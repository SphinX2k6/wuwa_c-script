using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Gacha.Blueprint
{
	// Token: 0x02003A67 RID: 14951
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/Gacha/Blueprint/BP_GachaArt.BP_GachaArt_C")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1236)]
	public class BP_GachaArt_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F94C RID: 129356 RVA: 0x008BC7E8 File Offset: 0x008BA9E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GachaArt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Gacha/Blueprint/BP_GachaArt.BP_GachaArt_C");
			}
			return BP_GachaArt_C._ClassPtr;
		}

		// Token: 0x0601F94D RID: 129357 RVA: 0x008BC80C File Offset: 0x008BAA0C
		public BP_GachaArt_C() : this(BuiltinUtils.AllocNativeUObject(BP_GachaArt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F94E RID: 129358 RVA: 0x008BC834 File Offset: 0x008BAA34
		[NullableContext(1)]
		public BP_GachaArt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GachaArt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0601F94F RID: 129359 RVA: 0x008BC867 File Offset: 0x008BAA67
		// (set) Token: 0x0601F950 RID: 129360 RVA: 0x008BC87B File Offset: 0x008BAA7B
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_04
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0601F951 RID: 129361 RVA: 0x008BC890 File Offset: 0x008BAA90
		// (set) Token: 0x0601F952 RID: 129362 RVA: 0x008BC8A4 File Offset: 0x008BAAA4
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_03
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0601F953 RID: 129363 RVA: 0x008BC8B9 File Offset: 0x008BAAB9
		// (set) Token: 0x0601F954 RID: 129364 RVA: 0x008BC8CD File Offset: 0x008BAACD
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0601F955 RID: 129365 RVA: 0x008BC8E2 File Offset: 0x008BAAE2
		// (set) Token: 0x0601F956 RID: 129366 RVA: 0x008BC8F6 File Offset: 0x008BAAF6
		public unsafe UNiagaraComponent NS_Fx_UI_Chouka_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0601F957 RID: 129367 RVA: 0x008BC90B File Offset: 0x008BAB0B
		// (set) Token: 0x0601F958 RID: 129368 RVA: 0x008BC91F File Offset: 0x008BAB1F
		public unsafe UStaticMeshComponent BGPlane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0601F959 RID: 129369 RVA: 0x008BC934 File Offset: 0x008BAB34
		// (set) Token: 0x0601F95A RID: 129370 RVA: 0x008BC948 File Offset: 0x008BAB48
		public unsafe UStaticMeshComponent CenterDisk
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0601F95B RID: 129371 RVA: 0x008BC95D File Offset: 0x008BAB5D
		// (set) Token: 0x0601F95C RID: 129372 RVA: 0x008BC971 File Offset: 0x008BAB71
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0601F95D RID: 129373 RVA: 0x008BC986 File Offset: 0x008BAB86
		// (set) Token: 0x0601F95E RID: 129374 RVA: 0x008BC99A File Offset: 0x008BAB9A
		public unsafe UMaterialInstanceDynamic CenterMaterialDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0601F95F RID: 129375 RVA: 0x008BC9AF File Offset: 0x008BABAF
		// (set) Token: 0x0601F960 RID: 129376 RVA: 0x008BC9BF File Offset: 0x008BABBF
		public unsafe float DefaultProcessInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0601F961 RID: 129377 RVA: 0x008BC9D0 File Offset: 0x008BABD0
		// (set) Token: 0x0601F962 RID: 129378 RVA: 0x008BC9E4 File Offset: 0x008BABE4
		public unsafe FVector2D Mouse_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0601F963 RID: 129379 RVA: 0x008BC9F9 File Offset: 0x008BABF9
		// (set) Token: 0x0601F964 RID: 129380 RVA: 0x008BCA09 File Offset: 0x008BAC09
		public unsafe float DefaultProcessFinal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0601F965 RID: 129381 RVA: 0x008BCA1A File Offset: 0x008BAC1A
		// (set) Token: 0x0601F966 RID: 129382 RVA: 0x008BCA2E File Offset: 0x008BAC2E
		public unsafe FVector2D Screen_Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0601F967 RID: 129383 RVA: 0x008BCA43 File Offset: 0x008BAC43
		// (set) Token: 0x0601F968 RID: 129384 RVA: 0x008BCA53 File Offset: 0x008BAC53
		public unsafe float Camera_FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0601F969 RID: 129385 RVA: 0x008BCA64 File Offset: 0x008BAC64
		// (set) Token: 0x0601F96A RID: 129386 RVA: 0x008BCA74 File Offset: 0x008BAC74
		public unsafe float ColorChangeProcessInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0601F96B RID: 129387 RVA: 0x008BCA85 File Offset: 0x008BAC85
		// (set) Token: 0x0601F96C RID: 129388 RVA: 0x008BCA95 File Offset: 0x008BAC95
		public unsafe float Camera_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0601F96D RID: 129389 RVA: 0x008BCAA6 File Offset: 0x008BACA6
		// (set) Token: 0x0601F96E RID: 129390 RVA: 0x008BCABA File Offset: 0x008BACBA
		public unsafe ACameraActor SceneCameraActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaArt_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0601F96F RID: 129391 RVA: 0x008BCACF File Offset: 0x008BACCF
		// (set) Token: 0x0601F970 RID: 129392 RVA: 0x008BCAE3 File Offset: 0x008BACE3
		public unsafe FRotator CameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0601F971 RID: 129393 RVA: 0x008BCAF8 File Offset: 0x008BACF8
		// (set) Token: 0x0601F972 RID: 129394 RVA: 0x008BCB08 File Offset: 0x008BAD08
		public unsafe float SidesAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x0601F973 RID: 129395 RVA: 0x008BCB19 File Offset: 0x008BAD19
		// (set) Token: 0x0601F974 RID: 129396 RVA: 0x008BCB29 File Offset: 0x008BAD29
		public unsafe float BleedingDist_PixelNum_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0601F975 RID: 129397 RVA: 0x008BCB3A File Offset: 0x008BAD3A
		// (set) Token: 0x0601F976 RID: 129398 RVA: 0x008BCB4A File Offset: 0x008BAD4A
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0601F977 RID: 129399 RVA: 0x008BCB5B File Offset: 0x008BAD5B
		// (set) Token: 0x0601F978 RID: 129400 RVA: 0x008BCB6B File Offset: 0x008BAD6B
		public unsafe float MousePositionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0601F979 RID: 129401 RVA: 0x008BCB7C File Offset: 0x008BAD7C
		// (set) Token: 0x0601F97A RID: 129402 RVA: 0x008BCB8C File Offset: 0x008BAD8C
		public unsafe float MousePositionXFinal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0601F97B RID: 129403 RVA: 0x008BCB9D File Offset: 0x008BAD9D
		// (set) Token: 0x0601F97C RID: 129404 RVA: 0x008BCBAD File Offset: 0x008BADAD
		public unsafe float Process
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x0601F97D RID: 129405 RVA: 0x008BCBBE File Offset: 0x008BADBE
		// (set) Token: 0x0601F97E RID: 129406 RVA: 0x008BCBCE File Offset: 0x008BADCE
		public unsafe float CCProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0601F97F RID: 129407 RVA: 0x008BCBDF File Offset: 0x008BADDF
		// (set) Token: 0x0601F980 RID: 129408 RVA: 0x008BCBEF File Offset: 0x008BADEF
		public unsafe bool Hidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0601F981 RID: 129409 RVA: 0x008BCC00 File Offset: 0x008BAE00
		// (set) Token: 0x0601F982 RID: 129410 RVA: 0x008BCC14 File Offset: 0x008BAE14
		public unsafe FLinearColor Award_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0601F983 RID: 129411 RVA: 0x008BCC29 File Offset: 0x008BAE29
		// (set) Token: 0x0601F984 RID: 129412 RVA: 0x008BCC3D File Offset: 0x008BAE3D
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResult> Gacha_Result
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_27);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0601F985 RID: 129413 RVA: 0x008BCC52 File Offset: 0x008BAE52
		// (set) Token: 0x0601F986 RID: 129414 RVA: 0x008BCC62 File Offset: 0x008BAE62
		public unsafe float ProcessTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaArt_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x0601F987 RID: 129415 RVA: 0x008BCC73 File Offset: 0x008BAE73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateAudio()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateAudio_NativeFunctionPtr, null);
		}

		// Token: 0x0601F988 RID: 129416 RVA: 0x008BCC88 File Offset: 0x008BAE88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F989 RID: 129417 RVA: 0x008BCCE9 File Offset: 0x008BAEE9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PreUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__PreUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x0601F98A RID: 129418 RVA: 0x008BCCFD File Offset: 0x008BAEFD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDebugParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateDebugParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601F98B RID: 129419 RVA: 0x008BCD14 File Offset: 0x008BAF14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TSUpdateParameters(float DefaultProcess, float ColorChangeProcess, FVector2D MousePosition)
		{
			BP_GachaArt_C.__TSUpdateParameters_FunctionParams* ptr = stackalloc BP_GachaArt_C.__TSUpdateParameters_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GachaArt_C.__TSUpdateParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__TSUpdateParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DefaultProcess = DefaultProcess;
			ptr->ColorChangeProcess = ColorChangeProcess;
			ptr->MousePosition = MousePosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__TSUpdateParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F98C RID: 129420 RVA: 0x008BCD68 File Offset: 0x008BAF68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCamera()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateCamera_NativeFunctionPtr, null);
		}

		// Token: 0x0601F98D RID: 129421 RVA: 0x008BCD7C File Offset: 0x008BAF7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0601F98E RID: 129422 RVA: 0x008BCD90 File Offset: 0x008BAF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParticlePosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateParticlePosition_NativeFunctionPtr, null);
		}

		// Token: 0x0601F98F RID: 129423 RVA: 0x008BCDA4 File Offset: 0x008BAFA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParticleParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UpdateParticleParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601F990 RID: 129424 RVA: 0x008BCDB8 File Offset: 0x008BAFB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F991 RID: 129425 RVA: 0x008BCDCC File Offset: 0x008BAFCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaArt_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F992 RID: 129426 RVA: 0x008BCDE1 File Offset: 0x008BAFE1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F993 RID: 129427 RVA: 0x008BCDF5 File Offset: 0x008BAFF5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F994 RID: 129428 RVA: 0x008BCE0C File Offset: 0x008BB00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GachaArt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaArt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaArt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x008BCE54 File Offset: 0x008BB054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GachaArt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaArt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaArt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaArt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F996 RID: 129430 RVA: 0x008BCE9B File Offset: 0x008BB09B
		protected BP_GachaArt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F2F3 RID: 62195
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/Gacha/Blueprint/BP_GachaArt.BP_GachaArt_C";

		// Token: 0x0400F2F4 RID: 62196
		private static IntPtr _ClassPtr;

		// Token: 0x0400F2F5 RID: 62197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F2F6 RID: 62198
		internal static int __PropertyOffset_1;

		// Token: 0x0400F2F7 RID: 62199
		internal static int __PropertyOffset_2;

		// Token: 0x0400F2F8 RID: 62200
		internal static int __PropertyOffset_3;

		// Token: 0x0400F2F9 RID: 62201
		internal static int __PropertyOffset_4;

		// Token: 0x0400F2FA RID: 62202
		internal static int __PropertyOffset_5;

		// Token: 0x0400F2FB RID: 62203
		internal static int __PropertyOffset_6;

		// Token: 0x0400F2FC RID: 62204
		internal static int __PropertyOffset_7;

		// Token: 0x0400F2FD RID: 62205
		internal static int __PropertyOffset_8;

		// Token: 0x0400F2FE RID: 62206
		internal static int __PropertyOffset_9;

		// Token: 0x0400F2FF RID: 62207
		internal static int __PropertyOffset_10;

		// Token: 0x0400F300 RID: 62208
		internal static int __PropertyOffset_11;

		// Token: 0x0400F301 RID: 62209
		internal static int __PropertyOffset_12;

		// Token: 0x0400F302 RID: 62210
		internal static int __PropertyOffset_13;

		// Token: 0x0400F303 RID: 62211
		internal static int __PropertyOffset_14;

		// Token: 0x0400F304 RID: 62212
		internal static int __PropertyOffset_15;

		// Token: 0x0400F305 RID: 62213
		internal static int __PropertyOffset_16;

		// Token: 0x0400F306 RID: 62214
		internal static int __PropertyOffset_17;

		// Token: 0x0400F307 RID: 62215
		internal static int __PropertyOffset_18;

		// Token: 0x0400F308 RID: 62216
		internal static int __PropertyOffset_19;

		// Token: 0x0400F309 RID: 62217
		internal static int __PropertyOffset_20;

		// Token: 0x0400F30A RID: 62218
		internal static int __PropertyOffset_21;

		// Token: 0x0400F30B RID: 62219
		internal static int __PropertyOffset_22;

		// Token: 0x0400F30C RID: 62220
		internal static int __PropertyOffset_23;

		// Token: 0x0400F30D RID: 62221
		internal static int __PropertyOffset_24;

		// Token: 0x0400F30E RID: 62222
		internal static int __PropertyOffset_25;

		// Token: 0x0400F30F RID: 62223
		internal static int __PropertyOffset_26;

		// Token: 0x0400F310 RID: 62224
		internal static int __PropertyOffset_27;

		// Token: 0x0400F311 RID: 62225
		internal static int __PropertyOffset_28;

		// Token: 0x0400F312 RID: 62226
		private static IntPtr __UpdateAudio_NativeFunctionPtr;

		// Token: 0x0400F313 RID: 62227
		private static IntPtr __TSInitParameters_NativeFunctionPtr;

		// Token: 0x0400F314 RID: 62228
		private static IntPtr __PreUpdate_NativeFunctionPtr;

		// Token: 0x0400F315 RID: 62229
		private static IntPtr __UpdateDebugParameters_NativeFunctionPtr;

		// Token: 0x0400F316 RID: 62230
		private static IntPtr __TSUpdateParameters_NativeFunctionPtr;

		// Token: 0x0400F317 RID: 62231
		private static IntPtr __UpdateCamera_NativeFunctionPtr;

		// Token: 0x0400F318 RID: 62232
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400F319 RID: 62233
		private static IntPtr __UpdateParticlePosition_NativeFunctionPtr;

		// Token: 0x0400F31A RID: 62234
		private static IntPtr __UpdateParticleParameters_NativeFunctionPtr;

		// Token: 0x0400F31B RID: 62235
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F31C RID: 62236
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F31D RID: 62237
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B0E RID: 39694
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TSInitParameters_FunctionParams
		{
			// Token: 0x040310E1 RID: 200929
			[FieldOffset(0)]
			public FVector2D ScreenResolution;

			// Token: 0x040310E2 RID: 200930
			[FieldOffset(8)]
			public float BleedingDistance;

			// Token: 0x040310E3 RID: 200931
			[FieldOffset(12)]
			public FLinearColor AwardColor;

			// Token: 0x040310E4 RID: 200932
			[FieldOffset(28)]
			public TEnumAsByte<E_GachaResult> GachaResult;
		}

		// Token: 0x02009B0F RID: 39695
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TSUpdateParameters_FunctionParams
		{
			// Token: 0x040310E5 RID: 200933
			[FieldOffset(0)]
			public float DefaultProcess;

			// Token: 0x040310E6 RID: 200934
			[FieldOffset(4)]
			public float ColorChangeProcess;

			// Token: 0x040310E7 RID: 200935
			[FieldOffset(8)]
			public FVector2D MousePosition;
		}

		// Token: 0x02009B10 RID: 39696
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040310E8 RID: 200936
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
