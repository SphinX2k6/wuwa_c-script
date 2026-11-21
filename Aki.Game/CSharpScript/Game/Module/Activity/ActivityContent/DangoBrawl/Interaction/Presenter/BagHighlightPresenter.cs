using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Presenter
{
	// Token: 0x020057BD RID: 22461
	[NullableContext(1)]
	[Nullable(0)]
	public class BagHighlightPresenter
	{
		// Token: 0x06037779 RID: 227193 RVA: 0x00F80D53 File Offset: 0x00F7EF53
		public BagHighlightPresenter(ActivityDangoBrawlData data, DropResolver resolver)
		{
			this.Data = data;
			this.Resolver = resolver;
		}

		// Token: 0x0603777A RID: 227194 RVA: 0x00F80D6C File Offset: 0x00F7EF6C
		public void Update(IDragVisual visual, DragTarget target)
		{
			DangoBrawlDropZone zone = this.Resolver.GetZone(EDragTargetKind.Bag);
			if (((zone != null) ? zone.BagExtra : null) == null || target.Bag == null)
			{
				return;
			}
			if (this.LastHighlightedSink != null && this.LastHighlightedSink != zone.BagExtra)
			{
				this.LastHighlightedSink.ClearHighlight();
			}
			this.LastHighlightedSink = zone.BagExtra;
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (bagpackData == null)
			{
				return;
			}
			DangoBrawlPlacementResult dangoBrawlPlacementResult = DangoBrawlPlaceUtil.EvaluatePlan(bagpackData, visual, target.Bag.Value.LeftTopPos, target.Bag.Value.Rotate, true, false);
			if (dangoBrawlPlacementResult.PlacedCells.Length == 0)
			{
				return;
			}
			Dictionary<int, EDangoBrawlPlaceMode> dictionary = new Dictionary<int, EDangoBrawlPlaceMode>();
			foreach (DangoBrawlFollowerVerdict dangoBrawlFollowerVerdict in dangoBrawlPlacementResult.FollowerVerdicts)
			{
				dictionary[dangoBrawlFollowerVerdict.Uid] = dangoBrawlFollowerVerdict.Mode;
			}
			HashSet<ValueTuple<int, int>> hashSet = new HashSet<ValueTuple<int, int>>();
			List<PanelPos> list = new List<PanelPos>(dangoBrawlPlacementResult.PlacedCells.Length);
			List<EDangoBrawlGridState> list2 = new List<EDangoBrawlGridState>(dangoBrawlPlacementResult.PlacedCells.Length);
			foreach (DangoBrawlPlacedCell dangoBrawlPlacedCell in dangoBrawlPlacementResult.PlacedCells)
			{
				if (hashSet.Add(new ValueTuple<int, int>(dangoBrawlPlacedCell.Pos.RowIndex, dangoBrawlPlacedCell.Pos.ColIndex)))
				{
					EDangoBrawlPlaceMode edangoBrawlPlaceMode2;
					EDangoBrawlPlaceMode edangoBrawlPlaceMode = dictionary.TryGetValue(dangoBrawlPlacedCell.OwnerUid, out edangoBrawlPlaceMode2) ? edangoBrawlPlaceMode2 : dangoBrawlPlacementResult.PrimaryMode;
					list.Add(dangoBrawlPlacedCell.Pos);
					list2.Add((edangoBrawlPlaceMode == EDangoBrawlPlaceMode.Direct) ? EDangoBrawlGridState.Success : EDangoBrawlGridState.Fail);
				}
			}
			zone.BagExtra.HighlightGrids(list.ToArray(), list2.ToArray());
		}

		// Token: 0x0603777B RID: 227195 RVA: 0x00F80F18 File Offset: 0x00F7F118
		public void UpdateFromPointer(IDragVisual visual, FVector pointerPos)
		{
			DangoBrawlDropZone zone = this.Resolver.GetZone(EDragTargetKind.Bag);
			if (((zone != null) ? zone.BagExtra : null) == null)
			{
				this.Clear();
				return;
			}
			FVector2D lguiPos = DangoBrawlUtil.PointerToItemCenter(DangoBrawlUtil.PointerToLgui(pointerPos), visual.DragAnchorOffset);
			if (!DropResolver.IsPointInItem(zone.HitItem, lguiPos))
			{
				this.Clear();
				return;
			}
			DragTarget dragTarget = this.Resolver.Resolve(visual, pointerPos);
			if (dragTarget == null || dragTarget.Kind != EDragTargetKind.Bag || dragTarget.Bag == null)
			{
				zone.BagExtra.ClearHighlight();
				return;
			}
			this.Update(visual, dragTarget);
		}

		// Token: 0x0603777C RID: 227196 RVA: 0x00F80FB1 File Offset: 0x00F7F1B1
		public void Clear()
		{
			IDangoBrawlBagDropZoneExtra lastHighlightedSink = this.LastHighlightedSink;
			if (lastHighlightedSink != null)
			{
				lastHighlightedSink.ClearHighlight();
			}
			this.LastHighlightedSink = null;
		}

		// Token: 0x0401D466 RID: 119910
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D467 RID: 119911
		private readonly DropResolver Resolver;

		// Token: 0x0401D468 RID: 119912
		[Nullable(2)]
		private IDangoBrawlBagDropZoneExtra LastHighlightedSink;
	}
}
