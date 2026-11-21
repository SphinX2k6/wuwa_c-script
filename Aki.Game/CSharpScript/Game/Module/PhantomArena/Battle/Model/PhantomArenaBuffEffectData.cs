using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200426A RID: 17002
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectData
	{
		// Token: 0x0602B061 RID: 176225 RVA: 0x00C1981C File Offset: 0x00C17A1C
		private void CreateBuffEffectData(PhantomBattleSkillTriggerInfo skillTriggerInfo, ENotifyMessageId? notifyId = null)
		{
			IBuffEffectData buffData = this.NewBuffEffectData(skillTriggerInfo, notifyId);
			this.PushBuffEffectData(buffData);
		}

		// Token: 0x0602B062 RID: 176226 RVA: 0x00C19839 File Offset: 0x00C17A39
		private void PushBuffEffectData(IBuffEffectData buffData)
		{
			this.BuffEffectDataList.Add(buffData);
			this.HandleReconstructCardEffect(buffData);
		}

		// Token: 0x0602B063 RID: 176227 RVA: 0x00C19850 File Offset: 0x00C17A50
		private void HandleReconstructCardEffect(IBuffEffectData buffData)
		{
			PhantomBattleEffectResultInfo effect = buffData.Effect;
			if (((effect != null) ? effect.PhantomBattleReconstruct : null) != null)
			{
				PhantomBattleReconstruct phantomBattleReconstruct = buffData.Effect.PhantomBattleReconstruct;
				if (phantomBattleReconstruct.Camp == PhantomBattleEffectCardCamp.GamerFighterPlayer)
				{
					PhantomArenaBattleModel.Instance.AddWaitReconstructCardIdList(phantomBattleReconstruct.CardUid);
				}
			}
		}

		// Token: 0x0602B064 RID: 176228 RVA: 0x00C19898 File Offset: 0x00C17A98
		public void PushBuffEffectDataBySkillList(PhantomBattleSkillTriggerInfo[] skillTriggerInfoList, ENotifyMessageId notifyId)
		{
			foreach (PhantomBattleSkillTriggerInfo skillTriggerInfo in skillTriggerInfoList)
			{
				this.CreateBuffEffectData(skillTriggerInfo, new ENotifyMessageId?(notifyId));
			}
			EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
		}

		// Token: 0x0602B065 RID: 176229 RVA: 0x00C198D8 File Offset: 0x00C17AD8
		public void PushBuffEffectDataBySkill(PhantomBattleSkillTriggerInfo skillTriggerInfo)
		{
			this.CreateBuffEffectData(skillTriggerInfo, null);
			EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
		}

		// Token: 0x0602B066 RID: 176230 RVA: 0x00C19908 File Offset: 0x00C17B08
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

		// Token: 0x0602B067 RID: 176231 RVA: 0x00C19964 File Offset: 0x00C17B64
		public void PushBuffEffectDataByEffectList(PhantomBattleBuffTriggerInfo[] buffTriggerInfoList, ENotifyMessageId notifyId)
		{
			foreach (PhantomBattleBuffTriggerInfo buffTriggerInfo in buffTriggerInfoList)
			{
				this.PushBuffEffectDataByEffect(buffTriggerInfo, notifyId);
			}
			EventSystem.Instance.Emit(EEventName.PhantomArenaTriggerSkillEffect);
		}

		// Token: 0x0602B068 RID: 176232 RVA: 0x00C199A0 File Offset: 0x00C17BA0
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

		// Token: 0x0602B069 RID: 176233 RVA: 0x00C19A0C File Offset: 0x00C17C0C
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

		// Token: 0x0602B06A RID: 176234 RVA: 0x00C19A76 File Offset: 0x00C17C76
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

		// Token: 0x0602B06B RID: 176235 RVA: 0x00C19AA0 File Offset: 0x00C17CA0
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

		// Token: 0x0602B06C RID: 176236 RVA: 0x00C19B08 File Offset: 0x00C17D08
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

		// Token: 0x0602B06D RID: 176237 RVA: 0x00C19B60 File Offset: 0x00C17D60
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

		// Token: 0x04017452 RID: 95314
		private readonly List<IBuffEffectData> BuffEffectDataList = new List<IBuffEffectData>();

		// Token: 0x04017453 RID: 95315
		public ISkillTriggerInfo CardSkillTriggerInfo;

		// Token: 0x04017454 RID: 95316
		public ISkillTriggerInfo RoleSkillTriggerInfo;
	}
}
