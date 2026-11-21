using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Ui;

// Token: 0x02000FFE RID: 4094
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FloroRanchGamePlayModel : ModelBase
{
	// Token: 0x0600A2DA RID: 41690 RVA: 0x002FC7DE File Offset: 0x002FA9DE
	public void SetCurrentActivityData(global::FloroRanchActivityData data)
	{
		this.CurrentActivityData = data;
	}

	// Token: 0x0600A2DB RID: 41691 RVA: 0x002FC7E8 File Offset: 0x002FA9E8
	[NullableContext(2)]
	public global::FloroRanchActivityData GetCurrentActivityData()
	{
		if (this.CurrentActivityData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "FloroRanch获取当前活动数据失败：当前活动数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return this.CurrentActivityData;
	}

	// Token: 0x1700116C RID: 4460
	// (get) Token: 0x0600A2DC RID: 41692 RVA: 0x002FC822 File Offset: 0x002FAA22
	public bool IsInGamePlay
	{
		get
		{
			return this.InGamePlay;
		}
	}

	// Token: 0x0600A2DD RID: 41693 RVA: 0x002FC82A File Offset: 0x002FAA2A
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		return true;
	}

	// Token: 0x0600A2DE RID: 41694 RVA: 0x002FC846 File Offset: 0x002FAA46
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		return true;
	}

	// Token: 0x0600A2DF RID: 41695 RVA: 0x002FC862 File Offset: 0x002FAA62
	public void InitGame(int activityId, List<int> races, int skillId, bool isOver)
	{
		this.ActivityId = activityId;
		this.Races = races;
		this.SkillId = skillId;
		this.IsOver = isOver;
	}

	// Token: 0x0600A2E0 RID: 41696 RVA: 0x002FC884 File Offset: 0x002FAA84
	public void EnterGame(FloroRanchStartPlayResponse gameData)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
			return;
		}
		if (this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch进入游戏失败：游戏已经开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.InitData(gameData.PlayInfo);
		this.RefreshDailyTaskData(new List<FloroRanchPlayTask>(gameData.Task));
		this.InitTimerSystem();
		this.InitStateMachine();
		this.ChangeState(EFloroRanchStageStateType.GameStart);
	}

	// Token: 0x0600A2E1 RID: 41697 RVA: 0x002FC90A File Offset: 0x002FAB0A
	public void InitStateMachine()
	{
		this.FloroRanchFsm = new FloroRanchStageFsm();
		this.FloroRanchFsm.Init();
	}

	// Token: 0x0600A2E2 RID: 41698 RVA: 0x002FC924 File Offset: 0x002FAB24
	public bool CanFsmInsertSkillTask()
	{
		if (this.FloroRanchFsm.GetCurrentStateType() != EFloroRanchStageStateType.DailyInStage)
		{
			return false;
		}
		FloroRanchStateBase currentState = this.FloroRanchFsm.GetCurrentState();
		return currentState != null && currentState is FloroRanchDailyInStageState && !((FloroRanchDailyInStageState)currentState).IsExecutingTask();
	}

	// Token: 0x0600A2E3 RID: 41699 RVA: 0x002FC968 File Offset: 0x002FAB68
	public void ChangeState(EFloroRanchStageStateType state)
	{
		this.FloroRanchFsm.ChangeState(state);
	}

	// Token: 0x0600A2E4 RID: 41700 RVA: 0x002FC978 File Offset: 0x002FAB78
	public void PauseGame()
	{
		if (!this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch暂停游戏失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.IsPause)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch暂停游戏失败：游戏已经暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsPause = true;
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.GetShowCardEntityList())
		{
			floroRanchEntityBase.GetUiItemComponent().Pause();
		}
		FloroRanchEntityBase roleEntity = this.RoleEntity;
		if (roleEntity != null)
		{
			roleEntity.GetUiItemComponent().Pause();
		}
		FloroRanchEntityActionSystem.Pause();
	}

	// Token: 0x0600A2E5 RID: 41701 RVA: 0x002FCA40 File Offset: 0x002FAC40
	public void ResumeGame()
	{
		if (!this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch恢复游戏失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!this.IsPause)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch恢复游戏失败：游戏未暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsPause = false;
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.GetShowCardEntityList())
		{
			floroRanchEntityBase.GetUiItemComponent().Resume();
		}
		FloroRanchEntityBase roleEntity = this.RoleEntity;
		if (roleEntity != null)
		{
			roleEntity.GetUiItemComponent().Resume();
		}
		FloroRanchEntityActionSystem.Resume();
	}

	// Token: 0x0600A2E6 RID: 41702 RVA: 0x002FCB08 File Offset: 0x002FAD08
	public void ExitGame(bool needSettle)
	{
		if (!this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch退出游戏失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.NeedSettle = needSettle;
		if (!needSettle)
		{
			global::FloroRanchActivityData currentActivityData = this.CurrentActivityData;
			if (currentActivityData != null)
			{
				currentActivityData.SetSavedStage(this.CurStage);
			}
		}
		this.IsExit = true;
		this.ChangeState(EFloroRanchStageStateType.GameExit);
	}

	// Token: 0x0600A2E7 RID: 41703 RVA: 0x002FCB6C File Offset: 0x002FAD6C
	public void ReStartGame()
	{
		if (!this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch退出游戏失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.NeedReStart = true;
		this.IsExit = true;
		this.ChangeState(EFloroRanchStageStateType.GameExit);
	}

	// Token: 0x0600A2E8 RID: 41704 RVA: 0x002FCBB8 File Offset: 0x002FADB8
	public void GameEnd()
	{
		if (!this.InGamePlay)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "FloroRanch退出游戏失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ClearTimerSystem();
		this.ExitAllEntity();
		this.ClearData();
		this.CloseAllRecordView();
	}

	// Token: 0x0600A2E9 RID: 41705 RVA: 0x002FCC05 File Offset: 0x002FAE05
	public void InitData(FloroRanchPlayInfo gameData)
	{
		this.InGamePlay = true;
		this.RefreshBasicData(gameData);
		this.InitEntityData(gameData);
	}

	// Token: 0x0600A2EA RID: 41706 RVA: 0x002FCC1C File Offset: 0x002FAE1C
	public void RefreshBasicData(FloroRanchPlayInfo gameData)
	{
		this.SubInstanceId = gameData.SubInsId;
		this.CurStage = gameData.Stage;
		this.CoinData.SetTotal(gameData.TotalCoin);
		this.CoinData.SetAmount(gameData.CurCoin);
		this.DiamondData.SetTotal(gameData.TotalDiamond);
		this.DiamondData.SetAmount(gameData.CurDiamond);
		this.StageTarget = gameData.StageTributeCount;
		this.EnableToyCount = gameData.EnableToy;
		this.IsEndlessMode = gameData.IsUnLimited;
		this.StageDayCount = gameData.CurStageDayNum;
		this.TotalDayCount = gameData.TotalDay;
		this.RemindDay = gameData.RemainDay;
		this.ActionInfoList.Clear();
	}

	// Token: 0x0600A2EB RID: 41707 RVA: 0x002FCCD8 File Offset: 0x002FAED8
	public void InitEntityData(FloroRanchPlayInfo gameData)
	{
		this.EntityMap.Clear();
		this.TerrainEntityList.Clear();
		this.CardEntityList.Clear();
		this.ToyEntityList.Clear();
		this.AddEntityList(new List<FloroRanchPlayUnit>(gameData.Terrains));
		this.AddEntityList(new List<FloroRanchPlayUnit>(gameData.PhantomList));
		this.AddEntityList(new List<FloroRanchPlayUnit>(gameData.ToyList));
		if (gameData.Dungeon != null)
		{
			this.DungeonEntity = FloroRanchEntityCreateSystem.CreateFloroRanchEntity(gameData.Dungeon);
			this.EntityMap[this.DungeonEntity.EntityId] = this.DungeonEntity;
		}
		if (gameData.Role != null)
		{
			this.RoleEntity = FloroRanchEntityCreateSystem.CreateFloroRanchEntity(gameData.Role);
			this.EntityMap[this.RoleEntity.EntityId] = this.RoleEntity;
		}
	}

	// Token: 0x0600A2EC RID: 41708 RVA: 0x002FCDAE File Offset: 0x002FAFAE
	public void OnDayStart(FloroRanchDayStart data)
	{
		this.CurStage = data.CurStage;
		this.IsEndlessMode = data.IsUnlimited;
		this.TotalDayCount = data.TotalDay;
		this.RemindDay = data.RemainDay;
	}

	// Token: 0x0600A2ED RID: 41709 RVA: 0x002FCDE0 File Offset: 0x002FAFE0
	public void OnStageStart(FloroRanchStageStart data)
	{
		this.StageTarget = data.Target;
		this.StageDayCount = data.DayCount;
		EventSystem.Instance.Emit(EEventName.OnFloroRanchStageInfoRefresh);
	}

	// Token: 0x0600A2EE RID: 41710 RVA: 0x002FCE0C File Offset: 0x002FB00C
	public void AddEntityList(List<FloroRanchPlayUnit> entityDataList)
	{
		foreach (FloroRanchPlayUnit entityData in entityDataList)
		{
			this.AddEntity(entityData);
		}
	}

	// Token: 0x0600A2EF RID: 41711 RVA: 0x002FCE5C File Offset: 0x002FB05C
	[return: Nullable(2)]
	public FloroRanchEntityBase AddEntity(FloroRanchPlayUnit entityData)
	{
		if (this.EntityMap.ContainsKey(entityData.PlayIncId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanch实体Id重复";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityData.PlayIncId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		FloroRanchEntityBase floroRanchEntityBase = FloroRanchEntityCreateSystem.CreateFloroRanchEntity(entityData);
		this.EntityMap[floroRanchEntityBase.EntityId] = floroRanchEntityBase;
		this.AddEntityByType(floroRanchEntityBase.EntityType, floroRanchEntityBase);
		if (floroRanchEntityBase.EntityType == EFloroRanchEntityType.Card)
		{
			int ownCardEntityCount = this.OwnCardEntityCountInternal + 1;
			this.SetOwnCardEntityCount(ownCardEntityCount);
		}
		return floroRanchEntityBase;
	}

	// Token: 0x0600A2F0 RID: 41712 RVA: 0x002FCEF4 File Offset: 0x002FB0F4
	public void RefreshEntityList(IEnumerable<FloroRanchPlayUnit> entityDataList)
	{
		foreach (FloroRanchPlayUnit floroRanchPlayUnit in entityDataList)
		{
			this.GetEntity(floroRanchPlayUnit.PlayIncId).RefreshEntityData(floroRanchPlayUnit);
		}
	}

	// Token: 0x0600A2F1 RID: 41713 RVA: 0x002FCF48 File Offset: 0x002FB148
	public void RefreshRemoveEntityList(List<int> entityList)
	{
		foreach (int entityId in entityList)
		{
			this.GetEntity(entityId).CheckGetComponent<FloroRanchEntityDataComponent>().Remove();
		}
	}

	// Token: 0x0600A2F2 RID: 41714 RVA: 0x002FCFA0 File Offset: 0x002FB1A0
	public bool CheckEntityIsExist(int entityId)
	{
		return this.EntityMap.ContainsKey(entityId);
	}

	// Token: 0x0600A2F3 RID: 41715 RVA: 0x002FCFB0 File Offset: 0x002FB1B0
	[NullableContext(2)]
	public FloroRanchEntityBase GetEntity(int entityId)
	{
		if (entityId <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanch获取实体数据失败：实体Id错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (!this.EntityMap.ContainsKey(entityId))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.FloroRanchGamePlay;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "FloroRanch获取实体数据失败：实体不存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		FloroRanchEntityBase result;
		this.EntityMap.TryGetValue(entityId, out result);
		return result;
	}

	// Token: 0x0600A2F4 RID: 41716 RVA: 0x002FD040 File Offset: 0x002FB240
	public void RemoveOwnEntityData(FloroRanchEntityBase entity)
	{
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = entity.CheckGetComponent<FloroRanchEntityDataComponent>();
		if (!floroRanchEntityDataComponent.IsValid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanch移除实体数据失败：实体重复移除";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entity.EntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		floroRanchEntityDataComponent.Remove();
		if (this.RemoveEntityByType(entity.EntityType, entity) && entity.EntityType == EFloroRanchEntityType.Card)
		{
			int ownCardEntityCount = this.OwnCardEntityCountInternal - 1;
			this.SetOwnCardEntityCount(ownCardEntityCount);
		}
	}

	// Token: 0x0600A2F5 RID: 41717 RVA: 0x002FD0C0 File Offset: 0x002FB2C0
	public void ClearRemoveEntity()
	{
		foreach (int key in new List<int>(this.EntityMap.Keys))
		{
			FloroRanchEntityBase floroRanchEntityBase = this.EntityMap[key];
			if (!floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>().IsValid)
			{
				this.EntityMap.Remove(floroRanchEntityBase.EntityId);
			}
		}
	}

	// Token: 0x0600A2F6 RID: 41718 RVA: 0x002FD144 File Offset: 0x002FB344
	public void OnShopItemPurchased(FloroRanchPlayShopBuyResponse data)
	{
		this.OnCurrencyChange(data.CurCoin, data.CurDiamond);
		switch (data.Type)
		{
		case FloroRanchPlayShopBuyType.BuyCard:
			FloroRanchEntityActionSystem.AddEntity(data.Card.NewPhantom);
			return;
		case FloroRanchPlayShopBuyType.BuyGardGroup:
		{
			FloroRanchPlayShopBuyCardGroup cardGroup = data.CardGroup;
			this.OpenAndRecordView(EUiViewName.FloroRanchCardGroupSelectView, new List<int>(cardGroup.CardIds), null);
			return;
		}
		case FloroRanchPlayShopBuyType.BuyToy:
		{
			FloroRanchPlayUnit newToy = data.Toy.NewToy;
			if (this.CheckEntityIsExist(newToy.PlayIncId))
			{
				this.GetEntity(newToy.PlayIncId).RefreshEntityData(newToy);
				return;
			}
			FloroRanchEntityActionSystem.AddEntity(newToy);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x0600A2F7 RID: 41719 RVA: 0x002FD1E4 File Offset: 0x002FB3E4
	public void OnTributeResult(FloroRanchPlayTributeResponse data)
	{
		this.RemindDay = data.RemainDay;
		this.CurStage = data.CurStage;
		EventSystem.Instance.Emit(EEventName.OnFloroRanchStageInfoRefresh);
		long curCoin = data.CurCoin;
		long curDiamond = data.CurDiamond;
		this.OnCurrencyChange(curCoin, curDiamond);
	}

	// Token: 0x0600A2F8 RID: 41720 RVA: 0x002FD22F File Offset: 0x002FB42F
	public void OnCurrencyChange(long coinAmount, long diamondAmount)
	{
		this.CoinData.SetAmount(coinAmount);
		this.DiamondData.SetAmount(diamondAmount);
		this.GetGamePlayView().RefreshCurrencyInfo();
	}

	// Token: 0x0600A2F9 RID: 41721 RVA: 0x002FD254 File Offset: 0x002FB454
	[NullableContext(2)]
	public void OpenAndRecordView(EUiViewName viewName, object param = null, Action callback = null)
	{
		UiManager.Instance.OpenView(viewName, param, delegate(bool isSuccess, int viewId)
		{
			if (!isSuccess)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FloroRanchGamePlay;
				ELogAuthor author = ELogAuthor.BB;
				string message = "FloroRanch打开界面失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UiPanelBase gamePlayView = this.GetGamePlayView();
			UiViewBase view = UiManager.Instance.GetView(viewId);
			gamePlayView.AddChild(view);
			this.OpenViewStack.Add(viewId);
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		});
	}

	// Token: 0x0600A2FA RID: 41722 RVA: 0x002FD29C File Offset: 0x002FB49C
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		int count = this.OpenViewStack.Count;
		if (count > 0 && this.OpenViewStack[count - 1] == viewId)
		{
			this.OpenViewStack.RemoveAt(count - 1);
		}
	}

	// Token: 0x0600A2FB RID: 41723 RVA: 0x002FD2D8 File Offset: 0x002FB4D8
	public void ShowRecordView()
	{
		foreach (int viewId in this.OpenViewStack)
		{
			UiViewBase view = UiManager.Instance.GetView(viewId);
			if (view != null)
			{
				view.SetActive(true);
			}
		}
		this.GetGamePlayView().SetShowButtonActive(false);
	}

	// Token: 0x0600A2FC RID: 41724 RVA: 0x002FD348 File Offset: 0x002FB548
	public void HideRecordView()
	{
		foreach (int viewId in this.OpenViewStack)
		{
			UiViewBase view = UiManager.Instance.GetView(viewId);
			if (view != null)
			{
				view.SetActive(false);
			}
		}
		this.GetGamePlayView().SetShowButtonActive(true);
	}

	// Token: 0x0600A2FD RID: 41725 RVA: 0x002FD3B8 File Offset: 0x002FB5B8
	public void CloseAllRecordView()
	{
		foreach (int viewId in this.OpenViewStack)
		{
			UiManager.Instance.CloseViewById(viewId, null);
		}
		this.OpenViewStack.Clear();
	}

	// Token: 0x1700116D RID: 4461
	// (get) Token: 0x0600A2FE RID: 41726 RVA: 0x002FD41C File Offset: 0x002FB61C
	public int OwnCardEntityCount
	{
		get
		{
			return this.OwnCardEntityCountInternal;
		}
	}

	// Token: 0x0600A2FF RID: 41727 RVA: 0x002FD424 File Offset: 0x002FB624
	public void SetOwnCardEntityCount(int count)
	{
		this.OwnCardEntityCountInternal = count;
		EventSystem.Instance.Emit(EEventName.OnFloroRanchCardEntityCountChange);
	}

	// Token: 0x0600A300 RID: 41728 RVA: 0x002FD440 File Offset: 0x002FB640
	public void ExitAllEntity()
	{
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.EntityMap.Values)
		{
			FloroRanchUiItemBaseComponent uiItemComponent = floroRanchEntityBase.GetUiItemComponent();
			if (uiItemComponent != null)
			{
				uiItemComponent.Exit();
			}
		}
	}

	// Token: 0x0600A301 RID: 41729 RVA: 0x002FD4A0 File Offset: 0x002FB6A0
	public void ClearData()
	{
		this.InGamePlay = false;
		this.ActivityId = 0;
		this.SubInstanceId = 0;
		this.Races.Clear();
		this.SkillId = 0;
		this.CurStage = 0;
		this.RemindDay = 0;
		this.TerrainEntityList.Clear();
		this.CardEntityList.Clear();
		this.ToyEntityList.Clear();
		this.DungeonEntity = null;
		this.RoleEntity = null;
		this.TaskList.Clear();
		this.FloroRanchFsm = null;
		this.IsPause = false;
		this.OpenViewStack.Clear();
		this.LastDayIncome = 0L;
		this.LastIncomeEntityList.Clear();
		this.OwnCardEntityCountInternal = 0;
		this.NeedReStart = false;
		this.IsExit = false;
		this.CurrentActivityData = null;
		this.ActionInfoList.Clear();
		this.EntityMap.Clear();
	}

	// Token: 0x0600A302 RID: 41730 RVA: 0x002FD57A File Offset: 0x002FB77A
	public void RefreshDailyTaskData(List<FloroRanchPlayTask> taskList)
	{
		this.TaskList = taskList;
	}

	// Token: 0x0600A303 RID: 41731 RVA: 0x002FD583 File Offset: 0x002FB783
	public List<FloroRanchPlayTask> GetDailyTaskList()
	{
		List<FloroRanchPlayTask> result = new List<FloroRanchPlayTask>(this.TaskList);
		this.TaskList.Clear();
		return result;
	}

	// Token: 0x0600A304 RID: 41732 RVA: 0x002FD59C File Offset: 0x002FB79C
	private void AddEntityByType(EFloroRanchEntityType type, FloroRanchEntityBase entity)
	{
		switch (type)
		{
		case EFloroRanchEntityType.Terrain:
			this.TerrainEntityList.Add(entity);
			return;
		case EFloroRanchEntityType.Card:
			this.CardEntityList.Add(entity);
			return;
		case EFloroRanchEntityType.Toy:
			this.ToyEntityList.Add(entity);
			return;
		case EFloroRanchEntityType.Dungeon:
		{
			if (this.DungeonEntity == null)
			{
				this.DungeonEntity = entity;
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanch添加实体失败：DungeonEntity已存在 不可重复添加";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entity.EntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		case EFloroRanchEntityType.Role:
		{
			if (this.RoleEntity == null)
			{
				this.RoleEntity = entity;
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.FloroRanchGamePlay;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "FloroRanch添加实体失败：RoleEntity已存在 不可重复添加";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entity.EntityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		default:
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.FloroRanchGamePlay;
			ELogAuthor author3 = ELogAuthor.LRC;
			string message3 = "FloroRanch添加实体失败：EntityType错误";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("type", type);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		}
	}

	// Token: 0x0600A305 RID: 41733 RVA: 0x002FD6A8 File Offset: 0x002FB8A8
	private bool RemoveEntityByType(EFloroRanchEntityType type, FloroRanchEntityBase entity)
	{
		int num = -1;
		switch (type)
		{
		case EFloroRanchEntityType.Terrain:
			num = this.TerrainEntityList.IndexOf(entity);
			if (num != -1)
			{
				this.TerrainEntityList.RemoveAt(num);
			}
			break;
		case EFloroRanchEntityType.Card:
			num = this.CardEntityList.IndexOf(entity);
			if (num != -1)
			{
				this.CardEntityList.RemoveAt(num);
			}
			break;
		case EFloroRanchEntityType.Toy:
			num = this.ToyEntityList.IndexOf(entity);
			if (num != -1)
			{
				this.ToyEntityList.RemoveAt(num);
			}
			break;
		case EFloroRanchEntityType.Dungeon:
			this.DungeonEntity = null;
			break;
		case EFloroRanchEntityType.Role:
			this.RoleEntity = null;
			break;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "RemoveEntityByType失败：EntityType错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			break;
		}
		}
		bool flag = num != -1;
		if (!flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.FloroRanchGamePlay;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "RemoveEntityByType失败：实体不存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entity.EntityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return flag;
	}

	// Token: 0x0600A306 RID: 41734 RVA: 0x002FD7B4 File Offset: 0x002FB9B4
	public List<FloroRanchEntityBase> GetShowCardEntityList()
	{
		List<FloroRanchEntityBase> list = new List<FloroRanchEntityBase>();
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.CardEntityList)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent.IsValid && floroRanchEntityDataComponent.Point != -1)
			{
				list.Add(floroRanchEntityBase);
			}
		}
		return list;
	}

	// Token: 0x0600A307 RID: 41735 RVA: 0x002FD828 File Offset: 0x002FBA28
	public List<FloroRanchEntityBase> GetShowToyEntityList()
	{
		List<FloroRanchEntityBase> list = new List<FloroRanchEntityBase>();
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.ToyEntityList)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent.IsValid && floroRanchEntityDataComponent.Point != -1)
			{
				list.Add(floroRanchEntityBase);
			}
		}
		return list;
	}

	// Token: 0x0600A308 RID: 41736 RVA: 0x002FD89C File Offset: 0x002FBA9C
	public int GetCurToyCount()
	{
		return this.GetShowToyEntityList().Count;
	}

	// Token: 0x0600A309 RID: 41737 RVA: 0x002FD8AC File Offset: 0x002FBAAC
	public List<FloroRanchEntityBase> GetShowTerrainEntityList()
	{
		List<FloroRanchEntityBase> list = new List<FloroRanchEntityBase>();
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.TerrainEntityList)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent.IsValid && floroRanchEntityDataComponent.Point != -1)
			{
				list.Add(floroRanchEntityBase);
			}
		}
		return list;
	}

	// Token: 0x0600A30A RID: 41738 RVA: 0x002FD920 File Offset: 0x002FBB20
	[NullableContext(2)]
	public FloroRanchEntityBase GetCardEntityByPoint(int point)
	{
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.CardEntityList)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent.IsValid && floroRanchEntityDataComponent.Point == point)
			{
				return floroRanchEntityBase;
			}
		}
		return null;
	}

	// Token: 0x0600A30B RID: 41739 RVA: 0x002FD98C File Offset: 0x002FBB8C
	[NullableContext(2)]
	public FloroRanchEntityBase GetTerrainEntityByPoint(int point)
	{
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.TerrainEntityList)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent.IsValid && floroRanchEntityDataComponent.Point == point)
			{
				return floroRanchEntityBase;
			}
		}
		return null;
	}

	// Token: 0x0600A30C RID: 41740 RVA: 0x002FD9F8 File Offset: 0x002FBBF8
	[NullableContext(2)]
	public FloroRanchEntityBase GetToyEntityByPoint(int point)
	{
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.ToyEntityList)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent.IsValid && floroRanchEntityDataComponent.Point == point)
			{
				return floroRanchEntityBase;
			}
		}
		return null;
	}

	// Token: 0x0600A30D RID: 41741 RVA: 0x002FDA64 File Offset: 0x002FBC64
	public void ClearLastDayIncome()
	{
		this.LastDayIncome = 0L;
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.EntityMap.Values)
		{
			floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>().Income = 0L;
		}
	}

	// Token: 0x0600A30E RID: 41742 RVA: 0x002FDAC8 File Offset: 0x002FBCC8
	public void RefreshLastIncomeEntityList()
	{
		this.LastIncomeEntityList.Clear();
		foreach (FloroRanchEntityBase item in this.EntityMap.Values)
		{
			this.LastIncomeEntityList.Add(item);
		}
		this.LastIncomeEntityList.Sort(delegate(FloroRanchEntityBase a, FloroRanchEntityBase b)
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = a.CheckGetComponent<FloroRanchEntityDataComponent>();
			FloroRanchEntityDataComponent floroRanchEntityDataComponent2 = b.CheckGetComponent<FloroRanchEntityDataComponent>();
			if (floroRanchEntityDataComponent2.Income != floroRanchEntityDataComponent.Income)
			{
				return floroRanchEntityDataComponent2.Income.CompareTo(floroRanchEntityDataComponent.Income);
			}
			bool isValid = floroRanchEntityDataComponent.IsValid;
			bool isValid2 = floroRanchEntityDataComponent2.IsValid;
			if (isValid != isValid2)
			{
				if (!isValid2)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				int num2;
				int num = FloroRanchDefine.EntityTypePriority.TryGetValue((int)floroRanchEntityDataComponent.EntityType, out num2) ? num2 : 0;
				int num4;
				int num3 = FloroRanchDefine.EntityTypePriority.TryGetValue((int)floroRanchEntityDataComponent2.EntityType, out num4) ? num4 : 0;
				if (num3 != num)
				{
					return num - num3;
				}
				int race = a.GetRace();
				int race2 = b.GetRace();
				if (race != race2)
				{
					return race - race2;
				}
				int rarity = a.GetRarity();
				int rarity2 = b.GetRarity();
				if (rarity != rarity2)
				{
					return rarity2 - rarity;
				}
				return floroRanchEntityDataComponent.EntityId - floroRanchEntityDataComponent2.EntityId;
			}
		});
	}

	// Token: 0x0600A30F RID: 41743 RVA: 0x002FDB5C File Offset: 0x002FBD5C
	public List<IFloroRanchDetailData> GetLastIncomeEntityList(FloroRanchFilterType filterType, bool isAscending, bool isShowNotPresentCard)
	{
		List<FloroRanchEntityBase> list = this.LastIncomeEntityList;
		list = list.FindAll(delegate(FloroRanchEntityBase entity)
		{
			EFloroRanchEntityType entityType = entity.EntityType;
			if (!this.CheckEntityTypeIsVisible(entityType))
			{
				return false;
			}
			int point = entity.GetPoint();
			return (isShowNotPresentCard || point != -1) && (filterType.FilterTypeId < 0 || filterType.FilterTypeId == (int)entityType);
		});
		List<IFloroRanchDetailData> list2 = new List<IFloroRanchDetailData>();
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(new FloroRanchDetailData
			{
				EntityData = list[i],
				Rank = i + 1
			});
		}
		if (!isAscending)
		{
			list2.Reverse();
		}
		return list2;
	}

	// Token: 0x0600A310 RID: 41744 RVA: 0x002FDBE0 File Offset: 0x002FBDE0
	public long GetLastDayIncome()
	{
		return this.LastDayIncome;
	}

	// Token: 0x0600A311 RID: 41745 RVA: 0x002FDBE8 File Offset: 0x002FBDE8
	public void AddLastDayIncome(long income)
	{
		this.LastDayIncome += income;
	}

	// Token: 0x0600A312 RID: 41746 RVA: 0x002FDBF8 File Offset: 0x002FBDF8
	public void SetStageTarget(long target)
	{
		this.StageTarget = target;
	}

	// Token: 0x0600A313 RID: 41747 RVA: 0x002FDC01 File Offset: 0x002FBE01
	public long GetStageTarget()
	{
		return this.StageTarget;
	}

	// Token: 0x0600A314 RID: 41748 RVA: 0x002FDC0C File Offset: 0x002FBE0C
	[NullableContext(2)]
	public FloroRanchGamePlayView GetGamePlayView()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView);
		if (viewByName == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "GetGamePlayView失败：view不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return viewByName as FloroRanchGamePlayView;
	}

	// Token: 0x0600A315 RID: 41749 RVA: 0x002FDC53 File Offset: 0x002FBE53
	public bool CheckEntityTypeIsVisible(EFloroRanchEntityType entityType)
	{
		return entityType == EFloroRanchEntityType.Card || entityType == EFloroRanchEntityType.Toy || entityType == EFloroRanchEntityType.Terrain;
	}

	// Token: 0x0600A316 RID: 41750 RVA: 0x002FDC64 File Offset: 0x002FBE64
	private void InitTimerSystem()
	{
		if (this.TimerHandle != null)
		{
			this.ClearTimerHandle();
		}
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
		this.TimeDilation = 1;
		this.IsSkipInternal = false;
	}

	// Token: 0x0600A317 RID: 41751 RVA: 0x002FDCB6 File Offset: 0x002FBEB6
	private void OnTick(float deltaTime)
	{
		if (this.IsPause)
		{
			return;
		}
		this.FloroRanchTimerSystem.Tick((double)(deltaTime * (float)this.TimeDilation));
	}

	// Token: 0x0600A318 RID: 41752 RVA: 0x002FDCD6 File Offset: 0x002FBED6
	private void ClearTimerSystem()
	{
		this.ClearTimerHandle();
		this.TimeDilation = 1;
		this.IsSkipInternal = false;
		this.FloroRanchTimerSystem.Clear();
	}

	// Token: 0x0600A319 RID: 41753 RVA: 0x002FDCF7 File Offset: 0x002FBEF7
	private void ClearTimerHandle()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600A31A RID: 41754 RVA: 0x002FDD23 File Offset: 0x002FBF23
	public void SetTimeDilation(int dilation)
	{
		this.TimeDilation = dilation;
	}

	// Token: 0x0600A31B RID: 41755 RVA: 0x002FDD2C File Offset: 0x002FBF2C
	public int GetTimeDilation()
	{
		return this.TimeDilation;
	}

	// Token: 0x1700116E RID: 4462
	// (get) Token: 0x0600A31C RID: 41756 RVA: 0x002FDD34 File Offset: 0x002FBF34
	// (set) Token: 0x0600A31D RID: 41757 RVA: 0x002FDD3C File Offset: 0x002FBF3C
	public bool IsSkip
	{
		get
		{
			return this.IsSkipInternal;
		}
		set
		{
			this.IsSkipInternal = value;
		}
	}

	// Token: 0x0600A31E RID: 41758 RVA: 0x002FDD48 File Offset: 0x002FBF48
	public float GetPopupRewardStayTime()
	{
		if (!FloroRanchDefine.FloroRanchSpeedTimeMap.ContainsKey(this.TimeDilation))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GetPopupRewardStayTime失败：TimeDilation错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeDilation", this.TimeDilation);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 500f;
		}
		return FloroRanchDefine.FloroRanchSpeedTimeMap[this.TimeDilation].PopupRewardStayTime;
	}

	// Token: 0x0600A31F RID: 41759 RVA: 0x002FDDB8 File Offset: 0x002FBFB8
	public float GetPopupRewardWaitTime()
	{
		if (!FloroRanchDefine.FloroRanchSpeedTimeMap.ContainsKey(this.TimeDilation))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GetPopupRewardWaitTime失败：TimeDilation错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeDilation", this.TimeDilation);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 200f;
		}
		return FloroRanchDefine.FloroRanchSpeedTimeMap[this.TimeDilation].PopupRewardWaitTime;
	}

	// Token: 0x0600A320 RID: 41760 RVA: 0x002FDE28 File Offset: 0x002FC028
	public float GetBezierCurveTime()
	{
		if (!FloroRanchDefine.FloroRanchSpeedTimeMap.ContainsKey(this.TimeDilation))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GetBezierCurveTime失败：TimeDilation错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeDilation", this.TimeDilation);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 500f;
		}
		return FloroRanchDefine.FloroRanchSpeedTimeMap[this.TimeDilation].BezierCurveTime;
	}

	// Token: 0x0600A321 RID: 41761 RVA: 0x002FDE98 File Offset: 0x002FC098
	public float GetWageSettleWaitTime()
	{
		if (!FloroRanchDefine.FloroRanchSpeedTimeMap.ContainsKey(this.TimeDilation))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GetWageSettleWaitTime失败：TimeDilation错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TimeDilation", this.TimeDilation);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 2500f;
		}
		return FloroRanchDefine.FloroRanchSpeedTimeMap[this.TimeDilation].WageSettleWaitTime;
	}

	// Token: 0x1700116F RID: 4463
	// (get) Token: 0x0600A322 RID: 41762 RVA: 0x002FDF06 File Offset: 0x002FC106
	public static FloroRanchGamePlayModel Instance
	{
		get
		{
			return FloroRanchGamePlayModel._Instance;
		}
	}

	// Token: 0x0600A323 RID: 41763 RVA: 0x002FDF0D File Offset: 0x002FC10D
	public static FloroRanchGamePlayModel GetOrCreateInstance()
	{
		if (FloroRanchGamePlayModel._Instance == null)
		{
			FloroRanchGamePlayModel.CreateInstance();
		}
		return FloroRanchGamePlayModel._Instance;
	}

	// Token: 0x0600A324 RID: 41764 RVA: 0x002FDF21 File Offset: 0x002FC121
	public static bool CreateInstance()
	{
		if (FloroRanchGamePlayModel._Instance != null)
		{
			return true;
		}
		FloroRanchGamePlayModel._Instance = new FloroRanchGamePlayModel();
		return true;
	}

	// Token: 0x0600A325 RID: 41765 RVA: 0x002FDF37 File Offset: 0x002FC137
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A326 RID: 41766 RVA: 0x002FDF39 File Offset: 0x002FC139
	public static void ResetStaticDefaultValue()
	{
		FloroRanchGamePlayModel._Instance = null;
	}

	// Token: 0x0600A327 RID: 41767 RVA: 0x002FDF41 File Offset: 0x002FC141
	static FloroRanchGamePlayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchGamePlayModel.CreateStaticDefaultValue), new Action(FloroRanchGamePlayModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005FEC RID: 24556
	public int ActivityId;

	// Token: 0x04005FED RID: 24557
	public int SubInstanceId;

	// Token: 0x04005FEE RID: 24558
	public List<int> Races = new List<int>();

	// Token: 0x04005FEF RID: 24559
	public int SkillId;

	// Token: 0x04005FF0 RID: 24560
	[Nullable(2)]
	private global::FloroRanchActivityData CurrentActivityData;

	// Token: 0x04005FF1 RID: 24561
	public bool IsOver;

	// Token: 0x04005FF2 RID: 24562
	public int CurStage;

	// Token: 0x04005FF3 RID: 24563
	public int RemindDay;

	// Token: 0x04005FF4 RID: 24564
	public long StageTarget;

	// Token: 0x04005FF5 RID: 24565
	public int StageDayCount;

	// Token: 0x04005FF6 RID: 24566
	public int TotalDayCount;

	// Token: 0x04005FF7 RID: 24567
	public int EnableToyCount;

	// Token: 0x04005FF8 RID: 24568
	private long LastDayIncome;

	// Token: 0x04005FF9 RID: 24569
	private bool InGamePlay;

	// Token: 0x04005FFA RID: 24570
	public bool IsEndlessMode;

	// Token: 0x04005FFB RID: 24571
	public FloroRanchCurrencyData CoinData = new FloroRanchCurrencyData(ECurrencyType.Coin);

	// Token: 0x04005FFC RID: 24572
	public FloroRanchCurrencyData DiamondData = new FloroRanchCurrencyData(ECurrencyType.Diamond);

	// Token: 0x04005FFD RID: 24573
	private int OwnCardEntityCountInternal;

	// Token: 0x04005FFE RID: 24574
	public bool ShowEntityDebugInfo = true;

	// Token: 0x04005FFF RID: 24575
	private readonly List<FloroRanchEntityBase> TerrainEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04006000 RID: 24576
	private readonly List<FloroRanchEntityBase> CardEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04006001 RID: 24577
	private readonly List<FloroRanchEntityBase> ToyEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04006002 RID: 24578
	[Nullable(2)]
	public FloroRanchEntityBase DungeonEntity;

	// Token: 0x04006003 RID: 24579
	[Nullable(2)]
	public FloroRanchEntityBase RoleEntity;

	// Token: 0x04006004 RID: 24580
	private readonly Dictionary<int, FloroRanchEntityBase> EntityMap = new Dictionary<int, FloroRanchEntityBase>();

	// Token: 0x04006005 RID: 24581
	private readonly List<FloroRanchEntityBase> LastIncomeEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04006006 RID: 24582
	private List<FloroRanchPlayTask> TaskList = new List<FloroRanchPlayTask>();

	// Token: 0x04006007 RID: 24583
	[Nullable(2)]
	private FloroRanchStageFsm FloroRanchFsm;

	// Token: 0x04006008 RID: 24584
	private readonly List<int> OpenViewStack = new List<int>();

	// Token: 0x04006009 RID: 24585
	public List<string> ActionInfoList = new List<string>();

	// Token: 0x0400600A RID: 24586
	public bool NeedReStart;

	// Token: 0x0400600B RID: 24587
	public bool NeedSettle;

	// Token: 0x0400600C RID: 24588
	public bool IsPause;

	// Token: 0x0400600D RID: 24589
	public bool IsExit;

	// Token: 0x0400600E RID: 24590
	public TimerSystemInstance FloroRanchTimerSystem = new TimerSystemInstance();

	// Token: 0x0400600F RID: 24591
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04006010 RID: 24592
	private int TimeDilation = 1;

	// Token: 0x04006011 RID: 24593
	private bool IsSkipInternal;

	// Token: 0x04006012 RID: 24594
	[Nullable(2)]
	private static FloroRanchGamePlayModel _Instance;
}
