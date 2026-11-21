using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006014 RID: 24596
	[NullableContext(1)]
	[Nullable(0)]
	public class BoxVolume : IElementalFieldVolume
	{
		// Token: 0x0603B17A RID: 242042 RVA: 0x010B7338 File Offset: 0x010B5538
		public BoxVolume(double centerX, double centerY, double centerZ, double halfX, double halfY, double halfZ)
		{
			this.Center.Set(centerX, centerY, centerZ);
			this.HalfSize.Set(halfX, halfY, halfZ);
			this.FeatureSize = Math.Min(Math.Min(halfX, halfY), halfZ) * 2.0;
		}

		// Token: 0x0603B17B RID: 242043 RVA: 0x010B73A0 File Offset: 0x010B55A0
		public bool ContainsPoint(Vector point)
		{
			return Math.Abs(point.X - this.Center.X) <= this.HalfSize.X && Math.Abs(point.Y - this.Center.Y) <= this.HalfSize.Y && Math.Abs(point.Z - this.Center.Z) <= this.HalfSize.Z;
		}

		// Token: 0x0603B17C RID: 242044 RVA: 0x010B7420 File Offset: 0x010B5620
		public bool IntersectsSegment(Vector a, Vector b)
		{
			Vector tempSamplePoint = BoxVolume.TempSamplePoint;
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

		// Token: 0x0603B17D RID: 242045 RVA: 0x010B74B8 File Offset: 0x010B56B8
		public void DebugDraw()
		{
			UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, this.Center.ToUeVector(false), this.HalfSize.ToUeVector(false), ElementalCasketDefine.activeVolumeDebugDrawColor, default(FRotator), 0.2f, 1f);
		}

		// Token: 0x0401F177 RID: 127351
		[StaticVariableRuleIgnore]
		private static readonly Stat boxIntersectsSegmentStat = Stat.Create("ElementalFieldVolume.Box.IntersectsSegment", "", "");

		// Token: 0x0401F178 RID: 127352
		private readonly Vector Center = Vector.Create();

		// Token: 0x0401F179 RID: 127353
		private readonly Vector HalfSize = Vector.Create();

		// Token: 0x0401F17A RID: 127354
		private readonly double FeatureSize;

		// Token: 0x0401F17B RID: 127355
		[StaticVariableRuleIgnore]
		private static readonly Vector TempSamplePoint = Vector.Create();
	}
}
