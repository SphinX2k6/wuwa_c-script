using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Presenter;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky
{
	// Token: 0x0200686C RID: 26732
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlStickyCtrl
	{
		// Token: 0x06042C19 RID: 273433 RVA: 0x0103F4EB File Offset: 0x0103D6EB
		public DangoBrawlStickyCtrl(ActivityDangoBrawlData data, DropResolver resolver, InteractionStateMachine fsm, DangoBrawlPlatformState platformState, DangoBrawlInteractionModeCtrl modes, DangoBrawlSourceAdapterRegistry dangoBrawlSourceAdapters, BagHighlightPresenter highlight)
		{
			this.Fsm = fsm;
			this.Resolver = resolver;
			this.DangoBrawlSourceAdapters = dangoBrawlSourceAdapters;
			this.Data = data;
			this.Highlight = highlight;
			this.Modes = modes;
			this.PlatformState = platformState;
		}

		// Token: 0x06042C1A RID: 273434 RVA: 0x0103F528 File Offset: 0x0103D728
		public void TryEnterReplaceSticky([Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> abandonedFollowers, [Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> replacedItems)
		{
			if (!this.PlatformState.SupportsSticky)
			{
				return;
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = DangoBrawlStickyUtil.PickReplaceCandidate(abandonedFollowers, replacedItems, this.Modes.Layer.IsActive);
			if (dangoBrawlBackpackItemData == null)
			{
				return;
			}
			if (dangoBrawlBackpackItemData.MyUid <= 0)
			{
				return;
			}
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (((benchData != null) ? benchData.GetItem(dangoBrawlBackpackItemData.MyUid) : null) == null)
			{
				return;
			}
			IDragSourceAdapter dragSourceAdapter = this.DangoBrawlSourceAdapters.Get(EDragSourceKind.Bench);
			if (dragSourceAdapter == null)
			{
				return;
			}
			FVector currentPointerPos = DangoBrawlStickyCtrl.GetCurrentPointerPos();
			this.BeginStickyCore(dragSourceAdapter, dangoBrawlBackpackItemData.MyUid, currentPointerPos, new EDangoBrawlRotate?(dangoBrawlBackpackItemData.MyRotation)).Forget<bool>();
		}

		// Token: 0x06042C1B RID: 273435 RVA: 0x0103F5C0 File Offset: 0x0103D7C0
		public void UpdateMove(FVector pointerPos)
		{
			if (!this.Fsm.IsSticky())
			{
				return;
			}
			if (this.Placing)
			{
				return;
			}
			InteractionPayload payLoad = this.Fsm.GetPayLoad();
			if (payLoad == null)
			{
				return;
			}
			payLoad.Visual.MoveTo(DangoBrawlUtil.PointerToLgui(pointerPos));
			this.Highlight.UpdateFromPointer(payLoad.Visual, pointerPos);
		}

		// Token: 0x06042C1C RID: 273436 RVA: 0x0103F618 File Offset: 0x0103D818
		public UniTask Place(FVector pointerPos)
		{
			DangoBrawlStickyCtrl.<Place>d__11 <Place>d__;
			<Place>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Place>d__.<>4__this = this;
			<Place>d__.pointerPos = pointerPos;
			<Place>d__.<>1__state = -1;
			<Place>d__.<>t__builder.Start<DangoBrawlStickyCtrl.<Place>d__11>(ref <Place>d__);
			return <Place>d__.<>t__builder.Task;
		}

		// Token: 0x06042C1D RID: 273437 RVA: 0x0103F664 File Offset: 0x0103D864
		public void RotateVisual()
		{
			if (!this.Fsm.IsSticky())
			{
				return;
			}
			InteractionPayload payLoad = this.Fsm.GetPayLoad();
			if (payLoad == null)
			{
				return;
			}
			EDangoBrawlRotate edangoBrawlRotate = DangoBrawlUtil.NextRotate(payLoad.Visual.Rotate);
			payLoad.Visual.Rotate = edangoBrawlRotate;
			IDangoBrawlDraggableView draggableItem = payLoad.Visual.DraggableItem;
			if (draggableItem == null)
			{
				return;
			}
			draggableItem.SetDraggableRotation(edangoBrawlRotate);
		}

		// Token: 0x06042C1E RID: 273438 RVA: 0x0103F6C4 File Offset: 0x0103D8C4
		[NullableContext(0)]
		private UniTask<bool> BeginStickyCore([Nullable(1)] IDragSourceAdapter adapter, int uid, FVector pointerPos, EDangoBrawlRotate? forceRotate = null)
		{
			DangoBrawlStickyCtrl.<BeginStickyCore>d__13 <BeginStickyCore>d__;
			<BeginStickyCore>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<BeginStickyCore>d__.<>4__this = this;
			<BeginStickyCore>d__.adapter = adapter;
			<BeginStickyCore>d__.uid = uid;
			<BeginStickyCore>d__.pointerPos = pointerPos;
			<BeginStickyCore>d__.forceRotate = forceRotate;
			<BeginStickyCore>d__.<>1__state = -1;
			<BeginStickyCore>d__.<>t__builder.Start<DangoBrawlStickyCtrl.<BeginStickyCore>d__13>(ref <BeginStickyCore>d__);
			return <BeginStickyCore>d__.<>t__builder.Task;
		}

		// Token: 0x06042C1F RID: 273439 RVA: 0x0103F728 File Offset: 0x0103D928
		[NullableContext(0)]
		private UniTask<bool> PlaceAtPointer(FVector pointerPos)
		{
			DangoBrawlStickyCtrl.<PlaceAtPointer>d__14 <PlaceAtPointer>d__;
			<PlaceAtPointer>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlaceAtPointer>d__.<>4__this = this;
			<PlaceAtPointer>d__.pointerPos = pointerPos;
			<PlaceAtPointer>d__.<>1__state = -1;
			<PlaceAtPointer>d__.<>t__builder.Start<DangoBrawlStickyCtrl.<PlaceAtPointer>d__14>(ref <PlaceAtPointer>d__);
			return <PlaceAtPointer>d__.<>t__builder.Task;
		}

		// Token: 0x06042C20 RID: 273440 RVA: 0x0103F774 File Offset: 0x0103D974
		private void SnapHoldingVisualToGrid(IDragVisual visual, FVector2D pointerLguiPos)
		{
			DangoBrawlDropZone zone = this.Resolver.GetZone(EDragTargetKind.Bag);
			if (((zone != null) ? zone.BagExtra : null) == null)
			{
				return;
			}
			UUIItem gridContainer = zone.BagExtra.GetGridContainer();
			if (gridContainer == null || !gridContainer.IsValid())
			{
				return;
			}
			int gridSize = 136;
			ValueTuple<PanelPos, FVector2D, FVector2D> valueTuple = DangoBrawlUtil.CalcGridSnapByPointer(gridContainer, visual, pointerLguiPos, gridSize);
			visual.MoveTo(valueTuple.Item3);
		}

		// Token: 0x06042C21 RID: 273441 RVA: 0x0103F7D4 File Offset: 0x0103D9D4
		private static FVector GetCurrentPointerPos()
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			FVector? fvector = (pointerEventData != null) ? new FVector?(pointerEventData.pointerPosition) : null;
			if (fvector != null)
			{
				FVector valueOrDefault = fvector.GetValueOrDefault();
				return new FVector(valueOrDefault.X, valueOrDefault.Y, 0f);
			}
			TsCharacterController characterController = Global.CharacterController;
			Vector2D vector2D = (characterController != null) ? characterController.GetCursorPosition() : null;
			if (vector2D == null)
			{
				return new FVector(0f, 0f, 0f);
			}
			return new FVector((float)vector2D.X, (float)vector2D.Y, 0f);
		}

		// Token: 0x04022C01 RID: 142337
		private readonly InteractionStateMachine Fsm;

		// Token: 0x04022C02 RID: 142338
		private readonly DropResolver Resolver;

		// Token: 0x04022C03 RID: 142339
		private readonly DangoBrawlSourceAdapterRegistry DangoBrawlSourceAdapters;

		// Token: 0x04022C04 RID: 142340
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022C05 RID: 142341
		private readonly BagHighlightPresenter Highlight;

		// Token: 0x04022C06 RID: 142342
		private readonly DangoBrawlInteractionModeCtrl Modes;

		// Token: 0x04022C07 RID: 142343
		private readonly DangoBrawlPlatformState PlatformState;

		// Token: 0x04022C08 RID: 142344
		private bool Placing;
	}
}
