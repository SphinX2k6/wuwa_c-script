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
	// Token: 0x02005E6E RID: 24174
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotLineComponent : UiPanelBase
	{
		// Token: 0x0603D795 RID: 251797 RVA: 0x00ED5BD8 File Offset: 0x00ED3DD8
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

		// Token: 0x0603D796 RID: 251798 RVA: 0x00ED5D4C File Offset: 0x00ED3F4C
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

		// Token: 0x0603D797 RID: 251799 RVA: 0x00ED5E48 File Offset: 0x00ED4048
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

		// Token: 0x0603D798 RID: 251800 RVA: 0x00ED5E94 File Offset: 0x00ED4094
		public void RecycleDebugLine()
		{
			foreach (UUI2DLineRaw uui2DLineRaw in this.DebugLines)
			{
				uui2DLineRaw.SetUIActive(false);
				this.DebugLinesPool.Add(uui2DLineRaw);
			}
			this.DebugLines.Clear();
		}

		// Token: 0x0603D799 RID: 251801 RVA: 0x00ED5F00 File Offset: 0x00ED4100
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

		// Token: 0x0603D79A RID: 251802 RVA: 0x00ED5F4B File Offset: 0x00ED414B
		public void ResetCircleId()
		{
			this.CurrentCircleId = 0;
		}

		// Token: 0x0603D79B RID: 251803 RVA: 0x00ED5F54 File Offset: 0x00ED4154
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

		// Token: 0x04020148 RID: 131400
		public UUIItem StartPoint;

		// Token: 0x04020149 RID: 131401
		public UUIItem EndPoint;

		// Token: 0x0402014A RID: 131402
		public UUIItem PlayerToStartLine;

		// Token: 0x0402014B RID: 131403
		public UUIItem EndToTargetLine;

		// Token: 0x0402014C RID: 131404
		public UUIItem PlayerToTargetLine;

		// Token: 0x0402014D RID: 131405
		public UUI2DLineRaw FindPathHighLightLine;

		// Token: 0x0402014E RID: 131406
		public UUIItem FindPathRoot;

		// Token: 0x0402014F RID: 131407
		public UUIItem CirclePathRoot;

		// Token: 0x04020150 RID: 131408
		[Nullable(1)]
		private readonly Dictionary<int, UUIItem> CirclePathHighLightLine = new Dictionary<int, UUIItem>();

		// Token: 0x04020151 RID: 131409
		public UUI2DLineRaw PathToCircleHighLightLine;

		// Token: 0x04020152 RID: 131410
		public UUIItem DebugPathRoot;

		// Token: 0x04020153 RID: 131411
		[Nullable(1)]
		private const string DebugLineResPath = "/Game/Aki/UI/UIResources/UiWorldMap/Prefabs/UiItem_DebugHighLightLine.UiItem_DebugHighLightLine";

		// Token: 0x04020154 RID: 131412
		[Nullable(1)]
		private readonly List<UUI2DLineRaw> DebugLinesPool = new List<UUI2DLineRaw>();

		// Token: 0x04020155 RID: 131413
		[Nullable(1)]
		private readonly List<UUI2DLineRaw> DebugLines = new List<UUI2DLineRaw>();

		// Token: 0x04020156 RID: 131414
		[Nullable(1)]
		private readonly Stat StatsObject0 = Stat.Create("LoadCirclePathHighLightLine", "", "");

		// Token: 0x04020157 RID: 131415
		public int CurrentCircleId;

		// Token: 0x0200C1EF RID: 49647
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403A9BD RID: 240061
			PlayerToStartLine,
			// Token: 0x0403A9BE RID: 240062
			EndToTargetLine,
			// Token: 0x0403A9BF RID: 240063
			PlayerToTargetLine,
			// Token: 0x0403A9C0 RID: 240064
			FindPathHighLightLine,
			// Token: 0x0403A9C1 RID: 240065
			StartPoint,
			// Token: 0x0403A9C2 RID: 240066
			EndPoint,
			// Token: 0x0403A9C3 RID: 240067
			FindPathRoot,
			// Token: 0x0403A9C4 RID: 240068
			CirclePathRoot,
			// Token: 0x0403A9C5 RID: 240069
			PathToCircleHighLightLine,
			// Token: 0x0403A9C6 RID: 240070
			DebugPathRoot
		}
	}
}
