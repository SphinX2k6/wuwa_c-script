using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x020032CD RID: 13005
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 2)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputAction.SInputAction")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2)]
	public struct SInputAction : IEqualityOperators<SInputAction, SInputAction, bool>, IEquatable<SInputAction>, IUnrealScriptStruct
	{
		// Token: 0x06020F38 RID: 134968 RVA: 0x009535AB File Offset: 0x009517AB
		public SInputAction(TEnumAsByte<EInputAction> Action, TEnumAsByte<EInputState> State)
		{
			this.Action = Action;
			this.State = State;
		}

		// Token: 0x06020F39 RID: 134969 RVA: 0x009535BB File Offset: 0x009517BB
		public static bool operator ==(SInputAction left, SInputAction right)
		{
			return left.Action == right.Action && left.State == right.State;
		}

		// Token: 0x06020F3A RID: 134970 RVA: 0x009535E3 File Offset: 0x009517E3
		public static bool operator !=(SInputAction left, SInputAction right)
		{
			return !(left == right);
		}

		// Token: 0x06020F3B RID: 134971 RVA: 0x009535EF File Offset: 0x009517EF
		public bool Equals(SInputAction other)
		{
			return this == other;
		}

		// Token: 0x06020F3C RID: 134972 RVA: 0x00953600 File Offset: 0x00951800
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SInputAction)
			{
				SInputAction other = (SInputAction)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06020F3D RID: 134973 RVA: 0x00953625 File Offset: 0x00951825
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EInputAction>, TEnumAsByte<EInputState>>(this.Action, this.State);
		}

		// Token: 0x06020F3E RID: 134974 RVA: 0x00953638 File Offset: 0x00951838
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputAction._ScriptStructPtr != 0) ? SInputAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputAction.SInputAction", ref SInputAction._ScriptStructPtr);
		}

		// Token: 0x04011D9A RID: 73114
		[FieldOffset(0)]
		public TEnumAsByte<EInputAction> Action;

		// Token: 0x04011D9B RID: 73115
		[FieldOffset(1)]
		public TEnumAsByte<EInputState> State;

		// Token: 0x04011D9C RID: 73116
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputAction.SInputAction";

		// Token: 0x04011D9D RID: 73117
		private static IntPtr _ScriptStructPtr;
	}
}
