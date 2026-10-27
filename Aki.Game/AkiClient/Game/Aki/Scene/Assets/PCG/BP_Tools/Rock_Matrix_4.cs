using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools
{
	// Token: 0x02003A6F RID: 14959
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix_4.Rock_Matrix_4")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct Rock_Matrix_4 : IEqualityOperators<Rock_Matrix_4, Rock_Matrix_4, bool>, IEquatable<Rock_Matrix_4>, IUnrealScriptStruct
	{
		// Token: 0x0601F9E5 RID: 129509 RVA: 0x008BD662 File Offset: 0x008BB862
		public Rock_Matrix_4(float m_xy, float m_xz, float m_yz, float k)
		{
			this.m_xy = m_xy;
			this.m_xz = m_xz;
			this.m_yz = m_yz;
			this.k = k;
		}

		// Token: 0x0601F9E6 RID: 129510 RVA: 0x008BD681 File Offset: 0x008BB881
		public static bool operator ==(Rock_Matrix_4 left, Rock_Matrix_4 right)
		{
			return left.m_xy == right.m_xy && left.m_xz == right.m_xz && left.m_yz == right.m_yz && left.k == right.k;
		}

		// Token: 0x0601F9E7 RID: 129511 RVA: 0x008BD6BD File Offset: 0x008BB8BD
		public static bool operator !=(Rock_Matrix_4 left, Rock_Matrix_4 right)
		{
			return !(left == right);
		}

		// Token: 0x0601F9E8 RID: 129512 RVA: 0x008BD6C9 File Offset: 0x008BB8C9
		public bool Equals(Rock_Matrix_4 other)
		{
			return this == other;
		}

		// Token: 0x0601F9E9 RID: 129513 RVA: 0x008BD6D8 File Offset: 0x008BB8D8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is Rock_Matrix_4)
			{
				Rock_Matrix_4 other = (Rock_Matrix_4)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F9EA RID: 129514 RVA: 0x008BD6FD File Offset: 0x008BB8FD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.m_xy, this.m_xz, this.m_yz, this.k);
		}

		// Token: 0x0601F9EB RID: 129515 RVA: 0x008BD71C File Offset: 0x008BB91C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Rock_Matrix_4._ScriptStructPtr != 0) ? Rock_Matrix_4._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix_4.Rock_Matrix_4", ref Rock_Matrix_4._ScriptStructPtr);
		}

		// Token: 0x0400F377 RID: 62327
		[FieldOffset(0)]
		public float m_xy;

		// Token: 0x0400F378 RID: 62328
		[FieldOffset(4)]
		public float m_xz;

		// Token: 0x0400F379 RID: 62329
		[FieldOffset(8)]
		public float m_yz;

		// Token: 0x0400F37A RID: 62330
		[FieldOffset(12)]
		public float k;

		// Token: 0x0400F37B RID: 62331
		public const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix_4.Rock_Matrix_4";

		// Token: 0x0400F37C RID: 62332
		private static IntPtr _ScriptStructPtr;
	}
}
