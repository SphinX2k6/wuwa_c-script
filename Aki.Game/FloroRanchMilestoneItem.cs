using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B95 RID: 7061
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchMilestoneItem : UiPanelBase
{
	// Token: 0x0600D23E RID: 53822 RVA: 0x003042DC File Offset: 0x003024DC
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

	// Token: 0x0600D23F RID: 53823 RVA: 0x003043A8 File Offset: 0x003025A8
	protected override void OnStart()
	{
		this.ProgressLayout = new GenericLayout<FloroRanchMilestoneRewardItem, FloroRanchMilestoneData>(base.GetHorizontalLayout(1), new Func<FloroRanchMilestoneRewardItem>(this.ProgressItemProxyCreate), null, false, true);
		this.ProgressBarWidth = base.GetSprite(4).GetWidth();
	}

	// Token: 0x0600D240 RID: 53824 RVA: 0x003043DD File Offset: 0x003025DD
	private FloroRanchMilestoneRewardItem ProgressItemProxyCreate()
	{
		return new FloroRanchMilestoneRewardItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x0600D241 RID: 53825 RVA: 0x003043F0 File Offset: 0x003025F0
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

	// Token: 0x04006058 RID: 24664
	protected GenericLayout<FloroRanchMilestoneRewardItem, FloroRanchMilestoneData> ProgressLayout;

	// Token: 0x04006059 RID: 24665
	protected float ProgressBarWidth;

	// Token: 0x0400605A RID: 24666
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x0400605B RID: 24667
	private const float REWARD_ITEM_WIDTH = 108f;

	// Token: 0x02008121 RID: 33057
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402A26A RID: 172650
		public const int TxtProgress = 0;

		// Token: 0x0402A26B RID: 172651
		public const int ProgressLayout = 1;

		// Token: 0x0402A26C RID: 172652
		public const int ProgressItem = 2;

		// Token: 0x0402A26D RID: 172653
		public const int DotStart = 3;

		// Token: 0x0402A26E RID: 172654
		public const int BarProgress = 4;
	}
}
