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
	// Token: 0x02004259 RID: 16985
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 2)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputAction.SInputAction")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2)]
	public struct SInputAction : IEqualityOperators<SInputAction, SInputAction, bool>, IEquatable<SInputAction>, IUnrealScriptStruct
	{
		// Token: 0x0602C04F RID: 180303 RVA: 0x00A11F98 File Offset: 0x00A10198
		public SInputAction(TEnumAsByte<EInputAction> Action, TEnumAsByte<EInputState> State)
		{
			this.Action = Action;
			this.State = State;
		}

		// Token: 0x0602C050 RID: 180304 RVA: 0x00A11FA8 File Offset: 0x00A101A8
		public static bool operator ==(SInputAction left, SInputAction right)
		{
			return left.Action == right.Action && left.State == right.State;
		}

		// Token: 0x0602C051 RID: 180305 RVA: 0x00A11FD0 File Offset: 0x00A101D0
		public static bool operator !=(SInputAction left, SInputAction right)
		{
			return !(left == right);
		}

		// Token: 0x0602C052 RID: 180306 RVA: 0x00A11FDC File Offset: 0x00A101DC
		public bool Equals(SInputAction other)
		{
			return this == other;
		}

		// Token: 0x0602C053 RID: 180307 RVA: 0x00A11FEC File Offset: 0x00A101EC
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

		// Token: 0x0602C054 RID: 180308 RVA: 0x00A12011 File Offset: 0x00A10211
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EInputAction>, TEnumAsByte<EInputState>>(this.Action, this.State);
		}

		// Token: 0x0602C055 RID: 180309 RVA: 0x00A12024 File Offset: 0x00A10224
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputAction._ScriptStructPtr != 0) ? SInputAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputAction.SInputAction", ref SInputAction._ScriptStructPtr);
		}

		// Token: 0x04016FEC RID: 94188
		[FieldOffset(0)]
		public TEnumAsByte<EInputAction> Action;

		// Token: 0x04016FED RID: 94189
		[FieldOffset(1)]
		public TEnumAsByte<EInputState> State;

		// Token: 0x04016FEE RID: 94190
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputAction.SInputAction";

		// Token: 0x04016FEF RID: 94191
		private static IntPtr _ScriptStructPtr;
	}
}
