using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Guide.GroupInfo;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001280 RID: 4736
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GuideModel : ModelBase
{
	// Token: 0x1700129C RID: 4764
	// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x00373174 File Offset: 0x00371374
	public bool IsGuideLockingInput
	{
		get
		{
			return this.LockingInputGuideStepCount > 0;
		}
	}

	// Token: 0x0600BB55 RID: 47957 RVA: 0x0037317F File Offset: 0x0037137F
	public void AddGuideLockInput()
	{
		this.LockingInputGuideStepCount++;
		if (this.LockingInputGuideStepCount == 1)
		{
			this.RefreshLockInput();
		}
	}

	// Token: 0x0600BB56 RID: 47958 RVA: 0x0037319E File Offset: 0x0037139E
	public void RemoveGuideLockInput()
	{
		this.LockingInputGuideStepCount--;
		if (this.LockingInputGuideStepCount == 0)
		{
			this.RefreshLockInput();
		}
	}

	// Token: 0x0600BB57 RID: 47959 RVA: 0x003731BC File Offset: 0x003713BC
	private void RefreshLockInput()
	{
		UiLayer.Instance.SetShowNormalMaskLayer(this.IsGuideLockingInput, "Guide");
		InputDistributeModel instance = InputDistributeModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RefreshInputDistributeTag();
	}

	// Token: 0x0600BB58 RID: 47960 RVA: 0x003731E4 File Offset: 0x003713E4
	protected override bool OnInit()
	{
		this.FinishedGroupIdSet = new HashSet<int>();
		this.DungeonResetIdList = new HashSet<int>();
		foreach (GuideGroup guideGroup in GuideConfig.Instance.GetAllGroup())
		{
			if (guideGroup.ResetInDungeon)
			{
				this.DungeonResetIdList.Add(guideGroup.Id);
			}
		}
		this.CurrentGroupMap = new Dictionary<int, GuideGroupInfo>();
		this.TypeViewSingletonMap = new Dictionary<EGuideViewType, GuideStepInfo>
		{
			{
				EGuideViewType.GuideFocus,
				null
			},
			{
				EGuideViewType.GuideTips,
				null
			}
		};
		this.FocusGroupMapByView = new Dictionary<EUiViewName, List<GuideGroupInfo>>();
		this.LockingInputGuideStepCount = 0;
		this.IsGmInvoke = false;
		return true;
	}

	// Token: 0x0600BB59 RID: 47961 RVA: 0x003732A0 File Offset: 0x003714A0
	public bool CheckGuideInfoExist(int guideId)
	{
		return this.CurrentGroupMap.ContainsKey(guideId);
	}

	// Token: 0x0600BB5A RID: 47962 RVA: 0x003732AE File Offset: 0x003714AE
	public bool IsLocked()
	{
		return this.IsGmLock || this.IsLock;
	}

	// Token: 0x0600BB5B RID: 47963 RVA: 0x003732C0 File Offset: 0x003714C0
	public void SetLock(bool value)
	{
		if (value == this.IsLock)
		{
			return;
		}
		if (value)
		{
			this.ClearAllGroup();
		}
		this.IsLock = value;
	}

	// Token: 0x0600BB5C RID: 47964 RVA: 0x003732DC File Offset: 0x003714DC
	public void SetGmLock(bool value)
	{
		if (value == this.IsGmLock)
		{
			return;
		}
		if (value)
		{
			this.ClearAllGroup();
		}
		this.IsGmLock = value;
	}

	// Token: 0x0600BB5D RID: 47965 RVA: 0x003732F8 File Offset: 0x003714F8
	public void AddTutorialInfo(TutorialListInfo tutorialInfo)
	{
		if (this.TutorialList == null)
		{
			this.TutorialList = new List<TutorialListInfo>();
		}
		this.TutorialList.Add(tutorialInfo);
		if (this.TimeHandler == null)
		{
			this.TimeHandler = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TutorialListCheckFunc), 20f, 1f, null, null, true);
		}
		this.TryShowTutorial();
	}

	// Token: 0x0600BB5E RID: 47966 RVA: 0x0037335C File Offset: 0x0037155C
	public void TryShowTutorial()
	{
		if (this.TutorialList.Count <= 0)
		{
			return;
		}
		TutorialListInfo tutorialListInfo = this.TutorialList[this.TutorialList.Count - 1];
		if (this.CurrentShowTutorial != null)
		{
			if (this.CurrentShowTutorial.TipState == ETutorialListType.Pop)
			{
				return;
			}
			if (!tutorialListInfo.TutorialTip || this.CurrentShowTutorial.TipState == ETutorialListType.Timing)
			{
				this.DoShowTutorial(tutorialListInfo);
				return;
			}
		}
		else
		{
			this.DoShowTutorial(tutorialListInfo);
		}
	}

	// Token: 0x0600BB5F RID: 47967 RVA: 0x003733D0 File Offset: 0x003715D0
	private void DoShowTutorial(TutorialListInfo tutorialListInfo)
	{
		this.CurrentShowTutorial = tutorialListInfo;
		if (UiManager.Instance.IsViewOpen(EUiViewName.GuideTutorialTipsView))
		{
			UiManager.Instance.CloseView(EUiViewName.GuideTutorialTipsView, null);
		}
		if (this.CurrentShowTutorial.TutorialTip)
		{
			this.TryResumeTimer();
			UiManager.Instance.OpenView(EUiViewName.GuideTutorialTipsView, this.CurrentShowTutorial, null);
			return;
		}
		this.TryPauseTimer();
		this.TryShowGuideTutorialView(false);
	}

	// Token: 0x0600BB60 RID: 47968 RVA: 0x0037343C File Offset: 0x0037163C
	private UniTask ShowTutorialViewUponMultipleQueued()
	{
		GuideModel.<ShowTutorialViewUponMultipleQueued>d__27 <ShowTutorialViewUponMultipleQueued>d__;
		<ShowTutorialViewUponMultipleQueued>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowTutorialViewUponMultipleQueued>d__.<>4__this = this;
		<ShowTutorialViewUponMultipleQueued>d__.<>1__state = -1;
		<ShowTutorialViewUponMultipleQueued>d__.<>t__builder.Start<GuideModel.<ShowTutorialViewUponMultipleQueued>d__27>(ref <ShowTutorialViewUponMultipleQueued>d__);
		return <ShowTutorialViewUponMultipleQueued>d__.<>t__builder.Task;
	}

	// Token: 0x0600BB61 RID: 47969 RVA: 0x00373480 File Offset: 0x00371680
	public void TryShowGuideTutorialView(bool isFromTips = false)
	{
		if (isFromTips && this.AreMultipleTutorialsQueued())
		{
			this.ShowTutorialViewUponMultipleQueued().Forget();
			return;
		}
		TutorialListInfo currentShowTutorial = this.CurrentShowTutorial;
		if (currentShowTutorial != null && currentShowTutorial.IsOverrideGuideTutorialView)
		{
			TutorialViewParam param = new TutorialViewParam
			{
				TutorialId = new int?(this.CurrentShowTutorial.GuideId)
			};
			UiManager.Instance.OpenView(EUiViewName.TutorialView, param, delegate(bool success, int _)
			{
				this.GuideTutorialViewOpenFailed = (!success && !UiManager.Instance.IsViewOpen(EUiViewName.TutorialView));
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TutorialView);
				if (viewByName != null)
				{
					((TutorialView)viewByName).IsOpenedByGuide = true;
				}
			});
			return;
		}
		GuideConfig instance = GuideConfig.Instance;
		TutorialListInfo currentShowTutorial2 = this.CurrentShowTutorial;
		GuideTutorial? guideTutorial = instance.GetGuideTutorial((currentShowTutorial2 != null) ? currentShowTutorial2.GuideId : 0);
		EUiViewName viewName = (guideTutorial == null || guideTutorial.GetValueOrDefault().ShowLayer == 0) ? EUiViewName.GuideTutorialView : EUiViewName.GuideTutorialPopView;
		UiManager.Instance.OpenView(viewName, this.CurrentShowTutorial, delegate(bool success, int _)
		{
			this.GuideTutorialViewOpenFailed = (!success && !UiManager.Instance.IsViewOpen(viewName));
		});
	}

	// Token: 0x0600BB62 RID: 47970 RVA: 0x0037356C File Offset: 0x0037176C
	public void ShowFailedOpenTutorialView()
	{
		if (this.GuideTutorialViewOpenFailed)
		{
			this.TryShowGuideTutorialView(false);
		}
	}

	// Token: 0x0600BB63 RID: 47971 RVA: 0x00373580 File Offset: 0x00371780
	public void ClipTipState()
	{
		foreach (TutorialListInfo tutorialListInfo in this.TutorialList)
		{
			if (tutorialListInfo.TipState == ETutorialListType.Tip)
			{
				tutorialListInfo.TipState = ETutorialListType.Timing;
			}
		}
	}

	// Token: 0x0600BB64 RID: 47972 RVA: 0x003735DC File Offset: 0x003717DC
	public void RemoveCurrentTutorialInfo()
	{
		int num = this.TutorialList.IndexOf(this.CurrentShowTutorial);
		this.CurrentShowTutorial = null;
		if (num >= 0)
		{
			this.TutorialList[num].StopGuide();
			this.TutorialList.RemoveAt(num);
			this.TryPauseTimer();
		}
	}

	// Token: 0x0600BB65 RID: 47973 RVA: 0x00373629 File Offset: 0x00371829
	public bool HaveCurrentTutorial()
	{
		return this.CurrentShowTutorial != null;
	}

	// Token: 0x0600BB66 RID: 47974 RVA: 0x00373634 File Offset: 0x00371834
	public bool AreMultipleTutorialsQueued()
	{
		List<TutorialListInfo> tutorialList = this.TutorialList;
		return ((tutorialList != null) ? tutorialList.Count : 0) > 1;
	}

	// Token: 0x0600BB67 RID: 47975 RVA: 0x0037364C File Offset: 0x0037184C
	public void TryPauseTimer()
	{
		if (this.TimeHandler != null && !this.TimeHandler.IsPause() && (this.TutorialList.Count == 0 || (this.CurrentShowTutorial != null && this.CurrentShowTutorial.TipState == ETutorialListType.Pop)))
		{
			TimerSystem.GameplayTimeInstance.Pause(this.TimeHandler, null);
		}
	}

	// Token: 0x0600BB68 RID: 47976 RVA: 0x003736A4 File Offset: 0x003718A4
	private void TryResumeTimer()
	{
		if (this.TimeHandler != null && this.TimeHandler.IsPause() && this.TutorialList.Count > 0 && (this.CurrentShowTutorial == null || this.CurrentShowTutorial.TipState != ETutorialListType.Pop))
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimeHandler))
			{
				TimerSystem.GameplayTimeInstance.Resume(this.TimeHandler);
				return;
			}
			this.TimeHandler = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TutorialListCheckFunc), 20f, 1f, null, null, true);
		}
	}

	// Token: 0x0600BB69 RID: 47977 RVA: 0x00373738 File Offset: 0x00371938
	private void TutorialListCheckFunc(float delta)
	{
		for (int i = 0; i < this.TutorialList.Count; i++)
		{
			if (this.TutorialList[i].Tick(20f))
			{
				this.TutorialList.RemoveAt(i);
				this.TryPauseTimer();
				i--;
			}
		}
	}

	// Token: 0x0600BB6A RID: 47978 RVA: 0x0037378C File Offset: 0x0037198C
	public void BreakTypeViewStep(EGuideViewType type)
	{
		GuideStepInfo guideStepInfo;
		if (this.TypeViewSingletonMap.TryGetValue(type, out guideStepInfo) && guideStepInfo != null)
		{
			guideStepInfo.SwitchState(EGuideStepState.Break);
		}
		this.TypeViewSingletonMap[type] = null;
	}

	// Token: 0x0600BB6B RID: 47979 RVA: 0x003737C0 File Offset: 0x003719C0
	public void OpenGuideView(GuideStepInfo stepInfo)
	{
		int contentType = stepInfo.Config.ContentType;
		this.TypeViewSingletonMap[(EGuideViewType)contentType] = stepInfo;
		if (contentType == 4)
		{
			UiManager.Instance.OpenView(EUiViewName.GuideFocusView, stepInfo, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.GuideTipsView, stepInfo, null);
	}

	// Token: 0x0600BB6C RID: 47980 RVA: 0x00373810 File Offset: 0x00371A10
	public void RemoveStepViewSingletonMap(GuideStepInfo stepInfo)
	{
		int contentType = stepInfo.Config.ContentType;
		GuideStepInfo guideStepInfo;
		if (this.TypeViewSingletonMap.TryGetValue((EGuideViewType)contentType, out guideStepInfo) && guideStepInfo == stepInfo)
		{
			this.TypeViewSingletonMap[(EGuideViewType)contentType] = null;
		}
	}

	// Token: 0x0600BB6D RID: 47981 RVA: 0x00373850 File Offset: 0x00371A50
	public void EnsureCurrentDungeonId()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		foreach (KeyValuePair<int, GuideGroupInfo> keyValuePair in this.CurrentGroupMap)
		{
			int key = keyValuePair.Key;
			GuideGroupInfo value = keyValuePair.Value;
			if (!this.CheckDungeonAvailable(key, instanceId, false))
			{
				value.Reset();
				this.CurrentGroupMap.Remove(key);
			}
		}
		foreach (int groupId in this.DungeonResetIdList)
		{
			if (this.CheckDungeonAvailable(groupId, instanceId, false))
			{
				GuideController.Instance.ResetFinishedGuide(groupId);
			}
		}
	}

	// Token: 0x0600BB6E RID: 47982 RVA: 0x0037392C File Offset: 0x00371B2C
	public void GmResetAllGuideGroup()
	{
		this.FinishedGroupIdSet.Clear();
		this.ClearAllGroup();
	}

	// Token: 0x0600BB6F RID: 47983 RVA: 0x00373940 File Offset: 0x00371B40
	public void ClearAllGroup()
	{
		foreach (GuideGroupInfo guideGroupInfo in this.CurrentGroupMap.Values)
		{
			guideGroupInfo.Reset();
		}
		this.CurrentGroupMap.Clear();
	}

	// Token: 0x0600BB70 RID: 47984 RVA: 0x003739A0 File Offset: 0x00371BA0
	public void FinishGroup(int groupId)
	{
		GuideGroupInfo guideGroupInfo;
		if (this.CurrentGroupMap.TryGetValue(groupId, out guideGroupInfo))
		{
			guideGroupInfo.Reset();
			this.CurrentGroupMap.Remove(groupId);
		}
		this.FinishedGroupIdSet.Add(groupId);
	}

	// Token: 0x0600BB71 RID: 47985 RVA: 0x003739DD File Offset: 0x00371BDD
	public void ResetFinishedGuide(int groupId)
	{
		this.FinishedGroupIdSet.Remove(groupId);
	}

	// Token: 0x0600BB72 RID: 47986 RVA: 0x003739EC File Offset: 0x00371BEC
	public bool? IsGroupFinished(int groupId)
	{
		HashSet<int> finishedGroupIdSet = this.FinishedGroupIdSet;
		if (finishedGroupIdSet == null)
		{
			return null;
		}
		return new bool?(finishedGroupIdSet.Contains(groupId));
	}

	// Token: 0x0600BB73 RID: 47987 RVA: 0x00373A18 File Offset: 0x00371C18
	public bool CanGroupInvoke(int groupId)
	{
		return !this.IsGroupFinished(groupId).GetValueOrDefault() || this.IsGroupCanRepeat(groupId);
	}

	// Token: 0x0600BB74 RID: 47988 RVA: 0x00373A40 File Offset: 0x00371C40
	public bool IsGroupCanRepeat(int groupId)
	{
		HashSet<int> limitRepeatStepSetOfGroup = GuideConfig.Instance.GetLimitRepeatStepSetOfGroup(groupId);
		return limitRepeatStepSetOfGroup.Count == 0 || (!limitRepeatStepSetOfGroup.Contains(-1) && (!this.CheckGuideInfoExist(groupId) || !this.CurrentGroupMap[groupId].HasAnyFinishedStep(limitRepeatStepSetOfGroup)));
	}

	// Token: 0x0600BB75 RID: 47989 RVA: 0x00373A90 File Offset: 0x00371C90
	[NullableContext(2)]
	public unsafe GuideGroupInfo TryGetGuideGroup(int groupId)
	{
		if (this.CheckGuideInfoExist(groupId))
		{
			return this.CurrentGroupMap[groupId];
		}
		if (this.IsLocked())
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "引导当前处于屏蔽状态, 无法创建", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		GuideGroup? group = GuideConfig.Instance.GetGroup(groupId);
		if (group == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "引导组的客户端配置不存在, 无法创建";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (!this.CanGroupInvoke(groupId))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "引导组服务端已记录完成且未配置为可重复完成, 不能重复执行";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("组Id", groupId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, GuideGroupInfo> keyValuePair in this.CurrentGroupMap)
		{
			int key = keyValuePair.Key;
			GuideGroupInfo value = keyValuePair.Value;
			GuideGroup? group2 = GuideConfig.Instance.GetGroup(key);
			if (group2 == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Guide;
				ELogAuthor author3 = ELogAuthor.WZ;
				string message3 = "当前引导组缓存不存在客户端配置";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("组Id", key);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return null;
			}
			if (group2.Value.Priority > group.Value.Priority)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Guide;
				ELogAuthor author4 = ELogAuthor.TL;
				string message4 = "引导组当前缓存中存在更高优先级的引导, 不能触发新引导";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前组Id", groupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("高优先级组Id", key);
				instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			GuideStepInfo currentGuideStep = value.CurrentGuideStep;
			int num = (currentGuideStep != null) ? currentGuideStep.Id : 0;
			if (num == 0)
			{
				num = ((value.StepInfoList.Count > 0) ? value.StepInfoList[0].Id : 0);
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Guide;
				ELogAuthor author5 = ELogAuthor.TZJ;
				string message5 = "[TryGetGuideGroup.优先级校验] 当前引导步骤为0，使用第一个步骤Id";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("当前组Id", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("第一个步骤Id", num);
				instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			HashSet<int> breakExcludeStepIdSet = value.BreakExcludeStepIdSet;
			if (breakExcludeStepIdSet != null && breakExcludeStepIdSet.Contains(num))
			{
				list.Add(key);
			}
		}
		EGuideOnlineMode onlineMode = (EGuideOnlineMode)group.Value.OnlineMode;
		if (!GuideController.Instance.CheckAvailableWhenOnline(onlineMode))
		{
			Log instance6 = Log.Instance;
			ELogModule module6 = ELogModule.Guide;
			ELogAuthor author6 = ELogAuthor.WZ;
			string message6 = "引导组用于是否联机的情况不匹配";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("组Id", groupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("OnlineMode", onlineMode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("是否处于联机", GameModeModel.Instance.IsMulti);
			instance6.Warn(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return null;
		}
		int openLimitCondition = group.Value.OpenLimitCondition;
		if (openLimitCondition != 0 && !this.IsGmInvoke && !LevelGeneralController.Instance.CheckCondition(openLimitCondition.ToString(), null, true, Array.Empty<object>()))
		{
			Log instance7 = Log.Instance;
			ELogModule module7 = ELogModule.Guide;
			ELogAuthor author7 = ELogAuthor.TL;
			string message7 = "引导组的入队条件组不通过";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("组Id", groupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("conditionGroupId", openLimitCondition);
			instance7.Warn(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			return null;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (!this.CheckDungeonAvailable(groupId, instanceId, false))
		{
			Log instance8 = Log.Instance;
			ELogModule module8 = ELogModule.Guide;
			ELogAuthor author8 = ELogAuthor.TL;
			string message8 = "引导组的副本Id与当前所在副本不匹配";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("组Id", groupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("当前所在副本Id", instanceId);
			instance8.Warn(module8, author8, message8, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
			return null;
		}
		if (list.Count > 0)
		{
			foreach (int num2 in list)
			{
				this.CurrentGroupMap[num2].Reset();
				this.CurrentGroupMap.Remove(num2);
				Log instance9 = Log.Instance;
				ELogModule module9 = ELogModule.Guide;
				ELogAuthor author9 = ELogAuthor.TZJ;
				string message9 = "当前引导组优先级低于新引导组，且配置了BreakExcludeStepId，当前引导组被重置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("当前组Id", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("新组Id", groupId);
				instance9.Info(module9, author9, message9, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 2));
			}
		}
		GuideGroupInfo guideGroupInfo = new GuideGroupInfo(groupId);
		this.CurrentGroupMap.Add(guideGroupInfo.Id, guideGroupInfo);
		return guideGroupInfo;
	}

	// Token: 0x0600BB76 RID: 47990 RVA: 0x00374000 File Offset: 0x00372200
	public void SwitchGroupState(int groupId, EGuideGroupState groupState)
	{
		GuideGroupInfo guideGroupInfo;
		if (!this.CurrentGroupMap.TryGetValue(groupId, out guideGroupInfo))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "引导组数据未创建";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		guideGroupInfo.SwitchState(groupState);
	}

	// Token: 0x0600BB77 RID: 47991 RVA: 0x00374054 File Offset: 0x00372254
	public unsafe bool CheckGroupStatus(int groupId, EGuideGroupState targetState, string operatorStr)
	{
		if (this.FinishedGroupIdSet == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "无法判定引导组状态, 引导数据尚未初始化";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("groupId", groupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("status", targetState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("operator", operatorStr);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		if (GuideConfig.Instance.GetGroup(groupId) == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "不存在ID的引导组数据, 请策划检查配置是否有误！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("组Id", groupId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		EGuideGroupState left = EGuideGroupState.Init;
		GuideGroupInfo guideGroupInfo;
		if (this.FinishedGroupIdSet.Contains(groupId))
		{
			left = EGuideGroupState.Finishing;
		}
		else if (this.CurrentGroupMap.TryGetValue(groupId, out guideGroupInfo))
		{
			left = guideGroupInfo.StateMachine.CurrentState.Value;
		}
		return GuideModel.CheckOperator((int)left, (int)targetState, operatorStr);
	}

	// Token: 0x0600BB78 RID: 47992 RVA: 0x00374168 File Offset: 0x00372368
	private static bool CheckOperator(int left, int right, string operatorStr)
	{
		if (operatorStr == "")
		{
			return left == right;
		}
		if (operatorStr == "!=")
		{
			return left != right;
		}
		if (operatorStr == ">")
		{
			return left > right;
		}
		if (operatorStr == ">=")
		{
			return left >= right;
		}
		if (operatorStr == "<")
		{
			return left < right;
		}
		return operatorStr == "<=" && left <= right;
	}

	// Token: 0x0600BB79 RID: 47993 RVA: 0x003741EC File Offset: 0x003723EC
	protected override bool OnClear()
	{
		this.FinishedGroupIdSet.Clear();
		this.CurrentGroupMap.Clear();
		this.DungeonResetIdList.Clear();
		this.FocusGroupMapByView.Clear();
		if (this.TutorialList != null)
		{
			this.TutorialList.Clear();
		}
		if (this.TimeHandler != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimeHandler);
		}
		this.FinishedGroupIdSet = null;
		this.CurrentGroupMap = null;
		this.DungeonResetIdList = null;
		this.TutorialList = null;
		this.CurrentShowTutorial = null;
		this.TimeHandler = null;
		this.GuideTutorialViewOpenFailed = false;
		return true;
	}

	// Token: 0x0600BB7A RID: 47994 RVA: 0x00374284 File Offset: 0x00372484
	public int[] GetRunningGroupIdList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, GuideGroupInfo> keyValuePair in this.CurrentGroupMap)
		{
			int key = keyValuePair.Key;
			if (keyValuePair.Value.CheckIsGuideRunning())
			{
				list.Add(key);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600BB7B RID: 47995 RVA: 0x003742FC File Offset: 0x003724FC
	public int[] GetRunningWithoutPendingGroupIdList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, GuideGroupInfo> keyValuePair in this.CurrentGroupMap)
		{
			int key = keyValuePair.Key;
			if (keyValuePair.Value.CheckIsGuideRunningWithoutPending())
			{
				list.Add(key);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600BB7C RID: 47996 RVA: 0x00374374 File Offset: 0x00372574
	public unsafe void AddFocusGuideGroupToView(GuideGroupInfo group)
	{
		GuideGroupInfo group2 = group;
		if (((group2 != null) ? group2.CurrentGuideStep : null) == null || group.CurrentGuideStep.Config.ContentType != 4)
		{
			return;
		}
		GuideFocusNew? guideFocus = GuideConfig.Instance.GetGuideFocus(group.CurrentGuideStep.Id);
		if (guideFocus == null)
		{
			return;
		}
		string guideFocusTargetViewName = GuideTestUtil.GetGuideFocusTargetViewName(guideFocus.Value.ViewName, group.CurrentGuideStep.Id);
		if (!this.FocusGroupMapByView.ContainsKey((EUiViewName)guideFocusTargetViewName))
		{
			this.FocusGroupMapByView.Add((EUiViewName)guideFocusTargetViewName, new List<GuideGroupInfo>
			{
				group
			});
			return;
		}
		List<GuideGroupInfo> list = this.FocusGroupMapByView[(EUiViewName)guideFocusTargetViewName];
		if (list.Exists((GuideGroupInfo g) => g.Id == group.Id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "尝试添加已存在的引导组到View";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("组Id", group.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("View", guideFocusTargetViewName);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		list.Add(group);
	}

	// Token: 0x0600BB7D RID: 47997 RVA: 0x003744DC File Offset: 0x003726DC
	public unsafe void RemoveFocusGuideGroupFromView(GuideGroupInfo group)
	{
		GuideGroupInfo group2 = group;
		if (((group2 != null) ? group2.CurrentGuideStep : null) == null || group.CurrentGuideStep.Config.ContentType != 4)
		{
			return;
		}
		GuideFocusNew? guideFocus = GuideConfig.Instance.GetGuideFocus(group.CurrentGuideStep.Id);
		if (guideFocus == null)
		{
			return;
		}
		string guideFocusTargetViewName = GuideTestUtil.GetGuideFocusTargetViewName(guideFocus.Value.ViewName, group.CurrentGuideStep.Id);
		if (!this.FocusGroupMapByView.ContainsKey((EUiViewName)guideFocusTargetViewName))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "尝试从不存在的View中移除引导组";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("组Id", group.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("View", guideFocusTargetViewName);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		List<GuideGroupInfo> list = this.FocusGroupMapByView[(EUiViewName)guideFocusTargetViewName];
		int num = list.FindIndex((GuideGroupInfo g) => g.Id == group.Id);
		if (num >= 0)
		{
			list.RemoveAt(num);
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Guide;
		ELogAuthor author2 = ELogAuthor.HYF;
		string message2 = "尝试从View中移除不存在的引导组";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("组Id", group.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("View", guideFocusTargetViewName);
		instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
	}

	// Token: 0x0600BB7E RID: 47998 RVA: 0x00374684 File Offset: 0x00372884
	public void FinishFocusGuideGroupOnView(EUiViewName viewName)
	{
		List<GuideGroupInfo> list;
		if (!this.FocusGroupMapByView.TryGetValue(viewName, out list) || list.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "尝试结束不存在的引导组";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("View", viewName);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			GuideGroupInfo guideGroupInfo = list[i];
			this.FinishGroup(guideGroupInfo.Id);
		}
		this.FocusGroupMapByView.Remove(viewName);
	}

	// Token: 0x0600BB7F RID: 47999 RVA: 0x00374708 File Offset: 0x00372908
	public bool HasFocusGuideGroupOnView(EUiViewName viewName)
	{
		List<GuideGroupInfo> list;
		return this.FocusGroupMapByView.TryGetValue(viewName, out list) && list.Count > 0;
	}

	// Token: 0x0600BB80 RID: 48000 RVA: 0x00374730 File Offset: 0x00372930
	private int[] GetAvailableDungeonIdList(int groupId)
	{
		GuideGroup? group = GuideConfig.Instance.GetGroup(groupId);
		if (group == null)
		{
			return Array.Empty<int>();
		}
		if (group.Value.DungeonSets() == null || group.Value.DungeonSets().Length == 0)
		{
			return group.Value.GetDungeonIdArray();
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (string setId in group.Value.DungeonSets())
		{
			GuideDungeonSetDefine? guideDungeonSet = GuideConfig.Instance.GetGuideDungeonSet(setId);
			if (guideDungeonSet != null)
			{
				foreach (int item in guideDungeonSet.Value.DungeonIdList())
				{
					hashSet.Add(item);
				}
			}
		}
		int[] array3 = new int[hashSet.Count];
		hashSet.CopyTo(array3);
		return array3;
	}

	// Token: 0x0600BB81 RID: 48001 RVA: 0x0037481C File Offset: 0x00372A1C
	public bool CheckDungeonAvailable(int groupId, int dungeonId, bool log = false)
	{
		if (GuideTestUtil.CheckIsTestGroup(groupId))
		{
			return true;
		}
		GuideGroup? group = GuideConfig.Instance.GetGroup(groupId);
		if (group == null)
		{
			return false;
		}
		if (group.Value.DungeonSets() == null || group.Value.DungeonSets().Length == 0)
		{
			return Array.IndexOf<int>(group.Value.DungeonId(), dungeonId) >= 0;
		}
		foreach (string setId in group.Value.DungeonSets())
		{
			GuideDungeonSetDefine? guideDungeonSet = GuideConfig.Instance.GetGuideDungeonSet(setId);
			if (guideDungeonSet != null && GuideModel.CheckDungeonAvailableBySet(guideDungeonSet.Value, dungeonId, log))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BB82 RID: 48002 RVA: 0x003748D8 File Offset: 0x00372AD8
	public bool CheckDungeonAvailableForSetDefine(string setDefineId, int dungeonId, bool log = false)
	{
		GuideDungeonSetDefine? guideDungeonSet = GuideConfig.Instance.GetGuideDungeonSet(setDefineId);
		return guideDungeonSet != null && GuideModel.CheckDungeonAvailableBySet(guideDungeonSet.Value, dungeonId, log);
	}

	// Token: 0x0600BB83 RID: 48003 RVA: 0x00374914 File Offset: 0x00372B14
	private static bool CheckDungeonAvailableBySet(GuideDungeonSetDefine setConfig, int dungeonId, bool log = false)
	{
		for (int i = 0; i < setConfig.ExcludeIdListLength; i++)
		{
			if (setConfig.ExcludeIdList(i) == dungeonId)
			{
				return false;
			}
		}
		for (int j = 0; j < setConfig.DungeonIdListLength; j++)
		{
			if (setConfig.DungeonIdList(j) == dungeonId)
			{
				return true;
			}
		}
		InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(dungeonId) : null;
		if (instanceDungeon == null)
		{
			return false;
		}
		for (int k = 0; k < setConfig.DungeonTypeSetListLength; k++)
		{
			GuideDungeonTypeSet? config = ConfigGuideDungeonTypeSetById.GetConfig(setConfig.DungeonTypeSetList(k), true);
			if (config != null && config.Value.InstType == instanceDungeon.Value.InstType && config.Value.InstSubType == instanceDungeon.Value.InstSubType)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x1700129D RID: 4765
	// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x00374A04 File Offset: 0x00372C04
	public static GuideModel Instance
	{
		get
		{
			return GuideModel._Instance;
		}
	}

	// Token: 0x0600BB85 RID: 48005 RVA: 0x00374A0B File Offset: 0x00372C0B
	public static GuideModel GetOrCreateInstance()
	{
		if (GuideModel._Instance == null)
		{
			GuideModel.CreateInstance();
		}
		return GuideModel._Instance;
	}

	// Token: 0x0600BB86 RID: 48006 RVA: 0x00374A1F File Offset: 0x00372C1F
	public static bool CreateInstance()
	{
		if (GuideModel._Instance != null)
		{
			return true;
		}
		GuideModel._Instance = new GuideModel();
		return true;
	}

	// Token: 0x0600BB87 RID: 48007 RVA: 0x00374A35 File Offset: 0x00372C35
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BB88 RID: 48008 RVA: 0x00374A37 File Offset: 0x00372C37
	public static void ResetStaticDefaultValue()
	{
		GuideModel._Instance = null;
	}

	// Token: 0x0600BB89 RID: 48009 RVA: 0x00374A3F File Offset: 0x00372C3F
	static GuideModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideModel.CreateStaticDefaultValue), new Action(GuideModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006BD7 RID: 27607
	public bool IsLock;

	// Token: 0x04006BD8 RID: 27608
	public bool IsGmLock;

	// Token: 0x04006BD9 RID: 27609
	public bool IsGmInvoke;

	// Token: 0x04006BDA RID: 27610
	public bool ShouldBlockGuideBecauseUiNotRender;

	// Token: 0x04006BDB RID: 27611
	[Nullable(2)]
	private HashSet<int> DungeonResetIdList;

	// Token: 0x04006BDC RID: 27612
	[Nullable(2)]
	private HashSet<int> FinishedGroupIdSet;

	// Token: 0x04006BDD RID: 27613
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, GuideGroupInfo> CurrentGroupMap;

	// Token: 0x04006BDE RID: 27614
	public Dictionary<EUiViewName, List<GuideGroupInfo>> FocusGroupMapByView;

	// Token: 0x04006BDF RID: 27615
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<TutorialListInfo> TutorialList;

	// Token: 0x04006BE0 RID: 27616
	[Nullable(2)]
	private TimerHandle TimeHandler;

	// Token: 0x04006BE1 RID: 27617
	[Nullable(2)]
	private TutorialListInfo CurrentShowTutorial;

	// Token: 0x04006BE2 RID: 27618
	private bool GuideTutorialViewOpenFailed;

	// Token: 0x04006BE3 RID: 27619
	[Nullable(2)]
	private Dictionary<EGuideViewType, GuideStepInfo> TypeViewSingletonMap;

	// Token: 0x04006BE4 RID: 27620
	private int LockingInputGuideStepCount;

	// Token: 0x04006BE5 RID: 27621
	[Nullable(2)]
	private static GuideModel _Instance;
}
