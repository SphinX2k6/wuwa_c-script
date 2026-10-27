using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CEB RID: 23787
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillItemDynamicEffect
	{
		// Token: 0x0603C3C6 RID: 246726 RVA: 0x00E6B67D File Offset: 0x00E6987D
		public BattleSkillItemDynamicEffect(UUINiagara UiEffect)
		{
		}

		// Token: 0x0603C3C7 RID: 246727 RVA: 0x00E6B6A3 File Offset: 0x00E698A3
		public void CancelLoadDynamicEffectNiagara()
		{
			if (this.LoadDynamicEffectNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadDynamicEffectNiagaraHandleId.Value);
			this.LoadDynamicEffectNiagaraHandleId = null;
			this.LoadDynamicEffectPath = null;
		}

		// Token: 0x0603C3C8 RID: 246728 RVA: 0x00E6B6DC File Offset: 0x00E698DC
		public void RefreshDynamicEffect(SkillButtonEffect? effectConfig)
		{
			this.EffectConfig = effectConfig;
			string text = null;
			if (effectConfig != null)
			{
				SkillButtonEffect value = effectConfig.Value;
				text = this.GetDynamicEffectPath(value);
			}
			this.RefreshDynamicEffectScale(effectConfig);
			if (this.CurrentDynamicEffectPath == text)
			{
				if (this.LoadDynamicEffectPath == null)
				{
					this.RefreshDynamicEffectColor(effectConfig, true);
				}
				return;
			}
			this.CancelLoadDynamicEffectNiagara();
			this.CurrentDynamicEffectPath = text;
			if (this.CurrentDynamicEffectPath == null)
			{
				this.SetDynamicEffectVisible(false);
				return;
			}
			this.LoadDynamicEffectPath = this.CurrentDynamicEffectPath;
			this.LoadDynamicEffectNiagaraHandleId = new int?(ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(this.LoadDynamicEffectPath, delegate([Nullable(2)] UNiagaraSystem effectObject, string _)
			{
				this.LoadDynamicEffectPath = null;
				if (effectObject == null || !effectObject.IsValid())
				{
					return;
				}
				UUINiagara uuiniagara = this.<UiEffect>P;
				if (uuiniagara == null)
				{
					return;
				}
				uuiniagara.SetNiagaraSystem(effectObject);
				this.RefreshDynamicEffectColor(this.EffectConfig, false);
				this.SetDynamicEffectVisible(true);
			}, 100, "js_undefined"));
		}

		// Token: 0x0603C3C9 RID: 246729 RVA: 0x00E6B78C File Offset: 0x00E6998C
		private void RefreshDynamicEffectColor(SkillButtonEffect? optEffectConfig, bool bReset = false)
		{
			if (optEffectConfig == null)
			{
				return;
			}
			SkillButtonEffect value = optEffectConfig.Value;
			if (value.ElementId == this.DynamicEffectElementId && value.Color == this.DynamicEffectColor)
			{
				return;
			}
			FLinearColor? flinearColor = null;
			this.DynamicEffectColor = value.Color;
			if (!string.IsNullOrEmpty(this.DynamicEffectColor))
			{
				this.DynamicEffectElementId = 0;
				FColor fcolor = FColor.FromHex(this.DynamicEffectColor);
				flinearColor = new FLinearColor?(new FLinearColor(ref fcolor));
			}
			else
			{
				this.DynamicEffectElementId = value.ElementId;
				if (this.DynamicEffectElementId > 0)
				{
					FColor fcolor = FColor.FromHex(ElementInfoConfig.Instance.GetElementInfo(this.DynamicEffectElementId).Value.SkillEffectColor);
					flinearColor = new FLinearColor?(new FLinearColor(ref fcolor));
				}
			}
			UUINiagara uuiniagara = this.<UiEffect>P;
			if (flinearColor != null)
			{
				uuiniagara.SetNiagaraVarLinearColor("Color", flinearColor.Value);
				return;
			}
			uuiniagara.ResetOverrideParameters();
			if (bReset && uuiniagara.NiagaraComponent != null)
			{
				uuiniagara.NiagaraComponent.ResetOverrideParametersAndActivate(true, "");
			}
		}

		// Token: 0x0603C3CA RID: 246730 RVA: 0x00E6B8A8 File Offset: 0x00E69AA8
		protected void RefreshDynamicEffectScale(SkillButtonEffect? effectConfig)
		{
			float num = (effectConfig != null) ? effectConfig.GetValueOrDefault().Scale : 1f;
			if (this.DynamicEffectScale == num)
			{
				return;
			}
			this.DynamicEffectScale = num;
			UUINiagara uuiniagara = this.<UiEffect>P;
			if (uuiniagara == null)
			{
				return;
			}
			uuiniagara.SetUIItemScale(new FVector(num));
		}

		// Token: 0x0603C3CB RID: 246731 RVA: 0x00E6B8FC File Offset: 0x00E69AFC
		public void SetDynamicEffectVisible(bool visible)
		{
			UUINiagara uuiniagara = this.<UiEffect>P;
			if (uuiniagara == null)
			{
				return;
			}
			if (!visible)
			{
				if (uuiniagara.bIsUIActive)
				{
					uuiniagara.SetUIActive(false);
				}
				return;
			}
			if (!uuiniagara.bIsUIActive)
			{
				uuiniagara.SetUIActive(true);
				uuiniagara.ActivateSystem(true);
				return;
			}
			uuiniagara.ActivateSystem(true);
		}

		// Token: 0x0603C3CC RID: 246732 RVA: 0x00E6B948 File Offset: 0x00E69B48
		protected string GetDynamicEffectPath(in SkillButtonEffect effectConfig)
		{
			SkillButtonEffect skillButtonEffect = effectConfig;
			string niagaraPath = skillButtonEffect.NiagaraPath;
			if (string.IsNullOrEmpty(niagaraPath))
			{
				return null;
			}
			return niagaraPath;
		}

		// Token: 0x0603C3CD RID: 246733 RVA: 0x00E6B96F File Offset: 0x00E69B6F
		public void Reset()
		{
			this.CancelLoadDynamicEffectNiagara();
			if (this.DynamicEffectElementId != 0 || this.DynamicEffectColor != null)
			{
				UUINiagara uuiniagara = this.<UiEffect>P;
				if (uuiniagara != null)
				{
					uuiniagara.ResetOverrideParameters();
				}
				this.DynamicEffectElementId = 0;
				this.DynamicEffectColor = null;
			}
		}

		// Token: 0x0401F640 RID: 128576
		[CompilerGenerated]
		private UUINiagara <UiEffect>P = UiEffect;

		// Token: 0x0401F641 RID: 128577
		private int? LoadDynamicEffectNiagaraHandleId = new int?(0);

		// Token: 0x0401F642 RID: 128578
		private string CurrentDynamicEffectPath;

		// Token: 0x0401F643 RID: 128579
		private int DynamicEffectElementId;

		// Token: 0x0401F644 RID: 128580
		private string DynamicEffectColor;

		// Token: 0x0401F645 RID: 128581
		private string LoadDynamicEffectPath;

		// Token: 0x0401F646 RID: 128582
		private float DynamicEffectScale = 1f;

		// Token: 0x0401F647 RID: 128583
		private SkillButtonEffect? EffectConfig;
	}
}
