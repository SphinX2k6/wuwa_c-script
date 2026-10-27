using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightningTree
{
	// Token: 0x02003C72 RID: 15474
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightningTree/BP_LightningTree.BP_LightningTree_C")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1617)]
	public class BP_LightningTree_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023E49 RID: 147017 RVA: 0x0092FF14 File Offset: 0x0092E114
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightningTree_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/LightningTree/BP_LightningTree.BP_LightningTree_C");
			}
			return BP_LightningTree_C._ClassPtr;
		}

		// Token: 0x06023E4A RID: 147018 RVA: 0x0092FF38 File Offset: 0x0092E138
		public BP_LightningTree_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightningTree_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023E4B RID: 147019 RVA: 0x0092FF60 File Offset: 0x0092E160
		[NullableContext(1)]
		public BP_LightningTree_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightningTree_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043FE RID: 17406
		// (get) Token: 0x06023E4C RID: 147020 RVA: 0x0092FF93 File Offset: 0x0092E193
		// (set) Token: 0x06023E4D RID: 147021 RVA: 0x0092FFA7 File Offset: 0x0092E1A7
		public unsafe UNiagaraComponent NS_Fx_LightningTree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x06023E4E RID: 147022 RVA: 0x0092FFBC File Offset: 0x0092E1BC
		// (set) Token: 0x06023E4F RID: 147023 RVA: 0x0092FFD0 File Offset: 0x0092E1D0
		public unsafe UStaticMeshComponent Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004400 RID: 17408
		// (get) Token: 0x06023E50 RID: 147024 RVA: 0x0092FFE5 File Offset: 0x0092E1E5
		// (set) Token: 0x06023E51 RID: 147025 RVA: 0x0092FFF9 File Offset: 0x0092E1F9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x06023E52 RID: 147026 RVA: 0x0093000E File Offset: 0x0092E20E
		// (set) Token: 0x06023E53 RID: 147027 RVA: 0x00930022 File Offset: 0x0092E222
		public unsafe UNiagaraSystem LightningEffectNiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x06023E54 RID: 147028 RVA: 0x00930037 File Offset: 0x0092E237
		// (set) Token: 0x06023E55 RID: 147029 RVA: 0x0093004B File Offset: 0x0092E24B
		public unsafe FTransform LightningEffectTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x06023E56 RID: 147030 RVA: 0x00930060 File Offset: 0x0092E260
		// (set) Token: 0x06023E57 RID: 147031 RVA: 0x00930099 File Offset: 0x0092E299
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMI) == null)
				{
					result = (this._DMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DMI.CopyAssign(value);
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x06023E58 RID: 147032 RVA: 0x009300A7 File Offset: 0x0092E2A7
		// (set) Token: 0x06023E59 RID: 147033 RVA: 0x009300B7 File Offset: 0x0092E2B7
		public unsafe bool Trigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004405 RID: 17413
		// (get) Token: 0x06023E5A RID: 147034 RVA: 0x009300C8 File Offset: 0x0092E2C8
		// (set) Token: 0x06023E5B RID: 147035 RVA: 0x009300D8 File Offset: 0x0092E2D8
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x06023E5C RID: 147036 RVA: 0x009300E9 File Offset: 0x0092E2E9
		// (set) Token: 0x06023E5D RID: 147037 RVA: 0x009300F9 File Offset: 0x0092E2F9
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x06023E5E RID: 147038 RVA: 0x0093010A File Offset: 0x0092E30A
		// (set) Token: 0x06023E5F RID: 147039 RVA: 0x0093011A File Offset: 0x0092E31A
		public unsafe float TriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x06023E60 RID: 147040 RVA: 0x0093012B File Offset: 0x0092E32B
		// (set) Token: 0x06023E61 RID: 147041 RVA: 0x0093013B File Offset: 0x0092E33B
		public unsafe float DiffusionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x06023E62 RID: 147042 RVA: 0x0093014C File Offset: 0x0092E34C
		// (set) Token: 0x06023E63 RID: 147043 RVA: 0x0093015C File Offset: 0x0092E35C
		public unsafe float ParticleEmissionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x06023E64 RID: 147044 RVA: 0x0093016D File Offset: 0x0092E36D
		// (set) Token: 0x06023E65 RID: 147045 RVA: 0x0093017D File Offset: 0x0092E37D
		public unsafe float FadedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x06023E66 RID: 147046 RVA: 0x0093018E File Offset: 0x0092E38E
		// (set) Token: 0x06023E67 RID: 147047 RVA: 0x0093019E File Offset: 0x0092E39E
		public unsafe float TriggerDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x06023E68 RID: 147048 RVA: 0x009301AF File Offset: 0x0092E3AF
		// (set) Token: 0x06023E69 RID: 147049 RVA: 0x009301BF File Offset: 0x0092E3BF
		public unsafe float HitProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x06023E6A RID: 147050 RVA: 0x009301D0 File Offset: 0x0092E3D0
		// (set) Token: 0x06023E6B RID: 147051 RVA: 0x009301E4 File Offset: 0x0092E3E4
		public unsafe BP_WeatherController_C WeatherController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WeatherController_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x06023E6C RID: 147052 RVA: 0x009301F9 File Offset: 0x0092E3F9
		// (set) Token: 0x06023E6D RID: 147053 RVA: 0x0093020D File Offset: 0x0092E40D
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x06023E6E RID: 147054 RVA: 0x00930222 File Offset: 0x0092E422
		// (set) Token: 0x06023E6F RID: 147055 RVA: 0x00930236 File Offset: 0x0092E436
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningTree_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x06023E70 RID: 147056 RVA: 0x0093024B File Offset: 0x0092E44B
		// (set) Token: 0x06023E71 RID: 147057 RVA: 0x0093025B File Offset: 0x0092E45B
		public unsafe bool WithinTheRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningTree_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023E72 RID: 147058 RVA: 0x0093026C File Offset: 0x0092E46C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06023E73 RID: 147059 RVA: 0x00930280 File Offset: 0x0092E480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__UpdateParam_NativeFunctionPtr, null);
		}

		// Token: 0x06023E74 RID: 147060 RVA: 0x00930294 File Offset: 0x0092E494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06023E75 RID: 147061 RVA: 0x009302A8 File Offset: 0x0092E4A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TriggerLightning()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__TriggerLightning_NativeFunctionPtr, null);
		}

		// Token: 0x06023E76 RID: 147062 RVA: 0x009302BC File Offset: 0x0092E4BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023E77 RID: 147063 RVA: 0x009302D0 File Offset: 0x0092E4D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningTree_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023E78 RID: 147064 RVA: 0x009302E8 File Offset: 0x0092E4E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightningTree_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightningTree_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightningTree_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023E79 RID: 147065 RVA: 0x00930330 File Offset: 0x0092E530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightningTree_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightningTree_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightningTree_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023E7A RID: 147066 RVA: 0x00930377 File Offset: 0x0092E577
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningTree_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023E7B RID: 147067 RVA: 0x0093038B File Offset: 0x0092E58B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningTree_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023E7C RID: 147068 RVA: 0x009303A0 File Offset: 0x0092E5A0
		protected BP_LightningTree_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C14 RID: 72724
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightningTree/BP_LightningTree.BP_LightningTree_C";

		// Token: 0x04011C15 RID: 72725
		private static IntPtr _ClassPtr;

		// Token: 0x04011C16 RID: 72726
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C17 RID: 72727
		internal static int __PropertyOffset_1;

		// Token: 0x04011C18 RID: 72728
		internal static int __PropertyOffset_2;

		// Token: 0x04011C19 RID: 72729
		internal static int __PropertyOffset_3;

		// Token: 0x04011C1A RID: 72730
		internal static int __PropertyOffset_4;

		// Token: 0x04011C1B RID: 72731
		internal static int __PropertyOffset_5;

		// Token: 0x04011C1C RID: 72732
		internal static int __PropertyOffset_6;

		// Token: 0x04011C1D RID: 72733
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMI;

		// Token: 0x04011C1E RID: 72734
		internal static int __PropertyOffset_7;

		// Token: 0x04011C1F RID: 72735
		internal static int __PropertyOffset_8;

		// Token: 0x04011C20 RID: 72736
		internal static int __PropertyOffset_9;

		// Token: 0x04011C21 RID: 72737
		internal static int __PropertyOffset_10;

		// Token: 0x04011C22 RID: 72738
		internal static int __PropertyOffset_11;

		// Token: 0x04011C23 RID: 72739
		internal static int __PropertyOffset_12;

		// Token: 0x04011C24 RID: 72740
		internal static int __PropertyOffset_13;

		// Token: 0x04011C25 RID: 72741
		internal static int __PropertyOffset_14;

		// Token: 0x04011C26 RID: 72742
		internal static int __PropertyOffset_15;

		// Token: 0x04011C27 RID: 72743
		internal static int __PropertyOffset_16;

		// Token: 0x04011C28 RID: 72744
		internal static int __PropertyOffset_17;

		// Token: 0x04011C29 RID: 72745
		internal static int __PropertyOffset_18;

		// Token: 0x04011C2A RID: 72746
		internal static int __PropertyOffset_19;

		// Token: 0x04011C2B RID: 72747
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04011C2C RID: 72748
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04011C2D RID: 72749
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04011C2E RID: 72750
		private static IntPtr __TriggerLightning_NativeFunctionPtr;

		// Token: 0x04011C2F RID: 72751
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011C30 RID: 72752
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011C31 RID: 72753
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009EB1 RID: 40625
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403178A RID: 202634
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
