using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004265 RID: 16997
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PhantomArenaBattleModel : ModelBase
	{
		// Token: 0x17005649 RID: 22089
		// (get) Token: 0x0602AFF7 RID: 176119 RVA: 0x00C18B57 File Offset: 0x00C16D57
		public int Round
		{
			get
			{
				return this.RoundInternal;
			}
		}

		// Token: 0x1700564A RID: 22090
		// (get) Token: 0x0602AFF8 RID: 176120 RVA: 0x00C18B5F File Offset: 0x00C16D5F
		public int ChallengeId
		{
			get
			{
				return this.ChallengeIdInternal;
			}
		}

		// Token: 0x0602AFF9 RID: 176121 RVA: 0x00C18B68 File Offset: 0x00C16D68
		public PhantomArenaBattleModel()
		{
			this.SpeedList = new List<float>(CommonConfig.Instance.GetPhantomArenaBattleSpeed());
		}

		// Token: 0x0602AFFA RID: 176122 RVA: 0x00C18BB8 File Offset: 0x00C16DB8
		public void InitData()
		{
			this.RoundInternal = 1;
			this.ReplaceCardData = new PhantomArenaReplaceCardData();
			this.OwnData = new PhantomArenaOwnData();
			this.OpponentData = new PhantomArenaOpponentData();
			this.BattleData = new PhantomArenaBattleData();
			this.BuffEffectData = new PhantomArenaBuffEffectData();
			this.SelectCardData = new PhantomArenaSelectCardData();
		}

		// Token: 0x0602AFFB RID: 176123 RVA: 0x00C18C10 File Offset: 0x00C16E10
		public void SetChallengeId(int challengeId)
		{
			this.ChallengeIdInternal = challengeId;
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(phantomBattleChallenge.ActivityId);
			this.IsOldBvb = (activityConfig != null && activityConfig.GetValueOrDefault().Type == 52);
		}

		// Token: 0x0602AFFC RID: 176124 RVA: 0x00C18C67 File Offset: 0x00C16E67
		public void SetRound(int round)
		{
			this.RoundInternal = round;
			EventSystem.Instance.Emit(EEventName.RefreshRound);
		}

		// Token: 0x0602AFFD RID: 176125 RVA: 0x00C18C80 File Offset: 0x00C16E80
		public void SetReplaceCardToHandCard(PhantomBattleDealCardReplaceResponse response)
		{
			this.ReplaceCardData.ClearReplaceCardData();
			this.OwnData.RefreshCardLibraryNum(response.CurCardLibraryNum);
			PhantomBattleHandCardInfo[] array = new PhantomBattleHandCardInfo[response.PhantomBattleHandCardInfos.Count];
			response.PhantomBattleHandCardInfos.CopyTo(array, 0);
			this.OwnData.InitHandData(array);
			EventSystem.Instance.Emit(EEventName.ReplaceCardFinish);
		}

		// Token: 0x0602AFFE RID: 176126 RVA: 0x00C18CE4 File Offset: 0x00C16EE4
		public void SetReplaceCardToHandCardWithoutChange(IReadOnlyList<PhantomBattleHandCardInfo> dataList)
		{
			PhantomBattleHandCardInfo[] array = new PhantomBattleHandCardInfo[dataList.Count];
			for (int i = 0; i < dataList.Count; i++)
			{
				array[i] = dataList[i];
			}
			this.OwnData.InitHandData(array);
		}

		// Token: 0x0602AFFF RID: 176127 RVA: 0x00C18D24 File Offset: 0x00C16F24
		public void RefreshFighterAttr(int fightId, Dictionary<int, int> battleAttrMap)
		{
			if (fightId == this.OwnData.FightId)
			{
				this.OwnData.RefreshBattleAttr(battleAttrMap);
				return;
			}
			if (fightId == this.OpponentData.FightId)
			{
				this.OpponentData.RefreshBattleAttr(battleAttrMap);
				return;
			}
			this.OpponentData.RefreshCardAttr(fightId, battleAttrMap);
			this.OwnData.RefreshCardAttr(fightId, battleAttrMap);
		}

		// Token: 0x0602B000 RID: 176128 RVA: 0x00C18D84 File Offset: 0x00C16F84
		public void InitTaskData(IReadOnlyList<PhantomBattleGamerFourCTaskInfo> dataList)
		{
			foreach (PhantomBattleGamerFourCTaskInfo phantomBattleGamerFourCTaskInfo in dataList)
			{
				if (phantomBattleGamerFourCTaskInfo.GamerIndex == 0)
				{
					this.OpponentData.InitTaskData(phantomBattleGamerFourCTaskInfo);
				}
				else
				{
					this.OwnData.InitTaskData(phantomBattleGamerFourCTaskInfo);
				}
			}
		}

		// Token: 0x0602B001 RID: 176129 RVA: 0x00C18DE8 File Offset: 0x00C16FE8
		public void InitFieldData()
		{
			this.OpponentData.InitFieldData();
			this.OwnData.InitFieldData();
		}

		// Token: 0x0602B002 RID: 176130 RVA: 0x00C18E00 File Offset: 0x00C17000
		public void InitRecycleData()
		{
			this.OpponentData.InitRecycleData();
			this.OwnData.InitRecycleData();
		}

		// Token: 0x0602B003 RID: 176131 RVA: 0x00C18E18 File Offset: 0x00C17018
		public void RefreshFieldAndRecycleLockData(IReadOnlyList<AreaSealInfo> sealInfos)
		{
			foreach (AreaSealInfo areaSealInfo in sealInfos)
			{
				if (areaSealInfo.AreaType == BattleAreaType.Retrieve)
				{
					if (areaSealInfo.UId == this.OpponentData.FightId)
					{
						this.OpponentData.RefreshRecycleLockData(areaSealInfo.UnLockRound);
					}
					else
					{
						this.OwnData.RefreshRecycleLockData(areaSealInfo.UnLockRound, true);
					}
				}
				else if (areaSealInfo.AreaType == BattleAreaType.Area)
				{
					if (areaSealInfo.UId == this.OpponentData.FightId)
					{
						this.OpponentData.RefreshFieldLockData(areaSealInfo.UnLockRound, true);
					}
					else
					{
						this.OwnData.RefreshFieldLockData(areaSealInfo.UnLockRound);
					}
				}
			}
		}

		// Token: 0x0602B004 RID: 176132 RVA: 0x00C18EE4 File Offset: 0x00C170E4
		public void RefreshTaskData(IReadOnlyList<PhantomBattleGamerFourCTaskInfo> dataList)
		{
			foreach (PhantomBattleGamerFourCTaskInfo phantomBattleGamerFourCTaskInfo in dataList)
			{
				if (phantomBattleGamerFourCTaskInfo.GamerIndex == 0)
				{
					this.OpponentData.RefreshTaskData(phantomBattleGamerFourCTaskInfo);
				}
				else if (phantomBattleGamerFourCTaskInfo.GamerIndex == 1)
				{
					this.OwnData.RefreshTaskData(phantomBattleGamerFourCTaskInfo);
				}
			}
		}

		// Token: 0x0602B005 RID: 176133 RVA: 0x00C18F50 File Offset: 0x00C17150
		public bool CheckSkillEnoughCost(int skillId)
		{
			int battleStatusValue = this.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
			int costConsume = PhantomArenaConfig.Instance.GetPhantomBattleSkillConfig(skillId).CostConsume;
			return battleStatusValue - costConsume >= 0;
		}

		// Token: 0x0602B006 RID: 176134 RVA: 0x00C18F85 File Offset: 0x00C17185
		public List<int> GetFightIdList(List<int> cardIdList)
		{
			List<int> list = new List<int>();
			list.AddRange(this.OwnData.GetFightIdList(cardIdList));
			list.AddRange(this.OpponentData.GetFightIdList(cardIdList));
			return list;
		}

		// Token: 0x0602B007 RID: 176135 RVA: 0x00C18FB0 File Offset: 0x00C171B0
		public void SetSpeedUp()
		{
			this.SpeedUpIndex++;
			if (this.SpeedUpIndex >= this.SpeedList.Count)
			{
				this.SpeedUpIndex = 0;
			}
			this.ApplySpeedUp();
		}

		// Token: 0x0602B008 RID: 176136 RVA: 0x00C18FE0 File Offset: 0x00C171E0
		public void ApplySpeedUp()
		{
			if (!this.IsInBattle)
			{
				return;
			}
			GameModeController.Instance.SetTimeDilation(this.SpeedList[this.SpeedUpIndex], ETimeDilationType.PhantomBattleArena);
			this.ApplySpeedBuff(this.SpeedList[this.SpeedUpIndex]);
		}

		// Token: 0x0602B009 RID: 176137 RVA: 0x00C1901E File Offset: 0x00C1721E
		public float GetSpeedUpText()
		{
			if (this.SpeedUpIndex < this.SpeedList.Count)
			{
				return this.SpeedList[this.SpeedUpIndex];
			}
			return 1f;
		}

		// Token: 0x0602B00A RID: 176138 RVA: 0x00C1904A File Offset: 0x00C1724A
		public void SetNormalSpeed()
		{
			this.ApplySpeedBuff(1f);
			GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.PhantomBattleArena);
		}

		// Token: 0x0602B00B RID: 176139 RVA: 0x00C19068 File Offset: 0x00C17268
		protected void ApplySpeedBuff(float speed)
		{
			float timeScale = 1f / speed;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return;
			}
			int entityId = baseCharacter.EntityId;
			PawnTimeScaleComponent component = EntitySystem.Instance.GetComponent<PawnTimeScaleComponent>(entityId);
			if (component != null)
			{
				component.SetForeverTimeScale(ETimeScaleSourceType.PhantomArenaBattle, timeScale, 0, false);
			}
		}

		// Token: 0x0602B00C RID: 176140 RVA: 0x00C190B1 File Offset: 0x00C172B1
		public void SetIsInBattle(bool inBattle)
		{
			this.IsInBattle = inBattle;
			if (inBattle)
			{
				this.SetTurnCountResultEnd(false);
				this.SetDealCardNotify(null);
				this.SetPhantomBattleBoardSettleNotify(null);
				this.ApplySpeedUp();
				return;
			}
			this.SetNormalSpeed();
		}

		// Token: 0x0602B00D RID: 176141 RVA: 0x00C190DF File Offset: 0x00C172DF
		public bool GetTurnCountResultEnd()
		{
			return this.TurnCountResultEnd;
		}

		// Token: 0x0602B00E RID: 176142 RVA: 0x00C190E7 File Offset: 0x00C172E7
		public void SetTurnCountResultEnd(bool value)
		{
			this.TurnCountResultEnd = value;
		}

		// Token: 0x0602B00F RID: 176143 RVA: 0x00C190F0 File Offset: 0x00C172F0
		[NullableContext(2)]
		public void SetDealCardNotify(PhantomBattleDealCardNotify notify)
		{
			this.PhantomBattleDealCardNotify = notify;
		}

		// Token: 0x0602B010 RID: 176144 RVA: 0x00C190F9 File Offset: 0x00C172F9
		[NullableContext(2)]
		public void SetPhantomBattleBoardSettleNotify(PhantomBattleBoardSettleNotify notify)
		{
			this.PhantomBattleSettleNotify = notify;
			if (notify != null)
			{
				EventSystem.Instance.Emit(EEventName.PhantomBattleBoardSettleNotify);
			}
		}

		// Token: 0x0602B011 RID: 176145 RVA: 0x00C19115 File Offset: 0x00C17315
		[NullableContext(2)]
		public PhantomBattleDealCardNotify GetDealCardNotify()
		{
			return this.PhantomBattleDealCardNotify;
		}

		// Token: 0x0602B012 RID: 176146 RVA: 0x00C1911D File Offset: 0x00C1731D
		[NullableContext(2)]
		public PhantomBattleBoardSettleNotify GetPhantomBattleSettleNotify()
		{
			return this.PhantomBattleSettleNotify;
		}

		// Token: 0x0602B013 RID: 176147 RVA: 0x00C19128 File Offset: 0x00C17328
		public void TryPhantomBattleDealCardNotify()
		{
			this.SetTurnCountResultEnd(true);
			PhantomBattleDealCardNotify dealCardNotify = this.GetDealCardNotify();
			PhantomBattleBoardSettleNotify phantomBattleSettleNotify = this.GetPhantomBattleSettleNotify();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "声骸竞技场BvB结算表现结束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("canNext", dealCardNotify != null || phantomBattleSettleNotify != null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (dealCardNotify != null)
			{
				PhantomArenaBattleController.PhantomBattleDealCardNotify(dealCardNotify, null);
				return;
			}
			if (phantomBattleSettleNotify != null)
			{
				PhantomArenaBattleController.TriggerPhantomBattleBoardSettle();
			}
		}

		// Token: 0x0602B014 RID: 176148 RVA: 0x00C19198 File Offset: 0x00C17398
		public void OnClickExitButtonConfirm()
		{
			this.SetIsInBattle(false);
			AudioSystem.Instance.ExecuteAction("play_music_arena_battle", EAudioActionType.Stop, null);
		}

		// Token: 0x0602B015 RID: 176149 RVA: 0x00C191C8 File Offset: 0x00C173C8
		public Dictionary<int, int> GetPhantomTagMap()
		{
			if (this.PhantomTagInited)
			{
				return this.PhantomTagMap;
			}
			this.PhantomTagInited = true;
			foreach (PhantomBattleFactor phantomBattleFactor in PhantomArenaConfig.Instance.GetPhantomBattleAllFactor())
			{
				if (!phantomBattleFactor.IsBeforeBattle && !StringUtils.IsBlank(phantomBattleFactor.Tag))
				{
					int tagIdByName = GameplayTagUtils.GetTagIdByName(phantomBattleFactor.Tag);
					this.PhantomTagMap[tagIdByName] = phantomBattleFactor.Id;
				}
			}
			return this.PhantomTagMap;
		}

		// Token: 0x0602B016 RID: 176150 RVA: 0x00C19268 File Offset: 0x00C17468
		public unsafe void AddWaitCallCardIdList(List<int> cardIdList)
		{
			foreach (int num in cardIdList)
			{
				PhantomCardData battleCardByCardId = this.OwnData.GetBattleCardByCardId(num);
				this.WaitCallCardIdMap[num] = battleCardByCardId.Index;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加等待召唤卡牌ID列表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CardIdList", cardIdList);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaitCallCardIdMap", this.WaitCallCardIdMap.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602B017 RID: 176151 RVA: 0x00C19334 File Offset: 0x00C17534
		public unsafe void RemoveWaitCallCardIdList(List<int> cardIdList)
		{
			foreach (int key in cardIdList)
			{
				this.WaitCallCardIdMap.Remove(key);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "移除等待召唤卡牌ID列表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CardIdList", cardIdList);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaitCallCardIdMap", this.WaitCallCardIdMap.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602B018 RID: 176152 RVA: 0x00C193F0 File Offset: 0x00C175F0
		public bool InWaitCallCardIdList(int cardId)
		{
			return this.WaitCallCardIdMap.ContainsKey(cardId);
		}

		// Token: 0x0602B019 RID: 176153 RVA: 0x00C19400 File Offset: 0x00C17600
		private void ClearWaitCallCardIdList()
		{
			this.WaitCallCardIdMap.Clear();
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "清空等待召唤卡牌ID列表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602B01A RID: 176154 RVA: 0x00C19438 File Offset: 0x00C17638
		public unsafe void AddWaitReconstructCardIdList(IEnumerable<int> cardIdList)
		{
			foreach (int num in cardIdList)
			{
				PhantomCardData battleCardByCardId = this.OwnData.GetBattleCardByCardId(num);
				this.WaitReconstructCardIdMap[num] = battleCardByCardId.Index;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加等待重构卡牌ID列表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CardIdList", cardIdList);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaitReconstructCardIdSet", this.WaitReconstructCardIdMap.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602B01B RID: 176155 RVA: 0x00C19500 File Offset: 0x00C17700
		public unsafe void RemoveWaitReconstructCardIdList(IEnumerable<int> cardIdList)
		{
			foreach (int key in cardIdList)
			{
				this.WaitReconstructCardIdMap.Remove(key);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "移除等待重构卡牌ID列表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CardIdList", cardIdList);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaitReconstructCardIdMap", this.WaitReconstructCardIdMap.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602B01C RID: 176156 RVA: 0x00C195B4 File Offset: 0x00C177B4
		public bool InWaitReconstructCardIdList(int cardId)
		{
			return this.WaitReconstructCardIdMap.ContainsKey(cardId);
		}

		// Token: 0x0602B01D RID: 176157 RVA: 0x00C195C4 File Offset: 0x00C177C4
		private void ClearWaitReconstructCardIdList()
		{
			this.WaitReconstructCardIdMap.Clear();
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "清空等待重构卡牌ID列表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602B01E RID: 176158 RVA: 0x00C195FC File Offset: 0x00C177FC
		public bool CanSetSlotIndex(int slotIndex)
		{
			using (Dictionary<int, int>.ValueCollection.Enumerator enumerator = this.WaitCallCardIdMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == slotIndex)
					{
						return false;
					}
				}
			}
			using (Dictionary<int, int>.ValueCollection.Enumerator enumerator = this.WaitReconstructCardIdMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == slotIndex)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0602B01F RID: 176159 RVA: 0x00C1969C File Offset: 0x00C1789C
		public bool CanDragCard(int cardId)
		{
			return !this.InWaitCallCardIdList(cardId) && !this.InWaitReconstructCardIdList(cardId);
		}

		// Token: 0x0602B020 RID: 176160 RVA: 0x00C196B5 File Offset: 0x00C178B5
		public void ClearWaitBattleData()
		{
			this.ClearWaitCallCardIdList();
			this.ClearWaitReconstructCardIdList();
		}

		// Token: 0x1700564B RID: 22091
		// (get) Token: 0x0602B021 RID: 176161 RVA: 0x00C196C3 File Offset: 0x00C178C3
		public static PhantomArenaBattleModel Instance
		{
			get
			{
				return PhantomArenaBattleModel._Instance;
			}
		}

		// Token: 0x0602B022 RID: 176162 RVA: 0x00C196CA File Offset: 0x00C178CA
		public static PhantomArenaBattleModel GetOrCreateInstance()
		{
			if (PhantomArenaBattleModel._Instance == null)
			{
				PhantomArenaBattleModel.CreateInstance();
			}
			return PhantomArenaBattleModel._Instance;
		}

		// Token: 0x0602B023 RID: 176163 RVA: 0x00C196DE File Offset: 0x00C178DE
		public static bool CreateInstance()
		{
			if (PhantomArenaBattleModel._Instance != null)
			{
				return true;
			}
			PhantomArenaBattleModel._Instance = new PhantomArenaBattleModel();
			return true;
		}

		// Token: 0x0602B024 RID: 176164 RVA: 0x00C196F4 File Offset: 0x00C178F4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B025 RID: 176165 RVA: 0x00C196F6 File Offset: 0x00C178F6
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaBattleModel._Instance = null;
		}

		// Token: 0x0602B026 RID: 176166 RVA: 0x00C196FE File Offset: 0x00C178FE
		static PhantomArenaBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaBattleModel.CreateStaticDefaultValue), new Action(PhantomArenaBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401742B RID: 95275
		[Nullable(2)]
		public PhantomBattleEnterCtx LoadingConfig;

		// Token: 0x0401742C RID: 95276
		public int InstId;

		// Token: 0x0401742D RID: 95277
		public PhantomArenaReplaceCardData ReplaceCardData;

		// Token: 0x0401742E RID: 95278
		public PhantomArenaOwnData OwnData;

		// Token: 0x0401742F RID: 95279
		public PhantomArenaOpponentData OpponentData;

		// Token: 0x04017430 RID: 95280
		public PhantomArenaBattleData BattleData;

		// Token: 0x04017431 RID: 95281
		public PhantomArenaBuffEffectData BuffEffectData;

		// Token: 0x04017432 RID: 95282
		public PhantomArenaSelectCardData SelectCardData;

		// Token: 0x04017433 RID: 95283
		public bool IsNeedShowTimeEndConfirm = true;

		// Token: 0x04017434 RID: 95284
		private int RoundInternal;

		// Token: 0x04017435 RID: 95285
		private int SpeedUpIndex;

		// Token: 0x04017436 RID: 95286
		private readonly List<float> SpeedList;

		// Token: 0x04017437 RID: 95287
		private bool IsInBattle;

		// Token: 0x04017438 RID: 95288
		private bool TurnCountResultEnd;

		// Token: 0x04017439 RID: 95289
		[Nullable(2)]
		private PhantomBattleDealCardNotify PhantomBattleDealCardNotify;

		// Token: 0x0401743A RID: 95290
		[Nullable(2)]
		private PhantomBattleBoardSettleNotify PhantomBattleSettleNotify;

		// Token: 0x0401743B RID: 95291
		private bool PhantomTagInited;

		// Token: 0x0401743C RID: 95292
		private readonly Dictionary<int, int> PhantomTagMap = new Dictionary<int, int>();

		// Token: 0x0401743D RID: 95293
		private int ChallengeIdInternal;

		// Token: 0x0401743E RID: 95294
		public bool IsOldBvb;

		// Token: 0x0401743F RID: 95295
		public bool IsBattleLoading;

		// Token: 0x04017440 RID: 95296
		public int CurrentLoading;

		// Token: 0x04017441 RID: 95297
		private readonly Dictionary<int, int> WaitCallCardIdMap = new Dictionary<int, int>();

		// Token: 0x04017442 RID: 95298
		private readonly Dictionary<int, int> WaitReconstructCardIdMap = new Dictionary<int, int>();

		// Token: 0x04017443 RID: 95299
		[Nullable(2)]
		private static PhantomArenaBattleModel _Instance;
	}
}
