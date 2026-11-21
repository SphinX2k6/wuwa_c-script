using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006389 RID: 25481
	[NullableContext(1)]
	[Nullable(0)]
	public class SClimbInfo
	{
		// Token: 0x0603DBC3 RID: 252867 RVA: 0x011E38BD File Offset: 0x011E1ABD
		[NullableContext(2)]
		public SClimbInfo(bool? 攀爬移动中 = null, Vector2D 攀爬输入向量 = null, float? onWallAngle = null)
		{
			this.攀爬移动中 = 攀爬移动中.GetValueOrDefault();
			this.攀爬输入向量 = Vector2D.Create(攀爬输入向量);
			this.OnWallAngle = onWallAngle.GetValueOrDefault();
		}

		// Token: 0x0603DBC4 RID: 252868 RVA: 0x011E38EC File Offset: 0x011E1AEC
		[NullableContext(2)]
		public bool Equals(SClimbInfo inB)
		{
			return inB != null && this.攀爬移动中 == inB.攀爬移动中 && this.攀爬输入向量.Equals(inB.攀爬输入向量, 9.999999747378752E-05) && Math.Abs(this.OnWallAngle - inB.OnWallAngle) < 1E-08f;
		}

		// Token: 0x0603DBC5 RID: 252869 RVA: 0x011E3941 File Offset: 0x011E1B41
		public void DeepCopy(SClimbInfo other)
		{
			this.攀爬移动中 = other.攀爬移动中;
			this.攀爬输入向量.DeepCopy(other.攀爬输入向量);
			this.OnWallAngle = other.OnWallAngle;
		}

		// Token: 0x0603DBC6 RID: 252870 RVA: 0x011E396C File Offset: 0x011E1B6C
		public SClimbInfo Copy()
		{
			Vector2D vector2D = Vector2D.Create(this.攀爬输入向量);
			return new SClimbInfo(new bool?(this.攀爬移动中), vector2D, new float?(this.OnWallAngle));
		}

		// Token: 0x04020BBC RID: 134076
		public bool 攀爬移动中;

		// Token: 0x04020BBD RID: 134077
		public Vector2D 攀爬输入向量;

		// Token: 0x04020BBE RID: 134078
		public float OnWallAngle;
	}
}
