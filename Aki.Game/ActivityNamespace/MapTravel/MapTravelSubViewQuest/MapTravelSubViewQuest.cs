using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewQuest
{
	// Token: 0x02002F69 RID: 12137
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelSubViewQuest : UiPanelBase, IMapTravelSubViewInterface
	{
		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0601CBEB RID: 117739 RVA: 0x008C5FA2 File Offset: 0x008C41A2
		// (set) Token: 0x0601CBEC RID: 117740 RVA: 0x008C5FAA File Offset: 0x008C41AA
		public bool NeedDestroySelf { get; set; } = true;

		// Token: 0x0601CBED RID: 117741 RVA: 0x008C5FB3 File Offset: 0x008C41B3
		public MapTravelSubViewQuest(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0601CBEE RID: 117742 RVA: 0x008C5FCC File Offset: 0x008C41CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601CBEF RID: 117743 RVA: 0x008C6035 File Offset: 0x008C4235
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.AreaLayoutList = new GenericScrollViewNew<AreaLayout, MapTravelAreaData>(base.GetScrollViewWithScrollbar(0), new Func<AreaLayout>(this.InitItem), null, false, null);
		}

		// Token: 0x0601CBF0 RID: 117744 RVA: 0x008C606C File Offset: 0x008C426C
		protected UniTask Refresh()
		{
			MapTravelSubViewQuest.<Refresh>d__10 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<MapTravelSubViewQuest.<Refresh>d__10>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBF1 RID: 117745 RVA: 0x008C60AF File Offset: 0x008C42AF
		private AreaLayout InitItem()
		{
			return new AreaLayout(this.ActivityBaseData);
		}

		// Token: 0x0601CBF2 RID: 117746 RVA: 0x008C60BC File Offset: 0x008C42BC
		public UniTask PlayStartSequence()
		{
			MapTravelSubViewQuest.<PlayStartSequence>d__12 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewQuest.<PlayStartSequence>d__12>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBF3 RID: 117747 RVA: 0x008C6100 File Offset: 0x008C4300
		public UniTask PlayCloseSequence()
		{
			MapTravelSubViewQuest.<PlayCloseSequence>d__13 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewQuest.<PlayCloseSequence>d__13>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0601CBF4 RID: 117748 RVA: 0x008C6143 File Offset: 0x008C4343
		// (set) Token: 0x0601CBF5 RID: 117749 RVA: 0x008C614B File Offset: 0x008C434B
		protected ActivityMapTravelData ActivityBaseData { get; set; }

		// Token: 0x0400F241 RID: 62017
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0400F242 RID: 62018
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<AreaLayout, MapTravelAreaData> AreaLayoutList;

		// Token: 0x02008C03 RID: 35843
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402C59B RID: 181659
			public const int Layout = 0;

			// Token: 0x0402C59C RID: 181660
			public const int AreaLayoutItem = 1;
		}
	}
}
