using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityGamePlay.Drinks;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000401 RID: 1025
[NullableContext(1)]
[Nullable(0)]
public class DrinksGamePlayMainView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x0600379D RID: 14237 RVA: 0x00144223 File Offset: 0x00142423
	public DrinksGamePlayMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600379E RID: 14238 RVA: 0x00144238 File Offset: 0x00142438
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickedBack))
		};
	}

	// Token: 0x0600379F RID: 14239 RVA: 0x00144368 File Offset: 0x00142568
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksGamePlayMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksGamePlayMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060037A0 RID: 14240 RVA: 0x001443AB File Offset: 0x001425AB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseHelp));
	}

	// Token: 0x060037A1 RID: 14241 RVA: 0x001443C6 File Offset: 0x001425C6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseHelp));
	}

	// Token: 0x060037A2 RID: 14242 RVA: 0x001443E1 File Offset: 0x001425E1
	protected override void OnStart()
	{
		this.QTELevelSequence = new LevelSequencePlayer(this.RootItem);
		this.QTELevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnQTESequenceEnd), false);
		this.OnGameCurrentStepStart();
	}

	// Token: 0x060037A3 RID: 14243 RVA: 0x00144412 File Offset: 0x00142612
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		UiCameraModel.Instance.DisablePlayerActor();
	}

	// Token: 0x060037A4 RID: 14244 RVA: 0x00144424 File Offset: 0x00142624
	protected override void OnBeforeHide()
	{
		this.ResumeTimeDilation();
	}

	// Token: 0x060037A5 RID: 14245 RVA: 0x0014442C File Offset: 0x0014262C
	protected override void OnBeforeDestroy()
	{
		if (this.NeedShowPlayer && DrinksModel.Instance.GameplayOpenWay == EDrinksGameplayOpenWay.FromEntityNPC)
		{
			UiCameraModel.Instance.EnablePlayerActor();
		}
		DrinksModel.Instance.RegisterProxy(false);
	}

	// Token: 0x060037A6 RID: 14246 RVA: 0x00144458 File Offset: 0x00142658
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("DrinksGamePlayMainView");
	}

	// Token: 0x060037A7 RID: 14247 RVA: 0x00144469 File Offset: 0x00142669
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("DrinksGamePlayMainView");
	}

	// Token: 0x060037A8 RID: 14248 RVA: 0x0014447A File Offset: 0x0014267A
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		if (!this.HasInitCamera)
		{
			this.CurCameraName = viewName.ToString();
			this.HasInitCamera = true;
			UiCameraController.Instance.PushCameraHandleByOpenView(viewName, viewId, operationType);
		}
	}

	// Token: 0x060037A9 RID: 14249 RVA: 0x001444AC File Offset: 0x001426AC
	public void PushCamera(string cameraName)
	{
		if (cameraName != this.CurCameraName && this.HasInitCamera)
		{
			this.CurCameraName = cameraName;
			UiCameraMapping? uiCameraMappingConfig = UiCameraConfig.Instance.GetUiCameraMappingConfig(cameraName);
			UiCameraModel.Instance.PushCameraHandleByHandleName(uiCameraMappingConfig.Value.DefaultUiCameraSettingsName, true, true, "1001", false, null);
		}
	}

	// Token: 0x060037AA RID: 14250 RVA: 0x00144505 File Offset: 0x00142705
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PopCameraHandleByCloseView(viewName, nextViewName, closeViewId, operationType);
	}

	// Token: 0x060037AB RID: 14251 RVA: 0x00144516 File Offset: 0x00142716
	protected override void OnTick(float delta)
	{
		if (this.NeedTickQTE && !this.StopTickOnClickClose)
		{
			this.QTEPanel.OnTick(delta);
		}
	}

	// Token: 0x060037AC RID: 14252 RVA: 0x00144534 File Offset: 0x00142734
	protected void RegisterProxy()
	{
		DrinksModel instance = DrinksModel.Instance;
		instance.RegisterProxy(true);
		instance.GetProxy().RegisterMainView(this);
	}

	// Token: 0x060037AD RID: 14253 RVA: 0x00144550 File Offset: 0x00142750
	public void OnGameCurrentStepStart()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetCloseBtnActive(true);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 != null)
		{
			captionItem2.SetHelpBtnActive(true);
		}
		this.StopTickOnClickClose = false;
		this.RefreshButtonState(false);
		this.QTEPanel.SetUiActive(false);
		this.TopPanel.UpdateStep();
		this.CurValuePanel.UpdateStep();
		LevelSequencePlayer qtelevelSequence = this.QTELevelSequence;
		if (qtelevelSequence != null)
		{
			qtelevelSequence.PlayLevelSequenceByName("RigthUIin", false, null, false);
		}
		this.MenuPanel.UpdateOnStepStart();
		this.BubblePanel.UpdateState(false);
		this.BubbleFlavorPanel.RefreshOnStart();
		if (DrinksModel.Instance.GetCurStep() < EDrinksPlayStep.Ornament)
		{
			this.PushCamera("DrinksGameplayView");
			return;
		}
		int roleId = DrinksModel.Instance.GetRoleId();
		this.PushCamera(DrinksConfig.Instance.GetInviteConfigByRole(roleId).Value.OrnamentCamera);
	}

	// Token: 0x060037AE RID: 14254 RVA: 0x00144639 File Offset: 0x00142839
	public void OnGameCurrentStepEnd()
	{
		this.RefreshButtonState(true);
		this.TopPanel.UpdateStepItem();
		this.BubblePanel.HideBubble();
	}

	// Token: 0x060037AF RID: 14255 RVA: 0x00144658 File Offset: 0x00142858
	public void OnDrinkBaseSelected(int drinkId, bool isEnd)
	{
		DrinksTopStepPanel topPanel = this.TopPanel;
		if (topPanel != null)
		{
			topPanel.UpdateStepItem();
		}
		this.BubblePanel.UpdateState(isEnd);
		DrinksCurrentStatePanel curValuePanel = this.CurValuePanel;
		if (curValuePanel == null)
		{
			return;
		}
		curValuePanel.OnDrinkSelected(drinkId);
	}

	// Token: 0x060037B0 RID: 14256 RVA: 0x00144688 File Offset: 0x00142888
	public void OnBatchingSelected(HashSet<int> batchingSet, bool isEnd)
	{
		DrinksTopStepPanel topPanel = this.TopPanel;
		if (topPanel != null)
		{
			topPanel.UpdateStepItem();
		}
		if (isEnd && batchingSet.Count > 0)
		{
			DrinksMenuPanel menuPanel = this.MenuPanel;
			if (menuPanel != null)
			{
				menuPanel.SetRaycastOnStepEnd();
			}
		}
		this.BubblePanel.UpdateState(isEnd);
		DrinksCurrentStatePanel curValuePanel = this.CurValuePanel;
		if (curValuePanel == null)
		{
			return;
		}
		curValuePanel.OnBatchingSelected(batchingSet);
	}

	// Token: 0x060037B1 RID: 14257 RVA: 0x001446E0 File Offset: 0x001428E0
	public void OnNoBatchingConfirm()
	{
		DrinksMenuPanel menuPanel = this.MenuPanel;
		if (menuPanel == null)
		{
			return;
		}
		menuPanel.SetRaycastOnStepEnd();
	}

	// Token: 0x060037B2 RID: 14258 RVA: 0x001446F2 File Offset: 0x001428F2
	public void OnOrnamentSelected(bool isEnd)
	{
		if (isEnd)
		{
			DrinksMenuPanel menuPanel = this.MenuPanel;
			if (menuPanel != null)
			{
				menuPanel.SetRaycastOnStepEnd();
			}
		}
		DrinksRoleStateItem roleStatePanel = this.RoleStatePanel;
		if (roleStatePanel != null)
		{
			roleStatePanel.RefreshCurState();
		}
		DrinksTopStepPanel topPanel = this.TopPanel;
		if (topPanel == null)
		{
			return;
		}
		topPanel.UpdateStepItem();
	}

	// Token: 0x060037B3 RID: 14259 RVA: 0x0014472C File Offset: 0x0014292C
	public void OnEnterDrinkBaseQTE()
	{
		this.RefreshButtonState(true);
		this.DialogBubble.DeactivateBubble(true);
		DrinksMenuPanel menuPanel = this.MenuPanel;
		if (menuPanel != null)
		{
			menuPanel.SetRaycastOnStepEnd();
		}
		LevelSequencePlayer qtelevelSequence = this.QTELevelSequence;
		if (qtelevelSequence != null)
		{
			qtelevelSequence.PlayLevelSequenceByName("RigthUIout", false, null, false);
		}
		this.QTEPanel.StartQTE();
		this.BubblePanel.HideBubble();
	}

	// Token: 0x060037B4 RID: 14260 RVA: 0x00144794 File Offset: 0x00142994
	public void UpdateRoleRequire()
	{
		DrinksRoleStateItem roleStatePanel = this.RoleStatePanel;
		if (roleStatePanel == null)
		{
			return;
		}
		roleStatePanel.RefreshCurState();
	}

	// Token: 0x060037B5 RID: 14261 RVA: 0x001447A8 File Offset: 0x001429A8
	public void UpdateFlavorBubble()
	{
		this.RefreshButtonState(true);
		this.DialogBubble.DeactivateBubble(true);
		this.CurValuePanel.RefreshOnEnterSeq();
		if (DrinksModel.Instance.GetCurStep() > EDrinksPlayStep.Drink2)
		{
			DrinksMenuPanel menuPanel = this.MenuPanel;
			if (menuPanel != null)
			{
				menuPanel.SetRaycastOnStepEnd();
			}
			LevelSequencePlayer qtelevelSequence = this.QTELevelSequence;
			if (qtelevelSequence != null)
			{
				qtelevelSequence.PlayLevelSequenceByName("RigthUIout", false, null, false);
			}
		}
		this.BubblePanel.HideBubble();
		this.BubbleFlavorPanel.Refresh();
	}

	// Token: 0x060037B6 RID: 14262 RVA: 0x00144828 File Offset: 0x00142A28
	public void ActivateDialogBubble(string config, bool isLike)
	{
		this.DialogBubble.ActivateBubble(config, isLike);
	}

	// Token: 0x060037B7 RID: 14263 RVA: 0x00144837 File Offset: 0x00142A37
	public void DeactivateDialogBubble()
	{
		this.DialogBubble.DeactivateBubble(true);
	}

	// Token: 0x060037B8 RID: 14264 RVA: 0x00144845 File Offset: 0x00142A45
	public int ShowBackMask(EDrinksPlayStep curStep)
	{
		return this.MaskPanel.ShowBackMask(curStep);
	}

	// Token: 0x060037B9 RID: 14265 RVA: 0x00144854 File Offset: 0x00142A54
	protected void RefreshButtonState(bool isEnd = false)
	{
		bool flag = DrinksModel.Instance.GetCurStep() > EDrinksPlayStep.Drink1;
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(flag && !isEnd);
	}

	// Token: 0x060037BA RID: 14266 RVA: 0x0014489C File Offset: 0x00142A9C
	public void SetNeedTickQTE(bool value)
	{
		this.NeedTickQTE = value;
		if (!value)
		{
			LevelSequencePlayer qtelevelSequence = this.QTELevelSequence;
			if (qtelevelSequence != null && qtelevelSequence.IsPlayingSequence("Qtein"))
			{
				LevelSequencePlayer qtelevelSequence2 = this.QTELevelSequence;
				if (qtelevelSequence2 != null)
				{
					qtelevelSequence2.StopCurrentSequence(false, true);
				}
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				LevelSequencePlayer qtelevelSequence4 = this.QTELevelSequence;
				if (qtelevelSequence4 == null)
				{
					return;
				}
				qtelevelSequence4.PlayLevelSequenceByName("Qteout", false, null, false);
			}, 1000f, null, null, true, 1f);
			return;
		}
		LevelSequencePlayer qtelevelSequence3 = this.QTELevelSequence;
		if (qtelevelSequence3 == null)
		{
			return;
		}
		qtelevelSequence3.PlayLevelSequenceByName("Qtein", false, null, false);
	}

	// Token: 0x060037BB RID: 14267 RVA: 0x00144924 File Offset: 0x00142B24
	public void SetShakeCamera(ACameraActor camera)
	{
		UiCameraController.Instance.DeepCopyCamera(camera);
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraModel.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "DrinksGameplayView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
	}

	// Token: 0x060037BC RID: 14268 RVA: 0x00144985 File Offset: 0x00142B85
	public void HideCaptionClose()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetCloseBtnActive(false);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 == null)
		{
			return;
		}
		captionItem2.SetHelpBtnActive(false);
	}

	// Token: 0x060037BD RID: 14269 RVA: 0x001449AC File Offset: 0x00142BAC
	private void OnClickCloseButton()
	{
		this.StopTickOnClickClose = true;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DrinkCloseConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap[0] = delegate()
		{
			this.StopTickOnClickClose = false;
		};
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			this.NeedTickQTE = false;
			DrinksModel.Instance.RestartGame();
			EventSystem.Instance.Emit(EEventName.NotifyGuideBreakFocus);
		};
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			DrinksSceneController sceneController = DrinksModel.Instance.GetSceneController();
			if (DrinksModel.Instance.GameplayOpenWay == EDrinksGameplayOpenWay.FromEntityNPC)
			{
				sceneController.ShowNpc();
			}
			sceneController.Destroy(true);
			this.NeedShowPlayer = true;
			base.CloseMe(null);
			if (DrinksModel.Instance.GameplayIsMainQuest)
			{
				DrinksModel.Instance.HideMainQuestNpcByEntityId();
			}
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060037BE RID: 14270 RVA: 0x00144A28 File Offset: 0x00142C28
	private void OnClickedBack()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DrinkPrevConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			DrinksModel.Instance.BackToPrevStep();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		EventSystem.Instance.Emit(EEventName.NotifyGuideBreakFocus);
	}

	// Token: 0x060037BF RID: 14271 RVA: 0x00144A87 File Offset: 0x00142C87
	private void OnQTESequenceEnd(string seqName)
	{
		if (seqName == "RigthUIout")
		{
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.DrinksGameplayView, false);
			return;
		}
		if (seqName == "Qteout")
		{
			this.QTEPanel.OnFadeSequenceEnd();
		}
	}

	// Token: 0x060037C0 RID: 14272 RVA: 0x00144AC4 File Offset: 0x00142CC4
	public void OnFinishMixing()
	{
		this.DeactivateDialogBubble();
		base.SetUiActive(false);
	}

	// Token: 0x060037C1 RID: 14273 RVA: 0x00144AD4 File Offset: 0x00142CD4
	public void OnFinishMixingEnd()
	{
		DrinksResultInfo currentPlayData = DrinksModel.Instance.GetCurrentPlayData();
		DrinksShowInfo param = new DrinksShowInfo
		{
			Data = currentPlayData,
			RoleId = DrinksModel.Instance.GetRoleId(),
			IsGamePlay = true
		};
		UiManager.Instance.OpenView(EUiViewName.DrinksShowView, param, delegate(bool _, int _)
		{
			this.NeedShowPlayer = false;
			base.CloseMe(null);
		});
	}

	// Token: 0x060037C2 RID: 14274 RVA: 0x00144B2C File Offset: 0x00142D2C
	private void OnCloseHelp(EUiViewName viewName, int viewId)
	{
		if (viewName.ToString() != EUiViewName.HelpView.ToString())
		{
			return;
		}
		this.StopTickOnClickClose = false;
	}

	// Token: 0x060037C3 RID: 14275 RVA: 0x00144B5C File Offset: 0x00142D5C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Ornament"))
		{
			return null;
		}
		int num = (int)float.Parse(configParams[1]);
		if (num == 0)
		{
			return null;
		}
		UUIItem uuiitem = this.MenuPanel.GuideGetOrnamentItem(num);
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04002DEE RID: 11758
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002DEF RID: 11759
	protected DrinksRoleStateItem RoleStatePanel;

	// Token: 0x04002DF0 RID: 11760
	protected DrinksTopStepPanel TopPanel;

	// Token: 0x04002DF1 RID: 11761
	protected DrinksMenuPanel MenuPanel;

	// Token: 0x04002DF2 RID: 11762
	protected DrinksCurrentStatePanel CurValuePanel;

	// Token: 0x04002DF3 RID: 11763
	protected DrinksQTEPanel QTEPanel;

	// Token: 0x04002DF4 RID: 11764
	protected DrinksBubblePanel BubblePanel;

	// Token: 0x04002DF5 RID: 11765
	protected DrinksFlavorBubblePanel BubbleFlavorPanel;

	// Token: 0x04002DF6 RID: 11766
	protected DrinksDialogBubble DialogBubble;

	// Token: 0x04002DF7 RID: 11767
	protected DrinksBlackMask MaskPanel;

	// Token: 0x04002DF8 RID: 11768
	public bool NeedTickQTE;

	// Token: 0x04002DF9 RID: 11769
	protected bool StopTickOnClickClose;

	// Token: 0x04002DFA RID: 11770
	[Nullable(2)]
	protected LevelSequencePlayer QTELevelSequence;

	// Token: 0x04002DFB RID: 11771
	protected bool NeedShowPlayer;

	// Token: 0x04002DFC RID: 11772
	protected string CurCameraName = "";

	// Token: 0x04002DFD RID: 11773
	protected bool HasInitCamera;

	// Token: 0x0200672C RID: 26412
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x04022153 RID: 139603
		public const int CaptionItem = 0;

		// Token: 0x04022154 RID: 139604
		public const int PanelRoleState = 1;

		// Token: 0x04022155 RID: 139605
		public const int PanelTopStep = 2;

		// Token: 0x04022156 RID: 139606
		public const int PanelMenu = 3;

		// Token: 0x04022157 RID: 139607
		public const int BtnPrevious = 4;

		// Token: 0x04022158 RID: 139608
		public const int PanelTasteState = 5;

		// Token: 0x04022159 RID: 139609
		public const int PanelQTE = 6;

		// Token: 0x0402215A RID: 139610
		public const int PanelAddType1 = 7;

		// Token: 0x0402215B RID: 139611
		public const int PanelAddType2 = 8;

		// Token: 0x0402215C RID: 139612
		public const int PanelBlackScreen = 9;

		// Token: 0x0402215D RID: 139613
		public const int ItemBubble = 10;
	}
}
