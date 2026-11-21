using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D8B RID: 19851
	[NullableContext(1)]
	[Nullable(0)]
	public class PetalMechanicSkillItem : BattleSkillItem
	{
		// Token: 0x06031D8A RID: 204170 RVA: 0x00DF0DBA File Offset: 0x00DEEFBA
		public void SetActionType(CSharpScript.Game.Input.EInputAction inputAction)
		{
			this.InputAction = inputAction;
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x06031D8B RID: 204171 RVA: 0x00DF0DD4 File Offset: 0x00DEEFD4
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

		// Token: 0x06031D8C RID: 204172 RVA: 0x00DF0E60 File Offset: 0x00DEF060
		public void RefreshSkillIconByResId(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetSkillIcon(resourcePath);
		}

		// Token: 0x06031D8D RID: 204173 RVA: 0x00DF0E80 File Offset: 0x00DEF080
		protected override void OnSkillButtonPressed()
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Play();
			}
			InputController.Instance.InputAction(this.InputAction, EInputState.Press);
			this.LongPressTimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnLongPress), 300f, null, null, true, 1f);
		}

		// Token: 0x06031D8E RID: 204174 RVA: 0x00DF0ED9 File Offset: 0x00DEF0D9
		protected override void OnSkillButtonReleased()
		{
			InputController.Instance.InputAction(this.InputAction, EInputState.Release);
		}

		// Token: 0x06031D8F RID: 204175 RVA: 0x00DF0EEC File Offset: 0x00DEF0EC
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0401A628 RID: 108072
		private CSharpScript.Game.Input.EInputAction InputAction = CSharpScript.Game.Input.EInputAction.None;
	}
}
