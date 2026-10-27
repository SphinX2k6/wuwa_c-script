using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DCA RID: 7626
public class GuideTipsView : GuideBaseView
{
	// Token: 0x0600E800 RID: 59392 RVA: 0x0036D1C4 File Offset: 0x0036B3C4
	[NullableContext(1)]
	public GuideTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E801 RID: 59393 RVA: 0x0036D1D4 File Offset: 0x0036B3D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E802 RID: 59394 RVA: 0x0036D2C1 File Offset: 0x0036B4C1
	protected override void OnGuideBaseViewAddEvent()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
	}

	// Token: 0x0600E803 RID: 59395 RVA: 0x0036D2DF File Offset: 0x0036B4DF
	protected override void OnGuideBaseViewRemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
	}

	// Token: 0x0600E804 RID: 59396 RVA: 0x0036D300 File Offset: 0x0036B500
	protected override void OnGuideBaseViewAfterHide()
	{
		base.UnbindInput(this.Config.Value.InputEnums(), this.Config.Value.InputEnums());
		if (this.UiViewSequence.HasSequenceNameInPlaying("Start"))
		{
			this.UiViewSequence.StopPrevSequence(true, true);
		}
	}

	// Token: 0x0600E805 RID: 59397 RVA: 0x0036D358 File Offset: 0x0036B558
	protected override void OnBeforeGuideBaseViewCreate()
	{
		this.Config = new GuideTips?((GuideTips)this.GuideStepInfo.ViewData.ViewConf);
		List<string> list = new List<string>(this.Config.Value.InputEnumsIter());
		base.BindInput(list, list, new TInputHandle<float>(this.ProcessInput));
	}

	// Token: 0x0600E806 RID: 59398 RVA: 0x0036D3B4 File Offset: 0x0036B5B4
	protected override void OnGuideBaseViewStart()
	{
		UUIText text = base.GetText(2);
		text.SetUIActive(false);
		text.SetUIActive(true);
		new GuideDescribeNew(text).SetUpText(this.Config.Value.Content, this.Config.Value.Button());
		GuidePrefabDefine.setPrefabText(text, text.GetText());
		UUIItem item = base.GetItem(4);
		float num = MathCommon.Clamp((float)this.Config.Value.UseMask / 100f, 0f, 1f);
		item.SetAlpha(num);
		item.SetRaycastTarget(num > 0f);
	}

	// Token: 0x0600E807 RID: 59399 RVA: 0x0036D458 File Offset: 0x0036B658
	protected override void OnGuideViewAfterShow()
	{
		UUIItem item = base.GetItem(3);
		if (base.TotalDuration > 0f)
		{
			this.CountDownItem = new GuideCountDownItem(base.TotalDuration);
			this.CountDownItem.Init(item);
		}
		else
		{
			item.SetUIActive(false);
		}
		base.BindInput(new List<string>(this.Config.Value.InputEnumsIter()), new List<string>(this.Config.Value.InputEnumsIter()), new TInputHandle<float>(this.ProcessInput));
	}

	// Token: 0x0600E808 RID: 59400 RVA: 0x0036D4E4 File Offset: 0x0036B6E4
	protected override UniTask OnBeforeHideAsync()
	{
		GuideTipsView.<OnBeforeHideAsync>d__13 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<GuideTipsView.<OnBeforeHideAsync>d__13>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E809 RID: 59401 RVA: 0x0036D528 File Offset: 0x0036B728
	protected override void OnGuideBaseViewTick(float delta)
	{
		bool flag = this.IsAllowedViewShow() && BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.GuideTipsView) && !base.HasConflictView();
		if (!base.IsBusy && flag != this.IsBattleViewReady)
		{
			this.IsBattleViewReady = flag;
			this.SetActive(flag);
		}
	}

	// Token: 0x0600E80A RID: 59402 RVA: 0x0036D57C File Offset: 0x0036B77C
	protected override void OnAfterPlayStartSequence()
	{
		if (!this.Config.Value.UseLoopAnim)
		{
			this.UiViewSequence.StopSequenceByKey("AutoLoop1", false, false);
			return;
		}
		this.UiViewSequence.PlaySequence("AutoLoop1", false, null);
	}

	// Token: 0x0600E80B RID: 59403 RVA: 0x0036D5CC File Offset: 0x0036B7CC
	private void OnShowMouseCursor(bool isOn)
	{
		InputDistributeController.Instance.RefreshInputTag();
		if (!isOn || UiManager.Instance.IsViewShow(EUiViewName.GmView))
		{
			return;
		}
		if (this.IsAllowedViewShow() && this.GuideStepInfo.Config.TimeScale < 1f)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			characterController.bShowMouseCursor = false;
			this.SetGameOnlyInputMode();
		}
	}

	// Token: 0x0600E80C RID: 59404 RVA: 0x0036D634 File Offset: 0x0036B834
	private void SetGameOnlyInputMode()
	{
		TsCharacterController characterController = Global.CharacterController;
		if (this.InputModeReply == null && !UKuroInputFunctionLibrary.HasInputModeReply(this.InputModeReply))
		{
			this.InputModeReply = UKuroInputFunctionLibrary.SetGameOnlyInputMode(characterController, "GuideTipsView设置输入模式");
		}
	}

	// Token: 0x0600E80D RID: 59405 RVA: 0x0036D673 File Offset: 0x0036B873
	private void ReplyGameOnlyInputMode()
	{
		if (this.InputModeReply != null)
		{
			UKuroInputFunctionLibrary.ReplyInputMode(Global.CharacterController, this.InputModeReply);
			this.InputModeReply = null;
		}
	}

	// Token: 0x0600E80E RID: 59406 RVA: 0x0036D69C File Offset: 0x0036B89C
	[NullableContext(1)]
	private void ProcessInput([Nullable(2)] string name, float value, InputIdentification _)
	{
		if (name != null)
		{
			this.CombineInputMap[name] = value;
			if (!base.IsAllCombineInputPass())
			{
				return;
			}
		}
		base.UnbindInput(this.Config.Value.InputEnums(), this.Config.Value.InputEnums());
		base.DoCloseByFinished();
	}

	// Token: 0x0600E80F RID: 59407 RVA: 0x0036D6F4 File Offset: 0x0036B8F4
	protected override void OnDurationChange(float remainDuration)
	{
		if (this.CountDownItem != null)
		{
			this.CountDownItem.OnDurationChange(remainDuration);
		}
	}

	// Token: 0x0600E810 RID: 59408 RVA: 0x0036D70C File Offset: 0x0036B90C
	private bool IsAllowedViewShow()
	{
		foreach (EUiViewName name in GuideDefine.guideTipsAllowedViews)
		{
			if (UiManager.Instance.IsViewShow(name))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04006B56 RID: 27478
	private GuideTips? Config;

	// Token: 0x04006B57 RID: 27479
	[Nullable(2)]
	private GuideCountDownItem CountDownItem;

	// Token: 0x04006B58 RID: 27480
	private bool IsBattleViewReady = true;

	// Token: 0x04006B59 RID: 27481
	[Nullable(2)]
	private FInputModeReply InputModeReply;

	// Token: 0x020083A7 RID: 33703
	private enum EGuideTipsView
	{
		// Token: 0x0402AE0E RID: 175630
		UiItemTips,
		// Token: 0x0402AE0F RID: 175631
		ToggleIcon,
		// Token: 0x0402AE10 RID: 175632
		GuideDescNew,
		// Token: 0x0402AE11 RID: 175633
		CountDownItem,
		// Token: 0x0402AE12 RID: 175634
		UiItemBlackBg,
		// Token: 0x0402AE13 RID: 175635
		IconParent
	}
}
