using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FEE RID: 16366
	[UnrealObjectPath("/Game/Aki/Core/Fight/BP_SceneBattleInteract.BP_SceneBattleInteract_C")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 220)]
	public class BP_SceneBattleInteract_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F22 RID: 171810 RVA: 0x009D1AC4 File Offset: 0x009CFCC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneBattleInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BP_SceneBattleInteract.BP_SceneBattleInteract_C");
			}
			return BP_SceneBattleInteract_C._ClassPtr;
		}

		// Token: 0x06029F23 RID: 171811 RVA: 0x009D1AE8 File Offset: 0x009CFCE8
		public BP_SceneBattleInteract_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneBattleInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029F24 RID: 171812 RVA: 0x009D1B10 File Offset: 0x009CFD10
		[NullableContext(1)]
		public BP_SceneBattleInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneBattleInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065E6 RID: 26086
		// (get) Token: 0x06029F25 RID: 171813 RVA: 0x009D1B43 File Offset: 0x009CFD43
		// (set) Token: 0x06029F26 RID: 171814 RVA: 0x009D1B53 File Offset: 0x009CFD53
		public unsafe int ShapeType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x06029F27 RID: 171815 RVA: 0x009D1B64 File Offset: 0x009CFD64
		// (set) Token: 0x06029F28 RID: 171816 RVA: 0x009D1B74 File Offset: 0x009CFD74
		public unsafe int WeaponType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x06029F29 RID: 171817 RVA: 0x009D1B85 File Offset: 0x009CFD85
		// (set) Token: 0x06029F2A RID: 171818 RVA: 0x009D1B95 File Offset: 0x009CFD95
		public unsafe float EffectRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x06029F2B RID: 171819 RVA: 0x009D1BA6 File Offset: 0x009CFDA6
		// (set) Token: 0x06029F2C RID: 171820 RVA: 0x009D1BB6 File Offset: 0x009CFDB6
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x06029F2D RID: 171821 RVA: 0x009D1BC7 File Offset: 0x009CFDC7
		// (set) Token: 0x06029F2E RID: 171822 RVA: 0x009D1BD7 File Offset: 0x009CFDD7
		public unsafe float CollisionHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170065EB RID: 26091
		// (get) Token: 0x06029F2F RID: 171823 RVA: 0x009D1BE8 File Offset: 0x009CFDE8
		// (set) Token: 0x06029F30 RID: 171824 RVA: 0x009D1BFC File Offset: 0x009CFDFC
		public unsafe FVectorDouble CollisionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170065EC RID: 26092
		// (get) Token: 0x06029F31 RID: 171825 RVA: 0x009D1C11 File Offset: 0x009CFE11
		// (set) Token: 0x06029F32 RID: 171826 RVA: 0x009D1C21 File Offset: 0x009CFE21
		public unsafe int Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170065ED RID: 26093
		// (get) Token: 0x06029F33 RID: 171827 RVA: 0x009D1C32 File Offset: 0x009CFE32
		// (set) Token: 0x06029F34 RID: 171828 RVA: 0x009D1C42 File Offset: 0x009CFE42
		public unsafe float RippleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170065EE RID: 26094
		// (get) Token: 0x06029F35 RID: 171829 RVA: 0x009D1C53 File Offset: 0x009CFE53
		// (set) Token: 0x06029F36 RID: 171830 RVA: 0x009D1C63 File Offset: 0x009CFE63
		public unsafe float RippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x06029F37 RID: 171831 RVA: 0x009D1C74 File Offset: 0x009CFE74
		// (set) Token: 0x06029F38 RID: 171832 RVA: 0x009D1C84 File Offset: 0x009CFE84
		public unsafe int RippleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x06029F39 RID: 171833 RVA: 0x009D1C95 File Offset: 0x009CFE95
		// (set) Token: 0x06029F3A RID: 171834 RVA: 0x009D1CA5 File Offset: 0x009CFEA5
		public unsafe float RippleDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x06029F3B RID: 171835 RVA: 0x009D1CB6 File Offset: 0x009CFEB6
		// (set) Token: 0x06029F3C RID: 171836 RVA: 0x009D1CCA File Offset: 0x009CFECA
		public unsafe TEnumAsByte<ESceneBattleInteractEntityType> EntityType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x06029F3D RID: 171837 RVA: 0x009D1CDF File Offset: 0x009CFEDF
		// (set) Token: 0x06029F3E RID: 171838 RVA: 0x009D1CEF File Offset: 0x009CFEEF
		public unsafe bool BreakEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065F3 RID: 26099
		// (get) Token: 0x06029F3F RID: 171839 RVA: 0x009D1D00 File Offset: 0x009CFF00
		// (set) Token: 0x06029F40 RID: 171840 RVA: 0x009D1D10 File Offset: 0x009CFF10
		public unsafe float BreakIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170065F4 RID: 26100
		// (get) Token: 0x06029F41 RID: 171841 RVA: 0x009D1D21 File Offset: 0x009CFF21
		// (set) Token: 0x06029F42 RID: 171842 RVA: 0x009D1D31 File Offset: 0x009CFF31
		public unsafe float BreakRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170065F5 RID: 26101
		// (get) Token: 0x06029F43 RID: 171843 RVA: 0x009D1D42 File Offset: 0x009CFF42
		// (set) Token: 0x06029F44 RID: 171844 RVA: 0x009D1D52 File Offset: 0x009CFF52
		public unsafe float RippleMinConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170065F6 RID: 26102
		// (get) Token: 0x06029F45 RID: 171845 RVA: 0x009D1D63 File Offset: 0x009CFF63
		// (set) Token: 0x06029F46 RID: 171846 RVA: 0x009D1D73 File Offset: 0x009CFF73
		public unsafe float RippleMaxConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170065F7 RID: 26103
		// (get) Token: 0x06029F47 RID: 171847 RVA: 0x009D1D84 File Offset: 0x009CFF84
		// (set) Token: 0x06029F48 RID: 171848 RVA: 0x009D1D94 File Offset: 0x009CFF94
		public unsafe bool SendWeaponEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065F8 RID: 26104
		// (get) Token: 0x06029F49 RID: 171849 RVA: 0x009D1DA5 File Offset: 0x009CFFA5
		// (set) Token: 0x06029F4A RID: 171850 RVA: 0x009D1DB5 File Offset: 0x009CFFB5
		public unsafe float ForceFieldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170065F9 RID: 26105
		// (get) Token: 0x06029F4B RID: 171851 RVA: 0x009D1DC6 File Offset: 0x009CFFC6
		// (set) Token: 0x06029F4C RID: 171852 RVA: 0x009D1DD6 File Offset: 0x009CFFD6
		public unsafe float RotationalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170065FA RID: 26106
		// (get) Token: 0x06029F4D RID: 171853 RVA: 0x009D1DE7 File Offset: 0x009CFFE7
		// (set) Token: 0x06029F4E RID: 171854 RVA: 0x009D1DF7 File Offset: 0x009CFFF7
		public unsafe float CentripetalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x06029F4F RID: 171855 RVA: 0x009D1E08 File Offset: 0x009D0008
		// (set) Token: 0x06029F50 RID: 171856 RVA: 0x009D1E1C File Offset: 0x009D001C
		public unsafe FVector DirectionalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170065FC RID: 26108
		// (get) Token: 0x06029F51 RID: 171857 RVA: 0x009D1E31 File Offset: 0x009D0031
		// (set) Token: 0x06029F52 RID: 171858 RVA: 0x009D1E41 File Offset: 0x009D0041
		public unsafe float NoiseForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170065FD RID: 26109
		// (get) Token: 0x06029F53 RID: 171859 RVA: 0x009D1E52 File Offset: 0x009D0052
		// (set) Token: 0x06029F54 RID: 171860 RVA: 0x009D1E62 File Offset: 0x009D0062
		public unsafe float WeaponRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170065FE RID: 26110
		// (get) Token: 0x06029F55 RID: 171861 RVA: 0x009D1E73 File Offset: 0x009D0073
		// (set) Token: 0x06029F56 RID: 171862 RVA: 0x009D1E87 File Offset: 0x009D0087
		public unsafe FVector WeaponOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x06029F57 RID: 171863 RVA: 0x009D1E9C File Offset: 0x009D009C
		// (set) Token: 0x06029F58 RID: 171864 RVA: 0x009D1EAC File Offset: 0x009D00AC
		public unsafe float SampleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x06029F59 RID: 171865 RVA: 0x009D1EBD File Offset: 0x009D00BD
		protected BP_SceneBattleInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158DD RID: 88285
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BP_SceneBattleInteract.BP_SceneBattleInteract_C";

		// Token: 0x040158DE RID: 88286
		private static IntPtr _ClassPtr;

		// Token: 0x040158DF RID: 88287
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040158E0 RID: 88288
		internal static int __PropertyOffset_0;

		// Token: 0x040158E1 RID: 88289
		internal static int __PropertyOffset_1;

		// Token: 0x040158E2 RID: 88290
		internal static int __PropertyOffset_2;

		// Token: 0x040158E3 RID: 88291
		internal static int __PropertyOffset_3;

		// Token: 0x040158E4 RID: 88292
		internal static int __PropertyOffset_4;

		// Token: 0x040158E5 RID: 88293
		internal static int __PropertyOffset_5;

		// Token: 0x040158E6 RID: 88294
		internal static int __PropertyOffset_6;

		// Token: 0x040158E7 RID: 88295
		internal static int __PropertyOffset_7;

		// Token: 0x040158E8 RID: 88296
		internal static int __PropertyOffset_8;

		// Token: 0x040158E9 RID: 88297
		internal static int __PropertyOffset_9;

		// Token: 0x040158EA RID: 88298
		internal static int __PropertyOffset_10;

		// Token: 0x040158EB RID: 88299
		internal static int __PropertyOffset_11;

		// Token: 0x040158EC RID: 88300
		internal static int __PropertyOffset_12;

		// Token: 0x040158ED RID: 88301
		internal static int __PropertyOffset_13;

		// Token: 0x040158EE RID: 88302
		internal static int __PropertyOffset_14;

		// Token: 0x040158EF RID: 88303
		internal static int __PropertyOffset_15;

		// Token: 0x040158F0 RID: 88304
		internal static int __PropertyOffset_16;

		// Token: 0x040158F1 RID: 88305
		internal static int __PropertyOffset_17;

		// Token: 0x040158F2 RID: 88306
		internal static int __PropertyOffset_18;

		// Token: 0x040158F3 RID: 88307
		internal static int __PropertyOffset_19;

		// Token: 0x040158F4 RID: 88308
		internal static int __PropertyOffset_20;

		// Token: 0x040158F5 RID: 88309
		internal static int __PropertyOffset_21;

		// Token: 0x040158F6 RID: 88310
		internal static int __PropertyOffset_22;

		// Token: 0x040158F7 RID: 88311
		internal static int __PropertyOffset_23;

		// Token: 0x040158F8 RID: 88312
		internal static int __PropertyOffset_24;

		// Token: 0x040158F9 RID: 88313
		internal static int __PropertyOffset_25;
	}
}
