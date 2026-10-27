using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Skin.Tab.Weapon
{
	// Token: 0x02004BE6 RID: 19430
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponSkinController : UiControllerBase
	{
		// Token: 0x060323CC RID: 205772 RVA: 0x00BAB6B3 File Offset: 0x00BA98B3
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		}

		// Token: 0x060323CD RID: 205773 RVA: 0x00BAB6D1 File Offset: 0x00BA98D1
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		}

		// Token: 0x060323CE RID: 205774 RVA: 0x00BAB6EF File Offset: 0x00BA98EF
		private void OnDataDone()
		{
			this.EquipSkinDataRequest();
		}

		// Token: 0x060323CF RID: 205775 RVA: 0x00BAB6F8 File Offset: 0x00BA98F8
		private void EquipSkinDataRequest()
		{
			LoadEquipInfoRequest message = LoadEquipInfoRequest.Create();
			Net.Instance.Call(ERequestMessageId.LoadEquipInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				LoadEquipInfoResponse loadEquipInfoResponse = (LoadEquipInfoResponse)msg;
				if (loadEquipInfoResponse == null)
				{
					return;
				}
				WeaponSkinModel.Instance.NotifyWeaponSkinData(loadEquipInfoResponse.EquipList);
			}, 0);
		}

		// Token: 0x060323D0 RID: 205776 RVA: 0x00BAB73C File Offset: 0x00BA993C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.WeaponSkinAddNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				WeaponSkinAddNotify weaponSkinAddNotify = (WeaponSkinAddNotify)msg;
				if (weaponSkinAddNotify != null)
				{
					if (weaponSkinAddNotify.IsLogin)
					{
						WeaponSkinModel.Instance.NotifyAllUnlockSkinData(weaponSkinAddNotify.SkinIds);
						return;
					}
					WeaponSkinModel.Instance.SetUnlockSkinData(weaponSkinAddNotify.SkinIds);
				}
			});
			Net.Instance.Register(ENotifyMessageId.WeaponSkinUnLoadNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				WeaponSkinUnLoadNotify weaponSkinUnLoadNotify = (WeaponSkinUnLoadNotify)msg;
				if (weaponSkinUnLoadNotify != null)
				{
					WeaponSkinModel.Instance.DeleteWeaponSkinData(weaponSkinUnLoadNotify.RoleId);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WeaponSkin;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "武器皮肤卸载成功";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", weaponSkinUnLoadNotify.RoleId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			});
			Net.Instance.Register(ENotifyMessageId.EntityEquipSkinChangeNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				EntityEquipSkinChangeNotify entityEquipSkinChangeNotify = (EntityEquipSkinChangeNotify)msg;
				int num = (int)MathUtils.Instance.LongToNumber(entityEquipSkinChangeNotify.EntityId);
				CharacterWeaponComponent component = CreatureModel.Instance.GetEntity((long)num).Entity.GetComponent<CharacterWeaponComponent>();
				if (component == null)
				{
					return;
				}
				component.OnEntityEquipSkinChangeNotify(entityEquipSkinChangeNotify);
			});
			Net.Instance.Register(ENotifyMessageId.EntityFlyEquipChangeNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				foreach (EntityFlySkin entityFlySkin in ((EntityFlyEquipChangeNotify)msg).SkinChanges)
				{
					int num = (int)MathUtils.Instance.LongToNumber(entityFlySkin.EntityId);
					CharacterWeaponComponent component = CreatureModel.Instance.GetEntity((long)num).Entity.GetComponent<CharacterWeaponComponent>();
					if (component == null)
					{
						break;
					}
					component.OnEntitySoarWingOrParaglidingSkinChangeNotify(entityFlySkin);
				}
			});
			Net.Instance.Register(ENotifyMessageId.WeaponSkinUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWeaponSkinUpdateNotify));
		}

		// Token: 0x060323D1 RID: 205777 RVA: 0x00BAB824 File Offset: 0x00BA9A24
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.WeaponSkinAddNotify);
			Net.Instance.UnRegister(ENotifyMessageId.WeaponSkinUnLoadNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EntityEquipSkinChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EntityFlyEquipChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.WeaponSkinUpdateNotify);
		}

		// Token: 0x060323D2 RID: 205778 RVA: 0x00BAB884 File Offset: 0x00BA9A84
		private unsafe void SendEquipSkinTakeOnRequest(int roleId, int skinId)
		{
			EquipSkinTakeOnRequest equipSkinTakeOnRequest = EquipSkinTakeOnRequest.Create();
			equipSkinTakeOnRequest.Data = RoleSkinEquipData.Create();
			equipSkinTakeOnRequest.Data.RoleID = roleId;
			equipSkinTakeOnRequest.Data.SkinItemId = skinId;
			Net.Instance.Call(ERequestMessageId.EquipSkinTakeOnRequest, equipSkinTakeOnRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EquipSkinTakeOnResponse equipSkinTakeOnResponse = (EquipSkinTakeOnResponse)msg;
				if (equipSkinTakeOnResponse == null)
				{
					return;
				}
				if (equipSkinTakeOnResponse.ErrorCode == ErrorCode.Success)
				{
					WeaponSkinModel.Instance.EquipWeaponSkinData(equipSkinTakeOnResponse.DataList);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WeaponSkin;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "武器皮肤装备成功";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skinId", skinId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(equipSkinTakeOnResponse.ErrorCode, 24452, null, true, true);
			}, 0);
		}

		// Token: 0x060323D3 RID: 205779 RVA: 0x00BAB8F8 File Offset: 0x00BA9AF8
		private void SendEquipSkinUnLoadRequest(int roleId)
		{
			if (roleId <= 0)
			{
				return;
			}
			EquipSkinUnLoadRequest equipSkinUnLoadRequest = EquipSkinUnLoadRequest.Create();
			equipSkinUnLoadRequest.RoleID = roleId;
			Net.Instance.Call(ERequestMessageId.EquipSkinUnLoadRequest, equipSkinUnLoadRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EquipSkinUnLoadResponse equipSkinUnLoadResponse = (EquipSkinUnLoadResponse)msg;
				if (equipSkinUnLoadResponse == null)
				{
					return;
				}
				if (equipSkinUnLoadResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(equipSkinUnLoadResponse.ErrorCode, 16037, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060323D4 RID: 205780 RVA: 0x00BAB947 File Offset: 0x00BA9B47
		public void SendEquipSkinRequest(int roleId, int skinId)
		{
			if (roleId <= 0)
			{
				return;
			}
			if (skinId == -1)
			{
				this.SendEquipSkinUnLoadRequest(roleId);
				return;
			}
			this.SendEquipSkinTakeOnRequest(roleId, skinId);
		}

		// Token: 0x060323D5 RID: 205781 RVA: 0x00BAB964 File Offset: 0x00BA9B64
		[NullableContext(2)]
		private void OnWeaponSkinUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			WeaponSkinUpdateNotify weaponSkinUpdateNotify = (WeaponSkinUpdateNotify)msg;
			WeaponSkinModel.Instance.RefreshUnlockSkinData(weaponSkinUpdateNotify.SkinIds);
		}

		// Token: 0x060323D6 RID: 205782 RVA: 0x00BAB988 File Offset: 0x00BA9B88
		public void OpenWeaponSkinShowView(List<int> skinIdList)
		{
			WeaponSkinShowViewData weaponSkinShowViewData = new WeaponSkinShowViewData();
			weaponSkinShowViewData.SkinIdList = skinIdList;
			UiManager.Instance.OpenView(EUiViewName.WeaponSkinShowView, weaponSkinShowViewData, null);
		}

		// Token: 0x17007C6A RID: 31850
		// (get) Token: 0x060323D7 RID: 205783 RVA: 0x00BAB9B3 File Offset: 0x00BA9BB3
		public static WeaponSkinController Instance
		{
			get
			{
				return WeaponSkinController._Instance;
			}
		}

		// Token: 0x060323D8 RID: 205784 RVA: 0x00BAB9BA File Offset: 0x00BA9BBA
		public static WeaponSkinController GetOrCreateInstance()
		{
			if (WeaponSkinController._Instance == null)
			{
				WeaponSkinController.CreateInstance();
			}
			return WeaponSkinController._Instance;
		}

		// Token: 0x060323D9 RID: 205785 RVA: 0x00BAB9CE File Offset: 0x00BA9BCE
		public static bool CreateInstance()
		{
			if (WeaponSkinController._Instance != null)
			{
				return true;
			}
			WeaponSkinController._Instance = new WeaponSkinController();
			return true;
		}

		// Token: 0x060323DA RID: 205786 RVA: 0x00BAB9E4 File Offset: 0x00BA9BE4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060323DB RID: 205787 RVA: 0x00BAB9E6 File Offset: 0x00BA9BE6
		public static void ResetStaticDefaultValue()
		{
			WeaponSkinController._Instance = null;
		}

		// Token: 0x060323DC RID: 205788 RVA: 0x00BAB9EE File Offset: 0x00BA9BEE
		static WeaponSkinController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeaponSkinController.CreateStaticDefaultValue), new Action(WeaponSkinController.ResetStaticDefaultValue));
		}

		// Token: 0x0401ABB9 RID: 109497
		[Nullable(2)]
		private static WeaponSkinController _Instance;
	}
}
