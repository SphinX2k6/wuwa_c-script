using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Gacha.Blueprint
{
	// Token: 0x020030A4 RID: 12452
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/Gacha/Blueprint/BP_GachaArt.BP_GachaArt_C")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1236)]
	public class BP_GachaArt_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DC28 RID: 121896 RVA: 0x009011CA File Offset: 0x008FF3CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GachaArt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Gacha/Blueprint/BP_GachaArt.BP_GachaArt_C");
			}
			return BP_GachaArt_C._ClassPtr;
		}

		// Token: 0x0601DC29 RID: 121897 RVA: 0x009011F0 File Offset: 0x008FF3F0
		public BP_GachaArt_C() : this(BuiltinUtils.AllocNativeUObject(BP_GachaArt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DC2A RID: 121898 RVA: 0x00901218 File Offset: 0x008FF418
		[NullableContext(1)]
		public BP_GachaArt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GachaArt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0601DC2B RID: 121899 RVA: 0x0090124B File Offset: 0x008FF44B
		// (set) Token: 0x0601DC2C RID: 121900 RVA: 0x0090125F File Offset: 0x008FF45F
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_04
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_04);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_04, value);
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0601DC2D RID: 121901 RVA: 0x00901274 File Offset: 0x008FF474
		// (set) Token: 0x0601DC2E RID: 121902 RVA: 0x00901288 File Offset: 0x008FF488
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_03
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_03);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_03, value);
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0601DC2F RID: 121903 RVA: 0x0090129D File Offset: 0x008FF49D
		// (set) Token: 0x0601DC30 RID: 121904 RVA: 0x009012B1 File Offset: 0x008FF4B1
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_01);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_01, value);
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0601DC31 RID: 121905 RVA: 0x009012C6 File Offset: 0x008FF4C6
		// (set) Token: 0x0601DC32 RID: 121906 RVA: 0x009012DA File Offset: 0x008FF4DA
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_02);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_NS_Fx_UI_Chouka_02, value);
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0601DC33 RID: 121907 RVA: 0x009012EF File Offset: 0x008FF4EF
		// (set) Token: 0x0601DC34 RID: 121908 RVA: 0x00901303 File Offset: 0x008FF503
		public unsafe UStaticMeshComponent BGPlane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_BGPlane);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_BGPlane, value);
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0601DC35 RID: 121909 RVA: 0x00901318 File Offset: 0x008FF518
		// (set) Token: 0x0601DC36 RID: 121910 RVA: 0x0090132C File Offset: 0x008FF52C
		public unsafe UStaticMeshComponent CenterDisk
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_CenterDisk);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_CenterDisk, value);
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0601DC37 RID: 121911 RVA: 0x00901341 File Offset: 0x008FF541
		// (set) Token: 0x0601DC38 RID: 121912 RVA: 0x00901355 File Offset: 0x008FF555
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0601DC39 RID: 121913 RVA: 0x0090136A File Offset: 0x008FF56A
		// (set) Token: 0x0601DC3A RID: 121914 RVA: 0x0090137E File Offset: 0x008FF57E
		public unsafe UMaterialInstanceDynamic CenterMaterialDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_CenterMaterialDynamic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_CenterMaterialDynamic, value);
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0601DC3B RID: 121915 RVA: 0x00901393 File Offset: 0x008FF593
		// (set) Token: 0x0601DC3C RID: 121916 RVA: 0x009013A3 File Offset: 0x008FF5A3
		public unsafe float DefaultProcessInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_DefaultProcessInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_DefaultProcessInput) = value;
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0601DC3D RID: 121917 RVA: 0x009013B4 File Offset: 0x008FF5B4
		// (set) Token: 0x0601DC3E RID: 121918 RVA: 0x009013C8 File Offset: 0x008FF5C8
		public unsafe FVector2D Mouse_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Mouse_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Mouse_Position) = value;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0601DC3F RID: 121919 RVA: 0x009013DD File Offset: 0x008FF5DD
		// (set) Token: 0x0601DC40 RID: 121920 RVA: 0x009013ED File Offset: 0x008FF5ED
		public unsafe float DefaultProcessFinal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_DefaultProcessFinal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_DefaultProcessFinal) = value;
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0601DC41 RID: 121921 RVA: 0x009013FE File Offset: 0x008FF5FE
		// (set) Token: 0x0601DC42 RID: 121922 RVA: 0x00901412 File Offset: 0x008FF612
		public unsafe FVector2D Screen_Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Screen_Resolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Screen_Resolution) = value;
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0601DC43 RID: 121923 RVA: 0x00901427 File Offset: 0x008FF627
		// (set) Token: 0x0601DC44 RID: 121924 RVA: 0x00901437 File Offset: 0x008FF637
		public unsafe float Camera_FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Camera_FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Camera_FOV) = value;
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0601DC45 RID: 121925 RVA: 0x00901448 File Offset: 0x008FF648
		// (set) Token: 0x0601DC46 RID: 121926 RVA: 0x00901458 File Offset: 0x008FF658
		public unsafe float ColorChangeProcessInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_ColorChangeProcessInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_ColorChangeProcessInput) = value;
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0601DC47 RID: 121927 RVA: 0x00901469 File Offset: 0x008FF669
		// (set) Token: 0x0601DC48 RID: 121928 RVA: 0x00901479 File Offset: 0x008FF679
		public unsafe float Camera_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Camera_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Camera_Length) = value;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0601DC49 RID: 121929 RVA: 0x0090148A File Offset: 0x008FF68A
		// (set) Token: 0x0601DC4A RID: 121930 RVA: 0x0090149E File Offset: 0x008FF69E
		public unsafe ACameraActor SceneCameraActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_SceneCameraActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_SceneCameraActor, value);
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0601DC4B RID: 121931 RVA: 0x009014B3 File Offset: 0x008FF6B3
		// (set) Token: 0x0601DC4C RID: 121932 RVA: 0x009014C7 File Offset: 0x008FF6C7
		public unsafe FRotator CameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_CameraRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_CameraRotation) = value;
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0601DC4D RID: 121933 RVA: 0x009014DC File Offset: 0x008FF6DC
		// (set) Token: 0x0601DC4E RID: 121934 RVA: 0x009014EC File Offset: 0x008FF6EC
		public unsafe float SidesAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_SidesAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_SidesAngle) = value;
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0601DC4F RID: 121935 RVA: 0x009014FD File Offset: 0x008FF6FD
		// (set) Token: 0x0601DC50 RID: 121936 RVA: 0x0090150D File Offset: 0x008FF70D
		public unsafe float BleedingDist_PixelNum_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_BleedingDist_PixelNum_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_BleedingDist_PixelNum_) = value;
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0601DC51 RID: 121937 RVA: 0x0090151E File Offset: 0x008FF71E
		// (set) Token: 0x0601DC52 RID: 121938 RVA: 0x0090152E File Offset: 0x008FF72E
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Debug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Debug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0601DC53 RID: 121939 RVA: 0x0090153F File Offset: 0x008FF73F
		// (set) Token: 0x0601DC54 RID: 121940 RVA: 0x0090154F File Offset: 0x008FF74F
		public unsafe float MousePositionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_MousePositionX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_MousePositionX) = value;
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0601DC55 RID: 121941 RVA: 0x00901560 File Offset: 0x008FF760
		// (set) Token: 0x0601DC56 RID: 121942 RVA: 0x00901570 File Offset: 0x008FF770
		public unsafe float MousePositionXFinal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_MousePositionXFinal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_MousePositionXFinal) = value;
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0601DC57 RID: 121943 RVA: 0x00901581 File Offset: 0x008FF781
		// (set) Token: 0x0601DC58 RID: 121944 RVA: 0x00901591 File Offset: 0x008FF791
		public unsafe float Process
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Process);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Process) = value;
			}
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0601DC59 RID: 121945 RVA: 0x009015A2 File Offset: 0x008FF7A2
		// (set) Token: 0x0601DC5A RID: 121946 RVA: 0x009015B2 File Offset: 0x008FF7B2
		public unsafe float CCProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_CCProcess);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_CCProcess) = value;
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0601DC5B RID: 121947 RVA: 0x009015C3 File Offset: 0x008FF7C3
		// (set) Token: 0x0601DC5C RID: 121948 RVA: 0x009015D3 File Offset: 0x008FF7D3
		public unsafe bool Hidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Hidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Hidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0601DC5D RID: 121949 RVA: 0x009015E4 File Offset: 0x008FF7E4
		// (set) Token: 0x0601DC5E RID: 121950 RVA: 0x009015F8 File Offset: 0x008FF7F8
		public unsafe FLinearColor Award_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Award_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Award_Color) = value;
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0601DC5F RID: 121951 RVA: 0x0090160D File Offset: 0x008FF80D
		// (set) Token: 0x0601DC60 RID: 121952 RVA: 0x00901621 File Offset: 0x008FF821
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResult> Gacha_Result
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Gacha_Result);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_Gacha_Result) = value;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0601DC61 RID: 121953 RVA: 0x00901636 File Offset: 0x008FF836
		// (set) Token: 0x0601DC62 RID: 121954 RVA: 0x00901646 File Offset: 0x008FF846
		public unsafe float ProcessTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_ProcessTemp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_ProcessTemp) = value;
			}
		}

		// Token: 0x0601DC63 RID: 121955 RVA: 0x00901657 File Offset: 0x008FF857
		[SkipLocalsInit]
		public virtual void UpdateAudio()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateAudio_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC64 RID: 121956 RVA: 0x0090166C File Offset: 0x008FF86C
		[SkipLocalsInit]
		public unsafe virtual void TSInitParameters(FVector2D ScreenResolution, float BleedingDistance, FLinearColor AwardColor, E_GachaResult GachaResult)
		{
			BP_GachaArt_C.__TSInitParameters_FunctionParams* ptr = stackalloc BP_GachaArt_C.__TSInitParameters_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GachaArt_C.__TSInitParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__TSInitParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScreenResolution = ScreenResolution;
			ptr->BleedingDistance = BleedingDistance;
			ptr->AwardColor = AwardColor;
			ptr->GachaResult = GachaResult;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__TSInitParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DC65 RID: 121957 RVA: 0x009016CD File Offset: 0x008FF8CD
		[SkipLocalsInit]
		public virtual void PreUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__PreUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC66 RID: 121958 RVA: 0x009016E1 File Offset: 0x008FF8E1
		[SkipLocalsInit]
		public virtual void UpdateDebugParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateDebugParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC67 RID: 121959 RVA: 0x009016F8 File Offset: 0x008FF8F8
		[SkipLocalsInit]
		public unsafe virtual void TSUpdateParameters(float DefaultProcess, float ColorChangeProcess, FVector2D MousePosition)
		{
			BP_GachaArt_C.__TSUpdateParameters_FunctionParams* ptr = stackalloc BP_GachaArt_C.__TSUpdateParameters_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GachaArt_C.__TSUpdateParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__TSUpdateParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DefaultProcess = DefaultProcess;
			ptr->ColorChangeProcess = ColorChangeProcess;
			ptr->MousePosition = MousePosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__TSUpdateParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DC68 RID: 121960 RVA: 0x0090174C File Offset: 0x008FF94C
		[SkipLocalsInit]
		public virtual void UpdateCamera()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateCamera_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC69 RID: 121961 RVA: 0x00901760 File Offset: 0x008FF960
		[SkipLocalsInit]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC6A RID: 121962 RVA: 0x00901774 File Offset: 0x008FF974
		[SkipLocalsInit]
		public virtual void UpdateParticlePosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateParticlePosition_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC6B RID: 121963 RVA: 0x00901788 File Offset: 0x008FF988
		[SkipLocalsInit]
		public virtual void UpdateParticleParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateParticleParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC6C RID: 121964 RVA: 0x0090179C File Offset: 0x008FF99C
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC6D RID: 121965 RVA: 0x009017B0 File Offset: 0x008FF9B0
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaArt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC6E RID: 121966 RVA: 0x009017C4 File Offset: 0x008FF9C4
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC6F RID: 121967 RVA: 0x009017D8 File Offset: 0x008FF9D8
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DC70 RID: 121968 RVA: 0x009017EC File Offset: 0x008FF9EC
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GachaArt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaArt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaArt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DC71 RID: 121969 RVA: 0x00901834 File Offset: 0x008FFA34
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GachaArt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaArt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaArt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DC72 RID: 121970 RVA: 0x0090187A File Offset: 0x008FFA7A
		protected BP_GachaArt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB1D RID: 64285
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/Gacha/Blueprint/BP_GachaArt.BP_GachaArt_C";

		// Token: 0x0400FB1E RID: 64286
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB1F RID: 64287
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB20 RID: 64288
		internal static int __PropertyOffset_NS_Fx_UI_Chouka_04;

		// Token: 0x0400FB21 RID: 64289
		internal static int __PropertyOffset_NS_Fx_UI_Chouka_03;

		// Token: 0x0400FB22 RID: 64290
		internal static int __PropertyOffset_NS_Fx_UI_Chouka_01;

		// Token: 0x0400FB23 RID: 64291
		internal static int __PropertyOffset_NS_Fx_UI_Chouka_02;

		// Token: 0x0400FB24 RID: 64292
		internal static int __PropertyOffset_BGPlane;

		// Token: 0x0400FB25 RID: 64293
		internal static int __PropertyOffset_CenterDisk;

		// Token: 0x0400FB26 RID: 64294
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FB27 RID: 64295
		internal static int __PropertyOffset_CenterMaterialDynamic;

		// Token: 0x0400FB28 RID: 64296
		internal static int __PropertyOffset_DefaultProcessInput;

		// Token: 0x0400FB29 RID: 64297
		internal static int __PropertyOffset_Mouse_Position;

		// Token: 0x0400FB2A RID: 64298
		internal static int __PropertyOffset_DefaultProcessFinal;

		// Token: 0x0400FB2B RID: 64299
		internal static int __PropertyOffset_Screen_Resolution;

		// Token: 0x0400FB2C RID: 64300
		internal static int __PropertyOffset_Camera_FOV;

		// Token: 0x0400FB2D RID: 64301
		internal static int __PropertyOffset_ColorChangeProcessInput;

		// Token: 0x0400FB2E RID: 64302
		internal static int __PropertyOffset_Camera_Length;

		// Token: 0x0400FB2F RID: 64303
		internal static int __PropertyOffset_SceneCameraActor;

		// Token: 0x0400FB30 RID: 64304
		internal static int __PropertyOffset_CameraRotation;

		// Token: 0x0400FB31 RID: 64305
		internal static int __PropertyOffset_SidesAngle;

		// Token: 0x0400FB32 RID: 64306
		internal static int __PropertyOffset_BleedingDist_PixelNum_;

		// Token: 0x0400FB33 RID: 64307
		internal static int __PropertyOffset_Debug;

		// Token: 0x0400FB34 RID: 64308
		internal static int __PropertyOffset_MousePositionX;

		// Token: 0x0400FB35 RID: 64309
		internal static int __PropertyOffset_MousePositionXFinal;

		// Token: 0x0400FB36 RID: 64310
		internal static int __PropertyOffset_Process;

		// Token: 0x0400FB37 RID: 64311
		internal static int __PropertyOffset_CCProcess;

		// Token: 0x0400FB38 RID: 64312
		internal static int __PropertyOffset_Hidden;

		// Token: 0x0400FB39 RID: 64313
		internal static int __PropertyOffset_Award_Color;

		// Token: 0x0400FB3A RID: 64314
		internal static int __PropertyOffset_Gacha_Result;

		// Token: 0x0400FB3B RID: 64315
		internal static int __PropertyOffset_ProcessTemp;

		// Token: 0x0400FB3C RID: 64316
		private static IntPtr __UpdateAudio_NativeFunctionPtr;

		// Token: 0x0400FB3D RID: 64317
		private static IntPtr __TSInitParameters_NativeFunctionPtr;

		// Token: 0x0400FB3E RID: 64318
		private static IntPtr __PreUpdate_NativeFunctionPtr;

		// Token: 0x0400FB3F RID: 64319
		private static IntPtr __UpdateDebugParameters_NativeFunctionPtr;

		// Token: 0x0400FB40 RID: 64320
		private static IntPtr __TSUpdateParameters_NativeFunctionPtr;

		// Token: 0x0400FB41 RID: 64321
		private static IntPtr __UpdateCamera_NativeFunctionPtr;

		// Token: 0x0400FB42 RID: 64322
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400FB43 RID: 64323
		private static IntPtr __UpdateParticlePosition_NativeFunctionPtr;

		// Token: 0x0400FB44 RID: 64324
		private static IntPtr __UpdateParticleParameters_NativeFunctionPtr;

		// Token: 0x0400FB45 RID: 64325
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FB46 RID: 64326
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FB47 RID: 64327
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008D9D RID: 36253
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TSInitParameters_FunctionParams
		{
			// Token: 0x0402C954 RID: 182612
			[FieldOffset(0)]
			public FVector2D ScreenResolution;

			// Token: 0x0402C955 RID: 182613
			[FieldOffset(8)]
			public float BleedingDistance;

			// Token: 0x0402C956 RID: 182614
			[FieldOffset(12)]
			public FLinearColor AwardColor;

			// Token: 0x0402C957 RID: 182615
			[FieldOffset(28)]
			public TEnumAsByte<E_GachaResult> GachaResult;
		}

		// Token: 0x02008D9E RID: 36254
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TSUpdateParameters_FunctionParams
		{
			// Token: 0x0402C958 RID: 182616
			[FieldOffset(0)]
			public float DefaultProcess;

			// Token: 0x0402C959 RID: 182617
			[FieldOffset(4)]
			public float ColorChangeProcess;

			// Token: 0x0402C95A RID: 182618
			[FieldOffset(8)]
			public FVector2D MousePosition;
		}

		// Token: 0x02008D9F RID: 36255
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C95B RID: 182619
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
