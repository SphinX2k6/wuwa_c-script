using System;

namespace CSharpScript.Game.Input.InputActionLogic
{
	// Token: 0x0200615A RID: 24922
	public class DodgeInputActionLogic : InputActionLogicBase
	{
		// Token: 0x0603BBCE RID: 244686 RVA: 0x010F492F File Offset: 0x010F2B2F
		public override bool IsAllowReleaseInput(EInputDataType inputDataType)
		{
			return inputDataType != EInputDataType.NormalWorldMotor;
		}
	}
}
