using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.CloudTraceTail;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud
{
	// Token: 0x02003C79 RID: 15481
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/BP_KuroTraceCloud.BP_KuroTraceCloud_C")]
	[UnrealStructLayout(1416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1416)]
	public class BP_KuroTraceCloud_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FD1 RID: 147409 RVA: 0x009323C7 File Offset: 0x009305C7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroTraceCloud_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/BP_KuroTraceCloud.BP_KuroTraceCloud_C");
			}
			return BP_KuroTraceCloud_C._ClassPtr;
		}

		// Token: 0x06023FD2 RID: 147410 RVA: 0x009323EC File Offset: 0x009305EC
		public BP_KuroTraceCloud_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroTraceCloud_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FD3 RID: 147411 RVA: 0x00932414 File Offset: 0x00930614
		[NullableContext(1)]
		public BP_KuroTraceCloud_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroTraceCloud_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x06023FD4 RID: 147412 RVA: 0x00932447 File Offset: 0x00930647
		// (set) Token: 0x06023FD5 RID: 147413 RVA: 0x0093245B File Offset: 0x0093065B
		public unsafe BPC_VolumeCloudTrail_C BPC_VolumeCloudTrail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BPC_VolumeCloudTrail_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x06023FD6 RID: 147414 RVA: 0x00932470 File Offset: 0x00930670
		// (set) Token: 0x06023FD7 RID: 147415 RVA: 0x00932484 File Offset: 0x00930684
		public unsafe USceneComponent FadeRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x06023FD8 RID: 147416 RVA: 0x00932499 File Offset: 0x00930699
		// (set) Token: 0x06023FD9 RID: 147417 RVA: 0x009324AD File Offset: 0x009306AD
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004499 RID: 17561
		// (get) Token: 0x06023FDA RID: 147418 RVA: 0x009324C2 File Offset: 0x009306C2
		// (set) Token: 0x06023FDB RID: 147419 RVA: 0x009324D6 File Offset: 0x009306D6
		public unsafe USceneComponent CloudRange
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700449A RID: 17562
		// (get) Token: 0x06023FDC RID: 147420 RVA: 0x009324EB File Offset: 0x009306EB
		// (set) Token: 0x06023FDD RID: 147421 RVA: 0x009324FF File Offset: 0x009306FF
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700449B RID: 17563
		// (get) Token: 0x06023FDE RID: 147422 RVA: 0x00932514 File Offset: 0x00930714
		// (set) Token: 0x06023FDF RID: 147423 RVA: 0x00932524 File Offset: 0x00930724
		public unsafe float CloudLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700449C RID: 17564
		// (get) Token: 0x06023FE0 RID: 147424 RVA: 0x00932535 File Offset: 0x00930735
		// (set) Token: 0x06023FE1 RID: 147425 RVA: 0x00932545 File Offset: 0x00930745
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700449D RID: 17565
		// (get) Token: 0x06023FE2 RID: 147426 RVA: 0x00932558 File Offset: 0x00930758
		// (set) Token: 0x06023FE3 RID: 147427 RVA: 0x00932591 File Offset: 0x00930791
		[Nullable(1)]
		public TArray<SD_KuroTraceCloudData> Data
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SD_KuroTraceCloudData> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<SD_KuroTraceCloudData>(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x1700449E RID: 17566
		// (get) Token: 0x06023FE4 RID: 147428 RVA: 0x009325A0 File Offset: 0x009307A0
		// (set) Token: 0x06023FE5 RID: 147429 RVA: 0x009325D9 File Offset: 0x009307D9
		[Nullable(1)]
		public SD_KuroTraceCloudData LerpData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SD_KuroTraceCloudData result;
				if ((result = this._LerpData) == null)
				{
					result = (this._LerpData = new SD_KuroTraceCloudData(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SD_KuroTraceCloudData.StaticStruct(), base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700449F RID: 17567
		// (get) Token: 0x06023FE6 RID: 147430 RVA: 0x009325FA File Offset: 0x009307FA
		// (set) Token: 0x06023FE7 RID: 147431 RVA: 0x0093260A File Offset: 0x0093080A
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x06023FE8 RID: 147432 RVA: 0x0093261B File Offset: 0x0093081B
		// (set) Token: 0x06023FE9 RID: 147433 RVA: 0x0093262F File Offset: 0x0093082F
		public unsafe UMaterialInstanceConstant HighCloudMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x06023FEA RID: 147434 RVA: 0x00932644 File Offset: 0x00930844
		// (set) Token: 0x06023FEB RID: 147435 RVA: 0x00932654 File Offset: 0x00930854
		public unsafe float FadeHeightPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x06023FEC RID: 147436 RVA: 0x00932665 File Offset: 0x00930865
		// (set) Token: 0x06023FED RID: 147437 RVA: 0x00932675 File Offset: 0x00930875
		public unsafe bool bDrawFadeBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x06023FEE RID: 147438 RVA: 0x00932686 File Offset: 0x00930886
		// (set) Token: 0x06023FEF RID: 147439 RVA: 0x0093269A File Offset: 0x0093089A
		public unsafe UMaterialInstanceConstant PlaneMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x06023FF0 RID: 147440 RVA: 0x009326AF File Offset: 0x009308AF
		// (set) Token: 0x06023FF1 RID: 147441 RVA: 0x009326C3 File Offset: 0x009308C3
		public unsafe AActor boundActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x06023FF2 RID: 147442 RVA: 0x009326D8 File Offset: 0x009308D8
		// (set) Token: 0x06023FF3 RID: 147443 RVA: 0x009326EC File Offset: 0x009308EC
		public unsafe AStaticMeshActor bottomPlane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x06023FF4 RID: 147444 RVA: 0x00932701 File Offset: 0x00930901
		// (set) Token: 0x06023FF5 RID: 147445 RVA: 0x00932715 File Offset: 0x00930915
		public unsafe FLinearColor LocalLightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x06023FF6 RID: 147446 RVA: 0x0093272A File Offset: 0x0093092A
		// (set) Token: 0x06023FF7 RID: 147447 RVA: 0x0093273E File Offset: 0x0093093E
		public unsafe FLinearColor LocalLightPos2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x06023FF8 RID: 147448 RVA: 0x00932753 File Offset: 0x00930953
		// (set) Token: 0x06023FF9 RID: 147449 RVA: 0x00932767 File Offset: 0x00930967
		public unsafe FLinearColor LocalLightPos3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x06023FFA RID: 147450 RVA: 0x0093277C File Offset: 0x0093097C
		// (set) Token: 0x06023FFB RID: 147451 RVA: 0x00932790 File Offset: 0x00930990
		public unsafe FLinearColor LocalLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x06023FFC RID: 147452 RVA: 0x009327A5 File Offset: 0x009309A5
		// (set) Token: 0x06023FFD RID: 147453 RVA: 0x009327B9 File Offset: 0x009309B9
		public unsafe FLinearColor LocalLightColor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x06023FFE RID: 147454 RVA: 0x009327CE File Offset: 0x009309CE
		// (set) Token: 0x06023FFF RID: 147455 RVA: 0x009327E2 File Offset: 0x009309E2
		public unsafe FLinearColor LocalLightColor3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x06024000 RID: 147456 RVA: 0x009327F7 File Offset: 0x009309F7
		// (set) Token: 0x06024001 RID: 147457 RVA: 0x0093280B File Offset: 0x00930A0B
		public unsafe FLinearColor TempLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x06024002 RID: 147458 RVA: 0x00932820 File Offset: 0x00930A20
		// (set) Token: 0x06024003 RID: 147459 RVA: 0x00932834 File Offset: 0x00930A34
		public unsafe FLinearColor TempLightColor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x06024004 RID: 147460 RVA: 0x00932849 File Offset: 0x00930A49
		// (set) Token: 0x06024005 RID: 147461 RVA: 0x0093285D File Offset: 0x00930A5D
		public unsafe FLinearColor TempLightColor3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x06024006 RID: 147462 RVA: 0x00932872 File Offset: 0x00930A72
		// (set) Token: 0x06024007 RID: 147463 RVA: 0x00932882 File Offset: 0x00930A82
		public unsafe float LightAttenuationC1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x06024008 RID: 147464 RVA: 0x00932893 File Offset: 0x00930A93
		// (set) Token: 0x06024009 RID: 147465 RVA: 0x009328A3 File Offset: 0x00930AA3
		public unsafe float LightAttenuationC2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x0602400A RID: 147466 RVA: 0x009328B4 File Offset: 0x00930AB4
		// (set) Token: 0x0602400B RID: 147467 RVA: 0x009328C8 File Offset: 0x00930AC8
		public unsafe AActor lightPosProxy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x0602400C RID: 147468 RVA: 0x009328DD File Offset: 0x00930ADD
		// (set) Token: 0x0602400D RID: 147469 RVA: 0x009328F1 File Offset: 0x00930AF1
		public unsafe AActor lightPosProxy2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x0602400E RID: 147470 RVA: 0x00932906 File Offset: 0x00930B06
		// (set) Token: 0x0602400F RID: 147471 RVA: 0x0093291A File Offset: 0x00930B1A
		public unsafe AActor lightPosProxy3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x06024010 RID: 147472 RVA: 0x0093292F File Offset: 0x00930B2F
		// (set) Token: 0x06024011 RID: 147473 RVA: 0x00932943 File Offset: 0x00930B43
		public unsafe FVector RadialMaskPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x06024012 RID: 147474 RVA: 0x00932958 File Offset: 0x00930B58
		// (set) Token: 0x06024013 RID: 147475 RVA: 0x00932968 File Offset: 0x00930B68
		public unsafe float RadialMaskRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x06024014 RID: 147476 RVA: 0x00932979 File Offset: 0x00930B79
		// (set) Token: 0x06024015 RID: 147477 RVA: 0x0093298D File Offset: 0x00930B8D
		public unsafe FVector FadeBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x06024016 RID: 147478 RVA: 0x009329A2 File Offset: 0x00930BA2
		// (set) Token: 0x06024017 RID: 147479 RVA: 0x009329B2 File Offset: 0x00930BB2
		public unsafe BP_EWorldType NewVar_0
		{
			get
			{
				return (BP_EWorldType)(*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_34));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_34) = (byte)value;
			}
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x06024018 RID: 147480 RVA: 0x009329C3 File Offset: 0x00930BC3
		// (set) Token: 0x06024019 RID: 147481 RVA: 0x009329D3 File Offset: 0x00930BD3
		public unsafe BP_EWorldType Editor_Type_0
		{
			get
			{
				return (BP_EWorldType)(*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_35));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_35) = (byte)value;
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x0602401A RID: 147482 RVA: 0x009329E4 File Offset: 0x00930BE4
		// (set) Token: 0x0602401B RID: 147483 RVA: 0x009329F4 File Offset: 0x00930BF4
		public unsafe float Dist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x0602401C RID: 147484 RVA: 0x00932A05 File Offset: 0x00930C05
		// (set) Token: 0x0602401D RID: 147485 RVA: 0x00932A15 File Offset: 0x00930C15
		public unsafe float FadeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x0602401E RID: 147486 RVA: 0x00932A26 File Offset: 0x00930C26
		// (set) Token: 0x0602401F RID: 147487 RVA: 0x00932A36 File Offset: 0x00930C36
		public unsafe float MinAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x06024020 RID: 147488 RVA: 0x00932A47 File Offset: 0x00930C47
		// (set) Token: 0x06024021 RID: 147489 RVA: 0x00932A57 File Offset: 0x00930C57
		public unsafe int NowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTraceCloud_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x06024022 RID: 147490 RVA: 0x00932A68 File Offset: 0x00930C68
		// (set) Token: 0x06024023 RID: 147491 RVA: 0x00932A7C File Offset: 0x00930C7C
		public unsafe UMaterialInstanceConstant HighCloudMaterial_SuperHigh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTraceCloud_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x06024024 RID: 147492 RVA: 0x00932A94 File Offset: 0x00930C94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitCloud(UMaterialInterface Material)
		{
			BP_KuroTraceCloud_C.__InitCloud_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__InitCloud_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__InitCloud_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__InitCloud_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__InitCloud_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024025 RID: 147493 RVA: 0x00932AEC File Offset: 0x00930CEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DistanceFromBox(FVector P, FVector Box, ref float dist)
		{
			BP_KuroTraceCloud_C.__DistanceFromBox_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__DistanceFromBox_FunctionParams[(UIntPtr)107] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__DistanceFromBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__DistanceFromBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			ptr->Box = Box;
			ptr->dist = dist;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__DistanceFromBox_NativeFunctionPtr, (void*)ptr);
			dist = ptr->dist;
		}

		// Token: 0x06024026 RID: 147494 RVA: 0x00932B4C File Offset: 0x00930D4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShowCloud(bool bNewVisibility)
		{
			BP_KuroTraceCloud_C.__ShowCloud_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__ShowCloud_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__ShowCloud_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__ShowCloud_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bNewVisibility = bNewVisibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ShowCloud_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024027 RID: 147495 RVA: 0x00932B92 File Offset: 0x00930D92
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Cloud_Fade()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__Update_Cloud_Fade_NativeFunctionPtr, null);
		}

		// Token: 0x06024028 RID: 147496 RVA: 0x00932BA8 File Offset: 0x00930DA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLerpGIData(float Time, ref SD_KuroTraceCloudData LerpData)
		{
			BP_KuroTraceCloud_C.__GetLerpGIData_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__GetLerpGIData_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__GetLerpGIData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__GetLerpGIData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			if (LerpData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SD_KuroTraceCloudData.StaticStruct(), &ptr->LerpData, LerpData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__GetLerpGIData_NativeFunctionPtr, (void*)ptr);
			if (LerpData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SD_KuroTraceCloudData.StaticStruct(), LerpData.NativePtr, &ptr->LerpData, 1, false);
			}
		}

		// Token: 0x06024029 RID: 147497 RVA: 0x00932C3C File Offset: 0x00930E3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloudLighting(UMaterialInstanceDynamic Material)
		{
			BP_KuroTraceCloud_C.__UpdateCloudLighting_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__UpdateCloudLighting_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__UpdateCloudLighting_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__UpdateCloudLighting_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__UpdateCloudLighting_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602402A RID: 147498 RVA: 0x00932C94 File Offset: 0x00930E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloudTransform(UStaticMeshComponent CloudCube)
		{
			BP_KuroTraceCloud_C.__UpdateCloudTransform_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__UpdateCloudTransform_FunctionParams[(UIntPtr)431] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__UpdateCloudTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__UpdateCloudTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudCube = ((CloudCube != null) ? CloudCube.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__UpdateCloudTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602402B RID: 147499 RVA: 0x00932CEC File Offset: 0x00930EEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602402C RID: 147500 RVA: 0x00932D00 File Offset: 0x00930F00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTraceCloud_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602402D RID: 147501 RVA: 0x00932D18 File Offset: 0x00930F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroTraceCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602402E RID: 147502 RVA: 0x00932D60 File Offset: 0x00930F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroTraceCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602402F RID: 147503 RVA: 0x00932DA7 File Offset: 0x00930FA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024030 RID: 147504 RVA: 0x00932DBB File Offset: 0x00930FBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024031 RID: 147505 RVA: 0x00932DCF File Offset: 0x00930FCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024032 RID: 147506 RVA: 0x00932DE4 File Offset: 0x00930FE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06024033 RID: 147507 RVA: 0x00932DF8 File Offset: 0x00930FF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroTraceCloud_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024034 RID: 147508 RVA: 0x00932E44 File Offset: 0x00931044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroTraceCloud_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroTraceCloud_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroTraceCloud_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTraceCloud_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTraceCloud_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024035 RID: 147509 RVA: 0x00932E90 File Offset: 0x00931090
		protected BP_KuroTraceCloud_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CF2 RID: 72946
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/BP_KuroTraceCloud.BP_KuroTraceCloud_C";

		// Token: 0x04011CF3 RID: 72947
		private static IntPtr _ClassPtr;

		// Token: 0x04011CF4 RID: 72948
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011CF5 RID: 72949
		internal static int __PropertyOffset_1;

		// Token: 0x04011CF6 RID: 72950
		internal static int __PropertyOffset_2;

		// Token: 0x04011CF7 RID: 72951
		internal static int __PropertyOffset_3;

		// Token: 0x04011CF8 RID: 72952
		internal static int __PropertyOffset_4;

		// Token: 0x04011CF9 RID: 72953
		internal static int __PropertyOffset_5;

		// Token: 0x04011CFA RID: 72954
		internal static int __PropertyOffset_6;

		// Token: 0x04011CFB RID: 72955
		internal static int __PropertyOffset_7;

		// Token: 0x04011CFC RID: 72956
		internal static int __PropertyOffset_8;

		// Token: 0x04011CFD RID: 72957
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SD_KuroTraceCloudData> _Data;

		// Token: 0x04011CFE RID: 72958
		internal static int __PropertyOffset_9;

		// Token: 0x04011CFF RID: 72959
		private SD_KuroTraceCloudData _LerpData;

		// Token: 0x04011D00 RID: 72960
		internal static int __PropertyOffset_10;

		// Token: 0x04011D01 RID: 72961
		internal static int __PropertyOffset_11;

		// Token: 0x04011D02 RID: 72962
		internal static int __PropertyOffset_12;

		// Token: 0x04011D03 RID: 72963
		internal static int __PropertyOffset_13;

		// Token: 0x04011D04 RID: 72964
		internal static int __PropertyOffset_14;

		// Token: 0x04011D05 RID: 72965
		internal static int __PropertyOffset_15;

		// Token: 0x04011D06 RID: 72966
		internal static int __PropertyOffset_16;

		// Token: 0x04011D07 RID: 72967
		internal static int __PropertyOffset_17;

		// Token: 0x04011D08 RID: 72968
		internal static int __PropertyOffset_18;

		// Token: 0x04011D09 RID: 72969
		internal static int __PropertyOffset_19;

		// Token: 0x04011D0A RID: 72970
		internal static int __PropertyOffset_20;

		// Token: 0x04011D0B RID: 72971
		internal static int __PropertyOffset_21;

		// Token: 0x04011D0C RID: 72972
		internal static int __PropertyOffset_22;

		// Token: 0x04011D0D RID: 72973
		internal static int __PropertyOffset_23;

		// Token: 0x04011D0E RID: 72974
		internal static int __PropertyOffset_24;

		// Token: 0x04011D0F RID: 72975
		internal static int __PropertyOffset_25;

		// Token: 0x04011D10 RID: 72976
		internal static int __PropertyOffset_26;

		// Token: 0x04011D11 RID: 72977
		internal static int __PropertyOffset_27;

		// Token: 0x04011D12 RID: 72978
		internal static int __PropertyOffset_28;

		// Token: 0x04011D13 RID: 72979
		internal static int __PropertyOffset_29;

		// Token: 0x04011D14 RID: 72980
		internal static int __PropertyOffset_30;

		// Token: 0x04011D15 RID: 72981
		internal static int __PropertyOffset_31;

		// Token: 0x04011D16 RID: 72982
		internal static int __PropertyOffset_32;

		// Token: 0x04011D17 RID: 72983
		internal static int __PropertyOffset_33;

		// Token: 0x04011D18 RID: 72984
		internal static int __PropertyOffset_34;

		// Token: 0x04011D19 RID: 72985
		internal static int __PropertyOffset_35;

		// Token: 0x04011D1A RID: 72986
		internal static int __PropertyOffset_36;

		// Token: 0x04011D1B RID: 72987
		internal static int __PropertyOffset_37;

		// Token: 0x04011D1C RID: 72988
		internal static int __PropertyOffset_38;

		// Token: 0x04011D1D RID: 72989
		internal static int __PropertyOffset_39;

		// Token: 0x04011D1E RID: 72990
		internal static int __PropertyOffset_40;

		// Token: 0x04011D1F RID: 72991
		private static IntPtr __InitCloud_NativeFunctionPtr;

		// Token: 0x04011D20 RID: 72992
		private static IntPtr __DistanceFromBox_NativeFunctionPtr;

		// Token: 0x04011D21 RID: 72993
		private static IntPtr __ShowCloud_NativeFunctionPtr;

		// Token: 0x04011D22 RID: 72994
		private static IntPtr __Update_Cloud_Fade_NativeFunctionPtr;

		// Token: 0x04011D23 RID: 72995
		private static IntPtr __GetLerpGIData_NativeFunctionPtr;

		// Token: 0x04011D24 RID: 72996
		private static IntPtr __UpdateCloudLighting_NativeFunctionPtr;

		// Token: 0x04011D25 RID: 72997
		private static IntPtr __UpdateCloudTransform_NativeFunctionPtr;

		// Token: 0x04011D26 RID: 72998
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011D27 RID: 72999
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011D28 RID: 73000
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011D29 RID: 73001
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011D2A RID: 73002
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x04011D2B RID: 73003
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009EBF RID: 40639
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __InitCloud_FunctionParams
		{
			// Token: 0x040317A8 RID: 202664
			[FieldOffset(0)]
			public IntPtr Material;
		}

		// Token: 0x02009EC0 RID: 40640
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 92)]
		protected ref struct __DistanceFromBox_FunctionParams
		{
			// Token: 0x040317A9 RID: 202665
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x040317AA RID: 202666
			[FieldOffset(12)]
			public FVector Box;

			// Token: 0x040317AB RID: 202667
			[FieldOffset(24)]
			public float dist;
		}

		// Token: 0x02009EC1 RID: 40641
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShowCloud_FunctionParams
		{
			// Token: 0x040317AC RID: 202668
			[FieldOffset(0)]
			public bool bNewVisibility;
		}

		// Token: 0x02009EC2 RID: 40642
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __GetLerpGIData_FunctionParams
		{
			// Token: 0x040317AD RID: 202669
			[FieldOffset(0)]
			public float Time;

			// Token: 0x040317AE RID: 202670
			[FieldOffset(4)]
			public byte LerpData;
		}

		// Token: 0x02009EC3 RID: 40643
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateCloudLighting_FunctionParams
		{
			// Token: 0x040317AF RID: 202671
			[FieldOffset(0)]
			public IntPtr Material;
		}

		// Token: 0x02009EC4 RID: 40644
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 416)]
		protected ref struct __UpdateCloudTransform_FunctionParams
		{
			// Token: 0x040317B0 RID: 202672
			[FieldOffset(0)]
			public IntPtr CloudCube;
		}

		// Token: 0x02009EC5 RID: 40645
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317B1 RID: 202673
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EC6 RID: 40646
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040317B2 RID: 202674
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
