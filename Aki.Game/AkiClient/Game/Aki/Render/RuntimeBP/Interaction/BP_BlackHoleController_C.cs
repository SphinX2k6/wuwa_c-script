using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D08 RID: 15624
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_BlackHoleController.BP_BlackHoleController_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1484)]
	public class BP_BlackHoleController_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060255D3 RID: 153043 RVA: 0x00957FB9 File Offset: 0x009561B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BlackHoleController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_BlackHoleController.BP_BlackHoleController_C");
			}
			return BP_BlackHoleController_C._ClassPtr;
		}

		// Token: 0x060255D4 RID: 153044 RVA: 0x00957FE0 File Offset: 0x009561E0
		public BP_BlackHoleController_C() : this(BuiltinUtils.AllocNativeUObject(BP_BlackHoleController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060255D5 RID: 153045 RVA: 0x00958008 File Offset: 0x00956208
		[NullableContext(1)]
		public BP_BlackHoleController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BlackHoleController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x060255D6 RID: 153046 RVA: 0x0095803B File Offset: 0x0095623B
		// (set) Token: 0x060255D7 RID: 153047 RVA: 0x0095804F File Offset: 0x0095624F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackHoleController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackHoleController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x060255D8 RID: 153048 RVA: 0x00958064 File Offset: 0x00956264
		// (set) Token: 0x060255D9 RID: 153049 RVA: 0x00958074 File Offset: 0x00956274
		public unsafe bool VisualizeTheRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x060255DA RID: 153050 RVA: 0x00958085 File Offset: 0x00956285
		// (set) Token: 0x060255DB RID: 153051 RVA: 0x00958095 File Offset: 0x00956295
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x060255DC RID: 153052 RVA: 0x009580A6 File Offset: 0x009562A6
		// (set) Token: 0x060255DD RID: 153053 RVA: 0x009580B6 File Offset: 0x009562B6
		public unsafe float Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x060255DE RID: 153054 RVA: 0x009580C7 File Offset: 0x009562C7
		// (set) Token: 0x060255DF RID: 153055 RVA: 0x009580D7 File Offset: 0x009562D7
		public unsafe float TrailSpiralScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x060255E0 RID: 153056 RVA: 0x009580E8 File Offset: 0x009562E8
		// (set) Token: 0x060255E1 RID: 153057 RVA: 0x009580F8 File Offset: 0x009562F8
		public unsafe float TrailSpiraIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BlackHoleController_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x060255E2 RID: 153058 RVA: 0x00958109 File Offset: 0x00956309
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NewFunction_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BlackHoleController_C.__NewFunction_0_NativeFunctionPtr, null);
		}

		// Token: 0x060255E3 RID: 153059 RVA: 0x00958120 File Offset: 0x00956320
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BlackHoleController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BlackHoleController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BlackHoleController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BlackHoleController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BlackHoleController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060255E4 RID: 153060 RVA: 0x00958168 File Offset: 0x00956368
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BlackHoleController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BlackHoleController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BlackHoleController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BlackHoleController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BlackHoleController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060255E5 RID: 153061 RVA: 0x009581B0 File Offset: 0x009563B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_BlackHoleController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_BlackHoleController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BlackHoleController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BlackHoleController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BlackHoleController_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060255E6 RID: 153062 RVA: 0x009581F8 File Offset: 0x009563F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_BlackHoleController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_BlackHoleController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BlackHoleController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BlackHoleController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BlackHoleController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060255E7 RID: 153063 RVA: 0x0095823F File Offset: 0x0095643F
		protected BP_BlackHoleController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A26 RID: 76326
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_BlackHoleController.BP_BlackHoleController_C";

		// Token: 0x04012A27 RID: 76327
		private static IntPtr _ClassPtr;

		// Token: 0x04012A28 RID: 76328
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A29 RID: 76329
		internal static int __PropertyOffset_1;

		// Token: 0x04012A2A RID: 76330
		internal static int __PropertyOffset_2;

		// Token: 0x04012A2B RID: 76331
		internal static int __PropertyOffset_3;

		// Token: 0x04012A2C RID: 76332
		internal static int __PropertyOffset_4;

		// Token: 0x04012A2D RID: 76333
		internal static int __PropertyOffset_5;

		// Token: 0x04012A2E RID: 76334
		internal static int __PropertyOffset_6;

		// Token: 0x04012A2F RID: 76335
		private static IntPtr __NewFunction_0_NativeFunctionPtr;

		// Token: 0x04012A30 RID: 76336
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012A31 RID: 76337
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FEC RID: 40940
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A87 RID: 203399
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FED RID: 40941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A88 RID: 203400
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
