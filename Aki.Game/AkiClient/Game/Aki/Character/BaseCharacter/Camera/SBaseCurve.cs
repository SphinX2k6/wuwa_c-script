using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C2 RID: 17346
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SBaseCurve.SBaseCurve")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SBaseCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CD73 RID: 183667 RVA: 0x00A2A0FC File Offset: 0x00A282FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBaseCurve._ScriptStructPtr != 0) ? SBaseCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SBaseCurve.SBaseCurve", ref SBaseCurve._ScriptStructPtr);
		}

		// Token: 0x1700710B RID: 28939
		// (get) Token: 0x0602CD74 RID: 183668 RVA: 0x00A2A120 File Offset: 0x00A28320
		// (set) Token: 0x0602CD75 RID: 183669 RVA: 0x00A2A134 File Offset: 0x00A28334
		public unsafe TEnumAsByte<EBaseCurveType> CurveType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700710C RID: 28940
		// (get) Token: 0x0602CD76 RID: 183670 RVA: 0x00A2A149 File Offset: 0x00A28349
		// (set) Token: 0x0602CD77 RID: 183671 RVA: 0x00A2A159 File Offset: 0x00A28359
		public unsafe float N
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700710D RID: 28941
		// (get) Token: 0x0602CD78 RID: 183672 RVA: 0x00A2A16A File Offset: 0x00A2836A
		// (set) Token: 0x0602CD79 RID: 183673 RVA: 0x00A2A17E File Offset: 0x00A2837E
		[Nullable(2)]
		public unsafe UCurveFloat FloatCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SBaseCurve.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBaseCurve.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602CD7A RID: 183674 RVA: 0x00A2A193 File Offset: 0x00A28393
		public SBaseCurve()
		{
		}

		// Token: 0x0602CD7B RID: 183675 RVA: 0x00A2A19B File Offset: 0x00A2839B
		public SBaseCurve(TEnumAsByte<EBaseCurveType> CurveType, float N, [Nullable(1)] UCurveFloat FloatCurve)
		{
			this.CurveType = CurveType;
			this.N = N;
			this.FloatCurve = FloatCurve;
		}

		// Token: 0x0602CD7C RID: 183676 RVA: 0x00A2A1B8 File Offset: 0x00A283B8
		protected override IntPtr GetUStructPtr()
		{
			return SBaseCurve.StaticStruct();
		}

		// Token: 0x0602CD7D RID: 183677 RVA: 0x00A2A1C4 File Offset: 0x00A283C4
		[NullableContext(2)]
		public SBaseCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CD7E RID: 183678 RVA: 0x00A2A1CE File Offset: 0x00A283CE
		public SBaseCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CD7F RID: 183679 RVA: 0x00A2A1D9 File Offset: 0x00A283D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBaseCurve(Pointer, false, true);
		}

		// Token: 0x0602CD80 RID: 183680 RVA: 0x00A2A1E3 File Offset: 0x00A283E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBaseCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04017CA0 RID: 97440
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SBaseCurve.SBaseCurve";

		// Token: 0x04017CA1 RID: 97441
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017CA2 RID: 97442
		internal static int __PropertyOffset_0;

		// Token: 0x04017CA3 RID: 97443
		internal static int __PropertyOffset_1;

		// Token: 0x04017CA4 RID: 97444
		internal static int __PropertyOffset_2;
	}
}
