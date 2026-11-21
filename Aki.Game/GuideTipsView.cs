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

// Token: 0x0200128C RID: 4748
public class GuideTipsView : GuideBaseView
{
	// Token: 0x0600BC1F RID: 48159 RVA: 0x00378EC4 File Offset: 0x003770C4
	[NullableContext(1)]
	public GuideTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BC20 RID: 48160 RVA: 0x00378ED4 File Offset: 0x003770D4
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

	// Token: 0x0600BC21 RID: 48161 RVA: 0x00378FC1 File Offset: 0x003771C1
	protected override void OnGuideBaseViewAddEvent()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
	}

	// Token: 0x0600BC22 RID: 48162 RVA: 0x00378FDF File Offset: 0x003771DF
	protected override void OnGuideBaseViewRemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
	}

	// Token: 0x0600BC23 RID: 48163 RVA: 0x00379000 File Offset: 0x00377200
	protected override void OnGuideBaseViewAfterHide()
	{
		base.UnbindInput(this.Config.Value.InputEnums(), this.Config.Value.InputEnums());
		if (this.UiViewSequence.HasSequenceNameInPlaying("Start"))
		{
			this.UiViewSequence.StopPrevSequence(true, true);
		}
	}

	// Token: 0x0600BC24 RID: 48164 RVA: 0x00379058 File Offset: 0x00377258
	protected override void OnBeforeGuideBaseViewCreate()
	{
		this.Config = new GuideTips?((GuideTips)this.GuideStepInfo.ViewData.ViewConf);
		List<string> list = new List<string>(this.Config.Value.InputEnumsIter());
		base.BindInput(list, list, new TInputHandle<float>(this.ProcessInput));
	}

	// Token: 0x0600BC25 RID: 48165 RVA: 0x003790B4 File Offset: 0x003772B4
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

	// Token: 0x0600BC26 RID: 48166 RVA: 0x00379158 File Offset: 0x00377358
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

	// Token: 0x0600BC27 RID: 48167 RVA: 0x003791E4 File Offset: 0x003773E4
	protected override UniTask OnBeforeHideAsync()
	{
		GuideTipsView.<OnBeforeHideAsync>d__13 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<GuideTipsView.<OnBeforeHideAsync>d__13>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BC28 RID: 48168 RVA: 0x00379228 File Offset: 0x00377428
	protected override void OnGuideBaseViewTick(float delta)
	{
		bool flag = this.IsAllowedViewShow() && BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.GuideTipsView) && !base.HasConflictView();
		if (!base.IsBusy && flag != this.IsBattleViewReady)
		{
			this.IsBattleViewReady = flag;
			this.SetActive(flag);
		}
	}

	// Token: 0x0600BC29 RID: 48169 RVA: 0x0037927C File Offset: 0x0037747C
	protected override void OnAfterPlayStartSequence()
	{
		if (!this.Config.Value.UseLoopAnim)
		{
			this.UiViewSequence.StopSequenceByKey("AutoLoop1", false, false);
			return;
		}
		this.UiViewSequence.PlaySequence("AutoLoop1", false, null);
	}

	// Token: 0x0600BC2A RID: 48170 RVA: 0x003792CC File Offset: 0x003774CC
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

	// Token: 0x0600BC2B RID: 48171 RVA: 0x00379334 File Offset: 0x00377534
	private void SetGameOnlyInputMode()
	{
		TsCharacterController characterController = Global.CharacterController;
		if (this.InputModeReply == null && !UKuroInputFunctionLibrary.HasInputModeReply(this.InputModeReply))
		{
			this.InputModeReply = UKuroInputFunctionLibrary.SetGameOnlyInputMode(characterController, "GuideTipsView设置输入模式");
		}
	}

	// Token: 0x0600BC2C RID: 48172 RVA: 0x00379373 File Offset: 0x00377573
	private void ReplyGameOnlyInputMode()
	{
		if (this.InputModeReply != null)
		{
			UKuroInputFunctionLibrary.ReplyInputMode(Global.CharacterController, this.InputModeReply);
			this.InputModeReply = null;
		}
	}

	// Token: 0x0600BC2D RID: 48173 RVA: 0x0037939C File Offset: 0x0037759C
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

	// Token: 0x0600BC2E RID: 48174 RVA: 0x003793F4 File Offset: 0x003775F4
	protected override void OnDurationChange(float remainDuration)
	{
		if (this.CountDownItem != null)
		{
			this.CountDownItem.OnDurationChange(remainDuration);
		}
	}

	// Token: 0x0600BC2F RID: 48175 RVA: 0x0037940C File Offset: 0x0037760C
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

	// Token: 0x04006C37 RID: 27703
	private GuideTips? Config;

	// Token: 0x04006C38 RID: 27704
	[Nullable(2)]
	private GuideCountDownItem CountDownItem;

	// Token: 0x04006C39 RID: 27705
	private bool IsBattleViewReady = true;

	// Token: 0x04006C3A RID: 27706
	[Nullable(2)]
	private FInputModeReply InputModeReply;

	// Token: 0x0200752E RID: 29998
	private enum EGuideTipsView
	{
		// Token: 0x04026133 RID: 155955
		UiItemTips,
		// Token: 0x04026134 RID: 155956
		ToggleIcon,
		// Token: 0x04026135 RID: 155957
		GuideDescNew,
		// Token: 0x04026136 RID: 155958
		CountDownItem,
		// Token: 0x04026137 RID: 155959
		UiItemBlackBg,
		// Token: 0x04026138 RID: 155960
		IconParent
	}
}
