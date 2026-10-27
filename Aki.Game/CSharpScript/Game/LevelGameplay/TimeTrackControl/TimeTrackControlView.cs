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
	// Token: 0x020069EA RID: 27114
	[NullableContext(2)]
	[Nullable(0)]
	public class TimeTrackControlView : UiTickViewBase
	{
		// Token: 0x06043722 RID: 276258 RVA: 0x0107B66D File Offset: 0x0107986D
		[NullableContext(1)]
		public TimeTrackControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043723 RID: 276259 RVA: 0x0107B678 File Offset: 0x01079878
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

		// Token: 0x06043724 RID: 276260 RVA: 0x0107B794 File Offset: 0x01079994
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

		// Token: 0x06043725 RID: 276261 RVA: 0x0107B96E File Offset: 0x01079B6E
		private void InitNotches()
		{
			this.BaseDistance = this.BoxWidth / (float)(this.Notches + 1);
		}

		// Token: 0x06043726 RID: 276262 RVA: 0x0107B986 File Offset: 0x01079B86
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Add(EEventName.OnTimeTrackControlUpdate, new Action<int, ErrorCode>(this.HandleInputUpdate));
		}

		// Token: 0x06043727 RID: 276263 RVA: 0x0107B9A4 File Offset: 0x01079BA4
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.OnTimeTrackControlUpdate, new Action<int, ErrorCode>(this.HandleInputUpdate));
		}

		// Token: 0x06043728 RID: 276264 RVA: 0x0107B9C2 File Offset: 0x01079BC2
		protected override void OnAddEventListener()
		{
			if (!EventSystem.Instance.HasWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit)))
			{
				EventSystem.Instance.AddWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit));
			}
		}

		// Token: 0x06043729 RID: 276265 RVA: 0x0107BA01 File Offset: 0x01079C01
		protected override void OnRemoveEventListener()
		{
			if (EventSystem.Instance.HasWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit)))
			{
				EventSystem.Instance.RemoveWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnCharBeHit));
			}
		}

		// Token: 0x0604372A RID: 276266 RVA: 0x0107BA40 File Offset: 0x01079C40
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

		// Token: 0x0604372B RID: 276267 RVA: 0x0107BA64 File Offset: 0x01079C64
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

		// Token: 0x0604372C RID: 276268 RVA: 0x0107BAF4 File Offset: 0x01079CF4
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

		// Token: 0x0604372D RID: 276269 RVA: 0x0107BB80 File Offset: 0x01079D80
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

		// Token: 0x0604372E RID: 276270 RVA: 0x0107BBF8 File Offset: 0x01079DF8
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

		// Token: 0x0604372F RID: 276271 RVA: 0x0107BCC7 File Offset: 0x01079EC7
		private float GetTargetLength(int inTargetPoint)
		{
			return MathUtils.Instance.RangeClamp((float)inTargetPoint * this.BaseDistance, 0f, 26f, -13f, 13f);
		}

		// Token: 0x06043730 RID: 276272 RVA: 0x0107BCF0 File Offset: 0x01079EF0
		private void OnClickBackBtn()
		{
			TimeTrackController.Instance.HandleTimeTrackControlViewClose();
			this.IsBtnClose = true;
			base.CloseMe(null);
		}

		// Token: 0x06043731 RID: 276273 RVA: 0x0107BD0A File Offset: 0x01079F0A
		private void OnClickRightBtn()
		{
			this.HandleTraceControl(true);
		}

		// Token: 0x06043732 RID: 276274 RVA: 0x0107BD13 File Offset: 0x01079F13
		private void OnClickLeftBtn()
		{
			this.HandleTraceControl(false);
		}

		// Token: 0x06043733 RID: 276275 RVA: 0x0107BD1C File Offset: 0x01079F1C
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

		// Token: 0x06043734 RID: 276276 RVA: 0x0107BD72 File Offset: 0x01079F72
		private void HandleLockHint()
		{
			this.UiViewSequence.PlaySequencePurely("Shake", true, false);
		}

		// Token: 0x06043735 RID: 276277 RVA: 0x0107BD88 File Offset: 0x01079F88
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

		// Token: 0x04023320 RID: 144160
		private UUIItem NotchListPanel;

		// Token: 0x04023321 RID: 144161
		private int Notches;

		// Token: 0x04023322 RID: 144162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TimeTrackControlPoint[] ControlPoints;

		// Token: 0x04023323 RID: 144163
		private float BoxWidth;

		// Token: 0x04023324 RID: 144164
		private float BaseDistance;

		// Token: 0x04023325 RID: 144165
		private int CurNotch;

		// Token: 0x04023326 RID: 144166
		private int MaxCounts;

		// Token: 0x04023327 RID: 144167
		private float CurLength;

		// Token: 0x04023328 RID: 144168
		private float TargetLength;

		// Token: 0x04023329 RID: 144169
		private float DeltaSpeed;

		// Token: 0x0402332A RID: 144170
		private bool IsInAnimated;

		// Token: 0x0402332B RID: 144171
		private bool IsBtnClose;

		// Token: 0x0402332C RID: 144172
		private bool IsHitClose;

		// Token: 0x0402332D RID: 144173
		private float SegmentTime;

		// Token: 0x0402332E RID: 144174
		private UUIItem IndicatorCircle;

		// Token: 0x0402332F RID: 144175
		private global::Rotator CurRotator;

		// Token: 0x04023330 RID: 144176
		private LongPressButtonItem LeftBtnLongPress;

		// Token: 0x04023331 RID: 144177
		private LongPressButtonItem RightBtnLongPress;

		// Token: 0x0200CB50 RID: 52048
		[NullableContext(0)]
		public enum ETimeTrackControlComponent
		{
			// Token: 0x0403D646 RID: 251462
			LeftBtn,
			// Token: 0x0403D647 RID: 251463
			RightBtn,
			// Token: 0x0403D648 RID: 251464
			LockBarL,
			// Token: 0x0403D649 RID: 251465
			NotchList,
			// Token: 0x0403D64A RID: 251466
			FirstNotch,
			// Token: 0x0403D64B RID: 251467
			IndicatorCircle,
			// Token: 0x0403D64C RID: 251468
			Indicator,
			// Token: 0x0403D64D RID: 251469
			CloseBtn,
			// Token: 0x0403D64E RID: 251470
			LockBarR
		}
	}
}
