using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.ShowCase
{
	// Token: 0x02006ED6 RID: 28374
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabShowcaseFocusView : UiViewBase
	{
		// Token: 0x060451ED RID: 283117 RVA: 0x01117930 File Offset: 0x01115B30
		public DollGrabShowcaseFocusView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060451EE RID: 283118 RVA: 0x0111798C File Offset: 0x01115B8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060451EF RID: 283119 RVA: 0x01117A38 File Offset: 0x01115C38
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabShowcaseFocusView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabShowcaseFocusView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060451F0 RID: 283120 RVA: 0x01117A7C File Offset: 0x01115C7C
		protected override void OnStart()
		{
			DollItemInfo data = this.Data;
			if (((data != null) ? data.DollShowCaseActor : null) != null)
			{
				Rotator originalRotation = this.OriginalRotation;
				FRotator frotator = this.Data.DollShowCaseActor.K2_GetActorRotation();
				originalRotation.DeepCopy(frotator);
				this.LastRotation.DeepCopy(this.OriginalRotation);
			}
			UUIDraggableComponent draggable = base.GetDraggable(0);
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDrag));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDrag));
		}

		// Token: 0x060451F1 RID: 283121 RVA: 0x01117B18 File Offset: 0x01115D18
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabShowcaseFocusView.<OnBeforeShowAsyncImplementImplement>d__13 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabShowcaseFocusView.<OnBeforeShowAsyncImplementImplement>d__13>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060451F2 RID: 283122 RVA: 0x01117B5B File Offset: 0x01115D5B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
		}

		// Token: 0x060451F3 RID: 283123 RVA: 0x01117B79 File Offset: 0x01115D79
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
		}

		// Token: 0x060451F4 RID: 283124 RVA: 0x01117B97 File Offset: 0x01115D97
		protected override void OnBeforeDestroy()
		{
			this.StopDollIdleAnimation();
			DollGrabShowcaseController.Instance.OpenAllViewCamera(null);
			DollItemInfo data = this.Data;
			if (data == null)
			{
				return;
			}
			BP_DollShowCaseActor_C dollShowCaseActor = data.DollShowCaseActor;
			if (dollShowCaseActor == null)
			{
				return;
			}
			dollShowCaseActor.K2_SetActorRotation(this.OriginalRotation.ToUeRotator(), false);
		}

		// Token: 0x060451F5 RID: 283125 RVA: 0x01117BD4 File Offset: 0x01115DD4
		private UniTask InitCaption()
		{
			DollGrabShowcaseFocusView.<InitCaption>d__17 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DollGrabShowcaseFocusView.<InitCaption>d__17>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060451F6 RID: 283126 RVA: 0x01117C17 File Offset: 0x01115E17
		protected void SetArrowActive(bool isActive)
		{
			if (this.IsArrowActive == isActive)
			{
				return;
			}
			this.IsArrowActive = isActive;
			base.GetItem(2).SetUIActive(isActive);
			base.GetItem(3).SetUIActive(isActive);
		}

		// Token: 0x060451F7 RID: 283127 RVA: 0x01117C44 File Offset: 0x01115E44
		protected void PlayDollIdleAnimation()
		{
			if (!this.Data.IsCollectComplete())
			{
				return;
			}
			if (string.IsNullOrEmpty(this.Data.DollIdleAnimPath))
			{
				return;
			}
			USkeletalMeshComponent skeletalMesh = this.Data.DollShowCaseActor.SkeletalMesh;
			if (skeletalMesh == null)
			{
				return;
			}
			skeletalMesh.Play(true);
		}

		// Token: 0x060451F8 RID: 283128 RVA: 0x01117C90 File Offset: 0x01115E90
		protected void StopDollIdleAnimation()
		{
			USkeletalMeshComponent skeletalMesh = this.Data.DollShowCaseActor.SkeletalMesh;
			if (skeletalMesh == null)
			{
				return;
			}
			skeletalMesh.Stop();
			skeletalMesh.SetPosition(0f, false);
		}

		// Token: 0x060451F9 RID: 283129 RVA: 0x01117CC4 File Offset: 0x01115EC4
		[NullableContext(2)]
		private void OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			FVector pointerPosition = eventData.pointerPosition;
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.LastPosition);
			this.SetArrowActive(false);
		}

		// Token: 0x060451FA RID: 283130 RVA: 0x01117CF4 File Offset: 0x01115EF4
		[NullableContext(2)]
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			FVector pointerPosition = eventData.pointerPosition;
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.CurPosition);
			this.CurPosition.Subtraction(this.LastPosition, this.DeltaPosition);
			this.LastPosition.DeepCopy(this.CurPosition);
			if (this.DeltaPosition.X == 0.0)
			{
				return;
			}
			this.LastRotation.Yaw -= (float)this.DeltaPosition.X;
			DollItemInfo data = this.Data;
			if (data == null)
			{
				return;
			}
			BP_DollShowCaseActor_C dollShowCaseActor = data.DollShowCaseActor;
			if (dollShowCaseActor == null)
			{
				return;
			}
			dollShowCaseActor.K2_SetActorRotation(this.LastRotation.ToUeRotator(), false);
		}

		// Token: 0x060451FB RID: 283131 RVA: 0x01117DA2 File Offset: 0x01115FA2
		[NullableContext(2)]
		private void OnPointerEndDrag(ULGUIPointerEventData eventData)
		{
			if (eventData != null)
			{
				this.SetArrowActive(true);
			}
		}

		// Token: 0x060451FC RID: 283132 RVA: 0x01117DAE File Offset: 0x01115FAE
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060451FD RID: 283133 RVA: 0x01117DB8 File Offset: 0x01115FB8
		private void OnInputUiTurn(float value)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (value == 0f)
			{
				this.SetArrowActive(true);
				return;
			}
			this.SetArrowActive(false);
			this.LastRotation.Yaw -= value * 4f;
			DollItemInfo data = this.Data;
			if (data == null)
			{
				return;
			}
			BP_DollShowCaseActor_C dollShowCaseActor = data.DollShowCaseActor;
			if (dollShowCaseActor == null)
			{
				return;
			}
			dollShowCaseActor.K2_SetActorRotation(this.LastRotation.ToUeRotator(), false);
		}

		// Token: 0x04023FD5 RID: 147413
		protected readonly Rotator OriginalRotation = Rotator.Create();

		// Token: 0x04023FD6 RID: 147414
		protected readonly Rotator LastRotation = Rotator.Create();

		// Token: 0x04023FD7 RID: 147415
		protected readonly Vector2D LastPosition = Vector2D.Create();

		// Token: 0x04023FD8 RID: 147416
		protected readonly Vector2D CurPosition = Vector2D.Create();

		// Token: 0x04023FD9 RID: 147417
		protected readonly Vector2D DeltaPosition = Vector2D.Create();

		// Token: 0x04023FDA RID: 147418
		[Nullable(2)]
		protected DollItemInfo Data;

		// Token: 0x04023FDB RID: 147419
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04023FDC RID: 147420
		private bool IsFirstShow = true;

		// Token: 0x04023FDD RID: 147421
		private bool IsArrowActive = true;
	}
}
