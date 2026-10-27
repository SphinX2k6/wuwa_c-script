using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.SummonGongduola
{
	// Token: 0x02003F05 RID: 16133
	[UnrealObjectPath("/Game/Aki/Data/Level/SummonGongduola/BP_SummonGongduolaConfig.BP_SummonGongduolaConfig_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 109)]
	public class BP_SummonGongduolaConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E55 RID: 167509 RVA: 0x009B70C7 File Offset: 0x009B52C7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SummonGongduolaConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/SummonGongduola/BP_SummonGongduolaConfig.BP_SummonGongduolaConfig_C");
			}
			return BP_SummonGongduolaConfig_C._ClassPtr;
		}

		// Token: 0x06028E56 RID: 167510 RVA: 0x009B70EC File Offset: 0x009B52EC
		public BP_SummonGongduolaConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SummonGongduolaConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E57 RID: 167511 RVA: 0x009B7114 File Offset: 0x009B5314
		[NullableContext(1)]
		public BP_SummonGongduolaConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SummonGongduolaConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006032 RID: 24626
		// (get) Token: 0x06028E58 RID: 167512 RVA: 0x009B7147 File Offset: 0x009B5347
		// (set) Token: 0x06028E59 RID: 167513 RVA: 0x009B7157 File Offset: 0x009B5357
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006033 RID: 24627
		// (get) Token: 0x06028E5A RID: 167514 RVA: 0x009B7168 File Offset: 0x009B5368
		// (set) Token: 0x06028E5B RID: 167515 RVA: 0x009B7178 File Offset: 0x009B5378
		public unsafe float StayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006034 RID: 24628
		// (get) Token: 0x06028E5C RID: 167516 RVA: 0x009B7189 File Offset: 0x009B5389
		// (set) Token: 0x06028E5D RID: 167517 RVA: 0x009B7199 File Offset: 0x009B5399
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006035 RID: 24629
		// (get) Token: 0x06028E5E RID: 167518 RVA: 0x009B71AA File Offset: 0x009B53AA
		// (set) Token: 0x06028E5F RID: 167519 RVA: 0x009B71BA File Offset: 0x009B53BA
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006036 RID: 24630
		// (get) Token: 0x06028E60 RID: 167520 RVA: 0x009B71CB File Offset: 0x009B53CB
		// (set) Token: 0x06028E61 RID: 167521 RVA: 0x009B71DB File Offset: 0x009B53DB
		public unsafe float OffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x06028E62 RID: 167522 RVA: 0x009B71EC File Offset: 0x009B53EC
		// (set) Token: 0x06028E63 RID: 167523 RVA: 0x009B71FC File Offset: 0x009B53FC
		public unsafe bool BanInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x06028E64 RID: 167524 RVA: 0x009B720D File Offset: 0x009B540D
		// (set) Token: 0x06028E65 RID: 167525 RVA: 0x009B721D File Offset: 0x009B541D
		public unsafe int ResummonDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x06028E66 RID: 167526 RVA: 0x009B722E File Offset: 0x009B542E
		// (set) Token: 0x06028E67 RID: 167527 RVA: 0x009B723E File Offset: 0x009B543E
		public unsafe bool LockCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028E68 RID: 167528 RVA: 0x009B724F File Offset: 0x009B544F
		protected BP_SummonGongduolaConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014EA5 RID: 85669
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/SummonGongduola/BP_SummonGongduolaConfig.BP_SummonGongduolaConfig_C";

		// Token: 0x04014EA6 RID: 85670
		private static IntPtr _ClassPtr;

		// Token: 0x04014EA7 RID: 85671
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014EA8 RID: 85672
		internal static int __PropertyOffset_0;

		// Token: 0x04014EA9 RID: 85673
		internal static int __PropertyOffset_1;

		// Token: 0x04014EAA RID: 85674
		internal static int __PropertyOffset_2;

		// Token: 0x04014EAB RID: 85675
		internal static int __PropertyOffset_3;

		// Token: 0x04014EAC RID: 85676
		internal static int __PropertyOffset_4;

		// Token: 0x04014EAD RID: 85677
		internal static int __PropertyOffset_5;

		// Token: 0x04014EAE RID: 85678
		internal static int __PropertyOffset_6;

		// Token: 0x04014EAF RID: 85679
		internal static int __PropertyOffset_7;
	}
}
