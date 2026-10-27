using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.GodRay
{
	// Token: 0x02003C81 RID: 15489
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroCustomShadowMap.BP_KuroCustomShadowMap_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1674)]
	public class BP_KuroCustomShadowMap_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024196 RID: 147862 RVA: 0x00934D47 File Offset: 0x00932F47
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCustomShadowMap_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroCustomShadowMap.BP_KuroCustomShadowMap_C");
			}
			return BP_KuroCustomShadowMap_C._ClassPtr;
		}

		// Token: 0x06024197 RID: 147863 RVA: 0x00934D6C File Offset: 0x00932F6C
		public BP_KuroCustomShadowMap_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCustomShadowMap_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024198 RID: 147864 RVA: 0x00934D94 File Offset: 0x00932F94
		[NullableContext(1)]
		public BP_KuroCustomShadowMap_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCustomShadowMap_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x06024199 RID: 147865 RVA: 0x00934DC7 File Offset: 0x00932FC7
		// (set) Token: 0x0602419A RID: 147866 RVA: 0x00934DDB File Offset: 0x00932FDB
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x0602419B RID: 147867 RVA: 0x00934DF0 File Offset: 0x00932FF0
		// (set) Token: 0x0602419C RID: 147868 RVA: 0x00934E04 File Offset: 0x00933004
		public unsafe USceneComponent RangeRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x0602419D RID: 147869 RVA: 0x00934E19 File Offset: 0x00933019
		// (set) Token: 0x0602419E RID: 147870 RVA: 0x00934E2D File Offset: 0x0093302D
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x0602419F RID: 147871 RVA: 0x00934E42 File Offset: 0x00933042
		// (set) Token: 0x060241A0 RID: 147872 RVA: 0x00934E56 File Offset: 0x00933056
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x060241A1 RID: 147873 RVA: 0x00934E6C File Offset: 0x0093306C
		// (set) Token: 0x060241A2 RID: 147874 RVA: 0x00934EA5 File Offset: 0x009330A5
		[Nullable(1)]
		public TSet<AActor> ActorList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<AActor> result;
				if ((result = this._ActorList) == null)
				{
					result = (this._ActorList = new TSet<AActor>(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorList.CopyAssign(value);
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x060241A3 RID: 147875 RVA: 0x00934EB3 File Offset: 0x009330B3
		// (set) Token: 0x060241A4 RID: 147876 RVA: 0x00934EC3 File Offset: 0x009330C3
		public unsafe int X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x060241A5 RID: 147877 RVA: 0x00934ED4 File Offset: 0x009330D4
		// (set) Token: 0x060241A6 RID: 147878 RVA: 0x00934EE4 File Offset: 0x009330E4
		public unsafe int Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x060241A7 RID: 147879 RVA: 0x00934EF5 File Offset: 0x009330F5
		// (set) Token: 0x060241A8 RID: 147880 RVA: 0x00934F05 File Offset: 0x00933105
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x060241A9 RID: 147881 RVA: 0x00934F16 File Offset: 0x00933116
		// (set) Token: 0x060241AA RID: 147882 RVA: 0x00934F26 File Offset: 0x00933126
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x060241AB RID: 147883 RVA: 0x00934F37 File Offset: 0x00933137
		// (set) Token: 0x060241AC RID: 147884 RVA: 0x00934F47 File Offset: 0x00933147
		public unsafe float Far_Plane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x060241AD RID: 147885 RVA: 0x00934F58 File Offset: 0x00933158
		// (set) Token: 0x060241AE RID: 147886 RVA: 0x00934F6C File Offset: 0x0093316C
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x060241AF RID: 147887 RVA: 0x00934F84 File Offset: 0x00933184
		// (set) Token: 0x060241B0 RID: 147888 RVA: 0x00934FBD File Offset: 0x009331BD
		[Nullable(1)]
		public TArray<AStaticMeshActor> VolumeLightMesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._VolumeLightMesh) == null)
				{
					result = (this._VolumeLightMesh = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VolumeLightMesh.CopyAssign(value);
			}
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x060241B1 RID: 147889 RVA: 0x00934FCB File Offset: 0x009331CB
		// (set) Token: 0x060241B2 RID: 147890 RVA: 0x00934FDF File Offset: 0x009331DF
		public unsafe UMaterialInstance SourceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x060241B3 RID: 147891 RVA: 0x00934FF4 File Offset: 0x009331F4
		// (set) Token: 0x060241B4 RID: 147892 RVA: 0x00935008 File Offset: 0x00933208
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x060241B5 RID: 147893 RVA: 0x0093501D File Offset: 0x0093321D
		// (set) Token: 0x060241B6 RID: 147894 RVA: 0x00935031 File Offset: 0x00933231
		public unsafe UTexture2D StaticShadowMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x060241B7 RID: 147895 RVA: 0x00935046 File Offset: 0x00933246
		// (set) Token: 0x060241B8 RID: 147896 RVA: 0x0093505A File Offset: 0x0093325A
		public unsafe UTextureRenderTarget2D RenderTargetPost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x060241B9 RID: 147897 RVA: 0x0093506F File Offset: 0x0093326F
		// (set) Token: 0x060241BA RID: 147898 RVA: 0x00935083 File Offset: 0x00933283
		public unsafe UMaterialInterface PostMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x060241BB RID: 147899 RVA: 0x00935098 File Offset: 0x00933298
		// (set) Token: 0x060241BC RID: 147900 RVA: 0x009350AC File Offset: 0x009332AC
		public unsafe UMaterialInstanceDynamic PostMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomShadowMap_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x060241BD RID: 147901 RVA: 0x009350C1 File Offset: 0x009332C1
		// (set) Token: 0x060241BE RID: 147902 RVA: 0x009350D1 File Offset: 0x009332D1
		public unsafe bool bUseMPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x060241BF RID: 147903 RVA: 0x009350E2 File Offset: 0x009332E2
		// (set) Token: 0x060241C0 RID: 147904 RVA: 0x009350F2 File Offset: 0x009332F2
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomShadowMap_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x060241C1 RID: 147905 RVA: 0x00935104 File Offset: 0x00933304
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVolumeMeshVisibility(bool bNewVisibility)
		{
			BP_KuroCustomShadowMap_C.__SetVolumeMeshVisibility_FunctionParams* ptr = stackalloc BP_KuroCustomShadowMap_C.__SetVolumeMeshVisibility_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroCustomShadowMap_C.__SetVolumeMeshVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCustomShadowMap_C.__SetVolumeMeshVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bNewVisibility = bNewVisibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__SetVolumeMeshVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060241C2 RID: 147906 RVA: 0x0093514A File Offset: 0x0093334A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PostProcessShadowTex()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__PostProcessShadowTex_NativeFunctionPtr, null);
		}

		// Token: 0x060241C3 RID: 147907 RVA: 0x0093515E File Offset: 0x0093335E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__UpdateMat_NativeFunctionPtr, null);
		}

		// Token: 0x060241C4 RID: 147908 RVA: 0x00935172 File Offset: 0x00933372
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Render()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__Render_NativeFunctionPtr, null);
		}

		// Token: 0x060241C5 RID: 147909 RVA: 0x00935186 File Offset: 0x00933386
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060241C6 RID: 147910 RVA: 0x0093519A File Offset: 0x0093339A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060241C7 RID: 147911 RVA: 0x009351AF File Offset: 0x009333AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060241C8 RID: 147912 RVA: 0x009351C3 File Offset: 0x009333C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060241C9 RID: 147913 RVA: 0x009351D8 File Offset: 0x009333D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCustomShadowMap_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCustomShadowMap_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCustomShadowMap_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCustomShadowMap_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060241CA RID: 147914 RVA: 0x00935220 File Offset: 0x00933420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCustomShadowMap_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCustomShadowMap_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCustomShadowMap_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCustomShadowMap_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060241CB RID: 147915 RVA: 0x00935268 File Offset: 0x00933468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroCustomShadowMap_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroCustomShadowMap_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCustomShadowMap_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCustomShadowMap_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060241CC RID: 147916 RVA: 0x009352B0 File Offset: 0x009334B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCustomShadowMap_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroCustomShadowMap_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCustomShadowMap_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCustomShadowMap_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCustomShadowMap_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060241CD RID: 147917 RVA: 0x009352F7 File Offset: 0x009334F7
		protected BP_KuroCustomShadowMap_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DEF RID: 73199
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroCustomShadowMap.BP_KuroCustomShadowMap_C";

		// Token: 0x04011DF0 RID: 73200
		private static IntPtr _ClassPtr;

		// Token: 0x04011DF1 RID: 73201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DF2 RID: 73202
		internal static int __PropertyOffset_1;

		// Token: 0x04011DF3 RID: 73203
		internal static int __PropertyOffset_2;

		// Token: 0x04011DF4 RID: 73204
		internal static int __PropertyOffset_3;

		// Token: 0x04011DF5 RID: 73205
		internal static int __PropertyOffset_4;

		// Token: 0x04011DF6 RID: 73206
		internal static int __PropertyOffset_5;

		// Token: 0x04011DF7 RID: 73207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AActor> _ActorList;

		// Token: 0x04011DF8 RID: 73208
		internal static int __PropertyOffset_6;

		// Token: 0x04011DF9 RID: 73209
		internal static int __PropertyOffset_7;

		// Token: 0x04011DFA RID: 73210
		internal static int __PropertyOffset_8;

		// Token: 0x04011DFB RID: 73211
		internal static int __PropertyOffset_9;

		// Token: 0x04011DFC RID: 73212
		internal static int __PropertyOffset_10;

		// Token: 0x04011DFD RID: 73213
		internal static int __PropertyOffset_11;

		// Token: 0x04011DFE RID: 73214
		internal static int __PropertyOffset_12;

		// Token: 0x04011DFF RID: 73215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _VolumeLightMesh;

		// Token: 0x04011E00 RID: 73216
		internal static int __PropertyOffset_13;

		// Token: 0x04011E01 RID: 73217
		internal static int __PropertyOffset_14;

		// Token: 0x04011E02 RID: 73218
		internal static int __PropertyOffset_15;

		// Token: 0x04011E03 RID: 73219
		internal static int __PropertyOffset_16;

		// Token: 0x04011E04 RID: 73220
		internal static int __PropertyOffset_17;

		// Token: 0x04011E05 RID: 73221
		internal static int __PropertyOffset_18;

		// Token: 0x04011E06 RID: 73222
		internal static int __PropertyOffset_19;

		// Token: 0x04011E07 RID: 73223
		internal static int __PropertyOffset_20;

		// Token: 0x04011E08 RID: 73224
		private static IntPtr __SetVolumeMeshVisibility_NativeFunctionPtr;

		// Token: 0x04011E09 RID: 73225
		private static IntPtr __PostProcessShadowTex_NativeFunctionPtr;

		// Token: 0x04011E0A RID: 73226
		private static IntPtr __UpdateMat_NativeFunctionPtr;

		// Token: 0x04011E0B RID: 73227
		private static IntPtr __Render_NativeFunctionPtr;

		// Token: 0x04011E0C RID: 73228
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011E0D RID: 73229
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011E0E RID: 73230
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011E0F RID: 73231
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009ECD RID: 40653
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetVolumeMeshVisibility_FunctionParams
		{
			// Token: 0x040317BA RID: 202682
			[FieldOffset(0)]
			public bool bNewVisibility;
		}

		// Token: 0x02009ECE RID: 40654
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317BB RID: 202683
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009ECF RID: 40655
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040317BC RID: 202684
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
