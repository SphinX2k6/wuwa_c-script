using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x02003EFD RID: 16125
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_WoodenOxenAndFlowingHorsesConfig.BP_WoodenOxenAndFlowingHorsesConfig_C")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 764)]
	public class BP_WoodenOxenAndFlowingHorsesConfig_C : BP_VehicleConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E04 RID: 167428 RVA: 0x009B6958 File Offset: 0x009B4B58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WoodenOxenAndFlowingHorsesConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_WoodenOxenAndFlowingHorsesConfig.BP_WoodenOxenAndFlowingHorsesConfig_C");
			}
			return BP_WoodenOxenAndFlowingHorsesConfig_C._ClassPtr;
		}

		// Token: 0x06028E05 RID: 167429 RVA: 0x009B697C File Offset: 0x009B4B7C
		public BP_WoodenOxenAndFlowingHorsesConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_WoodenOxenAndFlowingHorsesConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E06 RID: 167430 RVA: 0x009B69A4 File Offset: 0x009B4BA4
		[NullableContext(1)]
		public BP_WoodenOxenAndFlowingHorsesConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WoodenOxenAndFlowingHorsesConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700601F RID: 24607
		// (get) Token: 0x06028E07 RID: 167431 RVA: 0x009B69D7 File Offset: 0x009B4BD7
		// (set) Token: 0x06028E08 RID: 167432 RVA: 0x009B69E7 File Offset: 0x009B4BE7
		public unsafe float ObstacleHalfLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x06028E09 RID: 167433 RVA: 0x009B69F8 File Offset: 0x009B4BF8
		// (set) Token: 0x06028E0A RID: 167434 RVA: 0x009B6A08 File Offset: 0x009B4C08
		public unsafe float ObstacleHalfWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x06028E0B RID: 167435 RVA: 0x009B6A19 File Offset: 0x009B4C19
		// (set) Token: 0x06028E0C RID: 167436 RVA: 0x009B6A29 File Offset: 0x009B4C29
		public unsafe float WaypointHalfLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodenOxenAndFlowingHorsesConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06028E0D RID: 167437 RVA: 0x009B6A3A File Offset: 0x009B4C3A
		protected BP_WoodenOxenAndFlowingHorsesConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E79 RID: 85625
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_WoodenOxenAndFlowingHorsesConfig.BP_WoodenOxenAndFlowingHorsesConfig_C";

		// Token: 0x04014E7A RID: 85626
		private static IntPtr _ClassPtr;

		// Token: 0x04014E7B RID: 85627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E7C RID: 85628
		internal new static int __PropertyOffset_0;

		// Token: 0x04014E7D RID: 85629
		internal new static int __PropertyOffset_1;

		// Token: 0x04014E7E RID: 85630
		internal new static int __PropertyOffset_2;
	}
}
