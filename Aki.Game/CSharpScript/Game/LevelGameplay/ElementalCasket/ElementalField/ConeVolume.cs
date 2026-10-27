using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E93 RID: 28307
	[NullableContext(1)]
	[Nullable(0)]
	public class ConeVolume : IElementalFieldVolume
	{
		// Token: 0x06044FD4 RID: 282580 RVA: 0x0110D040 File Offset: 0x0110B240
		public ConeVolume(ISceneItemElementalFieldConeSnapshot snapshot)
		{
			this.Apex.Set(snapshot.Center.X, snapshot.Center.Y, snapshot.Center.Z);
			this.Axis.Set((double)snapshot.ConeAxis.X, (double)snapshot.ConeAxis.Y, (double)snapshot.ConeAxis.Z);
			this.Axis.Normalize(9.99999993922529E-09);
			this.Height = snapshot.ConeHeight;
			this.HalfAngle = snapshot.ConeHalfAngle;
			this.Radius = snapshot.ConeHeight * Math.Tan(snapshot.ConeHalfAngle);
			this.FeatureSize = Math.Min(this.Radius, this.Height);
		}

		// Token: 0x06044FD5 RID: 282581 RVA: 0x0110D120 File Offset: 0x0110B320
		public bool ContainsPoint(Vector point)
		{
			return MathUtils.Instance.IsLocationInsideCone(this.Apex, this.Axis, this.Height, this.Radius, point);
		}

		// Token: 0x06044FD6 RID: 282582 RVA: 0x0110D148 File Offset: 0x0110B348
		public bool IntersectsSegment(Vector a, Vector b)
		{
			Vector tempSamplePoint = ConeVolume.TempSamplePoint;
			double segmentLength = Vector.Dist(a, b);
			double num = ElementalFieldVolumeController.Instance.ComputeDynamicSampleStep(segmentLength, this.FeatureSize);
			int num2 = 0;
			while ((double)num2 <= num)
			{
				double num3 = (double)num2 / num;
				tempSamplePoint.Set(a.X + (b.X - a.X) * num3, a.Y + (b.Y - a.Y) * num3, a.Z + (b.Z - a.Z) * num3);
				if (this.ContainsPoint(tempSamplePoint))
				{
					return true;
				}
				num2++;
			}
			return false;
		}

		// Token: 0x06044FD7 RID: 282583 RVA: 0x0110D1E0 File Offset: 0x0110B3E0
		public void DebugDraw()
		{
			UKismetSystemLibrary.D_DrawDebugCone(GlobalData.World, this.Apex.ToUeVector(false), this.Axis.ToUeVector(false), (float)this.Height, (float)this.HalfAngle, (float)this.HalfAngle, 16, ElementalCasketDefine.activeVolumeDebugDrawColor, 0.2f, 1f);
		}

		// Token: 0x04023EBC RID: 147132
		[StaticVariableRuleIgnore]
		private static readonly Stat coneIntersectsSegmentStat = Stat.Create("ElementalFieldVolume.Cone.IntersectsSegment", "", "");

		// Token: 0x04023EBD RID: 147133
		private readonly Vector Apex = Vector.Create();

		// Token: 0x04023EBE RID: 147134
		private readonly Vector Axis = Vector.Create();

		// Token: 0x04023EBF RID: 147135
		private readonly double Height;

		// Token: 0x04023EC0 RID: 147136
		private readonly double Radius;

		// Token: 0x04023EC1 RID: 147137
		private readonly double HalfAngle;

		// Token: 0x04023EC2 RID: 147138
		private readonly double FeatureSize;

		// Token: 0x04023EC3 RID: 147139
		[StaticVariableRuleIgnore]
		private static readonly Vector TempSamplePoint = Vector.Create();
	}
}
