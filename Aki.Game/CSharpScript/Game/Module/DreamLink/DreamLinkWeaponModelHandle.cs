using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA2 RID: 23202
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkWeaponModelHandle
	{
		// Token: 0x0603AC48 RID: 240712 RVA: 0x00DFF29F File Offset: 0x00DFD49F
		[NullableContext(1)]
		public DreamLinkWeaponModelHandle(AActor Actor)
		{
			this.Actor = Actor;
			this.Rotator = Rotator.Create();
		}

		// Token: 0x0603AC49 RID: 240713 RVA: 0x00DFF2B9 File Offset: 0x00DFD4B9
		public void SetRotateParam(float aroundTime, ERotateAxis axis = ERotateAxis.Yaw, bool isPlus = true)
		{
			this.DeltaSecondRotate = ((aroundTime != 0f) ? (360f / aroundTime) : 0f);
			this.RotateAxis = new ERotateAxis?(axis);
			this.IsRotatePlus = isPlus;
		}

		// Token: 0x0603AC4A RID: 240714 RVA: 0x00DFF2EA File Offset: 0x00DFD4EA
		public void StartRotate()
		{
			this.IsRotating = true;
		}

		// Token: 0x0603AC4B RID: 240715 RVA: 0x00DFF2F3 File Offset: 0x00DFD4F3
		public void StopRotate()
		{
			this.IsRotating = false;
		}

		// Token: 0x0603AC4C RID: 240716 RVA: 0x00DFF2FC File Offset: 0x00DFD4FC
		public void Tick(float deltaTime)
		{
			this.OnRotate(deltaTime);
		}

		// Token: 0x0603AC4D RID: 240717 RVA: 0x00DFF308 File Offset: 0x00DFD508
		protected void OnRotate(float deltaTime)
		{
			if (!this.IsRotating || this.DeltaSecondRotate <= 0f)
			{
				return;
			}
			if (this.Actor == null)
			{
				return;
			}
			int num = this.IsRotatePlus ? 1 : -1;
			float num2 = this.DeltaSecondRotate * deltaTime * (float)num;
			ERotateAxis? rotateAxis = this.RotateAxis;
			ERotateAxis erotateAxis = ERotateAxis.Pitch;
			if (rotateAxis.GetValueOrDefault() == erotateAxis & rotateAxis != null)
			{
				this.Rotator.Pitch = num2;
			}
			else if (this.RotateAxis.GetValueOrDefault() == ERotateAxis.Yaw)
			{
				this.Rotator.Yaw = num2;
			}
			else if (this.RotateAxis.GetValueOrDefault() == ERotateAxis.Roll)
			{
				this.Rotator.Roll = num2;
			}
			FHitResult fhitResult = new FHitResult();
			this.Actor.K2_AddActorLocalRotation(this.Rotator.ToUeRotator(), false, ref fhitResult, false);
		}

		// Token: 0x0603AC4E RID: 240718 RVA: 0x00DFF3D0 File Offset: 0x00DFD5D0
		public void Destroy()
		{
			this.Actor = null;
		}

		// Token: 0x0401EAB4 RID: 125620
		private AActor Actor;

		// Token: 0x0401EAB5 RID: 125621
		private float DeltaSecondRotate;

		// Token: 0x0401EAB6 RID: 125622
		private bool IsRotating;

		// Token: 0x0401EAB7 RID: 125623
		private Rotator Rotator;

		// Token: 0x0401EAB8 RID: 125624
		private ERotateAxis? RotateAxis;

		// Token: 0x0401EAB9 RID: 125625
		private bool IsRotatePlus;
	}
}
