using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.TriggerItems
{
	// Token: 0x02003148 RID: 12616
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/TriggerItems/BP_TsTransitionWorldPartitionTriggerVolumeWrapper.BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F06E RID: 127086 RVA: 0x00924733 File Offset: 0x00922933
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/TriggerItems/BP_TsTransitionWorldPartitionTriggerVolumeWrapper.BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C");
			}
			return BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C._ClassPtr;
		}

		// Token: 0x0601F06F RID: 127087 RVA: 0x00924758 File Offset: 0x00922958
		public BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C() : this(BuiltinUtils.AllocNativeUObject(BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F070 RID: 127088 RVA: 0x00924780 File Offset: 0x00922980
		[NullableContext(1)]
		public BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0601F071 RID: 127089 RVA: 0x009247B3 File Offset: 0x009229B3
		// (set) Token: 0x0601F072 RID: 127090 RVA: 0x009247C7 File Offset: 0x009229C7
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0601F073 RID: 127091 RVA: 0x009247DC File Offset: 0x009229DC
		// (set) Token: 0x0601F074 RID: 127092 RVA: 0x009247F0 File Offset: 0x009229F0
		public unsafe TsTransitionWorldPartitionTriggerVolume TargetVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsTransitionWorldPartitionTriggerVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_TargetVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C.__PropertyOffset_TargetVolume, value);
			}
		}

		// Token: 0x0601F075 RID: 127093 RVA: 0x00924805 File Offset: 0x00922A05
		protected BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010929 RID: 67881
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/TriggerItems/BP_TsTransitionWorldPartitionTriggerVolumeWrapper.BP_TsTransitionWorldPartitionTriggerVolumeWrapper_C";

		// Token: 0x0401092A RID: 67882
		private static IntPtr _ClassPtr;

		// Token: 0x0401092B RID: 67883
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401092C RID: 67884
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401092D RID: 67885
		internal static int __PropertyOffset_TargetVolume;
	}
}
