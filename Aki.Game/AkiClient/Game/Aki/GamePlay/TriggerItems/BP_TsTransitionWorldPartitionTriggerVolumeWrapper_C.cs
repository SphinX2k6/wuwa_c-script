using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.TriggerItems
{
	// Token: 0x02003E50 RID: 15952
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/TriggerItems/BP_TsTransitionWorldPartitionTriggerVolumeWrapper.BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028192 RID: 164242 RVA: 0x009A3ECC File Offset: 0x009A20CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/TriggerItems/BP_TsTransitionWorldPartitionTriggerVolumeWrapper.BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C");
			}
			return BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C._ClassPtr;
		}

		// Token: 0x06028193 RID: 164243 RVA: 0x009A3EF0 File Offset: 0x009A20F0
		public BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C() : this(BuiltinUtils.AllocNativeUObject(BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028194 RID: 164244 RVA: 0x009A3F18 File Offset: 0x009A2118
		[NullableContext(1)]
		public BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BBD RID: 23485
		// (get) Token: 0x06028195 RID: 164245 RVA: 0x009A3F4B File Offset: 0x009A214B
		// (set) Token: 0x06028196 RID: 164246 RVA: 0x009A3F5F File Offset: 0x009A215F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BBE RID: 23486
		// (get) Token: 0x06028197 RID: 164247 RVA: 0x009A3F74 File Offset: 0x009A2174
		// (set) Token: 0x06028198 RID: 164248 RVA: 0x009A3F88 File Offset: 0x009A2188
		public unsafe TsTransitionWorldPartitionTriggerVolume TargetVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsTransitionWorldPartitionTriggerVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06028199 RID: 164249 RVA: 0x009A3F9D File Offset: 0x009A219D
		protected BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014678 RID: 83576
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/TriggerItems/BP_TsTransitionWorldPartitionTriggerVolumeWrapper.BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C";

		// Token: 0x04014679 RID: 83577
		private static IntPtr _ClassPtr;

		// Token: 0x0401467A RID: 83578
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401467B RID: 83579
		internal static int __PropertyOffset_0;

		// Token: 0x0401467C RID: 83580
		internal static int __PropertyOffset_1;
	}
}
