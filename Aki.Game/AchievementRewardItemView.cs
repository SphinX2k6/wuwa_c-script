using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020003E1 RID: 993
[NullableContext(1)]
[Nullable(0)]
public class AchievementRewardItemView : UiTickViewBase
{
	// Token: 0x0600360A RID: 13834 RVA: 0x0013CD41 File Offset: 0x0013AF41
	public AchievementRewardItemView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600360B RID: 13835 RVA: 0x0013CD60 File Offset: 0x0013AF60
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600360C RID: 13836 RVA: 0x0013CDEA File Offset: 0x0013AFEA
	protected override void OnStart()
	{
		this.Initialize();
		this.RefreshRewardItem();
	}

	// Token: 0x0600360D RID: 13837 RVA: 0x0013CDF8 File Offset: 0x0013AFF8
	private ILayoutItem<CommonItemDropGrid> InitItem(object tempData, UUIItem uiItem, int index)
	{
		ItemRewardInfo itemRewardInfo = (ItemRewardInfo)tempData;
		CommonItemDropGrid commonItemDropGrid = new CommonItemDropGrid();
		commonItemDropGrid.Initialize(uiItem.GetOwner());
		this.PromiseList.Add(commonItemDropGrid.AsyncRefreshByItemInfo(itemRewardInfo.ItemId.Value, itemRewardInfo.ItemCount.Value, null));
		return new LayoutItem<CommonItemDropGrid>
		{
			Key = index,
			Value = commonItemDropGrid
		};
	}

	// Token: 0x0600360E RID: 13838 RVA: 0x0013CE68 File Offset: 0x0013B068
	private void Initialize()
	{
		this.RestTime = 0f;
		this.Layout = new GenericLayoutNew<CommonItemDropGrid>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemDropGrid>(this.InitItem), base.GetItem(1));
		if (ItemHintModel.Instance.IsAchievementItemRewardListEmpty)
		{
			return;
		}
		this.ItemRewardData = ItemHintModel.Instance.ShiftAchievementItemRewardListFirst();
		this.ItemRewardInfoList = new List<ItemRewardInfo>(ItemHintController.Instance.CombineAllShowItems(this.ItemRewardData.ItemReward, true));
		this.DropShowPlan = ItemHintController.Instance.GetFirstShowBgDropGroup(this.ItemRewardData.ItemReward);
		string title = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(this.ItemRewardData.ItemReward.DropId).Value.Title;
		LguiUtil.Instance.SetLocalText(base.GetText(2), StringUtils.IsEmpty(title) ? "MiddleRequirementDefault" : title, Array.Empty<object>());
	}

	// Token: 0x0600360F RID: 13839 RVA: 0x0013CF50 File Offset: 0x0013B150
	private void RefreshRewardItem()
	{
		this.PromiseList = new List<UniTask>();
		if (this.ItemRewardInfoList.Count <= 0)
		{
			this.RestTime = 0f;
			base.CloseMe(null);
			return;
		}
		base.SetUiActive(false);
		int count = Math.Min(this.ItemRewardInfoList.Count, 3);
		List<ItemRewardInfo> range = this.ItemRewardInfoList.GetRange(0, count);
		this.ItemRewardInfoList.RemoveRange(0, count);
		this.Layout.RebuildLayoutByDataNew<ItemRewardInfo>(range.ToArray(), null);
		UniTask.WhenAll(this.PromiseList).GetAwaiter().OnCompleted(delegate
		{
			base.SetUiActive(true);
		});
	}

	// Token: 0x06003610 RID: 13840 RVA: 0x0013CFFF File Offset: 0x0013B1FF
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
		this.ItemRewardData = null;
	}

	// Token: 0x06003611 RID: 13841 RVA: 0x0013D013 File Offset: 0x0013B213
	protected override void OnAfterPlayStartSequence()
	{
		this.SetResetTime();
	}

	// Token: 0x06003612 RID: 13842 RVA: 0x0013D01C File Offset: 0x0013B21C
	protected unsafe void SetResetTime()
	{
		int showTime = this.DropShowPlan.Value.ShowTime;
		if (showTime < 20)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ItemHint;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "AchievementRewardItemView ShowTime 小于100";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DropGroupId", this.DropShowPlan.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ShowTime", showTime);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.RestTime = (float)showTime;
	}

	// Token: 0x06003613 RID: 13843 RVA: 0x0013D0BC File Offset: 0x0013B2BC
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

	// Token: 0x04002D43 RID: 11587
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CommonItemDropGrid> Layout;

	// Token: 0x04002D44 RID: 11588
	[Nullable(2)]
	private ItemRewardData ItemRewardData;

	// Token: 0x04002D45 RID: 11589
	private DropShowPlan? DropShowPlan;

	// Token: 0x04002D46 RID: 11590
	private float RestTime = -1f;

	// Token: 0x04002D47 RID: 11591
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ItemRewardInfo> ItemRewardInfoList;

	// Token: 0x04002D48 RID: 11592
	private List<UniTask> PromiseList = new List<UniTask>();

	// Token: 0x04002D49 RID: 11593
	private const int MAX_LENGTH = 3;

	// Token: 0x04002D4A RID: 11594
	public float TickDelta;

	// Token: 0x02006708 RID: 26376
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402209E RID: 139422
		ItemHorizontal,
		// Token: 0x0402209F RID: 139423
		SourceItemGrid,
		// Token: 0x040220A0 RID: 139424
		TxtTitle
	}
}
