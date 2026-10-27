using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000F2C RID: 3884
[NullableContext(1)]
[Nullable(0)]
public class AchievementRewardItemView : UiTickViewBase
{
	// Token: 0x06006272 RID: 25202 RVA: 0x00134419 File Offset: 0x00132619
	public AchievementRewardItemView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x00134438 File Offset: 0x00132638
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

	// Token: 0x06006274 RID: 25204 RVA: 0x001344C2 File Offset: 0x001326C2
	protected override void OnStart()
	{
		this.Initialize();
		this.RefreshRewardItem();
	}

	// Token: 0x06006275 RID: 25205 RVA: 0x001344D0 File Offset: 0x001326D0
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

	// Token: 0x06006276 RID: 25206 RVA: 0x00134540 File Offset: 0x00132740
	private void Initialize()
	{
		this.RestTime = 0f;
		this.Layout = new GenericLayoutNew<CommonItemDropGrid>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemDropGrid>(this.InitItem), base.GetItem(1));
		if (ItemHintModel.Instance.IsAchievementItemRewardListEmpty)
		{
			return;
		}
		this.ItemRewardData = ItemHintModel.Instance.ShiftAchievementItemRewardListFirst();
		this.ItemRewardInfoList = ItemHintController.Instance.CombineAllShowItems(this.ItemRewardData.ItemReward, true).ToList<ItemRewardInfo>();
		this.DropShowPlan = ItemHintController.Instance.GetFirstShowBgDropGroup(this.ItemRewardData.ItemReward);
		string title = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(this.ItemRewardData.ItemReward.DropId).Value.Title;
		LguiUtil.Instance.SetLocalText(base.GetText(2), StringUtils.IsEmpty(title) ? "MiddleRequirementDefault" : title, Array.Empty<object>());
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x00134628 File Offset: 0x00132828
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

	// Token: 0x06006278 RID: 25208 RVA: 0x001346D7 File Offset: 0x001328D7
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
		this.ItemRewardData = null;
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x001346EB File Offset: 0x001328EB
	protected override void OnAfterPlayStartSequence()
	{
		this.SetResetTime();
	}

	// Token: 0x0600627A RID: 25210 RVA: 0x001346F4 File Offset: 0x001328F4
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

	// Token: 0x0600627B RID: 25211 RVA: 0x00134794 File Offset: 0x00132994
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

	// Token: 0x04002CAA RID: 11434
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CommonItemDropGrid> Layout;

	// Token: 0x04002CAB RID: 11435
	[Nullable(2)]
	private ItemRewardData ItemRewardData;

	// Token: 0x04002CAC RID: 11436
	private DropShowPlan? DropShowPlan;

	// Token: 0x04002CAD RID: 11437
	private float RestTime = -1f;

	// Token: 0x04002CAE RID: 11438
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ItemRewardInfo> ItemRewardInfoList;

	// Token: 0x04002CAF RID: 11439
	private List<UniTask> PromiseList = new List<UniTask>();

	// Token: 0x04002CB0 RID: 11440
	private const int MAX_LENGTH = 3;

	// Token: 0x04002CB1 RID: 11441
	public float TickDelta;

	// Token: 0x02007574 RID: 30068
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04026D53 RID: 159059
		ItemHorizontal,
		// Token: 0x04026D54 RID: 159060
		SourceItemGrid,
		// Token: 0x04026D55 RID: 159061
		TxtTitle
	}
}
