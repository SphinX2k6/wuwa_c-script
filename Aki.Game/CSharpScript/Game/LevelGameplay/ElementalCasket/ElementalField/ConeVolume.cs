using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006013 RID: 24595
	[NullableContext(1)]
	[Nullable(0)]
	public class ConeVolume : IElementalFieldVolume
	{
		// Token: 0x0603B175 RID: 242037 RVA: 0x010B711C File Offset: 0x010B531C
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

		// Token: 0x0603B176 RID: 242038 RVA: 0x010B71FC File Offset: 0x010B53FC
		public bool ContainsPoint(Vector point)
		{
			return MathUtils.Instance.IsLocationInsideCone(this.Apex, this.Axis, this.Height, this.Radius, point);
		}

		// Token: 0x0603B177 RID: 242039 RVA: 0x010B7224 File Offset: 0x010B5424
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

		// Token: 0x0603B178 RID: 242040 RVA: 0x010B72BC File Offset: 0x010B54BC
		public void DebugDraw()
		{
			UKismetSystemLibrary.D_DrawDebugCone(GlobalData.World, this.Apex.ToUeVector(false), this.Axis.ToUeVector(false), (float)this.Height, (float)this.HalfAngle, (float)this.HalfAngle, 16, ElementalCasketDefine.activeVolumeDebugDrawColor, 0.2f, 1f);
		}

		// Token: 0x0401F16F RID: 127343
		[StaticVariableRuleIgnore]
		private static readonly Stat coneIntersectsSegmentStat = Stat.Create("ElementalFieldVolume.Cone.IntersectsSegment", "", "");

		// Token: 0x0401F170 RID: 127344
		private readonly Vector Apex = Vector.Create();

		// Token: 0x0401F171 RID: 127345
		private readonly Vector Axis = Vector.Create();

		// Token: 0x0401F172 RID: 127346
		private readonly double Height;

		// Token: 0x0401F173 RID: 127347
		private readonly double Radius;

		// Token: 0x0401F174 RID: 127348
		private readonly double HalfAngle;

		// Token: 0x0401F175 RID: 127349
		private readonly double FeatureSize;

		// Token: 0x0401F176 RID: 127350
		[StaticVariableRuleIgnore]
		private static readonly Vector TempSamplePoint = Vector.Create();
	}
}
