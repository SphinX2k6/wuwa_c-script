using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.AIGearStrategy
{
	// Token: 0x02003246 RID: 12870
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/BP_AiGearStrategy.BP_AIGearStrategy_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 100)]
	public class BP_AIGearStrategy_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602028F RID: 131727 RVA: 0x0093EA65 File Offset: 0x0093CC65
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AIGearStrategy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/AIGearStrategy/BP_AiGearStrategy.BP_AIGearStrategy_C");
			}
			return BP_AIGearStrategy_C._ClassPtr;
		}

		// Token: 0x06020290 RID: 131728 RVA: 0x0093EA8C File Offset: 0x0093CC8C
		public BP_AIGearStrategy_C() : this(BuiltinUtils.AllocNativeUObject(BP_AIGearStrategy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020291 RID: 131729 RVA: 0x0093EAB4 File Offset: 0x0093CCB4
		[NullableContext(1)]
		public BP_AIGearStrategy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AIGearStrategy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x06020292 RID: 131730 RVA: 0x0093EAE7 File Offset: 0x0093CCE7
		// (set) Token: 0x06020293 RID: 131731 RVA: 0x0093EAF7 File Offset: 0x0093CCF7
		public unsafe float LostWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_LostWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_LostWeight) = value;
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x06020294 RID: 131732 RVA: 0x0093EB08 File Offset: 0x0093CD08
		// (set) Token: 0x06020295 RID: 131733 RVA: 0x0093EB18 File Offset: 0x0093CD18
		public unsafe float RoundDecay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_RoundDecay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_RoundDecay) = value;
			}
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x06020296 RID: 131734 RVA: 0x0093EB29 File Offset: 0x0093CD29
		// (set) Token: 0x06020297 RID: 131735 RVA: 0x0093EB39 File Offset: 0x0093CD39
		public unsafe int IterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_IterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_IterationCount) = value;
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x06020298 RID: 131736 RVA: 0x0093EB4A File Offset: 0x0093CD4A
		// (set) Token: 0x06020299 RID: 131737 RVA: 0x0093EB5A File Offset: 0x0093CD5A
		public unsafe int PlayerIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_PlayerIterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_PlayerIterationCount) = value;
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0602029A RID: 131738 RVA: 0x0093EB6B File Offset: 0x0093CD6B
		// (set) Token: 0x0602029B RID: 131739 RVA: 0x0093EB7B File Offset: 0x0093CD7B
		public unsafe float IterationDecay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_IterationDecay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AIGearStrategy_C.__PropertyOffset_IterationDecay) = value;
			}
		}

		// Token: 0x0602029C RID: 131740 RVA: 0x0093EB8C File Offset: 0x0093CD8C
		protected BP_AIGearStrategy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114E7 RID: 70887
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/BP_AiGearStrategy.BP_AIGearStrategy_C";

		// Token: 0x040114E8 RID: 70888
		private static IntPtr _ClassPtr;

		// Token: 0x040114E9 RID: 70889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114EA RID: 70890
		internal static int __PropertyOffset_LostWeight;

		// Token: 0x040114EB RID: 70891
		internal static int __PropertyOffset_RoundDecay;

		// Token: 0x040114EC RID: 70892
		internal static int __PropertyOffset_IterationCount;

		// Token: 0x040114ED RID: 70893
		internal static int __PropertyOffset_PlayerIterationCount;

		// Token: 0x040114EE RID: 70894
		internal static int __PropertyOffset_IterationDecay;
	}
}
