using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input
{
	// Token: 0x020057CE RID: 22478
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlGamepadAdapter : IDangobrawlInputAdapter
	{
		// Token: 0x17006AF2 RID: 27378
		// (get) Token: 0x060377F3 RID: 227315 RVA: 0x00F82B25 File Offset: 0x00F80D25
		public EInputPlatform Platform
		{
			get
			{
				return EInputPlatform.Gamepad;
			}
		}

		// Token: 0x060377F4 RID: 227316 RVA: 0x00F82B28 File Offset: 0x00F80D28
		public DangoBrawlGamepadAdapter(DangoBrawlDragCtrl dragCtrl, DangoBrawlStickyCtrl stickyCtrl, InteractionStateMachine fsm)
		{
			this.DragCtrl = dragCtrl;
			this.StickyCtrl = stickyCtrl;
			this.Fsm = fsm;
		}

		// Token: 0x060377F5 RID: 227317 RVA: 0x00F82B45 File Offset: 0x00F80D45
		public void Start()
		{
			InputDistributeController.Instance.BindActionIgnoreLimit("UI键盘F手柄A", new TInputHandle<InputDistributeDefine.EActionType>(this.OnConfirmAction));
		}

		// Token: 0x060377F6 RID: 227318 RVA: 0x00F82B62 File Offset: 0x00F80D62
		public void Stop()
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit("UI键盘F手柄A", new TInputHandle<InputDistributeDefine.EActionType>(this.OnConfirmAction));
			this.Phase = DangoBrawlGamepadAdapter.EEaPhase.None;
		}

		// Token: 0x060377F7 RID: 227319 RVA: 0x00F82B88 File Offset: 0x00F80D88
		public void OnTick(float _)
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			FVector? fvector = (pointerEventData != null) ? new FVector?(pointerEventData.pointerPosition) : null;
			if (fvector == null)
			{
				return;
			}
			FVector valueOrDefault = fvector.GetValueOrDefault();
			if (this.DragCtrl.IsDragging)
			{
				this.DragCtrl.UpdateDrag(valueOrDefault);
				return;
			}
			if (this.Fsm.IsSticky())
			{
				this.StickyCtrl.UpdateMove(valueOrDefault);
			}
		}

		// Token: 0x060377F8 RID: 227320 RVA: 0x00F82C04 File Offset: 0x00F80E04
		private void OnConfirmAction(string _, InputDistributeDefine.EActionType actionType, InputIdentification __)
		{
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.Phase = ((this.DragCtrl.IsDragging || this.Fsm.IsBlocking()) ? DangoBrawlGamepadAdapter.EEaPhase.Settle : DangoBrawlGamepadAdapter.EEaPhase.Pick);
				return;
			}
			if (this.Phase != DangoBrawlGamepadAdapter.EEaPhase.Settle)
			{
				return;
			}
			this.Phase = DangoBrawlGamepadAdapter.EEaPhase.None;
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			FVector? fvector = (pointerEventData != null) ? new FVector?(pointerEventData.pointerPosition) : null;
			if (fvector == null)
			{
				return;
			}
			FVector valueOrDefault = fvector.GetValueOrDefault();
			if (this.DragCtrl.IsDragging)
			{
				this.DragCtrl.EndDrag(valueOrDefault).Forget();
				return;
			}
			if (this.Fsm.IsSticky())
			{
				this.StickyCtrl.Place(valueOrDefault).Forget();
				return;
			}
			if (this.Fsm.IsHolding() && this.DragCtrl.IsHoveringBlockingItem())
			{
				this.DragCtrl.ResumeBlockingSession(valueOrDefault);
			}
		}

		// Token: 0x060377F9 RID: 227321 RVA: 0x00F82CE8 File Offset: 0x00F80EE8
		public UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return UniTask.CompletedTask;
			}
			if (this.Phase != DangoBrawlGamepadAdapter.EEaPhase.Pick || this.DragCtrl.IsDragging || this.Fsm.IsBlocking())
			{
				return UniTask.CompletedTask;
			}
			return this.DragCtrl.BeginDrag(source, view, pointerPos);
		}

		// Token: 0x060377FA RID: 227322 RVA: 0x00F82D3A File Offset: 0x00F80F3A
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060377FB RID: 227323 RVA: 0x00F82D41 File Offset: 0x00F80F41
		public void OnPointerDrag(FVector pointerPos)
		{
		}

		// Token: 0x060377FC RID: 227324 RVA: 0x00F82D43 File Offset: 0x00F80F43
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0401D484 RID: 119940
		private readonly DangoBrawlDragCtrl DragCtrl;

		// Token: 0x0401D485 RID: 119941
		private readonly DangoBrawlStickyCtrl StickyCtrl;

		// Token: 0x0401D486 RID: 119942
		private readonly InteractionStateMachine Fsm;

		// Token: 0x0401D487 RID: 119943
		private DangoBrawlGamepadAdapter.EEaPhase Phase;

		// Token: 0x0200B418 RID: 46104
		[NullableContext(0)]
		private enum EEaPhase
		{
			// Token: 0x04037B4D RID: 228173
			None,
			// Token: 0x04037B4E RID: 228174
			Pick,
			// Token: 0x04037B4F RID: 228175
			Settle
		}
	}
}
