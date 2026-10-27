using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal.HeightMaskBake.BlackWave
{
	// Token: 0x02003C7D RID: 15485
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_BlackWaveComposite.BP_BlackWaveComposite_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1488)]
	public class BP_BlackWaveComposite_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060240D4 RID: 147668 RVA: 0x00933D93 File Offset: 0x00931F93
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BlackWaveComposite_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_BlackWaveComposite.BP_BlackWaveComposite_C");
			}
			return BP_BlackWaveComposite_C._ClassPtr;
		}

		// Token: 0x060240D5 RID: 147669 RVA: 0x00933DB8 File Offset: 0x00931FB8
		public BP_BlackWaveComposite_C() : this(BuiltinUtils.AllocNativeUObject(BP_BlackWaveComposite_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060240D6 RID: 147670 RVA: 0x00933DE0 File Offset: 0x00931FE0
		[NullableContext(1)]
		public BP_BlackWaveComposite_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BlackWaveComposite_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x060240D7 RID: 147671 RVA: 0x00933E13 File Offset: 0x00932013
		// (set) Token: 0x060240D8 RID: 147672 RVA: 0x00933E27 File Offset: 0x00932027
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x060240D9 RID: 147673 RVA: 0x00933E3C File Offset: 0x0093203C
		// (set) Token: 0x060240DA RID: 147674 RVA: 0x00933E50 File Offset: 0x00932050
		public unsafe UMaterialInstanceDynamic MDI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x060240DB RID: 147675 RVA: 0x00933E65 File Offset: 0x00932065
		// (set) Token: 0x060240DC RID: 147676 RVA: 0x00933E79 File Offset: 0x00932079
		public unsafe NinjaLive_C fluidR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLive_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x060240DD RID: 147677 RVA: 0x00933E8E File Offset: 0x0093208E
		// (set) Token: 0x060240DE RID: 147678 RVA: 0x00933EA2 File Offset: 0x009320A2
		public unsafe NinjaLive_C fluidG
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLive_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x060240DF RID: 147679 RVA: 0x00933EB7 File Offset: 0x009320B7
		// (set) Token: 0x060240E0 RID: 147680 RVA: 0x00933ECB File Offset: 0x009320CB
		public unsafe UTextureRenderTarget2D OutputRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BlackWaveComposite_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060240E1 RID: 147681 RVA: 0x00933EE0 File Offset: 0x009320E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BlackWaveComposite_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060240E2 RID: 147682 RVA: 0x00933EF4 File Offset: 0x009320F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BlackWaveComposite_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240E3 RID: 147683 RVA: 0x00933F0C File Offset: 0x0093210C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BlackWaveComposite_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BlackWaveComposite_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BlackWaveComposite_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BlackWaveComposite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BlackWaveComposite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060240E4 RID: 147684 RVA: 0x00933F54 File Offset: 0x00932154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BlackWaveComposite_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BlackWaveComposite_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BlackWaveComposite_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BlackWaveComposite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BlackWaveComposite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060240E5 RID: 147685 RVA: 0x00933F9B File Offset: 0x0093219B
		protected BP_BlackWaveComposite_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D86 RID: 73094
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_BlackWaveComposite.BP_BlackWaveComposite_C";

		// Token: 0x04011D87 RID: 73095
		private static IntPtr _ClassPtr;

		// Token: 0x04011D88 RID: 73096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D89 RID: 73097
		internal static int __PropertyOffset_1;

		// Token: 0x04011D8A RID: 73098
		internal static int __PropertyOffset_2;

		// Token: 0x04011D8B RID: 73099
		internal static int __PropertyOffset_3;

		// Token: 0x04011D8C RID: 73100
		internal static int __PropertyOffset_4;

		// Token: 0x04011D8D RID: 73101
		internal static int __PropertyOffset_5;

		// Token: 0x04011D8E RID: 73102
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011D8F RID: 73103
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009ECC RID: 40652
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317B9 RID: 202681
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
