using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057AB RID: 22443
	[NullableContext(1)]
	[Nullable(0)]
	public class DropResolver
	{
		// Token: 0x060376A0 RID: 226976 RVA: 0x00F7ACFD File Offset: 0x00F78EFD
		public void RegisterZone(DangoBrawlDropZone zone)
		{
			this.DropZones[zone.Kind] = zone;
		}

		// Token: 0x060376A1 RID: 226977 RVA: 0x00F7AD11 File Offset: 0x00F78F11
		public void UnregisterZone(EDragTargetKind kind)
		{
			this.DropZones.Remove(kind);
		}

		// Token: 0x060376A2 RID: 226978 RVA: 0x00F7AD20 File Offset: 0x00F78F20
		public void Start()
		{
		}

		// Token: 0x060376A3 RID: 226979 RVA: 0x00F7AD22 File Offset: 0x00F78F22
		public void Stop()
		{
			this.DropZones.Clear();
		}

		// Token: 0x060376A4 RID: 226980 RVA: 0x00F7AD30 File Offset: 0x00F78F30
		[NullableContext(2)]
		public DangoBrawlDropZone GetZone(EDragTargetKind kind)
		{
			DangoBrawlDropZone result;
			if (!this.DropZones.TryGetValue(kind, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060376A5 RID: 226981 RVA: 0x00F7AD50 File Offset: 0x00F78F50
		[NullableContext(2)]
		public IDangoBrawlBenchDropZoneExtra GetBenchDropZoneExtra()
		{
			DangoBrawlDropZone dangoBrawlDropZone;
			if (!this.DropZones.TryGetValue(EDragTargetKind.Bench, out dangoBrawlDropZone))
			{
				return null;
			}
			return dangoBrawlDropZone.BenchExtra;
		}

		// Token: 0x060376A6 RID: 226982 RVA: 0x00F7AD78 File Offset: 0x00F78F78
		public static bool IsPointInItem(UUIItem item, FVector2D lguiPos)
		{
			if (!item.IsValid())
			{
				return false;
			}
			ValueTuple<float, float, float, float> uiBounds = DangoBrawlUtil.GetUiBounds(item);
			return lguiPos.X >= uiBounds.Item1 && lguiPos.X <= uiBounds.Item2 && lguiPos.Y >= uiBounds.Item4 && lguiPos.Y <= uiBounds.Item3;
		}

		// Token: 0x060376A7 RID: 226983 RVA: 0x00F7ADD4 File Offset: 0x00F78FD4
		[return: Nullable(2)]
		public DragTarget Resolve(IDragVisual visual, FVector pointerPos)
		{
			FVector2D fvector2D = DangoBrawlUtil.PointerToItemCenter(DangoBrawlUtil.PointerToLgui(pointerPos), visual.DragAnchorOffset);
			foreach (DangoBrawlDropZone dangoBrawlDropZone in this.DropZones.Values)
			{
				if (DropResolver.IsPointInItem(dangoBrawlDropZone.HitItem, fvector2D))
				{
					switch (dangoBrawlDropZone.Kind)
					{
					case EDragTargetKind.Shop:
						return new DragTarget
						{
							Kind = EDragTargetKind.Shop
						};
					case EDragTargetKind.Bag:
						return this.MakeBagTarget(dangoBrawlDropZone, visual, fvector2D);
					case EDragTargetKind.Bench:
						return DropResolver.MakeBenchTarget(dangoBrawlDropZone, visual, fvector2D);
					default:
						return null;
					}
				}
			}
			return null;
		}

		// Token: 0x060376A8 RID: 226984 RVA: 0x00F7AE94 File Offset: 0x00F79094
		[return: Nullable(2)]
		private DragTarget MakeBagTarget(DangoBrawlDropZone zone, IDragVisual visual, FVector2D centerLgui)
		{
			PanelPos? panelPos = DropResolver.SnapBagLeftTopByPointer(zone.BagExtra, visual, centerLgui);
			if (panelPos == null)
			{
				return null;
			}
			return new DragTarget
			{
				Kind = EDragTargetKind.Bag,
				Bag = new DragTargetBag?(new DragTargetBag
				{
					LeftTopPos = panelPos.Value,
					Rotate = DropResolver.GetVisualRotate(visual)
				})
			};
		}

		// Token: 0x060376A9 RID: 226985 RVA: 0x00F7AEF8 File Offset: 0x00F790F8
		private static DragTarget MakeBenchTarget(DangoBrawlDropZone zone, IDragVisual visual, FVector2D centerLgui)
		{
			EDangoBrawlRotate benchDisplayRotate = DangoBrawlUtil.GetBenchDisplayRotate(visual.ConfigId, visual.Rotate);
			UUIItem draggableRootItem = visual.DraggableItem.GetDraggableRootItem();
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(visual.ConfigId, visual.Rotate));
			int item = boundSize.Item1;
			int item2 = boundSize.Item2;
			ValueTuple<int, int> boundSize2 = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(visual.ConfigId, benchDisplayRotate));
			int item3 = boundSize2.Item1;
			float item4 = (float)boundSize2.Item2;
			float num = (item2 > 0) ? (draggableRootItem.GetWidth() / (float)item2) : draggableRootItem.GetWidth();
			float num2 = (item > 0) ? (draggableRootItem.GetHeight() / (float)item) : draggableRootItem.GetHeight();
			float num3 = item4 * num;
			float num4 = (float)item3 * num2;
			float inX = centerLgui.X - num3 * 0.5f;
			float inY = centerLgui.Y + num4 * 0.5f;
			return new DragTarget
			{
				Kind = EDragTargetKind.Bench,
				Bench = new DragTargetBench?(new DragTargetBench
				{
					LguiPos = new FVector2D?(new FVector2D(inX, inY)),
					Rotate = benchDisplayRotate
				})
			};
		}

		// Token: 0x060376AA RID: 226986 RVA: 0x00F7B000 File Offset: 0x00F79200
		private static PanelPos? SnapBagLeftTopByPointer([Nullable(2)] IDangoBrawlBagDropZoneExtra sink, IDragVisual visual, FVector2D centerLgui)
		{
			if (sink == null)
			{
				return null;
			}
			UUIItem gridContainer = sink.GetGridContainer();
			if (gridContainer == null || !gridContainer.IsValid())
			{
				return null;
			}
			int num = 136;
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(visual.ConfigId, DropResolver.GetVisualRotate(visual)));
			int item = boundSize.Item1;
			int num2 = boundSize.Item2 * num;
			int num3 = item * num;
			float num4 = centerLgui.X - (float)num2 * 0.5f;
			float num5 = centerLgui.Y + (float)num3 * 0.5f;
			FVector lguispaceAbsolutePosition = gridContainer.GetLGUISpaceAbsolutePosition();
			int colIndex = DangoBrawlUtil.SnapGridIndex(num4 - lguispaceAbsolutePosition.X, num);
			return new PanelPos?(new PanelPos(DangoBrawlUtil.SnapGridIndex(lguispaceAbsolutePosition.Y - num5, num), colIndex));
		}

		// Token: 0x060376AB RID: 226987 RVA: 0x00F7B0BD File Offset: 0x00F792BD
		private static EDangoBrawlRotate GetVisualRotate(IDragVisual visual)
		{
			if (visual.TemplateType != EDangoBrawlTemplateType.Bag && visual.TemplateType != EDangoBrawlTemplateType.Item)
			{
				return EDangoBrawlRotate.Direction0;
			}
			return visual.Rotate;
		}

		// Token: 0x0401D3FC RID: 119804
		private readonly Dictionary<EDragTargetKind, DangoBrawlDropZone> DropZones = new Dictionary<EDragTargetKind, DangoBrawlDropZone>();
	}
}
