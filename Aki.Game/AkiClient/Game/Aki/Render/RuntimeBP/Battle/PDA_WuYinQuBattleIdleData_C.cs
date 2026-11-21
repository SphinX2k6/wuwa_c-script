using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003142 RID: 12610
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleIdleData.PDA_WuYinQuBattleIdleData_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PDA_WuYinQuBattleIdleData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F02C RID: 127020 RVA: 0x00923F51 File Offset: 0x00922151
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WuYinQuBattleIdleData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleIdleData.PDA_WuYinQuBattleIdleData_C");
			}
			return PDA_WuYinQuBattleIdleData_C._ClassPtr;
		}

		// Token: 0x0601F02D RID: 127021 RVA: 0x00923F78 File Offset: 0x00922178
		public PDA_WuYinQuBattleIdleData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleIdleData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F02E RID: 127022 RVA: 0x00923FA0 File Offset: 0x009221A0
		[NullableContext(1)]
		public PDA_WuYinQuBattleIdleData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleIdleData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0601F02F RID: 127023 RVA: 0x00923FD3 File Offset: 0x009221D3
		// (set) Token: 0x0601F030 RID: 127024 RVA: 0x00923FE7 File Offset: 0x009221E7
		public unsafe UKuroWeatherDataAsset AtmosInnerData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_AtmosInnerData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_AtmosInnerData, value);
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0601F031 RID: 127025 RVA: 0x00923FFC File Offset: 0x009221FC
		// (set) Token: 0x0601F032 RID: 127026 RVA: 0x00924010 File Offset: 0x00922210
		public unsafe UKuroWeatherDataAsset AtmosOuterData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_AtmosOuterData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_AtmosOuterData, value);
			}
		}

		// Token: 0x0601F033 RID: 127027 RVA: 0x00924025 File Offset: 0x00922225
		protected PDA_WuYinQuBattleIdleData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010870 RID: 67696
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleIdleData.PDA_WuYinQuBattleIdleData_C";

		// Token: 0x04010871 RID: 67697
		private static IntPtr _ClassPtr;

		// Token: 0x04010872 RID: 67698
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010873 RID: 67699
		internal static int __PropertyOffset_AtmosInnerData;

		// Token: 0x04010874 RID: 67700
		internal static int __PropertyOffset_AtmosOuterData;
	}
}
