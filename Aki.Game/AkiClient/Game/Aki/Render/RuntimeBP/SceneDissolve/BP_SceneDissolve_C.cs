using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneDissolve
{
	// Token: 0x02003BB6 RID: 15286
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneDissolve/BP_SceneDissolve.BP_SceneDissolve_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1500)]
	public class BP_SceneDissolve_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022204 RID: 139780 RVA: 0x0090057C File Offset: 0x008FE77C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneDissolve_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneDissolve/BP_SceneDissolve.BP_SceneDissolve_C");
			}
			return BP_SceneDissolve_C._ClassPtr;
		}

		// Token: 0x06022205 RID: 139781 RVA: 0x009005A0 File Offset: 0x008FE7A0
		public BP_SceneDissolve_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneDissolve_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022206 RID: 139782 RVA: 0x009005C8 File Offset: 0x008FE7C8
		[NullableContext(1)]
		public BP_SceneDissolve_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneDissolve_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x06022207 RID: 139783 RVA: 0x009005FB File Offset: 0x008FE7FB
		// (set) Token: 0x06022208 RID: 139784 RVA: 0x0090060F File Offset: 0x008FE80F
		public unsafe UNiagaraComponent NS_Fx_SceneDissolve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x06022209 RID: 139785 RVA: 0x00900624 File Offset: 0x008FE824
		// (set) Token: 0x0602220A RID: 139786 RVA: 0x00900638 File Offset: 0x008FE838
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0602220B RID: 139787 RVA: 0x0090064D File Offset: 0x008FE84D
		// (set) Token: 0x0602220C RID: 139788 RVA: 0x0090065D File Offset: 0x008FE85D
		public unsafe float DissolutionProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0602220D RID: 139789 RVA: 0x0090066E File Offset: 0x008FE86E
		// (set) Token: 0x0602220E RID: 139790 RVA: 0x00900682 File Offset: 0x008FE882
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneDissolve_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0602220F RID: 139791 RVA: 0x00900697 File Offset: 0x008FE897
		// (set) Token: 0x06022210 RID: 139792 RVA: 0x009006A7 File Offset: 0x008FE8A7
		public unsafe float DissolutionHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x06022211 RID: 139793 RVA: 0x009006B8 File Offset: 0x008FE8B8
		// (set) Token: 0x06022212 RID: 139794 RVA: 0x009006C8 File Offset: 0x008FE8C8
		public unsafe float DissolutionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x06022213 RID: 139795 RVA: 0x009006D9 File Offset: 0x008FE8D9
		// (set) Token: 0x06022214 RID: 139796 RVA: 0x009006ED File Offset: 0x008FE8ED
		public unsafe FVector DissolutionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneDissolve_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06022215 RID: 139797 RVA: 0x00900702 File Offset: 0x008FE902
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06022216 RID: 139798 RVA: 0x00900716 File Offset: 0x008FE916
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022217 RID: 139799 RVA: 0x0090072A File Offset: 0x008FE92A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneDissolve_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022218 RID: 139800 RVA: 0x0090073F File Offset: 0x008FE93F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022219 RID: 139801 RVA: 0x00900753 File Offset: 0x008FE953
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneDissolve_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602221A RID: 139802 RVA: 0x00900768 File Offset: 0x008FE968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneDissolve_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneDissolve_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneDissolve_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneDissolve_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602221B RID: 139803 RVA: 0x009007B0 File Offset: 0x008FE9B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneDissolve_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneDissolve_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneDissolve_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneDissolve_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneDissolve_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602221C RID: 139804 RVA: 0x009007F7 File Offset: 0x008FE9F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneDissolve_C.__SetParamFromSeq_NativeFunctionPtr, null);
		}

		// Token: 0x0602221D RID: 139805 RVA: 0x0090080B File Offset: 0x008FEA0B
		protected BP_SceneDissolve_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B6C RID: 68460
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneDissolve/BP_SceneDissolve.BP_SceneDissolve_C";

		// Token: 0x04010B6D RID: 68461
		private static IntPtr _ClassPtr;

		// Token: 0x04010B6E RID: 68462
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B6F RID: 68463
		internal static int __PropertyOffset_1;

		// Token: 0x04010B70 RID: 68464
		internal static int __PropertyOffset_2;

		// Token: 0x04010B71 RID: 68465
		internal static int __PropertyOffset_3;

		// Token: 0x04010B72 RID: 68466
		internal static int __PropertyOffset_4;

		// Token: 0x04010B73 RID: 68467
		internal static int __PropertyOffset_5;

		// Token: 0x04010B74 RID: 68468
		internal static int __PropertyOffset_6;

		// Token: 0x04010B75 RID: 68469
		internal static int __PropertyOffset_7;

		// Token: 0x04010B76 RID: 68470
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x04010B77 RID: 68471
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010B78 RID: 68472
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010B79 RID: 68473
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010B7A RID: 68474
		private static IntPtr __SetParamFromSeq_NativeFunctionPtr;

		// Token: 0x02009D43 RID: 40259
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314AE RID: 201902
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
