using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AFA RID: 6906
[NullableContext(2)]
[Nullable(0)]
public class CommonQteCustomOptionItem : UiPanelBase
{
	// Token: 0x060112E4 RID: 70372 RVA: 0x0050C97A File Offset: 0x0050AB7A
	[NullableContext(1)]
	public void Init(int index, SCommonQteButton config, CommonQteCustomOptionPanel parent)
	{
		this.Index = index;
		this.UiConfig = config;
		this.ParentItem = parent;
	}

	// Token: 0x060112E5 RID: 70373 RVA: 0x0050C994 File Offset: 0x0050AB94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISliderComponent))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
		}
	}

	// Token: 0x060112E6 RID: 70374 RVA: 0x0050CA48 File Offset: 0x0050AC48
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCustomOptionItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCustomOptionItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060112E7 RID: 70375 RVA: 0x0050CA8C File Offset: 0x0050AC8C
	protected override void OnStart()
	{
		base.OnStart();
		this.BtnMain = base.GetButton(0);
		this.DurationBar = base.GetSlider(3);
		UUISliderComponent durationBar = this.DurationBar;
		if (durationBar != null)
		{
			durationBar.SetValue(1f, true);
		}
		UUISliderComponent durationBar2 = this.DurationBar;
		if (durationBar2 != null)
		{
			durationBar2.SetSelfInteractive(false);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain != null)
		{
			btnMain.OnPointDownCallBack.Bind(new Action(this.OnPress));
		}
		if (this.KeyItem != null)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.Hide(null);
			}
		}
		else
		{
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		UUIItem uiItem = Info.Instance.IsInTouch() ? this.RootItem : base.GetItem(4);
		this.LevelSequencePlayer = new LevelSequencePlayer(uiItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x060112E8 RID: 70376 RVA: 0x0050CB9C File Offset: 0x0050AD9C
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.UnbindAction();
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain != null)
		{
			btnMain.OnPointDownCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.CommonQteContext = null;
		this.UiConfig = null;
		this.QteAction = "";
		this.ParentItem = null;
	}

	// Token: 0x060112E9 RID: 70377 RVA: 0x0050CBFC File Offset: 0x0050ADFC
	[NullableContext(1)]
	public void SetQteContext(CommonQteContextBase context)
	{
		CommonQteSelectOptionContext commonQteSelectOptionContext = context as CommonQteSelectOptionContext;
		if (commonQteSelectOptionContext == null)
		{
			return;
		}
		this.CommonQteContext = commonQteSelectOptionContext;
		string action = context.GetAction(new int?(this.Index));
		if (!string.IsNullOrEmpty(action))
		{
			this.QteAction = action;
			if (!Info.Instance.IsInTouch())
			{
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = action
				};
				InputMultiKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
				}
			}
		}
		SCommonQteButton uiConfig = this.UiConfig;
		string text = (uiConfig != null) ? uiConfig.TextId : null;
		UUIText text2 = base.GetText(1);
		if (!string.IsNullOrEmpty(text))
		{
			LguiUtil.Instance.SetLocalTextNew(text2, text, Array.Empty<object>());
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(!context.IsPermanent);
		}
		this.RefreshUiOffset();
	}

	// Token: 0x060112EA RID: 70378 RVA: 0x0050CCCC File Offset: 0x0050AECC
	public void PlayQteStart()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		this.OnSequenceEndEvent("Start");
		this.BindAction();
		base.SetUiActive(true);
	}

	// Token: 0x060112EB RID: 70379 RVA: 0x0050CD14 File Offset: 0x0050AF14
	public void PlayQteEnd()
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.Hide(null);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		CommonQteSelectOptionContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsSuccess())
		{
			CommonQteSelectOptionContext commonQteContext2 = this.CommonQteContext;
			int? num = (commonQteContext2 != null) ? new int?(commonQteContext2.SelectOption) : null;
			int index = this.Index;
			if (num.GetValueOrDefault() == index & num != null)
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					goto IL_B8;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("Press", false, null, false);
				goto IL_B8;
			}
		}
		LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
		if (levelSequencePlayer3 != null)
		{
			levelSequencePlayer3.PlayLevelSequenceByName("Close", false, null, false);
		}
		IL_B8:
		this.UnbindAction();
	}

	// Token: 0x060112EC RID: 70380 RVA: 0x0050CDE0 File Offset: 0x0050AFE0
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
			if (!Info.Instance.IsInTouch())
			{
				InputMultiKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.Show(null);
				return;
			}
		}
		else if (sequenceName == "Press" || sequenceName == "Close")
		{
			CommonQteCustomOptionPanel parentItem = this.ParentItem;
			if (parentItem == null)
			{
				return;
			}
			parentItem.OnOptionItemPlayEnded(this);
		}
	}

	// Token: 0x060112ED RID: 70381 RVA: 0x0050CE64 File Offset: 0x0050B064
	private void BindAction()
	{
		if (this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = true;
		if (!Info.Instance.IsInTouch())
		{
			InputDistributeController.Instance.BindActionIgnoreLimit(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
			if (this.QteAction == "幻象1")
			{
				InputDistributeController.Instance.BindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
			}
		}
	}

	// Token: 0x060112EE RID: 70382 RVA: 0x0050CED8 File Offset: 0x0050B0D8
	private void UnbindAction()
	{
		if (!this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = false;
		if (!Info.Instance.IsInTouch())
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
			if (this.QteAction == "幻象1")
			{
				InputDistributeController.Instance.UnBindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
			}
		}
	}

	// Token: 0x060112EF RID: 70383 RVA: 0x0050CF4A File Offset: 0x0050B14A
	[NullableContext(1)]
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		CommonQteCustomOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(actionType);
	}

	// Token: 0x060112F0 RID: 70384 RVA: 0x0050CF6C File Offset: 0x0050B16C
	[NullableContext(1)]
	private void OnInputInteract(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		if (Info.Instance.IsInGamepad())
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			bool flag;
			if (instance == null)
			{
				flag = false;
			}
			else
			{
				SkillButtonUiGamepadDataBase gamepadData = instance.GamepadData;
				flag = ((gamepadData != null) ? new bool?(gamepadData.SwitchInteractData.IsSwitchInteractOpen) : null).GetValueOrDefault();
			}
			if (flag)
			{
				SkillButtonUiModel instance2 = SkillButtonUiModel.Instance;
				bool flag2;
				if (instance2 == null)
				{
					flag2 = false;
				}
				else
				{
					SkillButtonUiGamepadDataBase gamepadData2 = instance2.GamepadData;
					flag2 = (((gamepadData2 != null) ? new EGamepadSwitchInteractState?(gamepadData2.SwitchInteractData.State) : null).GetValueOrDefault() == EGamepadSwitchInteractState.Explore);
				}
				if (flag2 && this.QteAction == "幻象1")
				{
					this.OnInputCallback(actionName, actionType, inputIdentification);
					return;
				}
			}
		}
	}

	// Token: 0x060112F1 RID: 70385 RVA: 0x0050D019 File Offset: 0x0050B219
	public void OnPress()
	{
		CommonQteCustomOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(InputDistributeDefine.EActionType.Press);
	}

	// Token: 0x060112F2 RID: 70386 RVA: 0x0050D03C File Offset: 0x0050B23C
	private void OnInput(InputDistributeDefine.EActionType actionType)
	{
		if (this.CommonQteContext != null && this.CommonQteContext.IsActive() && this.CommonQteContext.IsPending() && actionType == InputDistributeDefine.EActionType.Press)
		{
			this.CommonQteContext.SelectOption = this.Index;
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x060112F3 RID: 70387 RVA: 0x0050D08A File Offset: 0x0050B28A
	public void OnQtePause()
	{
		this.UnbindAction();
	}

	// Token: 0x060112F4 RID: 70388 RVA: 0x0050D092 File Offset: 0x0050B292
	public void OnQteResume()
	{
		this.BindAction();
	}

	// Token: 0x060112F5 RID: 70389 RVA: 0x0050D09A File Offset: 0x0050B29A
	public void SetProgress(Number progress)
	{
		UUISliderComponent durationBar = this.DurationBar;
		if (durationBar == null)
		{
			return;
		}
		durationBar.SetValue(progress, true);
	}

	// Token: 0x060112F6 RID: 70390 RVA: 0x0050D0B4 File Offset: 0x0050B2B4
	public void RefreshUiOffset()
	{
		SCommonQteButton uiConfig = this.UiConfig;
		if (uiConfig != null)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorAlign(uiConfig.AnchorHAlign, uiConfig.AnchorVAlign);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetAnchorOffset(uiConfig.AnchorOffset);
		}
	}

	// Token: 0x0400971D RID: 38685
	private int Index = -1;

	// Token: 0x0400971E RID: 38686
	[Nullable(1)]
	private string QteAction = "";

	// Token: 0x0400971F RID: 38687
	private bool HasBindAction;

	// Token: 0x04009720 RID: 38688
	private CommonQteSelectOptionContext CommonQteContext;

	// Token: 0x04009721 RID: 38689
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009722 RID: 38690
	private SCommonQteButton UiConfig;

	// Token: 0x04009723 RID: 38691
	private CommonQteCustomOptionPanel ParentItem;

	// Token: 0x04009724 RID: 38692
	private UUIButtonComponent BtnMain;

	// Token: 0x04009725 RID: 38693
	private UUISliderComponent DurationBar;

	// Token: 0x04009726 RID: 38694
	private InputMultiKeyItem KeyItem;

	// Token: 0x02007DD7 RID: 32215
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BD7 RID: 166871
		BtnMain,
		// Token: 0x04028BD8 RID: 166872
		DescText,
		// Token: 0x04028BD9 RID: 166873
		DurationPanel,
		// Token: 0x04028BDA RID: 166874
		DurationBar,
		// Token: 0x04028BDB RID: 166875
		AnimItem,
		// Token: 0x04028BDC RID: 166876
		KeyItem
	}
}
