using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E12 RID: 19986
	[NullableContext(1)]
	[Nullable(0)]
	public class XiaKongQteSkillItem : BattleSkillItem
	{
		// Token: 0x06032496 RID: 205974 RVA: 0x00E18CD8 File Offset: 0x00E16ED8
		public void SetPressCallback(Action<int> onPressCallback)
		{
			this.OnPressCallback = onPressCallback;
		}

		// Token: 0x06032497 RID: 205975 RVA: 0x00E18CE1 File Offset: 0x00E16EE1
		public void RefreshType(int inputType)
		{
			this.InputType = inputType;
			this.RefreshOnInputControllerMainTypeChange();
		}

		// Token: 0x06032498 RID: 205976 RVA: 0x00E18CF0 File Offset: 0x00E16EF0
		public void RefreshOnInputControllerMainTypeChange()
		{
			string actionNameByInputType = this.GetActionNameByInputType(this.InputType);
			if (!string.IsNullOrEmpty(actionNameByInputType))
			{
				this.RefreshKeyByActionName(actionNameByInputType);
			}
		}

		// Token: 0x06032499 RID: 205977 RVA: 0x00E18D19 File Offset: 0x00E16F19
		[NullableContext(2)]
		private string GetActionNameByInputType(int inputType)
		{
			if (Info.Instance.IsInTouch())
			{
				return null;
			}
			if (inputType == 1)
			{
				return "向右移动";
			}
			if (inputType == 2)
			{
				return "向左移动";
			}
			if (inputType == 4)
			{
				return "大招";
			}
			return null;
		}

		// Token: 0x0603249A RID: 205978 RVA: 0x00E18D48 File Offset: 0x00E16F48
		private void RefreshKeyByActionName(string actionName)
		{
			if (Info.Instance.OperationType != EOperationType.Desktop)
			{
				return;
			}
			if (this.KeyActionName == actionName)
			{
				return;
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
			this.KeyActionName = actionName;
		}

		// Token: 0x0603249B RID: 205979 RVA: 0x00E18DA8 File Offset: 0x00E16FA8
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x0603249C RID: 205980 RVA: 0x00E18DC8 File Offset: 0x00E16FC8
		protected override void OnSkillButtonPressed()
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Play();
			}
			Action<int> onPressCallback = this.OnPressCallback;
			if (onPressCallback == null)
			{
				return;
			}
			onPressCallback(this.InputType);
		}

		// Token: 0x0603249D RID: 205981 RVA: 0x00E18DF1 File Offset: 0x00E16FF1
		public void SetEnable(bool enable)
		{
			this.Enable = enable;
			this.RefreshEnable(false);
			this.RefreshDynamicEffect();
		}

		// Token: 0x0603249E RID: 205982 RVA: 0x00E18E07 File Offset: 0x00E17007
		public override void RefreshEnable(bool bForce = false)
		{
			base.SetSkillItemEnable(this.Enable, bForce);
		}

		// Token: 0x0603249F RID: 205983 RVA: 0x00E18E16 File Offset: 0x00E17016
		public override void RefreshDynamicEffect()
		{
			base.SetDynamicEffectVisible(this.Enable);
		}

		// Token: 0x060324A0 RID: 205984 RVA: 0x00E18E24 File Offset: 0x00E17024
		public void SetSkillIconName(string skillIconName)
		{
			LguiUtil.Instance.SetLocalTextNew(this.SkillNameText, skillIconName, Array.Empty<object>());
			this.SkillNameText.SetUIActive(true);
		}

		// Token: 0x0401AA6B RID: 109163
		private int InputType;

		// Token: 0x0401AA6C RID: 109164
		[Nullable(2)]
		private Action<int> OnPressCallback;

		// Token: 0x0401AA6D RID: 109165
		private bool Enable;
	}
}
