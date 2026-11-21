using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200518E RID: 20878
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipCalibrationView : UiTickViewBase
	{
		// Token: 0x06034210 RID: 213520 RVA: 0x00E94EAE File Offset: 0x00E930AE
		[NullableContext(1)]
		public RhythmShipCalibrationView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034211 RID: 213521 RVA: 0x00E94ECC File Offset: 0x00E930CC
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

		// Token: 0x06034212 RID: 213522 RVA: 0x00E9508C File Offset: 0x00E9328C
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipCalibrationView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipCalibrationView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034213 RID: 213523 RVA: 0x00E950D0 File Offset: 0x00E932D0
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

		// Token: 0x06034214 RID: 213524 RVA: 0x00E95148 File Offset: 0x00E93348
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

		// Token: 0x06034215 RID: 213525 RVA: 0x00E951E9 File Offset: 0x00E933E9
		protected override void OnBeforeDestroy()
		{
			if (!StringUtils.IsEmpty(this.CurrentAudioHandle))
			{
				RhythmShipController.Instance.PlayLoopAudioEvent(this.CurrentAudioHandle);
				return;
			}
			RhythmShipController.Instance.StopLoopAudioEvent();
		}

		// Token: 0x06034216 RID: 213526 RVA: 0x00E95214 File Offset: 0x00E93414
		private void RefreshView()
		{
			base.GetText(4).SetText(this.CurrentCalibrationValue.ToString(), true);
			base.GetItem(10).SetAnchorOffsetX((float)this.CurrentCalibrationValue / 150f * (this.MaxOffsetX / 2f));
			base.GetButton(5).SetSelfInteractive(this.CurrentCalibrationValue > -150);
			base.GetButton(6).SetSelfInteractive(this.CurrentCalibrationValue < 150);
		}

		// Token: 0x06034217 RID: 213527 RVA: 0x00E95292 File Offset: 0x00E93492
		private void StartCalibration()
		{
			base.GetItem(11).SetAnchorOffsetX(0f);
			RhythmShipController.Instance.PlayLoopAudioEvent("play_ui_rhythmship_rhythm_set");
			this.StarMoveTick = true;
		}

		// Token: 0x06034218 RID: 213528 RVA: 0x00E952BC File Offset: 0x00E934BC
		private void EndCalibration()
		{
			base.GetItem(11).SetAlpha(0f);
			this.ShowStopMoveShowCircleItem();
		}

		// Token: 0x06034219 RID: 213529 RVA: 0x00E952D8 File Offset: 0x00E934D8
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

		// Token: 0x0603421A RID: 213530 RVA: 0x00E95364 File Offset: 0x00E93564
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

		// Token: 0x0603421B RID: 213531 RVA: 0x00E95459 File Offset: 0x00E93659
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

		// Token: 0x0603421C RID: 213532 RVA: 0x00E95492 File Offset: 0x00E93692
		private void OnClickReduceBtn()
		{
			if (this.CurrentCalibrationValue <= -150)
			{
				return;
			}
			this.CurrentCalibrationValue--;
			this.RefreshView();
		}

		// Token: 0x0603421D RID: 213533 RVA: 0x00E954B6 File Offset: 0x00E936B6
		private void OnClickAddBtn()
		{
			if (this.CurrentCalibrationValue >= 150)
			{
				return;
			}
			this.CurrentCalibrationValue++;
			this.RefreshView();
		}

		// Token: 0x0603421E RID: 213534 RVA: 0x00E954DA File Offset: 0x00E936DA
		private void OnClickCalibrationBtn()
		{
			if (!this.StarMoveTick)
			{
				this.StartCalibration();
				return;
			}
			this.EndCalibration();
		}

		// Token: 0x0603421F RID: 213535 RVA: 0x00E954F1 File Offset: 0x00E936F1
		private void OnClickConfirmBtn()
		{
			RhythmShipModel.Instance.SetLocalCalibrationValue(this.CurrentCalibrationValue);
			base.CloseMe(null);
		}

		// Token: 0x06034220 RID: 213536 RVA: 0x00E9550A File Offset: 0x00E9370A
		private void OnAddBtnPointerDown()
		{
			this.AddBtnStartPointerDown = true;
		}

		// Token: 0x06034221 RID: 213537 RVA: 0x00E95513 File Offset: 0x00E93713
		private void OnAddBtnPointerEnd()
		{
			this.AddBtnStartPointerDown = false;
			this.BtnLongClickTime = 0f;
		}

		// Token: 0x06034222 RID: 213538 RVA: 0x00E95527 File Offset: 0x00E93727
		private void OnReduceBtnPointerDown()
		{
			this.ReduceBtnStartPointerDown = true;
		}

		// Token: 0x06034223 RID: 213539 RVA: 0x00E95530 File Offset: 0x00E93730
		private void OnReduceBtnPointerEnd()
		{
			this.ReduceBtnStartPointerDown = false;
			this.BtnLongClickTime = 0f;
		}

		// Token: 0x0401B9C0 RID: 113088
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B9C1 RID: 113089
		private int CurrentCalibrationValue;

		// Token: 0x0401B9C2 RID: 113090
		private bool CurrentShowNoteFlag = true;

		// Token: 0x0401B9C3 RID: 113091
		private float MaxOffsetX;

		// Token: 0x0401B9C4 RID: 113092
		private LevelSequencePlayer CircleItemLevelSequencePlayer;

		// Token: 0x0401B9C5 RID: 113093
		private LongPressButtonItem AddLongPress;

		// Token: 0x0401B9C6 RID: 113094
		private LongPressButtonItem ReduceLongPress;

		// Token: 0x0401B9C7 RID: 113095
		[Nullable(1)]
		private string CurrentAudioHandle = "";

		// Token: 0x0401B9C8 RID: 113096
		private bool StarMoveTick;

		// Token: 0x0401B9C9 RID: 113097
		private float MoveTime;

		// Token: 0x0401B9CA RID: 113098
		private float BtnLongClickTime;

		// Token: 0x0401B9CB RID: 113099
		private bool AddBtnStartPointerDown;

		// Token: 0x0401B9CC RID: 113100
		private bool ReduceBtnStartPointerDown;
	}
}
