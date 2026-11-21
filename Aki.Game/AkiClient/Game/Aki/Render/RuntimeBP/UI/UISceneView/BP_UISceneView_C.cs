using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI.UISceneView
{
	// Token: 0x020030A8 RID: 12456
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/UISceneView/BP_UISceneView.BP_UISceneView_C")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class BP_UISceneView_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD45 RID: 122181 RVA: 0x00903332 File Offset: 0x00901532
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UISceneView_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/UISceneView/BP_UISceneView.BP_UISceneView_C");
			}
			return BP_UISceneView_C._ClassPtr;
		}

		// Token: 0x0601DD46 RID: 122182 RVA: 0x00903358 File Offset: 0x00901558
		public BP_UISceneView_C() : this(BuiltinUtils.AllocNativeUObject(BP_UISceneView_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD47 RID: 122183 RVA: 0x00903380 File Offset: 0x00901580
		[NullableContext(1)]
		public BP_UISceneView_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UISceneView_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0601DD48 RID: 122184 RVA: 0x009033B3 File Offset: 0x009015B3
		// (set) Token: 0x0601DD49 RID: 122185 RVA: 0x009033C7 File Offset: 0x009015C7
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_Box);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_Box, value);
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0601DD4A RID: 122186 RVA: 0x009033DC File Offset: 0x009015DC
		// (set) Token: 0x0601DD4B RID: 122187 RVA: 0x009033F0 File Offset: 0x009015F0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0601DD4C RID: 122188 RVA: 0x00903405 File Offset: 0x00901605
		// (set) Token: 0x0601DD4D RID: 122189 RVA: 0x00903419 File Offset: 0x00901619
		public unsafe UTimelineComponent TimeLine_Alpha
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_TimeLine_Alpha);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_TimeLine_Alpha, value);
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0601DD4E RID: 122190 RVA: 0x0090342E File Offset: 0x0090162E
		// (set) Token: 0x0601DD4F RID: 122191 RVA: 0x00903442 File Offset: 0x00901642
		public unsafe AUIContainerActor ScreenSpaceUIRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_ScreenSpaceUIRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UISceneView_C.__PropertyOffset_ScreenSpaceUIRoot, value);
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0601DD50 RID: 122192 RVA: 0x00903457 File Offset: 0x00901657
		// (set) Token: 0x0601DD51 RID: 122193 RVA: 0x0090346B File Offset: 0x0090166B
		public unsafe FVector RelativeLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_RelativeLoc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_RelativeLoc) = value;
			}
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0601DD52 RID: 122194 RVA: 0x00903480 File Offset: 0x00901680
		// (set) Token: 0x0601DD53 RID: 122195 RVA: 0x00903494 File Offset: 0x00901694
		public unsafe FRotator RelativeRoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_RelativeRoc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_RelativeRoc) = value;
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0601DD54 RID: 122196 RVA: 0x009034A9 File Offset: 0x009016A9
		// (set) Token: 0x0601DD55 RID: 122197 RVA: 0x009034B9 File Offset: 0x009016B9
		public unsafe float Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_Fov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_Fov) = value;
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0601DD56 RID: 122198 RVA: 0x009034CA File Offset: 0x009016CA
		// (set) Token: 0x0601DD57 RID: 122199 RVA: 0x009034DA File Offset: 0x009016DA
		public unsafe float FadeInDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_FadeInDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_FadeInDuration) = value;
			}
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0601DD58 RID: 122200 RVA: 0x009034EB File Offset: 0x009016EB
		// (set) Token: 0x0601DD59 RID: 122201 RVA: 0x009034FB File Offset: 0x009016FB
		public unsafe float minAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_minAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_minAlpha) = value;
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0601DD5A RID: 122202 RVA: 0x0090350C File Offset: 0x0090170C
		// (set) Token: 0x0601DD5B RID: 122203 RVA: 0x0090351C File Offset: 0x0090171C
		public unsafe float maxAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_maxAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_maxAlpha) = value;
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0601DD5C RID: 122204 RVA: 0x0090352D File Offset: 0x0090172D
		// (set) Token: 0x0601DD5D RID: 122205 RVA: 0x0090353D File Offset: 0x0090173D
		public unsafe bool isInit_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_isInit_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_isInit_) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0601DD5E RID: 122206 RVA: 0x00903550 File Offset: 0x00901750
		// (set) Token: 0x0601DD5F RID: 122207 RVA: 0x00903589 File Offset: 0x00901789
		[Nullable(1)]
		public TArray<FEngineShowFlagsSetting> Show_Flag_Settings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FEngineShowFlagsSetting> result;
				if ((result = this._Show_Flag_Settings) == null)
				{
					result = (this._Show_Flag_Settings = new TArray<FEngineShowFlagsSetting>(base.NativePtr + (IntPtr)BP_UISceneView_C.__PropertyOffset_Show_Flag_Settings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Show_Flag_Settings.CopyAssign(value);
			}
		}

		// Token: 0x0601DD60 RID: 122208 RVA: 0x00903598 File Offset: 0x00901798
		[SkipLocalsInit]
		public unsafe virtual void SetFov(float Fov)
		{
			BP_UISceneView_C.__SetFov_FunctionParams* ptr = stackalloc BP_UISceneView_C.__SetFov_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_UISceneView_C.__SetFov_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__SetFov_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Fov = Fov;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__SetFov_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD61 RID: 122209 RVA: 0x009035E0 File Offset: 0x009017E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void SetSceneViewMaterailSingleParameter(string ParameterName, float value)
		{
			BP_UISceneView_C.__SetSceneViewMaterailSingleParameter_FunctionParams* ptr = stackalloc BP_UISceneView_C.__SetSceneViewMaterailSingleParameter_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_UISceneView_C.__SetSceneViewMaterailSingleParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__SetSceneViewMaterailSingleParameter_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ParameterName), ParameterName);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__SetSceneViewMaterailSingleParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_UISceneView_C.__SetSceneViewMaterailSingleParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD62 RID: 122210 RVA: 0x00903644 File Offset: 0x00901844
		[SkipLocalsInit]
		public unsafe virtual void SetSceneViewMaterialParams(float CenterOffsetX, float CenterOffsetY)
		{
			BP_UISceneView_C.__SetSceneViewMaterialParams_FunctionParams* ptr = stackalloc BP_UISceneView_C.__SetSceneViewMaterialParams_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_UISceneView_C.__SetSceneViewMaterialParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__SetSceneViewMaterialParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CenterOffsetX = CenterOffsetX;
			ptr->CenterOffsetY = CenterOffsetY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__SetSceneViewMaterialParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD63 RID: 122211 RVA: 0x00903694 File Offset: 0x00901894
		[SkipLocalsInit]
		public unsafe virtual void SetSceneViewMaterialParameters(float AlphaExp, float AlphaPosition, float CenterOffsetX, float CenterOffsetY, float FlowSpeed, float NoiseScale)
		{
			BP_UISceneView_C.__SetSceneViewMaterialParameters_FunctionParams* ptr = stackalloc BP_UISceneView_C.__SetSceneViewMaterialParameters_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_UISceneView_C.__SetSceneViewMaterialParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__SetSceneViewMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AlphaExp = AlphaExp;
			ptr->AlphaPosition = AlphaPosition;
			ptr->CenterOffsetX = CenterOffsetX;
			ptr->CenterOffsetY = CenterOffsetY;
			ptr->FlowSpeed = FlowSpeed;
			ptr->NoiseScale = NoiseScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__SetSceneViewMaterialParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD64 RID: 122212 RVA: 0x00903700 File Offset: 0x00901900
		[SkipLocalsInit]
		public unsafe virtual void GetPlayer0CameraTransformWithOffset(FVectorDouble RelativeOffset, ref FTransformDouble Transform)
		{
			BP_UISceneView_C.__GetPlayer0CameraTransformWithOffset_FunctionParams* ptr = stackalloc BP_UISceneView_C.__GetPlayer0CameraTransformWithOffset_FunctionParams[(UIntPtr)351] + 15L / (long)sizeof(BP_UISceneView_C.__GetPlayer0CameraTransformWithOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__GetPlayer0CameraTransformWithOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RelativeOffset = RelativeOffset;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__GetPlayer0CameraTransformWithOffset_NativeFunctionPtr, (void*)ptr);
			Transform = ptr->Transform;
		}

		// Token: 0x0601DD65 RID: 122213 RVA: 0x00903761 File Offset: 0x00901961
		[SkipLocalsInit]
		public virtual void TimeLine_Alpha__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__TimeLine_Alpha__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD66 RID: 122214 RVA: 0x00903775 File Offset: 0x00901975
		[SkipLocalsInit]
		public virtual void TimeLine_Alpha__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__TimeLine_Alpha__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD67 RID: 122215 RVA: 0x0090378C File Offset: 0x0090198C
		[SkipLocalsInit]
		public unsafe virtual void AppendSceneView(AUIContainerActor AttachActor, FTransformDouble Transform)
		{
			BP_UISceneView_C.__AppendSceneView_FunctionParams* ptr = stackalloc BP_UISceneView_C.__AppendSceneView_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_UISceneView_C.__AppendSceneView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__AppendSceneView_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AttachActor = ((AttachActor != null) ? AttachActor.NativePtr : IntPtr.Zero);
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__AppendSceneView_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD68 RID: 122216 RVA: 0x009037E8 File Offset: 0x009019E8
		[SkipLocalsInit]
		public virtual void InitCapture2DActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__InitCapture2DActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD69 RID: 122217 RVA: 0x009037FC File Offset: 0x009019FC
		[SkipLocalsInit]
		public unsafe virtual void BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_UISceneView_C.__BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_UISceneView_C.__BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_UISceneView_C.__BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UISceneView_C.__BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD6A RID: 122218 RVA: 0x009038B6 File Offset: 0x00901AB6
		[SkipLocalsInit]
		public virtual void CustomInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__CustomInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD6B RID: 122219 RVA: 0x009038CA File Offset: 0x00901ACA
		[SkipLocalsInit]
		public virtual void StopSceneView()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UISceneView_C.__StopSceneView_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD6C RID: 122220 RVA: 0x009038DE File Offset: 0x00901ADE
		protected BP_UISceneView_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBCF RID: 64463
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/UISceneView/BP_UISceneView.BP_UISceneView_C";

		// Token: 0x0400FBD0 RID: 64464
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBD1 RID: 64465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBD2 RID: 64466
		internal static int __PropertyOffset_Box;

		// Token: 0x0400FBD3 RID: 64467
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FBD4 RID: 64468
		internal static int __PropertyOffset_TimeLine_Alpha;

		// Token: 0x0400FBD5 RID: 64469
		internal static int __PropertyOffset_ScreenSpaceUIRoot;

		// Token: 0x0400FBD6 RID: 64470
		internal static int __PropertyOffset_RelativeLoc;

		// Token: 0x0400FBD7 RID: 64471
		internal static int __PropertyOffset_RelativeRoc;

		// Token: 0x0400FBD8 RID: 64472
		internal static int __PropertyOffset_Fov;

		// Token: 0x0400FBD9 RID: 64473
		internal static int __PropertyOffset_FadeInDuration;

		// Token: 0x0400FBDA RID: 64474
		internal static int __PropertyOffset_minAlpha;

		// Token: 0x0400FBDB RID: 64475
		internal static int __PropertyOffset_maxAlpha;

		// Token: 0x0400FBDC RID: 64476
		internal static int __PropertyOffset_isInit_;

		// Token: 0x0400FBDD RID: 64477
		internal static int __PropertyOffset_Show_Flag_Settings;

		// Token: 0x0400FBDE RID: 64478
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEngineShowFlagsSetting> _Show_Flag_Settings;

		// Token: 0x0400FBDF RID: 64479
		private static IntPtr __SetFov_NativeFunctionPtr;

		// Token: 0x0400FBE0 RID: 64480
		private static IntPtr __SetSceneViewMaterailSingleParameter_NativeFunctionPtr;

		// Token: 0x0400FBE1 RID: 64481
		private static IntPtr __SetSceneViewMaterialParams_NativeFunctionPtr;

		// Token: 0x0400FBE2 RID: 64482
		private static IntPtr __SetSceneViewMaterialParameters_NativeFunctionPtr;

		// Token: 0x0400FBE3 RID: 64483
		private static IntPtr __GetPlayer0CameraTransformWithOffset_NativeFunctionPtr;

		// Token: 0x0400FBE4 RID: 64484
		private static IntPtr __TimeLine_Alpha__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400FBE5 RID: 64485
		private static IntPtr __TimeLine_Alpha__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400FBE6 RID: 64486
		private static IntPtr __AppendSceneView_NativeFunctionPtr;

		// Token: 0x0400FBE7 RID: 64487
		private static IntPtr __InitCapture2DActor_NativeFunctionPtr;

		// Token: 0x0400FBE8 RID: 64488
		private static IntPtr __BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FBE9 RID: 64489
		private static IntPtr __CustomInit_NativeFunctionPtr;

		// Token: 0x0400FBEA RID: 64490
		private static IntPtr __StopSceneView_NativeFunctionPtr;

		// Token: 0x02008DBB RID: 36283
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetFov_FunctionParams
		{
			// Token: 0x0402C9A8 RID: 182696
			[FieldOffset(0)]
			public float Fov;
		}

		// Token: 0x02008DBC RID: 36284
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetSceneViewMaterailSingleParameter_FunctionParams
		{
			// Token: 0x0402C9A9 RID: 182697
			[FieldOffset(0)]
			public FString ParameterName;

			// Token: 0x0402C9AA RID: 182698
			[FieldOffset(16)]
			public float value;
		}

		// Token: 0x02008DBD RID: 36285
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSceneViewMaterialParams_FunctionParams
		{
			// Token: 0x0402C9AB RID: 182699
			[FieldOffset(0)]
			public float CenterOffsetX;

			// Token: 0x0402C9AC RID: 182700
			[FieldOffset(4)]
			public float CenterOffsetY;
		}

		// Token: 0x02008DBE RID: 36286
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetSceneViewMaterialParameters_FunctionParams
		{
			// Token: 0x0402C9AD RID: 182701
			[FieldOffset(0)]
			public float AlphaExp;

			// Token: 0x0402C9AE RID: 182702
			[FieldOffset(4)]
			public float AlphaPosition;

			// Token: 0x0402C9AF RID: 182703
			[FieldOffset(8)]
			public float CenterOffsetX;

			// Token: 0x0402C9B0 RID: 182704
			[FieldOffset(12)]
			public float CenterOffsetY;

			// Token: 0x0402C9B1 RID: 182705
			[FieldOffset(16)]
			public float FlowSpeed;

			// Token: 0x0402C9B2 RID: 182706
			[FieldOffset(20)]
			public float NoiseScale;
		}

		// Token: 0x02008DBF RID: 36287
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 336)]
		protected ref struct __GetPlayer0CameraTransformWithOffset_FunctionParams
		{
			// Token: 0x0402C9B3 RID: 182707
			[FieldOffset(0)]
			public FVectorDouble RelativeOffset;

			// Token: 0x0402C9B4 RID: 182708
			[FieldOffset(32)]
			public FTransformDouble Transform;
		}

		// Token: 0x02008DC0 RID: 36288
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __AppendSceneView_FunctionParams
		{
			// Token: 0x0402C9B5 RID: 182709
			[FieldOffset(0)]
			public IntPtr AttachActor;

			// Token: 0x0402C9B6 RID: 182710
			[FieldOffset(16)]
			public FTransformDouble Transform;
		}

		// Token: 0x02008DC1 RID: 36289
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_UISceneView_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402C9B7 RID: 182711
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402C9B8 RID: 182712
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402C9B9 RID: 182713
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402C9BA RID: 182714
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0402C9BB RID: 182715
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0402C9BC RID: 182716
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
