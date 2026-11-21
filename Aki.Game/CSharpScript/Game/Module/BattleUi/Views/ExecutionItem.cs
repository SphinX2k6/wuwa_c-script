using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D01 RID: 19713
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecutionItem : BattleSkillItem
	{
		// Token: 0x0603164F RID: 202319 RVA: 0x00DCE7B3 File Offset: 0x00DCC9B3
		public void Init(Action callback)
		{
			this.Callback = callback;
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x06031650 RID: 202320 RVA: 0x00DCE7CC File Offset: 0x00DCC9CC
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

		// Token: 0x06031651 RID: 202321 RVA: 0x00DCE858 File Offset: 0x00DCCA58
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x06031652 RID: 202322 RVA: 0x00DCE878 File Offset: 0x00DCCA78
		protected override void OnSkillButtonPressed()
		{
			Action callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback();
		}

		// Token: 0x06031653 RID: 202323 RVA: 0x00DCE88A File Offset: 0x00DCCA8A
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0401A2A4 RID: 107172
		[Nullable(2)]
		private Action Callback;
	}
}
