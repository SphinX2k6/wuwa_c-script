using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003141 RID: 12609
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleFightingData.PDA_WuYinQuBattleFightingData_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class PDA_WuYinQuBattleFightingData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F026 RID: 127014 RVA: 0x00923EA0 File Offset: 0x009220A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WuYinQuBattleFightingData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleFightingData.PDA_WuYinQuBattleFightingData_C");
			}
			return PDA_WuYinQuBattleFightingData_C._ClassPtr;
		}

		// Token: 0x0601F027 RID: 127015 RVA: 0x00923EC4 File Offset: 0x009220C4
		public PDA_WuYinQuBattleFightingData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleFightingData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F028 RID: 127016 RVA: 0x00923EEC File Offset: 0x009220EC
		[NullableContext(1)]
		public PDA_WuYinQuBattleFightingData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleFightingData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0601F029 RID: 127017 RVA: 0x00923F1F File Offset: 0x0092211F
		// (set) Token: 0x0601F02A RID: 127018 RVA: 0x00923F33 File Offset: 0x00922133
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset AtmosFightingData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleFightingData_C.__PropertyOffset_AtmosFightingData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleFightingData_C.__PropertyOffset_AtmosFightingData, value);
			}
		}

		// Token: 0x0601F02B RID: 127019 RVA: 0x00923F48 File Offset: 0x00922148
		protected PDA_WuYinQuBattleFightingData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401086C RID: 67692
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleFightingData.PDA_WuYinQuBattleFightingData_C";

		// Token: 0x0401086D RID: 67693
		private static IntPtr _ClassPtr;

		// Token: 0x0401086E RID: 67694
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401086F RID: 67695
		internal static int __PropertyOffset_AtmosFightingData;
	}
}
