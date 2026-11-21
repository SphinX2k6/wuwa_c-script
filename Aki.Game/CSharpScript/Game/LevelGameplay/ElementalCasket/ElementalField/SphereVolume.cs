using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Container;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006012 RID: 24594
	[NullableContext(1)]
	[Nullable(0)]
	public class SphereVolume : IElementalFieldVolume
	{
		// Token: 0x0603B171 RID: 242033 RVA: 0x010B707A File Offset: 0x010B527A
		public SphereVolume(double centerX, double centerY, double centerZ, double radius)
		{
			this.Center.Set(centerX, centerY, centerZ);
			this.Radius = radius;
			this.RadiusSq = radius * radius;
		}

		// Token: 0x0603B172 RID: 242034 RVA: 0x010B70AE File Offset: 0x010B52AE
		public bool ContainsPoint(Vector point)
		{
			return Vector.DistSquared(point, this.Center) <= this.RadiusSq;
		}

		// Token: 0x0603B173 RID: 242035 RVA: 0x010B70C7 File Offset: 0x010B52C7
		public bool IntersectsSegment(Vector a, Vector b)
		{
			return GraphDefine.vector3Space.DistSquaredPointToSegment(this.Center, a, b) <= this.RadiusSq;
		}

		// Token: 0x0603B174 RID: 242036 RVA: 0x010B70E6 File Offset: 0x010B52E6
		public void DebugDraw()
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.Center.ToUeVector(false), (float)this.Radius, 16, new FLinearColor?(ElementalCasketDefine.activeVolumeDebugDrawColor), 0.2f, 1f);
		}

		// Token: 0x0401F16C RID: 127340
		private readonly Vector Center = Vector.Create();

		// Token: 0x0401F16D RID: 127341
		private readonly double Radius;

		// Token: 0x0401F16E RID: 127342
		private readonly double RadiusSq;
	}
}
