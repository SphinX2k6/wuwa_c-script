using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA0 RID: 23968
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleShieldItem : UiPanelBase
	{
		// Token: 0x0603CD9C RID: 249244 RVA: 0x00E9DBF0 File Offset: 0x00E9BDF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CD9D RID: 249245 RVA: 0x00E9DC5C File Offset: 0x00E9BE5C
		protected override void OnStart()
		{
			this.PercentMachine.Duration = 200;
			this.BarSprite = base.GetSprite(0);
			this.BreakEffect = base.GetUiNiagara(1);
			this.BreakEffect.SetUIActive(false);
			this.RefreshBar(true);
			this.AddEvents();
		}

		// Token: 0x0603CD9E RID: 249246 RVA: 0x00E9DCAC File Offset: 0x00E9BEAC
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
			this.StopBreakEffect();
		}

		// Token: 0x0603CD9F RID: 249247 RVA: 0x00E9DCBA File Offset: 0x00E9BEBA
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.SetExistShield(false);
			this.ExistShieldChanged = null;
		}

		// Token: 0x0603CDA0 RID: 249248 RVA: 0x00E9DCD0 File Offset: 0x00E9BED0
		private void AddEvents()
		{
			FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged), null);
			FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged), null);
		}

		// Token: 0x0603CDA1 RID: 249249 RVA: 0x00E9DD04 File Offset: 0x00E9BF04
		private void RemoveEvents()
		{
			FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged));
			FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged));
		}

		// Token: 0x0603CDA2 RID: 249250 RVA: 0x00E9DD36 File Offset: 0x00E9BF36
		private void OnMotorcycleShieldChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			this.RefreshBar(false);
		}

		// Token: 0x0603CDA3 RID: 249251 RVA: 0x00E9DD40 File Offset: 0x00E9BF40
		private void RefreshBar(bool isStart = false)
		{
			float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.MotorcycleShield);
			float max = FormationAttributeController.Instance.GetMax(EFormationAttributeId.MotorcycleShield);
			float num = (max > 0f) ? (value / max) : 0f;
			if (isStart)
			{
				this.PercentMachine.Init(num);
				this.SetBarPercent(this.PercentMachine.GetCurPercent());
			}
			else
			{
				if (this.PercentMachine.GetTargetPercent() == 0f && this.PercentMachine.GetCurPercent() != 0f && num > 0f)
				{
					this.PercentMachine.Init(0f);
					this.PlayBreakEffect();
				}
				this.PercentMachine.SetTargetPercent(num);
			}
			this.SetExistShield(num > 0f);
		}

		// Token: 0x0603CDA4 RID: 249252 RVA: 0x00E9DDF8 File Offset: 0x00E9BFF8
		private void SetExistShield(bool existShield)
		{
			if (this.ExistShield != existShield)
			{
				this.ExistShield = existShield;
				Action existShieldChanged = this.ExistShieldChanged;
				if (existShieldChanged == null)
				{
					return;
				}
				existShieldChanged();
			}
		}

		// Token: 0x0603CDA5 RID: 249253 RVA: 0x00E9DE1A File Offset: 0x00E9C01A
		private void SetBarPercent(float percent)
		{
			UUISprite barSprite = this.BarSprite;
			if (barSprite == null)
			{
				return;
			}
			barSprite.SetFillAmount(percent);
		}

		// Token: 0x0603CDA6 RID: 249254 RVA: 0x00E9DE30 File Offset: 0x00E9C030
		private void PlayBreakEffect()
		{
			if (this.IsPlayingBreakEffect)
			{
				return;
			}
			this.IsPlayingBreakEffect = true;
			UUINiagara breakEffect = this.BreakEffect;
			if (breakEffect != null)
			{
				breakEffect.SetUIActive(true);
			}
			this.BreakEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.BreakEffectTimer = null;
				this.IsPlayingBreakEffect = false;
				UUINiagara breakEffect2 = this.BreakEffect;
				if (breakEffect2 == null)
				{
					return;
				}
				breakEffect2.SetUIActive(false);
			}, 900f, null, null, true, 1f);
		}

		// Token: 0x0603CDA7 RID: 249255 RVA: 0x00E9DE88 File Offset: 0x00E9C088
		private void StopBreakEffect()
		{
			if (!this.IsPlayingBreakEffect)
			{
				return;
			}
			this.IsPlayingBreakEffect = false;
			if (this.BreakEffectTimer != null)
			{
				TimerSystem.Instance.Remove(this.BreakEffectTimer);
				this.BreakEffectTimer = null;
			}
			UUINiagara breakEffect = this.BreakEffect;
			if (breakEffect == null)
			{
				return;
			}
			breakEffect.SetUIActive(false);
		}

		// Token: 0x0603CDA8 RID: 249256 RVA: 0x00E9DED8 File Offset: 0x00E9C0D8
		public void Tick(float delta)
		{
			if (this.PercentMachine.Update(delta))
			{
				float curPercent = this.PercentMachine.GetCurPercent();
				this.SetBarPercent(curPercent);
				if (curPercent == 0f)
				{
					this.PlayBreakEffect();
				}
			}
		}

		// Token: 0x0401FB35 RID: 129845
		private const int BREAK_ANIM_TIME = 900;

		// Token: 0x0401FB36 RID: 129846
		private UUISprite BarSprite;

		// Token: 0x0401FB37 RID: 129847
		private UUINiagara BreakEffect;

		// Token: 0x0401FB38 RID: 129848
		private bool IsPlayingBreakEffect;

		// Token: 0x0401FB39 RID: 129849
		private TimerHandle BreakEffectTimer;

		// Token: 0x0401FB3A RID: 129850
		[Nullable(1)]
		private readonly MotorcycleShieldPercentMachine PercentMachine = new MotorcycleShieldPercentMachine();

		// Token: 0x0401FB3B RID: 129851
		public bool ExistShield;

		// Token: 0x0401FB3C RID: 129852
		public Action ExistShieldChanged;

		// Token: 0x0200C079 RID: 49273
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A14E RID: 237902
			BarSprite,
			// Token: 0x0403A14F RID: 237903
			BreakEffect
		}
	}
}
