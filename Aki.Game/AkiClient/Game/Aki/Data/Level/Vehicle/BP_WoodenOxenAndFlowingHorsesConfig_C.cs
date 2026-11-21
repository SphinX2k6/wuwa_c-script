using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x020031BA RID: 12730
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_WoodenOxenAndFlowingHorsesConfig.BP_WoodenOxenAndFlowingHorsesConfig_C")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 764)]
	public class BP_WoodenOxenAndFlowingHorsesConfig_C : BP_VehicleConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7A1 RID: 128929 RVA: 0x0092EA20 File Offset: 0x0092CC20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WoodenOxenAndFlowingHorsesConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_WoodenOxenAndFlowingHorsesConfig.BP_WoodenOxenAndFlowingHorsesConfig_C");
			}
			return BP_WoodenOxenAndFlowingHorsesConfig_C._ClassPtr;
		}

		// Token: 0x0601F7A2 RID: 128930 RVA: 0x0092EA44 File Offset: 0x0092CC44
		public BP_WoodenOxenAndFlowingHorsesConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_WoodenOxenAndFlowingHorsesConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7A3 RID: 128931 RVA: 0x0092EA6C File Offset: 0x0092CC6C
		[NullableContext(1)]
		public BP_WoodenOxenAndFlowingHorsesConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WoodenOxenAndFlowingHorsesConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0601F7A4 RID: 128932 RVA: 0x0092EA9F File Offset: 0x0092CC9F
		// (set) Token: 0x0601F7A5 RID: 128933 RVA: 0x0092EAAF File Offset: 0x0092CCAF
		public unsafe float ObstacleHalfLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_ObstacleHalfLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_ObstacleHalfLength) = value;
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0601F7A6 RID: 128934 RVA: 0x0092EAC0 File Offset: 0x0092CCC0
		// (set) Token: 0x0601F7A7 RID: 128935 RVA: 0x0092EAD0 File Offset: 0x0092CCD0
		public unsafe float ObstacleHalfWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_ObstacleHalfWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_ObstacleHalfWidth) = value;
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0601F7A8 RID: 128936 RVA: 0x0092EAE1 File Offset: 0x0092CCE1
		// (set) Token: 0x0601F7A9 RID: 128937 RVA: 0x0092EAF1 File Offset: 0x0092CCF1
		public unsafe float WaypointHalfLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_WaypointHalfLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_WaypointHalfLength) = value;
			}
		}

		// Token: 0x0601F7AA RID: 128938 RVA: 0x0092EB02 File Offset: 0x0092CD02
		protected BP_WoodenOxenAndFlowingHorsesConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E1E RID: 69150
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_WoodenOxenAndFlowingHorsesConfig.BP_WoodenOxenAndFlowingHorsesConfig_C";

		// Token: 0x04010E1F RID: 69151
		private static IntPtr _ClassPtr;

		// Token: 0x04010E20 RID: 69152
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E21 RID: 69153
		internal static int __PropertyOffset_ObstacleHalfLength;

		// Token: 0x04010E22 RID: 69154
		internal static int __PropertyOffset_ObstacleHalfWidth;

		// Token: 0x04010E23 RID: 69155
		internal static int __PropertyOffset_WaypointHalfLength;
	}
}
