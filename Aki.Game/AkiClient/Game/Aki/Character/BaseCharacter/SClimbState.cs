using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003341 RID: 13121
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 3)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SClimbState.SClimbState")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3)]
	public struct SClimbState : IEqualityOperators<SClimbState, SClimbState, bool>, IEquatable<SClimbState>, IUnrealScriptStruct
	{
		// Token: 0x060212D3 RID: 135891 RVA: 0x0095AF0C File Offset: 0x0095910C
		public SClimbState(TEnumAsByte<EClimbState> 攀爬状态, TEnumAsByte<EEnterClimb> 进入攀爬类型, TEnumAsByte<EExitClimb> 退出攀爬类型)
		{
			this.攀爬状态 = 攀爬状态;
			this.进入攀爬类型 = 进入攀爬类型;
			this.退出攀爬类型 = 退出攀爬类型;
		}

		// Token: 0x060212D4 RID: 135892 RVA: 0x0095AF23 File Offset: 0x00959123
		public static bool operator ==(SClimbState left, SClimbState right)
		{
			return left.攀爬状态 == right.攀爬状态 && left.进入攀爬类型 == right.进入攀爬类型 && left.退出攀爬类型 == right.退出攀爬类型;
		}

		// Token: 0x060212D5 RID: 135893 RVA: 0x0095AF5E File Offset: 0x0095915E
		public static bool operator !=(SClimbState left, SClimbState right)
		{
			return !(left == right);
		}

		// Token: 0x060212D6 RID: 135894 RVA: 0x0095AF6A File Offset: 0x0095916A
		public bool Equals(SClimbState other)
		{
			return this == other;
		}

		// Token: 0x060212D7 RID: 135895 RVA: 0x0095AF78 File Offset: 0x00959178
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

		// Token: 0x060212D8 RID: 135896 RVA: 0x0095AF9D File Offset: 0x0095919D
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EClimbState>, TEnumAsByte<EEnterClimb>, TEnumAsByte<EExitClimb>>(this.攀爬状态, this.进入攀爬类型, this.退出攀爬类型);
		}

		// Token: 0x060212D9 RID: 135897 RVA: 0x0095AFB6 File Offset: 0x009591B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SClimbState._ScriptStructPtr != 0) ? SClimbState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SClimbState.SClimbState", ref SClimbState._ScriptStructPtr);
		}

		// Token: 0x0401223A RID: 74298
		[FieldOffset(0)]
		public TEnumAsByte<EClimbState> 攀爬状态;

		// Token: 0x0401223B RID: 74299
		[FieldOffset(1)]
		public TEnumAsByte<EEnterClimb> 进入攀爬类型;

		// Token: 0x0401223C RID: 74300
		[FieldOffset(2)]
		public TEnumAsByte<EExitClimb> 退出攀爬类型;

		// Token: 0x0401223D RID: 74301
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SClimbState.SClimbState";

		// Token: 0x0401223E RID: 74302
		private static IntPtr _ScriptStructPtr;
	}
}
