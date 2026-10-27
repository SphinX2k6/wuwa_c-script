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

// Token: 0x020012DC RID: 4828
[NullableContext(1)]
[Nullable(0)]
public class MapTravelSubViewPhantomCollect : UiPanelBase, IMapTravelSubViewInterface
{
	// Token: 0x17000B76 RID: 2934
	// (get) Token: 0x06008527 RID: 34087 RVA: 0x001C4E03 File Offset: 0x001C3003
	// (set) Token: 0x06008528 RID: 34088 RVA: 0x001C4E0B File Offset: 0x001C300B
	public bool NeedDestroySelf { get; set; }

	// Token: 0x06008529 RID: 34089 RVA: 0x001C4E14 File Offset: 0x001C3014
	public MapTravelSubViewPhantomCollect(ActivityMapTravelData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x0600852A RID: 34090 RVA: 0x001C4E24 File Offset: 0x001C3024
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

	// Token: 0x0600852B RID: 34091 RVA: 0x001C4ED0 File Offset: 0x001C30D0
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.AreaLayoutList = new LoopScrollView<PhantomCardItem, int>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PhantomCardItem>(this.OnCreateItem), false);
	}

	// Token: 0x0600852C RID: 34092 RVA: 0x001C4F1E File Offset: 0x001C311E
	private PhantomCardItem OnCreateItem()
	{
		return new PhantomCardItem(this.ActivityBaseData);
	}

	// Token: 0x0600852D RID: 34093 RVA: 0x001C4F2C File Offset: 0x001C312C
	protected UniTask Refresh()
	{
		MapTravelSubViewPhantomCollect.<Refresh>d__12 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<MapTravelSubViewPhantomCollect.<Refresh>d__12>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600852E RID: 34094 RVA: 0x001C4F70 File Offset: 0x001C3170
	public UniTask PlayStartSequence()
	{
		MapTravelSubViewPhantomCollect.<PlayStartSequence>d__13 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewPhantomCollect.<PlayStartSequence>d__13>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600852F RID: 34095 RVA: 0x001C4FB4 File Offset: 0x001C31B4
	public UniTask PlayCloseSequence()
	{
		MapTravelSubViewPhantomCollect.<PlayCloseSequence>d__14 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewPhantomCollect.<PlayCloseSequence>d__14>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06008530 RID: 34096 RVA: 0x001C4FF8 File Offset: 0x001C31F8
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

	// Token: 0x04003BB4 RID: 15284
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003BB5 RID: 15285
	private LoopScrollView<PhantomCardItem, int> AreaLayoutList;

	// Token: 0x04003BB6 RID: 15286
	protected ActivityMapTravelData ActivityBaseData;

	// Token: 0x020078ED RID: 30957
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027D61 RID: 163169
		public const int LoopScrollView = 0;

		// Token: 0x04027D62 RID: 163170
		public const int CardItem = 1;

		// Token: 0x04027D63 RID: 163171
		public const int TxtTips = 2;

		// Token: 0x04027D64 RID: 163172
		public const int TxtCount = 3;
	}
}
