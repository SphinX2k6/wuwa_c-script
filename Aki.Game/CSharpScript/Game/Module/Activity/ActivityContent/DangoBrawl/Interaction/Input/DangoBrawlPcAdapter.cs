using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input
{
	// Token: 0x02006880 RID: 26752
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPcAdapter : IDangobrawlInputAdapter
	{
		// Token: 0x170097B4 RID: 38836
		// (get) Token: 0x06042CAF RID: 273583 RVA: 0x0104192B File Offset: 0x0103FB2B
		public EInputPlatform Platform
		{
			get
			{
				return EInputPlatform.Pc;
			}
		}

		// Token: 0x170097B5 RID: 38837
		// (get) Token: 0x06042CB0 RID: 273584 RVA: 0x0104192E File Offset: 0x0103FB2E
		[Nullable(2)]
		private TsCharacterController CharacterController
		{
			[NullableContext(2)]
			get
			{
				return Global.CharacterController;
			}
		}

		// Token: 0x06042CB1 RID: 273585 RVA: 0x01041935 File Offset: 0x0103FB35
		public DangoBrawlPcAdapter(DangoBrawlDragCtrl dragCtrl, DangoBrawlStickyCtrl sticky, InteractionStateMachine fsm)
		{
			this.DragCtrl = dragCtrl;
			this.Sticky = sticky;
			this.Fsm = fsm;
		}

		// Token: 0x06042CB2 RID: 273586 RVA: 0x01041952 File Offset: 0x0103FB52
		public void Start()
		{
		}

		// Token: 0x06042CB3 RID: 273587 RVA: 0x01041954 File Offset: 0x0103FB54
		public void Stop()
		{
		}

		// Token: 0x06042CB4 RID: 273588 RVA: 0x01041958 File Offset: 0x0103FB58
		public void OnTick(float _)
		{
			if (this.CharacterController == null)
			{
				return;
			}
			bool flag = this.CharacterController.IsInputKeyDown(new FKey(new FName(EKey.LeftMouseButton)));
			bool flag2 = this.PrevLeftMouseDown && !flag;
			this.PrevLeftMouseDown = flag;
			Vector2D cursorPosition = this.CharacterController.GetCursorPosition();
			if (cursorPosition == null)
			{
				return;
			}
			FVector pointerPos = new FVector((float)cursorPosition.X, (float)cursorPosition.Y, 0f);
			if (this.DragCtrl.IsDragging)
			{
				this.WasStickyLastFrame = false;
				this.DragCtrl.UpdateDrag(pointerPos);
				if (flag2)
				{
					this.DragCtrl.EndDrag(pointerPos).Forget();
				}
				return;
			}
			bool flag3 = this.Fsm.IsSticky();
			if (flag3)
			{
				this.Sticky.UpdateMove(pointerPos);
				if (this.WasStickyLastFrame && flag2)
				{
					this.Sticky.Place(pointerPos).Forget();
				}
			}
			this.WasStickyLastFrame = flag3;
		}

		// Token: 0x06042CB5 RID: 273589 RVA: 0x01041A44 File Offset: 0x0103FC44
		public UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06042CB6 RID: 273590 RVA: 0x01041A4B File Offset: 0x0103FC4B
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return this.DragCtrl.BeginDrag(source, view, pointerPos);
		}

		// Token: 0x06042CB7 RID: 273591 RVA: 0x01041A5B File Offset: 0x0103FC5B
		public void OnPointerDrag(FVector pointerPos)
		{
			this.DragCtrl.UpdateDrag(pointerPos);
		}

		// Token: 0x06042CB8 RID: 273592 RVA: 0x01041A69 File Offset: 0x0103FC69
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			return this.DragCtrl.EndDrag(pointerPos);
		}

		// Token: 0x04022C2D RID: 142381
		private readonly DangoBrawlDragCtrl DragCtrl;

		// Token: 0x04022C2E RID: 142382
		private readonly DangoBrawlStickyCtrl Sticky;

		// Token: 0x04022C2F RID: 142383
		private readonly InteractionStateMachine Fsm;

		// Token: 0x04022C30 RID: 142384
		private bool PrevLeftMouseDown;

		// Token: 0x04022C31 RID: 142385
		private bool WasStickyLastFrame;
	}
}
