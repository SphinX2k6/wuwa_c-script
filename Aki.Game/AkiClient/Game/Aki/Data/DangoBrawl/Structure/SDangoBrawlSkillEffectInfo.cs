using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.DangoBrawl.Structure
{
	// Token: 0x02003F9C RID: 16284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/DangoBrawl/Structure/SDangoBrawlSkillEffectInfo.SDangoBrawlSkillEffectInfo")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 289)]
	public class SDangoBrawlSkillEffectInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029971 RID: 170353 RVA: 0x009C80E4 File Offset: 0x009C62E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDangoBrawlSkillEffectInfo._ScriptStructPtr != 0) ? SDangoBrawlSkillEffectInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/DangoBrawl/Structure/SDangoBrawlSkillEffectInfo.SDangoBrawlSkillEffectInfo", ref SDangoBrawlSkillEffectInfo._ScriptStructPtr);
		}

		// Token: 0x17006418 RID: 25624
		// (get) Token: 0x06029972 RID: 170354 RVA: 0x009C8108 File Offset: 0x009C6308
		// (set) Token: 0x06029973 RID: 170355 RVA: 0x009C8118 File Offset: 0x009C6318
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006419 RID: 25625
		// (get) Token: 0x06029974 RID: 170356 RVA: 0x009C8129 File Offset: 0x009C6329
		// (set) Token: 0x06029975 RID: 170357 RVA: 0x009C8148 File Offset: 0x009C6348
		public TSoftObjectPtr<UPrimaryDataAsset> WeaponAssetPath
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700641A RID: 25626
		// (get) Token: 0x06029976 RID: 170358 RVA: 0x009C816D File Offset: 0x009C636D
		// (set) Token: 0x06029977 RID: 170359 RVA: 0x009C817D File Offset: 0x009C637D
		public unsafe bool WeaponTargetSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700641B RID: 25627
		// (get) Token: 0x06029978 RID: 170360 RVA: 0x009C818E File Offset: 0x009C638E
		// (set) Token: 0x06029979 RID: 170361 RVA: 0x009C81A2 File Offset: 0x009C63A2
		public unsafe FVector WeaponOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700641C RID: 25628
		// (get) Token: 0x0602997A RID: 170362 RVA: 0x009C81B7 File Offset: 0x009C63B7
		// (set) Token: 0x0602997B RID: 170363 RVA: 0x009C81D6 File Offset: 0x009C63D6
		public TSoftObjectPtr<UPrimaryDataAsset> SkillAssetPath
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700641D RID: 25629
		// (get) Token: 0x0602997C RID: 170364 RVA: 0x009C81FB File Offset: 0x009C63FB
		// (set) Token: 0x0602997D RID: 170365 RVA: 0x009C820B File Offset: 0x009C640B
		public unsafe bool SkillTargetSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700641E RID: 25630
		// (get) Token: 0x0602997E RID: 170366 RVA: 0x009C821C File Offset: 0x009C641C
		// (set) Token: 0x0602997F RID: 170367 RVA: 0x009C8230 File Offset: 0x009C6430
		public unsafe FVector SkillOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700641F RID: 25631
		// (get) Token: 0x06029980 RID: 170368 RVA: 0x009C8245 File Offset: 0x009C6445
		// (set) Token: 0x06029981 RID: 170369 RVA: 0x009C8255 File Offset: 0x009C6455
		public unsafe float SkillMoveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006420 RID: 25632
		// (get) Token: 0x06029982 RID: 170370 RVA: 0x009C8266 File Offset: 0x009C6466
		// (set) Token: 0x06029983 RID: 170371 RVA: 0x009C827A File Offset: 0x009C647A
		[Nullable(2)]
		public unsafe UCurveFloat SkillCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SDangoBrawlSkillEffectInfo.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SDangoBrawlSkillEffectInfo.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006421 RID: 25633
		// (get) Token: 0x06029984 RID: 170372 RVA: 0x009C828F File Offset: 0x009C648F
		// (set) Token: 0x06029985 RID: 170373 RVA: 0x009C82AE File Offset: 0x009C64AE
		public TSoftObjectPtr<UPrimaryDataAsset> HitAssetPath
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_9, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006422 RID: 25634
		// (get) Token: 0x06029986 RID: 170374 RVA: 0x009C82D3 File Offset: 0x009C64D3
		// (set) Token: 0x06029987 RID: 170375 RVA: 0x009C82E3 File Offset: 0x009C64E3
		public unsafe bool HitTargetSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006423 RID: 25635
		// (get) Token: 0x06029988 RID: 170376 RVA: 0x009C82F4 File Offset: 0x009C64F4
		// (set) Token: 0x06029989 RID: 170377 RVA: 0x009C8308 File Offset: 0x009C6508
		public unsafe FVector HitOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006424 RID: 25636
		// (get) Token: 0x0602998A RID: 170378 RVA: 0x009C831D File Offset: 0x009C651D
		// (set) Token: 0x0602998B RID: 170379 RVA: 0x009C8331 File Offset: 0x009C6531
		public unsafe string OffsetGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_12)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_12)), value);
			}
		}

		// Token: 0x17006425 RID: 25637
		// (get) Token: 0x0602998C RID: 170380 RVA: 0x009C8346 File Offset: 0x009C6546
		// (set) Token: 0x0602998D RID: 170381 RVA: 0x009C8356 File Offset: 0x009C6556
		public unsafe float RandomDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006426 RID: 25638
		// (get) Token: 0x0602998E RID: 170382 RVA: 0x009C8367 File Offset: 0x009C6567
		// (set) Token: 0x0602998F RID: 170383 RVA: 0x009C837B File Offset: 0x009C657B
		public unsafe FVector OffsetMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006427 RID: 25639
		// (get) Token: 0x06029990 RID: 170384 RVA: 0x009C8390 File Offset: 0x009C6590
		// (set) Token: 0x06029991 RID: 170385 RVA: 0x009C83A4 File Offset: 0x009C65A4
		public unsafe FVector OffsetMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006428 RID: 25640
		// (get) Token: 0x06029992 RID: 170386 RVA: 0x009C83B9 File Offset: 0x009C65B9
		// (set) Token: 0x06029993 RID: 170387 RVA: 0x009C83C9 File Offset: 0x009C65C9
		public unsafe float PlayTimeDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006429 RID: 25641
		// (get) Token: 0x06029994 RID: 170388 RVA: 0x009C83DC File Offset: 0x009C65DC
		// (set) Token: 0x06029995 RID: 170389 RVA: 0x009C841F File Offset: 0x009C661F
		public TArray<float> DamageHitDelay
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DamageHitDelay) == null)
				{
					result = (this._DamageHitDelay = new TArray<float>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_17, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DamageHitDelay.CopyAssign(value);
			}
		}

		// Token: 0x1700642A RID: 25642
		// (get) Token: 0x06029996 RID: 170390 RVA: 0x009C842D File Offset: 0x009C662D
		// (set) Token: 0x06029997 RID: 170391 RVA: 0x009C843D File Offset: 0x009C663D
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700642B RID: 25643
		// (get) Token: 0x06029998 RID: 170392 RVA: 0x009C844E File Offset: 0x009C664E
		// (set) Token: 0x06029999 RID: 170393 RVA: 0x009C845E File Offset: 0x009C665E
		public unsafe float MontageLoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700642C RID: 25644
		// (get) Token: 0x0602999A RID: 170394 RVA: 0x009C846F File Offset: 0x009C666F
		// (set) Token: 0x0602999B RID: 170395 RVA: 0x009C847F File Offset: 0x009C667F
		public unsafe bool TowardOpposite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602999C RID: 170396 RVA: 0x009C8490 File Offset: 0x009C6690
		public SDangoBrawlSkillEffectInfo()
		{
		}

		// Token: 0x0602999D RID: 170397 RVA: 0x009C8498 File Offset: 0x009C6698
		public SDangoBrawlSkillEffectInfo(int Id, TSoftObjectPtr<UPrimaryDataAsset> WeaponAssetPath, bool WeaponTargetSelf, FVector WeaponOffset, TSoftObjectPtr<UPrimaryDataAsset> SkillAssetPath, bool SkillTargetSelf, FVector SkillOffset, float SkillMoveTime, UCurveFloat SkillCurve, TSoftObjectPtr<UPrimaryDataAsset> HitAssetPath, bool HitTargetSelf, FVector HitOffset, string OffsetGroupName, float RandomDistance, FVector OffsetMax, FVector OffsetMin, float PlayTimeDelay, TArray<float> DamageHitDelay, float PlayRate, float MontageLoopTime, bool TowardOpposite)
		{
			this.Id = Id;
			this.WeaponAssetPath = WeaponAssetPath;
			this.WeaponTargetSelf = WeaponTargetSelf;
			this.WeaponOffset = WeaponOffset;
			this.SkillAssetPath = SkillAssetPath;
			this.SkillTargetSelf = SkillTargetSelf;
			this.SkillOffset = SkillOffset;
			this.SkillMoveTime = SkillMoveTime;
			this.SkillCurve = SkillCurve;
			this.HitAssetPath = HitAssetPath;
			this.HitTargetSelf = HitTargetSelf;
			this.HitOffset = HitOffset;
			this.OffsetGroupName = OffsetGroupName;
			this.RandomDistance = RandomDistance;
			this.OffsetMax = OffsetMax;
			this.OffsetMin = OffsetMin;
			this.PlayTimeDelay = PlayTimeDelay;
			this.DamageHitDelay = DamageHitDelay;
			this.PlayRate = PlayRate;
			this.MontageLoopTime = MontageLoopTime;
			this.TowardOpposite = TowardOpposite;
		}

		// Token: 0x0602999E RID: 170398 RVA: 0x009C8550 File Offset: 0x009C6750
		protected override IntPtr GetUStructPtr()
		{
			return SDangoBrawlSkillEffectInfo.StaticStruct();
		}

		// Token: 0x0602999F RID: 170399 RVA: 0x009C855C File Offset: 0x009C675C
		[NullableContext(2)]
		public SDangoBrawlSkillEffectInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060299A0 RID: 170400 RVA: 0x009C8566 File Offset: 0x009C6766
		public SDangoBrawlSkillEffectInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060299A1 RID: 170401 RVA: 0x009C8571 File Offset: 0x009C6771
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDangoBrawlSkillEffectInfo(Pointer, false, true);
		}

		// Token: 0x060299A2 RID: 170402 RVA: 0x009C857B File Offset: 0x009C677B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDangoBrawlSkillEffectInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04015572 RID: 87410
		public const string __ObjectPath = "/Game/Aki/Data/DangoBrawl/Structure/SDangoBrawlSkillEffectInfo.SDangoBrawlSkillEffectInfo";

		// Token: 0x04015573 RID: 87411
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015574 RID: 87412
		internal static int __PropertyOffset_0;

		// Token: 0x04015575 RID: 87413
		internal static int __PropertyOffset_1;

		// Token: 0x04015576 RID: 87414
		internal static int __PropertyOffset_2;

		// Token: 0x04015577 RID: 87415
		internal static int __PropertyOffset_3;

		// Token: 0x04015578 RID: 87416
		internal static int __PropertyOffset_4;

		// Token: 0x04015579 RID: 87417
		internal static int __PropertyOffset_5;

		// Token: 0x0401557A RID: 87418
		internal static int __PropertyOffset_6;

		// Token: 0x0401557B RID: 87419
		internal static int __PropertyOffset_7;

		// Token: 0x0401557C RID: 87420
		internal static int __PropertyOffset_8;

		// Token: 0x0401557D RID: 87421
		internal static int __PropertyOffset_9;

		// Token: 0x0401557E RID: 87422
		internal static int __PropertyOffset_10;

		// Token: 0x0401557F RID: 87423
		internal static int __PropertyOffset_11;

		// Token: 0x04015580 RID: 87424
		internal static int __PropertyOffset_12;

		// Token: 0x04015581 RID: 87425
		internal static int __PropertyOffset_13;

		// Token: 0x04015582 RID: 87426
		internal static int __PropertyOffset_14;

		// Token: 0x04015583 RID: 87427
		internal static int __PropertyOffset_15;

		// Token: 0x04015584 RID: 87428
		internal static int __PropertyOffset_16;

		// Token: 0x04015585 RID: 87429
		internal static int __PropertyOffset_17;

		// Token: 0x04015586 RID: 87430
		[Nullable(2)]
		private TArray<float> _DamageHitDelay;

		// Token: 0x04015587 RID: 87431
		internal static int __PropertyOffset_18;

		// Token: 0x04015588 RID: 87432
		internal static int __PropertyOffset_19;

		// Token: 0x04015589 RID: 87433
		internal static int __PropertyOffset_20;
	}
}
