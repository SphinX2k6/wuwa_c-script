using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input
{
	// Token: 0x020057D0 RID: 22480
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPcAdapter : IDangobrawlInputAdapter
	{
		// Token: 0x17006AF4 RID: 27380
		// (get) Token: 0x06037807 RID: 227335 RVA: 0x00F82EA3 File Offset: 0x00F810A3
		public EInputPlatform Platform
		{
			get
			{
				return EInputPlatform.Pc;
			}
		}

		// Token: 0x17006AF5 RID: 27381
		// (get) Token: 0x06037808 RID: 227336 RVA: 0x00F82EA6 File Offset: 0x00F810A6
		[Nullable(2)]
		private TsCharacterController CharacterController
		{
			[NullableContext(2)]
			get
			{
				return Global.CharacterController;
			}
		}

		// Token: 0x06037809 RID: 227337 RVA: 0x00F82EAD File Offset: 0x00F810AD
		public DangoBrawlPcAdapter(DangoBrawlDragCtrl dragCtrl, DangoBrawlStickyCtrl sticky, InteractionStateMachine fsm)
		{
			this.DragCtrl = dragCtrl;
			this.Sticky = sticky;
			this.Fsm = fsm;
		}

		// Token: 0x0603780A RID: 227338 RVA: 0x00F82ECA File Offset: 0x00F810CA
		public void Start()
		{
		}

		// Token: 0x0603780B RID: 227339 RVA: 0x00F82ECC File Offset: 0x00F810CC
		public void Stop()
		{
		}

		// Token: 0x0603780C RID: 227340 RVA: 0x00F82ED0 File Offset: 0x00F810D0
		public void OnTick(float _)
		{
			if (this.CharacterController == null)
			{
				return;
			}
			bool flag = this.CharacterController.IsInputKeyDown(new FKey
			{
				KeyName = new FName(EKey.LeftMouseButton)
			});
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

		// Token: 0x0603780D RID: 227341 RVA: 0x00F82FC2 File Offset: 0x00F811C2
		public UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603780E RID: 227342 RVA: 0x00F82FC9 File Offset: 0x00F811C9
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return this.DragCtrl.BeginDrag(source, view, pointerPos);
		}

		// Token: 0x0603780F RID: 227343 RVA: 0x00F82FD9 File Offset: 0x00F811D9
		public void OnPointerDrag(FVector pointerPos)
		{
			this.DragCtrl.UpdateDrag(pointerPos);
		}

		// Token: 0x06037810 RID: 227344 RVA: 0x00F82FE7 File Offset: 0x00F811E7
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			return this.DragCtrl.EndDrag(pointerPos);
		}

		// Token: 0x0401D489 RID: 119945
		private readonly DangoBrawlDragCtrl DragCtrl;

		// Token: 0x0401D48A RID: 119946
		private readonly DangoBrawlStickyCtrl Sticky;

		// Token: 0x0401D48B RID: 119947
		private readonly InteractionStateMachine Fsm;

		// Token: 0x0401D48C RID: 119948
		private bool PrevLeftMouseDown;

		// Token: 0x0401D48D RID: 119949
		private bool WasStickyLastFrame;
	}
}
