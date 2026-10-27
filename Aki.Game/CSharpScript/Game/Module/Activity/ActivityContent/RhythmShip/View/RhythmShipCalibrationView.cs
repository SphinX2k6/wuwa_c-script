using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006210 RID: 25104
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipCalibrationView : UiTickViewBase
	{
		// Token: 0x0603F54F RID: 259407 RVA: 0x00F4DF56 File Offset: 0x00F4C156
		[NullableContext(1)]
		public RhythmShipCalibrationView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F550 RID: 259408 RVA: 0x00F4DF74 File Offset: 0x00F4C174
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickShowNoteToggle)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickReduceBtn)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnClickAddBtn)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickCalibrationBtn)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickConfirmBtn))
			};
		}

		// Token: 0x0603F551 RID: 259409 RVA: 0x00F4E134 File Offset: 0x00F4C334
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipCalibrationView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipCalibrationView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F552 RID: 259410 RVA: 0x00F4E178 File Offset: 0x00F4C378
		private void OnClickCloseBtn()
		{
			if (RhythmShipModel.Instance.LocalCalibrationValue == this.CurrentCalibrationValue)
			{
				base.CloseMe(null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RhythmCalibrationExitConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				base.CloseMe(null);
			});
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OnClickConfirmBtn));
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603F553 RID: 259411 RVA: 0x00F4E1F0 File Offset: 0x00F4C3F0
		protected override void OnStart()
		{
			this.CurrentAudioHandle = RhythmShipController.Instance.LastLoopAudio;
			this.CurrentCalibrationValue = RhythmShipModel.Instance.LocalCalibrationValue;
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			base.GetItem(12).SetAlpha(0f);
			base.GetItem(12).SetUIActive(true);
			this.MaxOffsetX = base.GetItem(3).GetWidth();
			this.CircleItemLevelSequencePlayer = new LevelSequencePlayer(base.GetItem(12));
			this.CircleItemLevelSequencePlayer.BindSequenceCloseEvent(delegate(string name)
			{
				if (name == "Click")
				{
					base.GetItem(12).SetAlpha(0f);
				}
			}, false);
			this.RefreshView();
		}

		// Token: 0x0603F554 RID: 259412 RVA: 0x00F4E291 File Offset: 0x00F4C491
		protected override void OnBeforeDestroy()
		{
			if (!StringUtils.IsEmpty(this.CurrentAudioHandle))
			{
				RhythmShipController.Instance.PlayLoopAudioEvent(this.CurrentAudioHandle);
				return;
			}
			RhythmShipController.Instance.StopLoopAudioEvent();
		}

		// Token: 0x0603F555 RID: 259413 RVA: 0x00F4E2BC File Offset: 0x00F4C4BC
		private void RefreshView()
		{
			base.GetText(4).SetText(this.CurrentCalibrationValue.ToString(), true);
			base.GetItem(10).SetAnchorOffsetX((float)this.CurrentCalibrationValue / 150f * (this.MaxOffsetX / 2f));
			base.GetButton(5).SetSelfInteractive(this.CurrentCalibrationValue > -150);
			base.GetButton(6).SetSelfInteractive(this.CurrentCalibrationValue < 150);
		}

		// Token: 0x0603F556 RID: 259414 RVA: 0x00F4E33A File Offset: 0x00F4C53A
		private void StartCalibration()
		{
			base.GetItem(11).SetAnchorOffsetX(0f);
			RhythmShipController.Instance.PlayLoopAudioEvent("play_ui_rhythmship_rhythm_set");
			this.StarMoveTick = true;
		}

		// Token: 0x0603F557 RID: 259415 RVA: 0x00F4E364 File Offset: 0x00F4C564
		private void EndCalibration()
		{
			base.GetItem(11).SetAlpha(0f);
			this.ShowStopMoveShowCircleItem();
		}

		// Token: 0x0603F558 RID: 259416 RVA: 0x00F4E380 File Offset: 0x00F4C580
		private void ShowStopMoveShowCircleItem()
		{
			base.GetItem(12).SetAlpha(1f);
			base.GetItem(12).SetAnchorOffsetX(base.GetItem(11).GetAnchorOffsetX());
			LevelSequencePlayer circleItemLevelSequencePlayer = this.CircleItemLevelSequencePlayer;
			if (circleItemLevelSequencePlayer == null || !circleItemLevelSequencePlayer.IsPlayingSequence("Click"))
			{
				LevelSequencePlayer circleItemLevelSequencePlayer2 = this.CircleItemLevelSequencePlayer;
				if (circleItemLevelSequencePlayer2 == null)
				{
					return;
				}
				circleItemLevelSequencePlayer2.PlayLevelSequenceByName("Click", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer circleItemLevelSequencePlayer3 = this.CircleItemLevelSequencePlayer;
				if (circleItemLevelSequencePlayer3 == null)
				{
					return;
				}
				circleItemLevelSequencePlayer3.ReplaySequenceByKey("Click");
				return;
			}
		}

		// Token: 0x0603F559 RID: 259417 RVA: 0x00F4E40C File Offset: 0x00F4C60C
		protected override void OnTick(float delta)
		{
			if (this.AddBtnStartPointerDown)
			{
				if (this.BtnLongClickTime > 100f)
				{
					this.OnClickAddBtn();
					this.BtnLongClickTime = 0f;
				}
				this.BtnLongClickTime += delta;
			}
			else if (this.ReduceBtnStartPointerDown)
			{
				if (this.BtnLongClickTime > 100f)
				{
					this.OnClickReduceBtn();
					this.BtnLongClickTime = 0f;
				}
				this.BtnLongClickTime += delta;
			}
			if (!this.StarMoveTick)
			{
				return;
			}
			this.MoveTime += delta;
			float num = this.MoveTime / 3000f * this.MaxOffsetX;
			if (num > this.MaxOffsetX)
			{
				num = 0f;
			}
			base.GetItem(11).SetAlpha(this.CurrentShowNoteFlag > false);
			base.GetItem(11).SetAnchorOffsetX(num);
			if (this.MoveTime >= 3000f)
			{
				this.MoveTime -= 3000f;
			}
		}

		// Token: 0x0603F55A RID: 259418 RVA: 0x00F4E501 File Offset: 0x00F4C701
		private void OnClickShowNoteToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.CurrentShowNoteFlag = true;
				base.GetItem(11).SetAlpha(1f);
				return;
			}
			this.CurrentShowNoteFlag = false;
			base.GetItem(11).SetAlpha(0f);
		}

		// Token: 0x0603F55B RID: 259419 RVA: 0x00F4E53A File Offset: 0x00F4C73A
		private void OnClickReduceBtn()
		{
			if (this.CurrentCalibrationValue <= -150)
			{
				return;
			}
			this.CurrentCalibrationValue--;
			this.RefreshView();
		}

		// Token: 0x0603F55C RID: 259420 RVA: 0x00F4E55E File Offset: 0x00F4C75E
		private void OnClickAddBtn()
		{
			if (this.CurrentCalibrationValue >= 150)
			{
				return;
			}
			this.CurrentCalibrationValue++;
			this.RefreshView();
		}

		// Token: 0x0603F55D RID: 259421 RVA: 0x00F4E582 File Offset: 0x00F4C782
		private void OnClickCalibrationBtn()
		{
			if (!this.StarMoveTick)
			{
				this.StartCalibration();
				return;
			}
			this.EndCalibration();
		}

		// Token: 0x0603F55E RID: 259422 RVA: 0x00F4E599 File Offset: 0x00F4C799
		private void OnClickConfirmBtn()
		{
			RhythmShipModel.Instance.SetLocalCalibrationValue(this.CurrentCalibrationValue);
			base.CloseMe(null);
		}

		// Token: 0x0603F55F RID: 259423 RVA: 0x00F4E5B2 File Offset: 0x00F4C7B2
		private void OnAddBtnPointerDown()
		{
			this.AddBtnStartPointerDown = true;
		}

		// Token: 0x0603F560 RID: 259424 RVA: 0x00F4E5BB File Offset: 0x00F4C7BB
		private void OnAddBtnPointerEnd()
		{
			this.AddBtnStartPointerDown = false;
			this.BtnLongClickTime = 0f;
		}

		// Token: 0x0603F561 RID: 259425 RVA: 0x00F4E5CF File Offset: 0x00F4C7CF
		private void OnReduceBtnPointerDown()
		{
			this.ReduceBtnStartPointerDown = true;
		}

		// Token: 0x0603F562 RID: 259426 RVA: 0x00F4E5D8 File Offset: 0x00F4C7D8
		private void OnReduceBtnPointerEnd()
		{
			this.ReduceBtnStartPointerDown = false;
			this.BtnLongClickTime = 0f;
		}

		// Token: 0x04021091 RID: 135313
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021092 RID: 135314
		private int CurrentCalibrationValue;

		// Token: 0x04021093 RID: 135315
		private bool CurrentShowNoteFlag = true;

		// Token: 0x04021094 RID: 135316
		private float MaxOffsetX;

		// Token: 0x04021095 RID: 135317
		private LevelSequencePlayer CircleItemLevelSequencePlayer;

		// Token: 0x04021096 RID: 135318
		private LongPressButtonItem AddLongPress;

		// Token: 0x04021097 RID: 135319
		private LongPressButtonItem ReduceLongPress;

		// Token: 0x04021098 RID: 135320
		[Nullable(1)]
		private string CurrentAudioHandle = "";

		// Token: 0x04021099 RID: 135321
		private bool StarMoveTick;

		// Token: 0x0402109A RID: 135322
		private float MoveTime;

		// Token: 0x0402109B RID: 135323
		private float BtnLongClickTime;

		// Token: 0x0402109C RID: 135324
		private bool AddBtnStartPointerDown;

		// Token: 0x0402109D RID: 135325
		private bool ReduceBtnStartPointerDown;
	}
}
