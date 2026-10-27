using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Container;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E92 RID: 28306
	[NullableContext(1)]
	[Nullable(0)]
	public class SphereVolume : IElementalFieldVolume
	{
		// Token: 0x06044FD0 RID: 282576 RVA: 0x0110CF9E File Offset: 0x0110B19E
		public SphereVolume(double centerX, double centerY, double centerZ, double radius)
		{
			this.Center.Set(centerX, centerY, centerZ);
			this.Radius = radius;
			this.RadiusSq = radius * radius;
		}

		// Token: 0x06044FD1 RID: 282577 RVA: 0x0110CFD2 File Offset: 0x0110B1D2
		public bool ContainsPoint(Vector point)
		{
			return Vector.DistSquared(point, this.Center) <= this.RadiusSq;
		}

		// Token: 0x06044FD2 RID: 282578 RVA: 0x0110CFEB File Offset: 0x0110B1EB
		public bool IntersectsSegment(Vector a, Vector b)
		{
			return GraphDefine.vector3Space.DistSquaredPointToSegment(this.Center, a, b) <= this.RadiusSq;
		}

		// Token: 0x06044FD3 RID: 282579 RVA: 0x0110D00A File Offset: 0x0110B20A
		public void DebugDraw()
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.Center.ToUeVector(false), (float)this.Radius, 16, new FLinearColor?(ElementalCasketDefine.activeVolumeDebugDrawColor), 0.2f, 1f);
		}

		// Token: 0x04023EB9 RID: 147129
		private readonly Vector Center = Vector.Create();

		// Token: 0x04023EBA RID: 147130
		private readonly double Radius;

		// Token: 0x04023EBB RID: 147131
		private readonly double RadiusSq;
	}
}
