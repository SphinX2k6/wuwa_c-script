using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Skin.Tab.Weapon
{
	// Token: 0x02003B97 RID: 15255
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponSkinController : UiControllerBase
	{
		// Token: 0x06027170 RID: 160112 RVA: 0x00AEFC52 File Offset: 0x00AEDE52
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		}

		// Token: 0x06027171 RID: 160113 RVA: 0x00AEFC70 File Offset: 0x00AEDE70
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
		}

		// Token: 0x06027172 RID: 160114 RVA: 0x00AEFC8E File Offset: 0x00AEDE8E
		private void OnDataDone()
		{
			this.EquipSkinDataRequest();
		}

		// Token: 0x06027173 RID: 160115 RVA: 0x00AEFC98 File Offset: 0x00AEDE98
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

		// Token: 0x06027174 RID: 160116 RVA: 0x00AEFCDC File Offset: 0x00AEDEDC
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

		// Token: 0x06027175 RID: 160117 RVA: 0x00AEFDC4 File Offset: 0x00AEDFC4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.WeaponSkinAddNotify);
			Net.Instance.UnRegister(ENotifyMessageId.WeaponSkinUnLoadNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EntityEquipSkinChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EntityFlyEquipChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.WeaponSkinUpdateNotify);
		}

		// Token: 0x06027176 RID: 160118 RVA: 0x00AEFE24 File Offset: 0x00AEE024
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(equipSkinTakeOnResponse.ErrorCode, 26442, null, true, true);
			}, 0);
		}

		// Token: 0x06027177 RID: 160119 RVA: 0x00AEFE98 File Offset: 0x00AEE098
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(equipSkinUnLoadResponse.ErrorCode, 15525, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06027178 RID: 160120 RVA: 0x00AEFEE7 File Offset: 0x00AEE0E7
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

		// Token: 0x06027179 RID: 160121 RVA: 0x00AEFF04 File Offset: 0x00AEE104
		[NullableContext(2)]
		private void OnWeaponSkinUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			WeaponSkinUpdateNotify weaponSkinUpdateNotify = (WeaponSkinUpdateNotify)msg;
			WeaponSkinModel.Instance.RefreshUnlockSkinData(weaponSkinUpdateNotify.SkinIds);
		}

		// Token: 0x0602717A RID: 160122 RVA: 0x00AEFF28 File Offset: 0x00AEE128
		public void OpenWeaponSkinShowView(List<int> skinIdList)
		{
			WeaponSkinShowViewData weaponSkinShowViewData = new WeaponSkinShowViewData();
			weaponSkinShowViewData.SkinIdList = skinIdList;
			UiManager.Instance.OpenView(EUiViewName.WeaponSkinShowView, weaponSkinShowViewData, null);
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x0602717B RID: 160123 RVA: 0x00AEFF53 File Offset: 0x00AEE153
		public static WeaponSkinController Instance
		{
			get
			{
				return WeaponSkinController._Instance;
			}
		}

		// Token: 0x0602717C RID: 160124 RVA: 0x00AEFF5A File Offset: 0x00AEE15A
		public static WeaponSkinController GetOrCreateInstance()
		{
			if (WeaponSkinController._Instance == null)
			{
				WeaponSkinController.CreateInstance();
			}
			return WeaponSkinController._Instance;
		}

		// Token: 0x0602717D RID: 160125 RVA: 0x00AEFF6E File Offset: 0x00AEE16E
		public static bool CreateInstance()
		{
			if (WeaponSkinController._Instance != null)
			{
				return true;
			}
			WeaponSkinController._Instance = new WeaponSkinController();
			return true;
		}

		// Token: 0x0602717E RID: 160126 RVA: 0x00AEFF84 File Offset: 0x00AEE184
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602717F RID: 160127 RVA: 0x00AEFF86 File Offset: 0x00AEE186
		public static void ResetStaticDefaultValue()
		{
			WeaponSkinController._Instance = null;
		}

		// Token: 0x06027180 RID: 160128 RVA: 0x00AEFF8E File Offset: 0x00AEE18E
		static WeaponSkinController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeaponSkinController.CreateStaticDefaultValue), new Action(WeaponSkinController.ResetStaticDefaultValue));
		}

		// Token: 0x04015514 RID: 87316
		[Nullable(2)]
		private static WeaponSkinController _Instance;
	}
}
