using System;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200584A RID: 22602
	public static class LongPressInteractRestrictCoreFix
	{
		// Token: 0x0200BA6C RID: 47724
		public class CoreFixLongPressRestriction : ILongPressInteractRestriction
		{
			// Token: 0x0604F89D RID: 325789 RVA: 0x0154835A File Offset: 0x0154655A
			public void Enter(EInputAction? triggerAction)
			{
			}

			// Token: 0x0604F89E RID: 325790 RVA: 0x0154835C File Offset: 0x0154655C
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

			// Token: 0x0604F89F RID: 325791 RVA: 0x0154837B File Offset: 0x0154657B
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

			// Token: 0x0604F8A0 RID: 325792 RVA: 0x0154839A File Offset: 0x0154659A
			public void Exit(EInputAction? triggerAction)
			{
				this.Release(triggerAction);
			}

			// Token: 0x0604F8A1 RID: 325793 RVA: 0x015483A3 File Offset: 0x015465A3
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

			// Token: 0x0604F8A2 RID: 325794 RVA: 0x015483CC File Offset: 0x015465CC
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

			// Token: 0x040385C1 RID: 230849
			private bool IsPressing;
		}
	}
}
