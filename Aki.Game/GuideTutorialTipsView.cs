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

// Token: 0x02001DCC RID: 7628
public class GuideTutorialTipsView : UiTickViewBase, IStaticVariableResetter
{
	// Token: 0x0600E819 RID: 59417 RVA: 0x0036D9D1 File Offset: 0x0036BBD1
	static GuideTutorialTipsView()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideTutorialTipsView.CreateStaticDefaultValue), new Action(GuideTutorialTipsView.ResetStaticDefaultValue));
	}

	// Token: 0x0600E81A RID: 59418 RVA: 0x0036D9F0 File Offset: 0x0036BBF0
	public static void CreateStaticDefaultValue()
	{
		GuideTutorialTipsView.RealProcessLock = false;
		GuideTutorialTipsView.BackupTimerHandle = null;
	}

	// Token: 0x0600E81B RID: 59419 RVA: 0x0036D9FE File Offset: 0x0036BBFE
	public static void ResetStaticDefaultValue()
	{
		GuideTutorialTipsView.RealProcessLock = false;
		GuideTutorialTipsView.BackupTimerHandle = null;
	}

	// Token: 0x0600E81C RID: 59420 RVA: 0x0036DA0C File Offset: 0x0036BC0C
	[NullableContext(1)]
	public GuideTutorialTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E81D RID: 59421 RVA: 0x0036DA18 File Offset: 0x0036BC18
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

	// Token: 0x0600E81E RID: 59422 RVA: 0x0036DB24 File Offset: 0x0036BD24
	protected override UniTask OnCreateAsync()
	{
		GuideTutorialTipsView.<OnCreateAsync>d__13 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<GuideTutorialTipsView.<OnCreateAsync>d__13>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E81F RID: 59423 RVA: 0x0036DB68 File Offset: 0x0036BD68
	private void OpenGuideTutorialView()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null && rootItem.bIsUIActive && !LoadingModel.Instance.IsLoadingView)
		{
			this.TutorialInfo.ClickToPopState();
			this.UiViewSequence.PlaySequence("CloseTips", true, null);
		}
	}

	// Token: 0x0600E820 RID: 59424 RVA: 0x0036DBBC File Offset: 0x0036BDBC
	[NullableContext(1)]
	private void OnStartSequenceEnd(string _)
	{
		this.TutorialInfo.TipState = ETutorialListType.Timing;
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
		{
			GuideModel.Instance.TryShowTutorial();
		});
	}

	// Token: 0x0600E821 RID: 59425 RVA: 0x0036DC09 File Offset: 0x0036BE09
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

	// Token: 0x0600E822 RID: 59426 RVA: 0x0036DC48 File Offset: 0x0036BE48
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

	// Token: 0x0600E823 RID: 59427 RVA: 0x0036DD64 File Offset: 0x0036BF64
	protected override void OnAfterShow()
	{
		if (this.TutorialInfo.TipState == ETutorialListType.Tip)
		{
			this.UiViewSequence.PlaySequence("StartTips", false, null);
			return;
		}
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
	}

	// Token: 0x0600E824 RID: 59428 RVA: 0x0036DDB4 File Offset: 0x0036BFB4
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

	// Token: 0x0600E825 RID: 59429 RVA: 0x0036DE10 File Offset: 0x0036C010
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

	// Token: 0x0600E826 RID: 59430 RVA: 0x0036DE41 File Offset: 0x0036C041
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.HideHUD, new Action(this.OnBattleViewChange));
		EventSystem.Instance.Add(EEventName.ShowHUD, new Action(this.OnBattleViewChange));
	}

	// Token: 0x0600E827 RID: 59431 RVA: 0x0036DE7B File Offset: 0x0036C07B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.HideHUD, new Action(this.OnBattleViewChange));
		EventSystem.Instance.Remove(EEventName.ShowHUD, new Action(this.OnBattleViewChange));
	}

	// Token: 0x0600E828 RID: 59432 RVA: 0x0036DEB5 File Offset: 0x0036C0B5
	private void OnBattleViewChange()
	{
		this.SetActive(UiManager.Instance.IsViewShow(EUiViewName.BattleView));
	}

	// Token: 0x0600E829 RID: 59433 RVA: 0x0036DECC File Offset: 0x0036C0CC
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

	// Token: 0x0600E82A RID: 59434 RVA: 0x0036DF58 File Offset: 0x0036C158
	private void OnTutorialHaveFinished()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
		{
			TutorialController.Instance.TryOpenAwardUiViewPending();
			GuideModel.Instance.TryShowTutorial();
		});
	}

	// Token: 0x04006B5C RID: 27484
	[Nullable(2)]
	public TutorialListInfo TutorialInfo;

	// Token: 0x04006B5D RID: 27485
	private GuideTutorial? ViewConf;

	// Token: 0x04006B5E RID: 27486
	private int TotalDuration;

	// Token: 0x04006B5F RID: 27487
	[Nullable(2)]
	private ULGUISpriteData_BaseObject TypeIconSprite;

	// Token: 0x04006B60 RID: 27488
	private static bool RealProcessLock;

	// Token: 0x04006B61 RID: 27489
	private const int BackupDuration = 5000;

	// Token: 0x04006B62 RID: 27490
	[Nullable(2)]
	private static TimerHandle BackupTimerHandle;

	// Token: 0x020083AA RID: 33706
	private enum EGuideTutorialTipsView
	{
		// Token: 0x0402AE1E RID: 175646
		TxtName,
		// Token: 0x0402AE1F RID: 175647
		TutorialTypeTex,
		// Token: 0x0402AE20 RID: 175648
		TutorialBtn,
		// Token: 0x0402AE21 RID: 175649
		TimerSlider,
		// Token: 0x0402AE22 RID: 175650
		TxtEvent
	}

	// Token: 0x020083AB RID: 33707
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402AE23 RID: 175651
		public static TTimerAction <0>__ExecuteRealBeforeDestroy;
	}
}
