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
		// Token: 0x060000EA RID: 234 RVA: 0x000163A8 File Offset: 0x000145A8
		[NullableContext(0)]
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

		// Token: 0x060000EB RID: 235 RVA: 0x000163E0 File Offset: 0x000145E0
		[NullableContext(0)]
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

		// Token: 0x060000EC RID: 236 RVA: 0x000163F3 File Offset: 0x000145F3
		[NullableContext(0)]
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

		// Token: 0x060000ED RID: 237 RVA: 0x00016408 File Offset: 0x00014608
		[NullableContext(0)]
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000164F4 File Offset: 0x000146F4
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0001652E File Offset: 0x0001472E
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0001653C File Offset: 0x0001473C
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00016566 File Offset: 0x00014766
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00016574 File Offset: 0x00014774
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0001659F File Offset: 0x0001479F
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000165AD File Offset: 0x000147AD
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000165D8 File Offset: 0x000147D8
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000165E8 File Offset: 0x000147E8
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00016622 File Offset: 0x00014822
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00016630 File Offset: 0x00014830
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0001665B File Offset: 0x0001485B
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0001666C File Offset: 0x0001486C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000166A6 File Offset: 0x000148A6
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000166B4 File Offset: 0x000148B4
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000166EE File Offset: 0x000148EE
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000166FC File Offset: 0x000148FC
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00016736 File Offset: 0x00014936
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00016744 File Offset: 0x00014944
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0001676F File Offset: 0x0001496F
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0001677D File Offset: 0x0001497D
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000167A8 File Offset: 0x000149A8
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000167B6 File Offset: 0x000149B6
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000167E1 File Offset: 0x000149E1
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000167F0 File Offset: 0x000149F0
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0001682A File Offset: 0x00014A2A
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00016838 File Offset: 0x00014A38
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00016899 File Offset: 0x00014A99
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000168AE File Offset: 0x00014AAE
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000168D5 File Offset: 0x00014AD5
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000168E4 File Offset: 0x00014AE4
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0001691E File Offset: 0x00014B1E
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0001692C File Offset: 0x00014B2C
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00016953 File Offset: 0x00014B53
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00016961 File Offset: 0x00014B61
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00016988 File Offset: 0x00014B88
		[Nullable(0)]
		public virtual IWorldLevelBonusType WorldLevelBonusType
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().WorldLevelBonusType = value;
			}
		}

		// Token: 0x04000098 RID: 152
		protected new AttributeComponent FbInstance;

		// Token: 0x04000099 RID: 153
		protected new AttributeComponent_SetValue PocoInterface;

		// Token: 0x0400009A RID: 154
		[Nullable(0)]
		private IFightMusicsSwitchByTagList _FightMusicsCache;

		// Token: 0x0400009B RID: 155
		private bool _FightMusicsInited;
	}
}
