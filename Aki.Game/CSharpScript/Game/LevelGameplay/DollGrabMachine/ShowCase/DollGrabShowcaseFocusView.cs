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
	// Token: 0x02006056 RID: 24662
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabShowcaseFocusView : UiViewBase
	{
		// Token: 0x0603B396 RID: 242582 RVA: 0x010C16C0 File Offset: 0x010BF8C0
		public DollGrabShowcaseFocusView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B397 RID: 242583 RVA: 0x010C171C File Offset: 0x010BF91C
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

		// Token: 0x0603B398 RID: 242584 RVA: 0x010C17C8 File Offset: 0x010BF9C8
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabShowcaseFocusView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabShowcaseFocusView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B399 RID: 242585 RVA: 0x010C180C File Offset: 0x010BFA0C
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

		// Token: 0x0603B39A RID: 242586 RVA: 0x010C18A8 File Offset: 0x010BFAA8
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabShowcaseFocusView.<OnBeforeShowAsyncImplementImplement>d__13 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabShowcaseFocusView.<OnBeforeShowAsyncImplementImplement>d__13>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603B39B RID: 242587 RVA: 0x010C18EB File Offset: 0x010BFAEB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
		}

		// Token: 0x0603B39C RID: 242588 RVA: 0x010C1909 File Offset: 0x010BFB09
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
		}

		// Token: 0x0603B39D RID: 242589 RVA: 0x010C1927 File Offset: 0x010BFB27
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

		// Token: 0x0603B39E RID: 242590 RVA: 0x010C1964 File Offset: 0x010BFB64
		private UniTask InitCaption()
		{
			DollGrabShowcaseFocusView.<InitCaption>d__17 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DollGrabShowcaseFocusView.<InitCaption>d__17>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0603B39F RID: 242591 RVA: 0x010C19A7 File Offset: 0x010BFBA7
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

		// Token: 0x0603B3A0 RID: 242592 RVA: 0x010C19D4 File Offset: 0x010BFBD4
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

		// Token: 0x0603B3A1 RID: 242593 RVA: 0x010C1A20 File Offset: 0x010BFC20
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

		// Token: 0x0603B3A2 RID: 242594 RVA: 0x010C1A54 File Offset: 0x010BFC54
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

		// Token: 0x0603B3A3 RID: 242595 RVA: 0x010C1A84 File Offset: 0x010BFC84
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

		// Token: 0x0603B3A4 RID: 242596 RVA: 0x010C1B32 File Offset: 0x010BFD32
		[NullableContext(2)]
		private void OnPointerEndDrag(ULGUIPointerEventData eventData)
		{
			if (eventData != null)
			{
				this.SetArrowActive(true);
			}
		}

		// Token: 0x0603B3A5 RID: 242597 RVA: 0x010C1B3E File Offset: 0x010BFD3E
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B3A6 RID: 242598 RVA: 0x010C1B48 File Offset: 0x010BFD48
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

		// Token: 0x0401F288 RID: 127624
		protected readonly Rotator OriginalRotation = Rotator.Create();

		// Token: 0x0401F289 RID: 127625
		protected readonly Rotator LastRotation = Rotator.Create();

		// Token: 0x0401F28A RID: 127626
		protected readonly Vector2D LastPosition = Vector2D.Create();

		// Token: 0x0401F28B RID: 127627
		protected readonly Vector2D CurPosition = Vector2D.Create();

		// Token: 0x0401F28C RID: 127628
		protected readonly Vector2D DeltaPosition = Vector2D.Create();

		// Token: 0x0401F28D RID: 127629
		[Nullable(2)]
		protected DollItemInfo Data;

		// Token: 0x0401F28E RID: 127630
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401F28F RID: 127631
		private bool IsFirstShow = true;

		// Token: 0x0401F290 RID: 127632
		private bool IsArrowActive = true;
	}
}
