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
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200105F RID: 4191
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GuessJokerGamePlayModel : ModelBase
{
	// Token: 0x06006B65 RID: 27493 RVA: 0x00159230 File Offset: 0x00157430
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

	// Token: 0x06006B66 RID: 27494 RVA: 0x00159287 File Offset: 0x00157487
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.PlotSequenceEnd, new Action(this.OnPlotSequenceEnd));
		this.PendingNpcSitSet.Clear();
		return true;
	}

	// Token: 0x06006B67 RID: 27495 RVA: 0x001592B1 File Offset: 0x001574B1
	private void OnPlotSequenceEnd()
	{
		if (this.GetGamePlayView() == null)
		{
			return;
		}
		this.OpenGamePlayView(null);
	}

	// Token: 0x06006B68 RID: 27496 RVA: 0x001592C3 File Offset: 0x001574C3
	public void InitGame()
	{
		this.InGamePlay = true;
		this.CardDataMap.Clear();
		this.RoundStartTipShownMap.Clear();
	}

	// Token: 0x06006B69 RID: 27497 RVA: 0x001592E4 File Offset: 0x001574E4
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

	// Token: 0x06006B6A RID: 27498 RVA: 0x00159367 File Offset: 0x00157567
	public void NextRound()
	{
		this.RoundNumber++;
		this.RoundStartTipShownMap.Clear();
	}

	// Token: 0x06006B6B RID: 27499 RVA: 0x00159384 File Offset: 0x00157584
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

	// Token: 0x06006B6C RID: 27500 RVA: 0x001593DF File Offset: 0x001575DF
	public void ExitGame()
	{
		if (this.IsExit)
		{
			return;
		}
		this.IsExit = true;
		this.ChangeState(EGuessJokerCardStateType.GameExit);
	}

	// Token: 0x06006B6D RID: 27501 RVA: 0x001593F8 File Offset: 0x001575F8
	public void GameEnd()
	{
		this.SetNpcPokerState(EPokerStateType.Idel);
		UiCameraAnimationManager.Instance.EnablePlayerActor();
		this.ClearData();
	}

	// Token: 0x06006B6E RID: 27502 RVA: 0x00159412 File Offset: 0x00157612
	public void SettleGameClear()
	{
		this.InGamePlay = false;
	}

	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x06006B6F RID: 27503 RVA: 0x0015941B File Offset: 0x0015761B
	public bool InGame
	{
		get
		{
			return this.InGamePlay;
		}
	}

	// Token: 0x06006B70 RID: 27504 RVA: 0x00159424 File Offset: 0x00157624
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

	// Token: 0x06006B71 RID: 27505 RVA: 0x00159708 File Offset: 0x00157908
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

	// Token: 0x06006B72 RID: 27506 RVA: 0x0015976C File Offset: 0x0015796C
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

	// Token: 0x06006B73 RID: 27507 RVA: 0x001597F4 File Offset: 0x001579F4
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

	// Token: 0x06006B74 RID: 27508 RVA: 0x00159834 File Offset: 0x00157A34
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

	// Token: 0x06006B75 RID: 27509 RVA: 0x001598F9 File Offset: 0x00157AF9
	private void InitTimerSystem()
	{
		if (this.GamePlayTimerHandle != null)
		{
			this.ClearTimerHandle();
		}
		this.GamePlayTimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.GamePlayTick), 20f, 1f, null, null, true);
	}

	// Token: 0x06006B76 RID: 27510 RVA: 0x00159932 File Offset: 0x00157B32
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

	// Token: 0x06006B77 RID: 27511 RVA: 0x00159963 File Offset: 0x00157B63
	private void NpcSitTick(float deltaTime)
	{
		this.ProcessPendingNpcSit();
	}

	// Token: 0x06006B78 RID: 27512 RVA: 0x0015996C File Offset: 0x00157B6C
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

	// Token: 0x06006B79 RID: 27513 RVA: 0x001599DD File Offset: 0x00157BDD
	public void InitStateMachine()
	{
		this.GuessJokerFsm = new GuessJokerStageFsm();
		this.GuessJokerFsm.Init();
	}

	// Token: 0x06006B7A RID: 27514 RVA: 0x001599F5 File Offset: 0x00157BF5
	public void ChangeState(EGuessJokerCardStateType state)
	{
		this.GuessJokerFsm.ChangeState(state);
	}

	// Token: 0x06006B7B RID: 27515 RVA: 0x00159A04 File Offset: 0x00157C04
	public void OpenGamePlayView(Action finishCallback = null)
	{
		UiCameraAnimationManager.Instance.DisablePlayerActor();
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

	// Token: 0x06006B7C RID: 27516 RVA: 0x00159A58 File Offset: 0x00157C58
	public UniTask CloseGamePlayViewAsync()
	{
		GuessJokerGamePlayModel.<CloseGamePlayViewAsync>d__52 <CloseGamePlayViewAsync>d__;
		<CloseGamePlayViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseGamePlayViewAsync>d__.<>4__this = this;
		<CloseGamePlayViewAsync>d__.<>1__state = -1;
		<CloseGamePlayViewAsync>d__.<>t__builder.Start<GuessJokerGamePlayModel.<CloseGamePlayViewAsync>d__52>(ref <CloseGamePlayViewAsync>d__);
		return <CloseGamePlayViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006B7D RID: 27517 RVA: 0x00159A9C File Offset: 0x00157C9C
	public GuessJokerGamePlayView GetGamePlayView()
	{
		if (this.GamePlayView == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker获取游戏界面失败：游戏界面未打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.GamePlayView;
	}

	// Token: 0x06006B7E RID: 27518 RVA: 0x00159AD8 File Offset: 0x00157CD8
	public void PushActions(IReadOnlyList<GuessJokerActionBase> actions)
	{
		if (this.ActionRunner == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker PushActions Fail：ActionRunner is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ActionRunner.PushActions(actions);
	}

	// Token: 0x06006B7F RID: 27519 RVA: 0x00159B1C File Offset: 0x00157D1C
	public void PushPlotActions(GuessJokerPlotAction[] actions)
	{
		if (this.PlotActionRunner == null)
		{
			Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJoker PushPlotActions Fail：PlotActionRunner is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PlotActionRunner.PushPlotActions(actions);
	}

	// Token: 0x06006B80 RID: 27520 RVA: 0x00159B5D File Offset: 0x00157D5D
	public void SetWinner(JokerGuessActor winner)
	{
		this.Winner = GuessJokerUtils.ServerPlayerTransToClient(winner);
	}

	// Token: 0x06006B81 RID: 27521 RVA: 0x00159B6B File Offset: 0x00157D6B
	public EGuessJokerPlayerType GetWinner()
	{
		return this.Winner;
	}

	// Token: 0x06006B82 RID: 27522 RVA: 0x00159B73 File Offset: 0x00157D73
	public int GetLevelId()
	{
		return this.LevelId;
	}

	// Token: 0x06006B83 RID: 27523 RVA: 0x00159B7B File Offset: 0x00157D7B
	public void UpdateTaskData(IEnumerable<JokerGuessOp> taskList)
	{
		this.TaskDataList.Clear();
		this.TaskDataList.AddRange(taskList);
		EventSystem.Instance.Emit(EEventName.GuessJokerCardUpdateTaskData);
	}

	// Token: 0x06006B84 RID: 27524 RVA: 0x00159BA4 File Offset: 0x00157DA4
	public List<JokerGuessOp> GetTaskDataList()
	{
		List<JokerGuessOp> result = new List<JokerGuessOp>(this.TaskDataList);
		this.TaskDataList.Clear();
		return result;
	}

	// Token: 0x06006B85 RID: 27525 RVA: 0x00159BBC File Offset: 0x00157DBC
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

	// Token: 0x06006B86 RID: 27526 RVA: 0x00159C30 File Offset: 0x00157E30
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x06006B87 RID: 27527 RVA: 0x00159C38 File Offset: 0x00157E38
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

	// Token: 0x06006B88 RID: 27528 RVA: 0x00159C70 File Offset: 0x00157E70
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

	// Token: 0x06006B89 RID: 27529 RVA: 0x00159CE0 File Offset: 0x00157EE0
	public void UpdateHp(EGuessJokerPlayerType playerType, int value)
	{
		this.GetRoleData(playerType).SetHp(value);
	}

	// Token: 0x06006B8A RID: 27530 RVA: 0x00159CF0 File Offset: 0x00157EF0
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

	// Token: 0x06006B8B RID: 27531 RVA: 0x00159E78 File Offset: 0x00158078
	public List<GuessJokerCardData> GetAllCardDataList()
	{
		return new List<GuessJokerCardData>(this.CardDataMap.Values);
	}

	// Token: 0x06006B8C RID: 27532 RVA: 0x00159E8C File Offset: 0x0015808C
	public GuessJokerCardData GetCardDataById(int cardId)
	{
		GuessJokerCardData result;
		if (!this.CardDataMap.TryGetValue(cardId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06006B8D RID: 27533 RVA: 0x00159EAC File Offset: 0x001580AC
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

	// Token: 0x06006B8E RID: 27534 RVA: 0x00159F14 File Offset: 0x00158114
	public List<GuessJokerCardData> GetHandCardsByPlayer(EGuessJokerPlayerType playerType)
	{
		return this.QueryCards(delegate(GuessJokerCardData card)
		{
			EGuessJokerPlayerType? belongPlayerType = card.GetBelongPlayerType();
			EGuessJokerPlayerType playerType2 = playerType;
			return belongPlayerType.GetValueOrDefault() == playerType2 & belongPlayerType != null;
		});
	}

	// Token: 0x06006B8F RID: 27535 RVA: 0x00159F40 File Offset: 0x00158140
	public List<GuessJokerCardData> GetAllCardsByPlayer(EGuessJokerPlayerType playerType)
	{
		return this.QueryCards(delegate(GuessJokerCardData card)
		{
			EGuessJokerPlayerType? belongPlayerType = card.GetBelongPlayerType();
			EGuessJokerPlayerType playerType2 = playerType;
			return belongPlayerType.GetValueOrDefault() == playerType2 & belongPlayerType != null;
		});
	}

	// Token: 0x06006B90 RID: 27536 RVA: 0x00159F6C File Offset: 0x0015816C
	public void UpdateCardBelongPlayerType(int[] cardIdList, EGuessJokerPlayerType? playerType = null)
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

	// Token: 0x06006B91 RID: 27537 RVA: 0x0015A004 File Offset: 0x00158204
	public int GetLevelIdByNpcId(int npcId)
	{
		GuessJokerLevel? jokerLevelByNpcId = GuessJokerConfig.Instance.GetJokerLevelByNpcId(npcId);
		if (jokerLevelByNpcId == null)
		{
			return -1;
		}
		return jokerLevelByNpcId.GetValueOrDefault().Id;
	}

	// Token: 0x06006B92 RID: 27538 RVA: 0x0015A038 File Offset: 0x00158238
	public int? GetLastUsedPlotId(int aiPlotConfigId)
	{
		int value;
		if (!this.LastUsedPlotIdMap.TryGetValue(aiPlotConfigId, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x06006B93 RID: 27539 RVA: 0x0015A065 File Offset: 0x00158265
	public void SetLastUsedPlotId(int aiPlotConfigId, int plotId)
	{
		this.LastUsedPlotIdMap[aiPlotConfigId] = plotId;
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x0015A074 File Offset: 0x00158274
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

	// Token: 0x06006B95 RID: 27541 RVA: 0x0015A0D4 File Offset: 0x001582D4
	public int GetAiSkillId()
	{
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(this.LevelId);
		if (jokerLevelById == null)
		{
			return -1;
		}
		return jokerLevelById.GetValueOrDefault().AiCardSkill;
	}

	// Token: 0x06006B96 RID: 27542 RVA: 0x0015A10C File Offset: 0x0015830C
	public void MarkRoundStartTipShown(EGuessJokerPlayerType playerType)
	{
		this.RoundStartTipShownMap[playerType] = true;
	}

	// Token: 0x06006B97 RID: 27543 RVA: 0x0015A11C File Offset: 0x0015831C
	public bool HasShownRoundStartTip(EGuessJokerPlayerType playerType)
	{
		bool flag;
		return this.RoundStartTipShownMap.TryGetValue(playerType, out flag) && flag;
	}

	// Token: 0x06006B98 RID: 27544 RVA: 0x0015A13C File Offset: 0x0015833C
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

	// Token: 0x06006B99 RID: 27545 RVA: 0x0015A188 File Offset: 0x00158388
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

	// Token: 0x06006B9A RID: 27546 RVA: 0x0015A1E4 File Offset: 0x001583E4
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

	// Token: 0x06006B9B RID: 27547 RVA: 0x0015A288 File Offset: 0x00158488
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

	// Token: 0x06006B9C RID: 27548 RVA: 0x0015A2CC File Offset: 0x001584CC
	public void SetNpcEnterInteractiveStage(bool isInteractive)
	{
		ABP_BaseRole_Gameplay_Poker_C npcAnimInst = this.GetNpcAnimInst(this.EntityId);
		if (npcAnimInst == null)
		{
			return;
		}
		npcAnimInst.SetPlayerInteractiveStage(isInteractive);
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x0015A2F4 File Offset: 0x001584F4
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

	// Token: 0x06006B9E RID: 27550 RVA: 0x0015A398 File Offset: 0x00158598
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

	// Token: 0x06006B9F RID: 27551 RVA: 0x0015A3C0 File Offset: 0x001585C0
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

	// Token: 0x06006BA0 RID: 27552 RVA: 0x0015A494 File Offset: 0x00158694
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

	// Token: 0x06006BA1 RID: 27553 RVA: 0x0015A520 File Offset: 0x00158720
	public void SetActiveDialogLogic(GuessJokerDialogLogic logic)
	{
		this.ActiveDialogLogic = logic;
	}

	// Token: 0x06006BA2 RID: 27554 RVA: 0x0015A529 File Offset: 0x00158729
	public GuessJokerDialogLogic GetActiveDialogLogic()
	{
		return this.ActiveDialogLogic;
	}

	// Token: 0x06006BA3 RID: 27555 RVA: 0x0015A531 File Offset: 0x00158731
	public void SetPlayerDrawnCard(int cardId)
	{
		this.PlayerDrawnCardId = new int?(cardId);
	}

	// Token: 0x06006BA4 RID: 27556 RVA: 0x0015A53F File Offset: 0x0015873F
	public void SetAiDrawnCard(int cardId)
	{
		this.AiDrawnCardId = new int?(cardId);
	}

	// Token: 0x06006BA5 RID: 27557 RVA: 0x0015A550 File Offset: 0x00158750
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

	// Token: 0x06006BA6 RID: 27558 RVA: 0x0015A5AC File Offset: 0x001587AC
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

	// Token: 0x06006BA7 RID: 27559 RVA: 0x0015A5FD File Offset: 0x001587FD
	public void ClearPlayerDrawnCard()
	{
		this.PlayerDrawnCardId = null;
	}

	// Token: 0x06006BA8 RID: 27560 RVA: 0x0015A60B File Offset: 0x0015880B
	public void ClearAiDrawnCard()
	{
		this.AiDrawnCardId = null;
	}

	// Token: 0x06006BA9 RID: 27561 RVA: 0x0015A61C File Offset: 0x0015881C
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

	// Token: 0x06006BAA RID: 27562 RVA: 0x0015A6D8 File Offset: 0x001588D8
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

	// Token: 0x06006BAB RID: 27563 RVA: 0x0015A848 File Offset: 0x00158A48
	private bool CheckNpcIsReady(int npcPbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcPbDataId);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		return worldEntity != null && ((worldEntity != null) ? worldEntity.GetComponent<NpcSitOnChairComponent>() : null) != null;
	}

	// Token: 0x06006BAC RID: 27564 RVA: 0x0015A884 File Offset: 0x00158A84
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

	// Token: 0x06006BAD RID: 27565 RVA: 0x0015A8D4 File Offset: 0x00158AD4
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

	// Token: 0x06006BAE RID: 27566 RVA: 0x0015A9BC File Offset: 0x00158BBC
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

	// Token: 0x06006BAF RID: 27567 RVA: 0x0015AA40 File Offset: 0x00158C40
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

	// Token: 0x06006BB0 RID: 27568 RVA: 0x0015AAAC File Offset: 0x00158CAC
	public void HideAllGuessJokerNpc()
	{
		foreach (int npcId in this.GetAllGuessJokerNpcIds())
		{
			this.HideGuessJokerNpc(npcId);
		}
	}

	// Token: 0x06006BB1 RID: 27569 RVA: 0x0015AB00 File Offset: 0x00158D00
	public void ShowAllGuessJokerNpc()
	{
		foreach (int npcId in this.GetAllGuessJokerNpcIds())
		{
			this.ShowGuessJokerNpc(npcId);
		}
	}

	// Token: 0x06006BB2 RID: 27570 RVA: 0x0015AB54 File Offset: 0x00158D54
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

	// Token: 0x06006BB3 RID: 27571 RVA: 0x0015ABB4 File Offset: 0x00158DB4
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

	// Token: 0x06006BB4 RID: 27572 RVA: 0x0015AC2C File Offset: 0x00158E2C
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

	// Token: 0x06006BB5 RID: 27573 RVA: 0x0015AC9F File Offset: 0x00158E9F
	public void ClearHideJokerNpcRecord(int npcId)
	{
		this.HiddenGuessJokerNpcSet.Remove(npcId);
	}

	// Token: 0x06006BB6 RID: 27574 RVA: 0x0015ACB0 File Offset: 0x00158EB0
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

	// Token: 0x06006BB7 RID: 27575 RVA: 0x0015ACFC File Offset: 0x00158EFC
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

	// Token: 0x06006BB8 RID: 27576 RVA: 0x0015ADDC File Offset: 0x00158FDC
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

	// Token: 0x06006BB9 RID: 27577 RVA: 0x0015AE18 File Offset: 0x00159018
	public bool ShouldPlaySkillEffect(int skillId)
	{
		EGuessJokerSkillEffectPlayStrategy skillEffectPlayStrategy = this.GetSkillEffectPlayStrategy(skillId);
		return skillEffectPlayStrategy == EGuessJokerSkillEffectPlayStrategy.Always || skillEffectPlayStrategy != EGuessJokerSkillEffectPlayStrategy.NotOnce;
	}

	// Token: 0x06006BBA RID: 27578 RVA: 0x0015AE3C File Offset: 0x0015903C
	public bool ShowPlayGiveUpSkillTip(int skillId)
	{
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(skillId);
		return jokerSkill != null && jokerSkill.Value.ShowGiveUpTip;
	}

	// Token: 0x06006BBB RID: 27579 RVA: 0x0015AE70 File Offset: 0x00159070
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

	// Token: 0x170008C3 RID: 2243
	// (get) Token: 0x06006BBC RID: 27580 RVA: 0x0015AEF1 File Offset: 0x001590F1
	public static GuessJokerGamePlayModel Instance
	{
		get
		{
			return GuessJokerGamePlayModel._Instance;
		}
	}

	// Token: 0x06006BBD RID: 27581 RVA: 0x0015AEF8 File Offset: 0x001590F8
	public static GuessJokerGamePlayModel GetOrCreateInstance()
	{
		if (GuessJokerGamePlayModel._Instance == null)
		{
			GuessJokerGamePlayModel.CreateInstance();
		}
		return GuessJokerGamePlayModel._Instance;
	}

	// Token: 0x06006BBE RID: 27582 RVA: 0x0015AF0C File Offset: 0x0015910C
	public static bool CreateInstance()
	{
		if (GuessJokerGamePlayModel._Instance != null)
		{
			return true;
		}
		GuessJokerGamePlayModel._Instance = new GuessJokerGamePlayModel();
		return true;
	}

	// Token: 0x06006BBF RID: 27583 RVA: 0x0015AF22 File Offset: 0x00159122
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006BC0 RID: 27584 RVA: 0x0015AF24 File Offset: 0x00159124
	public static void ResetStaticDefaultValue()
	{
		GuessJokerGamePlayModel._Instance = null;
	}

	// Token: 0x06006BC1 RID: 27585 RVA: 0x0015AF2C File Offset: 0x0015912C
	static GuessJokerGamePlayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerGamePlayModel.CreateStaticDefaultValue), new Action(GuessJokerGamePlayModel.ResetStaticDefaultValue));
	}

	// Token: 0x040031C6 RID: 12742
	private GuessJokerStageFsm GuessJokerFsm;

	// Token: 0x040031C7 RID: 12743
	private bool InGamePlay;

	// Token: 0x040031C8 RID: 12744
	public bool IsExit;

	// Token: 0x040031C9 RID: 12745
	private GuessJokerGamePlayView GamePlayView;

	// Token: 0x040031CA RID: 12746
	[Nullable(2)]
	private TimerHandle GamePlayTimerHandle;

	// Token: 0x040031CB RID: 12747
	[Nullable(2)]
	private TimerHandle NpcSitTimerHandle;

	// Token: 0x040031CC RID: 12748
	private int LevelId = -1;

	// Token: 0x040031CD RID: 12749
	private string S_Track_Id = "";

	// Token: 0x040031CE RID: 12750
	private int RoleId = -1;

	// Token: 0x040031CF RID: 12751
	public bool IsFinish;

	// Token: 0x040031D0 RID: 12752
	private GuessJokerRoleData AiRoleData;

	// Token: 0x040031D1 RID: 12753
	private GuessJokerRoleData PlayerRoleData;

	// Token: 0x040031D2 RID: 12754
	private readonly Dictionary<int, GuessJokerCardData> CardDataMap = new Dictionary<int, GuessJokerCardData>();

	// Token: 0x040031D3 RID: 12755
	public int RoundNumber;

	// Token: 0x040031D4 RID: 12756
	private readonly List<JokerGuessOp> TaskDataList = new List<JokerGuessOp>();

	// Token: 0x040031D5 RID: 12757
	public EGuessJokerPlayerType FirstPlayerTurn = EGuessJokerPlayerType.Ai;

	// Token: 0x040031D6 RID: 12758
	private EGuessJokerPlayerType Winner = EGuessJokerPlayerType.Ai;

	// Token: 0x040031D7 RID: 12759
	private GuessJokerActionRunner<GuessJokerActionBase> ActionRunner;

	// Token: 0x040031D8 RID: 12760
	private GuessJokerPlotActionRunner PlotActionRunner;

	// Token: 0x040031D9 RID: 12761
	public bool ShowInitialNoPairTip = true;

	// Token: 0x040031DA RID: 12762
	private readonly Dictionary<int, int> LastUsedPlotIdMap = new Dictionary<int, int>();

	// Token: 0x040031DB RID: 12763
	private GuessJokerDialogLogic ActiveDialogLogic;

	// Token: 0x040031DC RID: 12764
	private int? PlayerDrawnCardId;

	// Token: 0x040031DD RID: 12765
	private int? AiDrawnCardId;

	// Token: 0x040031DE RID: 12766
	private readonly Dictionary<EGuessJokerPlayerType, bool> RoundStartTipShownMap = new Dictionary<EGuessJokerPlayerType, bool>();

	// Token: 0x040031DF RID: 12767
	private readonly HashSet<int> HiddenGuessJokerNpcSet = new HashSet<int>();

	// Token: 0x040031E0 RID: 12768
	private readonly HashSet<int> PendingNpcSitSet = new HashSet<int>();

	// Token: 0x040031E1 RID: 12769
	public bool IsShowAiCards;

	// Token: 0x040031E2 RID: 12770
	[Nullable(2)]
	private static GuessJokerGamePlayModel _Instance;
}
