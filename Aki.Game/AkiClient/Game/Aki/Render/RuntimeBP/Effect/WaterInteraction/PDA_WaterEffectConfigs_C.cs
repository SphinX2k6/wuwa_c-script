using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003103 RID: 12547
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/PDA_WaterEffectConfigs.PDA_WaterEffectConfigs_C")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class PDA_WaterEffectConfigs_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB4A RID: 125770 RVA: 0x0091AFAB File Offset: 0x009191AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_WaterEffectConfigs_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/PDA_WaterEffectConfigs.PDA_WaterEffectConfigs_C");
			}
			return PDA_WaterEffectConfigs_C._ClassPtr;
		}

		// Token: 0x0601EB4B RID: 125771 RVA: 0x0091AFD0 File Offset: 0x009191D0
		public PDA_WaterEffectConfigs_C() : this(BuiltinUtils.AllocNativeUObject(PDA_WaterEffectConfigs_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB4C RID: 125772 RVA: 0x0091AFF8 File Offset: 0x009191F8
		public PDA_WaterEffectConfigs_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_WaterEffectConfigs_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0601EB4D RID: 125773 RVA: 0x0091B02B File Offset: 0x0091922B
		// (set) Token: 0x0601EB4E RID: 125774 RVA: 0x0091B03B File Offset: 0x0091923B
		public unsafe float TimeExistAfterDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_TimeExistAfterDead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_TimeExistAfterDead) = value;
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0601EB4F RID: 125775 RVA: 0x0091B04C File Offset: 0x0091924C
		// (set) Token: 0x0601EB50 RID: 125776 RVA: 0x0091B05C File Offset: 0x0091925C
		public unsafe float FallJumpPositionFix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_FallJumpPositionFix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_FallJumpPositionFix) = value;
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0601EB51 RID: 125777 RVA: 0x0091B070 File Offset: 0x00919270
		// (set) Token: 0x0601EB52 RID: 125778 RVA: 0x0091B0A9 File Offset: 0x009192A9
		public SWaterEffectSubConfig WaterEffectConfig
		{
			get
			{
				base.FastCheckIsValid();
				SWaterEffectSubConfig result;
				if ((result = this._WaterEffectConfig) == null)
				{
					result = (this._WaterEffectConfig = new SWaterEffectSubConfig(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_WaterEffectConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWaterEffectSubConfig.StaticStruct(), base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_WaterEffectConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0601EB53 RID: 125779 RVA: 0x0091B0CA File Offset: 0x009192CA
		// (set) Token: 0x0601EB54 RID: 125780 RVA: 0x0091B0DF File Offset: 0x009192DF
		public TSoftObjectPtr<UEffectModelBase> SwimIdleEffectRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_SwimIdleEffectRef, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_SwimIdleEffectRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0601EB55 RID: 125781 RVA: 0x0091B104 File Offset: 0x00919304
		// (set) Token: 0x0601EB56 RID: 125782 RVA: 0x0091B119 File Offset: 0x00919319
		public TSoftObjectPtr<UEffectModelBase> SwimNormalEffectRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_SwimNormalEffectRef, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_SwimNormalEffectRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0601EB57 RID: 125783 RVA: 0x0091B13E File Offset: 0x0091933E
		// (set) Token: 0x0601EB58 RID: 125784 RVA: 0x0091B153 File Offset: 0x00919353
		public TSoftObjectPtr<UEffectModelBase> SwimFastEffectRef
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_SwimFastEffectRef, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_SwimFastEffectRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0601EB59 RID: 125785 RVA: 0x0091B178 File Offset: 0x00919378
		// (set) Token: 0x0601EB5A RID: 125786 RVA: 0x0091B1B1 File Offset: 0x009193B1
		public TMap<UPhysicalMaterial, SWaterEffectSubConfig> MaterialEffectConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPhysicalMaterial, SWaterEffectSubConfig> result;
				if ((result = this._MaterialEffectConfig) == null)
				{
					result = (this._MaterialEffectConfig = new TMap<UPhysicalMaterial, SWaterEffectSubConfig>(base.NativePtr + (IntPtr)PDA_WaterEffectConfigs_C.__PropertyOffset_MaterialEffectConfig, this));
				}
				return result;
			}
			set
			{
				this.MaterialEffectConfig.CopyAssign(value);
			}
		}

		// Token: 0x0601EB5B RID: 125787 RVA: 0x0091B1BF File Offset: 0x009193BF
		protected PDA_WaterEffectConfigs_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104BF RID: 66751
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/PDA_WaterEffectConfigs.PDA_WaterEffectConfigs_C";

		// Token: 0x040104C0 RID: 66752
		private static IntPtr _ClassPtr;

		// Token: 0x040104C1 RID: 66753
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104C2 RID: 66754
		internal static int __PropertyOffset_TimeExistAfterDead;

		// Token: 0x040104C3 RID: 66755
		internal static int __PropertyOffset_FallJumpPositionFix;

		// Token: 0x040104C4 RID: 66756
		internal static int __PropertyOffset_WaterEffectConfig;

		// Token: 0x040104C5 RID: 66757
		[Nullable(2)]
		private SWaterEffectSubConfig _WaterEffectConfig;

		// Token: 0x040104C6 RID: 66758
		internal static int __PropertyOffset_SwimIdleEffectRef;

		// Token: 0x040104C7 RID: 66759
		internal static int __PropertyOffset_SwimNormalEffectRef;

		// Token: 0x040104C8 RID: 66760
		internal static int __PropertyOffset_SwimFastEffectRef;

		// Token: 0x040104C9 RID: 66761
		internal static int __PropertyOffset_MaterialEffectConfig;

		// Token: 0x040104CA RID: 66762
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UPhysicalMaterial, SWaterEffectSubConfig> _MaterialEffectConfig;
	}
}
