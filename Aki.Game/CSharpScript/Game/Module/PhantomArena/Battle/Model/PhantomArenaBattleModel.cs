using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02005295 RID: 21141
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PhantomArenaBattleModel : ModelBase
	{
		// Token: 0x17008289 RID: 33417
		// (get) Token: 0x060360FC RID: 221436 RVA: 0x00CCB453 File Offset: 0x00CC9653
		public int Round
		{
			get
			{
				return this.RoundInternal;
			}
		}

		// Token: 0x1700828A RID: 33418
		// (get) Token: 0x060360FD RID: 221437 RVA: 0x00CCB45B File Offset: 0x00CC965B
		public int ChallengeId
		{
			get
			{
				return this.ChallengeIdInternal;
			}
		}

		// Token: 0x060360FE RID: 221438 RVA: 0x00CCB464 File Offset: 0x00CC9664
		public PhantomArenaBattleModel()
		{
			this.SpeedList = CommonConfig.Instance.GetPhantomArenaBattleSpeed().ToList<float>();
		}

		// Token: 0x060360FF RID: 221439 RVA: 0x00CCB4B4 File Offset: 0x00CC96B4
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

		// Token: 0x06036100 RID: 221440 RVA: 0x00CCB50C File Offset: 0x00CC970C
		public void SetChallengeId(int challengeId)
		{
			this.ChallengeIdInternal = challengeId;
			PhantomBattleChallenge phantomBattleChallenge = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId);
			Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(phantomBattleChallenge.ActivityId);
			this.IsOldBvb = (activityConfig != null && activityConfig.GetValueOrDefault().Type == 52);
		}

		// Token: 0x06036101 RID: 221441 RVA: 0x00CCB563 File Offset: 0x00CC9763
		public void SetRound(int round)
		{
			this.RoundInternal = round;
			EventSystem.Instance.Emit(EEventName.RefreshRound);
		}

		// Token: 0x06036102 RID: 221442 RVA: 0x00CCB57C File Offset: 0x00CC977C
		public void SetReplaceCardToHandCard(PhantomBattleDealCardReplaceResponse response)
		{
			this.ReplaceCardData.ClearReplaceCardData();
			this.OwnData.RefreshCardLibraryNum(response.CurCardLibraryNum);
			this.OwnData.InitHandData(response.PhantomBattleHandCardInfos.ToArray<PhantomBattleHandCardInfo>());
			EventSystem.Instance.Emit(EEventName.ReplaceCardFinish);
		}

		// Token: 0x06036103 RID: 221443 RVA: 0x00CCB5CB File Offset: 0x00CC97CB
		public void SetReplaceCardToHandCardWithoutChange(IReadOnlyList<PhantomBattleHandCardInfo> dataList)
		{
			this.OwnData.InitHandData(dataList.ToArray<PhantomBattleHandCardInfo>());
		}

		// Token: 0x06036104 RID: 221444 RVA: 0x00CCB5E0 File Offset: 0x00CC97E0
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

		// Token: 0x06036105 RID: 221445 RVA: 0x00CCB640 File Offset: 0x00CC9840
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

		// Token: 0x06036106 RID: 221446 RVA: 0x00CCB6A4 File Offset: 0x00CC98A4
		public void InitFieldData()
		{
			this.OpponentData.InitFieldData();
			this.OwnData.InitFieldData();
		}

		// Token: 0x06036107 RID: 221447 RVA: 0x00CCB6BC File Offset: 0x00CC98BC
		public void InitRecycleData()
		{
			this.OpponentData.InitRecycleData();
			this.OwnData.InitRecycleData();
		}

		// Token: 0x06036108 RID: 221448 RVA: 0x00CCB6D4 File Offset: 0x00CC98D4
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

		// Token: 0x06036109 RID: 221449 RVA: 0x00CCB7A0 File Offset: 0x00CC99A0
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

		// Token: 0x0603610A RID: 221450 RVA: 0x00CCB80C File Offset: 0x00CC9A0C
		public bool CheckSkillEnoughCost(int skillId)
		{
			int battleStatusValue = this.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
			int costConsume = PhantomArenaConfig.Instance.GetPhantomBattleSkillConfig(skillId).CostConsume;
			return battleStatusValue - costConsume >= 0;
		}

		// Token: 0x0603610B RID: 221451 RVA: 0x00CCB841 File Offset: 0x00CC9A41
		public List<int> GetFightIdList(List<int> cardIdList)
		{
			List<int> list = new List<int>();
			list.AddRange(this.OwnData.GetFightIdList(cardIdList));
			list.AddRange(this.OpponentData.GetFightIdList(cardIdList));
			return list;
		}

		// Token: 0x0603610C RID: 221452 RVA: 0x00CCB86C File Offset: 0x00CC9A6C
		public void SetSpeedUp()
		{
			this.SpeedUpIndex++;
			if (this.SpeedUpIndex >= this.SpeedList.Count)
			{
				this.SpeedUpIndex = 0;
			}
			this.ApplySpeedUp();
		}

		// Token: 0x0603610D RID: 221453 RVA: 0x00CCB89C File Offset: 0x00CC9A9C
		public void ApplySpeedUp()
		{
			if (!this.IsInBattle)
			{
				return;
			}
			GameModeController.Instance.SetTimeDilation(this.SpeedList[this.SpeedUpIndex], ETimeDilationType.PhantomBattleArena);
			this.ApplySpeedBuff(this.SpeedList[this.SpeedUpIndex]);
		}

		// Token: 0x0603610E RID: 221454 RVA: 0x00CCB8DA File Offset: 0x00CC9ADA
		public float GetSpeedUpText()
		{
			if (this.SpeedUpIndex < this.SpeedList.Count)
			{
				return this.SpeedList[this.SpeedUpIndex];
			}
			return 1f;
		}

		// Token: 0x0603610F RID: 221455 RVA: 0x00CCB906 File Offset: 0x00CC9B06
		public void SetNormalSpeed()
		{
			this.ApplySpeedBuff(1f);
			GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.PhantomBattleArena);
		}

		// Token: 0x06036110 RID: 221456 RVA: 0x00CCB924 File Offset: 0x00CC9B24
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

		// Token: 0x06036111 RID: 221457 RVA: 0x00CCB96D File Offset: 0x00CC9B6D
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

		// Token: 0x06036112 RID: 221458 RVA: 0x00CCB99B File Offset: 0x00CC9B9B
		public bool GetTurnCountResultEnd()
		{
			return this.TurnCountResultEnd;
		}

		// Token: 0x06036113 RID: 221459 RVA: 0x00CCB9A3 File Offset: 0x00CC9BA3
		public void SetTurnCountResultEnd(bool value)
		{
			this.TurnCountResultEnd = value;
		}

		// Token: 0x06036114 RID: 221460 RVA: 0x00CCB9AC File Offset: 0x00CC9BAC
		[NullableContext(2)]
		public void SetDealCardNotify(PhantomBattleDealCardNotify notify)
		{
			this.PhantomBattleDealCardNotify = notify;
		}

		// Token: 0x06036115 RID: 221461 RVA: 0x00CCB9B5 File Offset: 0x00CC9BB5
		[NullableContext(2)]
		public void SetPhantomBattleBoardSettleNotify(PhantomBattleBoardSettleNotify notify)
		{
			this.PhantomBattleSettleNotify = notify;
			if (notify != null)
			{
				EventSystem.Instance.Emit(EEventName.PhantomBattleBoardSettleNotify);
			}
		}

		// Token: 0x06036116 RID: 221462 RVA: 0x00CCB9D1 File Offset: 0x00CC9BD1
		[NullableContext(2)]
		public PhantomBattleDealCardNotify GetDealCardNotify()
		{
			return this.PhantomBattleDealCardNotify;
		}

		// Token: 0x06036117 RID: 221463 RVA: 0x00CCB9D9 File Offset: 0x00CC9BD9
		[NullableContext(2)]
		public PhantomBattleBoardSettleNotify GetPhantomBattleSettleNotify()
		{
			return this.PhantomBattleSettleNotify;
		}

		// Token: 0x06036118 RID: 221464 RVA: 0x00CCB9E4 File Offset: 0x00CC9BE4
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

		// Token: 0x06036119 RID: 221465 RVA: 0x00CCBA54 File Offset: 0x00CC9C54
		public void OnClickExitButtonConfirm()
		{
			this.SetIsInBattle(false);
			AudioSystem.Instance.ExecuteAction("play_music_arena_battle", EAudioActionType.Stop, null);
		}

		// Token: 0x0603611A RID: 221466 RVA: 0x00CCBA84 File Offset: 0x00CC9C84
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

		// Token: 0x0603611B RID: 221467 RVA: 0x00CCBB24 File Offset: 0x00CC9D24
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

		// Token: 0x0603611C RID: 221468 RVA: 0x00CCBBF0 File Offset: 0x00CC9DF0
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

		// Token: 0x0603611D RID: 221469 RVA: 0x00CCBCAC File Offset: 0x00CC9EAC
		public bool InWaitCallCardIdList(int cardId)
		{
			return this.WaitCallCardIdMap.ContainsKey(cardId);
		}

		// Token: 0x0603611E RID: 221470 RVA: 0x00CCBCBC File Offset: 0x00CC9EBC
		private void ClearWaitCallCardIdList()
		{
			this.WaitCallCardIdMap.Clear();
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "清空等待召唤卡牌ID列表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603611F RID: 221471 RVA: 0x00CCBCF4 File Offset: 0x00CC9EF4
		public unsafe void AddWaitReconstructCardIdList(List<int> cardIdList)
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

		// Token: 0x06036120 RID: 221472 RVA: 0x00CCBDC0 File Offset: 0x00CC9FC0
		public unsafe void RemoveWaitReconstructCardIdList(List<int> cardIdList)
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

		// Token: 0x06036121 RID: 221473 RVA: 0x00CCBE7C File Offset: 0x00CCA07C
		public bool InWaitReconstructCardIdList(int cardId)
		{
			return this.WaitReconstructCardIdMap.ContainsKey(cardId);
		}

		// Token: 0x06036122 RID: 221474 RVA: 0x00CCBE8C File Offset: 0x00CCA08C
		private void ClearWaitReconstructCardIdList()
		{
			this.WaitReconstructCardIdMap.Clear();
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "清空等待重构卡牌ID列表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06036123 RID: 221475 RVA: 0x00CCBEC4 File Offset: 0x00CCA0C4
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

		// Token: 0x06036124 RID: 221476 RVA: 0x00CCBF64 File Offset: 0x00CCA164
		public bool CanDragCard(int cardId)
		{
			return !this.InWaitCallCardIdList(cardId) && !this.InWaitReconstructCardIdList(cardId);
		}

		// Token: 0x06036125 RID: 221477 RVA: 0x00CCBF7D File Offset: 0x00CCA17D
		public void ClearWaitBattleData()
		{
			this.ClearWaitCallCardIdList();
			this.ClearWaitReconstructCardIdList();
		}

		// Token: 0x1700828B RID: 33419
		// (get) Token: 0x06036126 RID: 221478 RVA: 0x00CCBF8B File Offset: 0x00CCA18B
		public static PhantomArenaBattleModel Instance
		{
			get
			{
				return PhantomArenaBattleModel._Instance;
			}
		}

		// Token: 0x06036127 RID: 221479 RVA: 0x00CCBF92 File Offset: 0x00CCA192
		public static PhantomArenaBattleModel GetOrCreateInstance()
		{
			if (PhantomArenaBattleModel._Instance == null)
			{
				PhantomArenaBattleModel.CreateInstance();
			}
			return PhantomArenaBattleModel._Instance;
		}

		// Token: 0x06036128 RID: 221480 RVA: 0x00CCBFA6 File Offset: 0x00CCA1A6
		public static bool CreateInstance()
		{
			if (PhantomArenaBattleModel._Instance != null)
			{
				return true;
			}
			PhantomArenaBattleModel._Instance = new PhantomArenaBattleModel();
			return true;
		}

		// Token: 0x06036129 RID: 221481 RVA: 0x00CCBFBC File Offset: 0x00CCA1BC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603612A RID: 221482 RVA: 0x00CCBFBE File Offset: 0x00CCA1BE
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaBattleModel._Instance = null;
		}

		// Token: 0x0603612B RID: 221483 RVA: 0x00CCBFC6 File Offset: 0x00CCA1C6
		static PhantomArenaBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaBattleModel.CreateStaticDefaultValue), new Action(PhantomArenaBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401C9F6 RID: 117238
		[Nullable(2)]
		public PhantomBattleEnterCtx LoadingConfig;

		// Token: 0x0401C9F7 RID: 117239
		public int InstId;

		// Token: 0x0401C9F8 RID: 117240
		public PhantomArenaReplaceCardData ReplaceCardData;

		// Token: 0x0401C9F9 RID: 117241
		public PhantomArenaOwnData OwnData;

		// Token: 0x0401C9FA RID: 117242
		public PhantomArenaOpponentData OpponentData;

		// Token: 0x0401C9FB RID: 117243
		public PhantomArenaBattleData BattleData;

		// Token: 0x0401C9FC RID: 117244
		public PhantomArenaBuffEffectData BuffEffectData;

		// Token: 0x0401C9FD RID: 117245
		public PhantomArenaSelectCardData SelectCardData;

		// Token: 0x0401C9FE RID: 117246
		public bool IsNeedShowTimeEndConfirm = true;

		// Token: 0x0401C9FF RID: 117247
		private int RoundInternal;

		// Token: 0x0401CA00 RID: 117248
		private int SpeedUpIndex;

		// Token: 0x0401CA01 RID: 117249
		private readonly List<float> SpeedList;

		// Token: 0x0401CA02 RID: 117250
		private bool IsInBattle;

		// Token: 0x0401CA03 RID: 117251
		private bool TurnCountResultEnd;

		// Token: 0x0401CA04 RID: 117252
		[Nullable(2)]
		private PhantomBattleDealCardNotify PhantomBattleDealCardNotify;

		// Token: 0x0401CA05 RID: 117253
		[Nullable(2)]
		private PhantomBattleBoardSettleNotify PhantomBattleSettleNotify;

		// Token: 0x0401CA06 RID: 117254
		private bool PhantomTagInited;

		// Token: 0x0401CA07 RID: 117255
		private readonly Dictionary<int, int> PhantomTagMap = new Dictionary<int, int>();

		// Token: 0x0401CA08 RID: 117256
		private int ChallengeIdInternal;

		// Token: 0x0401CA09 RID: 117257
		public bool IsOldBvb;

		// Token: 0x0401CA0A RID: 117258
		public bool IsBattleLoading;

		// Token: 0x0401CA0B RID: 117259
		public int CurrentLoading;

		// Token: 0x0401CA0C RID: 117260
		private readonly Dictionary<int, int> WaitCallCardIdMap = new Dictionary<int, int>();

		// Token: 0x0401CA0D RID: 117261
		private readonly Dictionary<int, int> WaitReconstructCardIdMap = new Dictionary<int, int>();

		// Token: 0x0401CA0E RID: 117262
		[Nullable(2)]
		private static PhantomArenaBattleModel _Instance;
	}
}
