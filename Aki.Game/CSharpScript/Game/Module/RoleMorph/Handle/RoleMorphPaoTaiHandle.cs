using System;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.RoleMorph.Handle
{
	// Token: 0x02003D37 RID: 15671
	public class RoleMorphPaoTaiHandle : RoleMorphHandleBase
	{
		// Token: 0x06028238 RID: 164408 RVA: 0x00B3C3E8 File Offset: 0x00B3A5E8
		public override void BeginMorph()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.ControlCameraByMoveAxis = true;
			}
		}

		// Token: 0x06028239 RID: 164409 RVA: 0x00B3C40C File Offset: 0x00B3A60C
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
