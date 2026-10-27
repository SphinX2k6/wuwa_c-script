using System;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.RoleMorph.Handle
{
	// Token: 0x02004D6E RID: 19822
	public class RoleMorphPaoTaiHandle : RoleMorphHandleBase
	{
		// Token: 0x060333CA RID: 209866 RVA: 0x00BF31C4 File Offset: 0x00BF13C4
		public override void BeginMorph()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.ControlCameraByMoveAxis = true;
			}
		}

		// Token: 0x060333CB RID: 209867 RVA: 0x00BF31E8 File Offset: 0x00BF13E8
		public override void EndMorph()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.ControlCameraByMoveAxis = false;
			}
		}
	}
}
