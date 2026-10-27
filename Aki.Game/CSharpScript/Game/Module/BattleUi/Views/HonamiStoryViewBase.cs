using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D5C RID: 23900
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class HonamiStoryViewBase : BattleVisibleChildView
	{
		// Token: 0x0603CABC RID: 248508 RVA: 0x00E90544 File Offset: 0x00E8E744
		protected override void OnStart()
		{
			this.OnInitData();
			base.InitChildType(EBattleUiChild.Ignore);
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.DangerPercent = ConfigCommonParamById.GetFloatConfig(this.DangerPercentConfigId).GetValueOrDefault();
			this.NormalPercent = 1f - this.DangerPercent;
			UUIText text = base.GetText(this.HpTextType);
			text.SetRichText(true);
			text.SetGameRichText(true);
			this.TweenPlayer = new BattleUiTweenAnimPlayer();
			this.TweenPlayer.InitTweenAnim(this.InTweenType, base.GetItem(this.InTweenType), false);
			this.TweenPlayer.InitTweenAnim(this.OutTweenType, base.GetItem(this.OutTweenType), false);
			object obj = this.ShowFunctionType == null || FunctionModel.Instance.IsOpen((int)this.ShowFunctionType.Value);
			bool flag = this.HideFunctionType == null || FunctionModel.Instance.IsOpen((int)this.HideFunctionType.Value);
			object obj2 = obj;
			if (obj2 == null || (this.HideFunctionType != null && flag))
			{
				base.SetVisible(1, false);
			}
			if (obj2 == null || !flag)
			{
				EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
				EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			}
		}

		// Token: 0x0603CABD RID: 248509 RVA: 0x00E906A0 File Offset: 0x00E8E8A0
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			BattleUiTweenAnimPlayer tweenPlayer = this.TweenPlayer;
			if (tweenPlayer != null)
			{
				tweenPlayer.Clear(false);
			}
			this.TweenPlayer = null;
			if (EventSystem.Instance.Has(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate)))
			{
				EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			}
			if (EventSystem.Instance.Has(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate)))
			{
				EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			}
		}

		// Token: 0x0603CABE RID: 248510 RVA: 0x00E90750 File Offset: 0x00E8E950
		protected override void OnBeforeShow()
		{
			UUIItem rootItem = this.RootItem;
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PlotViewHUD);
			rootItem.SetAlpha((viewByName != null && viewByName.IsShow) ? 0.2f : 1f);
			EventSystem.Instance.Add(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnAttributeChanged), null);
			FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnAttributeChanged), null);
			this.RefreshAttribute(true);
		}

		// Token: 0x0603CABF RID: 248511 RVA: 0x00E907E8 File Offset: 0x00E8E9E8
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnAttributeChanged));
			FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnAttributeChanged));
		}

		// Token: 0x0603CAC0 RID: 248512 RVA: 0x00E90844 File Offset: 0x00E8EA44
		private void OnPlotViewChange(EUiViewName viewName, bool isShow)
		{
			if (viewName != EUiViewName.PlotViewHUD)
			{
				return;
			}
			if (isShow)
			{
				this.TweenPlayer.StopTweenAnim(this.InTweenType);
				this.TweenPlayer.PlayTweenAnim(this.OutTweenType);
				return;
			}
			this.TweenPlayer.StopTweenAnim(this.OutTweenType);
			this.TweenPlayer.PlayTweenAnim(this.InTweenType);
		}

		// Token: 0x0603CAC1 RID: 248513 RVA: 0x00E908A7 File Offset: 0x00E8EAA7
		private void OnAttributeChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			this.RefreshAttribute(false);
		}

		// Token: 0x0603CAC2 RID: 248514 RVA: 0x00E908B0 File Offset: 0x00E8EAB0
		private void RefreshAttribute(bool isInit = false)
		{
			float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.HonamiStoryLifeSupport);
			float max = FormationAttributeController.Instance.GetMax(EFormationAttributeId.HonamiStoryLifeSupport);
			float num = value / max;
			EHpStateType ehpStateType = EHpStateType.Normal;
			if (num == 0f)
			{
				ehpStateType = EHpStateType.Dead;
			}
			else if (num <= this.DangerPercent)
			{
				ehpStateType = EHpStateType.Danger;
			}
			if (isInit || ehpStateType != this.StateType)
			{
				this.OnRefreshState(ehpStateType);
				string sequenceName = "Start";
				switch (ehpStateType)
				{
				case EHpStateType.Normal:
					sequenceName = (isInit ? "Start" : "Recover");
					break;
				case EHpStateType.Danger:
					sequenceName = "Red";
					break;
				case EHpStateType.Dead:
					sequenceName = "Ovr";
					break;
				}
				this.PlaySequence(sequenceName);
			}
			this.StateType = ehpStateType;
			this.OnRefreshAttribute(num, ehpStateType);
			base.GetText(this.HpTextType).SetText(this.GetHpText(ehpStateType, value, max), true);
		}

		// Token: 0x0603CAC3 RID: 248515 RVA: 0x00E90978 File Offset: 0x00E8EB78
		private string GetHpText(EHpStateType state, float curValue, float maxValue)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (state == EHpStateType.Danger)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ec5a7aff>");
				defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)curValue));
				defaultInterpolatedStringHandler.AppendLiteral("</color><color=#ffffff>/");
				defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)maxValue));
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (state != EHpStateType.Dead)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
				defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)curValue));
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)maxValue));
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#ec5a7aff>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)curValue));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)maxValue));
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603CAC4 RID: 248516 RVA: 0x00E90A88 File Offset: 0x00E8EC88
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			EFunctionType? efunctionType = this.ShowFunctionType;
			if (!(functionType == efunctionType.GetValueOrDefault() & efunctionType != null))
			{
				efunctionType = this.HideFunctionType;
				if (!(functionType == efunctionType.GetValueOrDefault() & efunctionType != null))
				{
					return;
				}
			}
			bool flag = this.ShowFunctionType == null || FunctionModel.Instance.IsOpen((int)this.ShowFunctionType.Value);
			bool flag2 = this.HideFunctionType == null || FunctionModel.Instance.IsOpen((int)this.HideFunctionType.Value);
			bool flag3 = !flag || (this.HideFunctionType != null && flag2);
			base.SetVisible(1, !flag3);
		}

		// Token: 0x0603CAC5 RID: 248517 RVA: 0x00E90B35 File Offset: 0x00E8ED35
		private void PlaySequence(string sequenceName)
		{
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely(sequenceName, false, false);
		}

		// Token: 0x0603CAC6 RID: 248518 RVA: 0x00E90B52 File Offset: 0x00E8ED52
		protected virtual void OnInitData()
		{
		}

		// Token: 0x0603CAC7 RID: 248519 RVA: 0x00E90B54 File Offset: 0x00E8ED54
		protected virtual void OnRefreshState(EHpStateType state)
		{
		}

		// Token: 0x0603CAC8 RID: 248520 RVA: 0x00E90B56 File Offset: 0x00E8ED56
		protected virtual void OnRefreshAttribute(float percent, EHpStateType state)
		{
		}

		// Token: 0x0401F9A4 RID: 129444
		protected const EFormationAttributeId AttributeId = EFormationAttributeId.HonamiStoryLifeSupport;

		// Token: 0x0401F9A5 RID: 129445
		private const float ROOT_TRANSLUCENT_ALPHA = 0.2f;

		// Token: 0x0401F9A6 RID: 129446
		protected float DangerPercent;

		// Token: 0x0401F9A7 RID: 129447
		protected float NormalPercent;

		// Token: 0x0401F9A8 RID: 129448
		private EHpStateType StateType;

		// Token: 0x0401F9A9 RID: 129449
		protected int HpTextType;

		// Token: 0x0401F9AA RID: 129450
		protected int InTweenType;

		// Token: 0x0401F9AB RID: 129451
		protected int OutTweenType;

		// Token: 0x0401F9AC RID: 129452
		protected string DangerPercentConfigId = string.Empty;

		// Token: 0x0401F9AD RID: 129453
		protected EFunctionType? ShowFunctionType;

		// Token: 0x0401F9AE RID: 129454
		protected EFunctionType? HideFunctionType;

		// Token: 0x0401F9AF RID: 129455
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401F9B0 RID: 129456
		[Nullable(2)]
		private BattleUiTweenAnimPlayer TweenPlayer;
	}
}
