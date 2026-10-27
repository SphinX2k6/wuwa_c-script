using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.AIGearStrategy
{
	// Token: 0x02003FC1 RID: 16321
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/BP_AiGearStrategy.BP_AIGearStrategy_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 100)]
	public class BP_AIGearStrategy_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029CA1 RID: 171169 RVA: 0x009CC802 File Offset: 0x009CAA02
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AIGearStrategy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/AIGearStrategy/BP_AiGearStrategy.BP_AIGearStrategy_C");
			}
			return BP_AIGearStrategy_C._ClassPtr;
		}

		// Token: 0x06029CA2 RID: 171170 RVA: 0x009CC828 File Offset: 0x009CAA28
		public BP_AIGearStrategy_C() : this(BuiltinUtils.AllocNativeUObject(BP_AIGearStrategy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029CA3 RID: 171171 RVA: 0x009CC850 File Offset: 0x009CAA50
		[NullableContext(1)]
		public BP_AIGearStrategy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AIGearStrategy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006547 RID: 25927
		// (get) Token: 0x06029CA4 RID: 171172 RVA: 0x009CC883 File Offset: 0x009CAA83
		// (set) Token: 0x06029CA5 RID: 171173 RVA: 0x009CC893 File Offset: 0x009CAA93
		public unsafe float LostWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006548 RID: 25928
		// (get) Token: 0x06029CA6 RID: 171174 RVA: 0x009CC8A4 File Offset: 0x009CAAA4
		// (set) Token: 0x06029CA7 RID: 171175 RVA: 0x009CC8B4 File Offset: 0x009CAAB4
		public unsafe float RoundDecay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006549 RID: 25929
		// (get) Token: 0x06029CA8 RID: 171176 RVA: 0x009CC8C5 File Offset: 0x009CAAC5
		// (set) Token: 0x06029CA9 RID: 171177 RVA: 0x009CC8D5 File Offset: 0x009CAAD5
		public unsafe int IterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700654A RID: 25930
		// (get) Token: 0x06029CAA RID: 171178 RVA: 0x009CC8E6 File Offset: 0x009CAAE6
		// (set) Token: 0x06029CAB RID: 171179 RVA: 0x009CC8F6 File Offset: 0x009CAAF6
		public unsafe int PlayerIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700654B RID: 25931
		// (get) Token: 0x06029CAC RID: 171180 RVA: 0x009CC907 File Offset: 0x009CAB07
		// (set) Token: 0x06029CAD RID: 171181 RVA: 0x009CC917 File Offset: 0x009CAB17
		public unsafe float IterationDecay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06029CAE RID: 171182 RVA: 0x009CC928 File Offset: 0x009CAB28
		protected BP_AIGearStrategy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015756 RID: 87894
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/BP_AiGearStrategy.BP_AIGearStrategy_C";

		// Token: 0x04015757 RID: 87895
		private static IntPtr _ClassPtr;

		// Token: 0x04015758 RID: 87896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015759 RID: 87897
		internal static int __PropertyOffset_0;

		// Token: 0x0401575A RID: 87898
		internal static int __PropertyOffset_1;

		// Token: 0x0401575B RID: 87899
		internal static int __PropertyOffset_2;

		// Token: 0x0401575C RID: 87900
		internal static int __PropertyOffset_3;

		// Token: 0x0401575D RID: 87901
		internal static int __PropertyOffset_4;
	}
}
