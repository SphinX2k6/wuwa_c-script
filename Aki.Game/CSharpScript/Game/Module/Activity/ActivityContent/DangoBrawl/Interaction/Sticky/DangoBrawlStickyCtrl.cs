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
	// Token: 0x020057BC RID: 22460
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlStickyCtrl
	{
		// Token: 0x06037770 RID: 227184 RVA: 0x00F809CB File Offset: 0x00F7EBCB
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

		// Token: 0x06037771 RID: 227185 RVA: 0x00F80A08 File Offset: 0x00F7EC08
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

		// Token: 0x06037772 RID: 227186 RVA: 0x00F80AA0 File Offset: 0x00F7ECA0
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

		// Token: 0x06037773 RID: 227187 RVA: 0x00F80AF8 File Offset: 0x00F7ECF8
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

		// Token: 0x06037774 RID: 227188 RVA: 0x00F80B44 File Offset: 0x00F7ED44
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

		// Token: 0x06037775 RID: 227189 RVA: 0x00F80BA4 File Offset: 0x00F7EDA4
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

		// Token: 0x06037776 RID: 227190 RVA: 0x00F80C08 File Offset: 0x00F7EE08
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

		// Token: 0x06037777 RID: 227191 RVA: 0x00F80C54 File Offset: 0x00F7EE54
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

		// Token: 0x06037778 RID: 227192 RVA: 0x00F80CB4 File Offset: 0x00F7EEB4
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

		// Token: 0x0401D45E RID: 119902
		private readonly InteractionStateMachine Fsm;

		// Token: 0x0401D45F RID: 119903
		private readonly DropResolver Resolver;

		// Token: 0x0401D460 RID: 119904
		private readonly DangoBrawlSourceAdapterRegistry DangoBrawlSourceAdapters;

		// Token: 0x0401D461 RID: 119905
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D462 RID: 119906
		private readonly BagHighlightPresenter Highlight;

		// Token: 0x0401D463 RID: 119907
		private readonly DangoBrawlInteractionModeCtrl Modes;

		// Token: 0x0401D464 RID: 119908
		private readonly DangoBrawlPlatformState PlatformState;

		// Token: 0x0401D465 RID: 119909
		private bool Placing;
	}
}
