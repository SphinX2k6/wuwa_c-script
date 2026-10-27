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
	// Token: 0x020044DC RID: 17628
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelSubViewQuest : UiPanelBase, IMapTravelSubViewInterface
	{
		// Token: 0x170073A6 RID: 29606
		// (get) Token: 0x0602D6AD RID: 186029 RVA: 0x00A4033A File Offset: 0x00A3E53A
		// (set) Token: 0x0602D6AE RID: 186030 RVA: 0x00A40342 File Offset: 0x00A3E542
		public bool NeedDestroySelf { get; set; } = true;

		// Token: 0x0602D6AF RID: 186031 RVA: 0x00A4034B File Offset: 0x00A3E54B
		public MapTravelSubViewQuest(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0602D6B0 RID: 186032 RVA: 0x00A40364 File Offset: 0x00A3E564
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

		// Token: 0x0602D6B1 RID: 186033 RVA: 0x00A403CD File Offset: 0x00A3E5CD
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.AreaLayoutList = new GenericScrollViewNew<AreaLayout, MapTravelAreaData>(base.GetScrollViewWithScrollbar(0), new Func<AreaLayout>(this.InitItem), null, false, null);
		}

		// Token: 0x0602D6B2 RID: 186034 RVA: 0x00A40404 File Offset: 0x00A3E604
		protected UniTask Refresh()
		{
			MapTravelSubViewQuest.<Refresh>d__10 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<MapTravelSubViewQuest.<Refresh>d__10>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6B3 RID: 186035 RVA: 0x00A40447 File Offset: 0x00A3E647
		private AreaLayout InitItem()
		{
			return new AreaLayout(this.ActivityBaseData);
		}

		// Token: 0x0602D6B4 RID: 186036 RVA: 0x00A40454 File Offset: 0x00A3E654
		public UniTask PlayStartSequence()
		{
			MapTravelSubViewQuest.<PlayStartSequence>d__12 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewQuest.<PlayStartSequence>d__12>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6B5 RID: 186037 RVA: 0x00A40498 File Offset: 0x00A3E698
		public UniTask PlayCloseSequence()
		{
			MapTravelSubViewQuest.<PlayCloseSequence>d__13 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewQuest.<PlayCloseSequence>d__13>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x170073A7 RID: 29607
		// (get) Token: 0x0602D6B6 RID: 186038 RVA: 0x00A404DB File Offset: 0x00A3E6DB
		// (set) Token: 0x0602D6B7 RID: 186039 RVA: 0x00A404E3 File Offset: 0x00A3E6E3
		protected ActivityMapTravelData ActivityBaseData { get; set; }

		// Token: 0x04018499 RID: 99481
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401849A RID: 99482
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<AreaLayout, MapTravelAreaData> AreaLayoutList;

		// Token: 0x0200A72E RID: 42798
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040327D0 RID: 206800
			public const int Layout = 0;

			// Token: 0x040327D1 RID: 206801
			public const int AreaLayoutItem = 1;
		}
	}
}
