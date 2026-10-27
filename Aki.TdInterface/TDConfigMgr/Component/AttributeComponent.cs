using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000026 RID: 38
	[NullableContext(2)]
	[Nullable(0)]
	public class AttributeComponent : IComponentBase
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00015A34 File Offset: 0x00013C34
		[NullableContext(1)]
		private AttributeComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AttributeComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AttributeComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AttributeComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00015A6C File Offset: 0x00013C6C
		[NullableContext(1)]
		public static AttributeComponent Create([Nullable(2)] AttributeComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AttributeComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00015A7F File Offset: 0x00013C7F
		[NullableContext(1)]
		public static AttributeComponent CreateFromSetValue([Nullable(2)] AttributeComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AttributeComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00015A94 File Offset: 0x00013C94
		[NullableContext(1)]
		public new AttributeComponent_SetValue ToSetValue()
		{
			return new AttributeComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PropertyId = this.PropertyId,
				MonsterPropExtraRateId = this.MonsterPropExtraRateId,
				MonsterPropGrowthId = this.MonsterPropGrowthId,
				Level = this.Level,
				MoraleLevel = this.MoraleLevel,
				HonamiStoryMonsterGrowth = this.HonamiStoryMonsterGrowth,
				FlagChallengeMonsterLevel = this.FlagChallengeMonsterLevel,
				RageModeId = this.RageModeId,
				HardnessModeId = this.HardnessModeId,
				WorldLevelBonusId = this.WorldLevelBonusId,
				IgnoreFightMusic = this.IgnoreFightMusic,
				FightMusics = this.FightMusics,
				FightMusic = this.FightMusic,
				FightMusicBanRadioMusic = this.FightMusicBanRadioMusic,
				AppendBuffIds = this.AppendBuffIds,
				WorldLevelBonusType = this.WorldLevelBonusType
			};
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00015B80 File Offset: 0x00013D80
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00015BBA File Offset: 0x00013DBA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00015BC8 File Offset: 0x00013DC8
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00015BF2 File Offset: 0x00013DF2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00015C00 File Offset: 0x00013E00
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00015C2B File Offset: 0x00013E2B
		public virtual int PropertyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PropertyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PropertyId;
			}
			set
			{
				this.GetOrCreatePoco().PropertyId = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00015C39 File Offset: 0x00013E39
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00015C64 File Offset: 0x00013E64
		public virtual int MonsterPropExtraRateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterPropExtraRateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MonsterPropExtraRateId;
			}
			set
			{
				this.GetOrCreatePoco().MonsterPropExtraRateId = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00015C74 File Offset: 0x00013E74
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00015CAE File Offset: 0x00013EAE
		public virtual int? MonsterPropGrowthId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterPropGrowthId;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MonsterPropGrowthId;
			}
			set
			{
				this.GetOrCreatePoco().MonsterPropGrowthId = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00015CBC File Offset: 0x00013EBC
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00015CE7 File Offset: 0x00013EE7
		public virtual int Level
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Level;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Level;
			}
			set
			{
				this.GetOrCreatePoco().Level = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00015CF8 File Offset: 0x00013EF8
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00015D32 File Offset: 0x00013F32
		public virtual int? MoraleLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoraleLevel;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoraleLevel;
			}
			set
			{
				this.GetOrCreatePoco().MoraleLevel = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00015D40 File Offset: 0x00013F40
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00015D7A File Offset: 0x00013F7A
		public virtual int? HonamiStoryMonsterGrowth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HonamiStoryMonsterGrowth;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HonamiStoryMonsterGrowth;
			}
			set
			{
				this.GetOrCreatePoco().HonamiStoryMonsterGrowth = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00015D88 File Offset: 0x00013F88
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00015DC2 File Offset: 0x00013FC2
		public virtual int? FlagChallengeMonsterLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlagChallengeMonsterLevel;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FlagChallengeMonsterLevel;
			}
			set
			{
				this.GetOrCreatePoco().FlagChallengeMonsterLevel = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00015DD0 File Offset: 0x00013FD0
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00015DFB File Offset: 0x00013FFB
		public virtual int RageModeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RageModeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RageModeId;
			}
			set
			{
				this.GetOrCreatePoco().RageModeId = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00015E09 File Offset: 0x00014009
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00015E34 File Offset: 0x00014034
		public virtual int HardnessModeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HardnessModeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HardnessModeId;
			}
			set
			{
				this.GetOrCreatePoco().HardnessModeId = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00015E42 File Offset: 0x00014042
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00015E6D File Offset: 0x0001406D
		public virtual int WorldLevelBonusId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WorldLevelBonusId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WorldLevelBonusId;
			}
			set
			{
				this.GetOrCreatePoco().WorldLevelBonusId = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00015E7C File Offset: 0x0001407C
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00015EB6 File Offset: 0x000140B6
		public virtual bool? IgnoreFightMusic
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IgnoreFightMusic;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IgnoreFightMusic;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreFightMusic = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00015EC4 File Offset: 0x000140C4
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00015F25 File Offset: 0x00014125
		public virtual IFightMusicsSwitchByTagList FightMusics
		{
			get
			{
				if (this._FightMusicsInited)
				{
					return this._FightMusicsCache;
				}
				this._FightMusicsInited = true;
				if (this.FbInstance != null)
				{
					this._FightMusicsCache = IFightMusicsSwitchByTagList.Create(this.FbInstance.FightMusics);
				}
				else
				{
					AttributeComponent_SetValue pocoInterface = this.PocoInterface;
					this._FightMusicsCache = ((pocoInterface != null) ? pocoInterface.FightMusics : null);
				}
				return this._FightMusicsCache;
			}
			set
			{
				this.GetOrCreatePoco().FightMusics = value;
				this._FightMusicsInited = false;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00015F3A File Offset: 0x0001413A
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00015F61 File Offset: 0x00014161
		public virtual string FightMusic
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FightMusic;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FightMusic;
			}
			set
			{
				this.GetOrCreatePoco().FightMusic = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00015F70 File Offset: 0x00014170
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00015FAA File Offset: 0x000141AA
		public virtual bool? FightMusicBanRadioMusic
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FightMusicBanRadioMusic;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FightMusicBanRadioMusic;
			}
			set
			{
				this.GetOrCreatePoco().FightMusicBanRadioMusic = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00015FB8 File Offset: 0x000141B8
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00015FDF File Offset: 0x000141DF
		public virtual List<long> AppendBuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppendBuffIds;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppendBuffIds;
			}
			set
			{
				this.GetOrCreatePoco().AppendBuffIds = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00015FED File Offset: 0x000141ED
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00016014 File Offset: 0x00014214
		[Nullable(1)]
		public virtual IWorldLevelBonusType WorldLevelBonusType
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WorldLevelBonusType;
				}
				AttributeComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WorldLevelBonusType;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().WorldLevelBonusType = value;
			}
		}

		// Token: 0x04000093 RID: 147
		protected new AttributeComponent FbInstance;

		// Token: 0x04000094 RID: 148
		protected new AttributeComponent_SetValue PocoInterface;

		// Token: 0x04000095 RID: 149
		[Nullable(1)]
		private IFightMusicsSwitchByTagList _FightMusicsCache;

		// Token: 0x04000096 RID: 150
		private bool _FightMusicsInited;
	}
}
