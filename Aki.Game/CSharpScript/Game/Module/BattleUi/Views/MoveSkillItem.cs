using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA5 RID: 23973
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveSkillItem : BattleSkillItem
	{
		// Token: 0x0603CDF2 RID: 249330 RVA: 0x00E9F4B5 File Offset: 0x00E9D6B5
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

		// Token: 0x0603CDF3 RID: 249331 RVA: 0x00E9F4DC File Offset: 0x00E9D6DC
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

		// Token: 0x0603CDF4 RID: 249332 RVA: 0x00E9F568 File Offset: 0x00E9D768
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x0603CDF5 RID: 249333 RVA: 0x00E9F588 File Offset: 0x00E9D788
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

		// Token: 0x0603CDF6 RID: 249334 RVA: 0x00E9F5BE File Offset: 0x00E9D7BE
		protected override void OnSkillButtonReleased()
		{
			this.IsPress = false;
			InputController.Instance.InputAxis(this.InputAxis, 0f, this.AutoClearInput);
		}

		// Token: 0x0603CDF7 RID: 249335 RVA: 0x00E9F5E2 File Offset: 0x00E9D7E2
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (!this.IsPress || !this.AutoClearInput)
			{
				return;
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
		}

		// Token: 0x0603CDF8 RID: 249336 RVA: 0x00E9F613 File Offset: 0x00E9D813
		protected override void OnBeforeHide()
		{
			this.IsPress = false;
		}

		// Token: 0x0603CDF9 RID: 249337 RVA: 0x00E9F61C File Offset: 0x00E9D81C
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0603CDFA RID: 249338 RVA: 0x00E9F62E File Offset: 0x00E9D82E
		public void SetCustomDynamicEffectId(int effectId)
		{
			this.CustomDynamicEffectId = effectId;
			this.RefreshDynamicEffect();
		}

		// Token: 0x0603CDFB RID: 249339 RVA: 0x00E9F640 File Offset: 0x00E9D840
		protected override SkillButtonEffect? GetDynamicEffectConfig()
		{
			if (this.CustomDynamicEffectId == 0)
			{
				return null;
			}
			return SkillButtonConfig.Instance.GetSkillButtonEffectConfig(this.CustomDynamicEffectId);
		}

		// Token: 0x0603CDFC RID: 249340 RVA: 0x00E9F66F File Offset: 0x00E9D86F
		public void SetCustomSkillItemEnable(bool bEnable)
		{
			base.SetSkillItemEnable(bEnable, true);
		}

		// Token: 0x0401FB54 RID: 129876
		private EInputAxis InputAxis = EInputAxis.None;

		// Token: 0x0401FB55 RID: 129877
		private float InputValue;

		// Token: 0x0401FB56 RID: 129878
		private int CustomDynamicEffectId;

		// Token: 0x0401FB57 RID: 129879
		private bool AutoClearInput = true;

		// Token: 0x0401FB58 RID: 129880
		private bool IsPress;
	}
}
