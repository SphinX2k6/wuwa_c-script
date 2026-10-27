using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003E39 RID: 15929
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleData.PDA_WuYinQuBattleData_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class PDA_WuYinQuBattleData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602804F RID: 163919 RVA: 0x009A20E8 File Offset: 0x009A02E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WuYinQuBattleData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleData.PDA_WuYinQuBattleData_C");
			}
			return PDA_WuYinQuBattleData_C._ClassPtr;
		}

		// Token: 0x06028050 RID: 163920 RVA: 0x009A210C File Offset: 0x009A030C
		public PDA_WuYinQuBattleData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028051 RID: 163921 RVA: 0x009A2134 File Offset: 0x009A0334
		[NullableContext(1)]
		public PDA_WuYinQuBattleData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x06028052 RID: 163922 RVA: 0x009A2167 File Offset: 0x009A0367
		// (set) Token: 0x06028053 RID: 163923 RVA: 0x009A2177 File Offset: 0x009A0377
		public unsafe float IdleToFightingTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005B5C RID: 23388
		// (get) Token: 0x06028054 RID: 163924 RVA: 0x009A2188 File Offset: 0x009A0388
		// (set) Token: 0x06028055 RID: 163925 RVA: 0x009A2198 File Offset: 0x009A0398
		public unsafe float FightingTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005B5D RID: 23389
		// (get) Token: 0x06028056 RID: 163926 RVA: 0x009A21A9 File Offset: 0x009A03A9
		// (set) Token: 0x06028057 RID: 163927 RVA: 0x009A21B9 File Offset: 0x009A03B9
		public unsafe float FightingToIdleTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005B5E RID: 23390
		// (get) Token: 0x06028058 RID: 163928 RVA: 0x009A21CA File Offset: 0x009A03CA
		// (set) Token: 0x06028059 RID: 163929 RVA: 0x009A21DE File Offset: 0x009A03DE
		public unsafe UCurveFloat IdleToFightingCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005B5F RID: 23391
		// (get) Token: 0x0602805A RID: 163930 RVA: 0x009A21F3 File Offset: 0x009A03F3
		// (set) Token: 0x0602805B RID: 163931 RVA: 0x009A2207 File Offset: 0x009A0407
		public unsafe UCurveFloat FightingTransitionCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005B60 RID: 23392
		// (get) Token: 0x0602805C RID: 163932 RVA: 0x009A221C File Offset: 0x009A041C
		// (set) Token: 0x0602805D RID: 163933 RVA: 0x009A2230 File Offset: 0x009A0430
		public unsafe UCurveFloat FightingToIdleCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005B61 RID: 23393
		// (get) Token: 0x0602805E RID: 163934 RVA: 0x009A2245 File Offset: 0x009A0445
		// (set) Token: 0x0602805F RID: 163935 RVA: 0x009A2259 File Offset: 0x009A0459
		public unsafe PDA_WuYinQuBattleIdleData_C WuYinQuIdleData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleIdleData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005B62 RID: 23394
		// (get) Token: 0x06028060 RID: 163936 RVA: 0x009A226E File Offset: 0x009A046E
		// (set) Token: 0x06028061 RID: 163937 RVA: 0x009A2282 File Offset: 0x009A0482
		public unsafe PDA_WuYinQuBattleFightingData_C WuYinQuFightingData1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleFightingData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005B63 RID: 23395
		// (get) Token: 0x06028062 RID: 163938 RVA: 0x009A2297 File Offset: 0x009A0497
		// (set) Token: 0x06028063 RID: 163939 RVA: 0x009A22AB File Offset: 0x009A04AB
		public unsafe PDA_WuYinQuBattleFightingData_C WuYinQuFightingData2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleFightingData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005B64 RID: 23396
		// (get) Token: 0x06028064 RID: 163940 RVA: 0x009A22C0 File Offset: 0x009A04C0
		// (set) Token: 0x06028065 RID: 163941 RVA: 0x009A22D4 File Offset: 0x009A04D4
		public unsafe PDA_WuYinQuBattleFightingData_C WuYinQuFightingData3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleFightingData_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005B65 RID: 23397
		// (get) Token: 0x06028066 RID: 163942 RVA: 0x009A22E9 File Offset: 0x009A04E9
		// (set) Token: 0x06028067 RID: 163943 RVA: 0x009A22FD File Offset: 0x009A04FD
		[Nullable(0)]
		public unsafe TEnumAsByte<EWuYinQuState> test
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005B66 RID: 23398
		// (get) Token: 0x06028068 RID: 163944 RVA: 0x009A2312 File Offset: 0x009A0512
		// (set) Token: 0x06028069 RID: 163945 RVA: 0x009A2326 File Offset: 0x009A0526
		public unsafe UMaterialParameterCollection GlobalMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005B67 RID: 23399
		// (get) Token: 0x0602806A RID: 163946 RVA: 0x009A233B File Offset: 0x009A053B
		// (set) Token: 0x0602806B RID: 163947 RVA: 0x009A234F File Offset: 0x009A054F
		public unsafe UCurveFloat LandscapeShowingRadiusCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005B68 RID: 23400
		// (get) Token: 0x0602806C RID: 163948 RVA: 0x009A2364 File Offset: 0x009A0564
		// (set) Token: 0x0602806D RID: 163949 RVA: 0x009A2378 File Offset: 0x009A0578
		public unsafe UCurveFloat LandscapeFadingRadiusCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005B69 RID: 23401
		// (get) Token: 0x0602806E RID: 163950 RVA: 0x009A238D File Offset: 0x009A058D
		// (set) Token: 0x0602806F RID: 163951 RVA: 0x009A23A1 File Offset: 0x009A05A1
		public unsafe PDA_InteractionGlobalConfigParameters_C GlobalInteractionParameterOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_InteractionGlobalConfigParameters_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleData_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x06028070 RID: 163952 RVA: 0x009A23B6 File Offset: 0x009A05B6
		// (set) Token: 0x06028071 RID: 163953 RVA: 0x009A23C6 File Offset: 0x009A05C6
		public unsafe float TriggerOuterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005B6B RID: 23403
		// (get) Token: 0x06028072 RID: 163954 RVA: 0x009A23D7 File Offset: 0x009A05D7
		// (set) Token: 0x06028073 RID: 163955 RVA: 0x009A23E7 File Offset: 0x009A05E7
		public unsafe float TriggerInnerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WuYinQuBattleData_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06028074 RID: 163956 RVA: 0x009A23F8 File Offset: 0x009A05F8
		protected PDA_WuYinQuBattleData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014522 RID: 83234
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleData.PDA_WuYinQuBattleData_C";

		// Token: 0x04014523 RID: 83235
		private static IntPtr _ClassPtr;

		// Token: 0x04014524 RID: 83236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014525 RID: 83237
		internal static int __PropertyOffset_0;

		// Token: 0x04014526 RID: 83238
		internal static int __PropertyOffset_1;

		// Token: 0x04014527 RID: 83239
		internal static int __PropertyOffset_2;

		// Token: 0x04014528 RID: 83240
		internal static int __PropertyOffset_3;

		// Token: 0x04014529 RID: 83241
		internal static int __PropertyOffset_4;

		// Token: 0x0401452A RID: 83242
		internal static int __PropertyOffset_5;

		// Token: 0x0401452B RID: 83243
		internal static int __PropertyOffset_6;

		// Token: 0x0401452C RID: 83244
		internal static int __PropertyOffset_7;

		// Token: 0x0401452D RID: 83245
		internal static int __PropertyOffset_8;

		// Token: 0x0401452E RID: 83246
		internal static int __PropertyOffset_9;

		// Token: 0x0401452F RID: 83247
		internal static int __PropertyOffset_10;

		// Token: 0x04014530 RID: 83248
		internal static int __PropertyOffset_11;

		// Token: 0x04014531 RID: 83249
		internal static int __PropertyOffset_12;

		// Token: 0x04014532 RID: 83250
		internal static int __PropertyOffset_13;

		// Token: 0x04014533 RID: 83251
		internal static int __PropertyOffset_14;

		// Token: 0x04014534 RID: 83252
		internal static int __PropertyOffset_15;

		// Token: 0x04014535 RID: 83253
		internal static int __PropertyOffset_16;
	}
}
