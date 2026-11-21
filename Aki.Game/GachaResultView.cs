using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200115C RID: 4444
[NullableContext(1)]
[Nullable(0)]
public class GachaResultView : GachaSceneView
{
	// Token: 0x0600B123 RID: 45347 RVA: 0x00344D18 File Offset: 0x00342F18
	public GachaResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B124 RID: 45348 RVA: 0x00344D78 File Offset: 0x00342F78
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

	// Token: 0x0600B125 RID: 45349 RVA: 0x00344E88 File Offset: 0x00343088
	protected override void OnAfterInitComponentsData()
	{
		IGachaViewOpenData gachaViewOpenData = this.OpenParam as IGachaViewOpenData;
		this.HideExtraReward = (gachaViewOpenData != null && gachaViewOpenData.ResultViewHideExtraReward);
	}

	// Token: 0x0600B126 RID: 45350 RVA: 0x00344EB4 File Offset: 0x003430B4
	protected override UniTask OnBeforeStartAsync()
	{
		GachaResultView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaResultView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B127 RID: 45351 RVA: 0x00344EF7 File Offset: 0x003430F7
	protected override void OnBeforeShow()
	{
		BlackScreenController.Instance.RemoveBlackScreen("Close", "GachaSkip", "Default");
		this.RefreshShare();
	}

	// Token: 0x0600B128 RID: 45352 RVA: 0x00344F18 File Offset: 0x00343118
	protected override void OnAfterShow()
	{
		KuroSdkController.Instance.TryOpenReview();
	}

	// Token: 0x0600B129 RID: 45353 RVA: 0x00344F24 File Offset: 0x00343124
	protected override void OnBeforeDestroy()
	{
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraModel.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "GachaResultView.OnBeforeDestroy", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		MenuController.Instance.OpenAllFilter();
	}

	// Token: 0x0600B12A RID: 45354 RVA: 0x00344F84 File Offset: 0x00343184
	protected override void AfterAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.RefreshShare));
	}

	// Token: 0x0600B12B RID: 45355 RVA: 0x00344FA2 File Offset: 0x003431A2
	protected override void AfterRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.RefreshShare));
	}

	// Token: 0x0600B12C RID: 45356 RVA: 0x00344FC0 File Offset: 0x003431C0
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

	// Token: 0x0600B12D RID: 45357 RVA: 0x00345138 File Offset: 0x00343338
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

	// Token: 0x0600B12E RID: 45358 RVA: 0x003451E5 File Offset: 0x003433E5
	[NullableContext(2)]
	private void RefreshExtraReward(List<TItem> rewardArray)
	{
		if (rewardArray != null && rewardArray.Count > 0 && !this.HideExtraReward)
		{
			base.GetItem(0).SetUIActive(true);
			this.ExtraRewardLayout.RefreshByData(rewardArray, null, false);
			return;
		}
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x0600B12F RID: 45359 RVA: 0x00345224 File Offset: 0x00343424
	[NullableContext(2)]
	private void RefreshAdditionalReward(List<TItem> rewardArray)
	{
		if (rewardArray != null && rewardArray.Count > 0 && !this.HideExtraReward)
		{
			base.GetItem(2).SetUIActive(true);
			this.AdditionalRewardLayout.RefreshByData(rewardArray, null, false);
			return;
		}
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600B130 RID: 45360 RVA: 0x00345264 File Offset: 0x00343464
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

	// Token: 0x0600B131 RID: 45361 RVA: 0x003452B0 File Offset: 0x003434B0
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

	// Token: 0x0600B132 RID: 45362 RVA: 0x003452FC File Offset: 0x003434FC
	private void CoverRewardListToMap(IReadOnlyList<GachaReward> rewardList, Dictionary<int, int> rewardMap)
	{
		foreach (GachaReward reward in rewardList)
		{
			this.CoverRewardToMap(reward, rewardMap);
		}
	}

	// Token: 0x0600B133 RID: 45363 RVA: 0x00345348 File Offset: 0x00343548
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

	// Token: 0x0600B134 RID: 45364 RVA: 0x0034539C File Offset: 0x0034359C
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

	// Token: 0x0600B135 RID: 45365 RVA: 0x0034542C File Offset: 0x0034362C
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

	// Token: 0x0600B136 RID: 45366 RVA: 0x003454A0 File Offset: 0x003436A0
	private GachaResultItemNew InitGachaResultItem()
	{
		return new GachaResultItemNew();
	}

	// Token: 0x0600B137 RID: 45367 RVA: 0x003454A7 File Offset: 0x003436A7
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600B138 RID: 45368 RVA: 0x003454AE File Offset: 0x003436AE
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

	// Token: 0x04006632 RID: 26162
	private bool HideExtraReward;

	// Token: 0x04006633 RID: 26163
	[Nullable(2)]
	private GachaResultItemNew SingleGachaResultItem;

	// Token: 0x04006634 RID: 26164
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaResultItemNew, global::GachaResult> GachaResultLayout;

	// Token: 0x04006635 RID: 26165
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ExtraRewardLayout;

	// Token: 0x04006636 RID: 26166
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> AdditionalRewardLayout;

	// Token: 0x04006637 RID: 26167
	[Nullable(2)]
	private ShareRewardInfo ShareRewardInfo;

	// Token: 0x04006638 RID: 26168
	private readonly Action NextBtn = delegate()
	{
		if (UiManager.Instance.IsViewHide(EUiViewName.GachaScanView) || UiManager.Instance.IsViewHide(EUiViewName.DrawMainView))
		{
			Log.Instance.Info(ELogModule.Gacha, ELogAuthor.LPH, "点击过快，之前界面仍未关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EventSystem.Instance.Emit(EEventName.CloseGachaSceneView);
	};

	// Token: 0x04006639 RID: 26169
	private readonly Action OnClickShare = delegate()
	{
		ChannelController.Instance.ShareGacha(GachaModel.Instance.CurGachaResult);
	};

	// Token: 0x020073FF RID: 29695
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025C30 RID: 154672
		ExtraRewardRootItem,
		// Token: 0x04025C31 RID: 154673
		ExtraRewardGridLayout,
		// Token: 0x04025C32 RID: 154674
		AdditionalRewardRootItem,
		// Token: 0x04025C33 RID: 154675
		AdditionalRewardGridLayout,
		// Token: 0x04025C34 RID: 154676
		NextBtn,
		// Token: 0x04025C35 RID: 154677
		ContentRootItem,
		// Token: 0x04025C36 RID: 154678
		ShareBtn,
		// Token: 0x04025C37 RID: 154679
		ShareReward,
		// Token: 0x04025C38 RID: 154680
		ShareRewardTip
	}
}
