using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02005F64 RID: 24420
	[NullableContext(1)]
	[Nullable(0)]
	public class ConeRangeChecker : ItemInspectRangeChecker
	{
		// Token: 0x0603AB70 RID: 240496 RVA: 0x01099EB8 File Offset: 0x010980B8
		protected override void OnInit(IShapeParams @params)
		{
			ConeShapeParams coneShapeParams = (ConeShapeParams)@params;
			this.Rotation.Vector(this.UpToDownVector);
			this.Height = coneShapeParams.Height;
			this.Radius = coneShapeParams.Radius;
		}

		// Token: 0x0603AB71 RID: 240497 RVA: 0x01099EF5 File Offset: 0x010980F5
		public override bool IsPointInside(IVector point)
		{
			this.TempVector.DeepCopy(point);
			return MathUtils.Instance.IsLocationInsideCone(this.Location, this.UpToDownVector, (double)this.Height, (double)this.Radius, this.TempVector);
		}

		// Token: 0x0603AB72 RID: 240498 RVA: 0x01099F30 File Offset: 0x01098130
		public override void DebugDraw()
		{
			float height = this.Height;
			float radius = this.Radius;
			float length = (float)Math.Sqrt((double)(height * height + radius * radius));
			float num = (float)Math.Atan((double)(radius / height));
			UKismetSystemLibrary.D_DrawDebugCone(GlobalData.World, this.Location.ToUeVector(false), this.UpToDownVector.ToUeVector(false), length, num, num, 12, ColorUtils.LinearRed, 1f, 0f);
		}

		// Token: 0x0401EDD5 RID: 126421
		protected readonly Vector UpToDownVector = Vector.Create();

		// Token: 0x0401EDD6 RID: 126422
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401EDD7 RID: 126423
		private float Height;

		// Token: 0x0401EDD8 RID: 126424
		private float Radius;
	}
}
