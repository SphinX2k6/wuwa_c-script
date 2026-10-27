using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x02003E3A RID: 15930
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleFightingData.PDA_WuYinQuBattleFightingData_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class PDA_WuYinQuBattleFightingData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028075 RID: 163957 RVA: 0x009A2401 File Offset: 0x009A0601
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WuYinQuBattleFightingData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleFightingData.PDA_WuYinQuBattleFightingData_C");
			}
			return PDA_WuYinQuBattleFightingData_C._ClassPtr;
		}

		// Token: 0x06028076 RID: 163958 RVA: 0x009A2428 File Offset: 0x009A0628
		public PDA_WuYinQuBattleFightingData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleFightingData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028077 RID: 163959 RVA: 0x009A2450 File Offset: 0x009A0650
		[NullableContext(1)]
		public PDA_WuYinQuBattleFightingData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WuYinQuBattleFightingData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B6C RID: 23404
		// (get) Token: 0x06028078 RID: 163960 RVA: 0x009A2483 File Offset: 0x009A0683
		// (set) Token: 0x06028079 RID: 163961 RVA: 0x009A2497 File Offset: 0x009A0697
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset AtmosFightingData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleFightingData_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_WuYinQuBattleFightingData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602807A RID: 163962 RVA: 0x009A24AC File Offset: 0x009A06AC
		protected PDA_WuYinQuBattleFightingData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014536 RID: 83254
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Battle/PDA_WuYinQuBattleFightingData.PDA_WuYinQuBattleFightingData_C";

		// Token: 0x04014537 RID: 83255
		private static IntPtr _ClassPtr;

		// Token: 0x04014538 RID: 83256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014539 RID: 83257
		internal static int __PropertyOffset_0;
	}
}
