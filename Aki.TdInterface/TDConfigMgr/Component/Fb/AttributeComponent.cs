using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A9D RID: 2717
	[NullableContext(2)]
	[Nullable(0)]
	public class AttributeComponent : IComponentBase
	{
		// Token: 0x06003E71 RID: 15985 RVA: 0x0009FBF6 File Offset: 0x0009DDF6
		[NullableContext(1)]
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x0009FC18 File Offset: 0x0009DE18
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x0009FC50 File Offset: 0x0009DE50
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x0009FC66 File Offset: 0x0009DE66
		public virtual int PropertyId
		{
			get
			{
				return this.Instance.PropertyId;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x0009FC73 File Offset: 0x0009DE73
		public virtual int MonsterPropExtraRateId
		{
			get
			{
				return this.Instance.MonsterPropExtraRateId;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x0009FC80 File Offset: 0x0009DE80
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003E77 RID: 15991 RVA: 0x0009FCB6 File Offset: 0x0009DEB6
		public virtual int Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x0009FCC4 File Offset: 0x0009DEC4
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

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003E79 RID: 15993 RVA: 0x0009FCFC File Offset: 0x0009DEFC
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

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x0009FD34 File Offset: 0x0009DF34
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

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06003E7B RID: 15995 RVA: 0x0009FD6B File Offset: 0x0009DF6B
		public virtual int RageModeId
		{
			get
			{
				return this.Instance.RageModeId;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x0009FD78 File Offset: 0x0009DF78
		public virtual int HardnessModeId
		{
			get
			{
				return this.Instance.HardnessModeId;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x0009FD85 File Offset: 0x0009DF85
		public virtual int WorldLevelBonusId
		{
			get
			{
				return this.Instance.WorldLevelBonusId;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x0009FD94 File Offset: 0x0009DF94
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

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x0009FDCB File Offset: 0x0009DFCB
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

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x0009FDFF File Offset: 0x0009DFFF
		public virtual string FightMusic
		{
			get
			{
				return this.Instance.FightMusic;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x0009FE0C File Offset: 0x0009E00C
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

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06003E82 RID: 16002 RVA: 0x0009FE44 File Offset: 0x0009E044
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

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x0009FEBD File Offset: 0x0009E0BD
		[Nullable(1)]
		public virtual IWorldLevelBonusType WorldLevelBonusType
		{
			[NullableContext(1)]
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

		// Token: 0x040022C6 RID: 8902
		private IAttributeComponent Instance;

		// Token: 0x040022C7 RID: 8903
		private IFightMusicsSwitchByTagList _FightMusicsCache;

		// Token: 0x040022C8 RID: 8904
		private bool _FightMusicsInited;

		// Token: 0x040022C9 RID: 8905
		private List<long> _AppendBuffIdsCache;

		// Token: 0x040022CA RID: 8906
		private bool _AppendBuffIdsInited;

		// Token: 0x040022CB RID: 8907
		[Nullable(1)]
		private IWorldLevelBonusType _WorldLevelBonusTypeCache;

		// Token: 0x040022CC RID: 8908
		private bool _WorldLevelBonusTypeInited;
	}
}
