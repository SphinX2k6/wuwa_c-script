using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TimeTrackControl
{
	// Token: 0x02005B46 RID: 23366
	[NullableContext(2)]
	[Nullable(0)]
	public class TimeTrackControlView : UiTickViewBase
	{
		// Token: 0x0603975E RID: 235358 RVA: 0x0101FB21 File Offset: 0x0101DD21
		[NullableContext(1)]
		public TimeTrackControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603975F RID: 235359 RVA: 0x0101FB2C File Offset: 0x0101DD2C
		protected unsafe override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUISprite))
			};
			int num = 1;
			List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
			Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickBackBtn));
			this.BtnBindInfo = list;
		}

		// Token: 0x06039760 RID: 235360 RVA: 0x0101FC48 File Offset: 0x0101DE48
		protected override void OnStart()
		{
			this.BoxWidth = 26f;
			this.MaxCounts = TimeTrackControlModel.Instance.GetConfigStatesCounts();
			this.SegmentTime = TimeTrackControlModel.Instance.GetConfigSegmentTime();
			this.Notches = ((this.MaxCounts - 2 > 0) ? (this.MaxCounts - 2) : 0);
			if (this.Notches > 0)
			{
				this.InitNotches();
			}
			else
			{
				this.BaseDistance = this.BoxWidth;
				this.Notches = 0;
			}
			this.CurNotch = TimeTrackControlModel.Instance.ControlPoint;
			this.CurLength = this.GetTargetLength(this.CurNotch);
			this.IndicatorCircle = base.GetItem(5);
			this.CurRotator = global::Rotator.Create(0f, this.CurLength, 0f);
			UUIItem indicatorCircle = this.IndicatorCircle;
			FRotator frotator = this.CurRotator.ToUeRotator();
			indicatorCircle.SetUIRelativeRotation(frotator);
			this.IsInAnimated = false;
			UUIItem item = base.GetItem(4);
			this.NotchListPanel = base.GetItem(3);
			this.ControlPoints = new TimeTrackControlPoint[this.MaxCounts];
			item.SetUIActive(false);
			for (int i = 0; i < this.MaxCounts; i++)
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, this.NotchListPanel);
				uuiitem.SetUIActive(true);
				float targetLength = this.GetTargetLength(i);
				TimeTrackControlPoint timeTrackControlPoint = new TimeTrackControlPoint(uuiitem, i, targetLength);
				timeTrackControlPoint.UpdateState(TimeTrackControlModel.Instance.IsControlPointUsable(i));
				this.ControlPoints[i] = timeTrackControlPoint;
			}
			this.ControlPoints[this.CurNotch].ToggleSelected(true);
			this.HandleLockBar();
			this.LeftBtnLongPress = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(0)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressFourth), delegate(bool _)
			{
				this.OnClickLeftBtn();
			});
			this.RightBtnLongPress = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(1)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressFourth), delegate(bool _)
			{
				this.OnClickRightBtn();
			});
		}

		// Token: 0x06039761 RID: 235361 RVA: 0x0101FE22 File Offset: 0x0101E022
		private void InitNotches()
		{
			this.BaseDistance = this.BoxWidth / (float)(this.Notches + 1);
		}

		// Token: 0x06039762 RID: 235362 RVA: 0x0101FE3A File Offset: 0x0101E03A
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Add(EEventName.OnTimeTrackControlUpdate, new Action<int, ErrorCode>(this.HandleInputUpdate));
		}

		// Token: 0x06039763 RID: 235363 RVA: 0x0101FE58 File Offset: 0x0101E058
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.OnTimeTrackControlUpdate, new Action<int, ErrorCode>(this.HandleInputUpdate));
		}

		// Token: 0x06039764 RID: 235364 RVA: 0x0101FE76 File Offset: 0x0101E076
		protected override void OnAddEventListener()
		{
			if (!EventSystem.Instance.HasWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit)))
			{
				EventSystem.Instance.AddWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit));
			}
		}

		// Token: 0x06039765 RID: 235365 RVA: 0x0101FEB5 File Offset: 0x0101E0B5
		protected override void OnRemoveEventListener()
		{
			if (EventSystem.Instance.HasWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit)))
			{
				EventSystem.Instance.RemoveWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit));
			}
		}

		// Token: 0x06039766 RID: 235366 RVA: 0x0101FEF4 File Offset: 0x0101E0F4
		[NullableContext(1)]
		private void OnCharBeHit(global::HitInformation hitData, HitContext hitContext)
		{
			if (hitData.CalculateType != 0)
			{
				return;
			}
			TimeTrackController.Instance.HandleTimeTrackControlViewClose();
			this.IsHitClose = true;
			base.CloseMe(null);
		}

		// Token: 0x06039767 RID: 235367 RVA: 0x0101FF18 File Offset: 0x0101E118
		protected override void OnBeforeDestroy()
		{
			LongPressButtonItem leftBtnLongPress = this.LeftBtnLongPress;
			if (leftBtnLongPress != null)
			{
				leftBtnLongPress.Clear();
			}
			LongPressButtonItem rightBtnLongPress = this.RightBtnLongPress;
			if (rightBtnLongPress != null)
			{
				rightBtnLongPress.Clear();
			}
			if (this.ControlPoints != null)
			{
				TimeTrackControlPoint[] controlPoints = this.ControlPoints;
				for (int i = 0; i < controlPoints.Length; i++)
				{
					controlPoints[i].Destroy(null);
				}
			}
			this.ControlPoints = null;
			AudioSystem.Instance.ExecuteAction("play_ui_com_time_loop", EAudioActionType.Stop, null);
			if (this.IsBtnClose || this.IsHitClose)
			{
				return;
			}
			TimeTrackController.Instance.HandleTimeTrackControlViewClose();
		}

		// Token: 0x06039768 RID: 235368 RVA: 0x0101FFA8 File Offset: 0x0101E1A8
		private void HandleInputUpdate(int curPoint, ErrorCode code)
		{
			if (code == ErrorCode.ErrTimelineMove)
			{
				this.HandleLockHint();
				return;
			}
			if (this.CurNotch == curPoint)
			{
				return;
			}
			if (this.ControlPoints != null)
			{
				this.ControlPoints[this.CurNotch].ToggleSelected(false);
			}
			this.CurNotch = curPoint;
			this.TargetLength = this.GetTargetLength(curPoint);
			this.DeltaSpeed = (this.TargetLength - this.CurLength) / this.SegmentTime / 1000f;
			this.IsInAnimated = true;
			AudioSystem.Instance.PostEvent("play_ui_com_time_loop");
		}

		// Token: 0x06039769 RID: 235369 RVA: 0x01020034 File Offset: 0x0101E234
		protected override void OnTick(float deltaTime)
		{
			if (!this.IsInAnimated)
			{
				return;
			}
			float num = deltaTime * this.DeltaSpeed;
			this.CurLength += num;
			if (Math.Abs(this.TargetLength - this.CurLength) < Math.Abs(num))
			{
				this.FinishedAnim();
			}
			this.CurRotator.Yaw = this.CurLength;
			UUIItem indicatorCircle = this.IndicatorCircle;
			FRotator frotator = this.CurRotator.ToUeRotator();
			indicatorCircle.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0603976A RID: 235370 RVA: 0x010200AC File Offset: 0x0101E2AC
		private void FinishedAnim()
		{
			this.CurLength = this.TargetLength;
			this.CurRotator.Yaw = this.CurLength;
			UUIItem indicatorCircle = this.IndicatorCircle;
			FRotator frotator = this.CurRotator.ToUeRotator();
			indicatorCircle.SetUIRelativeRotation(frotator);
			AudioSystem.Instance.ExecuteAction("play_ui_com_time_loop", EAudioActionType.Stop, null);
			this.IsInAnimated = false;
			if (this.ControlPoints == null)
			{
				return;
			}
			this.ControlPoints[this.CurNotch].ToggleSelected(true);
			foreach (TimeTrackControlPoint timeTrackControlPoint in this.ControlPoints)
			{
				bool flag = TimeTrackControlModel.Instance.IsControlPointUsable(timeTrackControlPoint.Index);
				timeTrackControlPoint.UpdateState(flag);
				if (flag)
				{
					AudioSystem.Instance.PostEvent("play_ui_com_time_bell");
				}
			}
			this.HandleLockBar();
		}

		// Token: 0x0603976B RID: 235371 RVA: 0x0102017B File Offset: 0x0101E37B
		private float GetTargetLength(int inTargetPoint)
		{
			return MathUtils.Instance.RangeClamp((float)inTargetPoint * this.BaseDistance, 0f, 26f, -13f, 13f);
		}

		// Token: 0x0603976C RID: 235372 RVA: 0x010201A4 File Offset: 0x0101E3A4
		private void OnClickBackBtn()
		{
			TimeTrackController.Instance.HandleTimeTrackControlViewClose();
			this.IsBtnClose = true;
			base.CloseMe(null);
		}

		// Token: 0x0603976D RID: 235373 RVA: 0x010201BE File Offset: 0x0101E3BE
		private void OnClickRightBtn()
		{
			this.HandleTraceControl(true);
		}

		// Token: 0x0603976E RID: 235374 RVA: 0x010201C7 File Offset: 0x0101E3C7
		private void OnClickLeftBtn()
		{
			this.HandleTraceControl(false);
		}

		// Token: 0x0603976F RID: 235375 RVA: 0x010201D0 File Offset: 0x0101E3D0
		private void HandleTraceControl(bool inForward)
		{
			if (this.IsInAnimated)
			{
				return;
			}
			if (!TimeTrackControlModel.Instance.CanUpdated)
			{
				return;
			}
			if (!inForward)
			{
				if (this.CurNotch > 0)
				{
					TimeTrackController.Instance.TimelineTraceControlRequest(false);
				}
				return;
			}
			if (this.CurNotch < this.MaxCounts - 1)
			{
				TimeTrackController.Instance.TimelineTraceControlRequest(true);
			}
		}

		// Token: 0x06039770 RID: 235376 RVA: 0x01020226 File Offset: 0x0101E426
		private void HandleLockHint()
		{
			this.UiViewSequence.PlaySequencePurely("Shake", true, false);
		}

		// Token: 0x06039771 RID: 235377 RVA: 0x0102023C File Offset: 0x0101E43C
		private void HandleLockBar()
		{
			int num = this.CurNotch;
			int num2 = this.CurNotch;
			num--;
			while (num >= 0 && TimeTrackControlModel.Instance.IsControlPointUsable(num))
			{
				num--;
			}
			if (num >= 0)
			{
				int num3 = (num + 1) / (this.MaxCounts - 1);
				base.GetSprite(2).SetUIActive(true);
				base.GetSprite(2).SetFillAmount((float)num3);
			}
			else
			{
				base.GetSprite(2).SetUIActive(false);
			}
			num2++;
			while (num2 < this.MaxCounts && TimeTrackControlModel.Instance.IsControlPointUsable(num2))
			{
				num2++;
			}
			if (num2 < this.MaxCounts)
			{
				int num4 = (this.MaxCounts - num2) / (this.MaxCounts - 1);
				base.GetSprite(8).SetUIActive(true);
				base.GetSprite(8).SetFillAmount((float)num4);
				return;
			}
			base.GetSprite(8).SetUIActive(false);
		}

		// Token: 0x0401E510 RID: 124176
		private UUIItem NotchListPanel;

		// Token: 0x0401E511 RID: 124177
		private int Notches;

		// Token: 0x0401E512 RID: 124178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TimeTrackControlPoint[] ControlPoints;

		// Token: 0x0401E513 RID: 124179
		private float BoxWidth;

		// Token: 0x0401E514 RID: 124180
		private float BaseDistance;

		// Token: 0x0401E515 RID: 124181
		private int CurNotch;

		// Token: 0x0401E516 RID: 124182
		private int MaxCounts;

		// Token: 0x0401E517 RID: 124183
		private float CurLength;

		// Token: 0x0401E518 RID: 124184
		private float TargetLength;

		// Token: 0x0401E519 RID: 124185
		private float DeltaSpeed;

		// Token: 0x0401E51A RID: 124186
		private bool IsInAnimated;

		// Token: 0x0401E51B RID: 124187
		private bool IsBtnClose;

		// Token: 0x0401E51C RID: 124188
		private bool IsHitClose;

		// Token: 0x0401E51D RID: 124189
		private float SegmentTime;

		// Token: 0x0401E51E RID: 124190
		private UUIItem IndicatorCircle;

		// Token: 0x0401E51F RID: 124191
		private global::Rotator CurRotator;

		// Token: 0x0401E520 RID: 124192
		private LongPressButtonItem LeftBtnLongPress;

		// Token: 0x0401E521 RID: 124193
		private LongPressButtonItem RightBtnLongPress;

		// Token: 0x0200B72F RID: 46895
		[NullableContext(0)]
		public enum ETimeTrackControlComponent
		{
			// Token: 0x04038A28 RID: 231976
			LeftBtn,
			// Token: 0x04038A29 RID: 231977
			RightBtn,
			// Token: 0x04038A2A RID: 231978
			LockBarL,
			// Token: 0x04038A2B RID: 231979
			NotchList,
			// Token: 0x04038A2C RID: 231980
			FirstNotch,
			// Token: 0x04038A2D RID: 231981
			IndicatorCircle,
			// Token: 0x04038A2E RID: 231982
			Indicator,
			// Token: 0x04038A2F RID: 231983
			CloseBtn,
			// Token: 0x04038A30 RID: 231984
			LockBarR
		}
	}
}
