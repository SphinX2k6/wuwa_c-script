using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools
{
	// Token: 0x02003A6E RID: 14958
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix_3.Rock_Matrix_3")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct Rock_Matrix_3 : IEqualityOperators<Rock_Matrix_3, Rock_Matrix_3, bool>, IEquatable<Rock_Matrix_3>, IUnrealScriptStruct
	{
		// Token: 0x0601F9DE RID: 129502 RVA: 0x008BD5A0 File Offset: 0x008BB7A0
		public Rock_Matrix_3(float m_xy, float m_xz, float m_yz)
		{
			this.m_xy = m_xy;
			this.m_xz = m_xz;
			this.m_yz = m_yz;
		}

		// Token: 0x0601F9DF RID: 129503 RVA: 0x008BD5B7 File Offset: 0x008BB7B7
		public static bool operator ==(Rock_Matrix_3 left, Rock_Matrix_3 right)
		{
			return left.m_xy == right.m_xy && left.m_xz == right.m_xz && left.m_yz == right.m_yz;
		}

		// Token: 0x0601F9E0 RID: 129504 RVA: 0x008BD5E5 File Offset: 0x008BB7E5
		public static bool operator !=(Rock_Matrix_3 left, Rock_Matrix_3 right)
		{
			return !(left == right);
		}

		// Token: 0x0601F9E1 RID: 129505 RVA: 0x008BD5F1 File Offset: 0x008BB7F1
		public bool Equals(Rock_Matrix_3 other)
		{
			return this == other;
		}

		// Token: 0x0601F9E2 RID: 129506 RVA: 0x008BD600 File Offset: 0x008BB800
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is Rock_Matrix_3)
			{
				Rock_Matrix_3 other = (Rock_Matrix_3)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F9E3 RID: 129507 RVA: 0x008BD625 File Offset: 0x008BB825
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.m_xy, this.m_xz, this.m_yz);
		}

		// Token: 0x0601F9E4 RID: 129508 RVA: 0x008BD63E File Offset: 0x008BB83E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Rock_Matrix_3._ScriptStructPtr != 0) ? Rock_Matrix_3._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix_3.Rock_Matrix_3", ref Rock_Matrix_3._ScriptStructPtr);
		}

		// Token: 0x0400F372 RID: 62322
		[FieldOffset(0)]
		public float m_xy;

		// Token: 0x0400F373 RID: 62323
		[FieldOffset(4)]
		public float m_xz;

		// Token: 0x0400F374 RID: 62324
		[FieldOffset(8)]
		public float m_yz;

		// Token: 0x0400F375 RID: 62325
		public const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/Rock_Matrix_3.Rock_Matrix_3";

		// Token: 0x0400F376 RID: 62326
		private static IntPtr _ScriptStructPtr;
	}
}
