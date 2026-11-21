using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000790 RID: 1936
[NullableContext(1)]
[Nullable(0)]
public class MapTravelSubViewPhantomCollect : UiPanelBase, IMapTravelSubViewInterface
{
	// Token: 0x17000B96 RID: 2966
	// (get) Token: 0x060058C2 RID: 22722 RVA: 0x001CDC5F File Offset: 0x001CBE5F
	// (set) Token: 0x060058C3 RID: 22723 RVA: 0x001CDC67 File Offset: 0x001CBE67
	public bool NeedDestroySelf { get; set; }

	// Token: 0x060058C4 RID: 22724 RVA: 0x001CDC70 File Offset: 0x001CBE70
	public MapTravelSubViewPhantomCollect(ActivityMapTravelData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x060058C5 RID: 22725 RVA: 0x001CDC80 File Offset: 0x001CBE80
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060058C6 RID: 22726 RVA: 0x001CDD2C File Offset: 0x001CBF2C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.AreaLayoutList = new LoopScrollView<PhantomCardItem, int>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PhantomCardItem>(this.OnCreateItem), false);
	}

	// Token: 0x060058C7 RID: 22727 RVA: 0x001CDD7A File Offset: 0x001CBF7A
	private PhantomCardItem OnCreateItem()
	{
		return new PhantomCardItem(this.ActivityBaseData);
	}

	// Token: 0x060058C8 RID: 22728 RVA: 0x001CDD88 File Offset: 0x001CBF88
	protected UniTask Refresh()
	{
		MapTravelSubViewPhantomCollect.<Refresh>d__12 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<MapTravelSubViewPhantomCollect.<Refresh>d__12>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x060058C9 RID: 22729 RVA: 0x001CDDCC File Offset: 0x001CBFCC
	public UniTask PlayStartSequence()
	{
		MapTravelSubViewPhantomCollect.<PlayStartSequence>d__13 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewPhantomCollect.<PlayStartSequence>d__13>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060058CA RID: 22730 RVA: 0x001CDE10 File Offset: 0x001CC010
	public UniTask PlayCloseSequence()
	{
		MapTravelSubViewPhantomCollect.<PlayCloseSequence>d__14 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewPhantomCollect.<PlayCloseSequence>d__14>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060058CB RID: 22731 RVA: 0x001CDE54 File Offset: 0x001CC054
	private int SortItem(int a, int b)
	{
		PhantomGain value = ActivityMapTravelConfig.Instance.GetPhantomConfig(a).Value;
		PhantomGain value2 = ActivityMapTravelConfig.Instance.GetPhantomConfig(b).Value;
		if (value.Sort == value2.Sort)
		{
			return a - b;
		}
		return value.Sort - value2.Sort;
	}

	// Token: 0x04003C4C RID: 15436
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003C4D RID: 15437
	private LoopScrollView<PhantomCardItem, int> AreaLayoutList;

	// Token: 0x04003C4E RID: 15438
	protected ActivityMapTravelData ActivityBaseData;

	// Token: 0x02006A77 RID: 27255
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402308F RID: 143503
		public const int LoopScrollView = 0;

		// Token: 0x04023090 RID: 143504
		public const int CardItem = 1;

		// Token: 0x04023091 RID: 143505
		public const int TxtTips = 2;

		// Token: 0x04023092 RID: 143506
		public const int TxtCount = 3;
	}
}
