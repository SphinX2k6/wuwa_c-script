using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x020052A2 RID: 21154
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomCardData
	{
		// Token: 0x170082D3 RID: 33491
		// (get) Token: 0x06036221 RID: 221729 RVA: 0x00CCEDC2 File Offset: 0x00CCCFC2
		public bool HasActiveSkill
		{
			get
			{
				return this.ActiveSkillId > 0;
			}
		}

		// Token: 0x170082D4 RID: 33492
		// (get) Token: 0x06036222 RID: 221730 RVA: 0x00CCEDCD File Offset: 0x00CCCFCD
		public bool HasClickActiveSkill
		{
			get
			{
				return this.ClickActiveSkillId > 0;
			}
		}

		// Token: 0x170082D5 RID: 33493
		// (get) Token: 0x06036223 RID: 221731 RVA: 0x00CCEDD8 File Offset: 0x00CCCFD8
		public bool HasCountSkill
		{
			get
			{
				return this.CountSkillId > 0;
			}
		}

		// Token: 0x170082D6 RID: 33494
		// (get) Token: 0x06036224 RID: 221732 RVA: 0x00CCEDE3 File Offset: 0x00CCCFE3
		public bool HasDurability
		{
			get
			{
				return this.Durable > 0;
			}
		}

		// Token: 0x170082D7 RID: 33495
		// (get) Token: 0x06036225 RID: 221733 RVA: 0x00CCEDEE File Offset: 0x00CCCFEE
		public bool InSkillCd
		{
			get
			{
				return this.SkillCd > 0;
			}
		}

		// Token: 0x170082D8 RID: 33496
		// (get) Token: 0x06036226 RID: 221734 RVA: 0x00CCEDFC File Offset: 0x00CCCFFC
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

		// Token: 0x170082D9 RID: 33497
		// (get) Token: 0x06036227 RID: 221735 RVA: 0x00CCEE20 File Offset: 0x00CCD020
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

		// Token: 0x170082DA RID: 33498
		// (get) Token: 0x06036228 RID: 221736 RVA: 0x00CCEE44 File Offset: 0x00CCD044
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

		// Token: 0x170082DB RID: 33499
		// (get) Token: 0x06036229 RID: 221737 RVA: 0x00CCEE68 File Offset: 0x00CCD068
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

		// Token: 0x170082DC RID: 33500
		// (get) Token: 0x0603622A RID: 221738 RVA: 0x00CCEE8C File Offset: 0x00CCD08C
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

		// Token: 0x170082DD RID: 33501
		// (get) Token: 0x0603622B RID: 221739 RVA: 0x00CCEEB0 File Offset: 0x00CCD0B0
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

		// Token: 0x170082DE RID: 33502
		// (get) Token: 0x0603622C RID: 221740 RVA: 0x00CCEED4 File Offset: 0x00CCD0D4
		public bool IsFourCost
		{
			get
			{
				int phantomArenaCardCoreCost = PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost();
				return this.ConfigCost == phantomArenaCardCoreCost;
			}
		}

		// Token: 0x170082DF RID: 33503
		// (get) Token: 0x0603622D RID: 221741 RVA: 0x00CCEEF5 File Offset: 0x00CCD0F5
		public bool IsField
		{
			get
			{
				return this.CardType == EPhantomArenaCardType.Field;
			}
		}

		// Token: 0x170082E0 RID: 33504
		// (get) Token: 0x0603622E RID: 221742 RVA: 0x00CCEF00 File Offset: 0x00CCD100
		public bool IsTool
		{
			get
			{
				return this.CardType == EPhantomArenaCardType.Tool;
			}
		}

		// Token: 0x170082E1 RID: 33505
		// (get) Token: 0x0603622F RID: 221743 RVA: 0x00CCEF0B File Offset: 0x00CCD10B
		public bool IsNormal
		{
			get
			{
				return this.CardType == EPhantomArenaCardType.Normal;
			}
		}

		// Token: 0x170082E2 RID: 33506
		// (get) Token: 0x06036230 RID: 221744 RVA: 0x00CCEF16 File Offset: 0x00CCD116
		public bool IsNoAllowDiscard
		{
			get
			{
				return this.IsField || this.IsFourCost;
			}
		}

		// Token: 0x170082E3 RID: 33507
		// (get) Token: 0x06036231 RID: 221745 RVA: 0x00CCEF28 File Offset: 0x00CCD128
		public bool IsInFight
		{
			get
			{
				return this.Index != -1;
			}
		}

		// Token: 0x06036232 RID: 221746 RVA: 0x00CCEF36 File Offset: 0x00CCD136
		public EPhantomArenaCardType GetCardType()
		{
			return this.CardType;
		}

		// Token: 0x06036233 RID: 221747 RVA: 0x00CCEF40 File Offset: 0x00CCD140
		public PhantomCardData(bool isNpcCard = false)
		{
			this.IsNpcCard = isNpcCard;
		}

		// Token: 0x06036234 RID: 221748 RVA: 0x00CCEF94 File Offset: 0x00CCD194
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

		// Token: 0x06036235 RID: 221749 RVA: 0x00CCF008 File Offset: 0x00CCD208
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

		// Token: 0x06036236 RID: 221750 RVA: 0x00CCF064 File Offset: 0x00CCD264
		private void RefreshHasActiveSkill()
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId);
			this.ActiveSkillId = phantomBattleCardConfig.ActiveSkillId;
			this.ClickActiveSkillId = phantomBattleCardConfig.DurableSkillId;
			this.CountSkillId = phantomBattleCardConfig.CountSkill;
		}

		// Token: 0x06036237 RID: 221751 RVA: 0x00CCF0AC File Offset: 0x00CCD2AC
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

		// Token: 0x06036238 RID: 221752 RVA: 0x00CCF228 File Offset: 0x00CCD428
		private void RefreshCost()
		{
			this.ConfigCost = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId).Cost;
			this.UseCost = (this.IsFourCost ? 0 : this.ConfigCost);
		}

		// Token: 0x06036239 RID: 221753 RVA: 0x00CCF26C File Offset: 0x00CCD46C
		private void RefreshCardType()
		{
			this.CardType = (EPhantomArenaCardType)PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId).Type;
		}

		// Token: 0x0603623A RID: 221754 RVA: 0x00CCF298 File Offset: 0x00CCD498
		public void RefreshFightData(PhantomBattleFighterInfo data)
		{
			PhantomBattleCardFighterInfoCtx phantomBattleCardFighterInfoCtx = data.PhantomBattleCardFighterInfoCtx;
			this.RefreshFightAttr(phantomBattleCardFighterInfoCtx.Attrs.ToDictionary<int, int>());
			this.CardId = phantomBattleCardFighterInfoCtx.CardUid;
			this.ConfigId = phantomBattleCardFighterInfoCtx.CardConfId;
			this.Index = phantomBattleCardFighterInfoCtx.SlotIndex;
			this.FightId = data.UId;
			this.IsCopy = phantomBattleCardFighterInfoCtx.IsCopy;
			this.RefreshFactorsByList(phantomBattleCardFighterInfoCtx.Factors.ToList<int>(), phantomBattleCardFighterInfoCtx.LockFactors.ToList<int>());
			this.RefreshHasActiveSkill();
			this.CanUse = true;
			this.EvolveNum = phantomBattleCardFighterInfoCtx.EvolveCount;
			this.IsUnLimitEvolve = phantomBattleCardFighterInfoCtx.CanUnlimitedEvolve;
			this.RefreshCost();
			this.RefreshCardType();
			this.SkillData.RefreshData(phantomBattleCardFighterInfoCtx.SkillUnlockInfo);
		}

		// Token: 0x0603623B RID: 221755 RVA: 0x00CCF358 File Offset: 0x00CCD558
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

		// Token: 0x0603623C RID: 221756 RVA: 0x00CCF3E8 File Offset: 0x00CCD5E8
		private void InitFactorsByList()
		{
			this.ExtraFactors.Clear();
			this.UnActiveFactors = new List<int>(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.ConfigId).GetCardFactorIdBytes().ToArray());
			EventSystem.Instance.Emit<int>(EEventName.PhantomArenaCardFactorsRefresh, this.CardId);
		}

		// Token: 0x0603623D RID: 221757 RVA: 0x00CCF444 File Offset: 0x00CCD644
		private void RefreshFactorsByList(List<int> factors, List<int> unActiveFactors)
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

		// Token: 0x0603623E RID: 221758 RVA: 0x00CCF508 File Offset: 0x00CCD708
		public void NotifyRefreshCardData(Dictionary<int, int> factorMap, List<int> unActiveFactors, bool canUnlimitedEvolve)
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

		// Token: 0x0603623F RID: 221759 RVA: 0x00CCF5F4 File Offset: 0x00CCD7F4
		public int GetFightValueByAttr(PhantomBattleCardAttr attr)
		{
			int result;
			if (this.AttrMap.TryGetValue(attr, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06036240 RID: 221760 RVA: 0x00CCF614 File Offset: 0x00CCD814
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

		// Token: 0x06036241 RID: 221761 RVA: 0x00CCF674 File Offset: 0x00CCD874
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

		// Token: 0x0401CA51 RID: 117329
		private EPhantomArenaCardType CardType;

		// Token: 0x0401CA52 RID: 117330
		public bool IsNpcCard;

		// Token: 0x0401CA53 RID: 117331
		public int Index = -1;

		// Token: 0x0401CA54 RID: 117332
		public int CardId;

		// Token: 0x0401CA55 RID: 117333
		public int FightId = -1;

		// Token: 0x0401CA56 RID: 117334
		public int ConfigId;

		// Token: 0x0401CA57 RID: 117335
		public bool CanUse;

		// Token: 0x0401CA58 RID: 117336
		public bool IsCopy;

		// Token: 0x0401CA59 RID: 117337
		public int EvolveNum;

		// Token: 0x0401CA5A RID: 117338
		public int ConfigCost;

		// Token: 0x0401CA5B RID: 117339
		public int UseCost;

		// Token: 0x0401CA5C RID: 117340
		public List<int> ExtraFactors = new List<int>();

		// Token: 0x0401CA5D RID: 117341
		public List<int> UnActiveFactors = new List<int>();

		// Token: 0x0401CA5E RID: 117342
		public Dictionary<PhantomBattleCardAttr, int> AttrMap = new Dictionary<PhantomBattleCardAttr, int>();

		// Token: 0x0401CA5F RID: 117343
		public int ActiveSkillId;

		// Token: 0x0401CA60 RID: 117344
		public int ClickActiveSkillId;

		// Token: 0x0401CA61 RID: 117345
		public int CountSkillId;

		// Token: 0x0401CA62 RID: 117346
		public bool IsUnLimitEvolve;

		// Token: 0x0401CA63 RID: 117347
		public PhantomCardSkillData SkillData = new PhantomCardSkillData();

		// Token: 0x0401CA64 RID: 117348
		public int LastEffectCount;
	}
}
