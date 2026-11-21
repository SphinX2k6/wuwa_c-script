using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B67 RID: 2919
	[NullableContext(2)]
	[Nullable(0)]
	public class AttributeComponent : IComponentBase
	{
		// Token: 0x0600429A RID: 17050 RVA: 0x000A91AE File Offset: 0x000A73AE
		[NullableContext(0)]
		public static AttributeComponent Create(IAttributeComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AttributeComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x000A91D0 File Offset: 0x000A73D0
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x000A9208 File Offset: 0x000A7408
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x000A921E File Offset: 0x000A741E
		public virtual int PropertyId
		{
			get
			{
				return this.Instance.PropertyId;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x000A922B File Offset: 0x000A742B
		public virtual int MonsterPropExtraRateId
		{
			get
			{
				return this.Instance.MonsterPropExtraRateId;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x000A9238 File Offset: 0x000A7438
		public virtual int? MonsterPropGrowthId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MonsterPropGrowthId);
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x000A926E File Offset: 0x000A746E
		public virtual int Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x000A927C File Offset: 0x000A747C
		public virtual int? MoraleLevel
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MoraleLevel);
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x000A92B4 File Offset: 0x000A74B4
		public virtual int? HonamiStoryMonsterGrowth
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HonamiStoryMonsterGrowth);
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x000A92EC File Offset: 0x000A74EC
		public virtual int? FlagChallengeMonsterLevel
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FlagChallengeMonsterLevel);
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x000A9323 File Offset: 0x000A7523
		public virtual int RageModeId
		{
			get
			{
				return this.Instance.RageModeId;
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x000A9330 File Offset: 0x000A7530
		public virtual int HardnessModeId
		{
			get
			{
				return this.Instance.HardnessModeId;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x000A933D File Offset: 0x000A753D
		public virtual int WorldLevelBonusId
		{
			get
			{
				return this.Instance.WorldLevelBonusId;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x000A934C File Offset: 0x000A754C
		public virtual bool? IgnoreFightMusic
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IgnoreFightMusic);
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x000A9383 File Offset: 0x000A7583
		public virtual IFightMusicsSwitchByTagList FightMusics
		{
			get
			{
				if (this._FightMusicsInited)
				{
					return this._FightMusicsCache;
				}
				this._FightMusicsInited = true;
				this._FightMusicsCache = IFightMusicsSwitchByTagList.Create(this.Instance.FightMusics);
				return this._FightMusicsCache;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x000A93B7 File Offset: 0x000A75B7
		public virtual string FightMusic
		{
			get
			{
				return this.Instance.FightMusic;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x000A93C4 File Offset: 0x000A75C4
		public virtual bool? FightMusicBanRadioMusic
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.FightMusicBanRadioMusic);
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x000A93FC File Offset: 0x000A75FC
		public virtual List<long> AppendBuffIds
		{
			get
			{
				if (this._AppendBuffIdsInited)
				{
					return this._AppendBuffIdsCache;
				}
				this._AppendBuffIdsInited = true;
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				int appendBuffIdsLength = this.Instance.AppendBuffIdsLength;
				this._AppendBuffIdsCache = new List<long>(appendBuffIdsLength);
				for (int i = 0; i < appendBuffIdsLength; i++)
				{
					this._AppendBuffIdsCache.Add(this.Instance.AppendBuffIds(i));
				}
				return this._AppendBuffIdsCache;
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x000A9475 File Offset: 0x000A7675
		[Nullable(0)]
		public virtual IWorldLevelBonusType WorldLevelBonusType
		{
			[NullableContext(0)]
			get
			{
				if (this._WorldLevelBonusTypeInited)
				{
					return this._WorldLevelBonusTypeCache;
				}
				this._WorldLevelBonusTypeInited = true;
				this._WorldLevelBonusTypeCache = ComponentReadHelper.ReadAttributeComponent_WorldLevelBonusType(this.Instance);
				return this._WorldLevelBonusTypeCache;
			}
		}

		// Token: 0x040024E2 RID: 9442
		private IAttributeComponent Instance;

		// Token: 0x040024E3 RID: 9443
		private IFightMusicsSwitchByTagList _FightMusicsCache;

		// Token: 0x040024E4 RID: 9444
		private bool _FightMusicsInited;

		// Token: 0x040024E5 RID: 9445
		private List<long> _AppendBuffIdsCache;

		// Token: 0x040024E6 RID: 9446
		private bool _AppendBuffIdsInited;

		// Token: 0x040024E7 RID: 9447
		[Nullable(0)]
		private IWorldLevelBonusType _WorldLevelBonusTypeCache;

		// Token: 0x040024E8 RID: 9448
		private bool _WorldLevelBonusTypeInited;
	}
}
