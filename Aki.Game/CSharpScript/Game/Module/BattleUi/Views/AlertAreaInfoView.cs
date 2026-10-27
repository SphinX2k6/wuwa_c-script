using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.AlertArea;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CAB RID: 23723
	public class AlertAreaInfoView : BattleVisibleChildView
	{
		// Token: 0x0603BEDA RID: 245466 RVA: 0x00E51F82 File Offset: 0x00E50182
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEvents();
		}

		// Token: 0x0603BEDB RID: 245467 RVA: 0x00E51FA0 File Offset: 0x00E501A0
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x0603BEDC RID: 245468 RVA: 0x00E51FB0 File Offset: 0x00E501B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BEDD RID: 245469 RVA: 0x00E520DF File Offset: 0x00E502DF
		private void AddEvents()
		{
			EventSystem.Instance.Add<int, float>(EEventName.OnUpdateAreaAlertValue, new Action<int, float>(this.OnUpdateAreaAlertValue));
		}

		// Token: 0x0603BEDE RID: 245470 RVA: 0x00E520FD File Offset: 0x00E502FD
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateAreaAlertValue, new Action<int, float>(this.OnUpdateAreaAlertValue));
		}

		// Token: 0x0603BEDF RID: 245471 RVA: 0x00E5211C File Offset: 0x00E5031C
		public void Tick(float delta)
		{
			AlertAreaUpdateMachine updateMachine = this.UpdateMachine;
			if (((updateMachine != null) ? new bool?(updateMachine.Update(delta)) : null).GetValueOrDefault())
			{
				this.OnMachineDataChange();
			}
		}

		// Token: 0x0603BEE0 RID: 245472 RVA: 0x00E5215C File Offset: 0x00E5035C
		public void OnMachineDataChange()
		{
			if (this.UpdateMachine == null)
			{
				return;
			}
			int progressDir = this.UpdateMachine.GetProgressDir();
			float barCurPercent = this.UpdateMachine.GetBarCurPercent();
			float barTargetPercent = this.UpdateMachine.GetBarTargetPercent();
			if (progressDir > 0)
			{
				this.SetBarProgressByPercent(barCurPercent);
				this.SetBarProgressBufferByPercent(barTargetPercent);
				return;
			}
			this.SetBarProgressByPercent(barTargetPercent);
			this.SetBarProgressBufferByPercent(barCurPercent);
		}

		// Token: 0x0603BEE1 RID: 245473 RVA: 0x00E521B8 File Offset: 0x00E503B8
		private void OnUpdateAreaAlertValue(int areaId, float value)
		{
			if (this.AreaId != areaId)
			{
				return;
			}
			float alertValue = this.AlertValue;
			this.AlertValue = AlertAreaModel.Instance.GetAreaAlertValue(areaId);
			AlertAreaUpdateMachine updateMachine = this.UpdateMachine;
			if (updateMachine != null)
			{
				updateMachine.ChangeTargetPercent(this.AlertValue);
			}
			this.SetTxtProgressByPercent(this.AlertValue);
			this.UpdateWarningAnimByPercent(alertValue, this.AlertValue);
			float deltaPercent = this.AlertValue - alertValue;
			this.ShowTxtProgressTip(true, deltaPercent);
		}

		// Token: 0x0603BEE2 RID: 245474 RVA: 0x00E52228 File Offset: 0x00E50428
		public void StartShow(int areaId)
		{
			this.AreaId = areaId;
			this.AlertValue = AlertAreaModel.Instance.GetAreaAlertValue(areaId);
			this.UpdateMachine = new AlertAreaUpdateMachine();
			this.InitTweenAnim();
			base.SetVisible(1, true);
			this.UpdateMachine.Init(this.AlertValue);
			this.SetBarProgressByPercent(this.AlertValue);
			this.SetBarProgressBufferByPercent(this.AlertValue);
			this.SetTxtProgressByPercent(this.AlertValue);
			this.HideTxtProgressTip();
		}

		// Token: 0x0603BEE3 RID: 245475 RVA: 0x00E522A4 File Offset: 0x00E504A4
		public void EndShow(int? areaId = null)
		{
			if (areaId != null)
			{
				int? num = areaId;
				int areaId2 = this.AreaId;
				if (!(num.GetValueOrDefault() == areaId2 & num != null))
				{
					return;
				}
			}
			base.SetVisible(1, false);
			this.ClearTweenAnim();
			this.AreaId = 0;
			this.AlertValue = 0f;
			this.UpdateMachine = null;
		}

		// Token: 0x0603BEE4 RID: 245476 RVA: 0x00E52300 File Offset: 0x00E50500
		private void SetBarProgressByPercent(float percent)
		{
			float num = MathUtils.Instance.RangeClamp(percent, 0f, 100f, 42f, 83f);
			base.GetSprite(1).SetFillAmount(num * 0.01f);
		}

		// Token: 0x0603BEE5 RID: 245477 RVA: 0x00E52340 File Offset: 0x00E50540
		private void SetBarProgressBufferByPercent(float percent)
		{
			float num = MathUtils.Instance.RangeClamp(percent, 0f, 100f, 42f, 83f);
			base.GetSprite(0).SetFillAmount(num * 0.01f);
		}

		// Token: 0x0603BEE6 RID: 245478 RVA: 0x00E52380 File Offset: 0x00E50580
		private void SetTxtProgressByPercent(float percent)
		{
			int num = (int)MathCommon.Clamp(Math.Round((double)percent), 0.0, 100.0);
			base.GetText(2).SetText(num.ToString(), true);
		}

		// Token: 0x0603BEE7 RID: 245479 RVA: 0x00E523C4 File Offset: 0x00E505C4
		private void UpdateWarningAnimByPercent(float oldPercent, float newPercent)
		{
			if (newPercent >= 100f)
			{
				if (oldPercent < 100f)
				{
					if (oldPercent >= 80f)
					{
						BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
						if (tweenPlayer != null)
						{
							tweenPlayer.StopTweenAnim(5);
						}
						BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
						if (tweenPlayer2 == null)
						{
							return;
						}
						tweenPlayer2.PlayTweenAnim(6);
						return;
					}
					else
					{
						BattleUiTweenAnimPlayer tweenPlayer3 = this.TweenPlayer;
						if (tweenPlayer3 == null)
						{
							return;
						}
						tweenPlayer3.PlayTweenAnim(6);
						return;
					}
				}
			}
			else if (newPercent >= 80f)
			{
				if (oldPercent >= 100f)
				{
					BattleUiTweenAnimPlayer tweenPlayer4 = this.TweenPlayer;
					if (tweenPlayer4 != null)
					{
						tweenPlayer4.StopTweenAnim(6);
					}
					BattleUiTweenAnimPlayer tweenPlayer5 = this.TweenPlayer;
					if (tweenPlayer5 == null)
					{
						return;
					}
					tweenPlayer5.PlayTweenAnim(5);
					return;
				}
				else if (oldPercent < 80f)
				{
					BattleUiTweenAnimPlayer tweenPlayer6 = this.TweenPlayer;
					if (tweenPlayer6 == null)
					{
						return;
					}
					tweenPlayer6.PlayTweenAnim(5);
					return;
				}
			}
			else if (oldPercent >= 100f)
			{
				BattleUiTweenAnimPlayer tweenPlayer7 = this.TweenPlayer;
				if (tweenPlayer7 != null)
				{
					tweenPlayer7.StopTweenAnim(6);
				}
				BattleUiTweenAnimPlayer tweenPlayer8 = this.TweenPlayer;
				if (tweenPlayer8 == null)
				{
					return;
				}
				tweenPlayer8.PlayTweenAnim(4);
				return;
			}
			else if (oldPercent >= 80f)
			{
				BattleUiTweenAnimPlayer tweenPlayer9 = this.TweenPlayer;
				if (tweenPlayer9 != null)
				{
					tweenPlayer9.StopTweenAnim(5);
				}
				BattleUiTweenAnimPlayer tweenPlayer10 = this.TweenPlayer;
				if (tweenPlayer10 == null)
				{
					return;
				}
				tweenPlayer10.PlayTweenAnim(4);
			}
		}

		// Token: 0x0603BEE8 RID: 245480 RVA: 0x00E524C8 File Offset: 0x00E506C8
		private void ShowTxtProgressTip(bool updateText, float deltaPercent = 0f)
		{
			if (updateText)
			{
				int value = (int)MathCommon.Clamp(Math.Abs(Math.Round((double)deltaPercent)), 0.0, 100.0);
				UUIText text = base.GetText(3);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted((deltaPercent >= 0f) ? "+" : "-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.GetText(3).SetUIActive(true);
			BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
			if (tweenPlayer == null)
			{
				return;
			}
			tweenPlayer.PlayTweenAnim(7);
		}

		// Token: 0x0603BEE9 RID: 245481 RVA: 0x00E52567 File Offset: 0x00E50767
		private void HideTxtProgressTip()
		{
			BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
			if (tweenPlayer != null)
			{
				tweenPlayer.StopTweenAnim(7);
			}
			base.GetText(3).SetUIActive(false);
		}

		// Token: 0x0603BEEA RID: 245482 RVA: 0x00E52588 File Offset: 0x00E50788
		private void InitTweenAnim()
		{
			this.TweenPlayer = new BattleUiTweenAnimPlayer();
			this.TweenPlayer.InitTweenAnim(4, base.GetItem(4), false);
			this.TweenPlayer.InitTweenAnim(5, base.GetItem(5), false);
			this.TweenPlayer.InitTweenAnim(6, base.GetItem(6), false);
			this.TweenPlayer.InitTweenAnim(7, base.GetItem(7), false);
		}

		// Token: 0x0603BEEB RID: 245483 RVA: 0x00E525F0 File Offset: 0x00E507F0
		private void ClearTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
			if (tweenPlayer != null)
			{
				tweenPlayer.StopTweenAnim(5);
			}
			BattleUiTweenAnimPlayer tweenPlayer2 = this.TweenPlayer;
			if (tweenPlayer2 != null)
			{
				tweenPlayer2.StopTweenAnim(6);
			}
			BattleUiTweenAnimPlayer tweenPlayer3 = this.TweenPlayer;
			if (tweenPlayer3 != null)
			{
				tweenPlayer3.StopTweenAnim(7);
			}
			BattleUiTweenAnimPlayer tweenPlayer4 = this.TweenPlayer;
			if (tweenPlayer4 != null)
			{
				tweenPlayer4.StopTweenAnim(4);
			}
			BattleUiTweenAnimPlayer tweenPlayer5 = this.TweenPlayer;
			if (tweenPlayer5 != null)
			{
				tweenPlayer5.Clear(false);
			}
			this.TweenPlayer = null;
		}

		// Token: 0x0401F460 RID: 128096
		private const float PERCENT_TO_PROGRESS = 0.01f;

		// Token: 0x0401F461 RID: 128097
		private const float UI_BAR_MIN_PERCENT = 42f;

		// Token: 0x0401F462 RID: 128098
		private const float UI_BAR_MAX_PERCENT = 83f;

		// Token: 0x0401F463 RID: 128099
		private int AreaId;

		// Token: 0x0401F464 RID: 128100
		private float AlertValue;

		// Token: 0x0401F465 RID: 128101
		[Nullable(2)]
		private AlertAreaUpdateMachine UpdateMachine;

		// Token: 0x0401F466 RID: 128102
		[Nullable(2)]
		private BattleUiTweenAnimPlayer TweenPlayer;

		// Token: 0x0200BE84 RID: 48772
		private enum EVisibleReason
		{
			// Token: 0x04039746 RID: 235334
			Default = 1
		}

		// Token: 0x0200BE85 RID: 48773
		private enum EChildComponent
		{
			// Token: 0x04039748 RID: 235336
			BarProgressBuffer,
			// Token: 0x04039749 RID: 235337
			BarProgress,
			// Token: 0x0403974A RID: 235338
			TxtProgress,
			// Token: 0x0403974B RID: 235339
			TxtProgressTip,
			// Token: 0x0403974C RID: 235340
			AniDefault,
			// Token: 0x0403974D RID: 235341
			AniWarningA,
			// Token: 0x0403974E RID: 235342
			AniWarningB,
			// Token: 0x0403974F RID: 235343
			AniTxtTip
		}
	}
}
