using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E2D RID: 24109
	[NullableContext(1)]
	[Nullable(0)]
	public class XiaKongQteSkillItem : BattleSkillItem
	{
		// Token: 0x0603D506 RID: 251142 RVA: 0x00EC776C File Offset: 0x00EC596C
		public void SetPressCallback(Action<int> onPressCallback)
		{
			this.OnPressCallback = onPressCallback;
		}

		// Token: 0x0603D507 RID: 251143 RVA: 0x00EC7775 File Offset: 0x00EC5975
		public void RefreshType(int inputType)
		{
			this.InputType = inputType;
			this.RefreshOnInputControllerMainTypeChange();
		}

		// Token: 0x0603D508 RID: 251144 RVA: 0x00EC7784 File Offset: 0x00EC5984
		public void RefreshOnInputControllerMainTypeChange()
		{
			string actionNameByInputType = this.GetActionNameByInputType(this.InputType);
			if (!string.IsNullOrEmpty(actionNameByInputType))
			{
				this.RefreshKeyByActionName(actionNameByInputType);
			}
		}

		// Token: 0x0603D509 RID: 251145 RVA: 0x00EC77AD File Offset: 0x00EC59AD
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

		// Token: 0x0603D50A RID: 251146 RVA: 0x00EC77DC File Offset: 0x00EC59DC
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

		// Token: 0x0603D50B RID: 251147 RVA: 0x00EC783C File Offset: 0x00EC5A3C
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x0603D50C RID: 251148 RVA: 0x00EC785C File Offset: 0x00EC5A5C
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

		// Token: 0x0603D50D RID: 251149 RVA: 0x00EC7885 File Offset: 0x00EC5A85
		public void SetEnable(bool enable)
		{
			this.Enable = enable;
			this.RefreshEnable(false);
			this.RefreshDynamicEffect();
		}

		// Token: 0x0603D50E RID: 251150 RVA: 0x00EC789B File Offset: 0x00EC5A9B
		public override void RefreshEnable(bool bForce = false)
		{
			base.SetSkillItemEnable(this.Enable, bForce);
		}

		// Token: 0x0603D50F RID: 251151 RVA: 0x00EC78AA File Offset: 0x00EC5AAA
		public override void RefreshDynamicEffect()
		{
			base.SetDynamicEffectVisible(this.Enable);
		}

		// Token: 0x0603D510 RID: 251152 RVA: 0x00EC78B8 File Offset: 0x00EC5AB8
		public void SetSkillIconName(string skillIconName)
		{
			LguiUtil.Instance.SetLocalTextNew(this.SkillNameText, skillIconName, Array.Empty<object>());
			this.SkillNameText.SetUIActive(true);
		}

		// Token: 0x0401FFA4 RID: 130980
		private int InputType;

		// Token: 0x0401FFA5 RID: 130981
		[Nullable(2)]
		private Action<int> OnPressCallback;

		// Token: 0x0401FFA6 RID: 130982
		private bool Enable;
	}
}
