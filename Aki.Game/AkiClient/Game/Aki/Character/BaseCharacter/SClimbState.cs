using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004303 RID: 17155
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 3)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SClimbState.SClimbState")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3)]
	public struct SClimbState : IEqualityOperators<SClimbState, SClimbState, bool>, IEquatable<SClimbState>, IUnrealScriptStruct
	{
		// Token: 0x0602C5A7 RID: 181671 RVA: 0x00A1DD4C File Offset: 0x00A1BF4C
		public SClimbState(TEnumAsByte<EClimbState> 攀爬状态, TEnumAsByte<EEnterClimb> 进入攀爬类型, TEnumAsByte<EExitClimb> 退出攀爬类型)
		{
			this.攀爬状态 = 攀爬状态;
			this.进入攀爬类型 = 进入攀爬类型;
			this.退出攀爬类型 = 退出攀爬类型;
		}

		// Token: 0x0602C5A8 RID: 181672 RVA: 0x00A1DD63 File Offset: 0x00A1BF63
		public static bool operator ==(SClimbState left, SClimbState right)
		{
			return left.攀爬状态 == right.攀爬状态 && left.进入攀爬类型 == right.进入攀爬类型 && left.退出攀爬类型 == right.退出攀爬类型;
		}

		// Token: 0x0602C5A9 RID: 181673 RVA: 0x00A1DD9E File Offset: 0x00A1BF9E
		public static bool operator !=(SClimbState left, SClimbState right)
		{
			return !(left == right);
		}

		// Token: 0x0602C5AA RID: 181674 RVA: 0x00A1DDAA File Offset: 0x00A1BFAA
		public bool Equals(SClimbState other)
		{
			return this == other;
		}

		// Token: 0x0602C5AB RID: 181675 RVA: 0x00A1DDB8 File Offset: 0x00A1BFB8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SClimbState)
			{
				SClimbState other = (SClimbState)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C5AC RID: 181676 RVA: 0x00A1DDDD File Offset: 0x00A1BFDD
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EClimbState>, TEnumAsByte<EEnterClimb>, TEnumAsByte<EExitClimb>>(this.攀爬状态, this.进入攀爬类型, this.退出攀爬类型);
		}

		// Token: 0x0602C5AD RID: 181677 RVA: 0x00A1DDF6 File Offset: 0x00A1BFF6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SClimbState._ScriptStructPtr != 0) ? SClimbState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SClimbState.SClimbState", ref SClimbState._ScriptStructPtr);
		}

		// Token: 0x04017631 RID: 95793
		[FieldOffset(0)]
		public TEnumAsByte<EClimbState> 攀爬状态;

		// Token: 0x04017632 RID: 95794
		[FieldOffset(1)]
		public TEnumAsByte<EEnterClimb> 进入攀爬类型;

		// Token: 0x04017633 RID: 95795
		[FieldOffset(2)]
		public TEnumAsByte<EExitClimb> 退出攀爬类型;

		// Token: 0x04017634 RID: 95796
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SClimbState.SClimbState";

		// Token: 0x04017635 RID: 95797
		private static IntPtr _ScriptStructPtr;
	}
}
