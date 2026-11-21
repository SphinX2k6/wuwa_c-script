using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.View
{
	// Token: 0x02005C07 RID: 23559
	[NullableContext(2)]
	[Nullable(0)]
	public class RollBlockView : UiViewBase
	{
		// Token: 0x06039DB6 RID: 236982 RVA: 0x01043070 File Offset: 0x01041270
		[NullableContext(1)]
		public RollBlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039DB7 RID: 236983 RVA: 0x0104307C File Offset: 0x0104127C
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

		// Token: 0x06039DB8 RID: 236984 RVA: 0x010433A8 File Offset: 0x010415A8
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

		// Token: 0x06039DB9 RID: 236985 RVA: 0x01043428 File Offset: 0x01041628
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

		// Token: 0x06039DBA RID: 236986 RVA: 0x010434A0 File Offset: 0x010416A0
		protected override void OnRemoveEventListener()
		{
			this.RemoveEventListener(false);
		}

		// Token: 0x06039DBB RID: 236987 RVA: 0x010434AC File Offset: 0x010416AC
		private void AddInputEvent()
		{
			InputDistributeController.Instance.BindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06039DBC RID: 236988 RVA: 0x0104355C File Offset: 0x0104175C
		private void RemoveInputEvent()
		{
			InputDistributeController.Instance.UnBindAxis("NavigationTopDown", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAxis("NavigationLeftRight", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAction("UI方向上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI方向右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x06039DBD RID: 236989 RVA: 0x0104360C File Offset: 0x0104180C
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

		// Token: 0x06039DBE RID: 236990 RVA: 0x010437C8 File Offset: 0x010419C8
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

		// Token: 0x06039DBF RID: 236991 RVA: 0x0104388C File Offset: 0x01041A8C
		private bool CanInput()
		{
			HashSet<EUiViewName> notAllowFightInputViewNameSet = InputDistributeModel.Instance.GetNotAllowFightInputViewNameSet();
			EUiViewName[] array = new EUiViewName[notAllowFightInputViewNameSet.Count];
			notAllowFightInputViewNameSet.CopyTo(array);
			return array.Length != 0 && !(array[array.Length - 1] != this.ViewInfo.Name);
		}

		// Token: 0x06039DC0 RID: 236992 RVA: 0x010438DC File Offset: 0x01041ADC
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

		// Token: 0x06039DC1 RID: 236993 RVA: 0x01043AFC File Offset: 0x01041CFC
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

		// Token: 0x06039DC2 RID: 236994 RVA: 0x01043BF4 File Offset: 0x01041DF4
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

		// Token: 0x06039DC3 RID: 236995 RVA: 0x01043C48 File Offset: 0x01041E48
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

		// Token: 0x06039DC4 RID: 236996 RVA: 0x01043CA8 File Offset: 0x01041EA8
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

		// Token: 0x06039DC5 RID: 236997 RVA: 0x01043E73 File Offset: 0x01042073
		protected override void OnBeforeDestroy()
		{
			if (this.ResetButtonCDTimerHandle != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.ResetButtonCDTimerHandle);
			}
			this.ResetButtonCDTimerHandle = null;
		}

		// Token: 0x06039DC6 RID: 236998 RVA: 0x01043E95 File Offset: 0x01042095
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start01")
			{
				this.AddEventListener();
			}
		}

		// Token: 0x06039DC7 RID: 236999 RVA: 0x01043EAC File Offset: 0x010420AC
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

		// Token: 0x06039DC8 RID: 237000 RVA: 0x01043F87 File Offset: 0x01042187
		private void OnSwitchButtonClick()
		{
			RollBlockController.Instance.OnClickSwitch();
		}

		// Token: 0x06039DC9 RID: 237001 RVA: 0x01043F93 File Offset: 0x01042193
		private void OnResetButtonClick()
		{
			RollBlockController.Instance.OnClickReset(false, false);
		}

		// Token: 0x06039DCA RID: 237002 RVA: 0x01043FA1 File Offset: 0x010421A1
		private void OnBackButtonClick()
		{
			RollBlockController.Instance.OnClickEsc();
		}

		// Token: 0x06039DCB RID: 237003 RVA: 0x01043FAD File Offset: 0x010421AD
		private void OnTipButtonClick()
		{
			RollBlockController.Instance.OnClickTip();
		}

		// Token: 0x06039DCC RID: 237004 RVA: 0x01043FB9 File Offset: 0x010421B9
		private void OnHelpButtonClick()
		{
			TutorialController.Instance.OpenExclusiveTutorial(EExclusiveTutorialType.RollBlock);
		}

		// Token: 0x0401E932 RID: 125234
		private float ForwardInputValue;

		// Token: 0x0401E933 RID: 125235
		private float RightInputValue;

		// Token: 0x0401E934 RID: 125236
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401E935 RID: 125237
		private UUIItem PnlAll;

		// Token: 0x0401E936 RID: 125238
		private UUIItem PnlTips;

		// Token: 0x0401E937 RID: 125239
		private UUIItem BtnReset;

		// Token: 0x0401E938 RID: 125240
		private bool IsAddedEventListener;

		// Token: 0x0401E939 RID: 125241
		private TimerHandle ResetButtonCDTimerHandle;
	}
}
