using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A7E RID: 19070
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkWeaponModelHandle
	{
		// Token: 0x0602FB91 RID: 195473 RVA: 0x00D4F807 File Offset: 0x00D4DA07
		[NullableContext(1)]
		public DreamLinkWeaponModelHandle(AActor Actor)
		{
			this.Actor = Actor;
			this.Rotator = Rotator.Create();
		}

		// Token: 0x0602FB92 RID: 195474 RVA: 0x00D4F821 File Offset: 0x00D4DA21
		public void SetRotateParam(float aroundTime, ERotateAxis axis = ERotateAxis.Yaw, bool isPlus = true)
		{
			this.DeltaSecondRotate = ((aroundTime != 0f) ? (360f / aroundTime) : 0f);
			this.RotateAxis = new ERotateAxis?(axis);
			this.IsRotatePlus = isPlus;
		}

		// Token: 0x0602FB93 RID: 195475 RVA: 0x00D4F852 File Offset: 0x00D4DA52
		public void StartRotate()
		{
			this.IsRotating = true;
		}

		// Token: 0x0602FB94 RID: 195476 RVA: 0x00D4F85B File Offset: 0x00D4DA5B
		public void StopRotate()
		{
			this.IsRotating = false;
		}

		// Token: 0x0602FB95 RID: 195477 RVA: 0x00D4F864 File Offset: 0x00D4DA64
		public void Tick(float deltaTime)
		{
			this.OnRotate(deltaTime);
		}

		// Token: 0x0602FB96 RID: 195478 RVA: 0x00D4F870 File Offset: 0x00D4DA70
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

		// Token: 0x0602FB97 RID: 195479 RVA: 0x00D4F938 File Offset: 0x00D4DB38
		public void Destroy()
		{
			this.Actor = null;
		}

		// Token: 0x0401955B RID: 103771
		private AActor Actor;

		// Token: 0x0401955C RID: 103772
		private float DeltaSecondRotate;

		// Token: 0x0401955D RID: 103773
		private bool IsRotating;

		// Token: 0x0401955E RID: 103774
		private Rotator Rotator;

		// Token: 0x0401955F RID: 103775
		private ERotateAxis? RotateAxis;

		// Token: 0x04019560 RID: 103776
		private bool IsRotatePlus;
	}
}
