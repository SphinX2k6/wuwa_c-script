using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200529C RID: 21148
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldData
	{
		// Token: 0x170082AB RID: 33451
		// (get) Token: 0x0603617B RID: 221563 RVA: 0x00CCC5D8 File Offset: 0x00CCA7D8
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

		// Token: 0x170082AC RID: 33452
		// (get) Token: 0x0603617C RID: 221564 RVA: 0x00CCC5EB File Offset: 0x00CCA7EB
		public bool IsOwn
		{
			get
			{
				return this.CardData != null && !this.CardData.IsNpcCard;
			}
		}

		// Token: 0x170082AD RID: 33453
		// (get) Token: 0x0603617D RID: 221565 RVA: 0x00CCC605 File Offset: 0x00CCA805
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

		// Token: 0x170082AE RID: 33454
		// (get) Token: 0x0603617E RID: 221566 RVA: 0x00CCC618 File Offset: 0x00CCA818
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

		// Token: 0x170082AF RID: 33455
		// (get) Token: 0x0603617F RID: 221567 RVA: 0x00CCC62B File Offset: 0x00CCA82B
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

		// Token: 0x170082B0 RID: 33456
		// (get) Token: 0x06036180 RID: 221568 RVA: 0x00CCC63E File Offset: 0x00CCA83E
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

		// Token: 0x170082B1 RID: 33457
		// (get) Token: 0x06036181 RID: 221569 RVA: 0x00CCC651 File Offset: 0x00CCA851
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

		// Token: 0x170082B2 RID: 33458
		// (get) Token: 0x06036182 RID: 221570 RVA: 0x00CCC664 File Offset: 0x00CCA864
		public bool HasClickActiveSkill
		{
			get
			{
				return this.ClickActiveSkillId > 0;
			}
		}

		// Token: 0x170082B3 RID: 33459
		// (get) Token: 0x06036183 RID: 221571 RVA: 0x00CCC66F File Offset: 0x00CCA86F
		public bool HasCountSkill
		{
			get
			{
				PhantomCardData cardData = this.CardData;
				return cardData != null && cardData.HasCountSkill;
			}
		}

		// Token: 0x170082B4 RID: 33460
		// (get) Token: 0x06036184 RID: 221572 RVA: 0x00CCC682 File Offset: 0x00CCA882
		public bool IsCanInteractive
		{
			get
			{
				return this.HasClickActiveSkill && !this.IsInSkillCd;
			}
		}

		// Token: 0x170082B5 RID: 33461
		// (get) Token: 0x06036185 RID: 221573 RVA: 0x00CCC69C File Offset: 0x00CCA89C
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

		// Token: 0x170082B6 RID: 33462
		// (get) Token: 0x06036186 RID: 221574 RVA: 0x00CCC6D4 File Offset: 0x00CCA8D4
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

		// Token: 0x170082B7 RID: 33463
		// (get) Token: 0x06036187 RID: 221575 RVA: 0x00CCC720 File Offset: 0x00CCA920
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

		// Token: 0x170082B8 RID: 33464
		// (get) Token: 0x06036188 RID: 221576 RVA: 0x00CCC76C File Offset: 0x00CCA96C
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

		// Token: 0x170082B9 RID: 33465
		// (get) Token: 0x06036189 RID: 221577 RVA: 0x00CCC7A4 File Offset: 0x00CCA9A4
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

		// Token: 0x170082BA RID: 33466
		// (get) Token: 0x0603618A RID: 221578 RVA: 0x00CCC7F0 File Offset: 0x00CCA9F0
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

		// Token: 0x170082BB RID: 33467
		// (get) Token: 0x0603618B RID: 221579 RVA: 0x00CCC83C File Offset: 0x00CCAA3C
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

		// Token: 0x170082BC RID: 33468
		// (get) Token: 0x0603618C RID: 221580 RVA: 0x00CCC888 File Offset: 0x00CCAA88
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

		// Token: 0x170082BD RID: 33469
		// (get) Token: 0x0603618D RID: 221581 RVA: 0x00CCC8D4 File Offset: 0x00CCAAD4
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

		// Token: 0x170082BE RID: 33470
		// (get) Token: 0x0603618E RID: 221582 RVA: 0x00CCC920 File Offset: 0x00CCAB20
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

		// Token: 0x170082BF RID: 33471
		// (get) Token: 0x0603618F RID: 221583 RVA: 0x00CCC96C File Offset: 0x00CCAB6C
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

		// Token: 0x170082C0 RID: 33472
		// (get) Token: 0x06036190 RID: 221584 RVA: 0x00CCC9B8 File Offset: 0x00CCABB8
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

		// Token: 0x170082C1 RID: 33473
		// (get) Token: 0x06036191 RID: 221585 RVA: 0x00CCCA04 File Offset: 0x00CCAC04
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

		// Token: 0x170082C2 RID: 33474
		// (get) Token: 0x06036192 RID: 221586 RVA: 0x00CCCA50 File Offset: 0x00CCAC50
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

		// Token: 0x170082C3 RID: 33475
		// (get) Token: 0x06036193 RID: 221587 RVA: 0x00CCCA9C File Offset: 0x00CCAC9C
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

		// Token: 0x170082C4 RID: 33476
		// (get) Token: 0x06036194 RID: 221588 RVA: 0x00CCCAE8 File Offset: 0x00CCACE8
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

		// Token: 0x170082C5 RID: 33477
		// (get) Token: 0x06036195 RID: 221589 RVA: 0x00CCCB34 File Offset: 0x00CCAD34
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

		// Token: 0x170082C6 RID: 33478
		// (get) Token: 0x06036196 RID: 221590 RVA: 0x00CCCB80 File Offset: 0x00CCAD80
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

		// Token: 0x170082C7 RID: 33479
		// (get) Token: 0x06036197 RID: 221591 RVA: 0x00CCCBCC File Offset: 0x00CCADCC
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

		// Token: 0x170082C8 RID: 33480
		// (get) Token: 0x06036198 RID: 221592 RVA: 0x00CCCC18 File Offset: 0x00CCAE18
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

		// Token: 0x170082C9 RID: 33481
		// (get) Token: 0x06036199 RID: 221593 RVA: 0x00CCCC64 File Offset: 0x00CCAE64
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

		// Token: 0x170082CA RID: 33482
		// (get) Token: 0x0603619A RID: 221594 RVA: 0x00CCCCB0 File Offset: 0x00CCAEB0
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

		// Token: 0x170082CB RID: 33483
		// (get) Token: 0x0603619B RID: 221595 RVA: 0x00CCCCFA File Offset: 0x00CCAEFA
		public bool IsInSkillCd
		{
			get
			{
				return this.CurrentCd > 0;
			}
		}

		// Token: 0x170082CC RID: 33484
		// (get) Token: 0x0603619C RID: 221596 RVA: 0x00CCCD05 File Offset: 0x00CCAF05
		public int SealRemainRound
		{
			get
			{
				return this.SealRemainRoundInternal;
			}
		}

		// Token: 0x170082CD RID: 33485
		// (get) Token: 0x0603619D RID: 221597 RVA: 0x00CCCD0D File Offset: 0x00CCAF0D
		public bool IsInSeal
		{
			get
			{
				return this.SealRemainRoundInternal > 0;
			}
		}

		// Token: 0x0603619E RID: 221598 RVA: 0x00CCCD18 File Offset: 0x00CCAF18
		public void SetSealRemainRound(int remainRound)
		{
			if (this.CardData != null)
			{
				this.SealRemainRoundInternal = remainRound;
			}
		}

		// Token: 0x0603619F RID: 221599 RVA: 0x00CCCD29 File Offset: 0x00CCAF29
		public void SetCardData(PhantomCardData cardData)
		{
			this.CardData = cardData;
		}

		// Token: 0x0401CA26 RID: 117286
		public PhantomCardData CardData;

		// Token: 0x0401CA27 RID: 117287
		private int SealRemainRoundInternal;
	}
}
