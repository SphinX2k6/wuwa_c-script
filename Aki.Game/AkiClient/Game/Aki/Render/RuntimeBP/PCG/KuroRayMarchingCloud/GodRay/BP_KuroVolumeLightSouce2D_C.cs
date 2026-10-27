using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.GodRay
{
	// Token: 0x02003C82 RID: 15490
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroVolumeLightSouce2D.BP_KuroVolumeLightSouce2D_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1612)]
	public class BP_KuroVolumeLightSouce2D_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060241CE RID: 147918 RVA: 0x00935300 File Offset: 0x00933500
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumeLightSouce2D_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroVolumeLightSouce2D.BP_KuroVolumeLightSouce2D_C");
			}
			return BP_KuroVolumeLightSouce2D_C._ClassPtr;
		}

		// Token: 0x060241CF RID: 147919 RVA: 0x00935324 File Offset: 0x00933524
		public BP_KuroVolumeLightSouce2D_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeLightSouce2D_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060241D0 RID: 147920 RVA: 0x0093534C File Offset: 0x0093354C
		[NullableContext(1)]
		public BP_KuroVolumeLightSouce2D_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeLightSouce2D_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x060241D1 RID: 147921 RVA: 0x0093537F File Offset: 0x0093357F
		// (set) Token: 0x060241D2 RID: 147922 RVA: 0x00935393 File Offset: 0x00933593
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x060241D3 RID: 147923 RVA: 0x009353A8 File Offset: 0x009335A8
		// (set) Token: 0x060241D4 RID: 147924 RVA: 0x009353BC File Offset: 0x009335BC
		public unsafe USceneComponent RangeRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x060241D5 RID: 147925 RVA: 0x009353D1 File Offset: 0x009335D1
		// (set) Token: 0x060241D6 RID: 147926 RVA: 0x009353E5 File Offset: 0x009335E5
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x060241D7 RID: 147927 RVA: 0x009353FA File Offset: 0x009335FA
		// (set) Token: 0x060241D8 RID: 147928 RVA: 0x0093540E File Offset: 0x0093360E
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x060241D9 RID: 147929 RVA: 0x00935423 File Offset: 0x00933623
		// (set) Token: 0x060241DA RID: 147930 RVA: 0x00935433 File Offset: 0x00933633
		public unsafe int X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x060241DB RID: 147931 RVA: 0x00935444 File Offset: 0x00933644
		// (set) Token: 0x060241DC RID: 147932 RVA: 0x00935454 File Offset: 0x00933654
		public unsafe int Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x060241DD RID: 147933 RVA: 0x00935465 File Offset: 0x00933665
		// (set) Token: 0x060241DE RID: 147934 RVA: 0x00935475 File Offset: 0x00933675
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x060241DF RID: 147935 RVA: 0x00935486 File Offset: 0x00933686
		// (set) Token: 0x060241E0 RID: 147936 RVA: 0x00935496 File Offset: 0x00933696
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x060241E1 RID: 147937 RVA: 0x009354A7 File Offset: 0x009336A7
		// (set) Token: 0x060241E2 RID: 147938 RVA: 0x009354B7 File Offset: 0x009336B7
		public unsafe float Far_Plane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x060241E3 RID: 147939 RVA: 0x009354C8 File Offset: 0x009336C8
		// (set) Token: 0x060241E4 RID: 147940 RVA: 0x009354DC File Offset: 0x009336DC
		public unsafe UTexture LightSource2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x060241E5 RID: 147941 RVA: 0x009354F4 File Offset: 0x009336F4
		// (set) Token: 0x060241E6 RID: 147942 RVA: 0x0093552D File Offset: 0x0093372D
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
					result = (this._VolumeLightMesh = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VolumeLightMesh.CopyAssign(value);
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x060241E7 RID: 147943 RVA: 0x0093553B File Offset: 0x0093373B
		// (set) Token: 0x060241E8 RID: 147944 RVA: 0x0093554F File Offset: 0x0093374F
		public unsafe UMaterialInstance SourceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x060241E9 RID: 147945 RVA: 0x00935564 File Offset: 0x00933764
		// (set) Token: 0x060241EA RID: 147946 RVA: 0x00935578 File Offset: 0x00933778
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x060241EB RID: 147947 RVA: 0x0093558D File Offset: 0x0093378D
		// (set) Token: 0x060241EC RID: 147948 RVA: 0x009355A1 File Offset: 0x009337A1
		public unsafe UTextureRenderTarget2D LightSource2DPost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x060241ED RID: 147949 RVA: 0x009355B6 File Offset: 0x009337B6
		// (set) Token: 0x060241EE RID: 147950 RVA: 0x009355CA File Offset: 0x009337CA
		public unsafe UMaterialInterface PostMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x060241EF RID: 147951 RVA: 0x009355DF File Offset: 0x009337DF
		// (set) Token: 0x060241F0 RID: 147952 RVA: 0x009355F3 File Offset: 0x009337F3
		public unsafe UMaterialInstanceDynamic PostMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x060241F1 RID: 147953 RVA: 0x00935608 File Offset: 0x00933808
		// (set) Token: 0x060241F2 RID: 147954 RVA: 0x00935618 File Offset: 0x00933818
		public unsafe bool bUseMPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x060241F3 RID: 147955 RVA: 0x00935629 File Offset: 0x00933829
		// (set) Token: 0x060241F4 RID: 147956 RVA: 0x00935639 File Offset: 0x00933839
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x060241F5 RID: 147957 RVA: 0x0093564A File Offset: 0x0093384A
		// (set) Token: 0x060241F6 RID: 147958 RVA: 0x0093565E File Offset: 0x0093385E
		public unsafe UTextureRenderTarget2D Texture_Render_Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x060241F7 RID: 147959 RVA: 0x00935673 File Offset: 0x00933873
		// (set) Token: 0x060241F8 RID: 147960 RVA: 0x00935687 File Offset: 0x00933887
		public unsafe AActor PlaneMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeLightSouce2D_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x060241F9 RID: 147961 RVA: 0x0093569C File Offset: 0x0093389C
		// (set) Token: 0x060241FA RID: 147962 RVA: 0x009356AC File Offset: 0x009338AC
		public unsafe int LastQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeLightSouce2D_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x060241FB RID: 147963 RVA: 0x009356BD File Offset: 0x009338BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateShadingRate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__UpdateShadingRate_NativeFunctionPtr, null);
		}

		// Token: 0x060241FC RID: 147964 RVA: 0x009356D1 File Offset: 0x009338D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePlane()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__UpdatePlane_NativeFunctionPtr, null);
		}

		// Token: 0x060241FD RID: 147965 RVA: 0x009356E8 File Offset: 0x009338E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVolumeMeshVisibility(bool bNewVisibility)
		{
			BP_KuroVolumeLightSouce2D_C.__SetVolumeMeshVisibility_FunctionParams* ptr = stackalloc BP_KuroVolumeLightSouce2D_C.__SetVolumeMeshVisibility_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroVolumeLightSouce2D_C.__SetVolumeMeshVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeLightSouce2D_C.__SetVolumeMeshVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bNewVisibility = bNewVisibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__SetVolumeMeshVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060241FE RID: 147966 RVA: 0x0093572E File Offset: 0x0093392E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PostProcessTex()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__PostProcessTex_NativeFunctionPtr, null);
		}

		// Token: 0x060241FF RID: 147967 RVA: 0x00935742 File Offset: 0x00933942
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__UpdateMat_NativeFunctionPtr, null);
		}

		// Token: 0x06024200 RID: 147968 RVA: 0x00935756 File Offset: 0x00933956
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Render()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__Render_NativeFunctionPtr, null);
		}

		// Token: 0x06024201 RID: 147969 RVA: 0x0093576A File Offset: 0x0093396A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024202 RID: 147970 RVA: 0x0093577E File Offset: 0x0093397E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024203 RID: 147971 RVA: 0x00935793 File Offset: 0x00933993
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024204 RID: 147972 RVA: 0x009357A7 File Offset: 0x009339A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024205 RID: 147973 RVA: 0x009357BC File Offset: 0x009339BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroVolumeLightSouce2D_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeLightSouce2D_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeLightSouce2D_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeLightSouce2D_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024206 RID: 147974 RVA: 0x00935804 File Offset: 0x00933A04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeLightSouce2D_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeLightSouce2D_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeLightSouce2D_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeLightSouce2D_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024207 RID: 147975 RVA: 0x0093584C File Offset: 0x00933A4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroVolumeLightSouce2D_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroVolumeLightSouce2D_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeLightSouce2D_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeLightSouce2D_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024208 RID: 147976 RVA: 0x00935894 File Offset: 0x00933A94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeLightSouce2D_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroVolumeLightSouce2D_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeLightSouce2D_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeLightSouce2D_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeLightSouce2D_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024209 RID: 147977 RVA: 0x009358DB File Offset: 0x00933ADB
		protected BP_KuroVolumeLightSouce2D_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E10 RID: 73232
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroVolumeLightSouce2D.BP_KuroVolumeLightSouce2D_C";

		// Token: 0x04011E11 RID: 73233
		private static IntPtr _ClassPtr;

		// Token: 0x04011E12 RID: 73234
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E13 RID: 73235
		internal static int __PropertyOffset_1;

		// Token: 0x04011E14 RID: 73236
		internal static int __PropertyOffset_2;

		// Token: 0x04011E15 RID: 73237
		internal static int __PropertyOffset_3;

		// Token: 0x04011E16 RID: 73238
		internal static int __PropertyOffset_4;

		// Token: 0x04011E17 RID: 73239
		internal static int __PropertyOffset_5;

		// Token: 0x04011E18 RID: 73240
		internal static int __PropertyOffset_6;

		// Token: 0x04011E19 RID: 73241
		internal static int __PropertyOffset_7;

		// Token: 0x04011E1A RID: 73242
		internal static int __PropertyOffset_8;

		// Token: 0x04011E1B RID: 73243
		internal static int __PropertyOffset_9;

		// Token: 0x04011E1C RID: 73244
		internal static int __PropertyOffset_10;

		// Token: 0x04011E1D RID: 73245
		internal static int __PropertyOffset_11;

		// Token: 0x04011E1E RID: 73246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _VolumeLightMesh;

		// Token: 0x04011E1F RID: 73247
		internal static int __PropertyOffset_12;

		// Token: 0x04011E20 RID: 73248
		internal static int __PropertyOffset_13;

		// Token: 0x04011E21 RID: 73249
		internal static int __PropertyOffset_14;

		// Token: 0x04011E22 RID: 73250
		internal static int __PropertyOffset_15;

		// Token: 0x04011E23 RID: 73251
		internal static int __PropertyOffset_16;

		// Token: 0x04011E24 RID: 73252
		internal static int __PropertyOffset_17;

		// Token: 0x04011E25 RID: 73253
		internal static int __PropertyOffset_18;

		// Token: 0x04011E26 RID: 73254
		internal static int __PropertyOffset_19;

		// Token: 0x04011E27 RID: 73255
		internal static int __PropertyOffset_20;

		// Token: 0x04011E28 RID: 73256
		internal static int __PropertyOffset_21;

		// Token: 0x04011E29 RID: 73257
		private static IntPtr __UpdateShadingRate_NativeFunctionPtr;

		// Token: 0x04011E2A RID: 73258
		private static IntPtr __UpdatePlane_NativeFunctionPtr;

		// Token: 0x04011E2B RID: 73259
		private static IntPtr __SetVolumeMeshVisibility_NativeFunctionPtr;

		// Token: 0x04011E2C RID: 73260
		private static IntPtr __PostProcessTex_NativeFunctionPtr;

		// Token: 0x04011E2D RID: 73261
		private static IntPtr __UpdateMat_NativeFunctionPtr;

		// Token: 0x04011E2E RID: 73262
		private static IntPtr __Render_NativeFunctionPtr;

		// Token: 0x04011E2F RID: 73263
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011E30 RID: 73264
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011E31 RID: 73265
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011E32 RID: 73266
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009ED0 RID: 40656
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetVolumeMeshVisibility_FunctionParams
		{
			// Token: 0x040317BD RID: 202685
			[FieldOffset(0)]
			public bool bNewVisibility;
		}

		// Token: 0x02009ED1 RID: 40657
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317BE RID: 202686
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009ED2 RID: 40658
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040317BF RID: 202687
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
