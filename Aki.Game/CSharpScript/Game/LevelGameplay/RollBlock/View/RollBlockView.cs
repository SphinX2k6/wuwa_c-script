using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.View
{
	// Token: 0x02006AAA RID: 27306
	[NullableContext(2)]
	[Nullable(0)]
	public class RollBlockView : UiViewBase
	{
		// Token: 0x06043D61 RID: 277857 RVA: 0x0109E920 File Offset: 0x0109CB20
		[NullableContext(1)]
		public RollBlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043D62 RID: 277858 RVA: 0x0109E92C File Offset: 0x0109CB2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnSwitchButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnResetButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnBackButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnTipButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnHelpButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06043D63 RID: 277859 RVA: 0x0109EC58 File Offset: 0x0109CE58
		protected void AddEventListener()
		{
			if (this.IsAddedEventListener)
			{
				return;
			}
			this.IsAddedEventListener = true;
			this.AddInputEvent();
			this.BindButtonEvent();
			EventSystem.Instance.Add(EEventName.ShowRollBlockTips, new Action(this.ShowRollBlockTips));
			if (!EventSystem.Instance.Has(EEventName.OnRollBlockReseting, new Action<ERollBlockResetPhase>(this.OnRollBlockReseting)))
			{
				EventSystem.Instance.Add(EEventName.OnRollBlockReseting, new Action<ERollBlockResetPhase>(this.OnRollBlockReseting));
			}
		}

		// Token: 0x06043D64 RID: 277860 RVA: 0x0109ECD8 File Offset: 0x0109CED8
		protected void RemoveEventListener(bool removeByReset = false)
		{
			this.IsAddedEventListener = false;
			this.RemoveInputEvent();
			this.RemoveButtonEvent();
			if (EventSystem.Instance.Has(EEventName.ShowRollBlockTips, new Action(this.ShowRollBlockTips)))
			{
				EventSystem.Instance.Remove(EEventName.ShowRollBlockTips, new Action(this.ShowRollBlockTips));
			}
			if (!removeByReset)
			{
				EventSystem.Instance.Remove(EEventName.OnRollBlockReseting, new Action<ERollBlockResetPhase>(this.OnRollBlockReseting));
			}
		}

		// Token: 0x06043D65 RID: 277861 RVA: 0x0109ED50 File Offset: 0x0109CF50
		protected override void OnRemoveEventListener()
		{
			this.RemoveEventListener(false);
		}

		// Token: 0x06043D66 RID: 277862 RVA: 0x0109ED5C File Offset: 0x0109CF5C
		private void AddInputEvent()
		{
			InputDistributeController.Instance.BindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06043D67 RID: 277863 RVA: 0x0109EE0C File Offset: 0x0109D00C
		private void RemoveInputEvent()
		{
			InputDistributeController.Instance.UnBindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06043D68 RID: 277864 RVA: 0x0109EEBC File Offset: 0x0109D0BC
		private void BindButtonEvent()
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.OnPointDownCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向左移动", InputDistributeDefine.EActionType.Press);
				});
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 != null)
			{
				button2.OnPointUpCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向左移动", InputDistributeDefine.EActionType.Release);
				});
			}
			UUIButtonComponent button3 = base.GetButton(2);
			if (button3 != null)
			{
				button3.OnPointDownCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向右移动", InputDistributeDefine.EActionType.Press);
				});
			}
			UUIButtonComponent button4 = base.GetButton(2);
			if (button4 != null)
			{
				button4.OnPointUpCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向右移动", InputDistributeDefine.EActionType.Release);
				});
			}
			UUIButtonComponent button5 = base.GetButton(3);
			if (button5 != null)
			{
				button5.OnPointDownCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向前移动", InputDistributeDefine.EActionType.Press);
				});
			}
			UUIButtonComponent button6 = base.GetButton(3);
			if (button6 != null)
			{
				button6.OnPointUpCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向前移动", InputDistributeDefine.EActionType.Release);
				});
			}
			UUIButtonComponent button7 = base.GetButton(4);
			if (button7 != null)
			{
				button7.OnPointDownCallBack.Bind(delegate()
				{
					RollBlockController.Instance.OnClickMoveInput("向后移动", InputDistributeDefine.EActionType.Press);
				});
			}
			UUIButtonComponent button8 = base.GetButton(4);
			if (button8 == null)
			{
				return;
			}
			button8.OnPointUpCallBack.Bind(delegate()
			{
				RollBlockController.Instance.OnClickMoveInput("向后移动", InputDistributeDefine.EActionType.Release);
			});
		}

		// Token: 0x06043D69 RID: 277865 RVA: 0x0109F078 File Offset: 0x0109D278
		private void RemoveButtonEvent()
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 != null)
			{
				button2.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button3 = base.GetButton(2);
			if (button3 != null)
			{
				button3.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button4 = base.GetButton(2);
			if (button4 != null)
			{
				button4.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button5 = base.GetButton(3);
			if (button5 != null)
			{
				button5.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button6 = base.GetButton(3);
			if (button6 != null)
			{
				button6.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button7 = base.GetButton(4);
			if (button7 != null)
			{
				button7.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button8 = base.GetButton(4);
			if (button8 == null)
			{
				return;
			}
			button8.OnPointUpCallBack.Unbind();
		}

		// Token: 0x06043D6A RID: 277866 RVA: 0x0109F13C File Offset: 0x0109D33C
		private bool CanInput()
		{
			EUiViewName[] array = InputDistributeModel.Instance.GetNotAllowFightInputViewNameSet().ToArray<EUiViewName>();
			return array.Length != 0 && !(array[array.Length - 1] != this.ViewInfo.Name);
		}

		// Token: 0x06043D6B RID: 277867 RVA: 0x0109F180 File Offset: 0x0109D380
		[NullableContext(1)]
		private void OnAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!this.CanInput())
			{
				return;
			}
			if (axisName == "NavigationTopDown" && Math.Abs(this.ForwardInputValue - value) > 1E-08f)
			{
				if (value > 0.5f && this.ForwardInputValue <= 0.5f)
				{
					RollBlockController.Instance.OnClickMoveInput("向后移动", InputDistributeDefine.EActionType.Release);
					RollBlockController.Instance.OnClickMoveInput("向前移动", InputDistributeDefine.EActionType.Press);
				}
				else if (value < -0.5f && this.ForwardInputValue >= -0.5f)
				{
					RollBlockController.Instance.OnClickMoveInput("向前移动", InputDistributeDefine.EActionType.Release);
					RollBlockController.Instance.OnClickMoveInput("向后移动", InputDistributeDefine.EActionType.Press);
				}
				else if (value > -0.5f && value < 0.5f)
				{
					RollBlockController.Instance.OnClickMoveInput((this.ForwardInputValue > 0f) ? "向前移动" : "向后移动", InputDistributeDefine.EActionType.Release);
				}
				this.ForwardInputValue = value;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[input] ForwardInputValue";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", this.ForwardInputValue);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (axisName == "NavigationLeftRight" && Math.Abs(this.RightInputValue - value) > 1E-08f)
			{
				if (value > 0.5f && this.RightInputValue <= 0.5f)
				{
					RollBlockController.Instance.OnClickMoveInput("向左移动", InputDistributeDefine.EActionType.Release);
					RollBlockController.Instance.OnClickMoveInput("向右移动", InputDistributeDefine.EActionType.Press);
				}
				else if (value < -0.5f && this.RightInputValue >= -0.5f)
				{
					RollBlockController.Instance.OnClickMoveInput("向右移动", InputDistributeDefine.EActionType.Release);
					RollBlockController.Instance.OnClickMoveInput("向左移动", InputDistributeDefine.EActionType.Press);
				}
				else if (value > -0.5f && value < 0.5f)
				{
					RollBlockController.Instance.OnClickMoveInput((this.RightInputValue > 0f) ? "向右移动" : "向左移动", InputDistributeDefine.EActionType.Release);
				}
				this.RightInputValue = value;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[input] RightInputValue";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Value", this.RightInputValue);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}

		// Token: 0x06043D6C RID: 277868 RVA: 0x0109F3A0 File Offset: 0x0109D5A0
		[NullableContext(1)]
		private unsafe void OnInput(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!this.CanInput() && actionType == InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (actionName == "UI方向上")
			{
				RollBlockController.Instance.OnClickMoveInput("向前移动", actionType);
			}
			else if (actionName == "UI方向下")
			{
				RollBlockController.Instance.OnClickMoveInput("向后移动", actionType);
			}
			else if (actionName == "UI方向左")
			{
				RollBlockController.Instance.OnClickMoveInput("向左移动", actionType);
			}
			else if (actionName == "UI方向右")
			{
				RollBlockController.Instance.OnClickMoveInput("向右移动", actionType);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RollBlock;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[input] OnInput";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionName", actionName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionType", actionType.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06043D6D RID: 277869 RVA: 0x0109F498 File Offset: 0x0109D698
		private void ShowRollBlockTips()
		{
			UUIItem pnlTips = this.PnlTips;
			if (pnlTips != null && pnlTips.bIsUIActive)
			{
				return;
			}
			UUIItem pnlTips2 = this.PnlTips;
			if (pnlTips2 != null)
			{
				pnlTips2.SetUIActive(true);
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("TipsIn", false, null, false);
		}

		// Token: 0x06043D6E RID: 277870 RVA: 0x0109F4EC File Offset: 0x0109D6EC
		private void OnRollBlockReseting(ERollBlockResetPhase resetPhase)
		{
			switch (resetPhase)
			{
			case ERollBlockResetPhase.Start:
				this.RemoveEventListener(true);
				return;
			case ERollBlockResetPhase.Failure:
				this.AddEventListener();
				return;
			case ERollBlockResetPhase.Succeed:
			{
				UUIItem pnlAll = this.PnlAll;
				if (pnlAll != null)
				{
					pnlAll.SetUIActive(false);
				}
				EventSystem.Instance.Once(EEventName.RollBlockAllCompleted, new Action(this.OnRollBlockAllCompleted));
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06043D6F RID: 277871 RVA: 0x0109F54C File Offset: 0x0109D74C
		protected override void OnBeforeShow()
		{
			this.PnlAll = base.GetItem(13);
			UUIItem pnlAll = this.PnlAll;
			if (pnlAll != null)
			{
				pnlAll.SetUIActive(false);
			}
			this.PnlTips = base.GetItem(8);
			UUIItem pnlTips = this.PnlTips;
			if (pnlTips != null)
			{
				pnlTips.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(6);
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
			this.BtnReset = (obj as UUIItem);
			BP_RollBlockGameplaySetting_C gameplaySetting = RollBlockController.Instance.GameplaySetting;
			int currentDifficulty = RollBlockController.Instance.GetCurrentDifficulty();
			int totalDifficulty = RollBlockController.Instance.GetTotalDifficulty();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), gameplaySetting.RollBlockMainTipKey, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), gameplaySetting.RollBlockSecondTipKey, new <>z__ReadOnlyArray<object>(new object[]
			{
				currentDifficulty,
				totalDifficulty
			}));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), gameplaySetting.RollBlockPhantomTipKey, Array.Empty<object>());
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (playerGender == EPlayerGender.None)
			{
				return;
			}
			UiResource? uiResource;
			string text = (ConfigUiResourceById.GetConfig((playerGender == EPlayerGender.Male) ? "SP_CubeMoveTipIconM" : "SP_CubeMoveTipIconF", true) != null) ? uiResource.GetValueOrDefault().Path : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(text, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
			{
				if (sprite == null || !sprite.IsValid())
				{
					return;
				}
				UUISprite sprite2 = base.GetSprite(10);
				if (sprite2 == null)
				{
					return;
				}
				sprite2.SetSprite(sprite, true);
			}, 100, "js_undefined");
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			}
			EventSystem.Instance.Once(EEventName.RollBlockAllCompleted, new Action(this.OnRollBlockAllCompleted));
		}

		// Token: 0x06043D70 RID: 277872 RVA: 0x0109F717 File Offset: 0x0109D917
		protected override void OnBeforeDestroy()
		{
			if (this.ResetButtonCDTimerHandle != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.ResetButtonCDTimerHandle);
			}
			this.ResetButtonCDTimerHandle = null;
		}

		// Token: 0x06043D71 RID: 277873 RVA: 0x0109F739 File Offset: 0x0109D939
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start01")
			{
				this.AddEventListener();
			}
		}

		// Token: 0x06043D72 RID: 277874 RVA: 0x0109F750 File Offset: 0x0109D950
		private void OnRollBlockAllCompleted()
		{
			UUIButtonComponent button = base.GetButton(5);
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
			(obj as UUIItem).SetUIActive(RollBlockController.Instance.GetIsMultiBlock());
			UUIItem pnlAll = this.PnlAll;
			if (pnlAll != null)
			{
				pnlAll.SetUIActive(true);
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}
			RollBlockController.Instance.NotifyServerShowAllBlock();
			UUIItem btnReset = this.BtnReset;
			if (btnReset != null)
			{
				btnReset.SetUIActive(false);
			}
			if (this.ResetButtonCDTimerHandle != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.ResetButtonCDTimerHandle);
			}
			this.ResetButtonCDTimerHandle = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				this.ResetButtonCDTimerHandle = null;
				UUIItem btnReset2 = this.BtnReset;
				if (btnReset2 == null)
				{
					return;
				}
				btnReset2.SetUIActive(true);
			}, 4000f, null, null, true, 1f);
		}

		// Token: 0x06043D73 RID: 277875 RVA: 0x0109F82B File Offset: 0x0109DA2B
		private void OnSwitchButtonClick()
		{
			RollBlockController.Instance.OnClickSwitch();
		}

		// Token: 0x06043D74 RID: 277876 RVA: 0x0109F837 File Offset: 0x0109DA37
		private void OnResetButtonClick()
		{
			RollBlockController.Instance.OnClickReset(false, false);
		}

		// Token: 0x06043D75 RID: 277877 RVA: 0x0109F845 File Offset: 0x0109DA45
		private void OnBackButtonClick()
		{
			RollBlockController.Instance.OnClickEsc();
		}

		// Token: 0x06043D76 RID: 277878 RVA: 0x0109F851 File Offset: 0x0109DA51
		private void OnTipButtonClick()
		{
			RollBlockController.Instance.OnClickTip();
		}

		// Token: 0x06043D77 RID: 277879 RVA: 0x0109F85D File Offset: 0x0109DA5D
		private void OnHelpButtonClick()
		{
			TutorialController.Instance.OpenExclusiveTutorial(EExclusiveTutorialType.RollBlock);
		}

		// Token: 0x04023740 RID: 145216
		private float ForwardInputValue;

		// Token: 0x04023741 RID: 145217
		private float RightInputValue;

		// Token: 0x04023742 RID: 145218
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04023743 RID: 145219
		private UUIItem PnlAll;

		// Token: 0x04023744 RID: 145220
		private UUIItem PnlTips;

		// Token: 0x04023745 RID: 145221
		private UUIItem BtnReset;

		// Token: 0x04023746 RID: 145222
		private bool IsAddedEventListener;

		// Token: 0x04023747 RID: 145223
		private TimerHandle ResetButtonCDTimerHandle;
	}
}
