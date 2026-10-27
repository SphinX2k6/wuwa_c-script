using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02004449 RID: 17481
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 13)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SFightingPressure.SFightingPressure")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SFightingPressure : IEqualityOperators<SFightingPressure, SFightingPressure, bool>, IEquatable<SFightingPressure>, IUnrealScriptStruct
	{
		// Token: 0x0602D414 RID: 185364 RVA: 0x00A37D64 File Offset: 0x00A35F64
		public SFightingPressure(float 最大攻击间隔, float 最小攻击间隔, int 同时进攻数量, bool 血量检测)
		{
			this.最大攻击间隔 = 最大攻击间隔;
			this.最小攻击间隔 = 最小攻击间隔;
			this.同时进攻数量 = 同时进攻数量;
			this.血量检测 = 血量检测;
		}

		// Token: 0x0602D415 RID: 185365 RVA: 0x00A37D83 File Offset: 0x00A35F83
		public static bool operator ==(SFightingPressure left, SFightingPressure right)
		{
			return left.最大攻击间隔 == right.最大攻击间隔 && left.最小攻击间隔 == right.最小攻击间隔 && left.同时进攻数量 == right.同时进攻数量 && left.血量检测 == right.血量检测;
		}

		// Token: 0x0602D416 RID: 185366 RVA: 0x00A37DBF File Offset: 0x00A35FBF
		public static bool operator !=(SFightingPressure left, SFightingPressure right)
		{
			return !(left == right);
		}

		// Token: 0x0602D417 RID: 185367 RVA: 0x00A37DCB File Offset: 0x00A35FCB
		public bool Equals(SFightingPressure other)
		{
			return this == other;
		}

		// Token: 0x0602D418 RID: 185368 RVA: 0x00A37DDC File Offset: 0x00A35FDC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SFightingPressure)
			{
				SFightingPressure other = (SFightingPressure)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602D419 RID: 185369 RVA: 0x00A37E01 File Offset: 0x00A36001
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, int, bool>(this.最大攻击间隔, this.最小攻击间隔, this.同时进攻数量, this.血量检测);
		}

		// Token: 0x0602D41A RID: 185370 RVA: 0x00A37E20 File Offset: 0x00A36020
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFightingPressure._ScriptStructPtr != 0) ? SFightingPressure._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SFightingPressure.SFightingPressure", ref SFightingPressure._ScriptStructPtr);
		}

		// Token: 0x04018134 RID: 98612
		[FieldOffset(0)]
		public float 最大攻击间隔;

		// Token: 0x04018135 RID: 98613
		[FieldOffset(4)]
		public float 最小攻击间隔;

		// Token: 0x04018136 RID: 98614
		[FieldOffset(8)]
		public int 同时进攻数量;

		// Token: 0x04018137 RID: 98615
		[FieldOffset(12)]
		public bool 血量检测;

		// Token: 0x04018138 RID: 98616
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SFightingPressure.SFightingPressure";

		// Token: 0x04018139 RID: 98617
		private static IntPtr _ScriptStructPtr;
	}
}
