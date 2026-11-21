using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D85 RID: 19845
	public class MotorcycleSkillItem : BattleSkillItem
	{
		// Token: 0x06031D40 RID: 204096 RVA: 0x00DEF908 File Offset: 0x00DEDB08
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

		// Token: 0x06031D41 RID: 204097 RVA: 0x00DEF96C File Offset: 0x00DEDB6C
		[NullableContext(1)]
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x06031D42 RID: 204098 RVA: 0x00DEF98C File Offset: 0x00DEDB8C
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

		// Token: 0x06031D43 RID: 204099 RVA: 0x00DEF9DB File Offset: 0x00DEDBDB
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

		// Token: 0x06031D44 RID: 204100 RVA: 0x00DEFA0D File Offset: 0x00DEDC0D
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (!this.IsPress)
			{
				return;
			}
			InputController.Instance.InputAxis(EInputAxis.MoveForward, this.InputValue, true);
		}

		// Token: 0x06031D45 RID: 204101 RVA: 0x00DEFA35 File Offset: 0x00DEDC35
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.IsPress = false;
		}

		// Token: 0x06031D46 RID: 204102 RVA: 0x00DEFA44 File Offset: 0x00DEDC44
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

		// Token: 0x0401A601 RID: 108033
		private bool IsPress;

		// Token: 0x0401A602 RID: 108034
		private float InputValue;
	}
}
