using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DandelionInteraction
{
	// Token: 0x02003DE9 RID: 15849
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_Small_DandelionInteraction.BP_Small_DandelionInteraction_C")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1472)]
	public class BP_Small_DandelionInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278B4 RID: 161972 RVA: 0x009944D5 File Offset: 0x009926D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Small_DandelionInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_Small_DandelionInteraction.BP_Small_DandelionInteraction_C");
			}
			return BP_Small_DandelionInteraction_C._ClassPtr;
		}

		// Token: 0x060278B5 RID: 161973 RVA: 0x009944FC File Offset: 0x009926FC
		public BP_Small_DandelionInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_Small_DandelionInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278B6 RID: 161974 RVA: 0x00994524 File Offset: 0x00992724
		[NullableContext(1)]
		public BP_Small_DandelionInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Small_DandelionInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058B0 RID: 22704
		// (get) Token: 0x060278B7 RID: 161975 RVA: 0x00994557 File Offset: 0x00992757
		// (set) Token: 0x060278B8 RID: 161976 RVA: 0x0099456B File Offset: 0x0099276B
		public unsafe UNiagaraComponent NS_Fx_DandelionInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Small_DandelionInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Small_DandelionInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058B1 RID: 22705
		// (get) Token: 0x060278B9 RID: 161977 RVA: 0x00994580 File Offset: 0x00992780
		// (set) Token: 0x060278BA RID: 161978 RVA: 0x00994594 File Offset: 0x00992794
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Small_DandelionInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Small_DandelionInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x060278BB RID: 161979 RVA: 0x009945A9 File Offset: 0x009927A9
		// (set) Token: 0x060278BC RID: 161980 RVA: 0x009945BD File Offset: 0x009927BD
		public unsafe UKuroPointCloudCache KuroPointCloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Small_DandelionInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Small_DandelionInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x060278BD RID: 161981 RVA: 0x009945D2 File Offset: 0x009927D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x060278BE RID: 161982 RVA: 0x009945E6 File Offset: 0x009927E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060278BF RID: 161983 RVA: 0x009945FA File Offset: 0x009927FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060278C0 RID: 161984 RVA: 0x0099460F File Offset: 0x0099280F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060278C1 RID: 161985 RVA: 0x00994623 File Offset: 0x00992823
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060278C2 RID: 161986 RVA: 0x00994638 File Offset: 0x00992838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Small_DandelionInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Small_DandelionInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Small_DandelionInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Small_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060278C3 RID: 161987 RVA: 0x00994680 File Offset: 0x00992880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Small_DandelionInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Small_DandelionInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Small_DandelionInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Small_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Small_DandelionInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060278C4 RID: 161988 RVA: 0x009946C7 File Offset: 0x009928C7
		protected BP_Small_DandelionInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013FEA RID: 81898
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_Small_DandelionInteraction.BP_Small_DandelionInteraction_C";

		// Token: 0x04013FEB RID: 81899
		private static IntPtr _ClassPtr;

		// Token: 0x04013FEC RID: 81900
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013FED RID: 81901
		internal static int __PropertyOffset_1;

		// Token: 0x04013FEE RID: 81902
		internal static int __PropertyOffset_2;

		// Token: 0x04013FEF RID: 81903
		internal static int __PropertyOffset_3;

		// Token: 0x04013FF0 RID: 81904
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x04013FF1 RID: 81905
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013FF2 RID: 81906
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013FF3 RID: 81907
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A249 RID: 41545
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EDA RID: 204506
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
