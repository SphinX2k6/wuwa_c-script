using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.Data.Water
{
	// Token: 0x02003E40 RID: 15936
	[UnrealObjectPath("/Game/Aki/Render/Data/Water/BP_Ocean_Data.BP_Ocean_Data_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class BP_Ocean_Data_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060280A3 RID: 164003 RVA: 0x009A2882 File Offset: 0x009A0A82
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Ocean_Data_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/Data/Water/BP_Ocean_Data.BP_Ocean_Data_C");
			}
			return BP_Ocean_Data_C._ClassPtr;
		}

		// Token: 0x060280A4 RID: 164004 RVA: 0x009A28A8 File Offset: 0x009A0AA8
		public BP_Ocean_Data_C() : this(BuiltinUtils.AllocNativeUObject(BP_Ocean_Data_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060280A5 RID: 164005 RVA: 0x009A28D0 File Offset: 0x009A0AD0
		[NullableContext(1)]
		public BP_Ocean_Data_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Ocean_Data_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x060280A6 RID: 164006 RVA: 0x009A2903 File Offset: 0x009A0B03
		// (set) Token: 0x060280A7 RID: 164007 RVA: 0x009A2917 File Offset: 0x009A0B17
		public unsafe FLinearColor FlickerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x060280A8 RID: 164008 RVA: 0x009A292C File Offset: 0x009A0B2C
		// (set) Token: 0x060280A9 RID: 164009 RVA: 0x009A2940 File Offset: 0x009A0B40
		public unsafe FLinearColor HightLightFlickerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x060280AA RID: 164010 RVA: 0x009A2955 File Offset: 0x009A0B55
		// (set) Token: 0x060280AB RID: 164011 RVA: 0x009A2965 File Offset: 0x009A0B65
		public unsafe float FlickerDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x060280AC RID: 164012 RVA: 0x009A2976 File Offset: 0x009A0B76
		// (set) Token: 0x060280AD RID: 164013 RVA: 0x009A2986 File Offset: 0x009A0B86
		public unsafe float FlowmapFlickerScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x060280AE RID: 164014 RVA: 0x009A2997 File Offset: 0x009A0B97
		// (set) Token: 0x060280AF RID: 164015 RVA: 0x009A29AB File Offset: 0x009A0BAB
		public unsafe FLinearColor FoamColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x060280B0 RID: 164016 RVA: 0x009A29C0 File Offset: 0x009A0BC0
		// (set) Token: 0x060280B1 RID: 164017 RVA: 0x009A29D0 File Offset: 0x009A0BD0
		public unsafe float FlowmapFoamScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x060280B2 RID: 164018 RVA: 0x009A29E1 File Offset: 0x009A0BE1
		// (set) Token: 0x060280B3 RID: 164019 RVA: 0x009A29F1 File Offset: 0x009A0BF1
		public unsafe float FoamNormalFlatten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005B7E RID: 23422
		// (get) Token: 0x060280B4 RID: 164020 RVA: 0x009A2A02 File Offset: 0x009A0C02
		// (set) Token: 0x060280B5 RID: 164021 RVA: 0x009A2A16 File Offset: 0x009A0C16
		public unsafe FLinearColor FoamEmissiveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005B7F RID: 23423
		// (get) Token: 0x060280B6 RID: 164022 RVA: 0x009A2A2B File Offset: 0x009A0C2B
		// (set) Token: 0x060280B7 RID: 164023 RVA: 0x009A2A3B File Offset: 0x009A0C3B
		public unsafe float WaveProfileAnimationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005B80 RID: 23424
		// (get) Token: 0x060280B8 RID: 164024 RVA: 0x009A2A4C File Offset: 0x009A0C4C
		// (set) Token: 0x060280B9 RID: 164025 RVA: 0x009A2A5C File Offset: 0x009A0C5C
		public unsafe float WaveProfileDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005B81 RID: 23425
		// (get) Token: 0x060280BA RID: 164026 RVA: 0x009A2A6D File Offset: 0x009A0C6D
		// (set) Token: 0x060280BB RID: 164027 RVA: 0x009A2A7D File Offset: 0x009A0C7D
		public unsafe float WaveProfileSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x060280BC RID: 164028 RVA: 0x009A2A8E File Offset: 0x009A0C8E
		// (set) Token: 0x060280BD RID: 164029 RVA: 0x009A2A9E File Offset: 0x009A0C9E
		public unsafe float WaveProfileWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x060280BE RID: 164030 RVA: 0x009A2AAF File Offset: 0x009A0CAF
		// (set) Token: 0x060280BF RID: 164031 RVA: 0x009A2AC3 File Offset: 0x009A0CC3
		public unsafe FLinearColor FluxWaveProfileDecode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x060280C0 RID: 164032 RVA: 0x009A2AD8 File Offset: 0x009A0CD8
		// (set) Token: 0x060280C1 RID: 164033 RVA: 0x009A2AEC File Offset: 0x009A0CEC
		public unsafe FLinearColor ScatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x060280C2 RID: 164034 RVA: 0x009A2B01 File Offset: 0x009A0D01
		// (set) Token: 0x060280C3 RID: 164035 RVA: 0x009A2B15 File Offset: 0x009A0D15
		public unsafe FLinearColor ScatteringShoreline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x060280C4 RID: 164036 RVA: 0x009A2B2A File Offset: 0x009A0D2A
		// (set) Token: 0x060280C5 RID: 164037 RVA: 0x009A2B3E File Offset: 0x009A0D3E
		public unsafe FLinearColor ScatteringFoam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x060280C6 RID: 164038 RVA: 0x009A2B53 File Offset: 0x009A0D53
		// (set) Token: 0x060280C7 RID: 164039 RVA: 0x009A2B67 File Offset: 0x009A0D67
		public unsafe FLinearColor ScatteringInside
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x060280C8 RID: 164040 RVA: 0x009A2B7C File Offset: 0x009A0D7C
		// (set) Token: 0x060280C9 RID: 164041 RVA: 0x009A2B90 File Offset: 0x009A0D90
		public unsafe FLinearColor AbsorptionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x060280CA RID: 164042 RVA: 0x009A2BA5 File Offset: 0x009A0DA5
		// (set) Token: 0x060280CB RID: 164043 RVA: 0x009A2BB9 File Offset: 0x009A0DB9
		public unsafe FLinearColor AbsorptionColorInside
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x060280CC RID: 164044 RVA: 0x009A2BCE File Offset: 0x009A0DCE
		// (set) Token: 0x060280CD RID: 164045 RVA: 0x009A2BDE File Offset: 0x009A0DDE
		public unsafe float Anisotropy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x060280CE RID: 164046 RVA: 0x009A2BEF File Offset: 0x009A0DEF
		// (set) Token: 0x060280CF RID: 164047 RVA: 0x009A2C03 File Offset: 0x009A0E03
		public unsafe FLinearColor ColorScaleBehindWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x060280D0 RID: 164048 RVA: 0x009A2C18 File Offset: 0x009A0E18
		// (set) Token: 0x060280D1 RID: 164049 RVA: 0x009A2C2C File Offset: 0x009A0E2C
		public unsafe FLinearColor WaterColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005B8D RID: 23437
		// (get) Token: 0x060280D2 RID: 164050 RVA: 0x009A2C41 File Offset: 0x009A0E41
		// (set) Token: 0x060280D3 RID: 164051 RVA: 0x009A2C51 File Offset: 0x009A0E51
		public unsafe float CausticBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005B8E RID: 23438
		// (get) Token: 0x060280D4 RID: 164052 RVA: 0x009A2C62 File Offset: 0x009A0E62
		// (set) Token: 0x060280D5 RID: 164053 RVA: 0x009A2C72 File Offset: 0x009A0E72
		public unsafe float VelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005B8F RID: 23439
		// (get) Token: 0x060280D6 RID: 164054 RVA: 0x009A2C83 File Offset: 0x009A0E83
		// (set) Token: 0x060280D7 RID: 164055 RVA: 0x009A2C93 File Offset: 0x009A0E93
		public unsafe float VelocityPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ocean_Data_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x060280D8 RID: 164056 RVA: 0x009A2CA4 File Offset: 0x009A0EA4
		protected BP_Ocean_Data_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014555 RID: 83285
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/Data/Water/BP_Ocean_Data.BP_Ocean_Data_C";

		// Token: 0x04014556 RID: 83286
		private static IntPtr _ClassPtr;

		// Token: 0x04014557 RID: 83287
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014558 RID: 83288
		internal static int __PropertyOffset_0;

		// Token: 0x04014559 RID: 83289
		internal static int __PropertyOffset_1;

		// Token: 0x0401455A RID: 83290
		internal static int __PropertyOffset_2;

		// Token: 0x0401455B RID: 83291
		internal static int __PropertyOffset_3;

		// Token: 0x0401455C RID: 83292
		internal static int __PropertyOffset_4;

		// Token: 0x0401455D RID: 83293
		internal static int __PropertyOffset_5;

		// Token: 0x0401455E RID: 83294
		internal static int __PropertyOffset_6;

		// Token: 0x0401455F RID: 83295
		internal static int __PropertyOffset_7;

		// Token: 0x04014560 RID: 83296
		internal static int __PropertyOffset_8;

		// Token: 0x04014561 RID: 83297
		internal static int __PropertyOffset_9;

		// Token: 0x04014562 RID: 83298
		internal static int __PropertyOffset_10;

		// Token: 0x04014563 RID: 83299
		internal static int __PropertyOffset_11;

		// Token: 0x04014564 RID: 83300
		internal static int __PropertyOffset_12;

		// Token: 0x04014565 RID: 83301
		internal static int __PropertyOffset_13;

		// Token: 0x04014566 RID: 83302
		internal static int __PropertyOffset_14;

		// Token: 0x04014567 RID: 83303
		internal static int __PropertyOffset_15;

		// Token: 0x04014568 RID: 83304
		internal static int __PropertyOffset_16;

		// Token: 0x04014569 RID: 83305
		internal static int __PropertyOffset_17;

		// Token: 0x0401456A RID: 83306
		internal static int __PropertyOffset_18;

		// Token: 0x0401456B RID: 83307
		internal static int __PropertyOffset_19;

		// Token: 0x0401456C RID: 83308
		internal static int __PropertyOffset_20;

		// Token: 0x0401456D RID: 83309
		internal static int __PropertyOffset_21;

		// Token: 0x0401456E RID: 83310
		internal static int __PropertyOffset_22;

		// Token: 0x0401456F RID: 83311
		internal static int __PropertyOffset_23;

		// Token: 0x04014570 RID: 83312
		internal static int __PropertyOffset_24;
	}
}
