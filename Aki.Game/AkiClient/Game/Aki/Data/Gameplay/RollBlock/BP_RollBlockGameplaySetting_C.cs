using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.RollBlock
{
	// Token: 0x02003F31 RID: 16177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RollBlock/BP_RollBlockGameplaySetting.BP_RollBlockGameplaySetting_C")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class BP_RollBlockGameplaySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029236 RID: 168502 RVA: 0x009BCB00 File Offset: 0x009BAD00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RollBlockGameplaySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/RollBlock/BP_RollBlockGameplaySetting.BP_RollBlockGameplaySetting_C");
			}
			return BP_RollBlockGameplaySetting_C._ClassPtr;
		}

		// Token: 0x06029237 RID: 168503 RVA: 0x009BCB24 File Offset: 0x009BAD24
		public BP_RollBlockGameplaySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_RollBlockGameplaySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029238 RID: 168504 RVA: 0x009BCB4C File Offset: 0x009BAD4C
		public BP_RollBlockGameplaySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RollBlockGameplaySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061B9 RID: 25017
		// (get) Token: 0x06029239 RID: 168505 RVA: 0x009BCB7F File Offset: 0x009BAD7F
		// (set) Token: 0x0602923A RID: 168506 RVA: 0x009BCB8F File Offset: 0x009BAD8F
		public unsafe float BlockRollTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170061BA RID: 25018
		// (get) Token: 0x0602923B RID: 168507 RVA: 0x009BCBA0 File Offset: 0x009BADA0
		// (set) Token: 0x0602923C RID: 168508 RVA: 0x009BCBB5 File Offset: 0x009BADB5
		public TSoftObjectPtr<UEffectModelGroup> BreakableObstacleLinkEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_1, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061BB RID: 25019
		// (get) Token: 0x0602923D RID: 168509 RVA: 0x009BCBDA File Offset: 0x009BADDA
		// (set) Token: 0x0602923E RID: 168510 RVA: 0x009BCBEF File Offset: 0x009BADEF
		public TSoftObjectPtr<UEffectModelGroup> BreakableObstacleDestroyLinkEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_2, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061BC RID: 25020
		// (get) Token: 0x0602923F RID: 168511 RVA: 0x009BCC14 File Offset: 0x009BAE14
		// (set) Token: 0x06029240 RID: 168512 RVA: 0x009BCC24 File Offset: 0x009BAE24
		public unsafe int ShowBlockInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170061BD RID: 25021
		// (get) Token: 0x06029241 RID: 168513 RVA: 0x009BCC35 File Offset: 0x009BAE35
		// (set) Token: 0x06029242 RID: 168514 RVA: 0x009BCC45 File Offset: 0x009BAE45
		public unsafe int ShowMistakeTipsCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170061BE RID: 25022
		// (get) Token: 0x06029243 RID: 168515 RVA: 0x009BCC56 File Offset: 0x009BAE56
		// (set) Token: 0x06029244 RID: 168516 RVA: 0x009BCC6A File Offset: 0x009BAE6A
		public unsafe string RollBlockErrorTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x06029245 RID: 168517 RVA: 0x009BCC7F File Offset: 0x009BAE7F
		// (set) Token: 0x06029246 RID: 168518 RVA: 0x009BCC8F File Offset: 0x009BAE8F
		public unsafe float DestroyTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x06029247 RID: 168519 RVA: 0x009BCCA0 File Offset: 0x009BAEA0
		// (set) Token: 0x06029248 RID: 168520 RVA: 0x009BCCB4 File Offset: 0x009BAEB4
		public unsafe string RollBlockMainTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x06029249 RID: 168521 RVA: 0x009BCCC9 File Offset: 0x009BAEC9
		// (set) Token: 0x0602924A RID: 168522 RVA: 0x009BCCDD File Offset: 0x009BAEDD
		public unsafe string RollBlockSecondTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x0602924B RID: 168523 RVA: 0x009BCCF2 File Offset: 0x009BAEF2
		// (set) Token: 0x0602924C RID: 168524 RVA: 0x009BCD06 File Offset: 0x009BAF06
		public unsafe string RollBlockPhantomTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_9)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_9)), value);
			}
		}

		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x0602924D RID: 168525 RVA: 0x009BCD1B File Offset: 0x009BAF1B
		// (set) Token: 0x0602924E RID: 168526 RVA: 0x009BCD30 File Offset: 0x009BAF30
		public TSoftObjectPtr<UEffectModelGroup> LightBeamEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x0602924F RID: 168527 RVA: 0x009BCD55 File Offset: 0x009BAF55
		// (set) Token: 0x06029250 RID: 168528 RVA: 0x009BCD6A File Offset: 0x009BAF6A
		public TSoftObjectPtr<UEffectModelGroup> LightBeamHitEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_11, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x06029251 RID: 168529 RVA: 0x009BCD8F File Offset: 0x009BAF8F
		// (set) Token: 0x06029252 RID: 168530 RVA: 0x009BCDA4 File Offset: 0x009BAFA4
		public TSoftObjectPtr<UEffectModelGroup> LightBeamHitWallEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_12, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x06029253 RID: 168531 RVA: 0x009BCDC9 File Offset: 0x009BAFC9
		// (set) Token: 0x06029254 RID: 168532 RVA: 0x009BCDDE File Offset: 0x009BAFDE
		public TSoftObjectPtr<UEffectModelGroup> LightBeamStartEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_13, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x06029255 RID: 168533 RVA: 0x009BCE03 File Offset: 0x009BB003
		// (set) Token: 0x06029256 RID: 168534 RVA: 0x009BCE13 File Offset: 0x009BB013
		public unsafe float VisionBlockRollTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x06029257 RID: 168535 RVA: 0x009BCE24 File Offset: 0x009BB024
		// (set) Token: 0x06029258 RID: 168536 RVA: 0x009BCE34 File Offset: 0x009BB034
		public unsafe int BlockDestroyDelayResetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x06029259 RID: 168537 RVA: 0x009BCE45 File Offset: 0x009BB045
		protected BP_RollBlockGameplaySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015101 RID: 86273
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/RollBlock/BP_RollBlockGameplaySetting.BP_RollBlockGameplaySetting_C";

		// Token: 0x04015102 RID: 86274
		private static IntPtr _ClassPtr;

		// Token: 0x04015103 RID: 86275
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015104 RID: 86276
		internal static int __PropertyOffset_0;

		// Token: 0x04015105 RID: 86277
		internal static int __PropertyOffset_1;

		// Token: 0x04015106 RID: 86278
		internal static int __PropertyOffset_2;

		// Token: 0x04015107 RID: 86279
		internal static int __PropertyOffset_3;

		// Token: 0x04015108 RID: 86280
		internal static int __PropertyOffset_4;

		// Token: 0x04015109 RID: 86281
		internal static int __PropertyOffset_5;

		// Token: 0x0401510A RID: 86282
		internal static int __PropertyOffset_6;

		// Token: 0x0401510B RID: 86283
		internal static int __PropertyOffset_7;

		// Token: 0x0401510C RID: 86284
		internal static int __PropertyOffset_8;

		// Token: 0x0401510D RID: 86285
		internal static int __PropertyOffset_9;

		// Token: 0x0401510E RID: 86286
		internal static int __PropertyOffset_10;

		// Token: 0x0401510F RID: 86287
		internal static int __PropertyOffset_11;

		// Token: 0x04015110 RID: 86288
		internal static int __PropertyOffset_12;

		// Token: 0x04015111 RID: 86289
		internal static int __PropertyOffset_13;

		// Token: 0x04015112 RID: 86290
		internal static int __PropertyOffset_14;

		// Token: 0x04015113 RID: 86291
		internal static int __PropertyOffset_15;
	}
}
