using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003E3B RID: 15931
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleIdleData.PDA_WuYinQuBattleIdleData_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PDA_WuYinQuBattleIdleData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602807B RID: 163963 RVA: 0x009A24B5 File Offset: 0x009A06B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WuYinQuBattleIdleData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleIdleData.PDA_WuYinQuBattleIdleData_C");
			}
			return PDA_WuYinQuBattleIdleData_C._ClassPtr;
		}

		// Token: 0x0602807C RID: 163964 RVA: 0x009A24DC File Offset: 0x009A06DC
		public PDA_WuYinQuBattleIdleData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleIdleData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602807D RID: 163965 RVA: 0x009A2504 File Offset: 0x009A0704
		[NullableContext(1)]
		public PDA_WuYinQuBattleIdleData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleIdleData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B6D RID: 23405
		// (get) Token: 0x0602807E RID: 163966 RVA: 0x009A2537 File Offset: 0x009A0737
		// (set) Token: 0x0602807F RID: 163967 RVA: 0x009A254B File Offset: 0x009A074B
		public unsafe UKuroWeatherDataAsset AtmosInnerData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005B6E RID: 23406
		// (get) Token: 0x06028080 RID: 163968 RVA: 0x009A2560 File Offset: 0x009A0760
		// (set) Token: 0x06028081 RID: 163969 RVA: 0x009A2574 File Offset: 0x009A0774
		public unsafe UKuroWeatherDataAsset AtmosOuterData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleIdleData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06028082 RID: 163970 RVA: 0x009A2589 File Offset: 0x009A0789
		protected PDA_WuYinQuBattleIdleData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401453A RID: 83258
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleIdleData.PDA_WuYinQuBattleIdleData_C";

		// Token: 0x0401453B RID: 83259
		private static IntPtr _ClassPtr;

		// Token: 0x0401453C RID: 83260
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401453D RID: 83261
		internal static int __PropertyOffset_0;

		// Token: 0x0401453E RID: 83262
		internal static int __PropertyOffset_1;
	}
}
