using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033DD RID: 13277
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SBaseCurve.SBaseCurve")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SBaseCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602197C RID: 137596 RVA: 0x00964CAB File Offset: 0x00962EAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBaseCurve._ScriptStructPtr != 0) ? SBaseCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SBaseCurve.SBaseCurve", ref SBaseCurve._ScriptStructPtr);
		}

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x0602197D RID: 137597 RVA: 0x00964CCF File Offset: 0x00962ECF
		// (set) Token: 0x0602197E RID: 137598 RVA: 0x00964CE3 File Offset: 0x00962EE3
		public unsafe TEnumAsByte<EBaseCurveType> CurveType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_CurveType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_CurveType) = value;
			}
		}

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x0602197F RID: 137599 RVA: 0x00964CF8 File Offset: 0x00962EF8
		// (set) Token: 0x06021980 RID: 137600 RVA: 0x00964D08 File Offset: 0x00962F08
		public unsafe float N
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_N);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBaseCurve.__PropertyOffset_N) = value;
			}
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x06021981 RID: 137601 RVA: 0x00964D19 File Offset: 0x00962F19
		// (set) Token: 0x06021982 RID: 137602 RVA: 0x00964D2D File Offset: 0x00962F2D
		[Nullable(2)]
		public unsafe UCurveFloat FloatCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SBaseCurve.__PropertyOffset_FloatCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBaseCurve.__PropertyOffset_FloatCurve, value);
			}
		}

		// Token: 0x06021983 RID: 137603 RVA: 0x00964D42 File Offset: 0x00962F42
		public SBaseCurve()
		{
		}

		// Token: 0x06021984 RID: 137604 RVA: 0x00964D4A File Offset: 0x00962F4A
		protected override IntPtr GetUStructPtr()
		{
			return SBaseCurve.StaticStruct();
		}

		// Token: 0x06021985 RID: 137605 RVA: 0x00964D56 File Offset: 0x00962F56
		[NullableContext(2)]
		public SBaseCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021986 RID: 137606 RVA: 0x00964D60 File Offset: 0x00962F60
		public SBaseCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021987 RID: 137607 RVA: 0x00964D6B File Offset: 0x00962F6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBaseCurve(Pointer, false, true);
		}

		// Token: 0x06021988 RID: 137608 RVA: 0x00964D75 File Offset: 0x00962F75
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBaseCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04012808 RID: 75784
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SBaseCurve.SBaseCurve";

		// Token: 0x04012809 RID: 75785
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401280A RID: 75786
		internal static int __PropertyOffset_CurveType;

		// Token: 0x0401280B RID: 75787
		internal static int __PropertyOffset_N;

		// Token: 0x0401280C RID: 75788
		internal static int __PropertyOffset_FloatCurve;
	}
}
