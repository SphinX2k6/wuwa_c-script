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

// Token: 0x0200260F RID: 9743
[NullableContext(2)]
[Nullable(0)]
public class CommonQteCustomOptionItem : UiPanelBase
{
	// Token: 0x06013E02 RID: 81410 RVA: 0x004FDB3E File Offset: 0x004FBD3E
	[NullableContext(1)]
	public void Init(int index, SCommonQteButton config, CommonQteCustomOptionPanel parent)
	{
		this.Index = index;
		this.UiConfig = config;
		this.ParentItem = parent;
	}

	// Token: 0x06013E03 RID: 81411 RVA: 0x004FDB58 File Offset: 0x004FBD58
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

	// Token: 0x06013E04 RID: 81412 RVA: 0x004FDC0C File Offset: 0x004FBE0C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCustomOptionItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCustomOptionItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E05 RID: 81413 RVA: 0x004FDC50 File Offset: 0x004FBE50
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

	// Token: 0x06013E06 RID: 81414 RVA: 0x004FDD60 File Offset: 0x004FBF60
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

	// Token: 0x06013E07 RID: 81415 RVA: 0x004FDDC0 File Offset: 0x004FBFC0
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

	// Token: 0x06013E08 RID: 81416 RVA: 0x004FDE90 File Offset: 0x004FC090
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

	// Token: 0x06013E09 RID: 81417 RVA: 0x004FDED8 File Offset: 0x004FC0D8
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

	// Token: 0x06013E0A RID: 81418 RVA: 0x004FDFA4 File Offset: 0x004FC1A4
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

	// Token: 0x06013E0B RID: 81419 RVA: 0x004FE028 File Offset: 0x004FC228
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

	// Token: 0x06013E0C RID: 81420 RVA: 0x004FE09C File Offset: 0x004FC29C
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

	// Token: 0x06013E0D RID: 81421 RVA: 0x004FE10E File Offset: 0x004FC30E
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

	// Token: 0x06013E0E RID: 81422 RVA: 0x004FE130 File Offset: 0x004FC330
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

	// Token: 0x06013E0F RID: 81423 RVA: 0x004FE1DD File Offset: 0x004FC3DD
	public void OnPress()
	{
		CommonQteCustomOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(InputDistributeDefine.EActionType.Press);
	}

	// Token: 0x06013E10 RID: 81424 RVA: 0x004FE200 File Offset: 0x004FC400
	private void OnInput(InputDistributeDefine.EActionType actionType)
	{
		if (this.CommonQteContext != null && this.CommonQteContext.IsActive() && this.CommonQteContext.IsPending() && actionType == InputDistributeDefine.EActionType.Press)
		{
			this.CommonQteContext.SelectOption = this.Index;
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013E11 RID: 81425 RVA: 0x004FE24E File Offset: 0x004FC44E
	public void OnQtePause()
	{
		this.UnbindAction();
	}

	// Token: 0x06013E12 RID: 81426 RVA: 0x004FE256 File Offset: 0x004FC456
	public void OnQteResume()
	{
		this.BindAction();
	}

	// Token: 0x06013E13 RID: 81427 RVA: 0x004FE25E File Offset: 0x004FC45E
	public void SetProgress(Number progress)
	{
		UUISliderComponent durationBar = this.DurationBar;
		if (durationBar == null)
		{
			return;
		}
		durationBar.SetValue(progress, true);
	}

	// Token: 0x06013E14 RID: 81428 RVA: 0x004FE278 File Offset: 0x004FC478
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

	// Token: 0x040095C6 RID: 38342
	private int Index = -1;

	// Token: 0x040095C7 RID: 38343
	[Nullable(1)]
	private string QteAction = "";

	// Token: 0x040095C8 RID: 38344
	private bool HasBindAction;

	// Token: 0x040095C9 RID: 38345
	private CommonQteSelectOptionContext CommonQteContext;

	// Token: 0x040095CA RID: 38346
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095CB RID: 38347
	private SCommonQteButton UiConfig;

	// Token: 0x040095CC RID: 38348
	private CommonQteCustomOptionPanel ParentItem;

	// Token: 0x040095CD RID: 38349
	private UUIButtonComponent BtnMain;

	// Token: 0x040095CE RID: 38350
	private UUISliderComponent DurationBar;

	// Token: 0x040095CF RID: 38351
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C4E RID: 35918
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8C0 RID: 186560
		BtnMain,
		// Token: 0x0402D8C1 RID: 186561
		DescText,
		// Token: 0x0402D8C2 RID: 186562
		DurationPanel,
		// Token: 0x0402D8C3 RID: 186563
		DurationBar,
		// Token: 0x0402D8C4 RID: 186564
		AnimItem,
		// Token: 0x0402D8C5 RID: 186565
		KeyItem
	}
}
