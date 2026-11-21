using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E53 RID: 20051
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotLineComponent : UiPanelBase
	{
		// Token: 0x06032725 RID: 206629 RVA: 0x00E27150 File Offset: 0x00E25350
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032726 RID: 206630 RVA: 0x00E272C4 File Offset: 0x00E254C4
		protected override void OnStart()
		{
			this.StartPoint = base.GetItem(4);
			this.EndPoint = base.GetItem(5);
			this.PlayerToStartLine = base.GetItem(0);
			UUIItem playerToStartLine = this.PlayerToStartLine;
			if (playerToStartLine != null)
			{
				playerToStartLine.SetColor(FColor.FromHex("65FFEBFF"));
			}
			this.EndToTargetLine = base.GetItem(1);
			this.PlayerToTargetLine = base.GetItem(2);
			UUIItem item = base.GetItem(3);
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUI2DLineRaw.StaticClass()) : null);
			}
			this.FindPathHighLightLine = (obj as UUI2DLineRaw);
			this.FindPathRoot = base.GetItem(6);
			this.CirclePathRoot = base.GetItem(7);
			UUIItem item2 = base.GetItem(8);
			object obj2;
			if (item2 == null)
			{
				obj2 = null;
			}
			else
			{
				AActor owner2 = item2.GetOwner();
				obj2 = ((owner2 != null) ? owner2.GetComponentByClass(UUI2DLineRaw.StaticClass()) : null);
			}
			this.PathToCircleHighLightLine = (obj2 as UUI2DLineRaw);
			this.DebugPathRoot = base.GetItem(9);
		}

		// Token: 0x06032727 RID: 206631 RVA: 0x00E273C0 File Offset: 0x00E255C0
		[NullableContext(1)]
		public UniTask CreateDebugRoadLine(TArray<FVector2D> points)
		{
			AutoPilotLineComponent.<CreateDebugRoadLine>d__19 <CreateDebugRoadLine>d__;
			<CreateDebugRoadLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDebugRoadLine>d__.<>4__this = this;
			<CreateDebugRoadLine>d__.points = points;
			<CreateDebugRoadLine>d__.<>1__state = -1;
			<CreateDebugRoadLine>d__.<>t__builder.Start<AutoPilotLineComponent.<CreateDebugRoadLine>d__19>(ref <CreateDebugRoadLine>d__);
			return <CreateDebugRoadLine>d__.<>t__builder.Task;
		}

		// Token: 0x06032728 RID: 206632 RVA: 0x00E2740C File Offset: 0x00E2560C
		public void RecycleDebugLine()
		{
			foreach (UUI2DLineRaw uui2DLineRaw in this.DebugLines)
			{
				uui2DLineRaw.SetUIActive(false);
				this.DebugLinesPool.Add(uui2DLineRaw);
			}
			this.DebugLines.Clear();
		}

		// Token: 0x06032729 RID: 206633 RVA: 0x00E27478 File Offset: 0x00E25678
		public UniTask LoadCirclePathHighLightLine(int circleId)
		{
			AutoPilotLineComponent.<LoadCirclePathHighLightLine>d__21 <LoadCirclePathHighLightLine>d__;
			<LoadCirclePathHighLightLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCirclePathHighLightLine>d__.<>4__this = this;
			<LoadCirclePathHighLightLine>d__.circleId = circleId;
			<LoadCirclePathHighLightLine>d__.<>1__state = -1;
			<LoadCirclePathHighLightLine>d__.<>t__builder.Start<AutoPilotLineComponent.<LoadCirclePathHighLightLine>d__21>(ref <LoadCirclePathHighLightLine>d__);
			return <LoadCirclePathHighLightLine>d__.<>t__builder.Task;
		}

		// Token: 0x0603272A RID: 206634 RVA: 0x00E274C3 File Offset: 0x00E256C3
		public void ResetCircleId()
		{
			this.CurrentCircleId = 0;
		}

		// Token: 0x0603272B RID: 206635 RVA: 0x00E274CC File Offset: 0x00E256CC
		protected override void OnBeforeDestroy()
		{
			foreach (UUI2DLineRaw uui2DLineRaw in this.DebugLines)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(uui2DLineRaw.GetOwner(), true);
			}
			foreach (UUI2DLineRaw uui2DLineRaw2 in this.DebugLinesPool)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(uui2DLineRaw2.GetOwner(), true);
			}
			foreach (UUIItem uuiitem in this.CirclePathHighLightLine.Values)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(uuiitem.GetOwner(), true);
			}
			this.DebugLinesPool.Clear();
			this.DebugLines.Clear();
			this.CirclePathHighLightLine.Clear();
			this.ResetCircleId();
		}

		// Token: 0x0401AC0F RID: 109583
		public UUIItem StartPoint;

		// Token: 0x0401AC10 RID: 109584
		public UUIItem EndPoint;

		// Token: 0x0401AC11 RID: 109585
		public UUIItem PlayerToStartLine;

		// Token: 0x0401AC12 RID: 109586
		public UUIItem EndToTargetLine;

		// Token: 0x0401AC13 RID: 109587
		public UUIItem PlayerToTargetLine;

		// Token: 0x0401AC14 RID: 109588
		public UUI2DLineRaw FindPathHighLightLine;

		// Token: 0x0401AC15 RID: 109589
		public UUIItem FindPathRoot;

		// Token: 0x0401AC16 RID: 109590
		public UUIItem CirclePathRoot;

		// Token: 0x0401AC17 RID: 109591
		[Nullable(1)]
		private readonly Dictionary<int, UUIItem> CirclePathHighLightLine = new Dictionary<int, UUIItem>();

		// Token: 0x0401AC18 RID: 109592
		public UUI2DLineRaw PathToCircleHighLightLine;

		// Token: 0x0401AC19 RID: 109593
		public UUIItem DebugPathRoot;

		// Token: 0x0401AC1A RID: 109594
		[Nullable(1)]
		private const string DebugLineResPath = "/Game/Aki/UI/UIResources/UiWorldMap/Prefabs/UiItem_DebugHighLightLine.UiItem_DebugHighLightLine";

		// Token: 0x0401AC1B RID: 109595
		[Nullable(1)]
		private readonly List<UUI2DLineRaw> DebugLinesPool = new List<UUI2DLineRaw>();

		// Token: 0x0401AC1C RID: 109596
		[Nullable(1)]
		private readonly List<UUI2DLineRaw> DebugLines = new List<UUI2DLineRaw>();

		// Token: 0x0401AC1D RID: 109597
		[Nullable(1)]
		private readonly Stat StatsObject0 = Stat.Create("LoadCirclePathHighLightLine", "", "");

		// Token: 0x0401AC1E RID: 109598
		public int CurrentCircleId;

		// Token: 0x0200ABFE RID: 44030
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040353AF RID: 218031
			PlayerToStartLine,
			// Token: 0x040353B0 RID: 218032
			EndToTargetLine,
			// Token: 0x040353B1 RID: 218033
			PlayerToTargetLine,
			// Token: 0x040353B2 RID: 218034
			FindPathHighLightLine,
			// Token: 0x040353B3 RID: 218035
			StartPoint,
			// Token: 0x040353B4 RID: 218036
			EndPoint,
			// Token: 0x040353B5 RID: 218037
			FindPathRoot,
			// Token: 0x040353B6 RID: 218038
			CirclePathRoot,
			// Token: 0x040353B7 RID: 218039
			PathToCircleHighLightLine,
			// Token: 0x040353B8 RID: 218040
			DebugPathRoot
		}
	}
}
