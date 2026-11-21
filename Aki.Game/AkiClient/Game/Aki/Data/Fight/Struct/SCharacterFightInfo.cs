using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003203 RID: 12803
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCharacterFightInfo.SCharacterFightInfo")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 737)]
	public class SCharacterFightInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDF8 RID: 130552 RVA: 0x00937DCF File Offset: 0x00935FCF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterFightInfo._ScriptStructPtr != 0) ? SCharacterFightInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCharacterFightInfo.SCharacterFightInfo", ref SCharacterFightInfo._ScriptStructPtr);
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0601FDF9 RID: 130553 RVA: 0x00937DF3 File Offset: 0x00935FF3
		// (set) Token: 0x0601FDFA RID: 130554 RVA: 0x00937E12 File Offset: 0x00936012
		public TSoftObjectPtr<UDataTable> SkillDataTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_SkillDataTable, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_SkillDataTable, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0601FDFB RID: 130555 RVA: 0x00937E37 File Offset: 0x00936037
		// (set) Token: 0x0601FDFC RID: 130556 RVA: 0x00937E56 File Offset: 0x00936056
		public TSoftObjectPtr<UDataTable> BulletDataTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_BulletDataTable, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_BulletDataTable, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0601FDFD RID: 130557 RVA: 0x00937E7B File Offset: 0x0093607B
		// (set) Token: 0x0601FDFE RID: 130558 RVA: 0x00937E9A File Offset: 0x0093609A
		public TSoftObjectPtr<UPrimaryDataAsset> PartHitEffect
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_PartHitEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_PartHitEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0601FDFF RID: 130559 RVA: 0x00937EBF File Offset: 0x009360BF
		// (set) Token: 0x0601FE00 RID: 130560 RVA: 0x00937EDE File Offset: 0x009360DE
		public TSoftObjectPtr<UDataTable> HitEffectTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_HitEffectTable, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_HitEffectTable, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0601FE01 RID: 130561 RVA: 0x00937F04 File Offset: 0x00936104
		// (set) Token: 0x0601FE02 RID: 130562 RVA: 0x00937F47 File Offset: 0x00936147
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> SkillDataTableMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> result;
				if ((result = this._SkillDataTableMap) == null)
				{
					result = (this._SkillDataTableMap = new TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_SkillDataTableMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.SkillDataTableMap.CopyAssign(value);
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0601FE03 RID: 130563 RVA: 0x00937F58 File Offset: 0x00936158
		// (set) Token: 0x0601FE04 RID: 130564 RVA: 0x00937F9B File Offset: 0x0093619B
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> BulletDataTableMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> result;
				if ((result = this._BulletDataTableMap) == null)
				{
					result = (this._BulletDataTableMap = new TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_BulletDataTableMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.BulletDataTableMap.CopyAssign(value);
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0601FE05 RID: 130565 RVA: 0x00937FAC File Offset: 0x009361AC
		// (set) Token: 0x0601FE06 RID: 130566 RVA: 0x00937FEF File Offset: 0x009361EF
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> HitEffectTableMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> result;
				if ((result = this._HitEffectTableMap) == null)
				{
					result = (this._HitEffectTableMap = new TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_HitEffectTableMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.HitEffectTableMap.CopyAssign(value);
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0601FE07 RID: 130567 RVA: 0x00938000 File Offset: 0x00936200
		// (set) Token: 0x0601FE08 RID: 130568 RVA: 0x00938043 File Offset: 0x00936243
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> BpInputMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> result;
				if ((result = this._BpInputMap) == null)
				{
					result = (this._BpInputMap = new TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_BpInputMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.BpInputMap.CopyAssign(value);
			}
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0601FE09 RID: 130569 RVA: 0x00938051 File Offset: 0x00936251
		// (set) Token: 0x0601FE0A RID: 130570 RVA: 0x00938070 File Offset: 0x00936270
		public TSoftClassPtr<TsBaseCharacter> LinkCharacter
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_LinkCharacter, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_LinkCharacter, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0601FE0B RID: 130571 RVA: 0x00938095 File Offset: 0x00936295
		// (set) Token: 0x0601FE0C RID: 130572 RVA: 0x009380B4 File Offset: 0x009362B4
		public TSoftObjectPtr<UDataTable> CustomParamTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_CustomParamTable, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_CustomParamTable, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0601FE0D RID: 130573 RVA: 0x009380DC File Offset: 0x009362DC
		// (set) Token: 0x0601FE0E RID: 130574 RVA: 0x0093811F File Offset: 0x0093631F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> MorphModelInfoMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> result;
				if ((result = this._MorphModelInfoMap) == null)
				{
					result = (this._MorphModelInfoMap = new TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_MorphModelInfoMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.MorphModelInfoMap.CopyAssign(value);
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0601FE0F RID: 130575 RVA: 0x0093812D File Offset: 0x0093632D
		// (set) Token: 0x0601FE10 RID: 130576 RVA: 0x0093814C File Offset: 0x0093634C
		public TSoftObjectPtr<UDataTable> KuroBulletDataTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_KuroBulletDataTable, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_KuroBulletDataTable, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0601FE11 RID: 130577 RVA: 0x00938171 File Offset: 0x00936371
		// (set) Token: 0x0601FE12 RID: 130578 RVA: 0x00938181 File Offset: 0x00936381
		public unsafe bool IsDarkTide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_IsDarkTide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_IsDarkTide) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FE13 RID: 130579 RVA: 0x00938192 File Offset: 0x00936392
		public SCharacterFightInfo()
		{
		}

		// Token: 0x0601FE14 RID: 130580 RVA: 0x0093819A File Offset: 0x0093639A
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterFightInfo.StaticStruct();
		}

		// Token: 0x0601FE15 RID: 130581 RVA: 0x009381A6 File Offset: 0x009363A6
		[NullableContext(2)]
		public SCharacterFightInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE16 RID: 130582 RVA: 0x009381B0 File Offset: 0x009363B0
		public SCharacterFightInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE17 RID: 130583 RVA: 0x009381BB File Offset: 0x009363BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterFightInfo(Pointer, false, true);
		}

		// Token: 0x0601FE18 RID: 130584 RVA: 0x009381C5 File Offset: 0x009363C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterFightInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040111DB RID: 70107
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCharacterFightInfo.SCharacterFightInfo";

		// Token: 0x040111DC RID: 70108
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111DD RID: 70109
		internal static int __PropertyOffset_SkillDataTable;

		// Token: 0x040111DE RID: 70110
		internal static int __PropertyOffset_BulletDataTable;

		// Token: 0x040111DF RID: 70111
		internal static int __PropertyOffset_PartHitEffect;

		// Token: 0x040111E0 RID: 70112
		internal static int __PropertyOffset_HitEffectTable;

		// Token: 0x040111E1 RID: 70113
		internal static int __PropertyOffset_SkillDataTableMap;

		// Token: 0x040111E2 RID: 70114
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> _SkillDataTableMap;

		// Token: 0x040111E3 RID: 70115
		internal static int __PropertyOffset_BulletDataTableMap;

		// Token: 0x040111E4 RID: 70116
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> _BulletDataTableMap;

		// Token: 0x040111E5 RID: 70117
		internal static int __PropertyOffset_HitEffectTableMap;

		// Token: 0x040111E6 RID: 70118
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> _HitEffectTableMap;

		// Token: 0x040111E7 RID: 70119
		internal static int __PropertyOffset_BpInputMap;

		// Token: 0x040111E8 RID: 70120
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> _BpInputMap;

		// Token: 0x040111E9 RID: 70121
		internal static int __PropertyOffset_LinkCharacter;

		// Token: 0x040111EA RID: 70122
		internal static int __PropertyOffset_CustomParamTable;

		// Token: 0x040111EB RID: 70123
		internal static int __PropertyOffset_MorphModelInfoMap;

		// Token: 0x040111EC RID: 70124
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> _MorphModelInfoMap;

		// Token: 0x040111ED RID: 70125
		internal static int __PropertyOffset_KuroBulletDataTable;

		// Token: 0x040111EE RID: 70126
		internal static int __PropertyOffset_IsDarkTide;
	}
}
