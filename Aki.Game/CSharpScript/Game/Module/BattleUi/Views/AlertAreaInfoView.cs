using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.AlertArea;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C8D RID: 19597
	public class AlertAreaInfoView : BattleVisibleChildView
	{
		// Token: 0x06030E2D RID: 200237 RVA: 0x00DA262A File Offset: 0x00DA082A
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEvents();
		}

		// Token: 0x06030E2E RID: 200238 RVA: 0x00DA2648 File Offset: 0x00DA0848
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x06030E2F RID: 200239 RVA: 0x00DA2658 File Offset: 0x00DA0858
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

		// Token: 0x06030E30 RID: 200240 RVA: 0x00DA2787 File Offset: 0x00DA0987
		private void AddEvents()
		{
			EventSystem.Instance.Add<int, float>(EEventName.OnUpdateAreaAlertValue, new Action<int, float>(this.OnUpdateAreaAlertValue));
		}

		// Token: 0x06030E31 RID: 200241 RVA: 0x00DA27A5 File Offset: 0x00DA09A5
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateAreaAlertValue, new Action<int, float>(this.OnUpdateAreaAlertValue));
		}

		// Token: 0x06030E32 RID: 200242 RVA: 0x00DA27C4 File Offset: 0x00DA09C4
		public void Tick(float delta)
		{
			AlertAreaUpdateMachine updateMachine = this.UpdateMachine;
			if (((updateMachine != null) ? new bool?(updateMachine.Update(delta)) : null).GetValueOrDefault())
			{
				this.OnMachineDataChange();
			}
		}

		// Token: 0x06030E33 RID: 200243 RVA: 0x00DA2804 File Offset: 0x00DA0A04
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

		// Token: 0x06030E34 RID: 200244 RVA: 0x00DA2860 File Offset: 0x00DA0A60
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

		// Token: 0x06030E35 RID: 200245 RVA: 0x00DA28D0 File Offset: 0x00DA0AD0
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

		// Token: 0x06030E36 RID: 200246 RVA: 0x00DA294C File Offset: 0x00DA0B4C
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

		// Token: 0x06030E37 RID: 200247 RVA: 0x00DA29A8 File Offset: 0x00DA0BA8
		private void SetBarProgressByPercent(float percent)
		{
			float num = MathUtils.Instance.RangeClamp(percent, 0f, 100f, 42f, 83f);
			base.GetSprite(1).SetFillAmount(num * 0.01f);
		}

		// Token: 0x06030E38 RID: 200248 RVA: 0x00DA29E8 File Offset: 0x00DA0BE8
		private void SetBarProgressBufferByPercent(float percent)
		{
			float num = MathUtils.Instance.RangeClamp(percent, 0f, 100f, 42f, 83f);
			base.GetSprite(0).SetFillAmount(num * 0.01f);
		}

		// Token: 0x06030E39 RID: 200249 RVA: 0x00DA2A28 File Offset: 0x00DA0C28
		private void SetTxtProgressByPercent(float percent)
		{
			int num = (int)MathCommon.Clamp(Math.Round((double)percent), 0.0, 100.0);
			base.GetText(2).SetText(num.ToString(), true);
		}

		// Token: 0x06030E3A RID: 200250 RVA: 0x00DA2A6C File Offset: 0x00DA0C6C
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

		// Token: 0x06030E3B RID: 200251 RVA: 0x00DA2B70 File Offset: 0x00DA0D70
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

		// Token: 0x06030E3C RID: 200252 RVA: 0x00DA2C0F File Offset: 0x00DA0E0F
		private void HideTxtProgressTip()
		{
			BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
			if (tweenPlayer != null)
			{
				tweenPlayer.StopTweenAnim(7);
			}
			base.GetText(3).SetUIActive(false);
		}

		// Token: 0x06030E3D RID: 200253 RVA: 0x00DA2C30 File Offset: 0x00DA0E30
		private void InitTweenAnim()
		{
			this.TweenPlayer = new BattleUiTweenAnimPlayer();
			this.TweenPlayer.InitTweenAnim(4, base.GetItem(4), false);
			this.TweenPlayer.InitTweenAnim(5, base.GetItem(5), false);
			this.TweenPlayer.InitTweenAnim(6, base.GetItem(6), false);
			this.TweenPlayer.InitTweenAnim(7, base.GetItem(7), false);
		}

		// Token: 0x06030E3E RID: 200254 RVA: 0x00DA2C98 File Offset: 0x00DA0E98
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

		// Token: 0x04019F19 RID: 106265
		private const float PERCENT_TO_PROGRESS = 0.01f;

		// Token: 0x04019F1A RID: 106266
		private const float UI_BAR_MIN_PERCENT = 42f;

		// Token: 0x04019F1B RID: 106267
		private const float UI_BAR_MAX_PERCENT = 83f;

		// Token: 0x04019F1C RID: 106268
		private int AreaId;

		// Token: 0x04019F1D RID: 106269
		private float AlertValue;

		// Token: 0x04019F1E RID: 106270
		[Nullable(2)]
		private AlertAreaUpdateMachine UpdateMachine;

		// Token: 0x04019F1F RID: 106271
		[Nullable(2)]
		private BattleUiTweenAnimPlayer TweenPlayer;

		// Token: 0x0200A88A RID: 43146
		private enum EVisibleReason
		{
			// Token: 0x04034107 RID: 213255
			Default = 1
		}

		// Token: 0x0200A88B RID: 43147
		private enum EChildComponent
		{
			// Token: 0x04034109 RID: 213257
			BarProgressBuffer,
			// Token: 0x0403410A RID: 213258
			BarProgress,
			// Token: 0x0403410B RID: 213259
			TxtProgress,
			// Token: 0x0403410C RID: 213260
			TxtProgressTip,
			// Token: 0x0403410D RID: 213261
			AniDefault,
			// Token: 0x0403410E RID: 213262
			AniWarningA,
			// Token: 0x0403410F RID: 213263
			AniWarningB,
			// Token: 0x04034110 RID: 213264
			AniTxtTip
		}
	}
}
