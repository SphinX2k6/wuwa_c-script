using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200445A RID: 17498
	[HasGetTypeHash]
	[UnrealObjectPath("/ImpostorBaker/ImpostorBaker/BP/Structs/LightingState.LightingState")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class LightingState : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D481 RID: 185473 RVA: 0x00A385DA File Offset: 0x00A367DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (LightingState._ScriptStructPtr != 0) ? LightingState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/ImpostorBaker/ImpostorBaker/BP/Structs/LightingState.LightingState", ref LightingState._ScriptStructPtr);
		}

		// Token: 0x170072DA RID: 29402
		// (get) Token: 0x0602D482 RID: 185474 RVA: 0x00A385FE File Offset: 0x00A367FE
		// (set) Token: 0x0602D483 RID: 185475 RVA: 0x00A38612 File Offset: 0x00A36812
		[Nullable(2)]
		public unsafe ALight Light
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALight>(base.NativePtr / (IntPtr)sizeof(void*) + LightingState.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LightingState.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170072DB RID: 29403
		// (get) Token: 0x0602D484 RID: 185476 RVA: 0x00A38627 File Offset: 0x00A36827
		// (set) Token: 0x0602D485 RID: 185477 RVA: 0x00A38637 File Offset: 0x00A36837
		public unsafe bool Visible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)LightingState.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)LightingState.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602D486 RID: 185478 RVA: 0x00A38648 File Offset: 0x00A36848
		public LightingState()
		{
		}

		// Token: 0x0602D487 RID: 185479 RVA: 0x00A38650 File Offset: 0x00A36850
		[NullableContext(1)]
		public LightingState(ALight Light, bool Visible)
		{
			this.Light = Light;
			this.Visible = Visible;
		}

		// Token: 0x0602D488 RID: 185480 RVA: 0x00A38666 File Offset: 0x00A36866
		protected override IntPtr GetUStructPtr()
		{
			return LightingState.StaticStruct();
		}

		// Token: 0x0602D489 RID: 185481 RVA: 0x00A38672 File Offset: 0x00A36872
		[NullableContext(2)]
		public LightingState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D48A RID: 185482 RVA: 0x00A3867C File Offset: 0x00A3687C
		public LightingState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D48B RID: 185483 RVA: 0x00A38687 File Offset: 0x00A36887
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new LightingState(Pointer, false, true);
		}

		// Token: 0x0602D48C RID: 185484 RVA: 0x00A38691 File Offset: 0x00A36891
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new LightingState(Pointer, MemoryOwner);
		}

		// Token: 0x040181A3 RID: 98723
		[Nullable(1)]
		public const string __ObjectPath = "/ImpostorBaker/ImpostorBaker/BP/Structs/LightingState.LightingState";

		// Token: 0x040181A4 RID: 98724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040181A5 RID: 98725
		internal static int __PropertyOffset_0;

		// Token: 0x040181A6 RID: 98726
		internal static int __PropertyOffset_1;
	}
}
