using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200426C RID: 17004
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldData
	{
		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x0602B076 RID: 176246 RVA: 0x00C19D0C File Offset: 0x00C17F0C
		public int CardConfigId
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				if (cardData == null)
				{
					return 0;
				}
				return cardData.ConfigId;
			}
		}

		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x0602B077 RID: 176247 RVA: 0x00C19D1F File Offset: 0x00C17F1F
		public bool IsOwn
		{
			get
			{
				return this.CardData != null && !this.CardData.IsNpcCard;
			}
		}

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x0602B078 RID: 176248 RVA: 0x00C19D39 File Offset: 0x00C17F39
		public int ClickActiveSkillId
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				if (cardData == null)
				{
					return 0;
				}
				return cardData.ClickActiveSkillId;
			}
		}

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x0602B079 RID: 176249 RVA: 0x00C19D4C File Offset: 0x00C17F4C
		public int CurrentCd
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				if (cardData == null)
				{
					return 0;
				}
				return cardData.SkillCd;
			}
		}

		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x0602B07A RID: 176250 RVA: 0x00C19D5F File Offset: 0x00C17F5F
		public int MaxCd
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				if (cardData == null)
				{
					return 0;
				}
				return cardData.SkillCdMax;
			}
		}

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x0602B07B RID: 176251 RVA: 0x00C19D72 File Offset: 0x00C17F72
		public int CurEffectCount
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				if (cardData == null)
				{
					return 0;
				}
				return cardData.CurEffectCount;
			}
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x0602B07C RID: 176252 RVA: 0x00C19D85 File Offset: 0x00C17F85
		public int MaxEffectCount
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				if (cardData == null)
				{
					return 0;
				}
				return cardData.MaxEffectCount;
			}
		}

		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x0602B07D RID: 176253 RVA: 0x00C19D98 File Offset: 0x00C17F98
		public bool HasClickActiveSkill
		{
			get
			{
				return this.ClickActiveSkillId > 0;
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x0602B07E RID: 176254 RVA: 0x00C19DA3 File Offset: 0x00C17FA3
		public bool HasCountSkill
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				return cardData != null && cardData.HasCountSkill;
			}
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x0602B07F RID: 176255 RVA: 0x00C19DB6 File Offset: 0x00C17FB6
		public bool IsCanInteractive
		{
			get
			{
				return this.HasClickActiveSkill && !this.IsInSkillCd;
			}
		}

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x0602B080 RID: 176256 RVA: 0x00C19DD0 File Offset: 0x00C17FD0
		public string FieldName
		{
			get
			{
				if (this.CardData != null)
				{
					return PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId).Name;
				}
				return "";
			}
		}

		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x0602B081 RID: 176257 RVA: 0x00C19E08 File Offset: 0x00C18008
		public string FieldEffectResource
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(phantomBattleCardConfig.Element).FieldActivateUi;
				}
				return "";
			}
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x0602B082 RID: 176258 RVA: 0x00C19E54 File Offset: 0x00C18054
		public string FieldActivateMaterial
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(phantomBattleCardConfig.Element).FieldActivateMaterial;
				}
				return "";
			}
		}

		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x0602B083 RID: 176259 RVA: 0x00C19EA0 File Offset: 0x00C180A0
		public string FieldBg
		{
			get
			{
				if (this.CardData != null)
				{
					return PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId).FieldBg;
				}
				return "";
			}
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x0602B084 RID: 176260 RVA: 0x00C19ED8 File Offset: 0x00C180D8
		public string FieldElementNiagara
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(phantomBattleCardConfig.Element).FieldElementNiagara;
				}
				return "";
			}
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x0602B085 RID: 176261 RVA: 0x00C19F24 File Offset: 0x00C18124
		public string FieldActivateElementNiagara
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(phantomBattleCardConfig.Element).FieldActivateElementNiagara;
				}
				return "";
			}
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x0602B086 RID: 176262 RVA: 0x00C19F70 File Offset: 0x00C18170
		public string FieldAudio
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleElementConfig(phantomBattleCardConfig.Element).FieldAudio;
				}
				return "";
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x0602B087 RID: 176263 RVA: 0x00C19FBC File Offset: 0x00C181BC
		public string BaseColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).BaseColor;
				}
				return "";
			}
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x0602B088 RID: 176264 RVA: 0x00C1A008 File Offset: 0x00C18208
		public string BackGroundColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).BackGroundColor;
				}
				return "";
			}
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x0602B089 RID: 176265 RVA: 0x00C1A054 File Offset: 0x00C18254
		public string FieldIcon
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldIcon;
				}
				return "";
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x0602B08A RID: 176266 RVA: 0x00C1A0A0 File Offset: 0x00C182A0
		public string FieldRing
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldRing;
				}
				return "";
			}
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x0602B08B RID: 176267 RVA: 0x00C1A0EC File Offset: 0x00C182EC
		public string FieldActivateIcon
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldActivateIcon;
				}
				return "";
			}
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x0602B08C RID: 176268 RVA: 0x00C1A138 File Offset: 0x00C18338
		public string FieldActivateRing
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldActivateRing;
				}
				return "";
			}
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x0602B08D RID: 176269 RVA: 0x00C1A184 File Offset: 0x00C18384
		public string FieldButtonColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldButtonColor;
				}
				return "";
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x0602B08E RID: 176270 RVA: 0x00C1A1D0 File Offset: 0x00C183D0
		public string FieldNorColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldNorColor;
				}
				return "";
			}
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x0602B08F RID: 176271 RVA: 0x00C1A21C File Offset: 0x00C1841C
		public string FieldActivateColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldActivateColor;
				}
				return "";
			}
		}

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x0602B090 RID: 176272 RVA: 0x00C1A268 File Offset: 0x00C18468
		public string FieldLightColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldLightColor;
				}
				return "";
			}
		}

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x0602B091 RID: 176273 RVA: 0x00C1A2B4 File Offset: 0x00C184B4
		public string FieldReleaseColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldReleaseColor;
				}
				return "";
			}
		}

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x0602B092 RID: 176274 RVA: 0x00C1A300 File Offset: 0x00C18500
		public string FieldSkillTexRelease
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldSkillTexRelease;
				}
				return "";
			}
		}

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x0602B093 RID: 176275 RVA: 0x00C1A34C File Offset: 0x00C1854C
		public string FieldSkillTexBg
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldSkillTexBg;
				}
				return "";
			}
		}

		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x0602B094 RID: 176276 RVA: 0x00C1A398 File Offset: 0x00C18598
		public string FieldSkillTexIcon
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldSkillTexIcon;
				}
				return "";
			}
		}

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x0602B095 RID: 176277 RVA: 0x00C1A3E4 File Offset: 0x00C185E4
		public string FieldTexSmokeColor
		{
			get
			{
				if (this.CardData != null)
				{
					PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.CardData.ConfigId);
					return PhantomArenaConfig.Instance.GetPhantomBattleEffectConfig(phantomBattleCardConfig.EffectId).FieldTexSmokeColor;
				}
				return "";
			}
		}

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x0602B096 RID: 176278 RVA: 0x00C1A42E File Offset: 0x00C1862E
		public bool IsInSkillCd
		{
			get
			{
				return this.CurrentCd > 0;
			}
		}

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x0602B097 RID: 176279 RVA: 0x00C1A439 File Offset: 0x00C18639
		public int SealRemainRound
		{
			get
			{
				return this.SealRemainRoundInternal;
			}
		}

		// Token: 0x1700568D RID: 22157
		// (get) Token: 0x0602B098 RID: 176280 RVA: 0x00C1A441 File Offset: 0x00C18641
		public bool IsInSeal
		{
			get
			{
				return this.SealRemainRoundInternal > 0;
			}
		}

		// Token: 0x0602B099 RID: 176281 RVA: 0x00C1A44C File Offset: 0x00C1864C
		public void SetSealRemainRound(int remainRound)
		{
			if (this.CardData != null)
			{
				this.SealRemainRoundInternal = remainRound;
			}
		}

		// Token: 0x0602B09A RID: 176282 RVA: 0x00C1A45D File Offset: 0x00C1865D
		public void SetCardData(PhantomCardData cardData)
		{
			this.CardData = cardData;
		}

		// Token: 0x0401745B RID: 95323
		public PhantomCardData CardData;

		// Token: 0x0401745C RID: 95324
		private int SealRemainRoundInternal;
	}
}
