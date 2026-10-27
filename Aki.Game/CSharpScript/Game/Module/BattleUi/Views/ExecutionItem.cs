using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D1F RID: 23839
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecutionItem : BattleSkillItem
	{
		// Token: 0x0603C6F6 RID: 247542 RVA: 0x00E7E01B File Offset: 0x00E7C21B
		public void Init(Action callback)
		{
			this.Callback = callback;
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x0603C6F7 RID: 247543 RVA: 0x00E7E034 File Offset: 0x00E7C234
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

		// Token: 0x0603C6F8 RID: 247544 RVA: 0x00E7E0C0 File Offset: 0x00E7C2C0
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x0603C6F9 RID: 247545 RVA: 0x00E7E0E0 File Offset: 0x00E7C2E0
		protected override void OnSkillButtonPressed()
		{
			Action callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback();
		}

		// Token: 0x0603C6FA RID: 247546 RVA: 0x00E7E0F2 File Offset: 0x00E7C2F2
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0401F7EB RID: 129003
		[Nullable(2)]
		private Action Callback;
	}
}
