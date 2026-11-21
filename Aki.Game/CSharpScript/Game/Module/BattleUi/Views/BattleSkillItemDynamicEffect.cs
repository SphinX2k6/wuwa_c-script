using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CCD RID: 19661
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillItemDynamicEffect
	{
		// Token: 0x0603131C RID: 201500 RVA: 0x00DBBC31 File Offset: 0x00DB9E31
		public BattleSkillItemDynamicEffect(UUINiagara UiEffect)
		{
		}

		// Token: 0x0603131D RID: 201501 RVA: 0x00DBBC57 File Offset: 0x00DB9E57
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

		// Token: 0x0603131E RID: 201502 RVA: 0x00DBBC90 File Offset: 0x00DB9E90
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

		// Token: 0x0603131F RID: 201503 RVA: 0x00DBBD40 File Offset: 0x00DB9F40
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

		// Token: 0x06031320 RID: 201504 RVA: 0x00DBBE5C File Offset: 0x00DBA05C
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

		// Token: 0x06031321 RID: 201505 RVA: 0x00DBBEB0 File Offset: 0x00DBA0B0
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

		// Token: 0x06031322 RID: 201506 RVA: 0x00DBBEFC File Offset: 0x00DBA0FC
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

		// Token: 0x06031323 RID: 201507 RVA: 0x00DBBF23 File Offset: 0x00DBA123
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

		// Token: 0x0401A0F9 RID: 106745
		[CompilerGenerated]
		private UUINiagara <UiEffect>P = UiEffect;

		// Token: 0x0401A0FA RID: 106746
		private int? LoadDynamicEffectNiagaraHandleId = new int?(0);

		// Token: 0x0401A0FB RID: 106747
		private string CurrentDynamicEffectPath;

		// Token: 0x0401A0FC RID: 106748
		private int DynamicEffectElementId;

		// Token: 0x0401A0FD RID: 106749
		private string DynamicEffectColor;

		// Token: 0x0401A0FE RID: 106750
		private string LoadDynamicEffectPath;

		// Token: 0x0401A0FF RID: 106751
		private float DynamicEffectScale = 1f;

		// Token: 0x0401A100 RID: 106752
		private SkillButtonEffect? EffectConfig;
	}
}
