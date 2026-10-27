using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003DB9 RID: 15801
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/PDA_WaterEffectConfigs.PDA_WaterEffectConfigs_C")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class PDA_WaterEffectConfigs_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027464 RID: 160868 RVA: 0x0098CFE4 File Offset: 0x0098B1E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WaterEffectConfigs_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/PDA_WaterEffectConfigs.PDA_WaterEffectConfigs_C");
			}
			return PDA_WaterEffectConfigs_C._ClassPtr;
		}

		// Token: 0x06027465 RID: 160869 RVA: 0x0098D008 File Offset: 0x0098B208
		public PDA_WaterEffectConfigs_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WaterEffectConfigs_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027466 RID: 160870 RVA: 0x0098D030 File Offset: 0x0098B230
		public PDA_WaterEffectConfigs_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WaterEffectConfigs_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700572C RID: 22316
		// (get) Token: 0x06027467 RID: 160871 RVA: 0x0098D063 File Offset: 0x0098B263
		// (set) Token: 0x06027468 RID: 160872 RVA: 0x0098D073 File Offset: 0x0098B273
		public unsafe float TimeExistAfterDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700572D RID: 22317
		// (get) Token: 0x06027469 RID: 160873 RVA: 0x0098D084 File Offset: 0x0098B284
		// (set) Token: 0x0602746A RID: 160874 RVA: 0x0098D094 File Offset: 0x0098B294
		public unsafe float FallJumpPositionFix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700572E RID: 22318
		// (get) Token: 0x0602746B RID: 160875 RVA: 0x0098D0A8 File Offset: 0x0098B2A8
		// (set) Token: 0x0602746C RID: 160876 RVA: 0x0098D0E1 File Offset: 0x0098B2E1
		public SWaterEffectSubConfig WaterEffectConfig
		{
			get
			{
				base.FastCheckIsValid();
				SWaterEffectSubConfig result;
				if ((result = this._WaterEffectConfig) == null)
				{
					result = (this._WaterEffectConfig = new SWaterEffectSubConfig(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWaterEffectSubConfig.StaticStruct(), base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700572F RID: 22319
		// (get) Token: 0x0602746D RID: 160877 RVA: 0x0098D102 File Offset: 0x0098B302
		// (set) Token: 0x0602746E RID: 160878 RVA: 0x0098D117 File Offset: 0x0098B317
		public TSoftObjectPtr<UEffectModelBase> SwimIdleEffectRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_3, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005730 RID: 22320
		// (get) Token: 0x0602746F RID: 160879 RVA: 0x0098D13C File Offset: 0x0098B33C
		// (set) Token: 0x06027470 RID: 160880 RVA: 0x0098D151 File Offset: 0x0098B351
		public TSoftObjectPtr<UEffectModelBase> SwimNormalEffectRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_4, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005731 RID: 22321
		// (get) Token: 0x06027471 RID: 160881 RVA: 0x0098D176 File Offset: 0x0098B376
		// (set) Token: 0x06027472 RID: 160882 RVA: 0x0098D18B File Offset: 0x0098B38B
		public TSoftObjectPtr<UEffectModelBase> SwimFastEffectRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_5, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005732 RID: 22322
		// (get) Token: 0x06027473 RID: 160883 RVA: 0x0098D1B0 File Offset: 0x0098B3B0
		// (set) Token: 0x06027474 RID: 160884 RVA: 0x0098D1E9 File Offset: 0x0098B3E9
		public TMap<UPhysicalMaterial, SWaterEffectSubConfig> MaterialEffectConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPhysicalMaterial, SWaterEffectSubConfig> result;
				if ((result = this._MaterialEffectConfig) == null)
				{
					result = (this._MaterialEffectConfig = new TMap<UPhysicalMaterial, SWaterEffectSubConfig>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.MaterialEffectConfig.CopyAssign(value);
			}
		}

		// Token: 0x06027475 RID: 160885 RVA: 0x0098D1F7 File Offset: 0x0098B3F7
		protected PDA_WaterEffectConfigs_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D14 RID: 81172
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/PDA_WaterEffectConfigs.PDA_WaterEffectConfigs_C";

		// Token: 0x04013D15 RID: 81173
		private static IntPtr _ClassPtr;

		// Token: 0x04013D16 RID: 81174
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013D17 RID: 81175
		internal static int __PropertyOffset_0;

		// Token: 0x04013D18 RID: 81176
		internal static int __PropertyOffset_1;

		// Token: 0x04013D19 RID: 81177
		internal static int __PropertyOffset_2;

		// Token: 0x04013D1A RID: 81178
		[Nullable(2)]
		private SWaterEffectSubConfig _WaterEffectConfig;

		// Token: 0x04013D1B RID: 81179
		internal static int __PropertyOffset_3;

		// Token: 0x04013D1C RID: 81180
		internal static int __PropertyOffset_4;

		// Token: 0x04013D1D RID: 81181
		internal static int __PropertyOffset_5;

		// Token: 0x04013D1E RID: 81182
		internal static int __PropertyOffset_6;

		// Token: 0x04013D1F RID: 81183
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UPhysicalMaterial, SWaterEffectSubConfig> _MaterialEffectConfig;
	}
}
