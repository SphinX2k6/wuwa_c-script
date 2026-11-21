using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D87 RID: 19847
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveSkillItem : BattleSkillItem
	{
		// Token: 0x06031D4F RID: 204111 RVA: 0x00DEFD6D File Offset: 0x00DEDF6D
		public void RefreshByMoveType(EInputAxis inputAxis, float inputValue, bool autoClearInput = true)
		{
			this.InputAxis = inputAxis;
			this.InputValue = inputValue;
			this.AutoClearInput = autoClearInput;
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x06031D50 RID: 204112 RVA: 0x00DEFD94 File Offset: 0x00DEDF94
		public void RefreshKeyByActionName(string actionName)
		{
			EOperationType operationType = Info.Instance.OperationType;
			if (operationType != EOperationType.Desktop)
			{
				return;
			}
			if (this.KeyActionName == actionName)
			{
				EOperationType? keyOperationType = this.KeyOperationType;
				EOperationType eoperationType = operationType;
				if (keyOperationType.GetValueOrDefault() == eoperationType & keyOperationType != null)
				{
					return;
				}
			}
			if (this.KeyItem != null)
			{
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = actionName
				};
				this.KeyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
				this.KeyItem.SetActive(true);
			}
			this.KeyOperationType = new EOperationType?(operationType);
			this.KeyActionName = actionName;
		}

		// Token: 0x06031D51 RID: 204113 RVA: 0x00DEFE20 File Offset: 0x00DEE020
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x06031D52 RID: 204114 RVA: 0x00DEFE40 File Offset: 0x00DEE040
		protected override void OnSkillButtonPressed()
		{
			this.IsPress = true;
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Play();
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, this.AutoClearInput);
		}

		// Token: 0x06031D53 RID: 204115 RVA: 0x00DEFE76 File Offset: 0x00DEE076
		protected override void OnSkillButtonReleased()
		{
			this.IsPress = false;
			InputController.Instance.InputAxis(this.InputAxis, 0f, this.AutoClearInput);
		}

		// Token: 0x06031D54 RID: 204116 RVA: 0x00DEFE9A File Offset: 0x00DEE09A
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (!this.IsPress || !this.AutoClearInput)
			{
				return;
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
		}

		// Token: 0x06031D55 RID: 204117 RVA: 0x00DEFECB File Offset: 0x00DEE0CB
		protected override void OnBeforeHide()
		{
			this.IsPress = false;
		}

		// Token: 0x06031D56 RID: 204118 RVA: 0x00DEFED4 File Offset: 0x00DEE0D4
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x06031D57 RID: 204119 RVA: 0x00DEFEE6 File Offset: 0x00DEE0E6
		public void SetCustomDynamicEffectId(int effectId)
		{
			this.CustomDynamicEffectId = effectId;
			this.RefreshDynamicEffect();
		}

		// Token: 0x06031D58 RID: 204120 RVA: 0x00DEFEF8 File Offset: 0x00DEE0F8
		protected override SkillButtonEffect? GetDynamicEffectConfig()
		{
			if (this.CustomDynamicEffectId == 0)
			{
				return null;
			}
			return SkillButtonConfig.Instance.GetSkillButtonEffectConfig(this.CustomDynamicEffectId);
		}

		// Token: 0x06031D59 RID: 204121 RVA: 0x00DEFF27 File Offset: 0x00DEE127
		public void SetCustomSkillItemEnable(bool bEnable)
		{
			base.SetSkillItemEnable(bEnable, true);
		}

		// Token: 0x0401A60C RID: 108044
		private EInputAxis InputAxis = EInputAxis.None;

		// Token: 0x0401A60D RID: 108045
		private float InputValue;

		// Token: 0x0401A60E RID: 108046
		private int CustomDynamicEffectId;

		// Token: 0x0401A60F RID: 108047
		private bool AutoClearInput = true;

		// Token: 0x0401A610 RID: 108048
		private bool IsPress;
	}
}
