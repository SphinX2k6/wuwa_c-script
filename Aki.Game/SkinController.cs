using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001FAB RID: 8107
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SkinController : UiControllerBase
{
	// Token: 0x060141D4 RID: 82388 RVA: 0x005DE3F8 File Offset: 0x005DC5F8
	public void OpenObtainSkinView(RewardItemData[] skinRewardList, RewardItemData[] otherRewardList)
	{
		SkinObtainViewData skinObtainViewData = new SkinObtainViewData();
		skinObtainViewData.ObtainSkinData = skinRewardList;
		skinObtainViewData.OtherRewardData = otherRewardList;
		UiManager.Instance.OpenView(EUiViewName.SkinObtainView, skinObtainViewData, null);
	}

	// Token: 0x060141D5 RID: 82389 RVA: 0x005DE42C File Offset: 0x005DC62C
	public void OpenObtainFlySkinView(RewardItemData[] skinRewardList, RewardItemData[] otherRewardList)
	{
		FlySkinObtainViewData flySkinObtainViewData = new FlySkinObtainViewData();
		flySkinObtainViewData.ObtainFlySkinData = new List<RewardItemData>(skinRewardList);
		flySkinObtainViewData.OtherRewardData = new List<RewardItemData>(otherRewardList);
		UiManager.Instance.OpenView(EUiViewName.FlySkinObtainView, flySkinObtainViewData, null);
	}

	// Token: 0x060141D6 RID: 82390 RVA: 0x005DE468 File Offset: 0x005DC668
	public void OpenBuyRoleSkinDetailView(PayShopGoods[] payShopData)
	{
		List<ShopSkinData> list = new List<ShopSkinData>();
		for (int i = 0; i < payShopData.Length; i++)
		{
			ShopSkinData item = ShopSkinData.Create(payShopData[i]);
			list.Add(item);
		}
		SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.Create(list);
		skinBuyDetailViewData.SetPreviewTitle("RoleSkinShopTitle_Text");
		UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
	}

	// Token: 0x060141D7 RID: 82391 RVA: 0x005DE4C0 File Offset: 0x005DC6C0
	public void OpenBuyRoleSkinPreviewDetailViewByRoleSkinData(List<RoleSkinData> roleSkinData)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.CreateByRoleSkinData(roleSkinData);
		skinBuyDetailViewData.SetPreviewTitle("RoleSkinPreviewTitle_Text");
		UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
	}

	// Token: 0x060141D8 RID: 82392 RVA: 0x005DE4F0 File Offset: 0x005DC6F0
	public void OpenBuyRoleSkinPreviewDetailViewByActivityRoleSkinData(RoleSkinData[] roleSkinData, bool isFemale)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.CreateByRoleSkinData(new List<RoleSkinData>(roleSkinData));
		skinBuyDetailViewData.SetPreviewTitle("RoleSkinPreviewTitle_Text");
		skinBuyDetailViewData.SetIsActivityReward(true);
		if (isFemale)
		{
			skinBuyDetailViewData.SetIndex(1);
		}
		UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
	}

	// Token: 0x060141D9 RID: 82393 RVA: 0x005DE538 File Offset: 0x005DC738
	public unsafe void OpenSkinShowView(int skinId)
	{
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(skinId);
		if (roleSkinConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleSkin;
			ELogAuthor author = ELogAuthor.HMQ;
			string message = "[OpenSkinShowView] 无法打开Spine预览：角色皮肤配置缺失";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Table", "RoleSkin");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkinId", skinId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		RoleSpineButtonClickLogEvent roleSpineButtonClickLogEvent = new RoleSpineButtonClickLogEvent();
		roleSpineButtonClickLogEvent.i_role_id = roleSkinConfig.Value.RoleId;
		roleSpineButtonClickLogEvent.i_skin_id = skinId;
		LogReportController.Instance.LogReport(roleSpineButtonClickLogEvent);
		UiManager.Instance.OpenView(EUiViewName.SkinShowView, skinId, null);
	}

	// Token: 0x060141DA RID: 82394 RVA: 0x005DE600 File Offset: 0x005DC800
	public void OpenEquipBuffItemShowView(int itemId, bool optionIsFemale = false)
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		bool flag = (curSelectMainRoleId ?? 0) == 0;
		if (flag)
		{
			return;
		}
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(curSelectMainRoleId.Value);
		if (roleInstanceById == null)
		{
			return;
		}
		RoleSkinData roleSkinData = new RoleSkinData(roleInstanceById.GetRoleSkinId());
		EquipBuffItemDetailViewData equipBuffItemDetailViewData = new EquipBuffItemDetailViewData();
		equipBuffItemDetailViewData.RoleSkinData = roleSkinData;
		equipBuffItemDetailViewData.LoadFromItemId(itemId);
		BuffItemModel.Instance.SetCurrentPreviewItemData(itemId, curSelectMainRoleId.Value);
		UiManager.Instance.OpenView(EUiViewName.EquipBuffItemDetailView, equipBuffItemDetailViewData, null);
	}

	// Token: 0x060141DB RID: 82395 RVA: 0x005DE690 File Offset: 0x005DC890
	public void SkipToSkinView(int roleId, EUiTabViewName tabViewName, bool needLoadRole, int selectRoleSkinId = -1, TOpenViewCallBack finishCallback = null, int? selectFlySkinId = null, EFlySkinTab? flySkinTab = null)
	{
		WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true);
		if (!(weaponDataByRoleDataId is WeaponInstance))
		{
			return;
		}
		SkinViewData param = new SkinViewData
		{
			RoleId = roleId,
			WeaponId = (weaponDataByRoleDataId as WeaponInstance).GetIncId().Value,
			TabViewName = tabViewName,
			NeedLoadRole = needLoadRole,
			FlySkinId = selectFlySkinId,
			FlySkinTab = flySkinTab,
			SelectRoleSkinId = new int?(selectRoleSkinId)
		};
		UiManager.Instance.OpenView(EUiViewName.SkinRootView, param, finishCallback);
	}

	// Token: 0x060141DC RID: 82396 RVA: 0x005DE718 File Offset: 0x005DC918
	public void SkipToCalabashSkinView(int skinId)
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		bool flag = (curSelectMainRoleId ?? 0) == 0;
		if (flag)
		{
			return;
		}
		WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(curSelectMainRoleId.Value, true);
		if (!(weaponDataByRoleDataId is WeaponInstance))
		{
			return;
		}
		RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(curSelectMainRoleId.Value);
		int value = (roleSkinDataByRoleId != null) ? roleSkinDataByRoleId.GetItemId() : -1;
		SkinViewData param = new SkinViewData
		{
			RoleId = curSelectMainRoleId.Value,
			WeaponId = (weaponDataByRoleDataId as WeaponInstance).GetIncId().Value,
			TabViewName = EUiTabViewName.CalabashSkinTabView,
			NeedLoadRole = true,
			CalabashSkinId = new int?(skinId),
			SelectRoleSkinId = new int?(value)
		};
		UiManager.Instance.OpenView(EUiViewName.SkinRootView, param, null);
	}

	// Token: 0x060141DD RID: 82397 RVA: 0x005DE7F1 File Offset: 0x005DC9F1
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x060141DE RID: 82398 RVA: 0x005DE80F File Offset: 0x005DCA0F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x060141DF RID: 82399 RVA: 0x005DE830 File Offset: 0x005DCA30
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleSkinAddNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RoleSkinAddNotify roleSkinAddNotify = (RoleSkinAddNotify)msg;
			RoleSkinModel.Instance.UpdateUnlockRoleSkin(roleSkinAddNotify.SkinIds);
			RoleSkinModel.Instance.UpdateWeaponSkinFirstWearRecord(roleSkinAddNotify.SkinIds);
			RoleSkinModel.Instance.AddRoleSkinNewFlag(roleSkinAddNotify.SkinIds);
		});
		Net.Instance.Register(ENotifyMessageId.RoleSkinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RoleSkinUpdateNotify roleSkinUpdateNotify = (RoleSkinUpdateNotify)msg;
			RoleSkinModel.Instance.UpdateUnlockRoleSkinDataFull(roleSkinUpdateNotify.SkinIds);
			RoleSkinModel.Instance.UpdateWeaponSkinFirstWearRecord(roleSkinUpdateNotify.SkinIds);
		});
	}

	// Token: 0x060141E0 RID: 82400 RVA: 0x005DE89B File Offset: 0x005DCA9B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinUpdateNotify);
	}

	// Token: 0x060141E1 RID: 82401 RVA: 0x005DE8BD File Offset: 0x005DCABD
	private void OnLoadingNetDataDone()
	{
		SkinController.RoleSkinDataRequest();
	}

	// Token: 0x060141E2 RID: 82402 RVA: 0x005DE8C4 File Offset: 0x005DCAC4
	private static void RoleSkinDataRequest()
	{
		RoleSkinRequest message = RoleSkinRequest.Create();
		Net.Instance.Call(ERequestMessageId.RoleSkinRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RoleSkinResponse roleSkinResponse = (RoleSkinResponse)msg;
			if (roleSkinResponse == null)
			{
				return;
			}
			RoleSkinModel.Instance.UpdateUnlockRoleSkin(roleSkinResponse.SkinIds);
		}, 0);
	}

	// Token: 0x060141E3 RID: 82403 RVA: 0x005DE908 File Offset: 0x005DCB08
	public bool CheckCanWearSkinAndShowTip()
	{
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInFight_Text", Array.Empty<object>());
			return false;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.正常游泳"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInSwimming_Text", Array.Empty<object>());
			return false;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInClimbing_Text", Array.Empty<object>());
			return false;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionMidair_Text", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x17001E30 RID: 7728
	// (get) Token: 0x060141E4 RID: 82404 RVA: 0x005DE9F9 File Offset: 0x005DCBF9
	public static SkinController Instance
	{
		get
		{
			return SkinController._Instance;
		}
	}

	// Token: 0x060141E5 RID: 82405 RVA: 0x005DEA00 File Offset: 0x005DCC00
	public static SkinController GetOrCreateInstance()
	{
		if (SkinController._Instance == null)
		{
			SkinController.CreateInstance();
		}
		return SkinController._Instance;
	}

	// Token: 0x060141E6 RID: 82406 RVA: 0x005DEA14 File Offset: 0x005DCC14
	public static bool CreateInstance()
	{
		if (SkinController._Instance != null)
		{
			return true;
		}
		SkinController._Instance = new SkinController();
		return true;
	}

	// Token: 0x060141E7 RID: 82407 RVA: 0x005DEA2A File Offset: 0x005DCC2A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060141E8 RID: 82408 RVA: 0x005DEA2C File Offset: 0x005DCC2C
	public static void ResetStaticDefaultValue()
	{
		SkinController._Instance = null;
	}

	// Token: 0x060141E9 RID: 82409 RVA: 0x005DEA34 File Offset: 0x005DCC34
	static SkinController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkinController.CreateStaticDefaultValue), new Action(SkinController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AAE2 RID: 43746
	[Nullable(2)]
	private static SkinController _Instance;
}
