using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.SunSpirit
{
	// Token: 0x02003F30 RID: 16176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/SunSpirit/BP_SunSpiritConfig.BP_SunSpiritConfig_C")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class BP_SunSpiritConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060291FC RID: 168444 RVA: 0x009BC6B9 File Offset: 0x009BA8B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SunSpiritConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/SunSpirit/BP_SunSpiritConfig.BP_SunSpiritConfig_C");
			}
			return BP_SunSpiritConfig_C._ClassPtr;
		}

		// Token: 0x060291FD RID: 168445 RVA: 0x009BC6E0 File Offset: 0x009BA8E0
		public BP_SunSpiritConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SunSpiritConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060291FE RID: 168446 RVA: 0x009BC708 File Offset: 0x009BA908
		public BP_SunSpiritConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SunSpiritConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x060291FF RID: 168447 RVA: 0x009BC73B File Offset: 0x009BA93B
		// (set) Token: 0x06029200 RID: 168448 RVA: 0x009BC74F File Offset: 0x009BA94F
		[Nullable(2)]
		public unsafe BP_CrowdAiConfig_C CrowdAiConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CrowdAiConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SunSpiritConfig_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SunSpiritConfig_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x06029201 RID: 168449 RVA: 0x009BC764 File Offset: 0x009BA964
		// (set) Token: 0x06029202 RID: 168450 RVA: 0x009BC774 File Offset: 0x009BA974
		public unsafe int CrowdAiSystemIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x06029203 RID: 168451 RVA: 0x009BC785 File Offset: 0x009BA985
		// (set) Token: 0x06029204 RID: 168452 RVA: 0x009BC795 File Offset: 0x009BA995
		public unsafe float AroundPlayerPosQueryRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x06029205 RID: 168453 RVA: 0x009BC7A6 File Offset: 0x009BA9A6
		// (set) Token: 0x06029206 RID: 168454 RVA: 0x009BC7B6 File Offset: 0x009BA9B6
		public unsafe float AroundPlayerPosQueryBoidRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x06029207 RID: 168455 RVA: 0x009BC7C7 File Offset: 0x009BA9C7
		// (set) Token: 0x06029208 RID: 168456 RVA: 0x009BC7D7 File Offset: 0x009BA9D7
		public unsafe int AroundPlayerPosQueryMaxTryCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x06029209 RID: 168457 RVA: 0x009BC7E8 File Offset: 0x009BA9E8
		// (set) Token: 0x0602920A RID: 168458 RVA: 0x009BC7F8 File Offset: 0x009BA9F8
		public unsafe float FlyingEffectMaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x0602920B RID: 168459 RVA: 0x009BC809 File Offset: 0x009BAA09
		// (set) Token: 0x0602920C RID: 168460 RVA: 0x009BC819 File Offset: 0x009BAA19
		public unsafe float FlyingEffectMinDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x0602920D RID: 168461 RVA: 0x009BC82A File Offset: 0x009BAA2A
		// (set) Token: 0x0602920E RID: 168462 RVA: 0x009BC83A File Offset: 0x009BAA3A
		public unsafe float FlyingEffectUpdateFailMaxTimeSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x0602920F RID: 168463 RVA: 0x009BC84B File Offset: 0x009BAA4B
		// (set) Token: 0x06029210 RID: 168464 RVA: 0x009BC85B File Offset: 0x009BAA5B
		public unsafe int FlyingEffectUpdateFailMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x06029211 RID: 168465 RVA: 0x009BC86C File Offset: 0x009BAA6C
		// (set) Token: 0x06029212 RID: 168466 RVA: 0x009BC87C File Offset: 0x009BAA7C
		public unsafe float FlyingEffectMaxFlyingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x06029213 RID: 168467 RVA: 0x009BC88D File Offset: 0x009BAA8D
		// (set) Token: 0x06029214 RID: 168468 RVA: 0x009BC8A2 File Offset: 0x009BAAA2
		public TSoftObjectPtr<UEffectModelBase> FlyingEffectDa
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x06029215 RID: 168469 RVA: 0x009BC8C7 File Offset: 0x009BAAC7
		// (set) Token: 0x06029216 RID: 168470 RVA: 0x009BC8D7 File Offset: 0x009BAAD7
		public unsafe bool FlyFromPlayerToGearInOrderFromMinToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x06029217 RID: 168471 RVA: 0x009BC8E8 File Offset: 0x009BAAE8
		// (set) Token: 0x06029218 RID: 168472 RVA: 0x009BC8F8 File Offset: 0x009BAAF8
		public unsafe float FlyFromPlayerToGearDelayInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x06029219 RID: 168473 RVA: 0x009BC909 File Offset: 0x009BAB09
		// (set) Token: 0x0602921A RID: 168474 RVA: 0x009BC919 File Offset: 0x009BAB19
		public unsafe float FlyFromPlayerToGearWaitTimeBeforeFly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x0602921B RID: 168475 RVA: 0x009BC92A File Offset: 0x009BAB2A
		// (set) Token: 0x0602921C RID: 168476 RVA: 0x009BC93A File Offset: 0x009BAB3A
		public unsafe float FlyFromPlayerToGearSpeedForCalc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170061AD RID: 25005
		// (get) Token: 0x0602921D RID: 168477 RVA: 0x009BC94B File Offset: 0x009BAB4B
		// (set) Token: 0x0602921E RID: 168478 RVA: 0x009BC95B File Offset: 0x009BAB5B
		public unsafe float FlyFromPlayerToGearDefaultDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170061AE RID: 25006
		// (get) Token: 0x0602921F RID: 168479 RVA: 0x009BC96C File Offset: 0x009BAB6C
		// (set) Token: 0x06029220 RID: 168480 RVA: 0x009BC97C File Offset: 0x009BAB7C
		public unsafe bool FlyFromGearToPlayerInOrderFromMinToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x06029221 RID: 168481 RVA: 0x009BC98D File Offset: 0x009BAB8D
		// (set) Token: 0x06029222 RID: 168482 RVA: 0x009BC99D File Offset: 0x009BAB9D
		public unsafe float FlyFromGearToPlayerDelayInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x06029223 RID: 168483 RVA: 0x009BC9AE File Offset: 0x009BABAE
		// (set) Token: 0x06029224 RID: 168484 RVA: 0x009BC9BE File Offset: 0x009BABBE
		public unsafe float FlyFromGearToPlayerWaitTimeBeforeFly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x06029225 RID: 168485 RVA: 0x009BC9CF File Offset: 0x009BABCF
		// (set) Token: 0x06029226 RID: 168486 RVA: 0x009BC9DF File Offset: 0x009BABDF
		public unsafe float FlyFromGearToPlayerSpeedForCalc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x06029227 RID: 168487 RVA: 0x009BC9F0 File Offset: 0x009BABF0
		// (set) Token: 0x06029228 RID: 168488 RVA: 0x009BCA00 File Offset: 0x009BAC00
		public unsafe float FlyFromGearToPlayerDefaultDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x06029229 RID: 168489 RVA: 0x009BCA11 File Offset: 0x009BAC11
		// (set) Token: 0x0602922A RID: 168490 RVA: 0x009BCA21 File Offset: 0x009BAC21
		public unsafe float FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x0602922B RID: 168491 RVA: 0x009BCA32 File Offset: 0x009BAC32
		// (set) Token: 0x0602922C RID: 168492 RVA: 0x009BCA46 File Offset: 0x009BAC46
		public unsafe FVector2D LauncherHintUiAnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x0602922D RID: 168493 RVA: 0x009BCA5B File Offset: 0x009BAC5B
		// (set) Token: 0x0602922E RID: 168494 RVA: 0x009BCA6F File Offset: 0x009BAC6F
		public unsafe FVector2D LauncherHintUiPosLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x0602922F RID: 168495 RVA: 0x009BCA84 File Offset: 0x009BAC84
		// (set) Token: 0x06029230 RID: 168496 RVA: 0x009BCA98 File Offset: 0x009BAC98
		public unsafe FVector2D CharacterHintUiAnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170061B7 RID: 25015
		// (get) Token: 0x06029231 RID: 168497 RVA: 0x009BCAAD File Offset: 0x009BACAD
		// (set) Token: 0x06029232 RID: 168498 RVA: 0x009BCAC1 File Offset: 0x009BACC1
		public unsafe FVector2D CharacterHintUiPosLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170061B8 RID: 25016
		// (get) Token: 0x06029233 RID: 168499 RVA: 0x009BCAD6 File Offset: 0x009BACD6
		// (set) Token: 0x06029234 RID: 168500 RVA: 0x009BCAE6 File Offset: 0x009BACE6
		public unsafe float CharacterHintUiShowDurationWhenUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x06029235 RID: 168501 RVA: 0x009BCAF7 File Offset: 0x009BACF7
		protected BP_SunSpiritConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150E3 RID: 86243
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/SunSpirit/BP_SunSpiritConfig.BP_SunSpiritConfig_C";

		// Token: 0x040150E4 RID: 86244
		private static IntPtr _ClassPtr;

		// Token: 0x040150E5 RID: 86245
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150E6 RID: 86246
		internal static int __PropertyOffset_0;

		// Token: 0x040150E7 RID: 86247
		internal static int __PropertyOffset_1;

		// Token: 0x040150E8 RID: 86248
		internal static int __PropertyOffset_2;

		// Token: 0x040150E9 RID: 86249
		internal static int __PropertyOffset_3;

		// Token: 0x040150EA RID: 86250
		internal static int __PropertyOffset_4;

		// Token: 0x040150EB RID: 86251
		internal static int __PropertyOffset_5;

		// Token: 0x040150EC RID: 86252
		internal static int __PropertyOffset_6;

		// Token: 0x040150ED RID: 86253
		internal static int __PropertyOffset_7;

		// Token: 0x040150EE RID: 86254
		internal static int __PropertyOffset_8;

		// Token: 0x040150EF RID: 86255
		internal static int __PropertyOffset_9;

		// Token: 0x040150F0 RID: 86256
		internal static int __PropertyOffset_10;

		// Token: 0x040150F1 RID: 86257
		internal static int __PropertyOffset_11;

		// Token: 0x040150F2 RID: 86258
		internal static int __PropertyOffset_12;

		// Token: 0x040150F3 RID: 86259
		internal static int __PropertyOffset_13;

		// Token: 0x040150F4 RID: 86260
		internal static int __PropertyOffset_14;

		// Token: 0x040150F5 RID: 86261
		internal static int __PropertyOffset_15;

		// Token: 0x040150F6 RID: 86262
		internal static int __PropertyOffset_16;

		// Token: 0x040150F7 RID: 86263
		internal static int __PropertyOffset_17;

		// Token: 0x040150F8 RID: 86264
		internal static int __PropertyOffset_18;

		// Token: 0x040150F9 RID: 86265
		internal static int __PropertyOffset_19;

		// Token: 0x040150FA RID: 86266
		internal static int __PropertyOffset_20;

		// Token: 0x040150FB RID: 86267
		internal static int __PropertyOffset_21;

		// Token: 0x040150FC RID: 86268
		internal static int __PropertyOffset_22;

		// Token: 0x040150FD RID: 86269
		internal static int __PropertyOffset_23;

		// Token: 0x040150FE RID: 86270
		internal static int __PropertyOffset_24;

		// Token: 0x040150FF RID: 86271
		internal static int __PropertyOffset_25;

		// Token: 0x04015100 RID: 86272
		internal static int __PropertyOffset_26;
	}
}
