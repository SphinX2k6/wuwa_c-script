using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D82 RID: 19842
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleShieldItem : UiPanelBase
	{
		// Token: 0x06031CF9 RID: 204025 RVA: 0x00DEE4A8 File Offset: 0x00DEC6A8
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

		// Token: 0x06031CFA RID: 204026 RVA: 0x00DEE514 File Offset: 0x00DEC714
		protected override void OnStart()
		{
			this.PercentMachine.Duration = 200;
			this.BarSprite = base.GetSprite(0);
			this.BreakEffect = base.GetUiNiagara(1);
			this.BreakEffect.SetUIActive(false);
			this.RefreshBar(true);
			this.AddEvents();
		}

		// Token: 0x06031CFB RID: 204027 RVA: 0x00DEE564 File Offset: 0x00DEC764
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
			this.StopBreakEffect();
		}

		// Token: 0x06031CFC RID: 204028 RVA: 0x00DEE572 File Offset: 0x00DEC772
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.SetExistShield(false);
			this.ExistShieldChanged = null;
		}

		// Token: 0x06031CFD RID: 204029 RVA: 0x00DEE588 File Offset: 0x00DEC788
		private void AddEvents()
		{
			FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged), null);
			FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged), null);
		}

		// Token: 0x06031CFE RID: 204030 RVA: 0x00DEE5BC File Offset: 0x00DEC7BC
		private void RemoveEvents()
		{
			FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged));
			FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.MotorcycleShield, new TValueListener(this.OnMotorcycleShieldChanged));
		}

		// Token: 0x06031CFF RID: 204031 RVA: 0x00DEE5EE File Offset: 0x00DEC7EE
		private void OnMotorcycleShieldChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			this.RefreshBar(false);
		}

		// Token: 0x06031D00 RID: 204032 RVA: 0x00DEE5F8 File Offset: 0x00DEC7F8
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

		// Token: 0x06031D01 RID: 204033 RVA: 0x00DEE6B0 File Offset: 0x00DEC8B0
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

		// Token: 0x06031D02 RID: 204034 RVA: 0x00DEE6D2 File Offset: 0x00DEC8D2
		private void SetBarPercent(float percent)
		{
			UUISprite barSprite = this.BarSprite;
			if (barSprite == null)
			{
				return;
			}
			barSprite.SetFillAmount(percent);
		}

		// Token: 0x06031D03 RID: 204035 RVA: 0x00DEE6E8 File Offset: 0x00DEC8E8
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

		// Token: 0x06031D04 RID: 204036 RVA: 0x00DEE740 File Offset: 0x00DEC940
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

		// Token: 0x06031D05 RID: 204037 RVA: 0x00DEE790 File Offset: 0x00DEC990
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

		// Token: 0x0401A5ED RID: 108013
		private const int BREAK_ANIM_TIME = 900;

		// Token: 0x0401A5EE RID: 108014
		private UUISprite BarSprite;

		// Token: 0x0401A5EF RID: 108015
		private UUINiagara BreakEffect;

		// Token: 0x0401A5F0 RID: 108016
		private bool IsPlayingBreakEffect;

		// Token: 0x0401A5F1 RID: 108017
		private TimerHandle BreakEffectTimer;

		// Token: 0x0401A5F2 RID: 108018
		[Nullable(1)]
		private readonly MotorcycleShieldPercentMachine PercentMachine = new MotorcycleShieldPercentMachine();

		// Token: 0x0401A5F3 RID: 108019
		public bool ExistShield;

		// Token: 0x0401A5F4 RID: 108020
		public Action ExistShieldChanged;

		// Token: 0x0200AA7F RID: 43647
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034B11 RID: 215825
			BarSprite,
			// Token: 0x04034B12 RID: 215826
			BreakEffect
		}
	}
}
