using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02006DE5 RID: 28133
	[NullableContext(1)]
	[Nullable(0)]
	public class ConeRangeChecker : ItemInspectRangeChecker
	{
		// Token: 0x06044A0C RID: 281100 RVA: 0x010EFC6C File Offset: 0x010EDE6C
		protected override void OnInit(IShapeParams @params)
		{
			ConeShapeParams coneShapeParams = (ConeShapeParams)@params;
			this.Rotation.Vector(this.UpToDownVector);
			this.Height = coneShapeParams.Height;
			this.Radius = coneShapeParams.Radius;
		}

		// Token: 0x06044A0D RID: 281101 RVA: 0x010EFCA9 File Offset: 0x010EDEA9
		public override bool IsPointInside(IVector point)
		{
			this.TempVector.DeepCopy(point);
			return MathUtils.Instance.IsLocationInsideCone(this.Location, this.UpToDownVector, (double)this.Height, (double)this.Radius, this.TempVector);
		}

		// Token: 0x06044A0E RID: 281102 RVA: 0x010EFCE4 File Offset: 0x010EDEE4
		public override void DebugDraw()
		{
			float height = this.Height;
			float radius = this.Radius;
			float length = (float)Math.Sqrt((double)(height * height + radius * radius));
			float num = (float)Math.Atan((double)(radius / height));
			UKismetSystemLibrary.D_DrawDebugCone(GlobalData.World, this.Location.ToUeVector(false), this.UpToDownVector.ToUeVector(false), length, num, num, 12, ColorUtils.LinearRed, 1f, 0f);
		}

		// Token: 0x04023B33 RID: 146227
		protected readonly Vector UpToDownVector = Vector.Create();

		// Token: 0x04023B34 RID: 146228
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04023B35 RID: 146229
		private float Height;

		// Token: 0x04023B36 RID: 146230
		private float Radius;
	}
}
