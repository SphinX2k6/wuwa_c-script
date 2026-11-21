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

// Token: 0x02001B05 RID: 6917
[NullableContext(1)]
[Nullable(0)]
public class CommonQteSelectOptionItem : UiPanelBase
{
	// Token: 0x060113C2 RID: 70594 RVA: 0x0051168A File Offset: 0x0050F88A
	public void Init(int index, SCommonQteButton config, CommonQteSelectOptionPanel parent)
	{
		this.Index = index;
		this.UiConfig = config;
		this.ParentItem = parent;
	}

	// Token: 0x060113C3 RID: 70595 RVA: 0x005116A4 File Offset: 0x0050F8A4
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

	// Token: 0x060113C4 RID: 70596 RVA: 0x0051173C File Offset: 0x0050F93C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSelectOptionItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSelectOptionItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060113C5 RID: 70597 RVA: 0x00511780 File Offset: 0x0050F980
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

	// Token: 0x060113C6 RID: 70598 RVA: 0x0051181C File Offset: 0x0050FA1C
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

	// Token: 0x060113C7 RID: 70599 RVA: 0x0051187C File Offset: 0x0050FA7C
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

	// Token: 0x060113C8 RID: 70600 RVA: 0x00511924 File Offset: 0x0050FB24
	public void PlayQteStart()
	{
		this.OnSequenceEndEvent("Start");
		this.BindAction();
		base.SetUiActive(true);
	}

	// Token: 0x060113C9 RID: 70601 RVA: 0x00511940 File Offset: 0x0050FB40
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

	// Token: 0x060113CA RID: 70602 RVA: 0x005119E0 File Offset: 0x0050FBE0
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

	// Token: 0x060113CB RID: 70603 RVA: 0x00511A64 File Offset: 0x0050FC64
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

	// Token: 0x060113CC RID: 70604 RVA: 0x00511AD8 File Offset: 0x0050FCD8
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

	// Token: 0x060113CD RID: 70605 RVA: 0x00511B4A File Offset: 0x0050FD4A
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		CommonQteSelectOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(actionType);
	}

	// Token: 0x060113CE RID: 70606 RVA: 0x00511B6C File Offset: 0x0050FD6C
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

	// Token: 0x060113CF RID: 70607 RVA: 0x00511C19 File Offset: 0x0050FE19
	public void OnPress()
	{
		CommonQteSelectOptionPanel parentItem = this.ParentItem;
		if (parentItem == null || !parentItem.IsValidInput())
		{
			return;
		}
		this.OnInput(InputDistributeDefine.EActionType.Press);
	}

	// Token: 0x060113D0 RID: 70608 RVA: 0x00511C3C File Offset: 0x0050FE3C
	private void OnInput(InputDistributeDefine.EActionType actionType)
	{
		if (this.CommonQteContext != null && this.CommonQteContext.IsActive() && this.CommonQteContext.IsPending() && actionType == InputDistributeDefine.EActionType.Press)
		{
			this.CommonQteContext.SelectOption = this.Index;
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x060113D1 RID: 70609 RVA: 0x00511C8A File Offset: 0x0050FE8A
	public void OnQtePause()
	{
		this.UnbindAction();
	}

	// Token: 0x060113D2 RID: 70610 RVA: 0x00511C92 File Offset: 0x0050FE92
	public void OnQteResume()
	{
		this.BindAction();
	}

	// Token: 0x060113D3 RID: 70611 RVA: 0x00511C9C File Offset: 0x0050FE9C
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

	// Token: 0x060113D4 RID: 70612 RVA: 0x00511CEC File Offset: 0x0050FEEC
	public void SetAnchorOffsetX(float offset)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetAnchorOffsetX(offset);
	}

	// Token: 0x0400978A RID: 38794
	private int Index = -1;

	// Token: 0x0400978B RID: 38795
	private string QteAction = "";

	// Token: 0x0400978C RID: 38796
	private bool HasBindAction;

	// Token: 0x0400978D RID: 38797
	[Nullable(2)]
	private CommonQteSelectOptionContext CommonQteContext;

	// Token: 0x0400978E RID: 38798
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400978F RID: 38799
	[Nullable(2)]
	private SCommonQteButton UiConfig;

	// Token: 0x04009790 RID: 38800
	[Nullable(2)]
	private CommonQteSelectOptionPanel ParentItem;

	// Token: 0x04009791 RID: 38801
	[Nullable(2)]
	private UUIExtendToggle ToggleMain;

	// Token: 0x04009792 RID: 38802
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x02007DEC RID: 32236
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028C33 RID: 166963
		MainItem,
		// Token: 0x04028C34 RID: 166964
		RaycastItem,
		// Token: 0x04028C35 RID: 166965
		OptionText,
		// Token: 0x04028C36 RID: 166966
		OffsetItem,
		// Token: 0x04028C37 RID: 166967
		KeyItem
	}
}
