using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D86 RID: 15750
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_CommonFluidSim.BP_CommonFluidSim_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1526)]
	public class BP_CommonFluidSim_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B6C RID: 158572 RVA: 0x0097CC14 File Offset: 0x0097AE14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CommonFluidSim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_CommonFluidSim.BP_CommonFluidSim_C");
			}
			return BP_CommonFluidSim_C._ClassPtr;
		}

		// Token: 0x06026B6D RID: 158573 RVA: 0x0097CC38 File Offset: 0x0097AE38
		public BP_CommonFluidSim_C() : this(BuiltinUtils.AllocNativeUObject(BP_CommonFluidSim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B6E RID: 158574 RVA: 0x0097CC60 File Offset: 0x0097AE60
		[NullableContext(1)]
		public BP_CommonFluidSim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CommonFluidSim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x06026B6F RID: 158575 RVA: 0x0097CC93 File Offset: 0x0097AE93
		// (set) Token: 0x06026B70 RID: 158576 RVA: 0x0097CCA7 File Offset: 0x0097AEA7
		public unsafe UStaticMeshComponent TraceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x06026B71 RID: 158577 RVA: 0x0097CCBC File Offset: 0x0097AEBC
		// (set) Token: 0x06026B72 RID: 158578 RVA: 0x0097CCD0 File Offset: 0x0097AED0
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x06026B73 RID: 158579 RVA: 0x0097CCE5 File Offset: 0x0097AEE5
		// (set) Token: 0x06026B74 RID: 158580 RVA: 0x0097CCF9 File Offset: 0x0097AEF9
		public unsafe NinjaLiveComponent_C NinjaLiveComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLiveComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CommonFluidSim_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x06026B75 RID: 158581 RVA: 0x0097CD0E File Offset: 0x0097AF0E
		// (set) Token: 0x06026B76 RID: 158582 RVA: 0x0097CD22 File Offset: 0x0097AF22
		public unsafe FVectorDouble lastPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x06026B77 RID: 158583 RVA: 0x0097CD37 File Offset: 0x0097AF37
		// (set) Token: 0x06026B78 RID: 158584 RVA: 0x0097CD47 File Offset: 0x0097AF47
		public unsafe float CachedStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x06026B79 RID: 158585 RVA: 0x0097CD58 File Offset: 0x0097AF58
		// (set) Token: 0x06026B7A RID: 158586 RVA: 0x0097CD68 File Offset: 0x0097AF68
		public unsafe double MinVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x06026B7B RID: 158587 RVA: 0x0097CD79 File Offset: 0x0097AF79
		// (set) Token: 0x06026B7C RID: 158588 RVA: 0x0097CD89 File Offset: 0x0097AF89
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053C7 RID: 21447
		// (get) Token: 0x06026B7D RID: 158589 RVA: 0x0097CD9A File Offset: 0x0097AF9A
		// (set) Token: 0x06026B7E RID: 158590 RVA: 0x0097CDAA File Offset: 0x0097AFAA
		public unsafe float FadeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170053C8 RID: 21448
		// (get) Token: 0x06026B7F RID: 158591 RVA: 0x0097CDBB File Offset: 0x0097AFBB
		// (set) Token: 0x06026B80 RID: 158592 RVA: 0x0097CDCB File Offset: 0x0097AFCB
		public unsafe float FadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170053C9 RID: 21449
		// (get) Token: 0x06026B81 RID: 158593 RVA: 0x0097CDDC File Offset: 0x0097AFDC
		// (set) Token: 0x06026B82 RID: 158594 RVA: 0x0097CDEC File Offset: 0x0097AFEC
		public unsafe bool bStoped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053CA RID: 21450
		// (get) Token: 0x06026B83 RID: 158595 RVA: 0x0097CDFD File Offset: 0x0097AFFD
		// (set) Token: 0x06026B84 RID: 158596 RVA: 0x0097CE0D File Offset: 0x0097B00D
		public unsafe bool bStarted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CommonFluidSim_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026B85 RID: 158597 RVA: 0x0097CE1E File Offset: 0x0097B01E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckSimEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_C.__CheckSimEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06026B86 RID: 158598 RVA: 0x0097CE32 File Offset: 0x0097B032
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026B87 RID: 158599 RVA: 0x0097CE46 File Offset: 0x0097B046
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CommonFluidSim_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026B88 RID: 158600 RVA: 0x0097CE5C File Offset: 0x0097B05C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CommonFluidSim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CommonFluidSim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CommonFluidSim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CommonFluidSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CommonFluidSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B89 RID: 158601 RVA: 0x0097CEA4 File Offset: 0x0097B0A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CommonFluidSim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CommonFluidSim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CommonFluidSim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CommonFluidSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CommonFluidSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026B8A RID: 158602 RVA: 0x0097CEEB File Offset: 0x0097B0EB
		protected BP_CommonFluidSim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013784 RID: 79748
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_CommonFluidSim.BP_CommonFluidSim_C";

		// Token: 0x04013785 RID: 79749
		private static IntPtr _ClassPtr;

		// Token: 0x04013786 RID: 79750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013787 RID: 79751
		internal static int __PropertyOffset_1;

		// Token: 0x04013788 RID: 79752
		internal static int __PropertyOffset_2;

		// Token: 0x04013789 RID: 79753
		internal static int __PropertyOffset_3;

		// Token: 0x0401378A RID: 79754
		internal static int __PropertyOffset_4;

		// Token: 0x0401378B RID: 79755
		internal static int __PropertyOffset_5;

		// Token: 0x0401378C RID: 79756
		internal static int __PropertyOffset_6;

		// Token: 0x0401378D RID: 79757
		internal static int __PropertyOffset_7;

		// Token: 0x0401378E RID: 79758
		internal static int __PropertyOffset_8;

		// Token: 0x0401378F RID: 79759
		internal static int __PropertyOffset_9;

		// Token: 0x04013790 RID: 79760
		internal static int __PropertyOffset_10;

		// Token: 0x04013791 RID: 79761
		internal static int __PropertyOffset_11;

		// Token: 0x04013792 RID: 79762
		private static IntPtr __CheckSimEnable_NativeFunctionPtr;

		// Token: 0x04013793 RID: 79763
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013794 RID: 79764
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A14C RID: 41292
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CF3 RID: 204019
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
