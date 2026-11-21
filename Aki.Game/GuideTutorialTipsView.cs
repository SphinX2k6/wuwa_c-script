using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200128E RID: 4750
public class GuideTutorialTipsView : UiTickViewBase, IStaticVariableResetter
{
	// Token: 0x0600BC38 RID: 48184 RVA: 0x003796D1 File Offset: 0x003778D1
	static GuideTutorialTipsView()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideTutorialTipsView.CreateStaticDefaultValue), new Action(GuideTutorialTipsView.ResetStaticDefaultValue));
	}

	// Token: 0x0600BC39 RID: 48185 RVA: 0x003796F0 File Offset: 0x003778F0
	public static void CreateStaticDefaultValue()
	{
		GuideTutorialTipsView.RealProcessLock = false;
		GuideTutorialTipsView.BackupTimerHandle = null;
	}

	// Token: 0x0600BC3A RID: 48186 RVA: 0x003796FE File Offset: 0x003778FE
	public static void ResetStaticDefaultValue()
	{
		GuideTutorialTipsView.RealProcessLock = false;
		GuideTutorialTipsView.BackupTimerHandle = null;
	}

	// Token: 0x0600BC3B RID: 48187 RVA: 0x0037970C File Offset: 0x0037790C
	[NullableContext(1)]
	public GuideTutorialTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BC3C RID: 48188 RVA: 0x00379718 File Offset: 0x00377918
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OpenGuideTutorialView));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BC3D RID: 48189 RVA: 0x00379824 File Offset: 0x00377A24
	protected override UniTask OnCreateAsync()
	{
		GuideTutorialTipsView.<OnCreateAsync>d__13 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<GuideTutorialTipsView.<OnCreateAsync>d__13>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BC3E RID: 48190 RVA: 0x00379868 File Offset: 0x00377A68
	private void OpenGuideTutorialView()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null && rootItem.bIsUIActive && !LoadingModel.Instance.IsLoadingView)
		{
			this.TutorialInfo.ClickToPopState();
			this.UiViewSequence.PlaySequence("CloseTips", true, null);
		}
	}

	// Token: 0x0600BC3F RID: 48191 RVA: 0x003798BC File Offset: 0x00377ABC
	[NullableContext(1)]
	private void OnStartSequenceEnd(string _)
	{
		this.TutorialInfo.TipState = ETutorialListType.Timing;
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
		{
			GuideModel.Instance.TryShowTutorial();
		});
	}

	// Token: 0x0600BC40 RID: 48192 RVA: 0x00379909 File Offset: 0x00377B09
	[NullableContext(1)]
	private void OnFinishSequenceEnd(string _)
	{
		if (this.TutorialInfo.TipState == ETutorialListType.Pop)
		{
			base.CloseMe(delegate(bool _)
			{
				GuideModel.Instance.TryShowGuideTutorialView(true);
			});
			return;
		}
		this.OnTutorialHaveFinished();
	}

	// Token: 0x0600BC41 RID: 48193 RVA: 0x00379948 File Offset: 0x00377B48
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (this.ViewConf == null)
		{
			if (!this.WaitToDestroy)
			{
				this.OnTutorialHaveFinished();
			}
			return;
		}
		string groupName = this.ViewConf.Value.GroupName;
		LguiUtil.Instance.SetLocalTextNew(text, groupName, Array.Empty<object>());
		if (this.TypeIconSprite != null)
		{
			base.GetSprite(1).SetSprite(this.TypeIconSprite, true);
		}
		string tutorialTypeTxt = TutorialUtils.GetTutorialTypeTxt((ETutorialType)this.ViewConf.Value.TutorialType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), tutorialTypeTxt, Array.Empty<object>());
		base.GetSprite(3).SetFillAmount(1f);
		this.UiViewSequence.AddSequenceFinishEvent("StartTips", new Action<string>(this.OnStartSequenceEnd), false);
		this.UiViewSequence.AddSequenceFinishEvent("CloseTips", new Action<string>(this.OnFinishSequenceEnd), false);
		if (!GuideTutorialTipsView.RealProcessLock)
		{
			GuideTutorialTipsView.RealProcessLock = true;
			TutorialController.Instance.OnTutorialTipExistChanged(true);
		}
		TimerHandle backupTimerHandle = GuideTutorialTipsView.BackupTimerHandle;
		if (backupTimerHandle != null)
		{
			backupTimerHandle.Remove();
		}
		GuideTutorialTipsView.BackupTimerHandle = null;
	}

	// Token: 0x0600BC42 RID: 48194 RVA: 0x00379A64 File Offset: 0x00377C64
	protected override void OnAfterShow()
	{
		if (this.TutorialInfo.TipState == ETutorialListType.Tip)
		{
			this.UiViewSequence.PlaySequence("StartTips", false, null);
			return;
		}
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
	}

	// Token: 0x0600BC43 RID: 48195 RVA: 0x00379AB4 File Offset: 0x00377CB4
	protected override void OnBeforeDestroy()
	{
		if (this.TutorialInfo.TipState == ETutorialListType.Tip)
		{
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = GuideTutorialTipsView.<>O.<0>__ExecuteRealBeforeDestroy) == null)
			{
				action = (GuideTutorialTipsView.<>O.<0>__ExecuteRealBeforeDestroy = new TTimerAction(GuideTutorialTipsView.ExecuteRealBeforeDestroy));
			}
			GuideTutorialTipsView.BackupTimerHandle = gameplayTimeInstance.Delay(action, 5000f, null, null, true, 1f);
			return;
		}
		GuideTutorialTipsView.ExecuteRealBeforeDestroy(0f);
	}

	// Token: 0x0600BC44 RID: 48196 RVA: 0x00379B10 File Offset: 0x00377D10
	private static void ExecuteRealBeforeDestroy(float deltaTime)
	{
		if (GuideTutorialTipsView.RealProcessLock)
		{
			TutorialController.Instance.OnTutorialTipExistChanged(false);
			GuideTutorialTipsView.RealProcessLock = false;
		}
		TimerHandle backupTimerHandle = GuideTutorialTipsView.BackupTimerHandle;
		if (backupTimerHandle != null)
		{
			backupTimerHandle.Remove();
		}
		GuideTutorialTipsView.BackupTimerHandle = null;
	}

	// Token: 0x0600BC45 RID: 48197 RVA: 0x00379B41 File Offset: 0x00377D41
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.HideHUD, new Action(this.OnBattleViewChange));
		EventSystem.Instance.Add(EEventName.ShowHUD, new Action(this.OnBattleViewChange));
	}

	// Token: 0x0600BC46 RID: 48198 RVA: 0x00379B7B File Offset: 0x00377D7B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.HideHUD, new Action(this.OnBattleViewChange));
		EventSystem.Instance.Remove(EEventName.ShowHUD, new Action(this.OnBattleViewChange));
	}

	// Token: 0x0600BC47 RID: 48199 RVA: 0x00379BB5 File Offset: 0x00377DB5
	private void OnBattleViewChange()
	{
		this.SetActive(UiManager.Instance.IsViewShow(EUiViewName.BattleView));
	}

	// Token: 0x0600BC48 RID: 48200 RVA: 0x00379BCC File Offset: 0x00377DCC
	protected override void OnTick(float delta)
	{
		if (base.IsShow)
		{
			float fillAmount = this.TutorialInfo.Duration / (float)this.TotalDuration;
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetFillAmount(fillAmount);
			}
			if (this.TutorialInfo.Duration <= 0f && this.UiViewSequence.CurrentSequenceName != "CloseTips")
			{
				this.UiViewSequence.StopPrevSequence(false, false);
				this.UiViewSequence.PlaySequence("CloseTips", true, null);
			}
		}
	}

	// Token: 0x0600BC49 RID: 48201 RVA: 0x00379C58 File Offset: 0x00377E58
	private void OnTutorialHaveFinished()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
		{
			TutorialController.Instance.TryOpenAwardUiViewPending();
			GuideModel.Instance.TryShowTutorial();
		});
	}

	// Token: 0x04006C3D RID: 27709
	[Nullable(2)]
	public TutorialListInfo TutorialInfo;

	// Token: 0x04006C3E RID: 27710
	private GuideTutorial? ViewConf;

	// Token: 0x04006C3F RID: 27711
	private int TotalDuration;

	// Token: 0x04006C40 RID: 27712
	[Nullable(2)]
	private ULGUISpriteData_BaseObject TypeIconSprite;

	// Token: 0x04006C41 RID: 27713
	private static bool RealProcessLock;

	// Token: 0x04006C42 RID: 27714
	private const int BackupDuration = 5000;

	// Token: 0x04006C43 RID: 27715
	[Nullable(2)]
	private static TimerHandle BackupTimerHandle;

	// Token: 0x02007531 RID: 30001
	private enum EGuideTutorialTipsView
	{
		// Token: 0x04026143 RID: 155971
		TxtName,
		// Token: 0x04026144 RID: 155972
		TutorialTypeTex,
		// Token: 0x04026145 RID: 155973
		TutorialBtn,
		// Token: 0x04026146 RID: 155974
		TimerSlider,
		// Token: 0x04026147 RID: 155975
		TxtEvent
	}

	// Token: 0x02007532 RID: 30002
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026148 RID: 155976
		public static TTimerAction <0>__ExecuteRealBeforeDestroy;
	}
}
