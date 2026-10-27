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

// Token: 0x02002006 RID: 8198
[NullableContext(1)]
[Nullable(0)]
public class ItemRewardView : UiTickViewBase
{
	// Token: 0x0601013E RID: 65854 RVA: 0x003EAE0B File Offset: 0x003E900B
	public ItemRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601013F RID: 65855 RVA: 0x003EAE2C File Offset: 0x003E902C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06010140 RID: 65856 RVA: 0x003EAE86 File Offset: 0x003E9086
	protected override void OnStart()
	{
		this.Initialize();
		this.RefreshRewardItem();
	}

	// Token: 0x06010141 RID: 65857 RVA: 0x003EAE94 File Offset: 0x003E9094
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

	// Token: 0x06010142 RID: 65858 RVA: 0x003EAF04 File Offset: 0x003E9104
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

	// Token: 0x06010143 RID: 65859 RVA: 0x003EAFF0 File Offset: 0x003E91F0
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

	// Token: 0x06010144 RID: 65860 RVA: 0x003EB0AB File Offset: 0x003E92AB
	protected override void OnBeforeDestroy()
	{
		this.OpenNormal(false);
		this.Layout.ClearChildren();
		this.ItemRewardData = null;
	}

	// Token: 0x06010145 RID: 65861 RVA: 0x003EB0C6 File Offset: 0x003E92C6
	private void OpenNormal(bool isOpen)
	{
		if (this.ViewInfo.Name == EUiViewName.ItemRewardView)
		{
			return;
		}
		UiLayer.Instance.SetShowNormalMaskLayer(isOpen, "");
	}

	// Token: 0x06010146 RID: 65862 RVA: 0x003EB0F0 File Offset: 0x003E92F0
	protected override void OnAfterPlayStartSequence()
	{
		this.SetResetTime();
	}

	// Token: 0x06010147 RID: 65863 RVA: 0x003EB0F8 File Offset: 0x003E92F8
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

	// Token: 0x06010148 RID: 65864 RVA: 0x003EB194 File Offset: 0x003E9394
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

	// Token: 0x040076E7 RID: 30439
	private const int MAX_LENGTH = 3;

	// Token: 0x040076E8 RID: 30440
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CommonItemDropGrid> Layout;

	// Token: 0x040076E9 RID: 30441
	[Nullable(2)]
	private ItemRewardData ItemRewardData;

	// Token: 0x040076EA RID: 30442
	private DropShowPlan? DropShowPlan;

	// Token: 0x040076EB RID: 30443
	private float RestTime = -1f;

	// Token: 0x040076EC RID: 30444
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ItemRewardInfo[] ItemRewardInfoList;

	// Token: 0x040076ED RID: 30445
	private List<UniTask> PromiseList = new List<UniTask>();

	// Token: 0x040076EE RID: 30446
	public float TickDelta;

	// Token: 0x0200860F RID: 34319
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402BA11 RID: 178705
		ItemHorizontal,
		// Token: 0x0402BA12 RID: 178706
		SourceItemGrid,
		// Token: 0x0402BA13 RID: 178707
		TxtTitle
	}
}
