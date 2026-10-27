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
	// Token: 0x02006A68 RID: 27240
	[NullableContext(2)]
	[Nullable(0)]
	public class SeekTraceView : UiTickViewBase
	{
		// Token: 0x06043B98 RID: 277400 RVA: 0x01093D83 File Offset: 0x01091F83
		[NullableContext(1)]
		public SeekTraceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043B99 RID: 277401 RVA: 0x01093D8C File Offset: 0x01091F8C
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

		// Token: 0x06043B9A RID: 277402 RVA: 0x01093E38 File Offset: 0x01092038
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add(EEventName.SeekTraceMoveActionInput, new Action<ESeekTraceMoveDirection, bool>(this.MoveActionInput));
			EventSystem.Instance.Add<ESeekTraceMoveDirection, float>(EEventName.SeekTraceMoveAxisInput, new Action<ESeekTraceMoveDirection, float>(this.MoveAxisInput));
			EventSystem.Instance.Add(EEventName.SeekTraceSelectItemInput, new Action(this.SelectItemInput));
			EventSystem.Instance.Add(EEventName.SeekTraceResetItemInput, new Action(this.ResetItemInput));
		}

		// Token: 0x06043B9B RID: 277403 RVA: 0x01093EF0 File Offset: 0x010920F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.SeekTraceMoveActionInput, new Action<ESeekTraceMoveDirection, bool>(this.MoveActionInput));
			EventSystem.Instance.Remove(EEventName.SeekTraceMoveAxisInput, new Action<ESeekTraceMoveDirection, float>(this.MoveAxisInput));
			EventSystem.Instance.Remove(EEventName.SeekTraceSelectItemInput, new Action(this.SelectItemInput));
			EventSystem.Instance.Remove(EEventName.SeekTraceResetItemInput, new Action(this.ResetItemInput));
		}

		// Token: 0x06043B9C RID: 277404 RVA: 0x01093FA5 File Offset: 0x010921A5
		private void OnCloseRewardView()
		{
			if (this.WaitRewardViewClose)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06043B9D RID: 277405 RVA: 0x01093FB6 File Offset: 0x010921B6
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.OnInputControllerChange();
		}

		// Token: 0x06043B9E RID: 277406 RVA: 0x01093FC8 File Offset: 0x010921C8
		protected override UniTask OnBeforeStartAsync()
		{
			SeekTraceView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SeekTraceView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043B9F RID: 277407 RVA: 0x0109400C File Offset: 0x0109220C
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

		// Token: 0x06043BA0 RID: 277408 RVA: 0x0109406E File Offset: 0x0109226E
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

		// Token: 0x06043BA1 RID: 277409 RVA: 0x0109409C File Offset: 0x0109229C
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

		// Token: 0x06043BA2 RID: 277410 RVA: 0x0109417B File Offset: 0x0109237B
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

		// Token: 0x06043BA3 RID: 277411 RVA: 0x010941A0 File Offset: 0x010923A0
		private void OnResetClick()
		{
			if (!SeekTraceModel.Instance.IsGameFinish)
			{
				this.ResetSeekTrace("CrossLine_Reset_Tips");
			}
		}

		// Token: 0x06043BA4 RID: 277412 RVA: 0x010941BC File Offset: 0x010923BC
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

		// Token: 0x06043BA5 RID: 277413 RVA: 0x010941F8 File Offset: 0x010923F8
		private void OnSelectedItem()
		{
			base.GetItem(0).SetUIActive(false);
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06043BA6 RID: 277414 RVA: 0x0109422C File Offset: 0x0109242C
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

		// Token: 0x06043BA7 RID: 277415 RVA: 0x010942A8 File Offset: 0x010924A8
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

		// Token: 0x06043BA8 RID: 277416 RVA: 0x010942FA File Offset: 0x010924FA
		private void PlayRefreshStepText(int value)
		{
			base.GetText(2).SetText(value.ToString(), true);
		}

		// Token: 0x06043BA9 RID: 277417 RVA: 0x01094310 File Offset: 0x01092510
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

		// Token: 0x06043BAA RID: 277418 RVA: 0x0109434E File Offset: 0x0109254E
		private void RefreshStepText()
		{
			base.GetText(2).SetText(SeekTraceModel.Instance.StepLimit.ToString(), true);
		}

		// Token: 0x06043BAB RID: 277419 RVA: 0x0109436C File Offset: 0x0109256C
		private void MoveAxisInput(ESeekTraceMoveDirection direction, float value)
		{
			SeekTraceJoystickInput joystickInput = this.JoystickInput;
			if (joystickInput == null)
			{
				return;
			}
			joystickInput.MoveAxisInput(direction, (double)value);
		}

		// Token: 0x06043BAC RID: 277420 RVA: 0x01094381 File Offset: 0x01092581
		private void MoveActionInput(ESeekTraceMoveDirection direction, bool isPress)
		{
			SeekTraceJoystickInput joystickInput = this.JoystickInput;
			if (joystickInput == null)
			{
				return;
			}
			joystickInput.MoveActionInput(direction, isPress);
		}

		// Token: 0x06043BAD RID: 277421 RVA: 0x01094395 File Offset: 0x01092595
		private void SelectItemInput()
		{
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.GamePadSelectItem();
		}

		// Token: 0x06043BAE RID: 277422 RVA: 0x010943A7 File Offset: 0x010925A7
		private void ResetItemInput()
		{
			SeekTraceContentPanel contentPanel = this.ContentPanel;
			if (contentPanel == null)
			{
				return;
			}
			contentPanel.GamePadResetItem();
		}

		// Token: 0x06043BAF RID: 277423 RVA: 0x010943BC File Offset: 0x010925BC
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

		// Token: 0x04023621 RID: 144929
		private PopupCaptionItem CaptionItem;

		// Token: 0x04023622 RID: 144930
		private SeekTraceContentPanel ContentPanel;

		// Token: 0x04023623 RID: 144931
		private SeekTraceClawItem ClawItem;

		// Token: 0x04023624 RID: 144932
		private bool IsReseting;

		// Token: 0x04023625 RID: 144933
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04023626 RID: 144934
		private ULTweener Tweener;

		// Token: 0x04023627 RID: 144935
		private UCurveFloat ResetCurve;

		// Token: 0x04023628 RID: 144936
		private SeekTraceJoystickInput JoystickInput;

		// Token: 0x04023629 RID: 144937
		private bool WaitRewardViewClose;
	}
}
