using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02002A30 RID: 10800
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SkinController : UiControllerBase
{
	// Token: 0x060167CB RID: 92107 RVA: 0x005B3330 File Offset: 0x005B1530
	public void OpenObtainSkinView(RewardItemData[] skinRewardList, RewardItemData[] otherRewardList)
	{
		SkinObtainViewData skinObtainViewData = new SkinObtainViewData();
		skinObtainViewData.ObtainSkinData = skinRewardList;
		skinObtainViewData.OtherRewardData = otherRewardList;
		UiManager.Instance.OpenView(EUiViewName.SkinObtainView, skinObtainViewData, null);
	}

	// Token: 0x060167CC RID: 92108 RVA: 0x005B3364 File Offset: 0x005B1564
	public void OpenObtainFlySkinView(RewardItemData[] skinRewardList, RewardItemData[] otherRewardList)
	{
		FlySkinObtainViewData flySkinObtainViewData = new FlySkinObtainViewData();
		flySkinObtainViewData.ObtainFlySkinData = skinRewardList.ToList<RewardItemData>();
		flySkinObtainViewData.OtherRewardData = otherRewardList.ToList<RewardItemData>();
		UiManager.Instance.OpenView(EUiViewName.FlySkinObtainView, flySkinObtainViewData, null);
	}

	// Token: 0x060167CD RID: 92109 RVA: 0x005B33A0 File Offset: 0x005B15A0
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

	// Token: 0x060167CE RID: 92110 RVA: 0x005B33F8 File Offset: 0x005B15F8
	public void OpenBuyRoleSkinPreviewDetailViewByRoleSkinData(List<RoleSkinData> roleSkinData)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.CreateByRoleSkinData(roleSkinData);
		skinBuyDetailViewData.SetPreviewTitle("RoleSkinPreviewTitle_Text");
		UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
	}

	// Token: 0x060167CF RID: 92111 RVA: 0x005B3428 File Offset: 0x005B1628
	public void OpenBuyRoleSkinPreviewDetailViewByActivityRoleSkinData(RoleSkinData[] roleSkinData, bool isFemale)
	{
		SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.CreateByRoleSkinData(roleSkinData.ToList<RoleSkinData>());
		skinBuyDetailViewData.SetPreviewTitle("RoleSkinPreviewTitle_Text");
		skinBuyDetailViewData.SetIsActivityReward(true);
		if (isFemale)
		{
			skinBuyDetailViewData.SetIndex(1);
		}
		UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
	}

	// Token: 0x060167D0 RID: 92112 RVA: 0x005B346E File Offset: 0x005B166E
	public void OpenSkinShowView(int skinId)
	{
		UiManager.Instance.OpenView(EUiViewName.SkinShowView, skinId, null);
	}

	// Token: 0x060167D1 RID: 92113 RVA: 0x005B3488 File Offset: 0x005B1688
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

	// Token: 0x060167D2 RID: 92114 RVA: 0x005B3518 File Offset: 0x005B1718
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

	// Token: 0x060167D3 RID: 92115 RVA: 0x005B35A0 File Offset: 0x005B17A0
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

	// Token: 0x060167D4 RID: 92116 RVA: 0x005B3679 File Offset: 0x005B1879
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x060167D5 RID: 92117 RVA: 0x005B3697 File Offset: 0x005B1897
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x060167D6 RID: 92118 RVA: 0x005B36B8 File Offset: 0x005B18B8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleSkinAddNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RoleSkinAddNotify roleSkinAddNotify = (RoleSkinAddNotify)msg;
			RoleSkinModel.Instance.UpdateUnlockRoleSkin(roleSkinAddNotify.SkinIds.ToList<int>());
			RoleSkinModel.Instance.UpdateWeaponSkinFirstWearRecord(roleSkinAddNotify.SkinIds.ToList<int>());
			RoleSkinModel.Instance.AddRoleSkinNewFlag(roleSkinAddNotify.SkinIds.ToList<int>());
		});
		Net.Instance.Register(ENotifyMessageId.RoleSkinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RoleSkinUpdateNotify roleSkinUpdateNotify = (RoleSkinUpdateNotify)msg;
			RoleSkinModel.Instance.UpdateUnlockRoleSkinDataFull(roleSkinUpdateNotify.SkinIds.ToList<int>());
			RoleSkinModel.Instance.UpdateWeaponSkinFirstWearRecord(roleSkinUpdateNotify.SkinIds.ToList<int>());
		});
	}

	// Token: 0x060167D7 RID: 92119 RVA: 0x005B3723 File Offset: 0x005B1923
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinUpdateNotify);
	}

	// Token: 0x060167D8 RID: 92120 RVA: 0x005B3745 File Offset: 0x005B1945
	private void OnLoadingNetDataDone()
	{
		SkinController.RoleSkinDataRequest();
	}

	// Token: 0x060167D9 RID: 92121 RVA: 0x005B374C File Offset: 0x005B194C
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
			RoleSkinModel.Instance.UpdateUnlockRoleSkin(roleSkinResponse.SkinIds.ToList<int>());
		}, 0);
	}

	// Token: 0x060167DA RID: 92122 RVA: 0x005B3790 File Offset: 0x005B1990
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

	// Token: 0x17001DD8 RID: 7640
	// (get) Token: 0x060167DB RID: 92123 RVA: 0x005B3881 File Offset: 0x005B1A81
	public static SkinController Instance
	{
		get
		{
			return SkinController._Instance;
		}
	}

	// Token: 0x060167DC RID: 92124 RVA: 0x005B3888 File Offset: 0x005B1A88
	public static SkinController GetOrCreateInstance()
	{
		if (SkinController._Instance == null)
		{
			SkinController.CreateInstance();
		}
		return SkinController._Instance;
	}

	// Token: 0x060167DD RID: 92125 RVA: 0x005B389C File Offset: 0x005B1A9C
	public static bool CreateInstance()
	{
		if (SkinController._Instance != null)
		{
			return true;
		}
		SkinController._Instance = new SkinController();
		return true;
	}

	// Token: 0x060167DE RID: 92126 RVA: 0x005B38B2 File Offset: 0x005B1AB2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060167DF RID: 92127 RVA: 0x005B38B4 File Offset: 0x005B1AB4
	public static void ResetStaticDefaultValue()
	{
		SkinController._Instance = null;
	}

	// Token: 0x060167E0 RID: 92128 RVA: 0x005B38BC File Offset: 0x005B1ABC
	static SkinController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkinController.CreateStaticDefaultValue), new Action(SkinController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A6F7 RID: 42743
	[Nullable(2)]
	private static SkinController _Instance;
}
