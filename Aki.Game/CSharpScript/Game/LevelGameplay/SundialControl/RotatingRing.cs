using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SundialControl
{
	// Token: 0x02006A07 RID: 27143
	[NullableContext(1)]
	[Nullable(0)]
	public class RotatingRing
	{
		// Token: 0x06043844 RID: 276548 RVA: 0x01083350 File Offset: 0x01081550
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

		// Token: 0x040233E6 RID: 144358
		public AActor RingActor;

		// Token: 0x040233E7 RID: 144359
		public double SimpleRotateAngle;

		// Token: 0x040233E8 RID: 144360
		public int TotalSocket;

		// Token: 0x040233E9 RID: 144361
		public int CurSocket;

		// Token: 0x040233EA RID: 144362
		public bool IsShine;

		// Token: 0x040233EB RID: 144363
		public float InitYaw;

		// Token: 0x040233EC RID: 144364
		public float RotateSpeed;
	}
}
