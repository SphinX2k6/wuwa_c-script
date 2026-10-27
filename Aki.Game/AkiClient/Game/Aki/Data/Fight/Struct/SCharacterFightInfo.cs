using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F61 RID: 16225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCharacterFightInfo.SCharacterFightInfo")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 737)]
	public class SCharacterFightInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602955A RID: 169306 RVA: 0x009C1948 File Offset: 0x009BFB48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterFightInfo._ScriptStructPtr != 0) ? SCharacterFightInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCharacterFightInfo.SCharacterFightInfo", ref SCharacterFightInfo._ScriptStructPtr);
		}

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x0602955B RID: 169307 RVA: 0x009C196C File Offset: 0x009BFB6C
		// (set) Token: 0x0602955C RID: 169308 RVA: 0x009C198B File Offset: 0x009BFB8B
		public TSoftObjectPtr<UDataTable> SkillDataTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x0602955D RID: 169309 RVA: 0x009C19B0 File Offset: 0x009BFBB0
		// (set) Token: 0x0602955E RID: 169310 RVA: 0x009C19CF File Offset: 0x009BFBCF
		public TSoftObjectPtr<UDataTable> BulletDataTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x0602955F RID: 169311 RVA: 0x009C19F4 File Offset: 0x009BFBF4
		// (set) Token: 0x06029560 RID: 169312 RVA: 0x009C1A13 File Offset: 0x009BFC13
		public TSoftObjectPtr<UPrimaryDataAsset> PartHitEffect
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x06029561 RID: 169313 RVA: 0x009C1A38 File Offset: 0x009BFC38
		// (set) Token: 0x06029562 RID: 169314 RVA: 0x009C1A57 File Offset: 0x009BFC57
		public TSoftObjectPtr<UDataTable> HitEffectTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x06029563 RID: 169315 RVA: 0x009C1A7C File Offset: 0x009BFC7C
		// (set) Token: 0x06029564 RID: 169316 RVA: 0x009C1ABF File Offset: 0x009BFCBF
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
					result = (this._SkillDataTableMap = new TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
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

		// Token: 0x170062B3 RID: 25267
		// (get) Token: 0x06029565 RID: 169317 RVA: 0x009C1AD0 File Offset: 0x009BFCD0
		// (set) Token: 0x06029566 RID: 169318 RVA: 0x009C1B13 File Offset: 0x009BFD13
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
					result = (this._BulletDataTableMap = new TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_5, base.MemoryOwner ?? this));
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

		// Token: 0x170062B4 RID: 25268
		// (get) Token: 0x06029567 RID: 169319 RVA: 0x009C1B24 File Offset: 0x009BFD24
		// (set) Token: 0x06029568 RID: 169320 RVA: 0x009C1B67 File Offset: 0x009BFD67
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
					result = (this._HitEffectTableMap = new TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_6, base.MemoryOwner ?? this));
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

		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x06029569 RID: 169321 RVA: 0x009C1B78 File Offset: 0x009BFD78
		// (set) Token: 0x0602956A RID: 169322 RVA: 0x009C1BBB File Offset: 0x009BFDBB
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
					result = (this._BpInputMap = new TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_7, base.MemoryOwner ?? this));
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

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x0602956B RID: 169323 RVA: 0x009C1BC9 File Offset: 0x009BFDC9
		// (set) Token: 0x0602956C RID: 169324 RVA: 0x009C1BE8 File Offset: 0x009BFDE8
		public TSoftClassPtr<TsBaseCharacter> LinkCharacter
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_8, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x0602956D RID: 169325 RVA: 0x009C1C0D File Offset: 0x009BFE0D
		// (set) Token: 0x0602956E RID: 169326 RVA: 0x009C1C2C File Offset: 0x009BFE2C
		public TSoftObjectPtr<UDataTable> CustomParamTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_9, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x0602956F RID: 169327 RVA: 0x009C1C54 File Offset: 0x009BFE54
		// (set) Token: 0x06029570 RID: 169328 RVA: 0x009C1C97 File Offset: 0x009BFE97
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
					result = (this._MorphModelInfoMap = new TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_10, base.MemoryOwner ?? this));
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

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x06029571 RID: 169329 RVA: 0x009C1CA5 File Offset: 0x009BFEA5
		// (set) Token: 0x06029572 RID: 169330 RVA: 0x009C1CC4 File Offset: 0x009BFEC4
		public TSoftObjectPtr<UDataTable> KuroBulletDataTable
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_11, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x06029573 RID: 169331 RVA: 0x009C1CE9 File Offset: 0x009BFEE9
		// (set) Token: 0x06029574 RID: 169332 RVA: 0x009C1CF9 File Offset: 0x009BFEF9
		public unsafe bool IsDarkTide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFightInfo.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029575 RID: 169333 RVA: 0x009C1D0A File Offset: 0x009BFF0A
		public SCharacterFightInfo()
		{
		}

		// Token: 0x06029576 RID: 169334 RVA: 0x009C1D14 File Offset: 0x009BFF14
		public SCharacterFightInfo(TSoftObjectPtr<UDataTable> SkillDataTable, TSoftObjectPtr<UDataTable> BulletDataTable, TSoftObjectPtr<UPrimaryDataAsset> PartHitEffect, TSoftObjectPtr<UDataTable> HitEffectTable, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> SkillDataTableMap, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> BulletDataTableMap, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> HitEffectTableMap, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> BpInputMap, TSoftClassPtr<TsBaseCharacter> LinkCharacter, TSoftObjectPtr<UDataTable> CustomParamTable, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> MorphModelInfoMap, TSoftObjectPtr<UDataTable> KuroBulletDataTable, bool IsDarkTide)
		{
			this.SkillDataTable = SkillDataTable;
			this.BulletDataTable = BulletDataTable;
			this.PartHitEffect = PartHitEffect;
			this.HitEffectTable = HitEffectTable;
			this.SkillDataTableMap = SkillDataTableMap;
			this.BulletDataTableMap = BulletDataTableMap;
			this.HitEffectTableMap = HitEffectTableMap;
			this.BpInputMap = BpInputMap;
			this.LinkCharacter = LinkCharacter;
			this.CustomParamTable = CustomParamTable;
			this.MorphModelInfoMap = MorphModelInfoMap;
			this.KuroBulletDataTable = KuroBulletDataTable;
			this.IsDarkTide = IsDarkTide;
		}

		// Token: 0x06029577 RID: 169335 RVA: 0x009C1D8C File Offset: 0x009BFF8C
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterFightInfo.StaticStruct();
		}

		// Token: 0x06029578 RID: 169336 RVA: 0x009C1D98 File Offset: 0x009BFF98
		[NullableContext(2)]
		public SCharacterFightInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029579 RID: 169337 RVA: 0x009C1DA2 File Offset: 0x009BFFA2
		public SCharacterFightInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602957A RID: 169338 RVA: 0x009C1DAD File Offset: 0x009BFFAD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterFightInfo(Pointer, false, true);
		}

		// Token: 0x0602957B RID: 169339 RVA: 0x009C1DB7 File Offset: 0x009BFFB7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterFightInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040152DC RID: 86748
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCharacterFightInfo.SCharacterFightInfo";

		// Token: 0x040152DD RID: 86749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152DE RID: 86750
		internal static int __PropertyOffset_0;

		// Token: 0x040152DF RID: 86751
		internal static int __PropertyOffset_1;

		// Token: 0x040152E0 RID: 86752
		internal static int __PropertyOffset_2;

		// Token: 0x040152E1 RID: 86753
		internal static int __PropertyOffset_3;

		// Token: 0x040152E2 RID: 86754
		internal static int __PropertyOffset_4;

		// Token: 0x040152E3 RID: 86755
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> _SkillDataTableMap;

		// Token: 0x040152E4 RID: 86756
		internal static int __PropertyOffset_5;

		// Token: 0x040152E5 RID: 86757
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> _BulletDataTableMap;

		// Token: 0x040152E6 RID: 86758
		internal static int __PropertyOffset_6;

		// Token: 0x040152E7 RID: 86759
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, TSoftObjectPtr<UDataTable>> _HitEffectTableMap;

		// Token: 0x040152E8 RID: 86760
		internal static int __PropertyOffset_7;

		// Token: 0x040152E9 RID: 86761
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> _BpInputMap;

		// Token: 0x040152EA RID: 86762
		internal static int __PropertyOffset_8;

		// Token: 0x040152EB RID: 86763
		internal static int __PropertyOffset_9;

		// Token: 0x040152EC RID: 86764
		internal static int __PropertyOffset_10;

		// Token: 0x040152ED RID: 86765
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> _MorphModelInfoMap;

		// Token: 0x040152EE RID: 86766
		internal static int __PropertyOffset_11;

		// Token: 0x040152EF RID: 86767
		internal static int __PropertyOffset_12;
	}
}
