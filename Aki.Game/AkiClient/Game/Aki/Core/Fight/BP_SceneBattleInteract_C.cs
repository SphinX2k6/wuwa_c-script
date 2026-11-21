using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003256 RID: 12886
	[UnrealObjectPath("/Game/Aki/Core/Fight/BP_SceneBattleInteract.BP_SceneBattleInteract_C")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 220)]
	public class BP_SceneBattleInteract_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602030B RID: 131851 RVA: 0x0093FC58 File Offset: 0x0093DE58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneBattleInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BP_SceneBattleInteract.BP_SceneBattleInteract_C");
			}
			return BP_SceneBattleInteract_C._ClassPtr;
		}

		// Token: 0x0602030C RID: 131852 RVA: 0x0093FC7C File Offset: 0x0093DE7C
		public BP_SceneBattleInteract_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneBattleInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602030D RID: 131853 RVA: 0x0093FCA4 File Offset: 0x0093DEA4
		[NullableContext(1)]
		public BP_SceneBattleInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneBattleInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0602030E RID: 131854 RVA: 0x0093FCD7 File Offset: 0x0093DED7
		// (set) Token: 0x0602030F RID: 131855 RVA: 0x0093FCE7 File Offset: 0x0093DEE7
		public unsafe int ShapeType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_ShapeType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_ShapeType) = value;
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x06020310 RID: 131856 RVA: 0x0093FCF8 File Offset: 0x0093DEF8
		// (set) Token: 0x06020311 RID: 131857 RVA: 0x0093FD08 File Offset: 0x0093DF08
		public unsafe int WeaponType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_WeaponType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_WeaponType) = value;
			}
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x06020312 RID: 131858 RVA: 0x0093FD19 File Offset: 0x0093DF19
		// (set) Token: 0x06020313 RID: 131859 RVA: 0x0093FD29 File Offset: 0x0093DF29
		public unsafe float EffectRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_EffectRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_EffectRadius) = value;
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x06020314 RID: 131860 RVA: 0x0093FD3A File Offset: 0x0093DF3A
		// (set) Token: 0x06020315 RID: 131861 RVA: 0x0093FD4A File Offset: 0x0093DF4A
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CollisionRadius) = value;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x06020316 RID: 131862 RVA: 0x0093FD5B File Offset: 0x0093DF5B
		// (set) Token: 0x06020317 RID: 131863 RVA: 0x0093FD6B File Offset: 0x0093DF6B
		public unsafe float CollisionHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CollisionHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CollisionHalfHeight) = value;
			}
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x06020318 RID: 131864 RVA: 0x0093FD7C File Offset: 0x0093DF7C
		// (set) Token: 0x06020319 RID: 131865 RVA: 0x0093FD90 File Offset: 0x0093DF90
		public unsafe FVectorDouble CollisionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CollisionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CollisionOffset) = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0602031A RID: 131866 RVA: 0x0093FDA5 File Offset: 0x0093DFA5
		// (set) Token: 0x0602031B RID: 131867 RVA: 0x0093FDB5 File Offset: 0x0093DFB5
		public unsafe int Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0602031C RID: 131868 RVA: 0x0093FDC6 File Offset: 0x0093DFC6
		// (set) Token: 0x0602031D RID: 131869 RVA: 0x0093FDD6 File Offset: 0x0093DFD6
		public unsafe float RippleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleRadius) = value;
			}
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0602031E RID: 131870 RVA: 0x0093FDE7 File Offset: 0x0093DFE7
		// (set) Token: 0x0602031F RID: 131871 RVA: 0x0093FDF7 File Offset: 0x0093DFF7
		public unsafe float RippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleIntensity) = value;
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x06020320 RID: 131872 RVA: 0x0093FE08 File Offset: 0x0093E008
		// (set) Token: 0x06020321 RID: 131873 RVA: 0x0093FE18 File Offset: 0x0093E018
		public unsafe int RippleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleType) = value;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x06020322 RID: 131874 RVA: 0x0093FE29 File Offset: 0x0093E029
		// (set) Token: 0x06020323 RID: 131875 RVA: 0x0093FE39 File Offset: 0x0093E039
		public unsafe float RippleDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleDensity) = value;
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x06020324 RID: 131876 RVA: 0x0093FE4A File Offset: 0x0093E04A
		// (set) Token: 0x06020325 RID: 131877 RVA: 0x0093FE5E File Offset: 0x0093E05E
		public unsafe TEnumAsByte<ESceneBattleInteractEntityType> EntityType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_EntityType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_EntityType) = value;
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x06020326 RID: 131878 RVA: 0x0093FE73 File Offset: 0x0093E073
		// (set) Token: 0x06020327 RID: 131879 RVA: 0x0093FE83 File Offset: 0x0093E083
		public unsafe bool BreakEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_BreakEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_BreakEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x06020328 RID: 131880 RVA: 0x0093FE94 File Offset: 0x0093E094
		// (set) Token: 0x06020329 RID: 131881 RVA: 0x0093FEA4 File Offset: 0x0093E0A4
		public unsafe float BreakIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_BreakIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_BreakIntensity) = value;
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0602032A RID: 131882 RVA: 0x0093FEB5 File Offset: 0x0093E0B5
		// (set) Token: 0x0602032B RID: 131883 RVA: 0x0093FEC5 File Offset: 0x0093E0C5
		public unsafe float BreakRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_BreakRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_BreakRadius) = value;
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0602032C RID: 131884 RVA: 0x0093FED6 File Offset: 0x0093E0D6
		// (set) Token: 0x0602032D RID: 131885 RVA: 0x0093FEE6 File Offset: 0x0093E0E6
		public unsafe float RippleMinConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleMinConnectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleMinConnectDistance) = value;
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0602032E RID: 131886 RVA: 0x0093FEF7 File Offset: 0x0093E0F7
		// (set) Token: 0x0602032F RID: 131887 RVA: 0x0093FF07 File Offset: 0x0093E107
		public unsafe float RippleMaxConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleMaxConnectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RippleMaxConnectDistance) = value;
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x06020330 RID: 131888 RVA: 0x0093FF18 File Offset: 0x0093E118
		// (set) Token: 0x06020331 RID: 131889 RVA: 0x0093FF28 File Offset: 0x0093E128
		public unsafe bool SendWeaponEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_SendWeaponEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_SendWeaponEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x06020332 RID: 131890 RVA: 0x0093FF39 File Offset: 0x0093E139
		// (set) Token: 0x06020333 RID: 131891 RVA: 0x0093FF49 File Offset: 0x0093E149
		public unsafe float ForceFieldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_ForceFieldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_ForceFieldRadius) = value;
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x06020334 RID: 131892 RVA: 0x0093FF5A File Offset: 0x0093E15A
		// (set) Token: 0x06020335 RID: 131893 RVA: 0x0093FF6A File Offset: 0x0093E16A
		public unsafe float RotationalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RotationalForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_RotationalForceField) = value;
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x06020336 RID: 131894 RVA: 0x0093FF7B File Offset: 0x0093E17B
		// (set) Token: 0x06020337 RID: 131895 RVA: 0x0093FF8B File Offset: 0x0093E18B
		public unsafe float CentripetalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CentripetalForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_CentripetalForceField) = value;
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x06020338 RID: 131896 RVA: 0x0093FF9C File Offset: 0x0093E19C
		// (set) Token: 0x06020339 RID: 131897 RVA: 0x0093FFB0 File Offset: 0x0093E1B0
		public unsafe FVector DirectionalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_DirectionalForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_DirectionalForceField) = value;
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0602033A RID: 131898 RVA: 0x0093FFC5 File Offset: 0x0093E1C5
		// (set) Token: 0x0602033B RID: 131899 RVA: 0x0093FFD5 File Offset: 0x0093E1D5
		public unsafe float NoiseForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_NoiseForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_NoiseForceField) = value;
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0602033C RID: 131900 RVA: 0x0093FFE6 File Offset: 0x0093E1E6
		// (set) Token: 0x0602033D RID: 131901 RVA: 0x0093FFF6 File Offset: 0x0093E1F6
		public unsafe float WeaponRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_WeaponRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_WeaponRadius) = value;
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0602033E RID: 131902 RVA: 0x00940007 File Offset: 0x0093E207
		// (set) Token: 0x0602033F RID: 131903 RVA: 0x0094001B File Offset: 0x0093E21B
		public unsafe FVector WeaponOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_WeaponOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_WeaponOffset) = value;
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x06020340 RID: 131904 RVA: 0x00940030 File Offset: 0x0093E230
		// (set) Token: 0x06020341 RID: 131905 RVA: 0x00940040 File Offset: 0x0093E240
		public unsafe float SampleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_SampleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneBattleInteract_C.__PropertyOffset_SampleIntensity) = value;
			}
		}

		// Token: 0x06020342 RID: 131906 RVA: 0x00940051 File Offset: 0x0093E251
		protected BP_SceneBattleInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011552 RID: 70994
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BP_SceneBattleInteract.BP_SceneBattleInteract_C";

		// Token: 0x04011553 RID: 70995
		private static IntPtr _ClassPtr;

		// Token: 0x04011554 RID: 70996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011555 RID: 70997
		internal static int __PropertyOffset_ShapeType;

		// Token: 0x04011556 RID: 70998
		internal static int __PropertyOffset_WeaponType;

		// Token: 0x04011557 RID: 70999
		internal static int __PropertyOffset_EffectRadius;

		// Token: 0x04011558 RID: 71000
		internal static int __PropertyOffset_CollisionRadius;

		// Token: 0x04011559 RID: 71001
		internal static int __PropertyOffset_CollisionHalfHeight;

		// Token: 0x0401155A RID: 71002
		internal static int __PropertyOffset_CollisionOffset;

		// Token: 0x0401155B RID: 71003
		internal static int __PropertyOffset_Interval;

		// Token: 0x0401155C RID: 71004
		internal static int __PropertyOffset_RippleRadius;

		// Token: 0x0401155D RID: 71005
		internal static int __PropertyOffset_RippleIntensity;

		// Token: 0x0401155E RID: 71006
		internal static int __PropertyOffset_RippleType;

		// Token: 0x0401155F RID: 71007
		internal static int __PropertyOffset_RippleDensity;

		// Token: 0x04011560 RID: 71008
		internal static int __PropertyOffset_EntityType;

		// Token: 0x04011561 RID: 71009
		internal static int __PropertyOffset_BreakEvent;

		// Token: 0x04011562 RID: 71010
		internal static int __PropertyOffset_BreakIntensity;

		// Token: 0x04011563 RID: 71011
		internal static int __PropertyOffset_BreakRadius;

		// Token: 0x04011564 RID: 71012
		internal static int __PropertyOffset_RippleMinConnectDistance;

		// Token: 0x04011565 RID: 71013
		internal static int __PropertyOffset_RippleMaxConnectDistance;

		// Token: 0x04011566 RID: 71014
		internal static int __PropertyOffset_SendWeaponEvent;

		// Token: 0x04011567 RID: 71015
		internal static int __PropertyOffset_ForceFieldRadius;

		// Token: 0x04011568 RID: 71016
		internal static int __PropertyOffset_RotationalForceField;

		// Token: 0x04011569 RID: 71017
		internal static int __PropertyOffset_CentripetalForceField;

		// Token: 0x0401156A RID: 71018
		internal static int __PropertyOffset_DirectionalForceField;

		// Token: 0x0401156B RID: 71019
		internal static int __PropertyOffset_NoiseForceField;

		// Token: 0x0401156C RID: 71020
		internal static int __PropertyOffset_WeaponRadius;

		// Token: 0x0401156D RID: 71021
		internal static int __PropertyOffset_WeaponOffset;

		// Token: 0x0401156E RID: 71022
		internal static int __PropertyOffset_SampleIntensity;
	}
}
