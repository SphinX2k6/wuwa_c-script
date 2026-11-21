using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x020032D0 RID: 13008
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 5)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputHoldConfig.SInputHoldConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SInputHoldConfig : IEqualityOperators<SInputHoldConfig, SInputHoldConfig, bool>, IEquatable<SInputHoldConfig>, IUnrealScriptStruct
	{
		// Token: 0x06020F53 RID: 134995 RVA: 0x009537F1 File Offset: 0x009519F1
		public SInputHoldConfig(float 触发时间, bool 连续触发)
		{
			this.触发时间 = 触发时间;
			this.连续触发 = 连续触发;
		}

		// Token: 0x06020F54 RID: 134996 RVA: 0x00953801 File Offset: 0x00951A01
		public static bool operator ==(SInputHoldConfig left, SInputHoldConfig right)
		{
			return left.触发时间 == right.触发时间 && left.连续触发 == right.连续触发;
		}

		// Token: 0x06020F55 RID: 134997 RVA: 0x00953821 File Offset: 0x00951A21
		public static bool operator !=(SInputHoldConfig left, SInputHoldConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06020F56 RID: 134998 RVA: 0x0095382D File Offset: 0x00951A2D
		public bool Equals(SInputHoldConfig other)
		{
			return this == other;
		}

		// Token: 0x06020F57 RID: 134999 RVA: 0x0095383C File Offset: 0x00951A3C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SInputHoldConfig)
			{
				SInputHoldConfig other = (SInputHoldConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06020F58 RID: 135000 RVA: 0x00953861 File Offset: 0x00951A61
		public override int GetHashCode()
		{
			return HashCode.Combine<float, bool>(this.触发时间, this.连续触发);
		}

		// Token: 0x06020F59 RID: 135001 RVA: 0x00953874 File Offset: 0x00951A74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputHoldConfig._ScriptStructPtr != 0) ? SInputHoldConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputHoldConfig.SInputHoldConfig", ref SInputHoldConfig._ScriptStructPtr);
		}

		// Token: 0x04011DA8 RID: 73128
		[FieldOffset(0)]
		public float 触发时间;

		// Token: 0x04011DA9 RID: 73129
		[FieldOffset(4)]
		public bool 连续触发;

		// Token: 0x04011DAA RID: 73130
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputHoldConfig.SInputHoldConfig";

		// Token: 0x04011DAB RID: 73131
		private static IntPtr _ScriptStructPtr;
	}
}
