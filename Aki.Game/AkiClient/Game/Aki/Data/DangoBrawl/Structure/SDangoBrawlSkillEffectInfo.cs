using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.DangoBrawl.Structure
{
	// Token: 0x0200322A RID: 12842
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/DangoBrawl/Structure/SDangoBrawlSkillEffectInfo.SDangoBrawlSkillEffectInfo")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 289)]
	public class SDangoBrawlSkillEffectInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060200DB RID: 131291 RVA: 0x0093C251 File Offset: 0x0093A451
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDangoBrawlSkillEffectInfo._ScriptStructPtr != 0) ? SDangoBrawlSkillEffectInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/DangoBrawl/Structure/SDangoBrawlSkillEffectInfo.SDangoBrawlSkillEffectInfo", ref SDangoBrawlSkillEffectInfo._ScriptStructPtr);
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x060200DC RID: 131292 RVA: 0x0093C275 File Offset: 0x0093A475
		// (set) Token: 0x060200DD RID: 131293 RVA: 0x0093C285 File Offset: 0x0093A485
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x060200DE RID: 131294 RVA: 0x0093C296 File Offset: 0x0093A496
		// (set) Token: 0x060200DF RID: 131295 RVA: 0x0093C2B5 File Offset: 0x0093A4B5
		public TSoftObjectPtr<UPrimaryDataAsset> WeaponAssetPath
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_WeaponAssetPath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_WeaponAssetPath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x060200E0 RID: 131296 RVA: 0x0093C2DA File Offset: 0x0093A4DA
		// (set) Token: 0x060200E1 RID: 131297 RVA: 0x0093C2EA File Offset: 0x0093A4EA
		public unsafe bool WeaponTargetSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_WeaponTargetSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_WeaponTargetSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x060200E2 RID: 131298 RVA: 0x0093C2FB File Offset: 0x0093A4FB
		// (set) Token: 0x060200E3 RID: 131299 RVA: 0x0093C30F File Offset: 0x0093A50F
		public unsafe FVector WeaponOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_WeaponOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_WeaponOffset) = value;
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x060200E4 RID: 131300 RVA: 0x0093C324 File Offset: 0x0093A524
		// (set) Token: 0x060200E5 RID: 131301 RVA: 0x0093C343 File Offset: 0x0093A543
		public TSoftObjectPtr<UPrimaryDataAsset> SkillAssetPath
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillAssetPath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillAssetPath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x060200E6 RID: 131302 RVA: 0x0093C368 File Offset: 0x0093A568
		// (set) Token: 0x060200E7 RID: 131303 RVA: 0x0093C378 File Offset: 0x0093A578
		public unsafe bool SkillTargetSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillTargetSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillTargetSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x060200E8 RID: 131304 RVA: 0x0093C389 File Offset: 0x0093A589
		// (set) Token: 0x060200E9 RID: 131305 RVA: 0x0093C39D File Offset: 0x0093A59D
		public unsafe FVector SkillOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillOffset) = value;
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x060200EA RID: 131306 RVA: 0x0093C3B2 File Offset: 0x0093A5B2
		// (set) Token: 0x060200EB RID: 131307 RVA: 0x0093C3C2 File Offset: 0x0093A5C2
		public unsafe float SkillMoveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillMoveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillMoveTime) = value;
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x060200EC RID: 131308 RVA: 0x0093C3D3 File Offset: 0x0093A5D3
		// (set) Token: 0x060200ED RID: 131309 RVA: 0x0093C3E7 File Offset: 0x0093A5E7
		[Nullable(2)]
		public unsafe UCurveFloat SkillCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SDangoBrawlSkillEffectInfo.__PropertyOffset_SkillCurve, value);
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x060200EE RID: 131310 RVA: 0x0093C3FC File Offset: 0x0093A5FC
		// (set) Token: 0x060200EF RID: 131311 RVA: 0x0093C41B File Offset: 0x0093A61B
		public TSoftObjectPtr<UPrimaryDataAsset> HitAssetPath
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_HitAssetPath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_HitAssetPath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x060200F0 RID: 131312 RVA: 0x0093C440 File Offset: 0x0093A640
		// (set) Token: 0x060200F1 RID: 131313 RVA: 0x0093C450 File Offset: 0x0093A650
		public unsafe bool HitTargetSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_HitTargetSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_HitTargetSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x060200F2 RID: 131314 RVA: 0x0093C461 File Offset: 0x0093A661
		// (set) Token: 0x060200F3 RID: 131315 RVA: 0x0093C475 File Offset: 0x0093A675
		public unsafe FVector HitOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_HitOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_HitOffset) = value;
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x060200F4 RID: 131316 RVA: 0x0093C48A File Offset: 0x0093A68A
		// (set) Token: 0x060200F5 RID: 131317 RVA: 0x0093C49E File Offset: 0x0093A69E
		public unsafe string OffsetGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_OffsetGroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_OffsetGroupName)), value);
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x060200F6 RID: 131318 RVA: 0x0093C4B3 File Offset: 0x0093A6B3
		// (set) Token: 0x060200F7 RID: 131319 RVA: 0x0093C4C3 File Offset: 0x0093A6C3
		public unsafe float RandomDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_RandomDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_RandomDistance) = value;
			}
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x060200F8 RID: 131320 RVA: 0x0093C4D4 File Offset: 0x0093A6D4
		// (set) Token: 0x060200F9 RID: 131321 RVA: 0x0093C4E8 File Offset: 0x0093A6E8
		public unsafe FVector OffsetMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_OffsetMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_OffsetMax) = value;
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x060200FA RID: 131322 RVA: 0x0093C4FD File Offset: 0x0093A6FD
		// (set) Token: 0x060200FB RID: 131323 RVA: 0x0093C511 File Offset: 0x0093A711
		public unsafe FVector OffsetMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_OffsetMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_OffsetMin) = value;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x060200FC RID: 131324 RVA: 0x0093C526 File Offset: 0x0093A726
		// (set) Token: 0x060200FD RID: 131325 RVA: 0x0093C536 File Offset: 0x0093A736
		public unsafe float PlayTimeDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_PlayTimeDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_PlayTimeDelay) = value;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x060200FE RID: 131326 RVA: 0x0093C548 File Offset: 0x0093A748
		// (set) Token: 0x060200FF RID: 131327 RVA: 0x0093C58B File Offset: 0x0093A78B
		public TArray<float> DamageHitDelay
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DamageHitDelay) == null)
				{
					result = (this._DamageHitDelay = new TArray<float>(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_DamageHitDelay, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DamageHitDelay.CopyAssign(value);
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x06020100 RID: 131328 RVA: 0x0093C599 File Offset: 0x0093A799
		// (set) Token: 0x06020101 RID: 131329 RVA: 0x0093C5A9 File Offset: 0x0093A7A9
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x06020102 RID: 131330 RVA: 0x0093C5BA File Offset: 0x0093A7BA
		// (set) Token: 0x06020103 RID: 131331 RVA: 0x0093C5CA File Offset: 0x0093A7CA
		public unsafe float MontageLoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_MontageLoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_MontageLoopTime) = value;
			}
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x06020104 RID: 131332 RVA: 0x0093C5DB File Offset: 0x0093A7DB
		// (set) Token: 0x06020105 RID: 131333 RVA: 0x0093C5EB File Offset: 0x0093A7EB
		public unsafe bool TowardOpposite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_TowardOpposite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoBrawlSkillEffectInfo.__PropertyOffset_TowardOpposite) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020106 RID: 131334 RVA: 0x0093C5FC File Offset: 0x0093A7FC
		public SDangoBrawlSkillEffectInfo()
		{
		}

		// Token: 0x06020107 RID: 131335 RVA: 0x0093C604 File Offset: 0x0093A804
		protected override IntPtr GetUStructPtr()
		{
			return SDangoBrawlSkillEffectInfo.StaticStruct();
		}

		// Token: 0x06020108 RID: 131336 RVA: 0x0093C610 File Offset: 0x0093A810
		[NullableContext(2)]
		public SDangoBrawlSkillEffectInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020109 RID: 131337 RVA: 0x0093C61A File Offset: 0x0093A81A
		public SDangoBrawlSkillEffectInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602010A RID: 131338 RVA: 0x0093C625 File Offset: 0x0093A825
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDangoBrawlSkillEffectInfo(Pointer, false, true);
		}

		// Token: 0x0602010B RID: 131339 RVA: 0x0093C62F File Offset: 0x0093A82F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDangoBrawlSkillEffectInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040113BB RID: 70587
		public const string __ObjectPath = "/Game/Aki/Data/DangoBrawl/Structure/SDangoBrawlSkillEffectInfo.SDangoBrawlSkillEffectInfo";

		// Token: 0x040113BC RID: 70588
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040113BD RID: 70589
		internal static int __PropertyOffset_Id;

		// Token: 0x040113BE RID: 70590
		internal static int __PropertyOffset_WeaponAssetPath;

		// Token: 0x040113BF RID: 70591
		internal static int __PropertyOffset_WeaponTargetSelf;

		// Token: 0x040113C0 RID: 70592
		internal static int __PropertyOffset_WeaponOffset;

		// Token: 0x040113C1 RID: 70593
		internal static int __PropertyOffset_SkillAssetPath;

		// Token: 0x040113C2 RID: 70594
		internal static int __PropertyOffset_SkillTargetSelf;

		// Token: 0x040113C3 RID: 70595
		internal static int __PropertyOffset_SkillOffset;

		// Token: 0x040113C4 RID: 70596
		internal static int __PropertyOffset_SkillMoveTime;

		// Token: 0x040113C5 RID: 70597
		internal static int __PropertyOffset_SkillCurve;

		// Token: 0x040113C6 RID: 70598
		internal static int __PropertyOffset_HitAssetPath;

		// Token: 0x040113C7 RID: 70599
		internal static int __PropertyOffset_HitTargetSelf;

		// Token: 0x040113C8 RID: 70600
		internal static int __PropertyOffset_HitOffset;

		// Token: 0x040113C9 RID: 70601
		internal static int __PropertyOffset_OffsetGroupName;

		// Token: 0x040113CA RID: 70602
		internal static int __PropertyOffset_RandomDistance;

		// Token: 0x040113CB RID: 70603
		internal static int __PropertyOffset_OffsetMax;

		// Token: 0x040113CC RID: 70604
		internal static int __PropertyOffset_OffsetMin;

		// Token: 0x040113CD RID: 70605
		internal static int __PropertyOffset_PlayTimeDelay;

		// Token: 0x040113CE RID: 70606
		internal static int __PropertyOffset_DamageHitDelay;

		// Token: 0x040113CF RID: 70607
		[Nullable(2)]
		private TArray<float> _DamageHitDelay;

		// Token: 0x040113D0 RID: 70608
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x040113D1 RID: 70609
		internal static int __PropertyOffset_MontageLoopTime;

		// Token: 0x040113D2 RID: 70610
		internal static int __PropertyOffset_TowardOpposite;
	}
}
