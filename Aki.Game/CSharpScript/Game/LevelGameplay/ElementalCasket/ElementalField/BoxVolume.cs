using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E94 RID: 28308
	[NullableContext(1)]
	[Nullable(0)]
	public class BoxVolume : IElementalFieldVolume
	{
		// Token: 0x06044FD9 RID: 282585 RVA: 0x0110D25C File Offset: 0x0110B45C
		public BoxVolume(double centerX, double centerY, double centerZ, double halfX, double halfY, double halfZ)
		{
			this.Center.Set(centerX, centerY, centerZ);
			this.HalfSize.Set(halfX, halfY, halfZ);
			this.FeatureSize = Math.Min(Math.Min(halfX, halfY), halfZ) * 2.0;
		}

		// Token: 0x06044FDA RID: 282586 RVA: 0x0110D2C4 File Offset: 0x0110B4C4
		public bool ContainsPoint(Vector point)
		{
			return Math.Abs(point.X - this.Center.X) <= this.HalfSize.X && Math.Abs(point.Y - this.Center.Y) <= this.HalfSize.Y && Math.Abs(point.Z - this.Center.Z) <= this.HalfSize.Z;
		}

		// Token: 0x06044FDB RID: 282587 RVA: 0x0110D344 File Offset: 0x0110B544
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

		// Token: 0x06044FDC RID: 282588 RVA: 0x0110D3DC File Offset: 0x0110B5DC
		public void DebugDraw()
		{
			UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, this.Center.ToUeVector(false), this.HalfSize.ToUeVector(false), ElementalCasketDefine.activeVolumeDebugDrawColor, default(FRotator), 0.2f, 1f);
		}

		// Token: 0x04023EC4 RID: 147140
		[StaticVariableRuleIgnore]
		private static readonly Stat boxIntersectsSegmentStat = Stat.Create("ElementalFieldVolume.Box.IntersectsSegment", "", "");

		// Token: 0x04023EC5 RID: 147141
		private readonly Vector Center = Vector.Create();

		// Token: 0x04023EC6 RID: 147142
		private readonly Vector HalfSize = Vector.Create();

		// Token: 0x04023EC7 RID: 147143
		private readonly double FeatureSize;

		// Token: 0x04023EC8 RID: 147144
		[StaticVariableRuleIgnore]
		private static readonly Vector TempSamplePoint = Vector.Create();
	}
}
