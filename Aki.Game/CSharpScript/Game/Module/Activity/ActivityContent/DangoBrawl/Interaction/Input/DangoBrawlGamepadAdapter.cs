using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input
{
	// Token: 0x0200687E RID: 26750
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlGamepadAdapter : IDangobrawlInputAdapter
	{
		// Token: 0x170097B1 RID: 38833
		// (get) Token: 0x06042C9B RID: 273563 RVA: 0x010415ED File Offset: 0x0103F7ED
		public EInputPlatform Platform
		{
			get
			{
				return EInputPlatform.Gamepad;
			}
		}

		// Token: 0x170097B2 RID: 38834
		// (get) Token: 0x06042C9C RID: 273564 RVA: 0x010415F0 File Offset: 0x0103F7F0
		[Nullable(2)]
		private APlayerController PlayerController
		{
			[NullableContext(2)]
			get
			{
				return Global.PlayerController;
			}
		}

		// Token: 0x06042C9D RID: 273565 RVA: 0x010415F7 File Offset: 0x0103F7F7
		public DangoBrawlGamepadAdapter(DangoBrawlDragCtrl dragCtrl, DangoBrawlStickyCtrl stickyCtrl, InteractionStateMachine fsm)
		{
			this.DragCtrl = dragCtrl;
			this.StickyCtrl = stickyCtrl;
			this.Fsm = fsm;
		}

		// Token: 0x06042C9E RID: 273566 RVA: 0x01041614 File Offset: 0x0103F814
		public void Start()
		{
		}

		// Token: 0x06042C9F RID: 273567 RVA: 0x01041616 File Offset: 0x0103F816
		public void Stop()
		{
		}

		// Token: 0x06042CA0 RID: 273568 RVA: 0x01041618 File Offset: 0x0103F818
		public void OnTick(float _)
		{
			if (this.PlayerController == null)
			{
				return;
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			FVector? fvector = (pointerEventData != null) ? new FVector?(pointerEventData.pointerPosition) : null;
			if (fvector == null)
			{
				return;
			}
			FVector valueOrDefault = fvector.GetValueOrDefault();
			FKey key = new FKey(new FName(EKey.Gamepad_FaceButton_Bottom));
			bool flag = this.PlayerController.IsInputKeyDown(key);
			bool flag2 = flag && !this.PrevAPressed;
			bool flag3 = !flag && this.PrevAPressed;
			this.PrevAPressed = flag;
			if (flag2)
			{
				this.Phase = ((this.DragCtrl.IsDragging || this.Fsm.IsBlocking()) ? DangoBrawlGamepadAdapter.EEaPhase.Settle : DangoBrawlGamepadAdapter.EEaPhase.Pick);
			}
			bool flag4 = flag3 && this.Phase == DangoBrawlGamepadAdapter.EEaPhase.Settle;
			if (this.DragCtrl.IsDragging)
			{
				this.DragCtrl.UpdateDrag(valueOrDefault);
				if (flag4)
				{
					this.DragCtrl.EndDrag(valueOrDefault).Forget();
				}
				return;
			}
			if (this.Fsm.IsSticky())
			{
				this.StickyCtrl.UpdateMove(valueOrDefault);
				if (flag4)
				{
					this.StickyCtrl.Place(valueOrDefault).Forget();
				}
				return;
			}
			if (this.Fsm.IsHolding())
			{
				if (flag4 && this.DragCtrl.IsHoveringBlockingItem())
				{
					this.DragCtrl.ResumeBlockingSession(valueOrDefault);
				}
				return;
			}
		}

		// Token: 0x06042CA1 RID: 273569 RVA: 0x01041770 File Offset: 0x0103F970
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

		// Token: 0x06042CA2 RID: 273570 RVA: 0x010417C2 File Offset: 0x0103F9C2
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06042CA3 RID: 273571 RVA: 0x010417C9 File Offset: 0x0103F9C9
		public void OnPointerDrag(FVector pointerPos)
		{
		}

		// Token: 0x06042CA4 RID: 273572 RVA: 0x010417CB File Offset: 0x0103F9CB
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x04022C27 RID: 142375
		private readonly DangoBrawlDragCtrl DragCtrl;

		// Token: 0x04022C28 RID: 142376
		private readonly DangoBrawlStickyCtrl StickyCtrl;

		// Token: 0x04022C29 RID: 142377
		private readonly InteractionStateMachine Fsm;

		// Token: 0x04022C2A RID: 142378
		private bool PrevAPressed;

		// Token: 0x04022C2B RID: 142379
		private DangoBrawlGamepadAdapter.EEaPhase Phase;

		// Token: 0x0200CA4E RID: 51790
		[NullableContext(0)]
		private enum EEaPhase
		{
			// Token: 0x0403D26E RID: 250478
			None,
			// Token: 0x0403D26F RID: 250479
			Pick,
			// Token: 0x0403D270 RID: 250480
			Settle
		}
	}
}
