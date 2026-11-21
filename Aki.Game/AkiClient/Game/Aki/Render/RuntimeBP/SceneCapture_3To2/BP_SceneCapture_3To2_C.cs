using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneCapture_3To2
{
	// Token: 0x020030D7 RID: 12503
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneCapture_3To2/BP_SceneCapture_3To2.BP_SceneCapture_3To2_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1577)]
	public class BP_SceneCapture_3To2_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E28A RID: 123530 RVA: 0x0090C892 File Offset: 0x0090AA92
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneCapture_3To2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneCapture_3To2/BP_SceneCapture_3To2.BP_SceneCapture_3To2_C");
			}
			return BP_SceneCapture_3To2_C._ClassPtr;
		}

		// Token: 0x0601E28B RID: 123531 RVA: 0x0090C8B8 File Offset: 0x0090AAB8
		public BP_SceneCapture_3To2_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneCapture_3To2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E28C RID: 123532 RVA: 0x0090C8E0 File Offset: 0x0090AAE0
		[NullableContext(1)]
		public BP_SceneCapture_3To2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneCapture_3To2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0601E28D RID: 123533 RVA: 0x0090C913 File Offset: 0x0090AB13
		// (set) Token: 0x0601E28E RID: 123534 RVA: 0x0090C927 File Offset: 0x0090AB27
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_SceneCaptureComponent2D);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_SceneCaptureComponent2D, value);
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0601E28F RID: 123535 RVA: 0x0090C93C File Offset: 0x0090AB3C
		// (set) Token: 0x0601E290 RID: 123536 RVA: 0x0090C950 File Offset: 0x0090AB50
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0601E291 RID: 123537 RVA: 0x0090C968 File Offset: 0x0090AB68
		// (set) Token: 0x0601E292 RID: 123538 RVA: 0x0090C9A1 File Offset: 0x0090ABA1
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
					result = (this._HiddenActor = new TArray<AActor>(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_HiddenActor, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HiddenActor.CopyAssign(value);
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0601E293 RID: 123539 RVA: 0x0090C9B0 File Offset: 0x0090ABB0
		// (set) Token: 0x0601E294 RID: 123540 RVA: 0x0090C9E9 File Offset: 0x0090ABE9
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
					result = (this._ActorPosition = new TArray<AActor>(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_ActorPosition, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorPosition.CopyAssign(value);
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0601E295 RID: 123541 RVA: 0x0090C9F7 File Offset: 0x0090ABF7
		// (set) Token: 0x0601E296 RID: 123542 RVA: 0x0090CA07 File Offset: 0x0090AC07
		public unsafe bool Capture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_Capture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_Capture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0601E297 RID: 123543 RVA: 0x0090CA18 File Offset: 0x0090AC18
		// (set) Token: 0x0601E298 RID: 123544 RVA: 0x0090CA2C File Offset: 0x0090AC2C
		public unsafe AKuroPostProcessVolume PPV
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_PPV);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_PPV, value);
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0601E299 RID: 123545 RVA: 0x0090CA41 File Offset: 0x0090AC41
		// (set) Token: 0x0601E29A RID: 123546 RVA: 0x0090CA56 File Offset: 0x0090AC56
		[Nullable(1)]
		public TSoftObjectPtr<UTextureRenderTarget2D> RTSoft
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UTextureRenderTarget2D>(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_RTSoft, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_RTSoft, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0601E29B RID: 123547 RVA: 0x0090CA7B File Offset: 0x0090AC7B
		// (set) Token: 0x0601E29C RID: 123548 RVA: 0x0090CA8F File Offset: 0x0090AC8F
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_RT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_RT, value);
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0601E29D RID: 123549 RVA: 0x0090CAA4 File Offset: 0x0090ACA4
		// (set) Token: 0x0601E29E RID: 123550 RVA: 0x0090CAB4 File Offset: 0x0090ACB4
		public unsafe bool First
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_First) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_First) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E29F RID: 123551 RVA: 0x0090CAC8 File Offset: 0x0090ACC8
		[SkipLocalsInit]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			BP_SceneCapture_3To2_C.__GetAoiRange_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__GetAoiRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E2A0 RID: 123552 RVA: 0x0090CB18 File Offset: 0x0090AD18
		[SkipLocalsInit]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			BP_SceneCapture_3To2_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E2A1 RID: 123553 RVA: 0x0090CB67 File Offset: 0x0090AD67
		[SkipLocalsInit]
		public virtual void DisableToonDepth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__DisableToonDepth_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A2 RID: 123554 RVA: 0x0090CB7B File Offset: 0x0090AD7B
		[SkipLocalsInit]
		public virtual void EnableToonDepth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__EnableToonDepth_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A3 RID: 123555 RVA: 0x0090CB8F File Offset: 0x0090AD8F
		[SkipLocalsInit]
		public virtual void AllowOcclusionQueries()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__AllowOcclusionQueries_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A4 RID: 123556 RVA: 0x0090CBA3 File Offset: 0x0090ADA3
		[SkipLocalsInit]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A5 RID: 123557 RVA: 0x0090CBB8 File Offset: 0x0090ADB8
		[SkipLocalsInit]
		public unsafe virtual void SetEnablePPV(float Enable3To2Toggle)
		{
			BP_SceneCapture_3To2_C.__SetEnablePPV_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__SetEnablePPV_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__SetEnablePPV_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__SetEnablePPV_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable3To2Toggle = Enable3To2Toggle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__SetEnablePPV_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E2A6 RID: 123558 RVA: 0x0090CBFE File Offset: 0x0090ADFE
		[SkipLocalsInit]
		public virtual void CaptureScene_Running()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__CaptureScene_Running_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A7 RID: 123559 RVA: 0x0090CC12 File Offset: 0x0090AE12
		[SkipLocalsInit]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A8 RID: 123560 RVA: 0x0090CC26 File Offset: 0x0090AE26
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2A9 RID: 123561 RVA: 0x0090CC3A File Offset: 0x0090AE3A
		[SkipLocalsInit]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2AA RID: 123562 RVA: 0x0090CC4E File Offset: 0x0090AE4E
		[SkipLocalsInit]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2AB RID: 123563 RVA: 0x0090CC62 File Offset: 0x0090AE62
		[SkipLocalsInit]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2AC RID: 123564 RVA: 0x0090CC78 File Offset: 0x0090AE78
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SceneCapture_3To2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E2AD RID: 123565 RVA: 0x0090CCC0 File Offset: 0x0090AEC0
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SceneCapture_3To2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E2AE RID: 123566 RVA: 0x0090CD06 File Offset: 0x0090AF06
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2AF RID: 123567 RVA: 0x0090CD1A File Offset: 0x0090AF1A
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2B0 RID: 123568 RVA: 0x0090CD2E File Offset: 0x0090AF2E
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2B1 RID: 123569 RVA: 0x0090CD42 File Offset: 0x0090AF42
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2B2 RID: 123570 RVA: 0x0090CD56 File Offset: 0x0090AF56
		protected BP_SceneCapture_3To2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF3B RID: 65339
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneCapture_3To2/BP_SceneCapture_3To2.BP_SceneCapture_3To2_C";

		// Token: 0x0400FF3C RID: 65340
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF3D RID: 65341
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF3E RID: 65342
		internal static int __PropertyOffset_SceneCaptureComponent2D;

		// Token: 0x0400FF3F RID: 65343
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FF40 RID: 65344
		internal static int __PropertyOffset_HiddenActor;

		// Token: 0x0400FF41 RID: 65345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActor;

		// Token: 0x0400FF42 RID: 65346
		internal static int __PropertyOffset_ActorPosition;

		// Token: 0x0400FF43 RID: 65347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorPosition;

		// Token: 0x0400FF44 RID: 65348
		internal static int __PropertyOffset_Capture;

		// Token: 0x0400FF45 RID: 65349
		internal static int __PropertyOffset_PPV;

		// Token: 0x0400FF46 RID: 65350
		internal static int __PropertyOffset_RTSoft;

		// Token: 0x0400FF47 RID: 65351
		internal static int __PropertyOffset_RT;

		// Token: 0x0400FF48 RID: 65352
		internal static int __PropertyOffset_First;

		// Token: 0x0400FF49 RID: 65353
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x0400FF4A RID: 65354
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x0400FF4B RID: 65355
		private static IntPtr __DisableToonDepth_NativeFunctionPtr;

		// Token: 0x0400FF4C RID: 65356
		private static IntPtr __EnableToonDepth_NativeFunctionPtr;

		// Token: 0x0400FF4D RID: 65357
		private static IntPtr __AllowOcclusionQueries_NativeFunctionPtr;

		// Token: 0x0400FF4E RID: 65358
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x0400FF4F RID: 65359
		private static IntPtr __SetEnablePPV_NativeFunctionPtr;

		// Token: 0x0400FF50 RID: 65360
		private static IntPtr __CaptureScene_Running_NativeFunctionPtr;

		// Token: 0x0400FF51 RID: 65361
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x0400FF52 RID: 65362
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FF53 RID: 65363
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0400FF54 RID: 65364
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x0400FF55 RID: 65365
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x0400FF56 RID: 65366
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FF57 RID: 65367
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FF58 RID: 65368
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008E2E RID: 36398
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0402CA6F RID: 182895
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02008E2F RID: 36399
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0402CA70 RID: 182896
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02008E30 RID: 36400
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetEnablePPV_FunctionParams
		{
			// Token: 0x0402CA71 RID: 182897
			[FieldOffset(0)]
			public float Enable3To2Toggle;
		}

		// Token: 0x02008E31 RID: 36401
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA72 RID: 182898
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
