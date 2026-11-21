using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D3E RID: 19774
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class HonamiStoryViewBase : BattleVisibleChildView
	{
		// Token: 0x06031A15 RID: 203285 RVA: 0x00DE0CF8 File Offset: 0x00DDEEF8
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

		// Token: 0x06031A16 RID: 203286 RVA: 0x00DE0E54 File Offset: 0x00DDF054
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

		// Token: 0x06031A17 RID: 203287 RVA: 0x00DE0F04 File Offset: 0x00DDF104
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

		// Token: 0x06031A18 RID: 203288 RVA: 0x00DE0F9C File Offset: 0x00DDF19C
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnAttributeChanged));
			FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnAttributeChanged));
		}

		// Token: 0x06031A19 RID: 203289 RVA: 0x00DE0FF8 File Offset: 0x00DDF1F8
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

		// Token: 0x06031A1A RID: 203290 RVA: 0x00DE105B File Offset: 0x00DDF25B
		private void OnAttributeChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			this.RefreshAttribute(false);
		}

		// Token: 0x06031A1B RID: 203291 RVA: 0x00DE1064 File Offset: 0x00DDF264
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

		// Token: 0x06031A1C RID: 203292 RVA: 0x00DE112C File Offset: 0x00DDF32C
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

		// Token: 0x06031A1D RID: 203293 RVA: 0x00DE123C File Offset: 0x00DDF43C
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

		// Token: 0x06031A1E RID: 203294 RVA: 0x00DE12E9 File Offset: 0x00DDF4E9
		private void PlaySequence(string sequenceName)
		{
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely(sequenceName, false, false);
		}

		// Token: 0x06031A1F RID: 203295 RVA: 0x00DE1306 File Offset: 0x00DDF506
		protected virtual void OnInitData()
		{
		}

		// Token: 0x06031A20 RID: 203296 RVA: 0x00DE1308 File Offset: 0x00DDF508
		protected virtual void OnRefreshState(EHpStateType state)
		{
		}

		// Token: 0x06031A21 RID: 203297 RVA: 0x00DE130A File Offset: 0x00DDF50A
		protected virtual void OnRefreshAttribute(float percent, EHpStateType state)
		{
		}

		// Token: 0x0401A45D RID: 107613
		protected const EFormationAttributeId AttributeId = EFormationAttributeId.HonamiStoryLifeSupport;

		// Token: 0x0401A45E RID: 107614
		private const float ROOT_TRANSLUCENT_ALPHA = 0.2f;

		// Token: 0x0401A45F RID: 107615
		protected float DangerPercent;

		// Token: 0x0401A460 RID: 107616
		protected float NormalPercent;

		// Token: 0x0401A461 RID: 107617
		private EHpStateType StateType;

		// Token: 0x0401A462 RID: 107618
		protected int HpTextType;

		// Token: 0x0401A463 RID: 107619
		protected int InTweenType;

		// Token: 0x0401A464 RID: 107620
		protected int OutTweenType;

		// Token: 0x0401A465 RID: 107621
		protected string DangerPercentConfigId = string.Empty;

		// Token: 0x0401A466 RID: 107622
		protected EFunctionType? ShowFunctionType;

		// Token: 0x0401A467 RID: 107623
		protected EFunctionType? HideFunctionType;

		// Token: 0x0401A468 RID: 107624
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401A469 RID: 107625
		[Nullable(2)]
		private BattleUiTweenAnimPlayer TweenPlayer;
	}
}
