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

// Token: 0x0200261A RID: 9754
[NullableContext(1)]
[Nullable(0)]
public class CommonQteSelectOptionItem : UiPanelBase
{
	// Token: 0x06013EE0 RID: 81632 RVA: 0x005027C6 File Offset: 0x005009C6
	public void Init(int index, SCommonQteButton config, CommonQteSelectOptionPanel parent)
	{
		this.Index = index;
		this.UiConfig = config;
		this.ParentItem = parent;
	}

	// Token: 0x06013EE1 RID: 81633 RVA: 0x005027E0 File Offset: 0x005009E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
		}
	}

	// Token: 0x06013EE2 RID: 81634 RVA: 0x00502878 File Offset: 0x00500A78
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSelectOptionItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSelectOptionItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013EE3 RID: 81635 RVA: 0x005028BC File Offset: 0x00500ABC
	protected override void OnStart()
	{
		base.OnStart();
		this.ToggleMain = base.GetExtendToggle(0);
		UUIExtendToggle toggleMain = this.ToggleMain;
		if (toggleMain != null)
		{
			toggleMain.OnPointDownCallBack.Bind(delegate(EToggleState _)
			{
				this.OnPress();
			});
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
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x06013EE4 RID: 81636 RVA: 0x00502958 File Offset: 0x00500B58
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.UnbindAction();
		UUIExtendToggle toggleMain = this.ToggleMain;
		if (toggleMain != null)
		{
			toggleMain.OnPointDownCallBack.Unbind();
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

	// Token: 0x06013EE5 RID: 81637 RVA: 0x005029B8 File Offset: 0x00500BB8
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
		if (!string.IsNullOrEmpty((uiConfig != null) ? uiConfig.TextId : null))
		{
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, this.UiConfig.TextId, Array.Empty<object>());
		}
	}

	// Token: 0x06013EE6 RID: 81638 RVA: 0x00502A60 File Offset: 0x00500C60
	public void PlayQteStart()
	{
		this.OnSequenceEndEvent("Start");
		this.BindAction();
		base.SetUiActive(true);
	}

	// Token: 0x06013EE7 RID: 81639 RVA: 0x00502A7C File Offset: 0x00500C7C
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
				this.OnSequenceEndEvent("Success");
				goto IL_8C;
			}
		}
		this.OnSequenceEndEvent("Fail");
		IL_8C:
		this.UnbindAction();
	}

	// Token: 0x06013EE8 RID: 81640 RVA: 0x00502B1C File Offset: 0x00500D1C
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
		else if (sequenceName == "Success" || sequenceName == "Fail")
		{
			CommonQteSelectOptionPanel parentItem = this.ParentItem;
			if (parentItem == null)
			{
				return;
			}
			parentItem.OnOptionItemPlayEnded(this);
		}
	}

	// Token: 0x06013EE9 RID: 81641 RVA: 0x00502BA0 File Offset: 0x00500DA0
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

	// Token: 0x06013EEA RID: 81642 RVA: 0x00502C14 File Offset: 0x00500E14
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

	// Token: 0x06013EEB RID: 81643 RVA: 0x00502C86 File Offset: 0x00500E86
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		CommonQteSelectOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(actionType);
	}

	// Token: 0x06013EEC RID: 81644 RVA: 0x00502CA8 File Offset: 0x00500EA8
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

	// Token: 0x06013EED RID: 81645 RVA: 0x00502D55 File Offset: 0x00500F55
	public void OnPress()
	{
		CommonQteSelectOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(InputDistributeDefine.EActionType.Press);
	}

	// Token: 0x06013EEE RID: 81646 RVA: 0x00502D78 File Offset: 0x00500F78
	private void OnInput(InputDistributeDefine.EActionType actionType)
	{
		if (this.CommonQteContext != null && this.CommonQteContext.IsActive() && this.CommonQteContext.IsPending() && actionType == InputDistributeDefine.EActionType.Press)
		{
			this.CommonQteContext.SelectOption = this.Index;
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013EEF RID: 81647 RVA: 0x00502DC6 File Offset: 0x00500FC6
	public void OnQtePause()
	{
		this.UnbindAction();
	}

	// Token: 0x06013EF0 RID: 81648 RVA: 0x00502DCE File Offset: 0x00500FCE
	public void OnQteResume()
	{
		this.BindAction();
	}

	// Token: 0x06013EF1 RID: 81649 RVA: 0x00502DD8 File Offset: 0x00500FD8
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

	// Token: 0x06013EF2 RID: 81650 RVA: 0x00502E28 File Offset: 0x00501028
	public void SetAnchorOffsetX(float offset)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetAnchorOffsetX(offset);
	}

	// Token: 0x04009633 RID: 38451
	private int Index = -1;

	// Token: 0x04009634 RID: 38452
	private string QteAction = "";

	// Token: 0x04009635 RID: 38453
	private bool HasBindAction;

	// Token: 0x04009636 RID: 38454
	[Nullable(2)]
	private CommonQteSelectOptionContext CommonQteContext;

	// Token: 0x04009637 RID: 38455
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009638 RID: 38456
	[Nullable(2)]
	private SCommonQteButton UiConfig;

	// Token: 0x04009639 RID: 38457
	[Nullable(2)]
	private CommonQteSelectOptionPanel ParentItem;

	// Token: 0x0400963A RID: 38458
	[Nullable(2)]
	private UUIExtendToggle ToggleMain;

	// Token: 0x0400963B RID: 38459
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C63 RID: 35939
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D91C RID: 186652
		MainItem,
		// Token: 0x0402D91D RID: 186653
		RaycastItem,
		// Token: 0x0402D91E RID: 186654
		OptionText,
		// Token: 0x0402D91F RID: 186655
		OffsetItem,
		// Token: 0x0402D920 RID: 186656
		KeyItem
	}
}
