using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Ui;

// Token: 0x02001B3F RID: 6975
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FloroRanchGamePlayModel : ModelBase
{
	// Token: 0x0600CEC9 RID: 52937 RVA: 0x002F16FE File Offset: 0x002EF8FE
	public void SetCurrentActivityData(global::FloroRanchActivityData data)
	{
		this.CurrentActivityData = data;
	}

	// Token: 0x0600CECA RID: 52938 RVA: 0x002F1708 File Offset: 0x002EF908
	[NullableContext(2)]
	public global::FloroRanchActivityData GetCurrentActivityData()
	{
		if (this.CurrentActivityData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "FloroRanch获取当前活动数据失败：当前活动数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return this.CurrentActivityData;
	}

	// Token: 0x17001147 RID: 4423
	// (get) Token: 0x0600CECB RID: 52939 RVA: 0x002F1742 File Offset: 0x002EF942
	public bool IsInGamePlay
	{
		get
		{
			return this.InGamePlay;
		}
	}

	// Token: 0x0600CECC RID: 52940 RVA: 0x002F174A File Offset: 0x002EF94A
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		return true;
	}

	// Token: 0x0600CECD RID: 52941 RVA: 0x002F1766 File Offset: 0x002EF966
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		return true;
	}

	// Token: 0x0600CECE RID: 52942 RVA: 0x002F1782 File Offset: 0x002EF982
	public void InitGame(int activityId, List<int> races, int skillId, bool isOver)
	{
		this.ActivityId = activityId;
		this.Races = races;
		this.SkillId = skillId;
		this.IsOver = isOver;
	}

	// Token: 0x0600CECF RID: 52943 RVA: 0x002F17A4 File Offset: 0x002EF9A4
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

	// Token: 0x0600CED0 RID: 52944 RVA: 0x002F182A File Offset: 0x002EFA2A
	public void InitStateMachine()
	{
		this.FloroRanchFsm = new FloroRanchStageFsm();
		this.FloroRanchFsm.Init();
	}

	// Token: 0x0600CED1 RID: 52945 RVA: 0x002F1844 File Offset: 0x002EFA44
	public bool CanFsmInsertSkillTask()
	{
		if (this.FloroRanchFsm.GetCurrentStateType() != EFloroRanchStageStateType.DailyInStage)
		{
			return false;
		}
		FloroRanchStateBase currentState = this.FloroRanchFsm.GetCurrentState();
		return currentState != null && currentState is FloroRanchDailyInStageState && !((FloroRanchDailyInStageState)currentState).IsExecutingTask();
	}

	// Token: 0x0600CED2 RID: 52946 RVA: 0x002F1888 File Offset: 0x002EFA88
	public void ChangeState(EFloroRanchStageStateType state)
	{
		this.FloroRanchFsm.ChangeState(state);
	}

	// Token: 0x0600CED3 RID: 52947 RVA: 0x002F1898 File Offset: 0x002EFA98
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

	// Token: 0x0600CED4 RID: 52948 RVA: 0x002F1960 File Offset: 0x002EFB60
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

	// Token: 0x0600CED5 RID: 52949 RVA: 0x002F1A28 File Offset: 0x002EFC28
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

	// Token: 0x0600CED6 RID: 52950 RVA: 0x002F1A8C File Offset: 0x002EFC8C
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

	// Token: 0x0600CED7 RID: 52951 RVA: 0x002F1AD8 File Offset: 0x002EFCD8
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

	// Token: 0x0600CED8 RID: 52952 RVA: 0x002F1B25 File Offset: 0x002EFD25
	public void InitData(FloroRanchPlayInfo gameData)
	{
		this.InGamePlay = true;
		this.RefreshBasicData(gameData);
		this.InitEntityData(gameData);
	}

	// Token: 0x0600CED9 RID: 52953 RVA: 0x002F1B3C File Offset: 0x002EFD3C
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

	// Token: 0x0600CEDA RID: 52954 RVA: 0x002F1BF8 File Offset: 0x002EFDF8
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

	// Token: 0x0600CEDB RID: 52955 RVA: 0x002F1CCE File Offset: 0x002EFECE
	public void OnDayStart(FloroRanchDayStart data)
	{
		this.CurStage = data.CurStage;
		this.IsEndlessMode = data.IsUnlimited;
		this.TotalDayCount = data.TotalDay;
		this.RemindDay = data.RemainDay;
	}

	// Token: 0x0600CEDC RID: 52956 RVA: 0x002F1D00 File Offset: 0x002EFF00
	public void OnStageStart(FloroRanchStageStart data)
	{
		this.StageTarget = data.Target;
		this.StageDayCount = data.DayCount;
		EventSystem.Instance.Emit(EEventName.OnFloroRanchStageInfoRefresh);
	}

	// Token: 0x0600CEDD RID: 52957 RVA: 0x002F1D2C File Offset: 0x002EFF2C
	public void AddEntityList(List<FloroRanchPlayUnit> entityDataList)
	{
		foreach (FloroRanchPlayUnit entityData in entityDataList)
		{
			this.AddEntity(entityData);
		}
	}

	// Token: 0x0600CEDE RID: 52958 RVA: 0x002F1D7C File Offset: 0x002EFF7C
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

	// Token: 0x0600CEDF RID: 52959 RVA: 0x002F1E14 File Offset: 0x002F0014
	public void RefreshEntityList(List<FloroRanchPlayUnit> entityDataList)
	{
		foreach (FloroRanchPlayUnit floroRanchPlayUnit in entityDataList)
		{
			this.GetEntity(floroRanchPlayUnit.PlayIncId).RefreshEntityData(floroRanchPlayUnit);
		}
	}

	// Token: 0x0600CEE0 RID: 52960 RVA: 0x002F1E70 File Offset: 0x002F0070
	public void RefreshRemoveEntityList(List<int> entityList)
	{
		foreach (int entityId in entityList)
		{
			this.GetEntity(entityId).CheckGetComponent<FloroRanchEntityDataComponent>().Remove();
		}
	}

	// Token: 0x0600CEE1 RID: 52961 RVA: 0x002F1EC8 File Offset: 0x002F00C8
	public bool CheckEntityIsExist(int entityId)
	{
		return this.EntityMap.ContainsKey(entityId);
	}

	// Token: 0x0600CEE2 RID: 52962 RVA: 0x002F1ED8 File Offset: 0x002F00D8
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

	// Token: 0x0600CEE3 RID: 52963 RVA: 0x002F1F68 File Offset: 0x002F0168
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

	// Token: 0x0600CEE4 RID: 52964 RVA: 0x002F1FE8 File Offset: 0x002F01E8
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

	// Token: 0x0600CEE5 RID: 52965 RVA: 0x002F206C File Offset: 0x002F026C
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

	// Token: 0x0600CEE6 RID: 52966 RVA: 0x002F210C File Offset: 0x002F030C
	public void OnTributeResult(FloroRanchPlayTributeResponse data)
	{
		this.RemindDay = data.RemainDay;
		this.CurStage = data.CurStage;
		EventSystem.Instance.Emit(EEventName.OnFloroRanchStageInfoRefresh);
		long curCoin = data.CurCoin;
		long curDiamond = data.CurDiamond;
		this.OnCurrencyChange(curCoin, curDiamond);
	}

	// Token: 0x0600CEE7 RID: 52967 RVA: 0x002F2157 File Offset: 0x002F0357
	public void OnCurrencyChange(long coinAmount, long diamondAmount)
	{
		this.CoinData.SetAmount(coinAmount);
		this.DiamondData.SetAmount(diamondAmount);
		this.GetGamePlayView().RefreshCurrencyInfo();
	}

	// Token: 0x0600CEE8 RID: 52968 RVA: 0x002F217C File Offset: 0x002F037C
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

	// Token: 0x0600CEE9 RID: 52969 RVA: 0x002F21C4 File Offset: 0x002F03C4
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		int count = this.OpenViewStack.Count;
		if (count > 0 && this.OpenViewStack[count - 1] == viewId)
		{
			this.OpenViewStack.RemoveAt(count - 1);
		}
	}

	// Token: 0x0600CEEA RID: 52970 RVA: 0x002F2200 File Offset: 0x002F0400
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

	// Token: 0x0600CEEB RID: 52971 RVA: 0x002F2270 File Offset: 0x002F0470
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

	// Token: 0x0600CEEC RID: 52972 RVA: 0x002F22E0 File Offset: 0x002F04E0
	public void CloseAllRecordView()
	{
		foreach (int viewId in this.OpenViewStack)
		{
			UiManager.Instance.CloseViewById(viewId, null);
		}
		this.OpenViewStack.Clear();
	}

	// Token: 0x17001148 RID: 4424
	// (get) Token: 0x0600CEED RID: 52973 RVA: 0x002F2344 File Offset: 0x002F0544
	public int OwnCardEntityCount
	{
		get
		{
			return this.OwnCardEntityCountInternal;
		}
	}

	// Token: 0x0600CEEE RID: 52974 RVA: 0x002F234C File Offset: 0x002F054C
	public void SetOwnCardEntityCount(int count)
	{
		this.OwnCardEntityCountInternal = count;
		EventSystem.Instance.Emit(EEventName.OnFloroRanchCardEntityCountChange);
	}

	// Token: 0x0600CEEF RID: 52975 RVA: 0x002F2368 File Offset: 0x002F0568
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

	// Token: 0x0600CEF0 RID: 52976 RVA: 0x002F23C8 File Offset: 0x002F05C8
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

	// Token: 0x0600CEF1 RID: 52977 RVA: 0x002F24A2 File Offset: 0x002F06A2
	public void RefreshDailyTaskData(List<FloroRanchPlayTask> taskList)
	{
		this.TaskList = taskList;
	}

	// Token: 0x0600CEF2 RID: 52978 RVA: 0x002F24AB File Offset: 0x002F06AB
	public List<FloroRanchPlayTask> GetDailyTaskList()
	{
		List<FloroRanchPlayTask> result = new List<FloroRanchPlayTask>(this.TaskList);
		this.TaskList.Clear();
		return result;
	}

	// Token: 0x0600CEF3 RID: 52979 RVA: 0x002F24C4 File Offset: 0x002F06C4
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

	// Token: 0x0600CEF4 RID: 52980 RVA: 0x002F25D0 File Offset: 0x002F07D0
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

	// Token: 0x0600CEF5 RID: 52981 RVA: 0x002F26DC File Offset: 0x002F08DC
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

	// Token: 0x0600CEF6 RID: 52982 RVA: 0x002F2750 File Offset: 0x002F0950
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

	// Token: 0x0600CEF7 RID: 52983 RVA: 0x002F27C4 File Offset: 0x002F09C4
	public int GetCurToyCount()
	{
		return this.GetShowToyEntityList().Count;
	}

	// Token: 0x0600CEF8 RID: 52984 RVA: 0x002F27D4 File Offset: 0x002F09D4
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

	// Token: 0x0600CEF9 RID: 52985 RVA: 0x002F2848 File Offset: 0x002F0A48
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

	// Token: 0x0600CEFA RID: 52986 RVA: 0x002F28B4 File Offset: 0x002F0AB4
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

	// Token: 0x0600CEFB RID: 52987 RVA: 0x002F2920 File Offset: 0x002F0B20
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

	// Token: 0x0600CEFC RID: 52988 RVA: 0x002F298C File Offset: 0x002F0B8C
	public void ClearLastDayIncome()
	{
		this.LastDayIncome = 0L;
		foreach (FloroRanchEntityBase floroRanchEntityBase in this.EntityMap.Values)
		{
			floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>().Income = 0L;
		}
	}

	// Token: 0x0600CEFD RID: 52989 RVA: 0x002F29F0 File Offset: 0x002F0BF0
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

	// Token: 0x0600CEFE RID: 52990 RVA: 0x002F2A84 File Offset: 0x002F0C84
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

	// Token: 0x0600CEFF RID: 52991 RVA: 0x002F2B08 File Offset: 0x002F0D08
	public long GetLastDayIncome()
	{
		return this.LastDayIncome;
	}

	// Token: 0x0600CF00 RID: 52992 RVA: 0x002F2B10 File Offset: 0x002F0D10
	public void AddLastDayIncome(long income)
	{
		this.LastDayIncome += income;
	}

	// Token: 0x0600CF01 RID: 52993 RVA: 0x002F2B20 File Offset: 0x002F0D20
	public void SetStageTarget(long target)
	{
		this.StageTarget = target;
	}

	// Token: 0x0600CF02 RID: 52994 RVA: 0x002F2B29 File Offset: 0x002F0D29
	public long GetStageTarget()
	{
		return this.StageTarget;
	}

	// Token: 0x0600CF03 RID: 52995 RVA: 0x002F2B34 File Offset: 0x002F0D34
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

	// Token: 0x0600CF04 RID: 52996 RVA: 0x002F2B7B File Offset: 0x002F0D7B
	public bool CheckEntityTypeIsVisible(EFloroRanchEntityType entityType)
	{
		return entityType == EFloroRanchEntityType.Card || entityType == EFloroRanchEntityType.Toy || entityType == EFloroRanchEntityType.Terrain;
	}

	// Token: 0x0600CF05 RID: 52997 RVA: 0x002F2B8C File Offset: 0x002F0D8C
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

	// Token: 0x0600CF06 RID: 52998 RVA: 0x002F2BDE File Offset: 0x002F0DDE
	private void OnTick(float deltaTime)
	{
		if (this.IsPause)
		{
			return;
		}
		this.FloroRanchTimerSystem.Tick((double)(deltaTime * (float)this.TimeDilation));
	}

	// Token: 0x0600CF07 RID: 52999 RVA: 0x002F2BFE File Offset: 0x002F0DFE
	private void ClearTimerSystem()
	{
		this.ClearTimerHandle();
		this.TimeDilation = 1;
		this.IsSkipInternal = false;
		this.FloroRanchTimerSystem.Clear();
	}

	// Token: 0x0600CF08 RID: 53000 RVA: 0x002F2C1F File Offset: 0x002F0E1F
	private void ClearTimerHandle()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600CF09 RID: 53001 RVA: 0x002F2C4B File Offset: 0x002F0E4B
	public void SetTimeDilation(int dilation)
	{
		this.TimeDilation = dilation;
	}

	// Token: 0x0600CF0A RID: 53002 RVA: 0x002F2C54 File Offset: 0x002F0E54
	public int GetTimeDilation()
	{
		return this.TimeDilation;
	}

	// Token: 0x17001149 RID: 4425
	// (get) Token: 0x0600CF0B RID: 53003 RVA: 0x002F2C5C File Offset: 0x002F0E5C
	// (set) Token: 0x0600CF0C RID: 53004 RVA: 0x002F2C64 File Offset: 0x002F0E64
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

	// Token: 0x0600CF0D RID: 53005 RVA: 0x002F2C70 File Offset: 0x002F0E70
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

	// Token: 0x0600CF0E RID: 53006 RVA: 0x002F2CE0 File Offset: 0x002F0EE0
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

	// Token: 0x0600CF0F RID: 53007 RVA: 0x002F2D50 File Offset: 0x002F0F50
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

	// Token: 0x0600CF10 RID: 53008 RVA: 0x002F2DC0 File Offset: 0x002F0FC0
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

	// Token: 0x1700114A RID: 4426
	// (get) Token: 0x0600CF11 RID: 53009 RVA: 0x002F2E2E File Offset: 0x002F102E
	public static FloroRanchGamePlayModel Instance
	{
		get
		{
			return FloroRanchGamePlayModel._Instance;
		}
	}

	// Token: 0x0600CF12 RID: 53010 RVA: 0x002F2E35 File Offset: 0x002F1035
	public static FloroRanchGamePlayModel GetOrCreateInstance()
	{
		if (FloroRanchGamePlayModel._Instance == null)
		{
			FloroRanchGamePlayModel.CreateInstance();
		}
		return FloroRanchGamePlayModel._Instance;
	}

	// Token: 0x0600CF13 RID: 53011 RVA: 0x002F2E49 File Offset: 0x002F1049
	public static bool CreateInstance()
	{
		if (FloroRanchGamePlayModel._Instance != null)
		{
			return true;
		}
		FloroRanchGamePlayModel._Instance = new FloroRanchGamePlayModel();
		return true;
	}

	// Token: 0x0600CF14 RID: 53012 RVA: 0x002F2E5F File Offset: 0x002F105F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CF15 RID: 53013 RVA: 0x002F2E61 File Offset: 0x002F1061
	public static void ResetStaticDefaultValue()
	{
		FloroRanchGamePlayModel._Instance = null;
	}

	// Token: 0x0600CF16 RID: 53014 RVA: 0x002F2E69 File Offset: 0x002F1069
	static FloroRanchGamePlayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchGamePlayModel.CreateStaticDefaultValue), new Action(FloroRanchGamePlayModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005F1D RID: 24349
	public int ActivityId;

	// Token: 0x04005F1E RID: 24350
	public int SubInstanceId;

	// Token: 0x04005F1F RID: 24351
	public List<int> Races = new List<int>();

	// Token: 0x04005F20 RID: 24352
	public int SkillId;

	// Token: 0x04005F21 RID: 24353
	[Nullable(2)]
	private global::FloroRanchActivityData CurrentActivityData;

	// Token: 0x04005F22 RID: 24354
	public bool IsOver;

	// Token: 0x04005F23 RID: 24355
	public int CurStage;

	// Token: 0x04005F24 RID: 24356
	public int RemindDay;

	// Token: 0x04005F25 RID: 24357
	public long StageTarget;

	// Token: 0x04005F26 RID: 24358
	public int StageDayCount;

	// Token: 0x04005F27 RID: 24359
	public int TotalDayCount;

	// Token: 0x04005F28 RID: 24360
	public int EnableToyCount;

	// Token: 0x04005F29 RID: 24361
	private long LastDayIncome;

	// Token: 0x04005F2A RID: 24362
	private bool InGamePlay;

	// Token: 0x04005F2B RID: 24363
	public bool IsEndlessMode;

	// Token: 0x04005F2C RID: 24364
	public FloroRanchCurrencyData CoinData = new FloroRanchCurrencyData(ECurrencyType.Coin);

	// Token: 0x04005F2D RID: 24365
	public FloroRanchCurrencyData DiamondData = new FloroRanchCurrencyData(ECurrencyType.Diamond);

	// Token: 0x04005F2E RID: 24366
	private int OwnCardEntityCountInternal;

	// Token: 0x04005F2F RID: 24367
	public bool ShowEntityDebugInfo = true;

	// Token: 0x04005F30 RID: 24368
	private readonly List<FloroRanchEntityBase> TerrainEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04005F31 RID: 24369
	private readonly List<FloroRanchEntityBase> CardEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04005F32 RID: 24370
	private readonly List<FloroRanchEntityBase> ToyEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04005F33 RID: 24371
	[Nullable(2)]
	public FloroRanchEntityBase DungeonEntity;

	// Token: 0x04005F34 RID: 24372
	[Nullable(2)]
	public FloroRanchEntityBase RoleEntity;

	// Token: 0x04005F35 RID: 24373
	private readonly Dictionary<int, FloroRanchEntityBase> EntityMap = new Dictionary<int, FloroRanchEntityBase>();

	// Token: 0x04005F36 RID: 24374
	private readonly List<FloroRanchEntityBase> LastIncomeEntityList = new List<FloroRanchEntityBase>();

	// Token: 0x04005F37 RID: 24375
	private List<FloroRanchPlayTask> TaskList = new List<FloroRanchPlayTask>();

	// Token: 0x04005F38 RID: 24376
	[Nullable(2)]
	private FloroRanchStageFsm FloroRanchFsm;

	// Token: 0x04005F39 RID: 24377
	private readonly List<int> OpenViewStack = new List<int>();

	// Token: 0x04005F3A RID: 24378
	public List<string> ActionInfoList = new List<string>();

	// Token: 0x04005F3B RID: 24379
	public bool NeedReStart;

	// Token: 0x04005F3C RID: 24380
	public bool NeedSettle;

	// Token: 0x04005F3D RID: 24381
	public bool IsPause;

	// Token: 0x04005F3E RID: 24382
	public bool IsExit;

	// Token: 0x04005F3F RID: 24383
	public TimerSystemInstance FloroRanchTimerSystem = new TimerSystemInstance();

	// Token: 0x04005F40 RID: 24384
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04005F41 RID: 24385
	private int TimeDilation = 1;

	// Token: 0x04005F42 RID: 24386
	private bool IsSkipInternal;

	// Token: 0x04005F43 RID: 24387
	[Nullable(2)]
	private static FloroRanchGamePlayModel _Instance;
}
