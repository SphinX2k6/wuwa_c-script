using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020014D9 RID: 5337
[NullableContext(1)]
[Nullable(0)]
public class ItemRewardView : UiTickViewBase
{
	// Token: 0x0600D5A6 RID: 54694 RVA: 0x003F7403 File Offset: 0x003F5603
	public ItemRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D5A7 RID: 54695 RVA: 0x003F7424 File Offset: 0x003F5624
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600D5A8 RID: 54696 RVA: 0x003F747E File Offset: 0x003F567E
	protected override void OnStart()
	{
		this.Initialize();
		this.RefreshRewardItem();
	}

	// Token: 0x0600D5A9 RID: 54697 RVA: 0x003F748C File Offset: 0x003F568C
	private ILayoutItem<CommonItemDropGrid> InitItem(object tempData, UUIItem uiItem, int index)
	{
		ItemRewardInfo itemRewardInfo = tempData as ItemRewardInfo;
		CommonItemDropGrid commonItemDropGrid = new CommonItemDropGrid();
		commonItemDropGrid.Initialize(uiItem.GetOwner());
		this.PromiseList.Add(commonItemDropGrid.AsyncRefreshByItemInfo(itemRewardInfo.ItemId.Value, itemRewardInfo.ItemCount.Value, null));
		return new LayoutItem<CommonItemDropGrid>
		{
			Key = index,
			Value = commonItemDropGrid
		};
	}

	// Token: 0x0600D5AA RID: 54698 RVA: 0x003F74FC File Offset: 0x003F56FC
	private void Initialize()
	{
		this.RestTime = 0f;
		this.Layout = new GenericLayoutNew<CommonItemDropGrid>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemDropGrid>(this.InitItem), base.GetItem(1));
		this.OpenNormal(true);
		if (ItemHintModel.Instance.IsItemRewardListEmpty)
		{
			return;
		}
		this.ItemRewardData = ItemHintModel.Instance.ShiftItemRewardListFirst();
		this.ItemRewardInfoList = ItemHintController.Instance.CombineAllShowItems(this.ItemRewardData.ItemReward, true);
		this.DropShowPlan = ItemHintController.Instance.GetFirstShowBgDropGroup(this.ItemRewardData.ItemReward);
		string title = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(this.ItemRewardData.ItemReward.DropId).Value.Title;
		LguiUtil.Instance.SetLocalText(base.GetText(2), StringUtils.IsEmpty(title) ? "MiddleRequirementDefault" : title, Array.Empty<object>());
	}

	// Token: 0x0600D5AB RID: 54699 RVA: 0x003F75E8 File Offset: 0x003F57E8
	private void RefreshRewardItem()
	{
		this.PromiseList.Clear();
		if (this.ItemRewardInfoList.Length == 0)
		{
			this.RestTime = 0f;
			base.CloseMe(null);
			return;
		}
		base.SetUiActive(false);
		int num = Math.Min(this.ItemRewardInfoList.Length, 3);
		ItemRewardInfo[] array = new ItemRewardInfo[num];
		Array.Copy(this.ItemRewardInfoList, 0, array, 0, num);
		int num2 = this.ItemRewardInfoList.Length - num;
		ItemRewardInfo[] array2 = new ItemRewardInfo[num2];
		Array.Copy(this.ItemRewardInfoList, num, array2, 0, num2);
		this.ItemRewardInfoList = array2;
		this.Layout.RebuildLayoutByDataNew<ItemRewardInfo>(array, null);
		UniTask.WhenAll(this.PromiseList).ContinueWith(delegate()
		{
			base.SetUiActive(true);
		});
	}

	// Token: 0x0600D5AC RID: 54700 RVA: 0x003F76A3 File Offset: 0x003F58A3
	protected override void OnBeforeDestroy()
	{
		this.OpenNormal(false);
		this.Layout.ClearChildren();
		this.ItemRewardData = null;
	}

	// Token: 0x0600D5AD RID: 54701 RVA: 0x003F76BE File Offset: 0x003F58BE
	private void OpenNormal(bool isOpen)
	{
		if (this.ViewInfo.Name == EUiViewName.ItemRewardView)
		{
			return;
		}
		UiLayer.Instance.SetShowNormalMaskLayer(isOpen, "");
	}

	// Token: 0x0600D5AE RID: 54702 RVA: 0x003F76E8 File Offset: 0x003F58E8
	protected override void OnAfterPlayStartSequence()
	{
		this.SetResetTime();
	}

	// Token: 0x0600D5AF RID: 54703 RVA: 0x003F76F0 File Offset: 0x003F58F0
	protected unsafe void SetResetTime()
	{
		int showTime = this.DropShowPlan.Value.ShowTime;
		if (showTime < 20)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ItemHint;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "ItemRewardView ShowTime 小于100";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DropGroupId", this.DropShowPlan.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ShowTime", showTime);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.RestTime = (float)showTime;
	}

	// Token: 0x0600D5B0 RID: 54704 RVA: 0x003F778C File Offset: 0x003F598C
	protected override void OnTick(float delta)
	{
		if (this.RestTime <= 0f)
		{
			return;
		}
		this.TickDelta += delta;
		if (this.TickDelta >= this.RestTime)
		{
			this.TickDelta = 0f;
			this.RestTime = 0f;
			this.SetResetTime();
			this.RefreshRewardItem();
		}
	}

	// Token: 0x040077D0 RID: 30672
	private const int MAX_LENGTH = 3;

	// Token: 0x040077D1 RID: 30673
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CommonItemDropGrid> Layout;

	// Token: 0x040077D2 RID: 30674
	[Nullable(2)]
	private ItemRewardData ItemRewardData;

	// Token: 0x040077D3 RID: 30675
	private DropShowPlan? DropShowPlan;

	// Token: 0x040077D4 RID: 30676
	private float RestTime = -1f;

	// Token: 0x040077D5 RID: 30677
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ItemRewardInfo[] ItemRewardInfoList;

	// Token: 0x040077D6 RID: 30678
	private List<UniTask> PromiseList = new List<UniTask>();

	// Token: 0x040077D7 RID: 30679
	public float TickDelta;

	// Token: 0x02007796 RID: 30614
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04026D20 RID: 159008
		ItemHorizontal,
		// Token: 0x04026D21 RID: 159009
		SourceItemGrid,
		// Token: 0x04026D22 RID: 159010
		TxtTitle
	}
}
