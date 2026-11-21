using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SundialControl
{
	// Token: 0x02005B64 RID: 23396
	[NullableContext(1)]
	[Nullable(0)]
	public class RotatingRing
	{
		// Token: 0x06039890 RID: 235664 RVA: 0x01027974 File Offset: 0x01025B74
		public RotatingRing(AActor ringActor, float simpleRotateAngle, float rotateSpeed)
		{
			this.RingActor = ringActor;
			this.SimpleRotateAngle = (double)simpleRotateAngle;
			this.TotalSocket = (int)(360f / simpleRotateAngle);
			this.CurSocket = 0;
			this.IsShine = false;
			this.RotateSpeed = rotateSpeed;
			FRotator relativeRotation = this.RingActor.RootComponent.RelativeRotation;
			this.InitYaw = relativeRotation.Yaw;
		}

		// Token: 0x0401E5D8 RID: 124376
		public AActor RingActor;

		// Token: 0x0401E5D9 RID: 124377
		public double SimpleRotateAngle;

		// Token: 0x0401E5DA RID: 124378
		public int TotalSocket;

		// Token: 0x0401E5DB RID: 124379
		public int CurSocket;

		// Token: 0x0401E5DC RID: 124380
		public bool IsShine;

		// Token: 0x0401E5DD RID: 124381
		public float InitYaw;

		// Token: 0x0401E5DE RID: 124382
		public float RotateSpeed;
	}
}
