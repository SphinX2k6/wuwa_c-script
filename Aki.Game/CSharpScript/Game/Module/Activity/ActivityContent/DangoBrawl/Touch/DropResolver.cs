using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x0200685B RID: 26715
	[NullableContext(1)]
	[Nullable(0)]
	public class DropResolver
	{
		// Token: 0x06042B4B RID: 273227 RVA: 0x010397B1 File Offset: 0x010379B1
		public void RegisterZone(DangoBrawlDropZone zone)
		{
			this.DropZones[zone.Kind] = zone;
		}

		// Token: 0x06042B4C RID: 273228 RVA: 0x010397C5 File Offset: 0x010379C5
		public void UnregisterZone(EDragTargetKind kind)
		{
			this.DropZones.Remove(kind);
		}

		// Token: 0x06042B4D RID: 273229 RVA: 0x010397D4 File Offset: 0x010379D4
		public void Start()
		{
		}

		// Token: 0x06042B4E RID: 273230 RVA: 0x010397D6 File Offset: 0x010379D6
		public void Stop()
		{
			this.DropZones.Clear();
		}

		// Token: 0x06042B4F RID: 273231 RVA: 0x010397E4 File Offset: 0x010379E4
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

		// Token: 0x06042B50 RID: 273232 RVA: 0x01039804 File Offset: 0x01037A04
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

		// Token: 0x06042B51 RID: 273233 RVA: 0x0103982C File Offset: 0x01037A2C
		public static bool IsPointInItem(UUIItem item, FVector2D lguiPos)
		{
			if (!item.IsValid())
			{
				return false;
			}
			ValueTuple<float, float, float, float> uiBounds = DangoBrawlUtil.GetUiBounds(item);
			return lguiPos.X >= uiBounds.Item1 && lguiPos.X <= uiBounds.Item2 && lguiPos.Y >= uiBounds.Item4 && lguiPos.Y <= uiBounds.Item3;
		}

		// Token: 0x06042B52 RID: 273234 RVA: 0x01039888 File Offset: 0x01037A88
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

		// Token: 0x06042B53 RID: 273235 RVA: 0x01039948 File Offset: 0x01037B48
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

		// Token: 0x06042B54 RID: 273236 RVA: 0x010399AC File Offset: 0x01037BAC
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

		// Token: 0x06042B55 RID: 273237 RVA: 0x01039AB4 File Offset: 0x01037CB4
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

		// Token: 0x06042B56 RID: 273238 RVA: 0x01039B71 File Offset: 0x01037D71
		private static EDangoBrawlRotate GetVisualRotate(IDragVisual visual)
		{
			if (visual.TemplateType != EDangoBrawlTemplateType.Bag && visual.TemplateType != EDangoBrawlTemplateType.Item)
			{
				return EDangoBrawlRotate.Direction0;
			}
			return visual.Rotate;
		}

		// Token: 0x04022B9F RID: 142239
		private readonly Dictionary<EDragTargetKind, DangoBrawlDropZone> DropZones = new Dictionary<EDragTargetKind, DangoBrawlDropZone>();
	}
}
