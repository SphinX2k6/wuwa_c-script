using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SlowWater
{
	// Token: 0x02003BFA RID: 15354
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SlowWater.BP_SlowWater_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class BP_SlowWater_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022ECB RID: 143051 RVA: 0x00915F65 File Offset: 0x00914165
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SlowWater_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SlowWater.BP_SlowWater_C");
			}
			return BP_SlowWater_C._ClassPtr;
		}

		// Token: 0x06022ECC RID: 143052 RVA: 0x00915F8C File Offset: 0x0091418C
		public BP_SlowWater_C() : this(BuiltinUtils.AllocNativeUObject(BP_SlowWater_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022ECD RID: 143053 RVA: 0x00915FB4 File Offset: 0x009141B4
		[NullableContext(1)]
		public BP_SlowWater_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SlowWater_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x06022ECE RID: 143054 RVA: 0x00915FE7 File Offset: 0x009141E7
		// (set) Token: 0x06022ECF RID: 143055 RVA: 0x00915FFB File Offset: 0x009141FB
		public unsafe UNiagaraComponent NS_SlowWater
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWater_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWater_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x06022ED0 RID: 143056 RVA: 0x00916010 File Offset: 0x00914210
		// (set) Token: 0x06022ED1 RID: 143057 RVA: 0x00916024 File Offset: 0x00914224
		public unsafe UStaticMeshComponent SM_SlowWater
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWater_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWater_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x06022ED2 RID: 143058 RVA: 0x00916039 File Offset: 0x00914239
		// (set) Token: 0x06022ED3 RID: 143059 RVA: 0x0091604D File Offset: 0x0091424D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWater_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SlowWater_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x06022ED4 RID: 143060 RVA: 0x00916062 File Offset: 0x00914262
		// (set) Token: 0x06022ED5 RID: 143061 RVA: 0x00916072 File Offset: 0x00914272
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x06022ED6 RID: 143062 RVA: 0x00916083 File Offset: 0x00914283
		// (set) Token: 0x06022ED7 RID: 143063 RVA: 0x00916093 File Offset: 0x00914293
		public unsafe bool AutoTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x06022ED8 RID: 143064 RVA: 0x009160A4 File Offset: 0x009142A4
		// (set) Token: 0x06022ED9 RID: 143065 RVA: 0x009160B4 File Offset: 0x009142B4
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x06022EDA RID: 143066 RVA: 0x009160C5 File Offset: 0x009142C5
		// (set) Token: 0x06022EDB RID: 143067 RVA: 0x009160D5 File Offset: 0x009142D5
		public unsafe float RollSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SlowWater_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06022EDC RID: 143068 RVA: 0x009160E8 File Offset: 0x009142E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SlowWater_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SlowWater_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWater_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SlowWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022EDD RID: 143069 RVA: 0x00916130 File Offset: 0x00914330
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SlowWater_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SlowWater_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWater_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SlowWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022EDE RID: 143070 RVA: 0x00916178 File Offset: 0x00914378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SlowWater_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SlowWater_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWater_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SlowWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022EDF RID: 143071 RVA: 0x009161C0 File Offset: 0x009143C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SlowWater_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SlowWater_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SlowWater_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SlowWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SlowWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022EE0 RID: 143072 RVA: 0x00916207 File Offset: 0x00914407
		protected BP_SlowWater_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011307 RID: 70407
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SlowWater.BP_SlowWater_C";

		// Token: 0x04011308 RID: 70408
		private static IntPtr _ClassPtr;

		// Token: 0x04011309 RID: 70409
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401130A RID: 70410
		internal static int __PropertyOffset_1;

		// Token: 0x0401130B RID: 70411
		internal static int __PropertyOffset_2;

		// Token: 0x0401130C RID: 70412
		internal static int __PropertyOffset_3;

		// Token: 0x0401130D RID: 70413
		internal static int __PropertyOffset_4;

		// Token: 0x0401130E RID: 70414
		internal static int __PropertyOffset_5;

		// Token: 0x0401130F RID: 70415
		internal static int __PropertyOffset_6;

		// Token: 0x04011310 RID: 70416
		internal static int __PropertyOffset_7;

		// Token: 0x04011311 RID: 70417
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011312 RID: 70418
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009DF1 RID: 40433
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403160C RID: 202252
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DF2 RID: 40434
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403160D RID: 202253
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
