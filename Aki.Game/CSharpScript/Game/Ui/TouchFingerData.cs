using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F1 RID: 13809
	public class TouchFingerData
	{
		// Token: 0x060232BF RID: 144063 RVA: 0x009FE3FE File Offset: 0x009FC5FE
		public TouchFingerData(EFingerIndex fingerIndex)
		{
			this.FingerIndex = fingerIndex;
		}

		// Token: 0x060232C0 RID: 144064 RVA: 0x009FE40D File Offset: 0x009FC60D
		public void StartTouch(FVector touchPosition)
		{
			this.TouchPosition = new FVector?(touchPosition);
			this.LastTouchPosition = new FVector?(touchPosition);
			this.IsTouch = true;
		}

		// Token: 0x060232C1 RID: 144065 RVA: 0x009FE42E File Offset: 0x009FC62E
		public void EndTouch()
		{
			this.TouchPosition = null;
			this.LastTouchPosition = null;
			this.IsTouch = false;
		}

		// Token: 0x060232C2 RID: 144066 RVA: 0x009FE44F File Offset: 0x009FC64F
		public void MoveTouch(FVector touchPosition)
		{
			if (this.CurrentFrameNumber != UKismetSystemLibrary.GetFrameCount())
			{
				this.LastTouchPosition = this.TouchPosition;
				this.CurrentFrameNumber = UKismetSystemLibrary.GetFrameCount();
			}
			this.TouchPosition = new FVector?(touchPosition);
		}

		// Token: 0x060232C3 RID: 144067 RVA: 0x009FE481 File Offset: 0x009FC681
		public EFingerIndex GetFingerIndex()
		{
			return this.FingerIndex;
		}

		// Token: 0x060232C4 RID: 144068 RVA: 0x009FE489 File Offset: 0x009FC689
		public FVector? GetTouchPosition()
		{
			return this.TouchPosition;
		}

		// Token: 0x060232C5 RID: 144069 RVA: 0x009FE491 File Offset: 0x009FC691
		public FVector? GetLastTouchPosition()
		{
			return this.LastTouchPosition;
		}

		// Token: 0x060232C6 RID: 144070 RVA: 0x009FE499 File Offset: 0x009FC699
		public bool IsInTouch()
		{
			return this.IsTouch;
		}

		// Token: 0x060232C7 RID: 144071 RVA: 0x009FE4A1 File Offset: 0x009FC6A1
		public bool IsTouchEmpty()
		{
			return !LguiEventSystemManager.Instance.IsPressComponentIsValid((int)this.FingerIndex);
		}

		// Token: 0x060232C8 RID: 144072 RVA: 0x009FE4B6 File Offset: 0x009FC6B6
		[NullableContext(2)]
		public ULGUIPointerEventData GetPointerEventData()
		{
			return LguiEventSystemManager.Instance.GetPointerEventData((int)this.FingerIndex, false);
		}

		// Token: 0x060232C9 RID: 144073 RVA: 0x009FE4CC File Offset: 0x009FC6CC
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

		// Token: 0x04013D85 RID: 81285
		private readonly EFingerIndex FingerIndex;

		// Token: 0x04013D86 RID: 81286
		private FVector? TouchPosition;

		// Token: 0x04013D87 RID: 81287
		private FVector? LastTouchPosition;

		// Token: 0x04013D88 RID: 81288
		private bool IsTouch;

		// Token: 0x04013D89 RID: 81289
		private long CurrentFrameNumber;
	}
}
