using System;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004822 RID: 18466
	public static class LongPressInteractRestrictCoreFix
	{
		// Token: 0x0200A483 RID: 42115
		public class CoreFixLongPressRestriction : ILongPressInteractRestriction
		{
			// Token: 0x06045E2B RID: 286251 RVA: 0x015017FE File Offset: 0x014FF9FE
			public void Enter(EInputAction? triggerAction)
			{
			}

			// Token: 0x06045E2C RID: 286252 RVA: 0x01501800 File Offset: 0x014FFA00
			public void Press(EInputAction? triggerAction)
			{
				if (this.IsPressing)
				{
					return;
				}
				this.IsPressing = true;
				this.SetCameraInputEnabled(false);
				LongPressInteractRestrictCoreFix.CoreFixLongPressRestriction.SetCombineButtonActionEnabled(false);
			}

			// Token: 0x06045E2D RID: 286253 RVA: 0x0150181F File Offset: 0x014FFA1F
			public void Release(EInputAction? triggerAction)
			{
				if (!this.IsPressing)
				{
					return;
				}
				this.IsPressing = false;
				this.SetCameraInputEnabled(true);
				LongPressInteractRestrictCoreFix.CoreFixLongPressRestriction.SetCombineButtonActionEnabled(true);
			}

			// Token: 0x06045E2E RID: 286254 RVA: 0x0150183E File Offset: 0x014FFA3E
			public void Exit(EInputAction? triggerAction)
			{
				this.Release(triggerAction);
			}

			// Token: 0x06045E2F RID: 286255 RVA: 0x01501847 File Offset: 0x014FFA47
			private void SetCameraInputEnabled(bool enabled)
			{
				FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
				FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
				if (fightCameraLogicComponent == null)
				{
					return;
				}
				fightCameraLogicComponent.SetInputEnable(this, enabled);
			}

			// Token: 0x06045E30 RID: 286256 RVA: 0x01501870 File Offset: 0x014FFA70
			private static void SetCombineButtonActionEnabled(bool enabled)
			{
				if (!enabled)
				{
					InputDistributeModel instance = InputDistributeModel.Instance;
					if (instance != null && instance.IsActionInPress("组合主键"))
					{
						InputDistributeController.Instance.InputAction("组合主键", false);
					}
				}
				TsCharacterController characterController = Global.CharacterController;
				if (characterController == null)
				{
					return;
				}
				characterController.SetActionEnable("组合主键", enabled);
			}

			// Token: 0x04032FB9 RID: 208825
			private bool IsPressing;
		}
	}
}
