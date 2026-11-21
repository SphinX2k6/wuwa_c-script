using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C22 RID: 23586
	[NullableContext(1)]
	[Nullable(0)]
	public class PianoGameplayView : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x06039EBB RID: 237243 RVA: 0x0104961A File Offset: 0x0104781A
		public PianoGameplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039EBC RID: 237244 RVA: 0x01049658 File Offset: 0x01047858
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnAutoPlayButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(delegate()
			{
				this.OnPianoKeyInput("钢琴琴键J", InputDistributeDefine.EActionType.Press, null);
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(delegate()
			{
				this.OnPianoKeyInput("钢琴琴键K", InputDistributeDefine.EActionType.Press, null);
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(delegate()
			{
				this.OnPianoKeyInput("钢琴琴键L", InputDistributeDefine.EActionType.Press, null);
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039EBD RID: 237245 RVA: 0x0104995F File Offset: 0x01047B5F
		private void RegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x06039EBE RID: 237246 RVA: 0x0104997C File Offset: 0x01047B7C
		private void UnRegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x06039EBF RID: 237247 RVA: 0x01049998 File Offset: 0x01047B98
		protected override UniTask OnBeforeStartAsync()
		{
			PianoGameplayView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PianoGameplayView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC0 RID: 237248 RVA: 0x010499DC File Offset: 0x01047BDC
		private void InitPianoQteBtnItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			object obj;
			if (button == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = button.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			UUIItem uuiitem = obj as UUIItem;
			if (uuiitem != null)
			{
				PianoGameplayModel.Instance.AddPianoQteBtnItem(new PianoQteBtnItem("钢琴琴键J", uuiitem, false));
			}
			UUIButtonComponent button2 = base.GetButton(1);
			object obj2;
			if (button2 == null)
			{
				obj2 = null;
			}
			else
			{
				AActor owner2 = button2.GetOwner();
				obj2 = ((owner2 != null) ? owner2.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			UUIItem uuiitem2 = obj2 as UUIItem;
			if (uuiitem2 != null)
			{
				PianoGameplayModel.Instance.AddPianoQteBtnItem(new PianoQteBtnItem("钢琴琴键K", uuiitem2, false));
			}
			UUIButtonComponent button3 = base.GetButton(2);
			object obj3;
			if (button3 == null)
			{
				obj3 = null;
			}
			else
			{
				AActor owner3 = button3.GetOwner();
				obj3 = ((owner3 != null) ? owner3.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			UUIItem uuiitem3 = obj3 as UUIItem;
			if (uuiitem3 != null)
			{
				PianoGameplayModel.Instance.AddPianoQteBtnItem(new PianoQteBtnItem("钢琴琴键L", uuiitem3, false));
			}
		}

		// Token: 0x06039EC1 RID: 237249 RVA: 0x01049AC4 File Offset: 0x01047CC4
		protected override void OnTick(float delta)
		{
			foreach (string a in this.PressedKey)
			{
				if (a == "UI方向上")
				{
					InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				}
				else if (a == "UI方向下")
				{
					InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				}
				else if (a == "UI方向左")
				{
					InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				}
				else if (a == "UI方向右")
				{
					InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				}
			}
			Joystick mobileJoystick = this.MobileJoystick;
			if (mobileJoystick == null)
			{
				return;
			}
			mobileJoystick.Tick(delta);
		}

		// Token: 0x06039EC2 RID: 237250 RVA: 0x01049BB8 File Offset: 0x01047DB8
		protected override void OnBeforeHide()
		{
			this.StopCurrentTalk();
		}

		// Token: 0x06039EC3 RID: 237251 RVA: 0x01049BC0 File Offset: 0x01047DC0
		protected override void OnBeforeDestroy()
		{
			this.IsWaitingAudioStart = false;
			PianoGameplayController.Instance.ExitPianoGameplay();
			PianoGameplayModel.Instance.ExitGameplay();
			this.PressedKey.Clear();
			PianoGameplayController.Instance.StopPianoQte();
			PianoGameplayModel.Instance.ClearPianoQteBtnItemList();
			this.SubtitleAnimPlayer.Clear();
			this.IsSubtitleFadeOutPlaying = false;
			this.TipsInTweens = Array.Empty<ULGUIPlayTweenComponent>();
			this.TipsOutTweens = Array.Empty<ULGUIPlayTweenComponent>();
			this.ClearDelayHideTimer();
			if (this.WriterComp != null)
			{
				PlotTextWriterComponent writerComp = this.WriterComp;
				if (writerComp != null)
				{
					writerComp.Clear();
				}
			}
			this.WriterComp = null;
			if (this.AudioComp != null)
			{
				PlotTextAudioComponent audioComp = this.AudioComp;
				if (audioComp != null)
				{
					audioComp.StopAudio();
				}
			}
			this.AudioComp = null;
			this.UnRegisterExtraUiProhibitRefresh();
			this.DebugHasNextTalk = false;
		}

		// Token: 0x06039EC4 RID: 237252 RVA: 0x01049C82 File Offset: 0x01047E82
		public bool CheckCondition()
		{
			return this.CurrentInputMode == EBoundInputMode.Touch && this.MobileJoystick != null && !this.DisableMove;
		}

		// Token: 0x06039EC5 RID: 237253 RVA: 0x01049CA0 File Offset: 0x01047EA0
		public string[] GetDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.AxisInput.MoveInput",
				"UiInputRoot"
			};
		}

		// Token: 0x06039EC6 RID: 237254 RVA: 0x01049CB8 File Offset: 0x01047EB8
		protected override void OnAddEventListener()
		{
			this.CurrentInputMode = EBoundInputMode.None;
			this.OnInputControllerChange(EInputControllerType.None, EInputControllerType.None);
			EventSystem.Instance.Add<IClientEventPianoUpdateSubtitle>(EEventName.OnPianoGameplayUpdateSubtitle, new Action<IClientEventPianoUpdateSubtitle>(this.OnPianoUpdateSubtitle));
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.RefreshDialogTextLayout));
			EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.OnShowTypeChange));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<EPianoGameplayStage>(EEventName.OnPianoGameplayStageChanged, new Action<EPianoGameplayStage>(this.OnPianoGameplayStageChanged));
			EventSystem.Instance.Add<bool, float>(EEventName.OnUiTextEnableUseDebugFixedDuration, new Action<bool, float>(this.OnUiTextEnableUseDebugFixedDuration));
		}

		// Token: 0x06039EC7 RID: 237255 RVA: 0x01049D7C File Offset: 0x01047F7C
		protected override void OnRemoveEventListener()
		{
			this.UnbindAllInput();
			EventSystem.Instance.Remove<IClientEventPianoUpdateSubtitle>(EEventName.OnPianoGameplayUpdateSubtitle, new Action<IClientEventPianoUpdateSubtitle>(this.OnPianoUpdateSubtitle));
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.RefreshDialogTextLayout));
			EventSystem.Instance.Remove<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.OnShowTypeChange));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove<EPianoGameplayStage>(EEventName.OnPianoGameplayStageChanged, new Action<EPianoGameplayStage>(this.OnPianoGameplayStageChanged));
			EventSystem.Instance.Remove<bool, float>(EEventName.OnUiTextEnableUseDebugFixedDuration, new Action<bool, float>(this.OnUiTextEnableUseDebugFixedDuration));
		}

		// Token: 0x06039EC8 RID: 237256 RVA: 0x01049E34 File Offset: 0x01048034
		protected void AddInputEvent()
		{
			InputDistributeController.Instance.BindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06039EC9 RID: 237257 RVA: 0x01049EE4 File Offset: 0x010480E4
		protected void RemoveInputEvent()
		{
			InputDistributeController.Instance.UnBindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06039ECA RID: 237258 RVA: 0x01049F94 File Offset: 0x01048194
		private void OnAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			if (this.DisableMove)
			{
				return;
			}
			bool flag = false;
			if (axisName == "NavigationTopDown")
			{
				InputController.Instance.InputAxis(EInputAxis.MoveForward, value, true);
				if (value != 0f)
				{
					flag = true;
				}
			}
			else if (axisName == "NavigationLeftRight")
			{
				InputController.Instance.InputAxis(EInputAxis.MoveRight, value, true);
				if (value != 0f)
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.TryPlayTipsOut();
			}
		}

		// Token: 0x06039ECB RID: 237259 RVA: 0x0104A007 File Offset: 0x01048207
		private void OnInput(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (this.DisableMove)
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.PressedKey.Add(actionName);
				this.TryPlayTipsOut();
				return;
			}
			this.PressedKey.Remove(actionName);
		}

		// Token: 0x06039ECC RID: 237260 RVA: 0x0104A036 File Offset: 0x01048236
		private void OnPianoKeyInput(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			PianoGameplayController.Instance.ExecutePianoSequenceEvent(actionName);
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			PianoGameplayController.Instance.OnPianoQteInput(actionName);
		}

		// Token: 0x06039ECD RID: 237261 RVA: 0x0104A054 File Offset: 0x01048254
		private void OnAutoPlayButtonClick()
		{
			bool pianoAutoPlay = !PianoGameplayController.Instance.IsPianoAutoPlayEnabled();
			PianoGameplayController.Instance.SetPianoAutoPlay(pianoAutoPlay);
			this.RefreshAutoPlayState();
		}

		// Token: 0x06039ECE RID: 237262 RVA: 0x0104A080 File Offset: 0x01048280
		private void RefreshAutoPlayState()
		{
			bool flag = PianoGameplayController.Instance.IsPianoAutoPlayEnabled();
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x06039ECF RID: 237263 RVA: 0x0104A0C4 File Offset: 0x010482C4
		private void ToggleEnableMoveInput(bool enable)
		{
			if (this.DisableMove == !enable)
			{
				return;
			}
			this.DisableMove = !enable;
			if (this.DisableMove)
			{
				this.PressedKey.Clear();
			}
			if (this.MobileJoystick != null)
			{
				this.MobileJoystick.SetEnable(enable);
				if (enable)
				{
					this.MobileJoystick.ShowBattleVisibleChildView();
				}
				else
				{
					this.MobileJoystick.HideBattleVisibleChildView();
				}
			}
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x06039ED0 RID: 237264 RVA: 0x0104A134 File Offset: 0x01048334
		private UniTask InitMobileJoystick()
		{
			PianoGameplayView.<InitMobileJoystick>d__51 <InitMobileJoystick>d__;
			<InitMobileJoystick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMobileJoystick>d__.<>4__this = this;
			<InitMobileJoystick>d__.<>1__state = -1;
			<InitMobileJoystick>d__.<>t__builder.Start<PianoGameplayView.<InitMobileJoystick>d__51>(ref <InitMobileJoystick>d__);
			return <InitMobileJoystick>d__.<>t__builder.Task;
		}

		// Token: 0x06039ED1 RID: 237265 RVA: 0x0104A177 File Offset: 0x01048377
		private void OnShowTypeChange(EOperationType last, EOperationType now)
		{
			if (now == EOperationType.Pad)
			{
				this.BindTouchInput();
				return;
			}
			this.UnbindTouchInput();
		}

		// Token: 0x06039ED2 RID: 237266 RVA: 0x0104A18C File Offset: 0x0104838C
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			EBoundInputMode eboundInputMode = EBoundInputMode.None;
			if (Info.Instance.IsInTouch())
			{
				eboundInputMode = EBoundInputMode.Touch;
			}
			else if (Info.Instance.IsInGamepad())
			{
				eboundInputMode = EBoundInputMode.Gamepad;
			}
			else if (Info.Instance.IsInKeyBoard())
			{
				eboundInputMode = EBoundInputMode.MouseKeyboard;
			}
			if (eboundInputMode == this.CurrentInputMode)
			{
				return;
			}
			this.UnbindAllInput();
			this.CurrentInputMode = eboundInputMode;
			switch (eboundInputMode)
			{
			case EBoundInputMode.MouseKeyboard:
				this.BindKeyBoardInput();
				return;
			case EBoundInputMode.Touch:
				this.BindTouchInput();
				return;
			case EBoundInputMode.Gamepad:
				this.BindGamepadInput();
				return;
			default:
				return;
			}
		}

		// Token: 0x06039ED3 RID: 237267 RVA: 0x0104A20C File Offset: 0x0104840C
		private void UnbindAllInput()
		{
			switch (this.CurrentInputMode)
			{
			case EBoundInputMode.MouseKeyboard:
				this.UnbindKeyBoardInput();
				return;
			case EBoundInputMode.Touch:
				this.UnbindTouchInput();
				return;
			case EBoundInputMode.Gamepad:
				this.UnbindGamepadInput();
				return;
			default:
				return;
			}
		}

		// Token: 0x06039ED4 RID: 237268 RVA: 0x0104A24C File Offset: 0x0104844C
		private void BindKeyBoardInput()
		{
			InputDistributeController.Instance.BindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06039ED5 RID: 237269 RVA: 0x0104A2C8 File Offset: 0x010484C8
		private void UnbindKeyBoardInput()
		{
			InputDistributeController.Instance.UnBindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06039ED6 RID: 237270 RVA: 0x0104A341 File Offset: 0x01048541
		private void BindTouchInput()
		{
			if (this.MobileJoystick == null)
			{
				this.InitMobileJoystick();
				return;
			}
			this.MobileJoystick.SetActive(true);
		}

		// Token: 0x06039ED7 RID: 237271 RVA: 0x0104A35F File Offset: 0x0104855F
		private void UnbindTouchInput()
		{
			if (this.MobileJoystick != null)
			{
				this.MobileJoystick.SetActive(false);
				return;
			}
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06039ED8 RID: 237272 RVA: 0x0104A388 File Offset: 0x01048588
		private void BindGamepadInput()
		{
			InputDistributeController.Instance.BindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
		}

		// Token: 0x06039ED9 RID: 237273 RVA: 0x0104A3C0 File Offset: 0x010485C0
		private void UnbindGamepadInput()
		{
			InputDistributeController.Instance.UnBindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
		}

		// Token: 0x06039EDA RID: 237274 RVA: 0x0104A3F8 File Offset: 0x010485F8
		[NullableContext(2)]
		public AUIContainerActor GetSceneCaptureViewAttachActor()
		{
			UUIItem item = base.GetItem(5);
			AUIContainerActor auicontainerActor = ((item != null) ? item.GetOwner() : null) as AUIContainerActor;
			if (auicontainerActor == null)
			{
				return null;
			}
			return auicontainerActor;
		}

		// Token: 0x06039EDB RID: 237275 RVA: 0x0104A424 File Offset: 0x01048624
		public void RefreshViewportLayout()
		{
			this.RefreshDialogTextLayout();
		}

		// Token: 0x06039EDC RID: 237276 RVA: 0x0104A42C File Offset: 0x0104862C
		private void OnPianoUpdateSubtitle(IClientEventPianoUpdateSubtitle @event)
		{
			ValueTuple<SetPlotMode, ShowTalk>? valueTuple = AnimatedScreenTextController.Instance.ParseFlow(@event.Flow);
			if (valueTuple == null)
			{
				return;
			}
			this.StopCurrentTalk();
			this.CurrentPlotMode = valueTuple.Value.Item1;
			UUIItem dialogTextItem = this.DialogTextItem;
			if (dialogTextItem != null)
			{
				dialogTextItem.SetUIActive(true);
			}
			this.UpdatePlotMode();
			this.CurrentShowTalk = valueTuple.Value.Item2;
			this.CurrentTalkItemIndex = -1;
			this.PlayNextTalk();
			this.ToggleEnableMoveInput(!@event.DisableMove);
		}

		// Token: 0x06039EDD RID: 237277 RVA: 0x0104A4B4 File Offset: 0x010486B4
		private void UpdatePlotMode()
		{
			if (this.CurrentPlotMode == null || this.CurrentPlotMode.UiStyle == null || this.CurrentPlotMode.UiStyle.UiStyle == null || this.DialogText == null)
			{
				return;
			}
			IUiStylePlayPianoOfLevelD uiStylePlayPianoOfLevelD = this.CurrentPlotMode.UiStyle.UiStyle as IUiStylePlayPianoOfLevelD;
			EPlayPianoFadeInEffect? fadeInEffect = uiStylePlayPianoOfLevelD.FadeInEffect;
			this.SubtitleFadeInEffect = ((fadeInEffect != null) ? new int?((int)fadeInEffect.GetValueOrDefault()) : null).GetValueOrDefault();
			EPlayPianoFadeOutEffect? fadeOutEffect = uiStylePlayPianoOfLevelD.FadeOutEffect;
			this.SubtitleFadeOutEffect = ((fadeOutEffect != null) ? new int?((int)fadeOutEffect.GetValueOrDefault()) : null).GetValueOrDefault();
			this.DialogText.SetFontSize((float)uiStylePlayPianoOfLevelD.FontSize);
			this.RefreshDialogTextLayout();
			if (PianoGameplayModel.Instance.UiTextDebugEnable)
			{
				this.DialogTextDelayHideDuration = PianoGameplayModel.Instance.UiTextDebugFixedDuration.GetValueOrDefault();
				return;
			}
			this.DialogTextDelayHideDuration = uiStylePlayPianoOfLevelD.Duration * 1000f;
		}

		// Token: 0x06039EDE RID: 237278 RVA: 0x0104A5C4 File Offset: 0x010487C4
		private void PlayNextTalk()
		{
			this.StopCurrentTalk();
			this.CurrentTalkItemIndex++;
			if (this.CurrentTalkItemIndex >= this.CurrentShowTalk.TalkItems.Count)
			{
				UUIItem dialogTextItem = this.DialogTextItem;
				if (dialogTextItem != null)
				{
					dialogTextItem.SetUIActive(false);
				}
				this.ToggleEnableMoveInput(true);
				this.DebugHasNextTalk = false;
				return;
			}
			this.CurrentTalkItem = this.CurrentShowTalk.TalkItems[this.CurrentTalkItemIndex];
			this.DialogText.SetText("", true);
			if (this.AudioComp == null)
			{
				this.AudioComp = new PlotTextAudioComponent();
				this.AudioComp.Init(new PlotTextAudioComponentContext
				{
					OnAudioStartDelegate = new Action(this.OnAudioStart),
					OnAudioEndDelegate = new Action(this.OnAudioEnd),
					OnAudioLoadTimeoutDelegate = new Action(this.OnAudioEnd)
				});
			}
			this.IsWaitingAudioStart = true;
			this.IsAudioPlaying = true;
			if (!this.AudioComp.TryPlayTalkAudioByTalkItem(this.CurrentTalkItem))
			{
				this.OnAudioEnd();
			}
		}

		// Token: 0x06039EDF RID: 237279 RVA: 0x0104A6CC File Offset: 0x010488CC
		private void PlayTextAppear()
		{
			this.IsWaitingAudioStart = false;
			LguiUtil.Instance.SetLocalTextNew(this.DialogText, this.CurrentTalkItem.TidTalk ?? "", Array.Empty<object>());
			this.IsTextWriterPlaying = true;
			if (this.SubtitleAnimPlayer.HasFadeIn(this.SubtitleFadeInEffect))
			{
				this.SubtitleAnimPlayer.PlayIn(this.SubtitleFadeInEffect, new Action(this.OnTextAppearComplete));
				return;
			}
			if (this.WriterComp != null)
			{
				this.WriterComp.Play();
				return;
			}
			this.SubtitleAnimPlayer.ShowImmediately();
			this.OnTextAppearComplete();
		}

		// Token: 0x06039EE0 RID: 237280 RVA: 0x0104A766 File Offset: 0x01048966
		private void ClearDelayHideTimer()
		{
			TimerHandle delayHideTimer = this.DelayHideTimer;
			if (delayHideTimer != null && delayHideTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.DelayHideTimer);
			}
			this.DelayHideTimer = null;
		}

		// Token: 0x06039EE1 RID: 237281 RVA: 0x0104A794 File Offset: 0x01048994
		private void StopCurrentTalk()
		{
			this.IsWaitingAudioStart = false;
			this.DebugHasNextTalk = false;
			this.IsAudioPlaying = false;
			this.IsTextWriterPlaying = false;
			this.IsSubtitleFadeOutPlaying = false;
			this.ClearDelayHideTimer();
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.Stop();
			}
			PlotTextAudioComponent audioComp = this.AudioComp;
			if (audioComp != null)
			{
				audioComp.StopAudio();
			}
			this.SubtitleAnimPlayer.Stop();
		}

		// Token: 0x06039EE2 RID: 237282 RVA: 0x0104A7F7 File Offset: 0x010489F7
		private void OnTextAppearComplete()
		{
			if (!this.IsTextWriterPlaying)
			{
				return;
			}
			this.IsTextWriterPlaying = false;
			this.TryStartDelayHideTimer();
		}

		// Token: 0x06039EE3 RID: 237283 RVA: 0x0104A80F File Offset: 0x01048A0F
		private void FinishCurrentTalk(float deltaTime)
		{
			this.ClearDelayHideTimer();
			if (this.IsSubtitleFadeOutPlaying)
			{
				return;
			}
			this.IsSubtitleFadeOutPlaying = true;
			this.SubtitleAnimPlayer.PlayOut(this.SubtitleFadeOutEffect, new Action(this.OnSubtitleFadeOutComplete));
		}

		// Token: 0x06039EE4 RID: 237284 RVA: 0x0104A844 File Offset: 0x01048A44
		private void OnSubtitleFadeOutComplete()
		{
			if (!this.IsSubtitleFadeOutPlaying)
			{
				return;
			}
			this.IsSubtitleFadeOutPlaying = false;
			this.PlayNextTalk();
		}

		// Token: 0x06039EE5 RID: 237285 RVA: 0x0104A85C File Offset: 0x01048A5C
		private void OnAudioStart()
		{
			if (!this.IsWaitingAudioStart)
			{
				return;
			}
			this.PlayTextAppear();
		}

		// Token: 0x06039EE6 RID: 237286 RVA: 0x0104A86D File Offset: 0x01048A6D
		private void OnAudioEnd()
		{
			if (!this.IsAudioPlaying)
			{
				return;
			}
			this.IsAudioPlaying = false;
			if (this.IsWaitingAudioStart)
			{
				this.PlayTextAppear();
				return;
			}
			this.TryStartDelayHideTimer();
		}

		// Token: 0x06039EE7 RID: 237287 RVA: 0x0104A894 File Offset: 0x01048A94
		private void TryStartDelayHideTimer()
		{
			if (this.IsTextWriterPlaying || this.IsAudioPlaying || this.IsSubtitleFadeOutPlaying || this.DelayHideTimer != null)
			{
				return;
			}
			if (this.DialogTextDelayHideDuration < 0f)
			{
				this.DebugHasNextTalk = true;
				return;
			}
			this.DebugHasNextTalk = false;
			this.DelayHideTimer = ((this.DialogTextDelayHideDuration < 20f) ? TimerSystem.Instance.Next(new TTimerAction(this.FinishCurrentTalk), null, null) : TimerSystem.Instance.Delay(new TTimerAction(this.FinishCurrentTalk), this.DialogTextDelayHideDuration, null, null, true, 1f));
		}

		// Token: 0x06039EE8 RID: 237288 RVA: 0x0104A92F File Offset: 0x01048B2F
		private void OnTextWriterAnimComplete()
		{
			if (this.SubtitleAnimPlayer.HasFadeIn(this.SubtitleFadeInEffect))
			{
				return;
			}
			this.OnTextAppearComplete();
		}

		// Token: 0x06039EE9 RID: 237289 RVA: 0x0104A94C File Offset: 0x01048B4C
		private void RefreshDialogTextLayout()
		{
			if (this.RootItem == null)
			{
				return;
			}
			float width = this.RootItem.GetWidth();
			float height = this.RootItem.GetHeight();
			PianoGameplayController.Instance.RefreshSplitScreenFov(width, height);
			if (this.DialogText != null)
			{
				SetPlotMode currentPlotMode = this.CurrentPlotMode;
				bool flag;
				if (currentPlotMode == null)
				{
					flag = (null != null);
				}
				else
				{
					IPlotModeUiStyleLevelD uiStyle = currentPlotMode.UiStyle;
					flag = (((uiStyle != null) ? uiStyle.UiStyle : null) != null);
				}
				if (flag)
				{
					UUIItem dialogTextItem = this.DialogTextItem;
					if (dialogTextItem == null || !dialogTextItem.bIsUIActive)
					{
						return;
					}
					IUiStylePlayPianoOfLevelD uiStylePlayPianoOfLevelD = this.CurrentPlotMode.UiStyle.UiStyle as IUiStylePlayPianoOfLevelD;
					if (uiStylePlayPianoOfLevelD.Position.X != null)
					{
						this.DialogText.SetAnchorOffsetX(width * uiStylePlayPianoOfLevelD.Position.X.Value);
					}
					if (uiStylePlayPianoOfLevelD.Position.Y != null)
					{
						this.DialogText.SetAnchorOffsetY(height * uiStylePlayPianoOfLevelD.Position.Y.Value);
					}
					if (uiStylePlayPianoOfLevelD.TextBoxSize.X != null)
					{
						float? num = uiStylePlayPianoOfLevelD.TextBoxSize.X;
						float num2 = 0f;
						if (num.GetValueOrDefault() > num2 & num != null)
						{
							this.DialogText.SetWidth(width * uiStylePlayPianoOfLevelD.TextBoxSize.X.Value);
						}
					}
					if (uiStylePlayPianoOfLevelD.TextBoxSize.Y != null)
					{
						float? num = uiStylePlayPianoOfLevelD.TextBoxSize.Y;
						float num2 = 0f;
						if (num.GetValueOrDefault() > num2 & num != null)
						{
							this.DialogText.SetHeight(height * uiStylePlayPianoOfLevelD.TextBoxSize.Y.Value);
						}
					}
					return;
				}
			}
		}

		// Token: 0x06039EEA RID: 237290 RVA: 0x0104AB05 File Offset: 0x01048D05
		private void OnPianoGameplayStageChanged(EPianoGameplayStage stage)
		{
			this.ToggleEnableMoveInput(stage == EPianoGameplayStage.Normal);
			if (stage == EPianoGameplayStage.Normal)
			{
				this.PlayTipsTweens(this.TipsInTweens);
			}
		}

		// Token: 0x06039EEB RID: 237291 RVA: 0x0104AB21 File Offset: 0x01048D21
		private void TryPlayTipsOut()
		{
			if (PianoGameplayModel.Instance.GameplayStage != EPianoGameplayStage.Normal || !this.IsFirstInput)
			{
				return;
			}
			this.IsFirstInput = false;
			this.StopTipsTweens(this.TipsInTweens);
			this.PlayTipsTweens(this.TipsOutTweens);
		}

		// Token: 0x06039EEC RID: 237292 RVA: 0x0104AB58 File Offset: 0x01048D58
		private unsafe void InitTips()
		{
			this.TipsInTweens = Array.Empty<ULGUIPlayTweenComponent>();
			this.TipsOutTweens = Array.Empty<ULGUIPlayTweenComponent>();
			UUIItem item = base.GetItem(15);
			UUIItem item2 = base.GetItem(16);
			ULGUIPlayTweenComponent[] tipsTweens = this.GetTipsTweens(item);
			ULGUIPlayTweenComponent[] tipsTweens2 = this.GetTipsTweens(item2);
			if (tipsTweens.Length == 0 || tipsTweens2.Length == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "提示动画节点或Tween缺失，按无动画处理";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TipsIn", 15);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TipsInCount", tipsTweens.Length);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TipsOut", 16);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TipsOutCount", tipsTweens2.Length);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			this.TipsInTweens = tipsTweens;
			this.TipsOutTweens = tipsTweens2;
		}

		// Token: 0x06039EED RID: 237293 RVA: 0x0104AC54 File Offset: 0x01048E54
		private ULGUIPlayTweenComponent[] GetTipsTweens([Nullable(2)] UUIItem item)
		{
			AActor aactor = (item != null && item.IsValid()) ? item.GetOwner() : null;
			if (aactor == null)
			{
				return Array.Empty<ULGUIPlayTweenComponent>();
			}
			TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(num);
			for (int i = 0; i < num; i++)
			{
				ULGUIPlayTweenComponent ulguiplayTweenComponent = tarray.Get(i) as ULGUIPlayTweenComponent;
				if (ulguiplayTweenComponent != null && ulguiplayTweenComponent.IsValid() && ulguiplayTweenComponent.GetPlayTween() != null)
				{
					list.Add(ulguiplayTweenComponent);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06039EEE RID: 237294 RVA: 0x0104ACE4 File Offset: 0x01048EE4
		private void PlayTipsTweens(ULGUIPlayTweenComponent[] tweens)
		{
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in tweens)
			{
				if (ulguiplayTweenComponent.IsValid())
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06039EEF RID: 237295 RVA: 0x0104AD14 File Offset: 0x01048F14
		private void StopTipsTweens(ULGUIPlayTweenComponent[] tweens)
		{
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in tweens)
			{
				if (ulguiplayTweenComponent.IsValid())
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x06039EF0 RID: 237296 RVA: 0x0104AD44 File Offset: 0x01048F44
		private void OnUiTextEnableUseDebugFixedDuration(bool enable, float duration)
		{
			TimerHandle delayHideTimer = this.DelayHideTimer;
			bool flag = delayHideTimer != null && delayHideTimer.Valid();
			this.ClearDelayHideTimer();
			if (enable)
			{
				this.DialogTextDelayHideDuration = duration;
			}
			else
			{
				SetPlotMode currentPlotMode = this.CurrentPlotMode;
				bool flag2;
				if (currentPlotMode == null)
				{
					flag2 = (null != null);
				}
				else
				{
					IPlotModeUiStyleLevelD uiStyle = currentPlotMode.UiStyle;
					flag2 = (((uiStyle != null) ? uiStyle.UiStyle : null) != null);
				}
				if (flag2)
				{
					IUiStylePlayPianoOfLevelD uiStylePlayPianoOfLevelD = this.CurrentPlotMode.UiStyle.UiStyle as IUiStylePlayPianoOfLevelD;
					this.DialogTextDelayHideDuration = uiStylePlayPianoOfLevelD.Duration * 1000f;
				}
			}
			if (flag || this.DebugHasNextTalk)
			{
				this.TryStartDelayHideTimer();
			}
		}

		// Token: 0x06039EF1 RID: 237297 RVA: 0x0104ADD0 File Offset: 0x01048FD0
		private void DebugShowWidthHeightRatio()
		{
			if (PianoGameplayModel.Instance.UiTextDebugShowWidthHeightRatio)
			{
				UUIItem dialogTextItem = this.DialogTextItem;
				if (dialogTextItem != null && dialogTextItem.bIsUIActive)
				{
					UWorld world = GlobalData.World;
					if (world == null)
					{
						return;
					}
					float width = this.RootItem.GetWidth();
					float height = this.RootItem.GetHeight();
					float value = this.DialogTextItem.GetWidth() / width;
					float value2 = this.DialogTextItem.GetHeight() / height;
					float value3 = this.DialogTextItem.GetAnchorOffsetX() / width;
					float value4 = this.DialogTextItem.GetAnchorOffsetY() / height;
					UObject worldContextObject = world;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 4);
					defaultInterpolatedStringHandler.AppendLiteral("当前UI字幕宽高比: [");
					defaultInterpolatedStringHandler.AppendFormatted<float>(value);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<float>(value2);
					defaultInterpolatedStringHandler.AppendLiteral("]\n 当前UI字幕位置比例: [");
					defaultInterpolatedStringHandler.AppendFormatted<float>(value3);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<float>(value4);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					UKismetSystemLibrary.PrintString(worldContextObject, defaultInterpolatedStringHandler.ToStringAndClear(), true, true, new FLinearColor?(new FLinearColor(0f, 1f, 0f, 1f)), 5f);
					return;
				}
			}
		}

		// Token: 0x0401EA00 RID: 125440
		private readonly HashSet<string> PressedKey = new HashSet<string>();

		// Token: 0x0401EA01 RID: 125441
		[Nullable(2)]
		private PianoGameplayCaptionPanel CaptionPanel;

		// Token: 0x0401EA02 RID: 125442
		[Nullable(2)]
		private UUIItem ContentItem;

		// Token: 0x0401EA03 RID: 125443
		[Nullable(2)]
		private UUIText DialogText;

		// Token: 0x0401EA04 RID: 125444
		[Nullable(2)]
		private UUIItem DialogTextItem;

		// Token: 0x0401EA05 RID: 125445
		[Nullable(2)]
		private ITalkItem CurrentTalkItem;

		// Token: 0x0401EA06 RID: 125446
		private int CurrentTalkItemIndex;

		// Token: 0x0401EA07 RID: 125447
		[Nullable(2)]
		private ShowTalk CurrentShowTalk;

		// Token: 0x0401EA08 RID: 125448
		[Nullable(2)]
		private SetPlotMode CurrentPlotMode;

		// Token: 0x0401EA09 RID: 125449
		[Nullable(2)]
		private UUIEffectTextAnimation TextAnimComp;

		// Token: 0x0401EA0A RID: 125450
		[Nullable(2)]
		private ULGUIPlayTweenComponent TweenComp;

		// Token: 0x0401EA0B RID: 125451
		[Nullable(2)]
		private PlotTextWriterComponent WriterComp;

		// Token: 0x0401EA0C RID: 125452
		[Nullable(2)]
		private PlotTextAudioComponent AudioComp;

		// Token: 0x0401EA0D RID: 125453
		private float DialogTextDelayHideDuration;

		// Token: 0x0401EA0E RID: 125454
		private bool IsAudioPlaying;

		// Token: 0x0401EA0F RID: 125455
		private bool IsWaitingAudioStart;

		// Token: 0x0401EA10 RID: 125456
		private bool IsTextWriterPlaying;

		// Token: 0x0401EA11 RID: 125457
		[Nullable(2)]
		private TimerHandle DelayHideTimer;

		// Token: 0x0401EA12 RID: 125458
		private bool DisableMove;

		// Token: 0x0401EA13 RID: 125459
		[Nullable(2)]
		private Joystick MobileJoystick;

		// Token: 0x0401EA14 RID: 125460
		private EBoundInputMode CurrentInputMode;

		// Token: 0x0401EA15 RID: 125461
		private bool DebugHasNextTalk;

		// Token: 0x0401EA16 RID: 125462
		private readonly PianoSubtitleAnimPlayer SubtitleAnimPlayer = new PianoSubtitleAnimPlayer();

		// Token: 0x0401EA17 RID: 125463
		private int SubtitleFadeInEffect;

		// Token: 0x0401EA18 RID: 125464
		private int SubtitleFadeOutEffect;

		// Token: 0x0401EA19 RID: 125465
		private bool IsSubtitleFadeOutPlaying;

		// Token: 0x0401EA1A RID: 125466
		private ULGUIPlayTweenComponent[] TipsInTweens = Array.Empty<ULGUIPlayTweenComponent>();

		// Token: 0x0401EA1B RID: 125467
		private ULGUIPlayTweenComponent[] TipsOutTweens = Array.Empty<ULGUIPlayTweenComponent>();

		// Token: 0x0401EA1C RID: 125468
		private bool IsFirstInput = true;

		// Token: 0x0200B78D RID: 46989
		[Nullable(0)]
		private sealed class PianoGameplayJoystick : Joystick
		{
			// Token: 0x06047FBA RID: 294842 RVA: 0x015EFB66 File Offset: 0x015EDD66
			public PianoGameplayJoystick(Action onMoveInput)
			{
				this.OnMoveInput = onMoveInput;
			}

			// Token: 0x06047FBB RID: 294843 RVA: 0x015EFB75 File Offset: 0x015EDD75
			protected override void OnWalk()
			{
				base.OnWalk();
				this.OnMoveInput();
			}

			// Token: 0x06047FBC RID: 294844 RVA: 0x015EFB88 File Offset: 0x015EDD88
			protected override void OnRun()
			{
				base.OnRun();
				this.OnMoveInput();
			}

			// Token: 0x04038B7D RID: 232317
			private readonly Action OnMoveInput;
		}
	}
}
