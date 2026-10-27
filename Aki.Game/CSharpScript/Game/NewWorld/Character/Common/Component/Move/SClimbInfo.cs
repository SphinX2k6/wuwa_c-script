using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070D9 RID: 28889
	[NullableContext(1)]
	[Nullable(0)]
	public class SClimbInfo
	{
		// Token: 0x060467DB RID: 288731 RVA: 0x011B3EE1 File Offset: 0x011B20E1
		[NullableContext(2)]
		public SClimbInfo(bool? 攀爬移动中 = null, Vector2D 攀爬输入向量 = null, float? onWallAngle = null)
		{
			this.攀爬移动中 = 攀爬移动中.GetValueOrDefault();
			this.攀爬输入向量 = Vector2D.Create(攀爬输入向量);
			this.OnWallAngle = onWallAngle.GetValueOrDefault();
		}

		// Token: 0x060467DC RID: 288732 RVA: 0x011B3F10 File Offset: 0x011B2110
		[NullableContext(2)]
		public bool Equals(SClimbInfo inB)
		{
			return inB != null && this.攀爬移动中 == inB.攀爬移动中 && this.攀爬输入向量.Equals(inB.攀爬输入向量, 9.999999747378752E-05) && Math.Abs(this.OnWallAngle - inB.OnWallAngle) < 1E-08f;
		}

		// Token: 0x060467DD RID: 288733 RVA: 0x011B3F65 File Offset: 0x011B2165
		public void DeepCopy(SClimbInfo other)
		{
			this.攀爬移动中 = other.攀爬移动中;
			this.攀爬输入向量.DeepCopy(other.攀爬输入向量);
			this.OnWallAngle = other.OnWallAngle;
		}

		// Token: 0x060467DE RID: 288734 RVA: 0x011B3F90 File Offset: 0x011B2190
		public SClimbInfo Copy()
		{
			Vector2D vector2D = Vector2D.Create(this.攀爬输入向量);
			return new SClimbInfo(new bool?(this.攀爬移动中), vector2D, new float?(this.OnWallAngle));
		}

		// Token: 0x04024F29 RID: 151337
		public bool 攀爬移动中;

		// Token: 0x04024F2A RID: 151338
		public Vector2D 攀爬输入向量;

		// Token: 0x04024F2B RID: 151339
		public float OnWallAngle;
	}
}
