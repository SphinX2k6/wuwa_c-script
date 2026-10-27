using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SlowWater
{
	// Token: 0x02003BF9 RID: 15353
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SlowWaterHoriz.BP_SlowWaterHoriz_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class BP_SlowWaterHoriz_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022EAD RID: 143021 RVA: 0x00915C1D File Offset: 0x00913E1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SlowWaterHoriz_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SlowWaterHoriz.BP_SlowWaterHoriz_C");
			}
			return BP_SlowWaterHoriz_C._ClassPtr;
		}

		// Token: 0x06022EAE RID: 143022 RVA: 0x00915C44 File Offset: 0x00913E44
		public BP_SlowWaterHoriz_C() : this(BuiltinUtils.AllocNativeUObject(BP_SlowWaterHoriz_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022EAF RID: 143023 RVA: 0x00915C6C File Offset: 0x00913E6C
		[NullableContext(1)]
		public BP_SlowWaterHoriz_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SlowWaterHoriz_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x06022EB0 RID: 143024 RVA: 0x00915C9F File Offset: 0x00913E9F
		// (set) Token: 0x06022EB1 RID: 143025 RVA: 0x00915CB3 File Offset: 0x00913EB3
		public unsafe UStaticMeshComponent SM_Water_Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x06022EB2 RID: 143026 RVA: 0x00915CC8 File Offset: 0x00913EC8
		// (set) Token: 0x06022EB3 RID: 143027 RVA: 0x00915CDC File Offset: 0x00913EDC
		public unsafe UStaticMeshComponent SM_SlowWater_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x06022EB4 RID: 143028 RVA: 0x00915CF1 File Offset: 0x00913EF1
		// (set) Token: 0x06022EB5 RID: 143029 RVA: 0x00915D05 File Offset: 0x00913F05
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x06022EB6 RID: 143030 RVA: 0x00915D1A File Offset: 0x00913F1A
		// (set) Token: 0x06022EB7 RID: 143031 RVA: 0x00915D2A File Offset: 0x00913F2A
		public unsafe float NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x06022EB8 RID: 143032 RVA: 0x00915D3B File Offset: 0x00913F3B
		// (set) Token: 0x06022EB9 RID: 143033 RVA: 0x00915D4B File Offset: 0x00913F4B
		public unsafe float NewVar_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x06022EBA RID: 143034 RVA: 0x00915D5C File Offset: 0x00913F5C
		// (set) Token: 0x06022EBB RID: 143035 RVA: 0x00915D6C File Offset: 0x00913F6C
		public unsafe bool EnableTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x06022EBC RID: 143036 RVA: 0x00915D7D File Offset: 0x00913F7D
		// (set) Token: 0x06022EBD RID: 143037 RVA: 0x00915D8D File Offset: 0x00913F8D
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x06022EBE RID: 143038 RVA: 0x00915D9E File Offset: 0x00913F9E
		// (set) Token: 0x06022EBF RID: 143039 RVA: 0x00915DAE File Offset: 0x00913FAE
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWaterHoriz_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x06022EC0 RID: 143040 RVA: 0x00915DBF File Offset: 0x00913FBF
		// (set) Token: 0x06022EC1 RID: 143041 RVA: 0x00915DD3 File Offset: 0x00913FD3
		public unsafe UMaterialInterface MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWaterHoriz_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x06022EC2 RID: 143042 RVA: 0x00915DE8 File Offset: 0x00913FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022EC3 RID: 143043 RVA: 0x00915DFC File Offset: 0x00913FFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022EC4 RID: 143044 RVA: 0x00915E14 File Offset: 0x00914014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SlowWaterHoriz_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SlowWaterHoriz_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWaterHoriz_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWaterHoriz_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022EC5 RID: 143045 RVA: 0x00915E5C File Offset: 0x0091405C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SlowWaterHoriz_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SlowWaterHoriz_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWaterHoriz_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWaterHoriz_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022EC6 RID: 143046 RVA: 0x00915EA4 File Offset: 0x009140A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SlowWaterHoriz_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SlowWaterHoriz_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWaterHoriz_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWaterHoriz_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022EC7 RID: 143047 RVA: 0x00915EEC File Offset: 0x009140EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SlowWaterHoriz_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SlowWaterHoriz_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWaterHoriz_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWaterHoriz_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022EC8 RID: 143048 RVA: 0x00915F33 File Offset: 0x00914133
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022EC9 RID: 143049 RVA: 0x00915F47 File Offset: 0x00914147
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SlowWaterHoriz_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022ECA RID: 143050 RVA: 0x00915F5C File Offset: 0x0091415C
		protected BP_SlowWaterHoriz_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112F7 RID: 70391
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SlowWaterHoriz.BP_SlowWaterHoriz_C";

		// Token: 0x040112F8 RID: 70392
		private static IntPtr _ClassPtr;

		// Token: 0x040112F9 RID: 70393
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112FA RID: 70394
		internal static int __PropertyOffset_1;

		// Token: 0x040112FB RID: 70395
		internal static int __PropertyOffset_2;

		// Token: 0x040112FC RID: 70396
		internal static int __PropertyOffset_3;

		// Token: 0x040112FD RID: 70397
		internal static int __PropertyOffset_4;

		// Token: 0x040112FE RID: 70398
		internal static int __PropertyOffset_5;

		// Token: 0x040112FF RID: 70399
		internal static int __PropertyOffset_6;

		// Token: 0x04011300 RID: 70400
		internal static int __PropertyOffset_7;

		// Token: 0x04011301 RID: 70401
		internal static int __PropertyOffset_8;

		// Token: 0x04011302 RID: 70402
		internal static int __PropertyOffset_9;

		// Token: 0x04011303 RID: 70403
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011304 RID: 70404
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011305 RID: 70405
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011306 RID: 70406
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009DEF RID: 40431
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403160A RID: 202250
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DF0 RID: 40432
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403160B RID: 202251
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
