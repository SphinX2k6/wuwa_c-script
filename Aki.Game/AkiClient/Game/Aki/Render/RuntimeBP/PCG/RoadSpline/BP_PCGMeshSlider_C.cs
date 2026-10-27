using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C24 RID: 15396
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_PCGMeshSlider.BP_PCGMeshSlider_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class BP_PCGMeshSlider_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060234DF RID: 144607 RVA: 0x009208AA File Offset: 0x0091EAAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PCGMeshSlider_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_PCGMeshSlider.BP_PCGMeshSlider_C");
			}
			return BP_PCGMeshSlider_C._ClassPtr;
		}

		// Token: 0x060234E0 RID: 144608 RVA: 0x009208D0 File Offset: 0x0091EAD0
		public BP_PCGMeshSlider_C() : this(BuiltinUtils.AllocNativeUObject(BP_PCGMeshSlider_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060234E1 RID: 144609 RVA: 0x009208F8 File Offset: 0x0091EAF8
		[NullableContext(1)]
		public BP_PCGMeshSlider_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PCGMeshSlider_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x060234E2 RID: 144610 RVA: 0x0092092B File Offset: 0x0091EB2B
		// (set) Token: 0x060234E3 RID: 144611 RVA: 0x0092093F File Offset: 0x0091EB3F
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x060234E4 RID: 144612 RVA: 0x00920954 File Offset: 0x0091EB54
		// (set) Token: 0x060234E5 RID: 144613 RVA: 0x00920968 File Offset: 0x0091EB68
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x060234E6 RID: 144614 RVA: 0x0092097D File Offset: 0x0091EB7D
		// (set) Token: 0x060234E7 RID: 144615 RVA: 0x00920991 File Offset: 0x0091EB91
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x060234E8 RID: 144616 RVA: 0x009209A6 File Offset: 0x0091EBA6
		// (set) Token: 0x060234E9 RID: 144617 RVA: 0x009209BA File Offset: 0x0091EBBA
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x060234EA RID: 144618 RVA: 0x009209CF File Offset: 0x0091EBCF
		// (set) Token: 0x060234EB RID: 144619 RVA: 0x009209E3 File Offset: 0x0091EBE3
		public unsafe USceneComponent SliderParent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x060234EC RID: 144620 RVA: 0x009209F8 File Offset: 0x0091EBF8
		// (set) Token: 0x060234ED RID: 144621 RVA: 0x00920A0C File Offset: 0x0091EC0C
		public unsafe AActor 样条线Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x060234EE RID: 144622 RVA: 0x00920A21 File Offset: 0x0091EC21
		// (set) Token: 0x060234EF RID: 144623 RVA: 0x00920A31 File Offset: 0x0091EC31
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGMeshSlider_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGMeshSlider_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x060234F0 RID: 144624 RVA: 0x00920A42 File Offset: 0x0091EC42
		// (set) Token: 0x060234F1 RID: 144625 RVA: 0x00920A56 File Offset: 0x0091EC56
		public unsafe UStaticMesh 静态模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x060234F2 RID: 144626 RVA: 0x00920A6B File Offset: 0x0091EC6B
		// (set) Token: 0x060234F3 RID: 144627 RVA: 0x00920A7F File Offset: 0x0091EC7F
		public unsafe USkeletalMesh 骨骼模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x060234F4 RID: 144628 RVA: 0x00920A94 File Offset: 0x0091EC94
		// (set) Token: 0x060234F5 RID: 144629 RVA: 0x00920AA4 File Offset: 0x0091ECA4
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGMeshSlider_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGMeshSlider_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x060234F6 RID: 144630 RVA: 0x00920AB5 File Offset: 0x0091ECB5
		// (set) Token: 0x060234F7 RID: 144631 RVA: 0x00920AC5 File Offset: 0x0091ECC5
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGMeshSlider_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGMeshSlider_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x060234F8 RID: 144632 RVA: 0x00920AD6 File Offset: 0x0091ECD6
		// (set) Token: 0x060234F9 RID: 144633 RVA: 0x00920AEA File Offset: 0x0091ECEA
		public unsafe UNiagaraSystem 粒子特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGMeshSlider_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x060234FA RID: 144634 RVA: 0x00920AFF File Offset: 0x0091ECFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 复制样条线_请根据提示操作_()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGMeshSlider_C.__复制样条线_请根据提示操作__NativeFunctionPtr, null);
		}

		// Token: 0x060234FB RID: 144635 RVA: 0x00920B14 File Offset: 0x0091ED14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_PCGMeshSlider_C.__IsEditor_FunctionParams* ptr = stackalloc BP_PCGMeshSlider_C.__IsEditor_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_PCGMeshSlider_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGMeshSlider_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGMeshSlider_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x060234FC RID: 144636 RVA: 0x00920B63 File Offset: 0x0091ED63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGMeshSlider_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060234FD RID: 144637 RVA: 0x00920B77 File Offset: 0x0091ED77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGMeshSlider_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060234FE RID: 144638 RVA: 0x00920B8C File Offset: 0x0091ED8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGMeshSlider_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060234FF RID: 144639 RVA: 0x00920BA0 File Offset: 0x0091EDA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGMeshSlider_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023500 RID: 144640 RVA: 0x00920BB8 File Offset: 0x0091EDB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PCGMeshSlider_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PCGMeshSlider_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGMeshSlider_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGMeshSlider_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGMeshSlider_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023501 RID: 144641 RVA: 0x00920C00 File Offset: 0x0091EE00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PCGMeshSlider_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PCGMeshSlider_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGMeshSlider_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGMeshSlider_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGMeshSlider_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023502 RID: 144642 RVA: 0x00920C48 File Offset: 0x0091EE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PCGMeshSlider_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PCGMeshSlider_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGMeshSlider_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGMeshSlider_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGMeshSlider_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023503 RID: 144643 RVA: 0x00920C90 File Offset: 0x0091EE90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PCGMeshSlider_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PCGMeshSlider_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGMeshSlider_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGMeshSlider_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGMeshSlider_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023504 RID: 144644 RVA: 0x00920CD7 File Offset: 0x0091EED7
		protected BP_PCGMeshSlider_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116A1 RID: 71329
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_PCGMeshSlider.BP_PCGMeshSlider_C";

		// Token: 0x040116A2 RID: 71330
		private static IntPtr _ClassPtr;

		// Token: 0x040116A3 RID: 71331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116A4 RID: 71332
		internal static int __PropertyOffset_1;

		// Token: 0x040116A5 RID: 71333
		internal static int __PropertyOffset_2;

		// Token: 0x040116A6 RID: 71334
		internal static int __PropertyOffset_3;

		// Token: 0x040116A7 RID: 71335
		internal static int __PropertyOffset_4;

		// Token: 0x040116A8 RID: 71336
		internal static int __PropertyOffset_5;

		// Token: 0x040116A9 RID: 71337
		internal static int __PropertyOffset_6;

		// Token: 0x040116AA RID: 71338
		internal static int __PropertyOffset_7;

		// Token: 0x040116AB RID: 71339
		internal static int __PropertyOffset_8;

		// Token: 0x040116AC RID: 71340
		internal static int __PropertyOffset_9;

		// Token: 0x040116AD RID: 71341
		internal static int __PropertyOffset_10;

		// Token: 0x040116AE RID: 71342
		internal static int __PropertyOffset_11;

		// Token: 0x040116AF RID: 71343
		internal static int __PropertyOffset_12;

		// Token: 0x040116B0 RID: 71344
		private static IntPtr __复制样条线_请根据提示操作__NativeFunctionPtr;

		// Token: 0x040116B1 RID: 71345
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x040116B2 RID: 71346
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040116B3 RID: 71347
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040116B4 RID: 71348
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040116B5 RID: 71349
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E56 RID: 40534
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x040316D8 RID: 202456
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x02009E57 RID: 40535
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316D9 RID: 202457
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E58 RID: 40536
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316DA RID: 202458
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
