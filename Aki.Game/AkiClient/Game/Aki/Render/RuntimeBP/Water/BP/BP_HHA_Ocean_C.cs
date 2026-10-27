using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.Data.Water;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A87 RID: 14983
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_HHA_Ocean.BP_HHA_Ocean_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1596)]
	public class BP_HHA_Ocean_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD04 RID: 130308 RVA: 0x008C3423 File Offset: 0x008C1623
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HHA_Ocean_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_HHA_Ocean.BP_HHA_Ocean_C");
			}
			return BP_HHA_Ocean_C._ClassPtr;
		}

		// Token: 0x0601FD05 RID: 130309 RVA: 0x008C3448 File Offset: 0x008C1648
		public BP_HHA_Ocean_C() : this(BuiltinUtils.AllocNativeUObject(BP_HHA_Ocean_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD06 RID: 130310 RVA: 0x008C3470 File Offset: 0x008C1670
		[NullableContext(1)]
		public BP_HHA_Ocean_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HHA_Ocean_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x0601FD07 RID: 130311 RVA: 0x008C34A3 File Offset: 0x008C16A3
		// (set) Token: 0x0601FD08 RID: 130312 RVA: 0x008C34B7 File Offset: 0x008C16B7
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x0601FD09 RID: 130313 RVA: 0x008C34CC File Offset: 0x008C16CC
		// (set) Token: 0x0601FD0A RID: 130314 RVA: 0x008C34DC File Offset: 0x008C16DC
		public unsafe float CurTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x0601FD0B RID: 130315 RVA: 0x008C34ED File Offset: 0x008C16ED
		// (set) Token: 0x0601FD0C RID: 130316 RVA: 0x008C3501 File Offset: 0x008C1701
		public unsafe BP_Ocean_Data_C ZhongWu_12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Ocean_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x0601FD0D RID: 130317 RVA: 0x008C3516 File Offset: 0x008C1716
		// (set) Token: 0x0601FD0E RID: 130318 RVA: 0x008C352A File Offset: 0x008C172A
		public unsafe BP_Ocean_Data_C YeWan_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Ocean_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x0601FD0F RID: 130319 RVA: 0x008C353F File Offset: 0x008C173F
		// (set) Token: 0x0601FD10 RID: 130320 RVA: 0x008C354F File Offset: 0x008C174F
		public unsafe float TimeLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0601FD11 RID: 130321 RVA: 0x008C3560 File Offset: 0x008C1760
		// (set) Token: 0x0601FD12 RID: 130322 RVA: 0x008C3574 File Offset: 0x008C1774
		public unsafe BP_Ocean_Data_C OceanData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Ocean_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0601FD13 RID: 130323 RVA: 0x008C3589 File Offset: 0x008C1789
		// (set) Token: 0x0601FD14 RID: 130324 RVA: 0x008C359D File Offset: 0x008C179D
		public unsafe UMaterialInstanceDynamic OceanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0601FD15 RID: 130325 RVA: 0x008C35B2 File Offset: 0x008C17B2
		// (set) Token: 0x0601FD16 RID: 130326 RVA: 0x008C35C2 File Offset: 0x008C17C2
		public unsafe int Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0601FD17 RID: 130327 RVA: 0x008C35D3 File Offset: 0x008C17D3
		// (set) Token: 0x0601FD18 RID: 130328 RVA: 0x008C35E3 File Offset: 0x008C17E3
		public unsafe bool EditorOceanLerpMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0601FD19 RID: 130329 RVA: 0x008C35F4 File Offset: 0x008C17F4
		// (set) Token: 0x0601FD1A RID: 130330 RVA: 0x008C3604 File Offset: 0x008C1804
		public unsafe bool SetTex_Noon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0601FD1B RID: 130331 RVA: 0x008C3615 File Offset: 0x008C1815
		// (set) Token: 0x0601FD1C RID: 130332 RVA: 0x008C3625 File Offset: 0x008C1825
		public unsafe bool SetTex_Night
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0601FD1D RID: 130333 RVA: 0x008C3636 File Offset: 0x008C1836
		// (set) Token: 0x0601FD1E RID: 130334 RVA: 0x008C364A File Offset: 0x008C184A
		public unsafe AStaticMeshActor OceanMeshActor_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0601FD1F RID: 130335 RVA: 0x008C365F File Offset: 0x008C185F
		// (set) Token: 0x0601FD20 RID: 130336 RVA: 0x008C3673 File Offset: 0x008C1873
		public unsafe AStaticMeshActor OceanMeshActor_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0601FD21 RID: 130337 RVA: 0x008C3688 File Offset: 0x008C1888
		// (set) Token: 0x0601FD22 RID: 130338 RVA: 0x008C369C File Offset: 0x008C189C
		public unsafe AStaticMeshActor OceanMeshActor_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0601FD23 RID: 130339 RVA: 0x008C36B1 File Offset: 0x008C18B1
		// (set) Token: 0x0601FD24 RID: 130340 RVA: 0x008C36C5 File Offset: 0x008C18C5
		public unsafe AStaticMeshActor OceanMeshActor_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HHA_Ocean_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0601FD25 RID: 130341 RVA: 0x008C36DA File Offset: 0x008C18DA
		// (set) Token: 0x0601FD26 RID: 130342 RVA: 0x008C36EA File Offset: 0x008C18EA
		public unsafe float ShaderTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0601FD27 RID: 130343 RVA: 0x008C36FB File Offset: 0x008C18FB
		// (set) Token: 0x0601FD28 RID: 130344 RVA: 0x008C370F File Offset: 0x008C190F
		public unsafe FLinearColor RippleTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0601FD29 RID: 130345 RVA: 0x008C3724 File Offset: 0x008C1924
		// (set) Token: 0x0601FD2A RID: 130346 RVA: 0x008C375D File Offset: 0x008C195D
		[Nullable(1)]
		public TArray<FName> RipplePos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._RipplePos) == null)
				{
					result = (this._RipplePos = new TArray<FName>(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RipplePos.CopyAssign(value);
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0601FD2B RID: 130347 RVA: 0x008C376B File Offset: 0x008C196B
		// (set) Token: 0x0601FD2C RID: 130348 RVA: 0x008C377B File Offset: 0x008C197B
		public unsafe int RippleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0601FD2D RID: 130349 RVA: 0x008C378C File Offset: 0x008C198C
		// (set) Token: 0x0601FD2E RID: 130350 RVA: 0x008C379C File Offset: 0x008C199C
		public unsafe bool bMobliePlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0601FD2F RID: 130351 RVA: 0x008C37AD File Offset: 0x008C19AD
		// (set) Token: 0x0601FD30 RID: 130352 RVA: 0x008C37BD File Offset: 0x008C19BD
		public unsafe bool bRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0601FD31 RID: 130353 RVA: 0x008C37CE File Offset: 0x008C19CE
		// (set) Token: 0x0601FD32 RID: 130354 RVA: 0x008C37DE File Offset: 0x008C19DE
		public unsafe bool bDrawDebugSphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0601FD33 RID: 130355 RVA: 0x008C37EF File Offset: 0x008C19EF
		// (set) Token: 0x0601FD34 RID: 130356 RVA: 0x008C37FF File Offset: 0x008C19FF
		public unsafe float fTODEnableRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HHA_Ocean_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x0601FD35 RID: 130357 RVA: 0x008C3810 File Offset: 0x008C1A10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WaterRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__WaterRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD36 RID: 130358 RVA: 0x008C3824 File Offset: 0x008C1A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD37 RID: 130359 RVA: 0x008C3838 File Offset: 0x008C1A38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HHA_Ocean_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD38 RID: 130360 RVA: 0x008C384D File Offset: 0x008C1A4D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD39 RID: 130361 RVA: 0x008C3861 File Offset: 0x008C1A61
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HHA_Ocean_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD3A RID: 130362 RVA: 0x008C3876 File Offset: 0x008C1A76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD3B RID: 130363 RVA: 0x008C388C File Offset: 0x008C1A8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CustomEvent_0(AActor 被控物, AActor 水面)
		{
			BP_HHA_Ocean_C.__CustomEvent_0_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__CustomEvent_0_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_HHA_Ocean_C.__CustomEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__CustomEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->被控物 = ((被控物 != null) ? 被控物.NativePtr : IntPtr.Zero);
			ptr->水面 = ((水面 != null) ? 水面.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__CustomEvent_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD3C RID: 130364 RVA: 0x008C38F8 File Offset: 0x008C1AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature(AActor OverlappedActor, AActor OtherActor)
		{
			BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD3D RID: 130365 RVA: 0x008C3964 File Offset: 0x008C1B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature(AActor OverlappedActor, AActor OtherActor)
		{
			BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD3E RID: 130366 RVA: 0x008C39D0 File Offset: 0x008C1BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature(AActor OverlappedActor, AActor OtherActor)
		{
			BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD3F RID: 130367 RVA: 0x008C3A3C File Offset: 0x008C1C3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature(AActor OverlappedActor, AActor OtherActor)
		{
			BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD40 RID: 130368 RVA: 0x008C3AA8 File Offset: 0x008C1CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_HHA_Ocean_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HHA_Ocean_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HHA_Ocean_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD41 RID: 130369 RVA: 0x008C3AF0 File Offset: 0x008C1CF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_HHA_Ocean_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HHA_Ocean_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HHA_Ocean_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HHA_Ocean_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HHA_Ocean_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FD42 RID: 130370 RVA: 0x008C3B37 File Offset: 0x008C1D37
		protected BP_HHA_Ocean_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F555 RID: 62805
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_HHA_Ocean.BP_HHA_Ocean_C";

		// Token: 0x0400F556 RID: 62806
		private static IntPtr _ClassPtr;

		// Token: 0x0400F557 RID: 62807
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F558 RID: 62808
		internal static int __PropertyOffset_1;

		// Token: 0x0400F559 RID: 62809
		internal static int __PropertyOffset_2;

		// Token: 0x0400F55A RID: 62810
		internal static int __PropertyOffset_3;

		// Token: 0x0400F55B RID: 62811
		internal static int __PropertyOffset_4;

		// Token: 0x0400F55C RID: 62812
		internal static int __PropertyOffset_5;

		// Token: 0x0400F55D RID: 62813
		internal static int __PropertyOffset_6;

		// Token: 0x0400F55E RID: 62814
		internal static int __PropertyOffset_7;

		// Token: 0x0400F55F RID: 62815
		internal static int __PropertyOffset_8;

		// Token: 0x0400F560 RID: 62816
		internal static int __PropertyOffset_9;

		// Token: 0x0400F561 RID: 62817
		internal static int __PropertyOffset_10;

		// Token: 0x0400F562 RID: 62818
		internal static int __PropertyOffset_11;

		// Token: 0x0400F563 RID: 62819
		internal static int __PropertyOffset_12;

		// Token: 0x0400F564 RID: 62820
		internal static int __PropertyOffset_13;

		// Token: 0x0400F565 RID: 62821
		internal static int __PropertyOffset_14;

		// Token: 0x0400F566 RID: 62822
		internal static int __PropertyOffset_15;

		// Token: 0x0400F567 RID: 62823
		internal static int __PropertyOffset_16;

		// Token: 0x0400F568 RID: 62824
		internal static int __PropertyOffset_17;

		// Token: 0x0400F569 RID: 62825
		internal static int __PropertyOffset_18;

		// Token: 0x0400F56A RID: 62826
		private TArray<FName> _RipplePos;

		// Token: 0x0400F56B RID: 62827
		internal static int __PropertyOffset_19;

		// Token: 0x0400F56C RID: 62828
		internal static int __PropertyOffset_20;

		// Token: 0x0400F56D RID: 62829
		internal static int __PropertyOffset_21;

		// Token: 0x0400F56E RID: 62830
		internal static int __PropertyOffset_22;

		// Token: 0x0400F56F RID: 62831
		internal static int __PropertyOffset_23;

		// Token: 0x0400F570 RID: 62832
		private static IntPtr __WaterRipple_NativeFunctionPtr;

		// Token: 0x0400F571 RID: 62833
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F572 RID: 62834
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F573 RID: 62835
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400F574 RID: 62836
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0400F575 RID: 62837
		private static IntPtr __BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F576 RID: 62838
		private static IntPtr __BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F577 RID: 62839
		private static IntPtr __BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F578 RID: 62840
		private static IntPtr __BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F579 RID: 62841
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B53 RID: 39763
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CustomEvent_0_FunctionParams
		{
			// Token: 0x04031177 RID: 201079
			[FieldOffset(0)]
			public IntPtr 被控物;

			// Token: 0x04031178 RID: 201080
			[FieldOffset(8)]
			public IntPtr 水面;
		}

		// Token: 0x02009B54 RID: 39764
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __BndEvt__BP_HHA_Ocean_OceanMeshActor_3_K2Node_ComponentBoundEvent_3_ActorBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031179 RID: 201081
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x0403117A RID: 201082
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009B55 RID: 39765
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __BndEvt__BP_HHA_Ocean_OceanMeshActor_2_K2Node_ComponentBoundEvent_2_ActorBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403117B RID: 201083
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x0403117C RID: 201084
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009B56 RID: 39766
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __BndEvt__BP_HHA_Ocean_OceanMeshActor_1_K2Node_ComponentBoundEvent_1_ActorBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403117D RID: 201085
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x0403117E RID: 201086
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009B57 RID: 39767
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __BndEvt__BP_HHA_Ocean_OceanMeshActor_0_K2Node_ComponentBoundEvent_0_ActorBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403117F RID: 201087
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x04031180 RID: 201088
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009B58 RID: 39768
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031181 RID: 201089
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
