using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003140 RID: 12608
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleData.PDA_WuYinQuBattleData_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class PDA_WuYinQuBattleData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F002 RID: 126978 RVA: 0x00923BB0 File Offset: 0x00921DB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WuYinQuBattleData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleData.PDA_WuYinQuBattleData_C");
			}
			return PDA_WuYinQuBattleData_C._ClassPtr;
		}

		// Token: 0x0601F003 RID: 126979 RVA: 0x00923BD4 File Offset: 0x00921DD4
		public PDA_WuYinQuBattleData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F004 RID: 126980 RVA: 0x00923BFC File Offset: 0x00921DFC
		[NullableContext(1)]
		public PDA_WuYinQuBattleData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0601F005 RID: 126981 RVA: 0x00923C2F File Offset: 0x00921E2F
		// (set) Token: 0x0601F006 RID: 126982 RVA: 0x00923C3F File Offset: 0x00921E3F
		public unsafe float IdleToFightingTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_IdleToFightingTransitionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_IdleToFightingTransitionTime) = value;
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0601F007 RID: 126983 RVA: 0x00923C50 File Offset: 0x00921E50
		// (set) Token: 0x0601F008 RID: 126984 RVA: 0x00923C60 File Offset: 0x00921E60
		public unsafe float FightingTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_FightingTransitionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_FightingTransitionTime) = value;
			}
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0601F009 RID: 126985 RVA: 0x00923C71 File Offset: 0x00921E71
		// (set) Token: 0x0601F00A RID: 126986 RVA: 0x00923C81 File Offset: 0x00921E81
		public unsafe float FightingToIdleTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_FightingToIdleTransitionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_FightingToIdleTransitionTime) = value;
			}
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0601F00B RID: 126987 RVA: 0x00923C92 File Offset: 0x00921E92
		// (set) Token: 0x0601F00C RID: 126988 RVA: 0x00923CA6 File Offset: 0x00921EA6
		public unsafe UCurveFloat IdleToFightingCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_IdleToFightingCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_IdleToFightingCurve, value);
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0601F00D RID: 126989 RVA: 0x00923CBB File Offset: 0x00921EBB
		// (set) Token: 0x0601F00E RID: 126990 RVA: 0x00923CCF File Offset: 0x00921ECF
		public unsafe UCurveFloat FightingTransitionCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_FightingTransitionCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_FightingTransitionCurve, value);
			}
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0601F00F RID: 126991 RVA: 0x00923CE4 File Offset: 0x00921EE4
		// (set) Token: 0x0601F010 RID: 126992 RVA: 0x00923CF8 File Offset: 0x00921EF8
		public unsafe UCurveFloat FightingToIdleCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_FightingToIdleCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_FightingToIdleCurve, value);
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0601F011 RID: 126993 RVA: 0x00923D0D File Offset: 0x00921F0D
		// (set) Token: 0x0601F012 RID: 126994 RVA: 0x00923D21 File Offset: 0x00921F21
		public unsafe PDA_WuYinQuBattleIdleData_C WuYinQuIdleData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleIdleData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuIdleData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuIdleData, value);
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0601F013 RID: 126995 RVA: 0x00923D36 File Offset: 0x00921F36
		// (set) Token: 0x0601F014 RID: 126996 RVA: 0x00923D4A File Offset: 0x00921F4A
		public unsafe PDA_WuYinQuBattleFightingData_C WuYinQuFightingData1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleFightingData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuFightingData1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuFightingData1, value);
			}
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0601F015 RID: 126997 RVA: 0x00923D5F File Offset: 0x00921F5F
		// (set) Token: 0x0601F016 RID: 126998 RVA: 0x00923D73 File Offset: 0x00921F73
		public unsafe PDA_WuYinQuBattleFightingData_C WuYinQuFightingData2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleFightingData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuFightingData2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuFightingData2, value);
			}
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0601F017 RID: 126999 RVA: 0x00923D88 File Offset: 0x00921F88
		// (set) Token: 0x0601F018 RID: 127000 RVA: 0x00923D9C File Offset: 0x00921F9C
		public unsafe PDA_WuYinQuBattleFightingData_C WuYinQuFightingData3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleFightingData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuFightingData3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_WuYinQuFightingData3, value);
			}
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0601F019 RID: 127001 RVA: 0x00923DB1 File Offset: 0x00921FB1
		// (set) Token: 0x0601F01A RID: 127002 RVA: 0x00923DC5 File Offset: 0x00921FC5
		[Nullable(0)]
		public unsafe TEnumAsByte<EWuYinQuState> test
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_test);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_test) = value;
			}
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0601F01B RID: 127003 RVA: 0x00923DDA File Offset: 0x00921FDA
		// (set) Token: 0x0601F01C RID: 127004 RVA: 0x00923DEE File Offset: 0x00921FEE
		public unsafe UMaterialParameterCollection GlobalMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_GlobalMPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_GlobalMPC, value);
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0601F01D RID: 127005 RVA: 0x00923E03 File Offset: 0x00922003
		// (set) Token: 0x0601F01E RID: 127006 RVA: 0x00923E17 File Offset: 0x00922017
		public unsafe UCurveFloat LandscapeShowingRadiusCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_LandscapeShowingRadiusCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_LandscapeShowingRadiusCurve, value);
			}
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0601F01F RID: 127007 RVA: 0x00923E2C File Offset: 0x0092202C
		// (set) Token: 0x0601F020 RID: 127008 RVA: 0x00923E40 File Offset: 0x00922040
		public unsafe UCurveFloat LandscapeFadingRadiusCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_LandscapeFadingRadiusCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_LandscapeFadingRadiusCurve, value);
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0601F021 RID: 127009 RVA: 0x00923E55 File Offset: 0x00922055
		// (set) Token: 0x0601F022 RID: 127010 RVA: 0x00923E65 File Offset: 0x00922065
		public unsafe float TriggerOuterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_TriggerOuterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_TriggerOuterSize) = value;
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0601F023 RID: 127011 RVA: 0x00923E76 File Offset: 0x00922076
		// (set) Token: 0x0601F024 RID: 127012 RVA: 0x00923E86 File Offset: 0x00922086
		public unsafe float TriggerInnerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_TriggerInnerSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_TriggerInnerSize) = value;
			}
		}

		// Token: 0x0601F025 RID: 127013 RVA: 0x00923E97 File Offset: 0x00922097
		protected PDA_WuYinQuBattleData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010859 RID: 67673
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleData.PDA_WuYinQuBattleData_C";

		// Token: 0x0401085A RID: 67674
		private static IntPtr _ClassPtr;

		// Token: 0x0401085B RID: 67675
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401085C RID: 67676
		internal static int __PropertyOffset_IdleToFightingTransitionTime;

		// Token: 0x0401085D RID: 67677
		internal static int __PropertyOffset_FightingTransitionTime;

		// Token: 0x0401085E RID: 67678
		internal static int __PropertyOffset_FightingToIdleTransitionTime;

		// Token: 0x0401085F RID: 67679
		internal static int __PropertyOffset_IdleToFightingCurve;

		// Token: 0x04010860 RID: 67680
		internal static int __PropertyOffset_FightingTransitionCurve;

		// Token: 0x04010861 RID: 67681
		internal static int __PropertyOffset_FightingToIdleCurve;

		// Token: 0x04010862 RID: 67682
		internal static int __PropertyOffset_WuYinQuIdleData;

		// Token: 0x04010863 RID: 67683
		internal static int __PropertyOffset_WuYinQuFightingData1;

		// Token: 0x04010864 RID: 67684
		internal static int __PropertyOffset_WuYinQuFightingData2;

		// Token: 0x04010865 RID: 67685
		internal static int __PropertyOffset_WuYinQuFightingData3;

		// Token: 0x04010866 RID: 67686
		internal static int __PropertyOffset_test;

		// Token: 0x04010867 RID: 67687
		internal static int __PropertyOffset_GlobalMPC;

		// Token: 0x04010868 RID: 67688
		internal static int __PropertyOffset_LandscapeShowingRadiusCurve;

		// Token: 0x04010869 RID: 67689
		internal static int __PropertyOffset_LandscapeFadingRadiusCurve;

		// Token: 0x0401086A RID: 67690
		internal static int __PropertyOffset_TriggerOuterSize;

		// Token: 0x0401086B RID: 67691
		internal static int __PropertyOffset_TriggerInnerSize;
	}
}
