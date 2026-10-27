using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneCapturePlay
{
	// Token: 0x02003BB9 RID: 15289
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneCapturePlay/BP_SceneCapture_Play.BP_SceneCapture_Play_C")]
	[UnrealStructLayout(1640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1640)]
	public class BP_SceneCapture_Play_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022261 RID: 139873 RVA: 0x00900F7A File Offset: 0x008FF17A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneCapture_Play_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneCapturePlay/BP_SceneCapture_Play.BP_SceneCapture_Play_C");
			}
			return BP_SceneCapture_Play_C._ClassPtr;
		}

		// Token: 0x06022262 RID: 139874 RVA: 0x00900FA0 File Offset: 0x008FF1A0
		public BP_SceneCapture_Play_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneCapture_Play_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022263 RID: 139875 RVA: 0x00900FC8 File Offset: 0x008FF1C8
		[NullableContext(1)]
		public BP_SceneCapture_Play_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneCapture_Play_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x06022264 RID: 139876 RVA: 0x00900FFB File Offset: 0x008FF1FB
		// (set) Token: 0x06022265 RID: 139877 RVA: 0x0090100F File Offset: 0x008FF20F
		public unsafe UStaticMeshComponent BottomLeft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x06022266 RID: 139878 RVA: 0x00901024 File Offset: 0x008FF224
		// (set) Token: 0x06022267 RID: 139879 RVA: 0x00901038 File Offset: 0x008FF238
		public unsafe UStaticMeshComponent BottomRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x06022268 RID: 139880 RVA: 0x0090104D File Offset: 0x008FF24D
		// (set) Token: 0x06022269 RID: 139881 RVA: 0x00901061 File Offset: 0x008FF261
		public unsafe UStaticMeshComponent TopRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0602226A RID: 139882 RVA: 0x00901076 File Offset: 0x008FF276
		// (set) Token: 0x0602226B RID: 139883 RVA: 0x0090108A File Offset: 0x008FF28A
		public unsafe UStaticMeshComponent TopLeft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0602226C RID: 139884 RVA: 0x0090109F File Offset: 0x008FF29F
		// (set) Token: 0x0602226D RID: 139885 RVA: 0x009010B3 File Offset: 0x008FF2B3
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0602226E RID: 139886 RVA: 0x009010C8 File Offset: 0x008FF2C8
		// (set) Token: 0x0602226F RID: 139887 RVA: 0x009010DC File Offset: 0x008FF2DC
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x06022270 RID: 139888 RVA: 0x009010F1 File Offset: 0x008FF2F1
		// (set) Token: 0x06022271 RID: 139889 RVA: 0x00901105 File Offset: 0x008FF305
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x06022272 RID: 139890 RVA: 0x0090111C File Offset: 0x008FF31C
		// (set) Token: 0x06022273 RID: 139891 RVA: 0x00901155 File Offset: 0x008FF355
		[Nullable(1)]
		public TArray<AActor> HiddenActor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HiddenActor) == null)
				{
					result = (this._HiddenActor = new TArray<AActor>(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HiddenActor.CopyAssign(value);
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x06022274 RID: 139892 RVA: 0x00901164 File Offset: 0x008FF364
		// (set) Token: 0x06022275 RID: 139893 RVA: 0x0090119D File Offset: 0x008FF39D
		[Nullable(1)]
		public TArray<AActor> ActorPosition
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorPosition) == null)
				{
					result = (this._ActorPosition = new TArray<AActor>(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorPosition.CopyAssign(value);
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x06022276 RID: 139894 RVA: 0x009011AB File Offset: 0x008FF3AB
		// (set) Token: 0x06022277 RID: 139895 RVA: 0x009011BB File Offset: 0x008FF3BB
		public unsafe bool Capture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x06022278 RID: 139896 RVA: 0x009011CC File Offset: 0x008FF3CC
		// (set) Token: 0x06022279 RID: 139897 RVA: 0x009011DC File Offset: 0x008FF3DC
		public unsafe float FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0602227A RID: 139898 RVA: 0x009011ED File Offset: 0x008FF3ED
		// (set) Token: 0x0602227B RID: 139899 RVA: 0x009011FD File Offset: 0x008FF3FD
		public unsafe bool UIToSceneMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0602227C RID: 139900 RVA: 0x0090120E File Offset: 0x008FF40E
		// (set) Token: 0x0602227D RID: 139901 RVA: 0x00901222 File Offset: 0x008FF422
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0602227E RID: 139902 RVA: 0x00901237 File Offset: 0x008FF437
		// (set) Token: 0x0602227F RID: 139903 RVA: 0x0090124B File Offset: 0x008FF44B
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x06022280 RID: 139904 RVA: 0x00901260 File Offset: 0x008FF460
		// (set) Token: 0x06022281 RID: 139905 RVA: 0x00901270 File Offset: 0x008FF470
		public unsafe float Scale_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x06022282 RID: 139906 RVA: 0x00901281 File Offset: 0x008FF481
		// (set) Token: 0x06022283 RID: 139907 RVA: 0x00901291 File Offset: 0x008FF491
		public unsafe float Scale_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x06022284 RID: 139908 RVA: 0x009012A2 File Offset: 0x008FF4A2
		// (set) Token: 0x06022285 RID: 139909 RVA: 0x009012B2 File Offset: 0x008FF4B2
		public unsafe float Offset_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x06022286 RID: 139910 RVA: 0x009012C3 File Offset: 0x008FF4C3
		// (set) Token: 0x06022287 RID: 139911 RVA: 0x009012D3 File Offset: 0x008FF4D3
		public unsafe float Offset_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x06022288 RID: 139912 RVA: 0x009012E4 File Offset: 0x008FF4E4
		// (set) Token: 0x06022289 RID: 139913 RVA: 0x009012F8 File Offset: 0x008FF4F8
		public unsafe UTexture2D UVToSceneTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0602228A RID: 139914 RVA: 0x0090130D File Offset: 0x008FF50D
		// (set) Token: 0x0602228B RID: 139915 RVA: 0x00901321 File Offset: 0x008FF521
		public unsafe FVector CameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0602228C RID: 139916 RVA: 0x00901336 File Offset: 0x008FF536
		// (set) Token: 0x0602228D RID: 139917 RVA: 0x0090134A File Offset: 0x008FF54A
		public unsafe FRotator CameraRotarion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0602228E RID: 139918 RVA: 0x0090135F File Offset: 0x008FF55F
		// (set) Token: 0x0602228F RID: 139919 RVA: 0x0090136F File Offset: 0x008FF56F
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_Play_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x06022290 RID: 139920 RVA: 0x00901380 File Offset: 0x008FF580
		// (set) Token: 0x06022291 RID: 139921 RVA: 0x00901394 File Offset: 0x008FF594
		public unsafe UMaterialInstanceDynamic DynamicMaterial_SceneCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_Play_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x06022292 RID: 139922 RVA: 0x009013A9 File Offset: 0x008FF5A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Editor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_Play_C.__Editor_NativeFunctionPtr, null);
		}

		// Token: 0x06022293 RID: 139923 RVA: 0x009013BD File Offset: 0x008FF5BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void runtime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_Play_C.__runtime_NativeFunctionPtr, null);
		}

		// Token: 0x06022294 RID: 139924 RVA: 0x009013D1 File Offset: 0x008FF5D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_Play_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022295 RID: 139925 RVA: 0x009013E5 File Offset: 0x008FF5E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_Play_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022296 RID: 139926 RVA: 0x009013FA File Offset: 0x008FF5FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_Play_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022297 RID: 139927 RVA: 0x0090140E File Offset: 0x008FF60E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_Play_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022298 RID: 139928 RVA: 0x00901424 File Offset: 0x008FF624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneCapture_Play_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneCapture_Play_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_Play_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_Play_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_Play_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022299 RID: 139929 RVA: 0x0090146C File Offset: 0x008FF66C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneCapture_Play_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneCapture_Play_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_Play_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_Play_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_Play_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602229A RID: 139930 RVA: 0x009014B4 File Offset: 0x008FF6B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SceneCapture_Play_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneCapture_Play_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_Play_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_Play_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_Play_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602229B RID: 139931 RVA: 0x009014FC File Offset: 0x008FF6FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SceneCapture_Play_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneCapture_Play_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_Play_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_Play_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_Play_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602229C RID: 139932 RVA: 0x00901543 File Offset: 0x008FF743
		protected BP_SceneCapture_Play_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BA8 RID: 68520
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneCapturePlay/BP_SceneCapture_Play.BP_SceneCapture_Play_C";

		// Token: 0x04010BA9 RID: 68521
		private static IntPtr _ClassPtr;

		// Token: 0x04010BAA RID: 68522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010BAB RID: 68523
		internal static int __PropertyOffset_1;

		// Token: 0x04010BAC RID: 68524
		internal static int __PropertyOffset_2;

		// Token: 0x04010BAD RID: 68525
		internal static int __PropertyOffset_3;

		// Token: 0x04010BAE RID: 68526
		internal static int __PropertyOffset_4;

		// Token: 0x04010BAF RID: 68527
		internal static int __PropertyOffset_5;

		// Token: 0x04010BB0 RID: 68528
		internal static int __PropertyOffset_6;

		// Token: 0x04010BB1 RID: 68529
		internal static int __PropertyOffset_7;

		// Token: 0x04010BB2 RID: 68530
		internal static int __PropertyOffset_8;

		// Token: 0x04010BB3 RID: 68531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActor;

		// Token: 0x04010BB4 RID: 68532
		internal static int __PropertyOffset_9;

		// Token: 0x04010BB5 RID: 68533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorPosition;

		// Token: 0x04010BB6 RID: 68534
		internal static int __PropertyOffset_10;

		// Token: 0x04010BB7 RID: 68535
		internal static int __PropertyOffset_11;

		// Token: 0x04010BB8 RID: 68536
		internal static int __PropertyOffset_12;

		// Token: 0x04010BB9 RID: 68537
		internal static int __PropertyOffset_13;

		// Token: 0x04010BBA RID: 68538
		internal static int __PropertyOffset_14;

		// Token: 0x04010BBB RID: 68539
		internal static int __PropertyOffset_15;

		// Token: 0x04010BBC RID: 68540
		internal static int __PropertyOffset_16;

		// Token: 0x04010BBD RID: 68541
		internal static int __PropertyOffset_17;

		// Token: 0x04010BBE RID: 68542
		internal static int __PropertyOffset_18;

		// Token: 0x04010BBF RID: 68543
		internal static int __PropertyOffset_19;

		// Token: 0x04010BC0 RID: 68544
		internal static int __PropertyOffset_20;

		// Token: 0x04010BC1 RID: 68545
		internal static int __PropertyOffset_21;

		// Token: 0x04010BC2 RID: 68546
		internal static int __PropertyOffset_22;

		// Token: 0x04010BC3 RID: 68547
		internal static int __PropertyOffset_23;

		// Token: 0x04010BC4 RID: 68548
		private static IntPtr __Editor_NativeFunctionPtr;

		// Token: 0x04010BC5 RID: 68549
		private static IntPtr __runtime_NativeFunctionPtr;

		// Token: 0x04010BC6 RID: 68550
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010BC7 RID: 68551
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010BC8 RID: 68552
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010BC9 RID: 68553
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D49 RID: 40265
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314B4 RID: 201908
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D4A RID: 40266
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314B5 RID: 201909
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
