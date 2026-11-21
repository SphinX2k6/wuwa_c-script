using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP;
using AkiClient.Game.Aki.Character.NPC.RoleNPC;
using AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000513 RID: 1299
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GuessJokerGamePlayModel : ModelBase
{
	// Token: 0x06003EFA RID: 16122 RVA: 0x00161B58 File Offset: 0x0015FD58
	protected override bool OnInit()
	{
		IReadOnlyList<GuessJokerLevel> jokerLevelList = GuessJokerConfig.Instance.GetJokerLevelList();
		if (jokerLevelList.Count == 0)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker初始化失败：关卡配置表为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.LevelId = jokerLevelList[0].Id;
		return true;
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x00161BAF File Offset: 0x0015FDAF
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.PlotSequenceEnd, new Action(this.OnPlotSequenceEnd));
		this.PendingNpcSitSet.Clear();
		return true;
	}

	// Token: 0x06003EFC RID: 16124 RVA: 0x00161BD9 File Offset: 0x0015FDD9
	private void OnPlotSequenceEnd()
	{
		if (this.GetGamePlayView() == null)
		{
			return;
		}
		this.OpenGamePlayView(null);
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x00161BEB File Offset: 0x0015FDEB
	public void InitGame()
	{
		this.InGamePlay = true;
		this.CardDataMap.Clear();
		this.RoundStartTipShownMap.Clear();
	}

	// Token: 0x06003EFE RID: 16126 RVA: 0x00161C0C File Offset: 0x0015FE0C
	public void EnterGame(JokerGuessInitGame response, int levelId, string serverTime)
	{
		if (SpringManorModel.Instance.ActivityData == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker进入游戏失败：活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker进入游戏失败：游戏已经开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.InitGame();
		this.InitData(response, levelId, serverTime);
		this.InitStateMachine();
		this.ChangeState(EGuessJokerCardStateType.GameStart);
		this.InitTimerSystem();
	}

	// Token: 0x06003EFF RID: 16127 RVA: 0x00161C8F File Offset: 0x0015FE8F
	public void NextRound()
	{
		this.RoundNumber++;
		this.RoundStartTipShownMap.Clear();
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x00161CAC File Offset: 0x0015FEAC
	public UniTask RematchGame(JokerGuessInitGame response, int levelId, string serverTime)
	{
		GuessJokerGamePlayModel.<RematchGame>d__34 <RematchGame>d__;
		<RematchGame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RematchGame>d__.<>4__this = this;
		<RematchGame>d__.response = response;
		<RematchGame>d__.levelId = levelId;
		<RematchGame>d__.serverTime = serverTime;
		<RematchGame>d__.<>1__state = -1;
		<RematchGame>d__.<>t__builder.Start<GuessJokerGamePlayModel.<RematchGame>d__34>(ref <RematchGame>d__);
		return <RematchGame>d__.<>t__builder.Task;
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x00161D07 File Offset: 0x0015FF07
	public void ExitGame()
	{
		if (this.IsExit)
		{
			return;
		}
		this.IsExit = true;
		this.ChangeState(EGuessJokerCardStateType.GameExit);
	}

	// Token: 0x06003F02 RID: 16130 RVA: 0x00161D20 File Offset: 0x0015FF20
	public void GameEnd()
	{
		this.SetNpcPokerState(EPokerStateType.Idel);
		UiCameraModel.Instance.EnablePlayerActor();
		this.ClearData();
	}

	// Token: 0x06003F03 RID: 16131 RVA: 0x00161D3A File Offset: 0x0015FF3A
	public void SettleGameClear()
	{
		this.InGamePlay = false;
	}

	// Token: 0x170008E1 RID: 2273
	// (get) Token: 0x06003F04 RID: 16132 RVA: 0x00161D43 File Offset: 0x0015FF43
	public bool InGame
	{
		get
		{
			return this.InGamePlay;
		}
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x00161D4C File Offset: 0x0015FF4C
	public unsafe void InitData(JokerGuessInitGame gameData, int levelId, string serverTime)
	{
		this.LevelId = levelId;
		this.S_Track_Id = serverTime;
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJoker初始化数据失败：关卡配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", levelId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RoleId = jokerLevelById.Value.AiRole;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.GuessJokerCard;
		ELogAuthor author2 = ELogAuthor.LRC;
		string message2 = "GuessJoker初始化Npc roleId";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelId", levelId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleId", this.RoleId);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (gameData.AiHandCards != null && gameData.AiHandCards.CardIds != null)
		{
			foreach (int num in gameData.AiHandCards.CardIds)
			{
				GuessJokerCardData guessJokerCardData = new GuessJokerCardData(num);
				guessJokerCardData.SetBelongPlayerType(new EGuessJokerPlayerType?(EGuessJokerPlayerType.Ai));
				this.CardDataMap[num] = guessJokerCardData;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.GuessJokerCard;
			ELogAuthor author3 = ELogAuthor.LRC;
			string message3 = "GuessJoker初始化AI手牌";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("cardIdList", string.Join<int>(",", gameData.AiHandCards.CardIds));
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		if (gameData.PlayerHandCards != null && gameData.PlayerHandCards.CardIds != null)
		{
			foreach (int num2 in gameData.PlayerHandCards.CardIds)
			{
				GuessJokerCardData guessJokerCardData2 = new GuessJokerCardData(num2);
				guessJokerCardData2.SetBelongPlayerType(new EGuessJokerPlayerType?(EGuessJokerPlayerType.Me));
				this.CardDataMap[num2] = guessJokerCardData2;
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.GuessJokerCard;
			ELogAuthor author4 = ELogAuthor.LRC;
			string message4 = "GuessJoker初始化玩家手牌";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("cardIdList", string.Join<int>(",", gameData.PlayerHandCards.CardIds));
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		}
		this.RoundNumber = 0;
		this.FirstPlayerTurn = GuessJokerUtils.ServerPlayerTransToClient(gameData.FirstActor);
		int initHP = jokerLevelById.Value.InitHP;
		this.AiRoleData = new GuessJokerRoleData(EGuessJokerPlayerType.Ai, initHP);
		this.PlayerRoleData = new GuessJokerRoleData(EGuessJokerPlayerType.Me, initHP);
		IGuessJokerLevelInfo guessJokerGameData = SpringManorModel.Instance.ActivityData.GetGuessJokerGameData(this.LevelId);
		this.IsFinish = (guessJokerGameData != null && guessJokerGameData.FirstPass);
		this.ShowInitialNoPairTip = (!this.CheckPlayerHasPair(EGuessJokerPlayerType.Ai) || !this.CheckPlayerHasPair(EGuessJokerPlayerType.Me));
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x00162030 File Offset: 0x00160230
	public GuessJokerCardData GetBlankCardData()
	{
		foreach (GuessJokerCardData guessJokerCardData in this.CardDataMap.Values)
		{
			if (guessJokerCardData.Type == EGuessJokerCardType.Blank)
			{
				return guessJokerCardData;
			}
		}
		return null;
	}

	// Token: 0x06003F07 RID: 16135 RVA: 0x00162094 File Offset: 0x00160294
	public int GetJokerCardId()
	{
		foreach (GuessJokerCardData guessJokerCardData in this.CardDataMap.Values)
		{
			if (guessJokerCardData.Type == EGuessJokerCardType.Joker)
			{
				return guessJokerCardData.Id;
			}
		}
		Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker获取鬼牌失败：鬼牌数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
		return -1;
	}

	// Token: 0x06003F08 RID: 16136 RVA: 0x0016211C File Offset: 0x0016031C
	public void RemoveCardData(int[] cardIdList)
	{
		foreach (int key in cardIdList)
		{
			GuessJokerCardData guessJokerCardData;
			if (this.CardDataMap.TryGetValue(key, out guessJokerCardData))
			{
				this.CardDataMap.Remove(key);
			}
		}
	}

	// Token: 0x06003F09 RID: 16137 RVA: 0x0016215C File Offset: 0x0016035C
	public void ClearData()
	{
		this.InGamePlay = false;
		this.IsExit = false;
		this.CardDataMap.Clear();
		GuessJokerActionRunner<GuessJokerActionBase> actionRunner = this.ActionRunner;
		if (actionRunner != null)
		{
			actionRunner.Destroy();
		}
		this.ActionRunner = null;
		GuessJokerPlotActionRunner plotActionRunner = this.PlotActionRunner;
		if (plotActionRunner != null)
		{
			plotActionRunner.Destroy();
		}
		this.PlotActionRunner = null;
		this.ClearTimerHandle();
		this.AiRoleData = null;
		this.PlayerRoleData = null;
		this.ShowInitialNoPairTip = true;
		this.RoleId = -1;
		this.S_Track_Id = "";
		this.LastUsedPlotIdMap.Clear();
		GuessJokerDialogLogic activeDialogLogic = this.ActiveDialogLogic;
		if (activeDialogLogic != null)
		{
			activeDialogLogic.Clear();
		}
		this.ActiveDialogLogic = null;
		this.PlayerDrawnCardId = null;
		this.AiDrawnCardId = null;
		this.GuessJokerFsm = null;
	}

	// Token: 0x06003F0A RID: 16138 RVA: 0x00162221 File Offset: 0x00160421
	private void InitTimerSystem()
	{
		if (this.GamePlayTimerHandle != null)
		{
			this.ClearTimerHandle();
		}
		this.GamePlayTimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.GamePlayTick), 20f, 1f, null, null, true);
	}

	// Token: 0x06003F0B RID: 16139 RVA: 0x0016225A File Offset: 0x0016045A
	private void GamePlayTick(float deltaTime)
	{
		this.GuessJokerFsm.Tick(deltaTime);
		GuessJokerActionRunner<GuessJokerActionBase> actionRunner = this.ActionRunner;
		if (actionRunner != null)
		{
			actionRunner.Tick(deltaTime);
		}
		GuessJokerPlotActionRunner plotActionRunner = this.PlotActionRunner;
		if (plotActionRunner == null)
		{
			return;
		}
		plotActionRunner.Tick(deltaTime);
	}

	// Token: 0x06003F0C RID: 16140 RVA: 0x0016228B File Offset: 0x0016048B
	private void NpcSitTick(float deltaTime)
	{
		this.ProcessPendingNpcSit();
	}

	// Token: 0x06003F0D RID: 16141 RVA: 0x00162294 File Offset: 0x00160494
	private void ClearTimerHandle()
	{
		if (this.GamePlayTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.GamePlayTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.GamePlayTimerHandle);
			this.GamePlayTimerHandle = null;
		}
		if (this.NpcSitTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.NpcSitTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.NpcSitTimerHandle);
			this.NpcSitTimerHandle = null;
		}
	}

	// Token: 0x06003F0E RID: 16142 RVA: 0x00162305 File Offset: 0x00160505
	public void InitStateMachine()
	{
		this.GuessJokerFsm = new GuessJokerStageFsm();
		this.GuessJokerFsm.Init();
	}

	// Token: 0x06003F0F RID: 16143 RVA: 0x0016231D File Offset: 0x0016051D
	public void ChangeState(EGuessJokerCardStateType state)
	{
		this.GuessJokerFsm.ChangeState(state);
	}

	// Token: 0x06003F10 RID: 16144 RVA: 0x0016232C File Offset: 0x0016052C
	public void OpenGamePlayView(Action finishCallback = null)
	{
		UiCameraModel.Instance.DisablePlayerActor();
		UiManager.Instance.OpenView(EUiViewName.GuessJokerGamePlayView, this.EntityId, delegate(bool isSuccess, int viewId)
		{
			if (!isSuccess)
			{
				Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker打开游戏界面失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ExitGame();
				return;
			}
			this.GamePlayView = (UiManager.Instance.GetView(viewId) as GuessJokerGamePlayView);
			if (this.ActionRunner == null)
			{
				this.ActionRunner = new GuessJokerActionRunner<GuessJokerActionBase>();
			}
			if (this.PlotActionRunner == null)
			{
				this.PlotActionRunner = new GuessJokerPlotActionRunner();
			}
			this.SetNpcPokerState(EPokerStateType.Idel);
			Action finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2();
		});
	}

	// Token: 0x06003F11 RID: 16145 RVA: 0x00162380 File Offset: 0x00160580
	public UniTask CloseGamePlayViewAsync()
	{
		GuessJokerGamePlayModel.<CloseGamePlayViewAsync>d__52 <CloseGamePlayViewAsync>d__;
		<CloseGamePlayViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseGamePlayViewAsync>d__.<>4__this = this;
		<CloseGamePlayViewAsync>d__.<>1__state = -1;
		<CloseGamePlayViewAsync>d__.<>t__builder.Start<GuessJokerGamePlayModel.<CloseGamePlayViewAsync>d__52>(ref <CloseGamePlayViewAsync>d__);
		return <CloseGamePlayViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003F12 RID: 16146 RVA: 0x001623C4 File Offset: 0x001605C4
	public GuessJokerGamePlayView GetGamePlayView()
	{
		if (this.GamePlayView == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker获取游戏界面失败：游戏界面未打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.GamePlayView;
	}

	// Token: 0x06003F13 RID: 16147 RVA: 0x00162400 File Offset: 0x00160600
	public void PushActions(IReadOnlyList<GuessJokerActionBase> actions)
	{
		if (this.ActionRunner == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker PushActions Fail：ActionRunner is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ActionRunner.PushActions(actions);
	}

	// Token: 0x06003F14 RID: 16148 RVA: 0x00162444 File Offset: 0x00160644
	public void PushPlotActions(GuessJokerPlotAction[] actions)
	{
		if (this.PlotActionRunner == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker PushPlotActions Fail：PlotActionRunner is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PlotActionRunner.PushPlotActions(actions);
	}

	// Token: 0x06003F15 RID: 16149 RVA: 0x00162485 File Offset: 0x00160685
	public void SetWinner(JokerGuessActor winner)
	{
		this.Winner = GuessJokerUtils.ServerPlayerTransToClient(winner);
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x00162493 File Offset: 0x00160693
	public EGuessJokerPlayerType GetWinner()
	{
		return this.Winner;
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x0016249B File Offset: 0x0016069B
	public int GetLevelId()
	{
		return this.LevelId;
	}

	// Token: 0x06003F18 RID: 16152 RVA: 0x001624A3 File Offset: 0x001606A3
	public void UpdateTaskData(IEnumerable<JokerGuessOp> taskList)
	{
		this.TaskDataList.Clear();
		this.TaskDataList.AddRange(taskList);
		EventSystem.Instance.Emit(EEventName.GuessJokerCardUpdateTaskData);
	}

	// Token: 0x06003F19 RID: 16153 RVA: 0x001624CC File Offset: 0x001606CC
	public List<JokerGuessOp> GetTaskDataList()
	{
		List<JokerGuessOp> result = new List<JokerGuessOp>(this.TaskDataList);
		this.TaskDataList.Clear();
		return result;
	}

	// Token: 0x06003F1A RID: 16154 RVA: 0x001624E4 File Offset: 0x001606E4
	private bool CheckPlayerHasPair(EGuessJokerPlayerType playerType)
	{
		List<GuessJokerCardData> handCardsByPlayer = this.GetHandCardsByPlayer(playerType);
		HashSet<int> hashSet = new HashSet<int>();
		foreach (GuessJokerCardData guessJokerCardData in handCardsByPlayer)
		{
			int value = guessJokerCardData.Value;
			if (hashSet.Contains(value))
			{
				return true;
			}
			hashSet.Add(value);
		}
		return false;
	}

	// Token: 0x06003F1B RID: 16155 RVA: 0x00162558 File Offset: 0x00160758
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x170008E2 RID: 2274
	// (get) Token: 0x06003F1C RID: 16156 RVA: 0x00162560 File Offset: 0x00160760
	public int EntityId
	{
		get
		{
			GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(this.RoleId);
			if (jokerAiConfigByRoleId == null)
			{
				return -1;
			}
			return jokerAiConfigByRoleId.Value.NpcId;
		}
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x00162598 File Offset: 0x00160798
	public GuessJokerRoleData GetRoleData(EGuessJokerPlayerType playerType)
	{
		if (playerType == EGuessJokerPlayerType.Ai)
		{
			if (this.AiRoleData == null)
			{
				Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker获取角色数据失败：AI角色数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.AiRoleData;
		}
		else
		{
			if (this.PlayerRoleData == null)
			{
				Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker获取角色数据失败：玩家角色数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.PlayerRoleData;
		}
	}

	// Token: 0x06003F1E RID: 16158 RVA: 0x00162608 File Offset: 0x00160808
	public void UpdateHp(EGuessJokerPlayerType playerType, int value)
	{
		this.GetRoleData(playerType).SetHp(value);
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x00162618 File Offset: 0x00160818
	public List<IPlayCardInfo> GetPlayerPlayCardIdList()
	{
		List<GuessJokerCardData> handCardsByPlayer = this.GetHandCardsByPlayer(EGuessJokerPlayerType.Me);
		Dictionary<int, List<GuessJokerCardData>> dictionary = new Dictionary<int, List<GuessJokerCardData>>();
		foreach (GuessJokerCardData guessJokerCardData in handCardsByPlayer)
		{
			int value = guessJokerCardData.Value;
			if (!dictionary.ContainsKey(value))
			{
				dictionary[value] = new List<GuessJokerCardData>();
			}
			dictionary[value].Add(guessJokerCardData);
		}
		List<IPlayCardInfo> list = new List<IPlayCardInfo>();
		foreach (KeyValuePair<int, List<GuessJokerCardData>> keyValuePair in dictionary)
		{
			List<GuessJokerCardData> value2 = keyValuePair.Value;
			int count = value2.Count;
			if (count >= 2)
			{
				if (count > 2)
				{
					for (int i = value2.Count - 1; i >= 0; i--)
					{
						if (value2[i].Type == EGuessJokerCardType.Blank)
						{
							value2.RemoveAt(i);
						}
					}
				}
				List<int> list2 = new List<int>();
				foreach (GuessJokerCardData guessJokerCardData2 in value2)
				{
					list2.Add(guessJokerCardData2.Id);
				}
				list.Add(new PlayCardInfo
				{
					Value = keyValuePair.Key,
					CardIdList = list2.ToArray()
				});
			}
		}
		return list;
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x001627A0 File Offset: 0x001609A0
	public List<GuessJokerCardData> GetAllCardDataList()
	{
		return new List<GuessJokerCardData>(this.CardDataMap.Values);
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x001627B4 File Offset: 0x001609B4
	public GuessJokerCardData GetCardDataById(int cardId)
	{
		GuessJokerCardData result;
		if (!this.CardDataMap.TryGetValue(cardId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x001627D4 File Offset: 0x001609D4
	public List<GuessJokerCardData> QueryCards(Func<GuessJokerCardData, bool> predicate)
	{
		List<GuessJokerCardData> list = new List<GuessJokerCardData>();
		foreach (GuessJokerCardData guessJokerCardData in this.CardDataMap.Values)
		{
			if (predicate(guessJokerCardData))
			{
				list.Add(guessJokerCardData);
			}
		}
		return list;
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x0016283C File Offset: 0x00160A3C
	public List<GuessJokerCardData> GetHandCardsByPlayer(EGuessJokerPlayerType playerType)
	{
		return this.QueryCards(delegate(GuessJokerCardData card)
		{
			EGuessJokerPlayerType? belongPlayerType = card.GetBelongPlayerType();
			EGuessJokerPlayerType playerType2 = playerType;
			return belongPlayerType.GetValueOrDefault() == playerType2 & belongPlayerType != null;
		});
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x00162868 File Offset: 0x00160A68
	public List<GuessJokerCardData> GetAllCardsByPlayer(EGuessJokerPlayerType playerType)
	{
		return this.QueryCards(delegate(GuessJokerCardData card)
		{
			EGuessJokerPlayerType? belongPlayerType = card.GetBelongPlayerType();
			EGuessJokerPlayerType playerType2 = playerType;
			return belongPlayerType.GetValueOrDefault() == playerType2 & belongPlayerType != null;
		});
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x00162894 File Offset: 0x00160A94
	public void UpdateCardBelongPlayerType(IReadOnlyList<int> cardIdList, EGuessJokerPlayerType? playerType = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GuessJokerCard;
		ELogAuthor author = ELogAuthor.LRC;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
		defaultInterpolatedStringHandler.AppendLiteral("更新卡牌归属玩家类型：");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", cardIdList));
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted<EGuessJokerPlayerType?>(playerType);
		instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		foreach (int key in cardIdList)
		{
			GuessJokerCardData guessJokerCardData;
			if (this.CardDataMap.TryGetValue(key, out guessJokerCardData))
			{
				guessJokerCardData.SetBelongPlayerType(playerType);
			}
		}
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x0016294C File Offset: 0x00160B4C
	public int GetLevelIdByNpcId(int npcId)
	{
		GuessJokerLevel? jokerLevelByNpcId = GuessJokerConfig.Instance.GetJokerLevelByNpcId(npcId);
		if (jokerLevelByNpcId == null)
		{
			return -1;
		}
		return jokerLevelByNpcId.GetValueOrDefault().Id;
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x00162980 File Offset: 0x00160B80
	public int? GetLastUsedPlotId(int aiPlotConfigId)
	{
		int value;
		if (!this.LastUsedPlotIdMap.TryGetValue(aiPlotConfigId, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x001629AD File Offset: 0x00160BAD
	public void SetLastUsedPlotId(int aiPlotConfigId, int plotId)
	{
		this.LastUsedPlotIdMap[aiPlotConfigId] = plotId;
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x001629BC File Offset: 0x00160BBC
	public bool CheckBlankCardDisable()
	{
		using (Dictionary<int, GuessJokerCardData>.ValueCollection.Enumerator enumerator = this.CardDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Type == EGuessJokerCardType.Blank)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x00162A1C File Offset: 0x00160C1C
	public int GetAiSkillId()
	{
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(this.LevelId);
		if (jokerLevelById == null)
		{
			return -1;
		}
		return jokerLevelById.GetValueOrDefault().AiCardSkill;
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x00162A54 File Offset: 0x00160C54
	public void MarkRoundStartTipShown(EGuessJokerPlayerType playerType)
	{
		this.RoundStartTipShownMap[playerType] = true;
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x00162A64 File Offset: 0x00160C64
	public bool HasShownRoundStartTip(EGuessJokerPlayerType playerType)
	{
		bool flag;
		return this.RoundStartTipShownMap.TryGetValue(playerType, out flag) && flag;
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x00162A84 File Offset: 0x00160C84
	public bool IsInFirstTutorial()
	{
		if (!this.InGamePlay)
		{
			return false;
		}
		if (this.LevelId != 1010)
		{
			return false;
		}
		IGuessJokerLevelInfo guessJokerGameData = SpringManorModel.Instance.ActivityData.GetGuessJokerGameData(this.LevelId);
		return guessJokerGameData != null && !guessJokerGameData.FirstPass;
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x00162AD0 File Offset: 0x00160CD0
	public string GetPlayerNameByType(EGuessJokerPlayerType playerType)
	{
		if (playerType == EGuessJokerPlayerType.Me)
		{
			return FunctionModel.Instance.GetPlayerName();
		}
		int roleId = this.GetRoleId();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig != null)
		{
			string name = roleConfig.Value.Name;
			return ConfigMultiTextLang.GetLocalTextNew(name, null) ?? name;
		}
		return "";
	}

	// Token: 0x06003F2F RID: 16175 RVA: 0x00162B2C File Offset: 0x00160D2C
	public bool EnterNpcPokerState(int npcPbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcPbDataId);
		if (entityByPbDataId == null || entityByPbDataId.Entity == null)
		{
			return false;
		}
		CharacterLinkedAnimInstComponent component = entityByPbDataId.Entity.GetComponent<CharacterLinkedAnimInstComponent>();
		if (component != null)
		{
			component.SyncLinkGameplayAnimBlueprint(EGameplayABPType.Poker);
		}
		BaseMoveComponent component2 = entityByPbDataId.Entity.GetComponent<BaseMoveComponent>();
		if (component2 == null)
		{
			return false;
		}
		component2.IsRegionMoveMode = true;
		CharacterActorComponent component3 = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
		USkeletalMeshComponent uskeletalMeshComponent;
		if (component3 == null)
		{
			uskeletalMeshComponent = null;
		}
		else
		{
			TsBaseCharacter actor = component3.Actor;
			uskeletalMeshComponent = ((actor != null) ? actor.Mesh : null);
		}
		USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
		if (uskeletalMeshComponent2 == null)
		{
			return false;
		}
		ABP_BaseRole_Gameplay_Poker_C abp_BaseRole_Gameplay_Poker_C = uskeletalMeshComponent2.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY) as ABP_BaseRole_Gameplay_Poker_C;
		if (abp_BaseRole_Gameplay_Poker_C == null)
		{
			return false;
		}
		abp_BaseRole_Gameplay_Poker_C.SetPokerState(EPokerStateType.Idel);
		return true;
	}

	// Token: 0x06003F30 RID: 16176 RVA: 0x00162BD0 File Offset: 0x00160DD0
	public bool SetNpcPokerState(EPokerStateType state)
	{
		ABP_BaseRole_Gameplay_Poker_C npcAnimInst = this.GetNpcAnimInst(this.EntityId);
		if (npcAnimInst == null)
		{
			return false;
		}
		if (state == EPokerStateType.BeChosenCardStrong || state == EPokerStateType.BeChosenCardWeak)
		{
			int beChooseEmotionIndex = new Random().Next(2);
			npcAnimInst.SetBeChooseEmotionIndex(beChooseEmotionIndex);
		}
		npcAnimInst.SetPokerState(state);
		return true;
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x00162C14 File Offset: 0x00160E14
	public void SetNpcEnterInteractiveStage(bool isInteractive)
	{
		ABP_BaseRole_Gameplay_Poker_C npcAnimInst = this.GetNpcAnimInst(this.EntityId);
		if (npcAnimInst == null)
		{
			return;
		}
		npcAnimInst.SetPlayerInteractiveStage(isInteractive);
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x00162C3C File Offset: 0x00160E3C
	public void UpdateNpcIdleState()
	{
		List<GuessJokerCardData> handCardsByPlayer = this.GetHandCardsByPlayer(EGuessJokerPlayerType.Ai);
		List<GuessJokerCardData> handCardsByPlayer2 = this.GetHandCardsByPlayer(EGuessJokerPlayerType.Me);
		int count = handCardsByPlayer.Count;
		int count2 = handCardsByPlayer2.Count;
		bool flag = false;
		using (List<GuessJokerCardData>.Enumerator enumerator = handCardsByPlayer.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Type == EGuessJokerCardType.Joker)
				{
					flag = true;
					break;
				}
			}
		}
		EPokerIdleState npcIdleState;
		if (count2 > 4)
		{
			npcIdleState = EPokerIdleState.Normal;
		}
		else if (count2 < 4 && flag)
		{
			npcIdleState = EPokerIdleState.Disadvantage;
		}
		else if (count < 4 && flag)
		{
			npcIdleState = EPokerIdleState.Advantage;
		}
		else
		{
			npcIdleState = EPokerIdleState.Normal;
		}
		this.SetNpcIdleState(npcIdleState);
	}

	// Token: 0x06003F33 RID: 16179 RVA: 0x00162CE0 File Offset: 0x00160EE0
	public bool SetNpcIdleState(EPokerIdleState state)
	{
		ABP_BaseRole_Gameplay_Poker_C npcAnimInst = this.GetNpcAnimInst(this.EntityId);
		if (npcAnimInst == null)
		{
			return false;
		}
		npcAnimInst.SetPokerIdleState(state);
		return true;
	}

	// Token: 0x06003F34 RID: 16180 RVA: 0x00162D08 File Offset: 0x00160F08
	public unsafe ABP_BaseRole_Gameplay_Poker_C GetNpcAnimInst(int entityId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
		if (entityByPbDataId == null || entityByPbDataId.Entity == null)
		{
			return null;
		}
		CharacterActorComponent component = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
		USkeletalMeshComponent uskeletalMeshComponent;
		if (component == null)
		{
			uskeletalMeshComponent = null;
		}
		else
		{
			TsBaseCharacter actor = component.Actor;
			uskeletalMeshComponent = ((actor != null) ? actor.Mesh : null);
		}
		USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
		if (uskeletalMeshComponent2 == null)
		{
			return null;
		}
		ABP_BaseRole_Gameplay_Poker_C abp_BaseRole_Gameplay_Poker_C = uskeletalMeshComponent2.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY) as ABP_BaseRole_Gameplay_Poker_C;
		if (abp_BaseRole_Gameplay_Poker_C == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJoker获取NPC动画实例失败：动画实例不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimInstance", (abp_BaseRole_Gameplay_Poker_C != null) ? "存在" : "不存在");
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return abp_BaseRole_Gameplay_Poker_C;
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x00162DDC File Offset: 0x00160FDC
	public List<int> GetLevelIdList()
	{
		IEnumerable<GuessJokerLevel> jokerLevelList = GuessJokerConfig.Instance.GetJokerLevelList();
		List<int> list = new List<int>();
		foreach (GuessJokerLevel guessJokerLevel in jokerLevelList)
		{
			list.Add(guessJokerLevel.Id);
		}
		if (list.Count == 0)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker获取关卡ID列表失败：关卡配置表为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<int>();
		}
		return list;
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x00162E68 File Offset: 0x00161068
	public void SetActiveDialogLogic(GuessJokerDialogLogic logic)
	{
		this.ActiveDialogLogic = logic;
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x00162E71 File Offset: 0x00161071
	public GuessJokerDialogLogic GetActiveDialogLogic()
	{
		return this.ActiveDialogLogic;
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x00162E79 File Offset: 0x00161079
	public void SetPlayerDrawnCard(int cardId)
	{
		this.PlayerDrawnCardId = new int?(cardId);
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x00162E87 File Offset: 0x00161087
	public void SetAiDrawnCard(int cardId)
	{
		this.AiDrawnCardId = new int?(cardId);
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x00162E98 File Offset: 0x00161098
	public bool HasPlayerNewCardInHand()
	{
		if (this.PlayerDrawnCardId == null)
		{
			return false;
		}
		GuessJokerCardData guessJokerCardData2;
		GuessJokerCardData guessJokerCardData = this.CardDataMap.TryGetValue(this.PlayerDrawnCardId.Value, out guessJokerCardData2) ? guessJokerCardData2 : null;
		if (guessJokerCardData != null)
		{
			EGuessJokerPlayerType? belongPlayerType = guessJokerCardData.GetBelongPlayerType();
			EGuessJokerPlayerType eguessJokerPlayerType = EGuessJokerPlayerType.Me;
			return belongPlayerType.GetValueOrDefault() == eguessJokerPlayerType & belongPlayerType != null;
		}
		return false;
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x00162EF4 File Offset: 0x001610F4
	public bool HasAiNewCardInHand()
	{
		if (this.AiDrawnCardId == null)
		{
			return false;
		}
		GuessJokerCardData guessJokerCardData2;
		GuessJokerCardData guessJokerCardData = this.CardDataMap.TryGetValue(this.AiDrawnCardId.Value, out guessJokerCardData2) ? guessJokerCardData2 : null;
		return guessJokerCardData != null && guessJokerCardData.GetBelongPlayerType().GetValueOrDefault() == EGuessJokerPlayerType.Ai;
	}

	// Token: 0x06003F3C RID: 16188 RVA: 0x00162F45 File Offset: 0x00161145
	public void ClearPlayerDrawnCard()
	{
		this.PlayerDrawnCardId = null;
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x00162F53 File Offset: 0x00161153
	public void ClearAiDrawnCard()
	{
		this.AiDrawnCardId = null;
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x00162F64 File Offset: 0x00161164
	public void EnableGuessJokerNpcSit(int pdDataId)
	{
		int num = 0;
		int num2 = 0;
		foreach (IGuessJokerNpcAndChairInfo guessJokerNpcAndChairInfo in GuessJokerConfig.Instance.GetNpcAndChairMatchInfo())
		{
			if (guessJokerNpcAndChairInfo.NpcId == pdDataId || guessJokerNpcAndChairInfo.ChairId == pdDataId)
			{
				num = guessJokerNpcAndChairInfo.ChairId;
				num2 = guessJokerNpcAndChairInfo.NpcId;
				break;
			}
		}
		if (num == 0 || num2 == 0)
		{
			return;
		}
		this.PendingNpcSitSet.Add(num2);
		if (this.NpcSitTimerHandle == null)
		{
			this.NpcSitTimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.NpcSitTick), 20f, 1f, null, null, true);
		}
	}

	// Token: 0x06003F3F RID: 16191 RVA: 0x00163020 File Offset: 0x00161220
	private void ProcessPendingNpcSit()
	{
		if (this.PendingNpcSitSet.Count == 0)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int num in this.PendingNpcSitSet)
		{
			List<IGuessJokerNpcAndChairInfo> npcAndChairMatchInfo = GuessJokerConfig.Instance.GetNpcAndChairMatchInfo();
			int num2 = 0;
			foreach (IGuessJokerNpcAndChairInfo guessJokerNpcAndChairInfo in npcAndChairMatchInfo)
			{
				if (guessJokerNpcAndChairInfo.NpcId == num)
				{
					num2 = guessJokerNpcAndChairInfo.ChairId;
					break;
				}
			}
			if (num2 == 0)
			{
				list.Add(num);
			}
			else if (this.CheckNpcIsReady(num) && this.CheckChairIsReady(num2))
			{
				this.GuessJokerDoSitDown(num, num2);
				list.Add(num);
			}
		}
		foreach (int item in list)
		{
			this.PendingNpcSitSet.Remove(item);
		}
		if (this.PendingNpcSitSet.Count == 0 && this.NpcSitTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.NpcSitTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.NpcSitTimerHandle);
			this.NpcSitTimerHandle = null;
		}
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x00163190 File Offset: 0x00161390
	private bool CheckNpcIsReady(int npcPbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcPbDataId);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		return worldEntity != null && ((worldEntity != null) ? worldEntity.GetComponent<NpcSitOnChairComponent>() : null) != null;
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x001631CC File Offset: 0x001613CC
	private bool CheckChairIsReady(int chairPbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(chairPbDataId);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		if (worldEntity == null)
		{
			return false;
		}
		PawnInteractNewComponent component = worldEntity.GetComponent<PawnInteractNewComponent>();
		if (component == null)
		{
			return false;
		}
		PawnChairController pawnChairController = component.GetSubEntityInteractLogicController() as PawnChairController;
		return pawnChairController != null && pawnChairController.IsSceneInteractionLoadCompleted();
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x0016321C File Offset: 0x0016141C
	public void GuessJokerDoSitDown(int npcPbDataId, int chairPbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcPbDataId);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		if (worldEntity == null)
		{
			return;
		}
		NpcSitOnChairComponent npcSitOnChairComponent = (worldEntity != null) ? worldEntity.GetComponent<NpcSitOnChairComponent>() : null;
		EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(chairPbDataId);
		WorldEntity worldEntity2 = (entityByPbDataId2 != null) ? entityByPbDataId2.Entity : null;
		if (npcSitOnChairComponent != null && worldEntity2 != null)
		{
			PawnInteractNewComponent component = worldEntity2.GetComponent<PawnInteractNewComponent>();
			PawnChairController pawnChairController = ((component != null) ? component.GetSubEntityInteractLogicController() : null) as PawnChairController;
			if (pawnChairController == null || !pawnChairController.IsSceneInteractionLoadCompleted())
			{
				return;
			}
			if (pawnChairController != null)
			{
				pawnChairController.Possess(worldEntity, false);
			}
			if (pawnChairController != null)
			{
				pawnChairController.IgnoreCollision();
			}
			npcSitOnChairComponent.DoSitDownAction(worldEntity2);
			CharacterAnimationComponent component2 = worldEntity.GetComponent<CharacterAnimationComponent>();
			ABP_BaseRoleNPC_C abp_BaseRoleNPC_C = ((component2 != null) ? component2.MainAnimInstance : null) as ABP_BaseRoleNPC_C;
			if (((abp_BaseRoleNPC_C != null) ? abp_BaseRoleNPC_C.LogicParams : null) != null)
			{
				abp_BaseRoleNPC_C.LogicParams.SitDownType = 1;
				abp_BaseRoleNPC_C.LogicParams.bSitDown = true;
			}
			this.EnterNpcPokerState(npcPbDataId);
		}
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x00163304 File Offset: 0x00161504
	public List<int> GetAllGuessJokerNpcIds()
	{
		IEnumerable<GuessJokerLevel> jokerLevelList = GuessJokerConfig.Instance.GetJokerLevelList();
		List<int> list = new List<int>();
		foreach (GuessJokerLevel guessJokerLevel in jokerLevelList)
		{
			GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(guessJokerLevel.AiRole);
			if (jokerAiConfigByRoleId != null)
			{
				list.Add(jokerAiConfigByRoleId.Value.NpcId);
			}
		}
		return list;
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x00163388 File Offset: 0x00161588
	public bool CheckIsGuessJokerEntityId(int entityId)
	{
		bool result = false;
		foreach (IGuessJokerNpcAndChairInfo guessJokerNpcAndChairInfo in GuessJokerConfig.Instance.GetNpcAndChairMatchInfo())
		{
			if (guessJokerNpcAndChairInfo.NpcId == entityId || guessJokerNpcAndChairInfo.ChairId == entityId)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x06003F45 RID: 16197 RVA: 0x001633F4 File Offset: 0x001615F4
	public void HideAllGuessJokerNpc()
	{
		foreach (int npcId in this.GetAllGuessJokerNpcIds())
		{
			this.HideGuessJokerNpc(npcId);
		}
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x00163448 File Offset: 0x00161648
	public void ShowAllGuessJokerNpc()
	{
		foreach (int npcId in this.GetAllGuessJokerNpcIds())
		{
			this.ShowGuessJokerNpc(npcId);
		}
	}

	// Token: 0x06003F47 RID: 16199 RVA: 0x0016349C File Offset: 0x0016169C
	public void ShowOnlyGuessJokerNpc(int npcId)
	{
		foreach (int num in this.GetAllGuessJokerNpcIds())
		{
			if (num == npcId)
			{
				this.ShowGuessJokerNpc(num);
			}
			else
			{
				this.HideGuessJokerNpc(num);
			}
		}
	}

	// Token: 0x06003F48 RID: 16200 RVA: 0x001634FC File Offset: 0x001616FC
	public void HideGuessJokerNpc(int npcId)
	{
		if (this.HiddenGuessJokerNpcSet.Contains(npcId))
		{
			return;
		}
		if (!this.GetAllGuessJokerNpcIds().Contains(npcId))
		{
			return;
		}
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcId);
		if (entityByPbDataId == null || !entityByPbDataId.Valid || entityByPbDataId.Entity == null)
		{
			return;
		}
		CreatureController.Instance.SetEntityEnable(entityByPbDataId.Entity, false, "[GuessJoker] 隐藏猜鬼牌NPC", false);
		this.HiddenGuessJokerNpcSet.Add(npcId);
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x00163574 File Offset: 0x00161774
	private void ShowGuessJokerNpc(int npcId)
	{
		if (!this.HiddenGuessJokerNpcSet.Contains(npcId))
		{
			return;
		}
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcId);
		if (entityByPbDataId == null || !entityByPbDataId.Valid || entityByPbDataId.Entity == null)
		{
			this.HiddenGuessJokerNpcSet.Remove(npcId);
			return;
		}
		CreatureController.Instance.SetEntityEnable(entityByPbDataId.Entity, true, "[GuessJoker] 显示猜鬼牌NPC", false);
		this.HiddenGuessJokerNpcSet.Remove(npcId);
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x001635E7 File Offset: 0x001617E7
	public void ClearHideJokerNpcRecord(int npcId)
	{
		this.HiddenGuessJokerNpcSet.Remove(npcId);
	}

	// Token: 0x06003F4B RID: 16203 RVA: 0x001635F8 File Offset: 0x001617F8
	public UniTask OpenSelectRoleView(int levelId = 0)
	{
		GuessJokerGamePlayModel.<OpenSelectRoleView>d__111 <OpenSelectRoleView>d__;
		<OpenSelectRoleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSelectRoleView>d__.<>4__this = this;
		<OpenSelectRoleView>d__.levelId = levelId;
		<OpenSelectRoleView>d__.<>1__state = -1;
		<OpenSelectRoleView>d__.<>t__builder.Start<GuessJokerGamePlayModel.<OpenSelectRoleView>d__111>(ref <OpenSelectRoleView>d__);
		return <OpenSelectRoleView>d__.<>t__builder.Task;
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x00163644 File Offset: 0x00161844
	public bool CheckRedDot()
	{
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		if (activityData == null)
		{
			return false;
		}
		if (!activityData.IsFunctionUnlocked(ESpringFunctionType.Card))
		{
			return false;
		}
		int num = 0;
		bool flag = false;
		foreach (GuessJokerLevel guessJokerLevel in GuessJokerConfig.Instance.GetJokerLevelList())
		{
			IGuessJokerLevelInfo guessJokerGameData = activityData.GetGuessJokerGameData(guessJokerLevel.Id);
			if (guessJokerGameData != null)
			{
				if (guessJokerGameData.FirstPass && !guessJokerGameData.RewardGet)
				{
					flag = true;
					break;
				}
				if (guessJokerGameData.Unlock && !guessJokerGameData.FirstPass)
				{
					num = guessJokerLevel.Id;
					break;
				}
			}
		}
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerUnlockLevelClicked, null) ?? new HashSet<int>();
		return flag || (num != 0 && !hashSet.Contains(num));
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x00163724 File Offset: 0x00161924
	public EGuessJokerSkillEffectPlayStrategy GetSkillEffectPlayStrategy(int skillId)
	{
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(skillId);
		if (jokerSkill == null)
		{
			return EGuessJokerSkillEffectPlayStrategy.Always;
		}
		if (jokerSkill.Value.EffectPlayStrategy != 1)
		{
			return EGuessJokerSkillEffectPlayStrategy.Always;
		}
		return EGuessJokerSkillEffectPlayStrategy.NotOnce;
	}

	// Token: 0x06003F4E RID: 16206 RVA: 0x00163760 File Offset: 0x00161960
	public bool ShouldPlaySkillEffect(int skillId)
	{
		EGuessJokerSkillEffectPlayStrategy skillEffectPlayStrategy = this.GetSkillEffectPlayStrategy(skillId);
		return skillEffectPlayStrategy == EGuessJokerSkillEffectPlayStrategy.Always || skillEffectPlayStrategy != EGuessJokerSkillEffectPlayStrategy.NotOnce;
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x00163784 File Offset: 0x00161984
	public bool ShowPlayGiveUpSkillTip(int skillId)
	{
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(skillId);
		return jokerSkill != null && jokerSkill.Value.ShowGiveUpTip;
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x001637B8 File Offset: 0x001619B8
	public void GuessJokerExitSaveReport()
	{
		if (!this.InGamePlay)
		{
			return;
		}
		GuessJokerExitSaveReport guessJokerExitSaveReport = new GuessJokerExitSaveReport();
		guessJokerExitSaveReport.i_level_id = this.LevelId;
		guessJokerExitSaveReport.s_trace_id = this.S_Track_Id;
		guessJokerExitSaveReport.i_turn_id = this.RoundNumber;
		GuessJokerRoleData roleData = this.GetRoleData(EGuessJokerPlayerType.Me);
		int i_role_hp = (roleData != null) ? roleData.GetHp() : 0;
		GuessJokerRoleData roleData2 = this.GetRoleData(EGuessJokerPlayerType.Ai);
		int i_enemy_hp = (roleData2 != null) ? roleData2.GetHp() : 0;
		guessJokerExitSaveReport.i_role_hp = i_role_hp;
		guessJokerExitSaveReport.i_enemy_hp = i_enemy_hp;
		LogReportController.Instance.LogReport(guessJokerExitSaveReport);
	}

	// Token: 0x170008E3 RID: 2275
	// (get) Token: 0x06003F51 RID: 16209 RVA: 0x00163839 File Offset: 0x00161A39
	public static GuessJokerGamePlayModel Instance
	{
		get
		{
			return GuessJokerGamePlayModel._Instance;
		}
	}

	// Token: 0x06003F52 RID: 16210 RVA: 0x00163840 File Offset: 0x00161A40
	public static GuessJokerGamePlayModel GetOrCreateInstance()
	{
		if (GuessJokerGamePlayModel._Instance == null)
		{
			GuessJokerGamePlayModel.CreateInstance();
		}
		return GuessJokerGamePlayModel._Instance;
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x00163854 File Offset: 0x00161A54
	public static bool CreateInstance()
	{
		if (GuessJokerGamePlayModel._Instance != null)
		{
			return true;
		}
		GuessJokerGamePlayModel._Instance = new GuessJokerGamePlayModel();
		return true;
	}

	// Token: 0x06003F54 RID: 16212 RVA: 0x0016386A File Offset: 0x00161A6A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003F55 RID: 16213 RVA: 0x0016386C File Offset: 0x00161A6C
	public static void ResetStaticDefaultValue()
	{
		GuessJokerGamePlayModel._Instance = null;
	}

	// Token: 0x06003F56 RID: 16214 RVA: 0x00163874 File Offset: 0x00161A74
	static GuessJokerGamePlayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerGamePlayModel.CreateStaticDefaultValue), new Action(GuessJokerGamePlayModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400325F RID: 12895
	private GuessJokerStageFsm GuessJokerFsm;

	// Token: 0x04003260 RID: 12896
	private bool InGamePlay;

	// Token: 0x04003261 RID: 12897
	public bool IsExit;

	// Token: 0x04003262 RID: 12898
	private GuessJokerGamePlayView GamePlayView;

	// Token: 0x04003263 RID: 12899
	[Nullable(2)]
	private TimerHandle GamePlayTimerHandle;

	// Token: 0x04003264 RID: 12900
	[Nullable(2)]
	private TimerHandle NpcSitTimerHandle;

	// Token: 0x04003265 RID: 12901
	private int LevelId = -1;

	// Token: 0x04003266 RID: 12902
	private string S_Track_Id = "";

	// Token: 0x04003267 RID: 12903
	private int RoleId = -1;

	// Token: 0x04003268 RID: 12904
	public bool IsFinish;

	// Token: 0x04003269 RID: 12905
	private GuessJokerRoleData AiRoleData;

	// Token: 0x0400326A RID: 12906
	private GuessJokerRoleData PlayerRoleData;

	// Token: 0x0400326B RID: 12907
	private readonly Dictionary<int, GuessJokerCardData> CardDataMap = new Dictionary<int, GuessJokerCardData>();

	// Token: 0x0400326C RID: 12908
	public int RoundNumber;

	// Token: 0x0400326D RID: 12909
	private readonly List<JokerGuessOp> TaskDataList = new List<JokerGuessOp>();

	// Token: 0x0400326E RID: 12910
	public EGuessJokerPlayerType FirstPlayerTurn = EGuessJokerPlayerType.Ai;

	// Token: 0x0400326F RID: 12911
	private EGuessJokerPlayerType Winner = EGuessJokerPlayerType.Ai;

	// Token: 0x04003270 RID: 12912
	private GuessJokerActionRunner<GuessJokerActionBase> ActionRunner;

	// Token: 0x04003271 RID: 12913
	private GuessJokerPlotActionRunner PlotActionRunner;

	// Token: 0x04003272 RID: 12914
	public bool ShowInitialNoPairTip = true;

	// Token: 0x04003273 RID: 12915
	private readonly Dictionary<int, int> LastUsedPlotIdMap = new Dictionary<int, int>();

	// Token: 0x04003274 RID: 12916
	private GuessJokerDialogLogic ActiveDialogLogic;

	// Token: 0x04003275 RID: 12917
	private int? PlayerDrawnCardId;

	// Token: 0x04003276 RID: 12918
	private int? AiDrawnCardId;

	// Token: 0x04003277 RID: 12919
	private readonly Dictionary<EGuessJokerPlayerType, bool> RoundStartTipShownMap = new Dictionary<EGuessJokerPlayerType, bool>();

	// Token: 0x04003278 RID: 12920
	private readonly HashSet<int> HiddenGuessJokerNpcSet = new HashSet<int>();

	// Token: 0x04003279 RID: 12921
	private readonly HashSet<int> PendingNpcSitSet = new HashSet<int>();

	// Token: 0x0400327A RID: 12922
	public bool IsShowAiCards;

	// Token: 0x0400327B RID: 12923
	[Nullable(2)]
	private static GuessJokerGamePlayModel _Instance;
}
