using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001054 RID: 4180
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchMilestoneItem : UiPanelBase
{
	// Token: 0x0600A64F RID: 42575 RVA: 0x0030F3B4 File Offset: 0x0030D5B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A650 RID: 42576 RVA: 0x0030F480 File Offset: 0x0030D680
	protected override void OnStart()
	{
		this.ProgressLayout = new GenericLayout<FloroRanchMilestoneRewardItem, FloroRanchMilestoneData>(base.GetHorizontalLayout(1), new Func<FloroRanchMilestoneRewardItem>(this.ProgressItemProxyCreate), null, false, true);
		this.ProgressBarWidth = base.GetSprite(4).GetWidth();
	}

	// Token: 0x0600A651 RID: 42577 RVA: 0x0030F4B5 File Offset: 0x0030D6B5
	private FloroRanchMilestoneRewardItem ProgressItemProxyCreate()
	{
		return new FloroRanchMilestoneRewardItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x0600A652 RID: 42578 RVA: 0x0030F4C8 File Offset: 0x0030D6C8
	public UniTask RefreshProgressItem(float currentProgress, List<FloroRanchMilestoneData> dataList)
	{
		FloroRanchMilestoneItem.<RefreshProgressItem>d__8 <RefreshProgressItem>d__;
		<RefreshProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshProgressItem>d__.<>4__this = this;
		<RefreshProgressItem>d__.currentProgress = currentProgress;
		<RefreshProgressItem>d__.dataList = dataList;
		<RefreshProgressItem>d__.<>1__state = -1;
		<RefreshProgressItem>d__.<>t__builder.Start<FloroRanchMilestoneItem.<RefreshProgressItem>d__8>(ref <RefreshProgressItem>d__);
		return <RefreshProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x04006127 RID: 24871
	protected GenericLayout<FloroRanchMilestoneRewardItem, FloroRanchMilestoneData> ProgressLayout;

	// Token: 0x04006128 RID: 24872
	protected float ProgressBarWidth;

	// Token: 0x04006129 RID: 24873
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x0400612A RID: 24874
	private const float REWARD_ITEM_WIDTH = 108f;

	// Token: 0x020072AF RID: 29359
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402559E RID: 152990
		public const int TxtProgress = 0;

		// Token: 0x0402559F RID: 152991
		public const int ProgressLayout = 1;

		// Token: 0x040255A0 RID: 152992
		public const int ProgressItem = 2;

		// Token: 0x040255A1 RID: 152993
		public const int DotStart = 3;

		// Token: 0x040255A2 RID: 152994
		public const int BarProgress = 4;
	}
}
