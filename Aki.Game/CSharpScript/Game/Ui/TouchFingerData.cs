using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046C0 RID: 18112
	public class TouchFingerData
	{
		// Token: 0x0602EB73 RID: 191347 RVA: 0x00ACFA6C File Offset: 0x00ACDC6C
		public TouchFingerData(EFingerIndex fingerIndex)
		{
			this.FingerIndex = fingerIndex;
		}

		// Token: 0x0602EB74 RID: 191348 RVA: 0x00ACFA7B File Offset: 0x00ACDC7B
		public void StartTouch(FVector touchPosition)
		{
			this.TouchPosition = new FVector?(touchPosition);
			this.LastTouchPosition = new FVector?(touchPosition);
			this.IsTouch = true;
		}

		// Token: 0x0602EB75 RID: 191349 RVA: 0x00ACFA9C File Offset: 0x00ACDC9C
		public void EndTouch()
		{
			this.TouchPosition = null;
			this.LastTouchPosition = null;
			this.IsTouch = false;
		}

		// Token: 0x0602EB76 RID: 191350 RVA: 0x00ACFABD File Offset: 0x00ACDCBD
		public void MoveTouch(FVector touchPosition)
		{
			if (this.CurrentFrameNumber != UKismetSystemLibrary.GetFrameCount())
			{
				this.LastTouchPosition = this.TouchPosition;
				this.CurrentFrameNumber = UKismetSystemLibrary.GetFrameCount();
			}
			this.TouchPosition = new FVector?(touchPosition);
		}

		// Token: 0x0602EB77 RID: 191351 RVA: 0x00ACFAEF File Offset: 0x00ACDCEF
		public EFingerIndex GetFingerIndex()
		{
			return this.FingerIndex;
		}

		// Token: 0x0602EB78 RID: 191352 RVA: 0x00ACFAF7 File Offset: 0x00ACDCF7
		public FVector? GetTouchPosition()
		{
			return this.TouchPosition;
		}

		// Token: 0x0602EB79 RID: 191353 RVA: 0x00ACFAFF File Offset: 0x00ACDCFF
		public FVector? GetLastTouchPosition()
		{
			return this.LastTouchPosition;
		}

		// Token: 0x0602EB7A RID: 191354 RVA: 0x00ACFB07 File Offset: 0x00ACDD07
		public bool IsInTouch()
		{
			return this.IsTouch;
		}

		// Token: 0x0602EB7B RID: 191355 RVA: 0x00ACFB0F File Offset: 0x00ACDD0F
		public bool IsTouchEmpty()
		{
			return !LguiEventSystemManager.Instance.IsPressComponentIsValid((int)this.FingerIndex);
		}

		// Token: 0x0602EB7C RID: 191356 RVA: 0x00ACFB24 File Offset: 0x00ACDD24
		[NullableContext(2)]
		public ULGUIPointerEventData GetPointerEventData()
		{
			return LguiEventSystemManager.Instance.GetPointerEventData((int)this.FingerIndex, false);
		}

		// Token: 0x0602EB7D RID: 191357 RVA: 0x00ACFB38 File Offset: 0x00ACDD38
		public bool IsTouchComponentContainTag(FName tag)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData();
			USceneComponent usceneComponent = (pointerEventData != null) ? pointerEventData.pressComponent : null;
			USceneComponent usceneComponent2 = (pointerEventData != null) ? pointerEventData.enterComponent : null;
			if (usceneComponent != null && usceneComponent.IsValid())
			{
				return usceneComponent.ComponentHasTag(tag);
			}
			return usceneComponent2 != null && usceneComponent2.IsValid() && usceneComponent2.ComponentHasTag(tag);
		}

		// Token: 0x040196DE RID: 104158
		private readonly EFingerIndex FingerIndex;

		// Token: 0x040196DF RID: 104159
		private FVector? TouchPosition;

		// Token: 0x040196E0 RID: 104160
		private FVector? LastTouchPosition;

		// Token: 0x040196E1 RID: 104161
		private bool IsTouch;

		// Token: 0x040196E2 RID: 104162
		private long CurrentFrameNumber;
	}
}
