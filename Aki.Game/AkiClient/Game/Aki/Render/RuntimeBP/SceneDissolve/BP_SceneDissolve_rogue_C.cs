using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneDissolve
{
	// Token: 0x02003BB7 RID: 15287
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneDissolve/BP_SceneDissolve_rogue.BP_SceneDissolve_rogue_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1500)]
	public class BP_SceneDissolve_rogue_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602221E RID: 139806 RVA: 0x00900814 File Offset: 0x008FEA14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneDissolve_rogue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneDissolve/BP_SceneDissolve_rogue.BP_SceneDissolve_rogue_C");
			}
			return BP_SceneDissolve_rogue_C._ClassPtr;
		}

		// Token: 0x0602221F RID: 139807 RVA: 0x00900838 File Offset: 0x008FEA38
		public BP_SceneDissolve_rogue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneDissolve_rogue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022220 RID: 139808 RVA: 0x00900860 File Offset: 0x008FEA60
		[NullableContext(1)]
		public BP_SceneDissolve_rogue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneDissolve_rogue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x06022221 RID: 139809 RVA: 0x00900893 File Offset: 0x008FEA93
		// (set) Token: 0x06022222 RID: 139810 RVA: 0x009008A7 File Offset: 0x008FEAA7
		public unsafe UNiagaraComponent NS_Fx_SceneDissolve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_rogue_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_rogue_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x06022223 RID: 139811 RVA: 0x009008BC File Offset: 0x008FEABC
		// (set) Token: 0x06022224 RID: 139812 RVA: 0x009008D0 File Offset: 0x008FEAD0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_rogue_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_rogue_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x06022225 RID: 139813 RVA: 0x009008E5 File Offset: 0x008FEAE5
		// (set) Token: 0x06022226 RID: 139814 RVA: 0x009008F5 File Offset: 0x008FEAF5
		public unsafe float DissolutionProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x06022227 RID: 139815 RVA: 0x00900906 File Offset: 0x008FEB06
		// (set) Token: 0x06022228 RID: 139816 RVA: 0x0090091A File Offset: 0x008FEB1A
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_rogue_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_rogue_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x06022229 RID: 139817 RVA: 0x0090092F File Offset: 0x008FEB2F
		// (set) Token: 0x0602222A RID: 139818 RVA: 0x0090093F File Offset: 0x008FEB3F
		public unsafe float DissolutionHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0602222B RID: 139819 RVA: 0x00900950 File Offset: 0x008FEB50
		// (set) Token: 0x0602222C RID: 139820 RVA: 0x00900960 File Offset: 0x008FEB60
		public unsafe float DissolutionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0602222D RID: 139821 RVA: 0x00900971 File Offset: 0x008FEB71
		// (set) Token: 0x0602222E RID: 139822 RVA: 0x00900985 File Offset: 0x008FEB85
		public unsafe FVector DissolutionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_rogue_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602222F RID: 139823 RVA: 0x0090099A File Offset: 0x008FEB9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06022230 RID: 139824 RVA: 0x009009AE File Offset: 0x008FEBAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022231 RID: 139825 RVA: 0x009009C2 File Offset: 0x008FEBC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022232 RID: 139826 RVA: 0x009009D7 File Offset: 0x008FEBD7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022233 RID: 139827 RVA: 0x009009EB File Offset: 0x008FEBEB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022234 RID: 139828 RVA: 0x00900A00 File Offset: 0x008FEC00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneDissolve_rogue_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneDissolve_rogue_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneDissolve_rogue_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneDissolve_rogue_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022235 RID: 139829 RVA: 0x00900A48 File Offset: 0x008FEC48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneDissolve_rogue_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneDissolve_rogue_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneDissolve_rogue_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneDissolve_rogue_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022236 RID: 139830 RVA: 0x00900A8F File Offset: 0x008FEC8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_rogue_C.__SetParamFromSeq_NativeFunctionPtr, null);
		}

		// Token: 0x06022237 RID: 139831 RVA: 0x00900AA3 File Offset: 0x008FECA3
		protected BP_SceneDissolve_rogue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B7B RID: 68475
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneDissolve/BP_SceneDissolve_rogue.BP_SceneDissolve_rogue_C";

		// Token: 0x04010B7C RID: 68476
		private static IntPtr _ClassPtr;

		// Token: 0x04010B7D RID: 68477
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B7E RID: 68478
		internal static int __PropertyOffset_1;

		// Token: 0x04010B7F RID: 68479
		internal static int __PropertyOffset_2;

		// Token: 0x04010B80 RID: 68480
		internal static int __PropertyOffset_3;

		// Token: 0x04010B81 RID: 68481
		internal static int __PropertyOffset_4;

		// Token: 0x04010B82 RID: 68482
		internal static int __PropertyOffset_5;

		// Token: 0x04010B83 RID: 68483
		internal static int __PropertyOffset_6;

		// Token: 0x04010B84 RID: 68484
		internal static int __PropertyOffset_7;

		// Token: 0x04010B85 RID: 68485
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x04010B86 RID: 68486
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010B87 RID: 68487
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010B88 RID: 68488
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010B89 RID: 68489
		private static IntPtr __SetParamFromSeq_NativeFunctionPtr;

		// Token: 0x02009D44 RID: 40260
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314AF RID: 201903
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
