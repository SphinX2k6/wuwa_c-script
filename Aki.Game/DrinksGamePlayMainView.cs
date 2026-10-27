using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityGamePlay.Drinks;
using CSharpScript.Game.Module.UiCameraAnimation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F4C RID: 3916
[NullableContext(1)]
[Nullable(0)]
public class DrinksGamePlayMainView : UiTickViewBase, IUiCameraBehavior
{
	// Token: 0x06006405 RID: 25605 RVA: 0x0013B957 File Offset: 0x00139B57
	public DrinksGamePlayMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006406 RID: 25606 RVA: 0x0013B96C File Offset: 0x00139B6C
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

	// Token: 0x06006407 RID: 25607 RVA: 0x0013BA9C File Offset: 0x00139C9C
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksGamePlayMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksGamePlayMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006408 RID: 25608 RVA: 0x0013BADF File Offset: 0x00139CDF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseHelp));
	}

	// Token: 0x06006409 RID: 25609 RVA: 0x0013BAFA File Offset: 0x00139CFA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseHelp));
	}

	// Token: 0x0600640A RID: 25610 RVA: 0x0013BB15 File Offset: 0x00139D15
	protected override void OnStart()
	{
		this.QTELevelSequence = new LevelSequencePlayer(this.RootItem);
		this.QTELevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnQTESequenceEnd), false);
		this.OnGameCurrentStepStart();
	}

	// Token: 0x0600640B RID: 25611 RVA: 0x0013BB46 File Offset: 0x00139D46
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		UiCameraAnimationManager.Instance.DisablePlayerActor();
	}

	// Token: 0x0600640C RID: 25612 RVA: 0x0013BB58 File Offset: 0x00139D58
	protected override void OnBeforeHide()
	{
		this.ResumeTimeDilation();
	}

	// Token: 0x0600640D RID: 25613 RVA: 0x0013BB60 File Offset: 0x00139D60
	protected override void OnBeforeDestroy()
	{
		if (this.NeedShowPlayer && DrinksModel.Instance.GameplayOpenWay == EDrinksGameplayOpenWay.FromEntityNPC)
		{
			UiCameraAnimationManager.Instance.EnablePlayerActor();
		}
		DrinksModel.Instance.RegisterProxy(false);
	}

	// Token: 0x0600640E RID: 25614 RVA: 0x0013BB8C File Offset: 0x00139D8C
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("DrinksGamePlayMainView");
	}

	// Token: 0x0600640F RID: 25615 RVA: 0x0013BB9D File Offset: 0x00139D9D
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("DrinksGamePlayMainView");
	}

	// Token: 0x06006410 RID: 25616 RVA: 0x0013BBAE File Offset: 0x00139DAE
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		if (!this.HasInitCamera)
		{
			this.CurCameraName = viewName.ToString();
			this.HasInitCamera = true;
			UiCameraAnimationController.Instance.PushCameraHandle(viewName, new int?(viewId), isBlend);
		}
	}

	// Token: 0x06006411 RID: 25617 RVA: 0x0013BBE4 File Offset: 0x00139DE4
	public void PushCamera(string cameraName)
	{
		if (cameraName != this.CurCameraName && this.HasInitCamera)
		{
			this.CurCameraName = cameraName;
			UiCameraMapping? uiCameraMappingConfig = UiCameraAnimationConfig.Instance.GetUiCameraMappingConfig(cameraName);
			UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(uiCameraMappingConfig.Value.DefaultUiCameraSettingsName, true, true, "1001", false, null, null);
		}
	}

	// Token: 0x06006412 RID: 25618 RVA: 0x0013BC46 File Offset: 0x00139E46
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationController.Instance.PopCameraHandle(viewName, stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x06006413 RID: 25619 RVA: 0x0013BC57 File Offset: 0x00139E57
	protected override void OnTick(float delta)
	{
		if (this.NeedTickQTE && !this.StopTickOnClickClose)
		{
			this.QTEPanel.OnTick(delta);
		}
	}

	// Token: 0x06006414 RID: 25620 RVA: 0x0013BC75 File Offset: 0x00139E75
	protected void RegisterProxy()
	{
		DrinksModel instance = DrinksModel.Instance;
		instance.RegisterProxy(true);
		instance.GetProxy().RegisterMainView(this);
	}

	// Token: 0x06006415 RID: 25621 RVA: 0x0013BC90 File Offset: 0x00139E90
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

	// Token: 0x06006416 RID: 25622 RVA: 0x0013BD79 File Offset: 0x00139F79
	public void OnGameCurrentStepEnd()
	{
		this.RefreshButtonState(true);
		this.TopPanel.UpdateStepItem();
		this.BubblePanel.HideBubble();
	}

	// Token: 0x06006417 RID: 25623 RVA: 0x0013BD98 File Offset: 0x00139F98
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

	// Token: 0x06006418 RID: 25624 RVA: 0x0013BDC8 File Offset: 0x00139FC8
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

	// Token: 0x06006419 RID: 25625 RVA: 0x0013BE20 File Offset: 0x0013A020
	public void OnNoBatchingConfirm()
	{
		DrinksMenuPanel menuPanel = this.MenuPanel;
		if (menuPanel == null)
		{
			return;
		}
		menuPanel.SetRaycastOnStepEnd();
	}

	// Token: 0x0600641A RID: 25626 RVA: 0x0013BE32 File Offset: 0x0013A032
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

	// Token: 0x0600641B RID: 25627 RVA: 0x0013BE6C File Offset: 0x0013A06C
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

	// Token: 0x0600641C RID: 25628 RVA: 0x0013BED4 File Offset: 0x0013A0D4
	public void UpdateRoleRequire()
	{
		DrinksRoleStateItem roleStatePanel = this.RoleStatePanel;
		if (roleStatePanel == null)
		{
			return;
		}
		roleStatePanel.RefreshCurState();
	}

	// Token: 0x0600641D RID: 25629 RVA: 0x0013BEE8 File Offset: 0x0013A0E8
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

	// Token: 0x0600641E RID: 25630 RVA: 0x0013BF68 File Offset: 0x0013A168
	public void ActivateDialogBubble(string config, bool isLike)
	{
		this.DialogBubble.ActivateBubble(config, isLike);
	}

	// Token: 0x0600641F RID: 25631 RVA: 0x0013BF77 File Offset: 0x0013A177
	public void DeactivateDialogBubble()
	{
		this.DialogBubble.DeactivateBubble(true);
	}

	// Token: 0x06006420 RID: 25632 RVA: 0x0013BF85 File Offset: 0x0013A185
	public int ShowBackMask(EDrinksPlayStep curStep)
	{
		return this.MaskPanel.ShowBackMask(curStep);
	}

	// Token: 0x06006421 RID: 25633 RVA: 0x0013BF94 File Offset: 0x0013A194
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

	// Token: 0x06006422 RID: 25634 RVA: 0x0013BFDC File Offset: 0x0013A1DC
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

	// Token: 0x06006423 RID: 25635 RVA: 0x0013C064 File Offset: 0x0013A264
	public void SetShakeCamera(ACameraActor camera)
	{
		UiCameraAnimationController.Instance.DeepCopyCamera(camera);
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraAnimationManager.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "DrinksGameplayView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
	}

	// Token: 0x06006424 RID: 25636 RVA: 0x0013C0C5 File Offset: 0x0013A2C5
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

	// Token: 0x06006425 RID: 25637 RVA: 0x0013C0EC File Offset: 0x0013A2EC
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

	// Token: 0x06006426 RID: 25638 RVA: 0x0013C168 File Offset: 0x0013A368
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

	// Token: 0x06006427 RID: 25639 RVA: 0x0013C1C7 File Offset: 0x0013A3C7
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

	// Token: 0x06006428 RID: 25640 RVA: 0x0013C204 File Offset: 0x0013A404
	public void OnFinishMixing()
	{
		this.DeactivateDialogBubble();
		base.SetUiActive(false);
	}

	// Token: 0x06006429 RID: 25641 RVA: 0x0013C214 File Offset: 0x0013A414
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

	// Token: 0x0600642A RID: 25642 RVA: 0x0013C26C File Offset: 0x0013A46C
	private void OnCloseHelp(EUiViewName viewName, int viewId)
	{
		if (viewName.ToString() != EUiViewName.HelpView.ToString())
		{
			return;
		}
		this.StopTickOnClickClose = false;
	}

	// Token: 0x0600642B RID: 25643 RVA: 0x0013C29C File Offset: 0x0013A49C
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

	// Token: 0x04002D55 RID: 11605
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002D56 RID: 11606
	protected DrinksRoleStateItem RoleStatePanel;

	// Token: 0x04002D57 RID: 11607
	protected DrinksTopStepPanel TopPanel;

	// Token: 0x04002D58 RID: 11608
	protected DrinksMenuPanel MenuPanel;

	// Token: 0x04002D59 RID: 11609
	protected DrinksCurrentStatePanel CurValuePanel;

	// Token: 0x04002D5A RID: 11610
	protected DrinksQTEPanel QTEPanel;

	// Token: 0x04002D5B RID: 11611
	protected DrinksBubblePanel BubblePanel;

	// Token: 0x04002D5C RID: 11612
	protected DrinksFlavorBubblePanel BubbleFlavorPanel;

	// Token: 0x04002D5D RID: 11613
	protected DrinksDialogBubble DialogBubble;

	// Token: 0x04002D5E RID: 11614
	protected DrinksBlackMask MaskPanel;

	// Token: 0x04002D5F RID: 11615
	public bool NeedTickQTE;

	// Token: 0x04002D60 RID: 11616
	protected bool StopTickOnClickClose;

	// Token: 0x04002D61 RID: 11617
	[Nullable(2)]
	protected LevelSequencePlayer QTELevelSequence;

	// Token: 0x04002D62 RID: 11618
	protected bool NeedShowPlayer;

	// Token: 0x04002D63 RID: 11619
	protected string CurCameraName = "";

	// Token: 0x04002D64 RID: 11620
	protected bool HasInitCamera;

	// Token: 0x02007598 RID: 30104
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x04026E08 RID: 159240
		public const int CaptionItem = 0;

		// Token: 0x04026E09 RID: 159241
		public const int PanelRoleState = 1;

		// Token: 0x04026E0A RID: 159242
		public const int PanelTopStep = 2;

		// Token: 0x04026E0B RID: 159243
		public const int PanelMenu = 3;

		// Token: 0x04026E0C RID: 159244
		public const int BtnPrevious = 4;

		// Token: 0x04026E0D RID: 159245
		public const int PanelTasteState = 5;

		// Token: 0x04026E0E RID: 159246
		public const int PanelQTE = 6;

		// Token: 0x04026E0F RID: 159247
		public const int PanelAddType1 = 7;

		// Token: 0x04026E10 RID: 159248
		public const int PanelAddType2 = 8;

		// Token: 0x04026E11 RID: 159249
		public const int PanelBlackScreen = 9;

		// Token: 0x04026E12 RID: 159250
		public const int ItemBubble = 10;
	}
}
