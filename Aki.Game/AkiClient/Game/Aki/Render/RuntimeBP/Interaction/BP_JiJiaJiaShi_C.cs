using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D16 RID: 15638
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_JiJiaJiaShi.BP_JiJiaJiaShi_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1524)]
	public class BP_JiJiaJiaShi_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060257E3 RID: 153571 RVA: 0x0095B3E1 File Offset: 0x009595E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_JiJiaJiaShi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_JiJiaJiaShi.BP_JiJiaJiaShi_C");
			}
			return BP_JiJiaJiaShi_C._ClassPtr;
		}

		// Token: 0x060257E4 RID: 153572 RVA: 0x0095B408 File Offset: 0x00959608
		public BP_JiJiaJiaShi_C() : this(BuiltinUtils.AllocNativeUObject(BP_JiJiaJiaShi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060257E5 RID: 153573 RVA: 0x0095B430 File Offset: 0x00959630
		[NullableContext(1)]
		public BP_JiJiaJiaShi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_JiJiaJiaShi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x060257E6 RID: 153574 RVA: 0x0095B463 File Offset: 0x00959663
		// (set) Token: 0x060257E7 RID: 153575 RVA: 0x0095B477 File Offset: 0x00959677
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_JiJiaJiaShi_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_JiJiaJiaShi_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x060257E8 RID: 153576 RVA: 0x0095B48C File Offset: 0x0095968C
		// (set) Token: 0x060257E9 RID: 153577 RVA: 0x0095B4A0 File Offset: 0x009596A0
		public unsafe FVector BeforeVector_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x060257EA RID: 153578 RVA: 0x0095B4B5 File Offset: 0x009596B5
		// (set) Token: 0x060257EB RID: 153579 RVA: 0x0095B4C9 File Offset: 0x009596C9
		public unsafe FName LifePlay_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x060257EC RID: 153580 RVA: 0x0095B4DE File Offset: 0x009596DE
		// (set) Token: 0x060257ED RID: 153581 RVA: 0x0095B4F2 File Offset: 0x009596F2
		public unsafe FVector V_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x060257EE RID: 153582 RVA: 0x0095B507 File Offset: 0x00959707
		// (set) Token: 0x060257EF RID: 153583 RVA: 0x0095B51B File Offset: 0x0095971B
		public unsafe UNiagaraSystem NewVar_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_JiJiaJiaShi_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_JiJiaJiaShi_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x060257F0 RID: 153584 RVA: 0x0095B530 File Offset: 0x00959730
		// (set) Token: 0x060257F1 RID: 153585 RVA: 0x0095B544 File Offset: 0x00959744
		public unsafe FVector BeforeVector__Editor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_JiJiaJiaShi_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x060257F2 RID: 153586 RVA: 0x0095B559 File Offset: 0x00959759
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__DisableTick_NativeFunctionPtr, null);
		}

		// Token: 0x060257F3 RID: 153587 RVA: 0x0095B56D File Offset: 0x0095976D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__EnableTick_NativeFunctionPtr, null);
		}

		// Token: 0x060257F4 RID: 153588 RVA: 0x0095B581 File Offset: 0x00959781
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060257F5 RID: 153589 RVA: 0x0095B595 File Offset: 0x00959795
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257F6 RID: 153590 RVA: 0x0095B5AA File Offset: 0x009597AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060257F7 RID: 153591 RVA: 0x0095B5BE File Offset: 0x009597BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257F8 RID: 153592 RVA: 0x0095B5D4 File Offset: 0x009597D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_JiJiaJiaShi_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_JiJiaJiaShi_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_JiJiaJiaShi_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_JiJiaJiaShi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060257F9 RID: 153593 RVA: 0x0095B61C File Offset: 0x0095981C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_JiJiaJiaShi_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_JiJiaJiaShi_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_JiJiaJiaShi_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_JiJiaJiaShi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257FA RID: 153594 RVA: 0x0095B664 File Offset: 0x00959864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_JiJiaJiaShi_C.__EditorTick_FunctionParams* ptr = stackalloc BP_JiJiaJiaShi_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_JiJiaJiaShi_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_JiJiaJiaShi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060257FB RID: 153595 RVA: 0x0095B6AC File Offset: 0x009598AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_JiJiaJiaShi_C.__EditorTick_FunctionParams* ptr = stackalloc BP_JiJiaJiaShi_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_JiJiaJiaShi_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_JiJiaJiaShi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_JiJiaJiaShi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257FC RID: 153596 RVA: 0x0095B6F3 File Offset: 0x009598F3
		protected BP_JiJiaJiaShi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B5C RID: 76636
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_JiJiaJiaShi.BP_JiJiaJiaShi_C";

		// Token: 0x04012B5D RID: 76637
		private static IntPtr _ClassPtr;

		// Token: 0x04012B5E RID: 76638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B5F RID: 76639
		internal static int __PropertyOffset_1;

		// Token: 0x04012B60 RID: 76640
		internal static int __PropertyOffset_2;

		// Token: 0x04012B61 RID: 76641
		internal static int __PropertyOffset_3;

		// Token: 0x04012B62 RID: 76642
		internal static int __PropertyOffset_4;

		// Token: 0x04012B63 RID: 76643
		internal static int __PropertyOffset_5;

		// Token: 0x04012B64 RID: 76644
		internal static int __PropertyOffset_6;

		// Token: 0x04012B65 RID: 76645
		private static IntPtr __DisableTick_NativeFunctionPtr;

		// Token: 0x04012B66 RID: 76646
		private static IntPtr __EnableTick_NativeFunctionPtr;

		// Token: 0x04012B67 RID: 76647
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B68 RID: 76648
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012B69 RID: 76649
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012B6A RID: 76650
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A003 RID: 40963
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A9E RID: 203422
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A004 RID: 40964
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A9F RID: 203423
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
