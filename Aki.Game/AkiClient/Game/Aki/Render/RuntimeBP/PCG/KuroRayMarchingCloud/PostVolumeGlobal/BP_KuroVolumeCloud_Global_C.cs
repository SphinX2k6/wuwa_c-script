using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal
{
	// Token: 0x02003C7B RID: 15483
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Global.BP_KuroVolumeCloud_Global_C")]
	[UnrealStructLayout(2016, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2012)]
	public class BP_KuroVolumeCloud_Global_C : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024042 RID: 147522 RVA: 0x00932F59 File Offset: 0x00931159
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumeCloud_Global_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Global.BP_KuroVolumeCloud_Global_C");
			}
			return BP_KuroVolumeCloud_Global_C._ClassPtr;
		}

		// Token: 0x06024043 RID: 147523 RVA: 0x00932F80 File Offset: 0x00931180
		public BP_KuroVolumeCloud_Global_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeCloud_Global_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024044 RID: 147524 RVA: 0x00932FA8 File Offset: 0x009311A8
		[NullableContext(1)]
		public BP_KuroVolumeCloud_Global_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeCloud_Global_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x06024045 RID: 147525 RVA: 0x00932FDB File Offset: 0x009311DB
		// (set) Token: 0x06024046 RID: 147526 RVA: 0x00932FEF File Offset: 0x009311EF
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x06024047 RID: 147527 RVA: 0x00933004 File Offset: 0x00931204
		// (set) Token: 0x06024048 RID: 147528 RVA: 0x00933018 File Offset: 0x00931218
		public unsafe USceneComponent CloudRange
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x06024049 RID: 147529 RVA: 0x0093302D File Offset: 0x0093122D
		// (set) Token: 0x0602404A RID: 147530 RVA: 0x00933041 File Offset: 0x00931241
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x0602404B RID: 147531 RVA: 0x00933058 File Offset: 0x00931258
		// (set) Token: 0x0602404C RID: 147532 RVA: 0x00933091 File Offset: 0x00931291
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
					result = (this._Data = new TArray<SD_KuroTraceCloudData>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x0602404D RID: 147533 RVA: 0x009330A0 File Offset: 0x009312A0
		// (set) Token: 0x0602404E RID: 147534 RVA: 0x009330D9 File Offset: 0x009312D9
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
					result = (this._LerpData = new SD_KuroTraceCloudData(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SD_KuroTraceCloudData.StaticStruct(), base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x0602404F RID: 147535 RVA: 0x009330FA File Offset: 0x009312FA
		// (set) Token: 0x06024050 RID: 147536 RVA: 0x0093310A File Offset: 0x0093130A
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x06024051 RID: 147537 RVA: 0x0093311B File Offset: 0x0093131B
		// (set) Token: 0x06024052 RID: 147538 RVA: 0x0093312B File Offset: 0x0093132B
		public unsafe bool bUpdateTransformAlways
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x06024053 RID: 147539 RVA: 0x0093313C File Offset: 0x0093133C
		// (set) Token: 0x06024054 RID: 147540 RVA: 0x0093314C File Offset: 0x0093134C
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x06024055 RID: 147541 RVA: 0x0093315D File Offset: 0x0093135D
		// (set) Token: 0x06024056 RID: 147542 RVA: 0x00933171 File Offset: 0x00931371
		public unsafe FLinearColor BakeFlowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x06024057 RID: 147543 RVA: 0x00933186 File Offset: 0x00931386
		// (set) Token: 0x06024058 RID: 147544 RVA: 0x0093319A File Offset: 0x0093139A
		public unsafe UMaterialInterface LastMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x06024059 RID: 147545 RVA: 0x009331AF File Offset: 0x009313AF
		// (set) Token: 0x0602405A RID: 147546 RVA: 0x009331C3 File Offset: 0x009313C3
		public unsafe FVectorDouble LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x0602405B RID: 147547 RVA: 0x009331D8 File Offset: 0x009313D8
		// (set) Token: 0x0602405C RID: 147548 RVA: 0x009331EC File Offset: 0x009313EC
		public unsafe FVectorDouble LastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x0602405D RID: 147549 RVA: 0x00933201 File Offset: 0x00931401
		// (set) Token: 0x0602405E RID: 147550 RVA: 0x00933211 File Offset: 0x00931411
		public unsafe bool bLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x0602405F RID: 147551 RVA: 0x00933222 File Offset: 0x00931422
		// (set) Token: 0x06024060 RID: 147552 RVA: 0x00933236 File Offset: 0x00931436
		public unsafe FLinearColor CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x06024061 RID: 147553 RVA: 0x0093324B File Offset: 0x0093144B
		// (set) Token: 0x06024062 RID: 147554 RVA: 0x0093325F File Offset: 0x0093145F
		public unsafe FLinearColor LocalSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x06024063 RID: 147555 RVA: 0x00933274 File Offset: 0x00931474
		// (set) Token: 0x06024064 RID: 147556 RVA: 0x00933284 File Offset: 0x00931484
		public unsafe int FadeGroup_0_2_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x06024065 RID: 147557 RVA: 0x00933295 File Offset: 0x00931495
		// (set) Token: 0x06024066 RID: 147558 RVA: 0x009332A5 File Offset: 0x009314A5
		public unsafe float LocalOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x06024067 RID: 147559 RVA: 0x009332B6 File Offset: 0x009314B6
		// (set) Token: 0x06024068 RID: 147560 RVA: 0x009332CA File Offset: 0x009314CA
		public unsafe FLinearColor ThunderColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x06024069 RID: 147561 RVA: 0x009332DF File Offset: 0x009314DF
		// (set) Token: 0x0602406A RID: 147562 RVA: 0x009332EF File Offset: 0x009314EF
		public unsafe float ThunderSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x0602406B RID: 147563 RVA: 0x00933300 File Offset: 0x00931500
		// (set) Token: 0x0602406C RID: 147564 RVA: 0x00933310 File Offset: 0x00931510
		public unsafe float ThunderTimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x0602406D RID: 147565 RVA: 0x00933321 File Offset: 0x00931521
		// (set) Token: 0x0602406E RID: 147566 RVA: 0x00933335 File Offset: 0x00931535
		public unsafe UCurveFloat ThunderCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x0602406F RID: 147567 RVA: 0x0093334A File Offset: 0x0093154A
		// (set) Token: 0x06024070 RID: 147568 RVA: 0x0093335E File Offset: 0x0093155E
		public unsafe UCurveFloat ThunderCurve2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x06024071 RID: 147569 RVA: 0x00933373 File Offset: 0x00931573
		// (set) Token: 0x06024072 RID: 147570 RVA: 0x00933387 File Offset: 0x00931587
		public unsafe UCurveFloat ThunderCurve3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x06024073 RID: 147571 RVA: 0x0093339C File Offset: 0x0093159C
		// (set) Token: 0x06024074 RID: 147572 RVA: 0x009333D5 File Offset: 0x009315D5
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_24, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x06024075 RID: 147573 RVA: 0x009333E4 File Offset: 0x009315E4
		// (set) Token: 0x06024076 RID: 147574 RVA: 0x0093341D File Offset: 0x0093161D
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x06024077 RID: 147575 RVA: 0x0093342C File Offset: 0x0093162C
		// (set) Token: 0x06024078 RID: 147576 RVA: 0x00933465 File Offset: 0x00931665
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_26, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x06024079 RID: 147577 RVA: 0x00933473 File Offset: 0x00931673
		// (set) Token: 0x0602407A RID: 147578 RVA: 0x00933483 File Offset: 0x00931683
		public unsafe bool bUseGlobalSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x0602407B RID: 147579 RVA: 0x00933494 File Offset: 0x00931694
		// (set) Token: 0x0602407C RID: 147580 RVA: 0x009334A4 File Offset: 0x009316A4
		public unsafe bool bEnableDistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x0602407D RID: 147581 RVA: 0x009334B5 File Offset: 0x009316B5
		// (set) Token: 0x0602407E RID: 147582 RVA: 0x009334C5 File Offset: 0x009316C5
		public unsafe double DistanceFadeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x0602407F RID: 147583 RVA: 0x009334D6 File Offset: 0x009316D6
		// (set) Token: 0x06024080 RID: 147584 RVA: 0x009334E6 File Offset: 0x009316E6
		public unsafe double DistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x06024081 RID: 147585 RVA: 0x009334F7 File Offset: 0x009316F7
		// (set) Token: 0x06024082 RID: 147586 RVA: 0x00933507 File Offset: 0x00931707
		public unsafe int NowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x06024083 RID: 147587 RVA: 0x00933518 File Offset: 0x00931718
		// (set) Token: 0x06024084 RID: 147588 RVA: 0x0093352C File Offset: 0x0093172C
		public unsafe AStaticMeshActor LowQualityMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x06024085 RID: 147589 RVA: 0x00933541 File Offset: 0x00931741
		// (set) Token: 0x06024086 RID: 147590 RVA: 0x00933551 File Offset: 0x00931751
		public unsafe float CacheLocalOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x06024087 RID: 147591 RVA: 0x00933562 File Offset: 0x00931762
		// (set) Token: 0x06024088 RID: 147592 RVA: 0x00933572 File Offset: 0x00931772
		public unsafe bool LastNotAffectedByVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x06024089 RID: 147593 RVA: 0x00933583 File Offset: 0x00931783
		// (set) Token: 0x0602408A RID: 147594 RVA: 0x00933593 File Offset: 0x00931793
		public unsafe int LastQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x0602408B RID: 147595 RVA: 0x009335A4 File Offset: 0x009317A4
		// (set) Token: 0x0602408C RID: 147596 RVA: 0x009335B8 File Offset: 0x009317B8
		public unsafe UMaterialParameterCollection MPC_GlobalShader
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x0602408D RID: 147597 RVA: 0x009335CD File Offset: 0x009317CD
		// (set) Token: 0x0602408E RID: 147598 RVA: 0x009335DD File Offset: 0x009317DD
		public unsafe float VolumeCloudSpeedMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x0602408F RID: 147599 RVA: 0x009335EE File Offset: 0x009317EE
		// (set) Token: 0x06024090 RID: 147600 RVA: 0x009335FE File Offset: 0x009317FE
		public unsafe bool bShouldTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x06024091 RID: 147601 RVA: 0x0093360F File Offset: 0x0093180F
		// (set) Token: 0x06024092 RID: 147602 RVA: 0x0093361F File Offset: 0x0093181F
		public unsafe bool bLocalOnlyForVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x06024093 RID: 147603 RVA: 0x00933630 File Offset: 0x00931830
		// (set) Token: 0x06024094 RID: 147604 RVA: 0x00933640 File Offset: 0x00931840
		public unsafe bool bVolumeCloudNotAffectedByVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x06024095 RID: 147605 RVA: 0x00933651 File Offset: 0x00931851
		// (set) Token: 0x06024096 RID: 147606 RVA: 0x00933661 File Offset: 0x00931861
		public unsafe bool bMac
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x06024097 RID: 147607 RVA: 0x00933672 File Offset: 0x00931872
		// (set) Token: 0x06024098 RID: 147608 RVA: 0x00933686 File Offset: 0x00931886
		public unsafe FName FadeGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x06024099 RID: 147609 RVA: 0x0093369B File Offset: 0x0093189B
		// (set) Token: 0x0602409A RID: 147610 RVA: 0x009336AB File Offset: 0x009318AB
		public unsafe bool vrsNotChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x0602409B RID: 147611 RVA: 0x009336BC File Offset: 0x009318BC
		// (set) Token: 0x0602409C RID: 147612 RVA: 0x009336CC File Offset: 0x009318CC
		public unsafe int VRSQualityOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x0602409D RID: 147613 RVA: 0x009336DD File Offset: 0x009318DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudShadingRateLocal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudShadingRateLocal_NativeFunctionPtr, null);
		}

		// Token: 0x0602409E RID: 147614 RVA: 0x009336F1 File Offset: 0x009318F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudShadingRate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudShadingRate_NativeFunctionPtr, null);
		}

		// Token: 0x0602409F RID: 147615 RVA: 0x00933705 File Offset: 0x00931905
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CleanMID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__CleanMID_NativeFunctionPtr, null);
		}

		// Token: 0x060240A0 RID: 147616 RVA: 0x00933719 File Offset: 0x00931919
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckNeed_Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__CheckNeed_Update_NativeFunctionPtr, null);
		}

		// Token: 0x060240A1 RID: 147617 RVA: 0x0093372D File Offset: 0x0093192D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x060240A2 RID: 147618 RVA: 0x00933744 File Offset: 0x00931944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLerpGIData(float Time, ref SD_KuroTraceCloudData LerpData)
		{
			BP_KuroVolumeCloud_Global_C.__GetLerpGIData_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__GetLerpGIData_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__GetLerpGIData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__GetLerpGIData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			if (LerpData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SD_KuroTraceCloudData.StaticStruct(), &ptr->LerpData, LerpData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__GetLerpGIData_NativeFunctionPtr, (void*)ptr);
			if (LerpData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SD_KuroTraceCloudData.StaticStruct(), LerpData.NativePtr, &ptr->LerpData, 1, false);
			}
		}

		// Token: 0x060240A3 RID: 147619 RVA: 0x009337D5 File Offset: 0x009319D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudLighting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudLighting_NativeFunctionPtr, null);
		}

		// Token: 0x060240A4 RID: 147620 RVA: 0x009337E9 File Offset: 0x009319E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudTransform_NativeFunctionPtr, null);
		}

		// Token: 0x060240A5 RID: 147621 RVA: 0x009337FD File Offset: 0x009319FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060240A6 RID: 147622 RVA: 0x00933811 File Offset: 0x00931A11
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240A7 RID: 147623 RVA: 0x00933826 File Offset: 0x00931A26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060240A8 RID: 147624 RVA: 0x0093383A File Offset: 0x00931A3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240A9 RID: 147625 RVA: 0x00933850 File Offset: 0x00931A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060240AA RID: 147626 RVA: 0x00933898 File Offset: 0x00931A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060240AB RID: 147627 RVA: 0x009338DF File Offset: 0x00931ADF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060240AC RID: 147628 RVA: 0x009338F3 File Offset: 0x00931AF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x060240AD RID: 147629 RVA: 0x00933907 File Offset: 0x00931B07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x0093391C File Offset: 0x00931B1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x060240AF RID: 147631 RVA: 0x00933930 File Offset: 0x00931B30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForPC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240B0 RID: 147632 RVA: 0x00933945 File Offset: 0x00931B45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeSave_NativeFunctionPtr, null);
		}

		// Token: 0x060240B1 RID: 147633 RVA: 0x00933959 File Offset: 0x00931B59
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BeforeSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeSave_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240B2 RID: 147634 RVA: 0x0093396E File Offset: 0x00931B6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x060240B3 RID: 147635 RVA: 0x00933984 File Offset: 0x00931B84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060240B4 RID: 147636 RVA: 0x009339D0 File Offset: 0x00931BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060240B5 RID: 147637 RVA: 0x00933A1C File Offset: 0x00931C1C
		protected BP_KuroVolumeCloud_Global_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D30 RID: 73008
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Global.BP_KuroVolumeCloud_Global_C";

		// Token: 0x04011D31 RID: 73009
		private static IntPtr _ClassPtr;

		// Token: 0x04011D32 RID: 73010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D33 RID: 73011
		internal static int __PropertyOffset_1;

		// Token: 0x04011D34 RID: 73012
		internal static int __PropertyOffset_2;

		// Token: 0x04011D35 RID: 73013
		internal static int __PropertyOffset_3;

		// Token: 0x04011D36 RID: 73014
		internal static int __PropertyOffset_4;

		// Token: 0x04011D37 RID: 73015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SD_KuroTraceCloudData> _Data;

		// Token: 0x04011D38 RID: 73016
		internal static int __PropertyOffset_5;

		// Token: 0x04011D39 RID: 73017
		private SD_KuroTraceCloudData _LerpData;

		// Token: 0x04011D3A RID: 73018
		internal static int __PropertyOffset_6;

		// Token: 0x04011D3B RID: 73019
		internal static int __PropertyOffset_7;

		// Token: 0x04011D3C RID: 73020
		internal static int __PropertyOffset_8;

		// Token: 0x04011D3D RID: 73021
		internal static int __PropertyOffset_9;

		// Token: 0x04011D3E RID: 73022
		internal static int __PropertyOffset_10;

		// Token: 0x04011D3F RID: 73023
		internal static int __PropertyOffset_11;

		// Token: 0x04011D40 RID: 73024
		internal static int __PropertyOffset_12;

		// Token: 0x04011D41 RID: 73025
		internal static int __PropertyOffset_13;

		// Token: 0x04011D42 RID: 73026
		internal static int __PropertyOffset_14;

		// Token: 0x04011D43 RID: 73027
		internal static int __PropertyOffset_15;

		// Token: 0x04011D44 RID: 73028
		internal static int __PropertyOffset_16;

		// Token: 0x04011D45 RID: 73029
		internal static int __PropertyOffset_17;

		// Token: 0x04011D46 RID: 73030
		internal static int __PropertyOffset_18;

		// Token: 0x04011D47 RID: 73031
		internal static int __PropertyOffset_19;

		// Token: 0x04011D48 RID: 73032
		internal static int __PropertyOffset_20;

		// Token: 0x04011D49 RID: 73033
		internal static int __PropertyOffset_21;

		// Token: 0x04011D4A RID: 73034
		internal static int __PropertyOffset_22;

		// Token: 0x04011D4B RID: 73035
		internal static int __PropertyOffset_23;

		// Token: 0x04011D4C RID: 73036
		internal static int __PropertyOffset_24;

		// Token: 0x04011D4D RID: 73037
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04011D4E RID: 73038
		internal static int __PropertyOffset_25;

		// Token: 0x04011D4F RID: 73039
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04011D50 RID: 73040
		internal static int __PropertyOffset_26;

		// Token: 0x04011D51 RID: 73041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04011D52 RID: 73042
		internal static int __PropertyOffset_27;

		// Token: 0x04011D53 RID: 73043
		internal static int __PropertyOffset_28;

		// Token: 0x04011D54 RID: 73044
		internal static int __PropertyOffset_29;

		// Token: 0x04011D55 RID: 73045
		internal static int __PropertyOffset_30;

		// Token: 0x04011D56 RID: 73046
		internal static int __PropertyOffset_31;

		// Token: 0x04011D57 RID: 73047
		internal static int __PropertyOffset_32;

		// Token: 0x04011D58 RID: 73048
		internal static int __PropertyOffset_33;

		// Token: 0x04011D59 RID: 73049
		internal static int __PropertyOffset_34;

		// Token: 0x04011D5A RID: 73050
		internal static int __PropertyOffset_35;

		// Token: 0x04011D5B RID: 73051
		internal static int __PropertyOffset_36;

		// Token: 0x04011D5C RID: 73052
		internal static int __PropertyOffset_37;

		// Token: 0x04011D5D RID: 73053
		internal static int __PropertyOffset_38;

		// Token: 0x04011D5E RID: 73054
		internal static int __PropertyOffset_39;

		// Token: 0x04011D5F RID: 73055
		internal static int __PropertyOffset_40;

		// Token: 0x04011D60 RID: 73056
		internal static int __PropertyOffset_41;

		// Token: 0x04011D61 RID: 73057
		internal static int __PropertyOffset_42;

		// Token: 0x04011D62 RID: 73058
		internal static int __PropertyOffset_43;

		// Token: 0x04011D63 RID: 73059
		internal static int __PropertyOffset_44;

		// Token: 0x04011D64 RID: 73060
		private static IntPtr __UpdateCloudShadingRateLocal_NativeFunctionPtr;

		// Token: 0x04011D65 RID: 73061
		private static IntPtr __UpdateCloudShadingRate_NativeFunctionPtr;

		// Token: 0x04011D66 RID: 73062
		private static IntPtr __CleanMID_NativeFunctionPtr;

		// Token: 0x04011D67 RID: 73063
		private static IntPtr __CheckNeed_Update_NativeFunctionPtr;

		// Token: 0x04011D68 RID: 73064
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04011D69 RID: 73065
		private static IntPtr __GetLerpGIData_NativeFunctionPtr;

		// Token: 0x04011D6A RID: 73066
		private static IntPtr __UpdateCloudLighting_NativeFunctionPtr;

		// Token: 0x04011D6B RID: 73067
		private static IntPtr __UpdateCloudTransform_NativeFunctionPtr;

		// Token: 0x04011D6C RID: 73068
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011D6D RID: 73069
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011D6E RID: 73070
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011D6F RID: 73071
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011D70 RID: 73072
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04011D71 RID: 73073
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x04011D72 RID: 73074
		private static IntPtr __BeforeSave_NativeFunctionPtr;

		// Token: 0x04011D73 RID: 73075
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x04011D74 RID: 73076
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009EC7 RID: 40647
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __GetLerpGIData_FunctionParams
		{
			// Token: 0x040317B3 RID: 202675
			[FieldOffset(0)]
			public float Time;

			// Token: 0x040317B4 RID: 202676
			[FieldOffset(4)]
			public byte LerpData;
		}

		// Token: 0x02009EC8 RID: 40648
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317B5 RID: 202677
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EC9 RID: 40649
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040317B6 RID: 202678
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
