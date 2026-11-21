using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.LineCross;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BC5 RID: 23493
	[NullableContext(2)]
	[Nullable(0)]
	public class SeekTraceView : UiTickViewBase
	{
		// Token: 0x06039BE6 RID: 236518 RVA: 0x010385B7 File Offset: 0x010367B7
		[NullableContext(1)]
		public SeekTraceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039BE7 RID: 236519 RVA: 0x010385C0 File Offset: 0x010367C0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnResetClick))
			};
		}

		// Token: 0x06039BE8 RID: 236520 RVA: 0x0103866C File Offset: 0x0103686C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add(EEventName.SeekTraceMoveActionInput, new Action<ESeekTraceMoveDirection, bool>(this.MoveActionInput));
			EventSystem.Instance.Add<ESeekTraceMoveDirection, float>(EEventName.SeekTraceMoveAxisInput, new Action<ESeekTraceMoveDirection, float>(this.MoveAxisInput));
			EventSystem.Instance.Add(EEventName.SeekTraceSelectItemInput, new Action(this.SelectItemInput));
			EventSystem.Instance.Add(EEventName.SeekTraceResetItemInput, new Action(this.ResetItemInput));
		}

		// Token: 0x06039BE9 RID: 236521 RVA: 0x01038724 File Offset: 0x01036924
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.SeekTraceMoveActionInput, new Action<ESeekTraceMoveDirection, bool>(this.MoveActionInput));
			EventSystem.Instance.Remove(EEventName.SeekTraceMoveAxisInput, new Action<ESeekTraceMoveDirection, float>(this.MoveAxisInput));
			EventSystem.Instance.Remove(EEventName.SeekTraceSelectItemInput, new Action(this.SelectItemInput));
			EventSystem.Instance.Remove(EEventName.SeekTraceResetItemInput, new Action(this.ResetItemInput));
		}

		// Token: 0x06039BEA RID: 236522 RVA: 0x010387D9 File Offset: 0x010369D9
		private void OnCloseRewardView()
		{
			if (this.WaitRewardViewClose)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06039BEB RID: 236523 RVA: 0x010387EA File Offset: 0x010369EA
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.OnInputControllerChange();
		}

		// Token: 0x06039BEC RID: 236524 RVA: 0x010387FC File Offset: 0x010369FC
		protected override UniTask OnBeforeStartAsync()
		{
			SeekTraceView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SeekTraceView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039BED RID: 236525 RVA: 0x01038840 File Offset: 0x01036A40
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
			this.RefreshStepText();
			this.JoystickInput = new SeekTraceJoystickInput();
			SeekTraceJoystickInput joystickInput = this.JoystickInput;
			if (joystickInput == null)
			{
				return;
			}
			joystickInput.RegisterMovePress(new Action<ESeekTraceMoveDirection>(this.OnMovePress));
		}

		// Token: 0x06039BEE RID: 236526 RVA: 0x010388A2 File Offset: 0x01036AA2
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.ResetCurve = null;
			LineCrossModel.Instance.CurrentChallengeFinishState = false;
		}

		// Token: 0x06039BEF RID: 236527 RVA: 0x010388D0 File Offset: 0x01036AD0
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Reset")
			{
				SeekTraceContentPanel contentPanel = this.ContentPanel;
				if (contentPanel != null)
				{
					contentPanel.SetInteractEnable(true);
				}
				this.IsReseting = false;
				return;
			}
			if (sequenceName == "Success")
			{
				if (!SeekTraceModel.Instance.RemainUiAfterCompletion || LineCrossModel.Instance.CurrentChallengeFinishState)
				{
					base.CloseMe(null);
				}
				else if (SeekTraceModel.Instance.RemainUiAfterCompletion && !LineCrossModel.Instance.CurrentChallengeFinishState)
				{
					this.WaitRewardViewClose = true;
				}
				if (LineCrossModel.Instance.CurrentChallengeFinishState)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("LineCross_Challenge_Pass", Array.Empty<object>());
				}
				int currentInteractEntityId = SeekTraceModel.Instance.CurrentInteractEntityId;
				Entity entity = EntitySystem.Instance.Get(currentInteractEntityId);
				if (entity == null || !entity.Active)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Gameplay_Locked", Array.Empty<object>());
				}
				SeekTraceController.FinishSeekTrace();
			}
		}

		// Token: 0x06039BF0 RID: 236528 RVA: 0x010389AF File Offset: 0x01036BAF
		protected override void OnTick(float delta)
		{
			SeekTraceJoystickInput joystickInput = this.JoystickInput;
			if (joystickInput != null)
			{
				joystickInput.Tick((double)delta);
			}
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.UpdateKeyBoardSelectFrame();
		}

		// Token: 0x06039BF1 RID: 236529 RVA: 0x010389D4 File Offset: 0x01036BD4
		private void OnResetClick()
		{
			if (!SeekTraceModel.Instance.IsGameFinish)
			{
				this.ResetSeekTrace("CrossLine_Reset_Tips");
			}
		}

		// Token: 0x06039BF2 RID: 236530 RVA: 0x010389F0 File Offset: 0x01036BF0
		private void OnCloseClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SeekTraceExit);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.CloseMe(null);
				SeekTraceController.FinishSeekTrace();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06039BF3 RID: 236531 RVA: 0x01038A2C File Offset: 0x01036C2C
		private void OnSelectedItem()
		{
			base.GetItem(0).SetUIActive(false);
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06039BF4 RID: 236532 RVA: 0x01038A60 File Offset: 0x01036C60
		private void OnPlacedItem()
		{
			base.GetItem(0).SetUIActive(true);
			base.GetButton(3).RootUIComp.Get().SetUIActive(true);
			SeekTraceModel instance = SeekTraceModel.Instance;
			this.RefreshStepText();
			if (!instance.IsGameFinish)
			{
				return;
			}
			if (!instance.GameFinishResult)
			{
				this.ResetSeekTrace("CrossLine_Fail_Tips");
				return;
			}
			this.SequencePlayer.PlaySequencePurely("Success", false, false);
			this.ContentPanel.OnSeekTraceSucceed();
		}

		// Token: 0x06039BF5 RID: 236533 RVA: 0x01038ADC File Offset: 0x01036CDC
		[NullableContext(1)]
		private void ResetSeekTrace(string tipsId)
		{
			if (this.IsReseting)
			{
				return;
			}
			this.IsReseting = true;
			int lastStep = SeekTraceModel.Instance.StepLimit;
			SeekTraceController.ResetSeekTrace(delegate
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(tipsId, Array.Empty<object>());
				this.SequencePlayer.PlaySequencePurely("Reset", false, false);
				SeekTraceContentPanel contentPanel = this.ContentPanel;
				if (contentPanel != null)
				{
					contentPanel.SetInteractEnable(false);
				}
				SeekTraceContentPanel contentPanel2 = this.ContentPanel;
				if (contentPanel2 != null)
				{
					contentPanel2.ResetView();
				}
				int stepLimit = SeekTraceModel.Instance.StepLimit;
				this.Tweener = ULTweenBPLibrary.IntTo(GlobalData.World, DelegateUtils.ToManualReleaseDelegate<FLTweenIntSetterDynamic>(new Action<int>(this.PlayRefreshStepText)), lastStep, stepLimit, 1f, 0f, LTweenEase.OutCubic);
				if (this.Tweener != null)
				{
					if (this.ResetCurve != null)
					{
						this.Tweener.SetEase(LTweenEase.CurveFloat);
						this.Tweener.SetCurveFloat(this.ResetCurve);
					}
					this.Tweener.OnCompleteCallBack.Bind(new Action(this.PlayRefreshStepTextComplete));
				}
			});
		}

		// Token: 0x06039BF6 RID: 236534 RVA: 0x01038B2E File Offset: 0x01036D2E
		private void PlayRefreshStepText(int value)
		{
			base.GetText(2).SetText(value.ToString(), true);
		}

		// Token: 0x06039BF7 RID: 236535 RVA: 0x01038B44 File Offset: 0x01036D44
		private void PlayRefreshStepTextComplete()
		{
			if (this.Tweener != null)
			{
				this.Tweener.Kill(false);
				this.Tweener.OnCompleteCallBack.Unbind();
				this.Tweener = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.PlayRefreshStepText));
		}

		// Token: 0x06039BF8 RID: 236536 RVA: 0x01038B82 File Offset: 0x01036D82
		private void RefreshStepText()
		{
			base.GetText(2).SetText(SeekTraceModel.Instance.StepLimit.ToString(), true);
		}

		// Token: 0x06039BF9 RID: 236537 RVA: 0x01038BA0 File Offset: 0x01036DA0
		private void MoveAxisInput(ESeekTraceMoveDirection direction, float value)
		{
			SeekTraceJoystickInput joystickInput = this.JoystickInput;
			if (joystickInput == null)
			{
				return;
			}
			joystickInput.MoveAxisInput(direction, (double)value);
		}

		// Token: 0x06039BFA RID: 236538 RVA: 0x01038BB5 File Offset: 0x01036DB5
		private void MoveActionInput(ESeekTraceMoveDirection direction, bool isPress)
		{
			SeekTraceJoystickInput joystickInput = this.JoystickInput;
			if (joystickInput == null)
			{
				return;
			}
			joystickInput.MoveActionInput(direction, isPress);
		}

		// Token: 0x06039BFB RID: 236539 RVA: 0x01038BC9 File Offset: 0x01036DC9
		private void SelectItemInput()
		{
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.GamePadSelectItem();
		}

		// Token: 0x06039BFC RID: 236540 RVA: 0x01038BDB File Offset: 0x01036DDB
		private void ResetItemInput()
		{
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.GamePadResetItem();
		}

		// Token: 0x06039BFD RID: 236541 RVA: 0x01038BF0 File Offset: 0x01036DF0
		private void OnMovePress(ESeekTraceMoveDirection direction)
		{
			int offsetX = 0;
			int offsetY = 0;
			switch (direction)
			{
			case ESeekTraceMoveDirection.Up:
				offsetY = -1;
				break;
			case ESeekTraceMoveDirection.Down:
				offsetY = 1;
				break;
			case ESeekTraceMoveDirection.Left:
				offsetX = -1;
				break;
			case ESeekTraceMoveDirection.Right:
				offsetX = 1;
				break;
			}
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.GamePadMovePosition(offsetX, offsetY);
		}

		// Token: 0x0401E813 RID: 124947
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401E814 RID: 124948
		private SeekTraceContentPanel ContentPanel;

		// Token: 0x0401E815 RID: 124949
		private SeekTraceClawItem ClawItem;

		// Token: 0x0401E816 RID: 124950
		private bool IsReseting;

		// Token: 0x0401E817 RID: 124951
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401E818 RID: 124952
		private ULTweener Tweener;

		// Token: 0x0401E819 RID: 124953
		private UCurveFloat ResetCurve;

		// Token: 0x0401E81A RID: 124954
		private SeekTraceJoystickInput JoystickInput;

		// Token: 0x0401E81B RID: 124955
		private bool WaitRewardViewClose;
	}
}
