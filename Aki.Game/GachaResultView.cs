using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C9D RID: 7325
[NullableContext(1)]
[Nullable(0)]
public class GachaResultView : GachaSceneView
{
	// Token: 0x0600DD0D RID: 56589 RVA: 0x003397D0 File Offset: 0x003379D0
	public GachaResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DD0E RID: 56590 RVA: 0x00339830 File Offset: 0x00337A30
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, this.NextBtn),
			new ValueTuple<int, Delegate>(6, this.OnClickShare)
		};
	}

	// Token: 0x0600DD0F RID: 56591 RVA: 0x00339940 File Offset: 0x00337B40
	protected override void OnAfterInitComponentsData()
	{
		IGachaViewOpenData gachaViewOpenData = this.OpenParam as IGachaViewOpenData;
		this.HideExtraReward = (gachaViewOpenData != null && gachaViewOpenData.ResultViewHideExtraReward);
	}

	// Token: 0x0600DD10 RID: 56592 RVA: 0x0033996C File Offset: 0x00337B6C
	protected override UniTask OnBeforeStartAsync()
	{
		GachaResultView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaResultView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD11 RID: 56593 RVA: 0x003399AF File Offset: 0x00337BAF
	protected override void OnBeforeShow()
	{
		BlackScreenController.Instance.RemoveBlackScreen("Close", "GachaSkip", "Default");
		this.RefreshShare();
	}

	// Token: 0x0600DD12 RID: 56594 RVA: 0x003399D0 File Offset: 0x00337BD0
	protected override void OnAfterShow()
	{
		KuroSdkController.Instance.TryOpenReview();
	}

	// Token: 0x0600DD13 RID: 56595 RVA: 0x003399DC File Offset: 0x00337BDC
	protected override void OnBeforeDestroy()
	{
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraAnimationManager.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "GachaResultView.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		MenuController.Instance.OpenAllFilter();
	}

	// Token: 0x0600DD14 RID: 56596 RVA: 0x00339A3C File Offset: 0x00337C3C
	protected override void AfterAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.RefreshShare));
	}

	// Token: 0x0600DD15 RID: 56597 RVA: 0x00339A5A File Offset: 0x00337C5A
	protected override void AfterRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.RefreshShare));
	}

	// Token: 0x0600DD16 RID: 56598 RVA: 0x00339A78 File Offset: 0x00337C78
	private void RefreshShare()
	{
		if (!ChannelController.Instance.CouldShare())
		{
			return;
		}
		global::GachaResult[] curGachaResult = GachaModel.Instance.CurGachaResult;
		int num;
		if (curGachaResult.Length == 1)
		{
			if (this.GetItemQuality(curGachaResult[0].Proto_GachaReward.ItemId) < 5)
			{
				return;
			}
			num = ((GachaConfig.Instance.GetItemIdType(curGachaResult[0].Proto_GachaReward.ItemId) == InventoryDefine.EItemDataType.WeaponItem) ? 4 : 3);
		}
		else
		{
			num = 5;
		}
		base.GetButton(6).RootUIComp.Get().SetUIActive(true);
		ShareReward? config = ConfigShareRewardById.GetConfig(num, true);
		if (config == null)
		{
			return;
		}
		bool flag = ChannelModel.Instance.CouldGetShareReward((EShareActionId)num);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Gacha;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "刷新分享按钮";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("showShareReward", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		base.GetItem(7).SetUIActive(flag);
		if (flag)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			foreach (KeyValuePair<int, int> keyValuePair in config.Value.Reward())
			{
				list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
			}
			ValueTuple<int, int> valueTuple2 = list[0];
			ShareRewardInfo shareRewardInfo = this.ShareRewardInfo;
			if (shareRewardInfo == null)
			{
				return;
			}
			shareRewardInfo.SetItemInfo(valueTuple2.Item1, valueTuple2.Item2);
		}
	}

	// Token: 0x0600DD17 RID: 56599 RVA: 0x00339BF0 File Offset: 0x00337DF0
	private int RewardItemSort(TItem a, TItem b)
	{
		int itemId = a.ItemData.ItemId;
		int itemId2 = b.ItemData.ItemId;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		int? num = (itemConfigData != null) ? new int?(itemConfigData.QualityId) : null;
		ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(itemId2);
		int? num2 = (itemConfigData2 != null) ? new int?(itemConfigData2.QualityId) : null;
		int? num3 = num;
		int? num4 = num2;
		if (num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null))
		{
			return itemId - itemId2;
		}
		return num2.Value - num.Value;
	}

	// Token: 0x0600DD18 RID: 56600 RVA: 0x00339CA0 File Offset: 0x00337EA0
	[NullableContext(2)]
	private void RefreshExtraReward(List<TItem> rewardArray)
	{
		if (rewardArray != null && rewardArray.Count > 0 && !this.HideExtraReward)
		{
			base.GetItem(0).SetUIActive(true);
			this.ExtraRewardLayout.RefreshByData(rewardArray.ToList<TItem>(), null, false);
			return;
		}
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x0600DD19 RID: 56601 RVA: 0x00339CF0 File Offset: 0x00337EF0
	[NullableContext(2)]
	private void RefreshAdditionalReward(List<TItem> rewardArray)
	{
		if (rewardArray != null && rewardArray.Count > 0 && !this.HideExtraReward)
		{
			base.GetItem(2).SetUIActive(true);
			this.AdditionalRewardLayout.RefreshByData(rewardArray.ToList<TItem>(), null, false);
			return;
		}
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600DD1A RID: 56602 RVA: 0x00339D40 File Offset: 0x00337F40
	public UniTask HandleMultiGacha(global::GachaResult[] dataList)
	{
		GachaResultView.<HandleMultiGacha>d__22 <HandleMultiGacha>d__;
		<HandleMultiGacha>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleMultiGacha>d__.<>4__this = this;
		<HandleMultiGacha>d__.dataList = dataList;
		<HandleMultiGacha>d__.<>1__state = -1;
		<HandleMultiGacha>d__.<>t__builder.Start<GachaResultView.<HandleMultiGacha>d__22>(ref <HandleMultiGacha>d__);
		return <HandleMultiGacha>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD1B RID: 56603 RVA: 0x00339D8C File Offset: 0x00337F8C
	private UniTask HandleSingleGacha(global::GachaResult data)
	{
		GachaResultView.<HandleSingleGacha>d__23 <HandleSingleGacha>d__;
		<HandleSingleGacha>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleSingleGacha>d__.<>4__this = this;
		<HandleSingleGacha>d__.data = data;
		<HandleSingleGacha>d__.<>1__state = -1;
		<HandleSingleGacha>d__.<>t__builder.Start<GachaResultView.<HandleSingleGacha>d__23>(ref <HandleSingleGacha>d__);
		return <HandleSingleGacha>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD1C RID: 56604 RVA: 0x00339DD8 File Offset: 0x00337FD8
	private void CoverRewardListToMap(IReadOnlyList<GachaReward> rewardList, Dictionary<int, int> rewardMap)
	{
		foreach (GachaReward reward in rewardList)
		{
			this.CoverRewardToMap(reward, rewardMap);
		}
	}

	// Token: 0x0600DD1D RID: 56605 RVA: 0x00339E24 File Offset: 0x00338024
	private void CoverRewardToMap(GachaReward reward, Dictionary<int, int> rewardMap)
	{
		int num2;
		int num = rewardMap.TryGetValue(reward.ItemId, out num2) ? num2 : 0;
		int value = reward.ItemCount + num;
		if (rewardMap.ContainsKey(reward.ItemId))
		{
			rewardMap[reward.ItemId] = value;
			return;
		}
		rewardMap.Add(reward.ItemId, value);
	}

	// Token: 0x0600DD1E RID: 56606 RVA: 0x00339E78 File Offset: 0x00338078
	[return: Nullable(2)]
	private List<TItem> CoverRewardMapToItemList(Dictionary<int, int> rewardMap)
	{
		if (rewardMap == null || rewardMap.Count == 0)
		{
			return null;
		}
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in rewardMap)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
			list.Add(item);
		}
		list.Sort(new Comparison<TItem>(this.RewardItemSort));
		return list;
	}

	// Token: 0x0600DD1F RID: 56607 RVA: 0x00339F08 File Offset: 0x00338108
	public int GetItemQuality(int itemId)
	{
		int result = 0;
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(itemId);
		if (itemIdType != InventoryDefine.EItemDataType.RoleItem)
		{
			if (itemIdType == InventoryDefine.EItemDataType.WeaponItem)
			{
				WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
				if (weaponConfigByItemId != null)
				{
					result = weaponConfigByItemId.Value.QualityId;
				}
			}
		}
		else
		{
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(itemId);
			if (roleInfoById != null)
			{
				result = roleInfoById.Value.QualityId;
			}
		}
		return result;
	}

	// Token: 0x0600DD20 RID: 56608 RVA: 0x00339F7C File Offset: 0x0033817C
	private GachaResultItemNew InitGachaResultItem()
	{
		return new GachaResultItemNew();
	}

	// Token: 0x0600DD21 RID: 56609 RVA: 0x00339F83 File Offset: 0x00338183
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600DD22 RID: 56610 RVA: 0x00339F8A File Offset: 0x0033818A
	[CompilerGenerated]
	internal static int <HandleMultiGacha>g__RevertType|22_0(InventoryDefine.EItemDataType type)
	{
		switch (type)
		{
		case InventoryDefine.EItemDataType.RoleItem:
			return 2;
		case InventoryDefine.EItemDataType.WeaponItem:
			return 1;
		}
		return 0;
	}

	// Token: 0x04006560 RID: 25952
	private bool HideExtraReward;

	// Token: 0x04006561 RID: 25953
	[Nullable(2)]
	private GachaResultItemNew SingleGachaResultItem;

	// Token: 0x04006562 RID: 25954
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaResultItemNew, global::GachaResult> GachaResultLayout;

	// Token: 0x04006563 RID: 25955
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ExtraRewardLayout;

	// Token: 0x04006564 RID: 25956
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> AdditionalRewardLayout;

	// Token: 0x04006565 RID: 25957
	[Nullable(2)]
	private ShareRewardInfo ShareRewardInfo;

	// Token: 0x04006566 RID: 25958
	private readonly Action NextBtn = delegate()
	{
		if (UiManager.Instance.IsViewHide(EUiViewName.GachaScanView) || UiManager.Instance.IsViewHide(EUiViewName.DrawMainView))
		{
			Log.Instance.Info(ELogModule.Gacha, ELogAuthor.LPH, "点击过快，之前界面仍未关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EventSystem.Instance.Emit(EEventName.CloseGachaSceneView);
	};

	// Token: 0x04006567 RID: 25959
	private readonly Action OnClickShare = delegate()
	{
		ChannelController.Instance.ShareGacha(GachaModel.Instance.CurGachaResult);
	};

	// Token: 0x02008278 RID: 33400
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A911 RID: 174353
		ExtraRewardRootItem,
		// Token: 0x0402A912 RID: 174354
		ExtraRewardGridLayout,
		// Token: 0x0402A913 RID: 174355
		AdditionalRewardRootItem,
		// Token: 0x0402A914 RID: 174356
		AdditionalRewardGridLayout,
		// Token: 0x0402A915 RID: 174357
		NextBtn,
		// Token: 0x0402A916 RID: 174358
		ContentRootItem,
		// Token: 0x0402A917 RID: 174359
		ShareBtn,
		// Token: 0x0402A918 RID: 174360
		ShareReward,
		// Token: 0x0402A919 RID: 174361
		ShareRewardTip
	}
}
