using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200529A RID: 21146
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectData
	{
		// Token: 0x06036166 RID: 221542 RVA: 0x00CCC0E4 File Offset: 0x00CCA2E4
		private void CreateBuffEffectData(PhantomBattleSkillTriggerInfo skillTriggerInfo, ENotifyMessageId? notifyId = null)
		{
			IBuffEffectData buffData = this.NewBuffEffectData(skillTriggerInfo, notifyId);
			this.PushBuffEffectData(buffData);
		}

		// Token: 0x06036167 RID: 221543 RVA: 0x00CCC101 File Offset: 0x00CCA301
		private void PushBuffEffectData(IBuffEffectData buffData)
		{
			this.BuffEffectDataList.Add(buffData);
			this.HandleReconstructCardEffect(buffData);
		}

		// Token: 0x06036168 RID: 221544 RVA: 0x00CCC118 File Offset: 0x00CCA318
		private void HandleReconstructCardEffect(IBuffEffectData buffData)
		{
			PhantomBattleEffectResultInfo effect = buffData.Effect;
			if (((effect != null) ? effect.PhantomBattleReconstruct : null) != null)
			{
				PhantomBattleReconstruct phantomBattleReconstruct = buffData.Effect.PhantomBattleReconstruct;
				if (phantomBattleReconstruct.Camp == PhantomBattleEffectCardCamp.GamerFighterPlayer)
				{
					PhantomArenaBattleModel.Instance.AddWaitReconstructCardIdList(phantomBattleReconstruct.CardUid.ToList<int>());
				}
			}
		}

		// Token: 0x06036169 RID: 221545 RVA: 0x00CCC164 File Offset: 0x00CCA364
		public void PushBuffEffectDataBySkillList(PhantomBattleSkillTriggerInfo[] skillTriggerInfoList, ENotifyMessageId notifyId)
		{
			foreach (PhantomBattleSkillTriggerInfo skillTriggerInfo in skillTriggerInfoList)
			{
				this.CreateBuffEffectData(skillTriggerInfo, new ENotifyMessageId?(notifyId));
			}
			EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
		}

		// Token: 0x0603616A RID: 221546 RVA: 0x00CCC1A4 File Offset: 0x00CCA3A4
		public void PushBuffEffectDataBySkill(PhantomBattleSkillTriggerInfo skillTriggerInfo)
		{
			this.CreateBuffEffectData(skillTriggerInfo, null);
			EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
		}

		// Token: 0x0603616B RID: 221547 RVA: 0x00CCC1D4 File Offset: 0x00CCA3D4
		private void PushBuffEffectDataByEffect(PhantomBattleBuffTriggerInfo buffTriggerInfo, ENotifyMessageId notifyId)
		{
			BuffEffectData buffData = new BuffEffectData
			{
				SourceFightId = buffTriggerInfo.SourceFighterUId,
				SkillId = buffTriggerInfo.PhantomBattleBuffId,
				SelectFightIdList = new List<int>(buffTriggerInfo.SelectFighterUId),
				Effect = buffTriggerInfo.PhantomBattleEffectResultInfo,
				NotifyId = new ENotifyMessageId?(notifyId)
			};
			this.PushBuffEffectData(buffData);
		}

		// Token: 0x0603616C RID: 221548 RVA: 0x00CCC230 File Offset: 0x00CCA430
		public void PushBuffEffectDataByEffectList(PhantomBattleBuffTriggerInfo[] buffTriggerInfoList, ENotifyMessageId notifyId)
		{
			foreach (PhantomBattleBuffTriggerInfo buffTriggerInfo in buffTriggerInfoList)
			{
				this.PushBuffEffectDataByEffect(buffTriggerInfo, notifyId);
			}
			EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
		}

		// Token: 0x0603616D RID: 221549 RVA: 0x00CCC26C File Offset: 0x00CCA46C
		public void PushBuffEffectDataByNpc(int fightId, NpcPhantomBattleCardSkillInfo info, ENotifyMessageId notifyId, bool isWaitEffect)
		{
			BuffEffectData buffData = new BuffEffectData
			{
				SourceFightId = fightId,
				SkillId = info.SkillId,
				SelectFightIdList = new List<int>(info.SelectFighterUId),
				Effect = info.PhantomBattleEffectResultInfo,
				NotifyId = new ENotifyMessageId?(notifyId)
			};
			this.PushBuffEffectData(buffData);
			if (isWaitEffect)
			{
				EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
			}
		}

		// Token: 0x0603616E RID: 221550 RVA: 0x00CCC2D8 File Offset: 0x00CCA4D8
		public void PushBuffEffectDataByNpc(int fightId, NpcPhantomBattleCardDurableSkillInfo info, ENotifyMessageId notifyId, bool isWaitEffect)
		{
			BuffEffectData buffData = new BuffEffectData
			{
				SourceFightId = fightId,
				SkillId = info.SkillId,
				SelectFightIdList = new List<int>(info.SelectFighterUId),
				Effect = info.PhantomBattleEffectResultInfo,
				NotifyId = new ENotifyMessageId?(notifyId)
			};
			this.PushBuffEffectData(buffData);
			if (isWaitEffect)
			{
				EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
			}
		}

		// Token: 0x0603616F RID: 221551 RVA: 0x00CCC342 File Offset: 0x00CCA542
		public IBuffEffectData PopBuffEffectData()
		{
			if (this.BuffEffectDataList.Count > 0)
			{
				IBuffEffectData result = this.BuffEffectDataList[0];
				this.BuffEffectDataList.RemoveAt(0);
				return result;
			}
			return null;
		}

		// Token: 0x06036170 RID: 221552 RVA: 0x00CCC36C File Offset: 0x00CCA56C
		public void SetCardSkillTriggerInfo(EPhantomArenaBuffEffectType effectType, List<int> fightIdList, int selectNum, int cardId, bool isFight, int skillId, bool isClickInteract)
		{
			this.CardSkillTriggerInfo = new SkillTriggerInfo
			{
				InteractType = effectType,
				SelectFightIdList = fightIdList,
				SelectNum = selectNum,
				SkillId = new int?(skillId),
				DataId = new int?(cardId),
				IsRole = false,
				IsPassive = false,
				IsFight = isFight,
				IsClickInteract = isClickInteract
			};
		}

		// Token: 0x06036171 RID: 221553 RVA: 0x00CCC3D4 File Offset: 0x00CCA5D4
		public void SetRoleSkillTriggerInfo(EPhantomArenaBuffEffectType effectType, List<int> fightIdList, int selectNum, int skillId)
		{
			this.RoleSkillTriggerInfo = new SkillTriggerInfo
			{
				InteractType = effectType,
				SelectFightIdList = fightIdList,
				SelectNum = selectNum,
				DataId = new int?(skillId),
				IsRole = true,
				IsPassive = false,
				IsFight = false,
				IsClickInteract = false
			};
		}

		// Token: 0x06036172 RID: 221554 RVA: 0x00CCC42C File Offset: 0x00CCA62C
		public IBuffEffectData NewBuffEffectData(PhantomBattleSkillTriggerInfo skillTriggerInfo, ENotifyMessageId? notifyId = null)
		{
			return new BuffEffectData
			{
				SourceFightId = skillTriggerInfo.SourceFighterUId,
				SkillId = skillTriggerInfo.SkillId,
				SelectFightIdList = new List<int>(skillTriggerInfo.SelectFighterUId),
				Effect = skillTriggerInfo.PhantomBattleEffectResultInfo,
				NotifyId = notifyId
			};
		}

		// Token: 0x0401CA1D RID: 117277
		private readonly List<IBuffEffectData> BuffEffectDataList = new List<IBuffEffectData>();

		// Token: 0x0401CA1E RID: 117278
		public ISkillTriggerInfo CardSkillTriggerInfo;

		// Token: 0x0401CA1F RID: 117279
		public ISkillTriggerInfo RoleSkillTriggerInfo;
	}
}
