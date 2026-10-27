using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect
{
	// Token: 0x02003DB7 RID: 15799
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BP_EffectPreview.BP_EffectPreview_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_EffectPreview_C : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027456 RID: 160854 RVA: 0x0098CE38 File Offset: 0x0098B038
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectPreview_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectPreview.BP_EffectPreview_C");
			}
			return BP_EffectPreview_C._ClassPtr;
		}

		// Token: 0x06027457 RID: 160855 RVA: 0x0098CE5C File Offset: 0x0098B05C
		public BP_EffectPreview_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectPreview_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027458 RID: 160856 RVA: 0x0098CE84 File Offset: 0x0098B084
		[NullableContext(1)]
		public BP_EffectPreview_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectPreview_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005729 RID: 22313
		// (get) Token: 0x06027459 RID: 160857 RVA: 0x0098CEB7 File Offset: 0x0098B0B7
		// (set) Token: 0x0602745A RID: 160858 RVA: 0x0098CECB File Offset: 0x0098B0CB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPreview_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPreview_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700572A RID: 22314
		// (get) Token: 0x0602745B RID: 160859 RVA: 0x0098CEE0 File Offset: 0x0098B0E0
		// (set) Token: 0x0602745C RID: 160860 RVA: 0x0098CEF0 File Offset: 0x0098B0F0
		public unsafe int EffectView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700572B RID: 22315
		// (get) Token: 0x0602745D RID: 160861 RVA: 0x0098CF01 File Offset: 0x0098B101
		// (set) Token: 0x0602745E RID: 160862 RVA: 0x0098CF11 File Offset: 0x0098B111
		public unsafe int Transient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602745F RID: 160863 RVA: 0x0098CF22 File Offset: 0x0098B122
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectPreview_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027460 RID: 160864 RVA: 0x0098CF36 File Offset: 0x0098B136
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectPreview_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027461 RID: 160865 RVA: 0x0098CF4C File Offset: 0x0098B14C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_EffectPreview_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectPreview_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectPreview_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027462 RID: 160866 RVA: 0x0098CF94 File Offset: 0x0098B194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_EffectPreview_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectPreview_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectPreview_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027463 RID: 160867 RVA: 0x0098CFDB File Offset: 0x0098B1DB
		protected BP_EffectPreview_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D09 RID: 81161
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectPreview.BP_EffectPreview_C";

		// Token: 0x04013D0A RID: 81162
		private static IntPtr _ClassPtr;

		// Token: 0x04013D0B RID: 81163
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013D0C RID: 81164
		internal static int __PropertyOffset_1;

		// Token: 0x04013D0D RID: 81165
		internal static int __PropertyOffset_2;

		// Token: 0x04013D0E RID: 81166
		internal static int __PropertyOffset_3;

		// Token: 0x04013D0F RID: 81167
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013D10 RID: 81168
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A214 RID: 41492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E7E RID: 204414
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
