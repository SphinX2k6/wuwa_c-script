using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools
{
	// Token: 0x02003A6D RID: 14957
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix.Rock_Matrix")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct Rock_Matrix : IEqualityOperators<Rock_Matrix, Rock_Matrix, bool>, IEquatable<Rock_Matrix>, IUnrealScriptStruct
	{
		// Token: 0x0601F9D7 RID: 129495 RVA: 0x008BD47D File Offset: 0x008BB67D
		public Rock_Matrix(float m_xx, float m_xy, float m_xz, float m_yy, float m_yz, float m_zz)
		{
			this.m_xx = m_xx;
			this.m_xy = m_xy;
			this.m_xz = m_xz;
			this.m_yy = m_yy;
			this.m_yz = m_yz;
			this.m_zz = m_zz;
		}

		// Token: 0x0601F9D8 RID: 129496 RVA: 0x008BD4AC File Offset: 0x008BB6AC
		public static bool operator ==(Rock_Matrix left, Rock_Matrix right)
		{
			return left.m_xx == right.m_xx && left.m_xy == right.m_xy && left.m_xz == right.m_xz && left.m_yy == right.m_yy && left.m_yz == right.m_yz && left.m_zz == right.m_zz;
		}

		// Token: 0x0601F9D9 RID: 129497 RVA: 0x008BD50F File Offset: 0x008BB70F
		public static bool operator !=(Rock_Matrix left, Rock_Matrix right)
		{
			return !(left == right);
		}

		// Token: 0x0601F9DA RID: 129498 RVA: 0x008BD51B File Offset: 0x008BB71B
		public bool Equals(Rock_Matrix other)
		{
			return this == other;
		}

		// Token: 0x0601F9DB RID: 129499 RVA: 0x008BD52C File Offset: 0x008BB72C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is Rock_Matrix)
			{
				Rock_Matrix other = (Rock_Matrix)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F9DC RID: 129500 RVA: 0x008BD551 File Offset: 0x008BB751
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float, float>(this.m_xx, this.m_xy, this.m_xz, this.m_yy, this.m_yz, this.m_zz);
		}

		// Token: 0x0601F9DD RID: 129501 RVA: 0x008BD57C File Offset: 0x008BB77C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Rock_Matrix._ScriptStructPtr != 0) ? Rock_Matrix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix.Rock_Matrix", ref Rock_Matrix._ScriptStructPtr);
		}

		// Token: 0x0400F36A RID: 62314
		[FieldOffset(0)]
		public float m_xx;

		// Token: 0x0400F36B RID: 62315
		[FieldOffset(4)]
		public float m_xy;

		// Token: 0x0400F36C RID: 62316
		[FieldOffset(8)]
		public float m_xz;

		// Token: 0x0400F36D RID: 62317
		[FieldOffset(12)]
		public float m_yy;

		// Token: 0x0400F36E RID: 62318
		[FieldOffset(16)]
		public float m_yz;

		// Token: 0x0400F36F RID: 62319
		[FieldOffset(20)]
		public float m_zz;

		// Token: 0x0400F370 RID: 62320
		public const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix.Rock_Matrix";

		// Token: 0x0400F371 RID: 62321
		private static IntPtr _ScriptStructPtr;
	}
}
