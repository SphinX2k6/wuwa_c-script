using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004272 RID: 17010
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomCardData
	{
		// Token: 0x17005693 RID: 22163
		// (get) Token: 0x0602B11C RID: 176412 RVA: 0x00C1C4FF File Offset: 0x00C1A6FF
		public bool HasActiveSkill
		{
			get
			{
				return this.ActiveSkillId > 0;
			}
		}

		// Token: 0x17005694 RID: 22164
		// (get) Token: 0x0602B11D RID: 176413 RVA: 0x00C1C50A File Offset: 0x00C1A70A
		public bool HasClickActiveSkill
		{
			get
			{
				return this.ClickActiveSkillId > 0;
			}
		}

		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x0602B11E RID: 176414 RVA: 0x00C1C515 File Offset: 0x00C1A715
		public bool HasCountSkill
		{
			get
			{
				return this.CountSkillId > 0;
			}
		}

		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x0602B11F RID: 176415 RVA: 0x00C1C520 File Offset: 0x00C1A720
		public bool HasDurability
		{
			get
			{
				return this.Durable > 0;
			}
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x0602B120 RID: 176416 RVA: 0x00C1C52B File Offset: 0x00C1A72B
		public bool InSkillCd
		{
			get
			{
				return this.SkillCd > 0;
			}
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x0602B121 RID: 176417 RVA: 0x00C1C538 File Offset: 0x00C1A738
		public int SkillCd
		{
			get
			{
				int result;
				if (this.AttrMap.TryGetValue(PhantomBattleCardAttr.CardSkillCd, out result))
				{
					return result;
				}
				return 0;
			}
		}

		// Token: 0x17005699 RID: 22169
		// (get) Token: 0x0602B122 RID: 176418 RVA: 0x00C1C55C File Offset: 0x00C1A75C
		public int SkillCdMax
		{
			get
			{
				int result;
				if (this.AttrMap.TryGetValue(PhantomBattleCardAttr.CardSkillCdmax, out result))
				{
					return result;
				}
				return 0;
			}
		}

		// Token: 0x1700569A RID: 22170
		// (get) Token: 0x0602B123 RID: 176419 RVA: 0x00C1C580 File Offset: 0x00C1A780
		public int Durable
		{
			get
			{
				int result;
				if (this.AttrMap.TryGetValue(PhantomBattleCardAttr.Durable, out result))
				{
					return result;
				}
				return 0;
			}
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x0602B124 RID: 176420 RVA: 0x00C1C5A4 File Offset: 0x00C1A7A4
		public int DurableMax
		{
			get
			{
				int result;
				if (this.AttrMap.TryGetValue(PhantomBattleCardAttr.DurableMax, out result))
				{
					return result;
				}
				return 0;
			}
		}

		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x0602B125 RID: 176421 RVA: 0x00C1C5C8 File Offset: 0x00C1A7C8
		public int CurEffectCount
		{
			get
			{
				int result;
				if (this.AttrMap.TryGetValue(PhantomBattleCardAttr.CurEffectCount, out result))
				{
					return result;
				}
				return 0;
			}
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x0602B126 RID: 176422 RVA: 0x00C1C5EC File Offset: 0x00C1A7EC
		public int MaxEffectCount
		{
			get
			{
				int result;
				if (this.AttrMap.TryGetValue(PhantomBattleCardAttr.MaxEffectCount, out result))
				{
					return result;
				}
				return 0;
			}
		}

		// Token: 0x1700569E RID: 22174
		// (get) Token: 0x0602B127 RID: 176423 RVA: 0x00C1C610 File Offset: 0x00C1A810
		public bool IsFourCost
		{
			get
			{
				int phantomArenaCardCoreCost = PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost();
				return this.ConfigCost == phantomArenaCardCoreCost;
			}
		}

		// Token: 0x1700569F RID: 22175
		// (get) Token: 0x0602B128 RID: 176424 RVA: 0x00C1C631 File Offset: 0x00C1A831
		public bool IsField
		{
			get
			{
				return this.CardType == EPhantomArenaCardType.Field;
			}
		}

		// Token: 0x170056A0 RID: 22176
		// (get) Token: 0x0602B129 RID: 176425 RVA: 0x00C1C63C File Offset: 0x00C1A83C
		public bool IsTool
		{
			get
			{
				return this.CardType == EPhantomArenaCardType.Tool;
			}
		}

		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x0602B12A RID: 176426 RVA: 0x00C1C647 File Offset: 0x00C1A847
		public bool IsNormal
		{
			get
			{
				return this.CardType == EPhantomArenaCardType.Normal;
			}
		}

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x0602B12B RID: 176427 RVA: 0x00C1C652 File Offset: 0x00C1A852
		public bool IsNoAllowDiscard
		{
			get
			{
				return this.IsField || this.IsFourCost;
			}
		}

		// Token: 0x170056A3 RID: 22179
		// (get) Token: 0x0602B12C RID: 176428 RVA: 0x00C1C664 File Offset: 0x00C1A864
		public bool IsInFight
		{
			get
			{
				return this.Index != -1;
			}
		}

		// Token: 0x0602B12D RID: 176429 RVA: 0x00C1C672 File Offset: 0x00C1A872
		public EPhantomArenaCardType GetCardType()
		{
			return this.CardType;
		}

		// Token: 0x0602B12E RID: 176430 RVA: 0x00C1C67C File Offset: 0x00C1A87C
		public PhantomCardData(bool isNpcCard = false)
		{
			this.IsNpcCard = isNpcCard;
		}

		// Token: 0x0602B12F RID: 176431 RVA: 0x00C1C6D0 File Offset: 0x00C1A8D0
		public void InitData(PhantomBattleHandCardInfo dataInfo)
		{
			this.CardId = dataInfo.CardUid;
			this.ConfigId = dataInfo.CardConfId;
			this.CanUse = dataInfo.CanUse;
			this.EvolveNum = 0;
			this.Index = -1;
			this.FightId = -1;
			this.IsUnLimitEvolve = false;
			this.IsCopy = false;
			this.InitFactorsByList();
			this.RefreshHasActiveSkill();
			this.InitAttrMap();
			this.RefreshCost();
			this.RefreshCardType();
		}

		// Token: 0x0602B130 RID: 176432 RVA: 0x00C1C744 File Offset: 0x00C1A944
		public void InitDataByNpc(int cardId, int configId)
		{
			this.CardId = cardId;
			this.ConfigId = configId;
			this.CanUse = true;
			this.EvolveNum = 0;
			this.Index = -1;
			this.FightId = cardId;
			this.IsCopy = false;
			this.InitFactorsByList();
			this.RefreshHasActiveSkill();
			this.InitAttrMap();
			this.RefreshCost();
			this.RefreshCardType();
		}

		// Token: 0x0602B131 RID: 176433 RVA: 0x00C1C7A0 File Offset: 0x00C1A9A0
		private void RefreshHasActiveSkill()
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId);
			this.ActiveSkillId = phantomBattleCardConfig.ActiveSkillId;
			this.ClickActiveSkillId = phantomBattleCardConfig.DurableSkillId;
			this.CountSkillId = phantomBattleCardConfig.CountSkill;
		}

		// Token: 0x0602B132 RID: 176434 RVA: 0x00C1C7E8 File Offset: 0x00C1A9E8
		private void InitAttrMap()
		{
			this.AttrMap.Clear();
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId);
			int value;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(0, out value))
			{
				this.AttrMap[PhantomBattleCardAttr.AttackAbility] = value;
			}
			int value2;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(1, out value2))
			{
				this.AttrMap[PhantomBattleCardAttr.LifeAbility] = value2;
			}
			this.AttrMap[PhantomBattleCardAttr.CostAbility] = phantomBattleCardConfig.Cost;
			int value3;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(3, out value3))
			{
				this.AttrMap[PhantomBattleCardAttr.Crit] = value3;
			}
			int value4;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(4, out value4))
			{
				this.AttrMap[PhantomBattleCardAttr.CritDamage] = value4;
			}
			int value5;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(9, out value5))
			{
				this.AttrMap[PhantomBattleCardAttr.CardSkillCd] = value5;
			}
			int value6;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(10, out value6))
			{
				this.AttrMap[PhantomBattleCardAttr.CardSkillCdmax] = value6;
			}
			int value7;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(11, out value7))
			{
				this.AttrMap[PhantomBattleCardAttr.Durable] = value7;
			}
			int value8;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(12, out value8))
			{
				this.AttrMap[PhantomBattleCardAttr.DurableMax] = value8;
			}
			int value9;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(13, out value9))
			{
				this.AttrMap[PhantomBattleCardAttr.CurEffectCount] = value9;
			}
			int value10;
			if (phantomBattleCardConfig.InitAttack().TryGetValue(14, out value10))
			{
				this.AttrMap[PhantomBattleCardAttr.MaxEffectCount] = value10;
			}
		}

		// Token: 0x0602B133 RID: 176435 RVA: 0x00C1C964 File Offset: 0x00C1AB64
		private void RefreshCost()
		{
			this.ConfigCost = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId).Cost;
			this.UseCost = (this.IsFourCost ? 0 : this.ConfigCost);
		}

		// Token: 0x0602B134 RID: 176436 RVA: 0x00C1C9A8 File Offset: 0x00C1ABA8
		private void RefreshCardType()
		{
			this.CardType = (EPhantomArenaCardType)PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId).Type;
		}

		// Token: 0x0602B135 RID: 176437 RVA: 0x00C1C9D4 File Offset: 0x00C1ABD4
		public void RefreshFightData(PhantomBattleFighterInfo data)
		{
			PhantomBattleCardFighterInfoCtx phantomBattleCardFighterInfoCtx = data.PhantomBattleCardFighterInfoCtx;
			this.RefreshFightAttr(new Dictionary<int, int>(phantomBattleCardFighterInfoCtx.Attrs));
			this.CardId = phantomBattleCardFighterInfoCtx.CardUid;
			this.ConfigId = phantomBattleCardFighterInfoCtx.CardConfId;
			this.Index = phantomBattleCardFighterInfoCtx.SlotIndex;
			this.FightId = data.UId;
			this.IsCopy = phantomBattleCardFighterInfoCtx.IsCopy;
			this.RefreshFactorsByList(phantomBattleCardFighterInfoCtx.Factors, phantomBattleCardFighterInfoCtx.LockFactors);
			this.RefreshHasActiveSkill();
			this.CanUse = true;
			this.EvolveNum = phantomBattleCardFighterInfoCtx.EvolveCount;
			this.IsUnLimitEvolve = phantomBattleCardFighterInfoCtx.CanUnlimitedEvolve;
			this.RefreshCost();
			this.RefreshCardType();
			this.SkillData.RefreshData(phantomBattleCardFighterInfoCtx.SkillUnlockInfo);
		}

		// Token: 0x0602B136 RID: 176438 RVA: 0x00C1CA8C File Offset: 0x00C1AC8C
		public void RefreshFightAttr(Dictionary<int, int> battleAttrMap)
		{
			this.LastEffectCount = this.CurEffectCount;
			this.AttrMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in battleAttrMap)
			{
				PhantomBattleCardAttr key = (PhantomBattleCardAttr)keyValuePair.Key;
				this.AttrMap[key] = keyValuePair.Value;
			}
			EventSystem.Instance.Emit<int>(EEventName.PhantomArenaCardAttrRefresh, this.CardId);
		}

		// Token: 0x0602B137 RID: 176439 RVA: 0x00C1CB1C File Offset: 0x00C1AD1C
		private void InitFactorsByList()
		{
			this.ExtraFactors.Clear();
			this.UnActiveFactors = new List<int>(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId).GetCardFactorIdBytes().ToArray());
			EventSystem.Instance.Emit<int>(EEventName.PhantomArenaCardFactorsRefresh, this.CardId);
		}

		// Token: 0x0602B138 RID: 176440 RVA: 0x00C1CB78 File Offset: 0x00C1AD78
		private void RefreshFactorsByList(IEnumerable<int> factors, IEnumerable<int> unActiveFactors)
		{
			this.ExtraFactors.Clear();
			this.UnActiveFactors.Clear();
			foreach (int item in factors)
			{
				this.ExtraFactors.Add(item);
			}
			foreach (int item2 in unActiveFactors)
			{
				this.UnActiveFactors.Add(item2);
			}
			EventSystem.Instance.Emit<int>(EEventName.PhantomArenaCardFactorsRefresh, this.CardId);
		}

		// Token: 0x0602B139 RID: 176441 RVA: 0x00C1CC30 File Offset: 0x00C1AE30
		public void NotifyRefreshCardData(Dictionary<int, int> factorMap, IEnumerable<int> unActiveFactors, bool canUnlimitedEvolve)
		{
			this.ExtraFactors.Clear();
			this.UnActiveFactors.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in factorMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				for (int i = 0; i < value; i++)
				{
					this.ExtraFactors.Add(key);
				}
			}
			foreach (int item in unActiveFactors)
			{
				this.UnActiveFactors.Add(item);
			}
			this.IsUnLimitEvolve = canUnlimitedEvolve;
			EventSystem.Instance.Emit<int>(EEventName.PhantomArenaCardFactorsRefresh, this.CardId);
		}

		// Token: 0x0602B13A RID: 176442 RVA: 0x00C1CD1C File Offset: 0x00C1AF1C
		public int GetFightValueByAttr(PhantomBattleCardAttr attr)
		{
			int result;
			if (this.AttrMap.TryGetValue(attr, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0602B13B RID: 176443 RVA: 0x00C1CD3C File Offset: 0x00C1AF3C
		public EPhantomArenaCardValueChangeType ValueChangeTypeByBuff(PhantomBattleCardAttr attr)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId);
			int num;
			if (!this.AttrMap.TryGetValue(attr, out num))
			{
				num = 0;
			}
			int num2 = 0;
			int num3;
			if (attr == PhantomBattleCardAttr.CostAbility)
			{
				num2 = phantomBattleCardConfig.Cost;
			}
			else if (phantomBattleCardConfig.InitAttack().TryGetValue((int)attr, out num3))
			{
				num2 = num3;
			}
			if (num == num2)
			{
				return EPhantomArenaCardValueChangeType.None;
			}
			if (num > num2)
			{
				return EPhantomArenaCardValueChangeType.Add;
			}
			return EPhantomArenaCardValueChangeType.Subtract;
		}

		// Token: 0x0602B13C RID: 176444 RVA: 0x00C1CD9C File Offset: 0x00C1AF9C
		[NullableContext(0)]
		public ValueTuple<bool, EPhantomCardSettingFailReason> IsOtherCardCanEvolve([Nullable(1)] PhantomCardData card)
		{
			if (card.IsFourCost)
			{
				return new ValueTuple<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FourCostCantEvolve);
			}
			if (this.IsFourCost)
			{
				return new ValueTuple<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.FourCostCantBeEvolved);
			}
			if (this.IsUnLimitEvolve)
			{
				return new ValueTuple<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
			}
			if (this.CardType == EPhantomArenaCardType.Tool)
			{
				return new ValueTuple<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ToolCantEvolve);
			}
			int configCost = card.ConfigCost;
			if (configCost == 1 && (this.EvolveNum > 0 || this.ConfigCost == 3))
			{
				return new ValueTuple<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.OneCostCantEvolveOther);
			}
			if (configCost == 3 && this.EvolveNum != 1)
			{
				return new ValueTuple<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ThreeCostCantEvolveOther);
			}
			return new ValueTuple<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x04017486 RID: 95366
		private EPhantomArenaCardType CardType;

		// Token: 0x04017487 RID: 95367
		public bool IsNpcCard;

		// Token: 0x04017488 RID: 95368
		public int Index = -1;

		// Token: 0x04017489 RID: 95369
		public int CardId;

		// Token: 0x0401748A RID: 95370
		public int FightId = -1;

		// Token: 0x0401748B RID: 95371
		public int ConfigId;

		// Token: 0x0401748C RID: 95372
		public bool CanUse;

		// Token: 0x0401748D RID: 95373
		public bool IsCopy;

		// Token: 0x0401748E RID: 95374
		public int EvolveNum;

		// Token: 0x0401748F RID: 95375
		public int ConfigCost;

		// Token: 0x04017490 RID: 95376
		public int UseCost;

		// Token: 0x04017491 RID: 95377
		public List<int> ExtraFactors = new List<int>();

		// Token: 0x04017492 RID: 95378
		public List<int> UnActiveFactors = new List<int>();

		// Token: 0x04017493 RID: 95379
		public Dictionary<PhantomBattleCardAttr, int> AttrMap = new Dictionary<PhantomBattleCardAttr, int>();

		// Token: 0x04017494 RID: 95380
		public int ActiveSkillId;

		// Token: 0x04017495 RID: 95381
		public int ClickActiveSkillId;

		// Token: 0x04017496 RID: 95382
		public int CountSkillId;

		// Token: 0x04017497 RID: 95383
		public bool IsUnLimitEvolve;

		// Token: 0x04017498 RID: 95384
		public PhantomCardSkillData SkillData = new PhantomCardSkillData();

		// Token: 0x04017499 RID: 95385
		public int LastEffectCount;
	}
}
