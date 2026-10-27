using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Presenter
{
	// Token: 0x0200686D RID: 26733
	[NullableContext(1)]
	[Nullable(0)]
	public class BagHighlightPresenter
	{
		// Token: 0x06042C22 RID: 273442 RVA: 0x0103F873 File Offset: 0x0103DA73
		public BagHighlightPresenter(ActivityDangoBrawlData data, DropResolver resolver)
		{
			this.Data = data;
			this.Resolver = resolver;
		}

		// Token: 0x06042C23 RID: 273443 RVA: 0x0103F88C File Offset: 0x0103DA8C
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

		// Token: 0x06042C24 RID: 273444 RVA: 0x0103FA38 File Offset: 0x0103DC38
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

		// Token: 0x06042C25 RID: 273445 RVA: 0x0103FAD1 File Offset: 0x0103DCD1
		public void Clear()
		{
			IDangoBrawlBagDropZoneExtra lastHighlightedSink = this.LastHighlightedSink;
			if (lastHighlightedSink != null)
			{
				lastHighlightedSink.ClearHighlight();
			}
			this.LastHighlightedSink = null;
		}

		// Token: 0x04022C09 RID: 142345
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022C0A RID: 142346
		private readonly DropResolver Resolver;

		// Token: 0x04022C0B RID: 142347
		[Nullable(2)]
		private IDangoBrawlBagDropZoneExtra LastHighlightedSink;
	}
}
