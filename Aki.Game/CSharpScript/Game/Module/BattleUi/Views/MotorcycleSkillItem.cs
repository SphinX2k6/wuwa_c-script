using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA3 RID: 23971
	public class MotorcycleSkillItem : BattleSkillItem
	{
		// Token: 0x0603CDE3 RID: 249315 RVA: 0x00E9F050 File Offset: 0x00E9D250
		[NullableContext(2)]
		public override void Refresh(ISkillButtonData skillButtonData)
		{
			if (skillButtonData == null)
			{
				this.InputValue = 0f;
			}
			else if (skillButtonData.GetButtonType() == ESkillButtonType.前进)
			{
				this.InputValue = 1f;
			}
			else if (skillButtonData.GetButtonType() == ESkillButtonType.刹车)
			{
				this.InputValue = -1f;
			}
			else
			{
				this.InputValue = 0f;
			}
			base.Refresh(skillButtonData);
		}

		// Token: 0x0603CDE4 RID: 249316 RVA: 0x00E9F0B4 File Offset: 0x00E9D2B4
		[NullableContext(1)]
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x0603CDE5 RID: 249317 RVA: 0x00E9F0D4 File Offset: 0x00E9D2D4
		protected override void OnSkillButtonPressed()
		{
			if (this.InputValue == 0f)
			{
				base.OnSkillButtonPressed();
				return;
			}
			this.IsPress = true;
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Play();
			}
			InputController.Instance.InputAxis(EInputAxis.MoveForward, this.InputValue, true);
		}

		// Token: 0x0603CDE6 RID: 249318 RVA: 0x00E9F123 File Offset: 0x00E9D323
		protected override void OnSkillButtonReleased()
		{
			if (this.InputValue == 0f)
			{
				base.OnSkillButtonReleased();
				return;
			}
			this.IsPress = false;
			InputController.Instance.InputAxis(EInputAxis.MoveForward, 0f, true);
		}

		// Token: 0x0603CDE7 RID: 249319 RVA: 0x00E9F155 File Offset: 0x00E9D355
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (!this.IsPress)
			{
				return;
			}
			InputController.Instance.InputAxis(EInputAxis.MoveForward, this.InputValue, true);
		}

		// Token: 0x0603CDE8 RID: 249320 RVA: 0x00E9F17D File Offset: 0x00E9D37D
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.IsPress = false;
		}

		// Token: 0x0603CDE9 RID: 249321 RVA: 0x00E9F18C File Offset: 0x00E9D38C
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			if (this.InputValue == 0f)
			{
				base.OnInputAction(bForcePlayClickEffect);
				return;
			}
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0401FB49 RID: 129865
		private bool IsPress;

		// Token: 0x0401FB4A RID: 129866
		private float InputValue;
	}
}
