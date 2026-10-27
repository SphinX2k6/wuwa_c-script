using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.Data.Water
{
	// Token: 0x02003E41 RID: 15937
	[UnrealObjectPath("/Game/Aki/Render/Data/Water/BP_RippleWater_Data.BP_RippleWater_Data_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class BP_RippleWater_Data_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060280D9 RID: 164057 RVA: 0x009A2CAD File Offset: 0x009A0EAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RippleWater_Data_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/Data/Water/BP_RippleWater_Data.BP_RippleWater_Data_C");
			}
			return BP_RippleWater_Data_C._ClassPtr;
		}

		// Token: 0x060280DA RID: 164058 RVA: 0x009A2CD4 File Offset: 0x009A0ED4
		public BP_RippleWater_Data_C() : this(BuiltinUtils.AllocNativeUObject(BP_RippleWater_Data_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060280DB RID: 164059 RVA: 0x009A2CFC File Offset: 0x009A0EFC
		[NullableContext(1)]
		public BP_RippleWater_Data_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RippleWater_Data_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x060280DC RID: 164060 RVA: 0x009A2D2F File Offset: 0x009A0F2F
		// (set) Token: 0x060280DD RID: 164061 RVA: 0x009A2D3F File Offset: 0x009A0F3F
		public unsafe float Step
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x060280DE RID: 164062 RVA: 0x009A2D50 File Offset: 0x009A0F50
		// (set) Token: 0x060280DF RID: 164063 RVA: 0x009A2D60 File Offset: 0x009A0F60
		public unsafe float captureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x060280E0 RID: 164064 RVA: 0x009A2D71 File Offset: 0x009A0F71
		// (set) Token: 0x060280E1 RID: 164065 RVA: 0x009A2D81 File Offset: 0x009A0F81
		public unsafe float PlayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x060280E2 RID: 164066 RVA: 0x009A2D92 File Offset: 0x009A0F92
		// (set) Token: 0x060280E3 RID: 164067 RVA: 0x009A2DA2 File Offset: 0x009A0FA2
		public unsafe float RippleDistanceNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x060280E4 RID: 164068 RVA: 0x009A2DB3 File Offset: 0x009A0FB3
		// (set) Token: 0x060280E5 RID: 164069 RVA: 0x009A2DC3 File Offset: 0x009A0FC3
		public unsafe float RippleDistanceFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x060280E6 RID: 164070 RVA: 0x009A2DD4 File Offset: 0x009A0FD4
		// (set) Token: 0x060280E7 RID: 164071 RVA: 0x009A2DE4 File Offset: 0x009A0FE4
		public unsafe float SwimRippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x060280E8 RID: 164072 RVA: 0x009A2DF5 File Offset: 0x009A0FF5
		// (set) Token: 0x060280E9 RID: 164073 RVA: 0x009A2E09 File Offset: 0x009A1009
		public unsafe FVector2D ExtraRipplePoint1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x060280EA RID: 164074 RVA: 0x009A2E1E File Offset: 0x009A101E
		// (set) Token: 0x060280EB RID: 164075 RVA: 0x009A2E32 File Offset: 0x009A1032
		public unsafe FVector2D ExtraRipplePoint2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005B98 RID: 23448
		// (get) Token: 0x060280EC RID: 164076 RVA: 0x009A2E47 File Offset: 0x009A1047
		// (set) Token: 0x060280ED RID: 164077 RVA: 0x009A2E57 File Offset: 0x009A1057
		public unsafe float PlayerSize_Mul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005B99 RID: 23449
		// (get) Token: 0x060280EE RID: 164078 RVA: 0x009A2E68 File Offset: 0x009A1068
		// (set) Token: 0x060280EF RID: 164079 RVA: 0x009A2E78 File Offset: 0x009A1078
		public unsafe float ExtraPlayerSize_Mul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x060280F0 RID: 164080 RVA: 0x009A2E89 File Offset: 0x009A1089
		// (set) Token: 0x060280F1 RID: 164081 RVA: 0x009A2E99 File Offset: 0x009A1099
		public unsafe float RippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x060280F2 RID: 164082 RVA: 0x009A2EAA File Offset: 0x009A10AA
		// (set) Token: 0x060280F3 RID: 164083 RVA: 0x009A2EBA File Offset: 0x009A10BA
		public unsafe float RippleAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleWater_Data_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x060280F4 RID: 164084 RVA: 0x009A2ECB File Offset: 0x009A10CB
		protected BP_RippleWater_Data_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014571 RID: 83313
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/Data/Water/BP_RippleWater_Data.BP_RippleWater_Data_C";

		// Token: 0x04014572 RID: 83314
		private static IntPtr _ClassPtr;

		// Token: 0x04014573 RID: 83315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014574 RID: 83316
		internal static int __PropertyOffset_0;

		// Token: 0x04014575 RID: 83317
		internal static int __PropertyOffset_1;

		// Token: 0x04014576 RID: 83318
		internal static int __PropertyOffset_2;

		// Token: 0x04014577 RID: 83319
		internal static int __PropertyOffset_3;

		// Token: 0x04014578 RID: 83320
		internal static int __PropertyOffset_4;

		// Token: 0x04014579 RID: 83321
		internal static int __PropertyOffset_5;

		// Token: 0x0401457A RID: 83322
		internal static int __PropertyOffset_6;

		// Token: 0x0401457B RID: 83323
		internal static int __PropertyOffset_7;

		// Token: 0x0401457C RID: 83324
		internal static int __PropertyOffset_8;

		// Token: 0x0401457D RID: 83325
		internal static int __PropertyOffset_9;

		// Token: 0x0401457E RID: 83326
		internal static int __PropertyOffset_10;

		// Token: 0x0401457F RID: 83327
		internal static int __PropertyOffset_11;
	}
}
