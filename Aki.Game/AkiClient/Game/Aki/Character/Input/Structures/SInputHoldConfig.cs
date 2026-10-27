using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x0200425C RID: 16988
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 5)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputHoldConfig.SInputHoldConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SInputHoldConfig : IEqualityOperators<SInputHoldConfig, SInputHoldConfig, bool>, IEquatable<SInputHoldConfig>, IUnrealScriptStruct
	{
		// Token: 0x0602C06B RID: 180331 RVA: 0x00A121FA File Offset: 0x00A103FA
		public SInputHoldConfig(float 触发时间, bool 连续触发)
		{
			this.触发时间 = 触发时间;
			this.连续触发 = 连续触发;
		}

		// Token: 0x0602C06C RID: 180332 RVA: 0x00A1220A File Offset: 0x00A1040A
		public static bool operator ==(SInputHoldConfig left, SInputHoldConfig right)
		{
			return left.触发时间 == right.触发时间 && left.连续触发 == right.连续触发;
		}

		// Token: 0x0602C06D RID: 180333 RVA: 0x00A1222A File Offset: 0x00A1042A
		public static bool operator !=(SInputHoldConfig left, SInputHoldConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0602C06E RID: 180334 RVA: 0x00A12236 File Offset: 0x00A10436
		public bool Equals(SInputHoldConfig other)
		{
			return this == other;
		}

		// Token: 0x0602C06F RID: 180335 RVA: 0x00A12244 File Offset: 0x00A10444
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

		// Token: 0x0602C070 RID: 180336 RVA: 0x00A12269 File Offset: 0x00A10469
		public override int GetHashCode()
		{
			return HashCode.Combine<float, bool>(this.触发时间, this.连续触发);
		}

		// Token: 0x0602C071 RID: 180337 RVA: 0x00A1227C File Offset: 0x00A1047C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputHoldConfig._ScriptStructPtr != 0) ? SInputHoldConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputHoldConfig.SInputHoldConfig", ref SInputHoldConfig._ScriptStructPtr);
		}

		// Token: 0x04016FFA RID: 94202
		[FieldOffset(0)]
		public float 触发时间;

		// Token: 0x04016FFB RID: 94203
		[FieldOffset(4)]
		public bool 连续触发;

		// Token: 0x04016FFC RID: 94204
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputHoldConfig.SInputHoldConfig";

		// Token: 0x04016FFD RID: 94205
		private static IntPtr _ScriptStructPtr;
	}
}
