using System;

namespace CSharpScript.Game.Input.InputActionLogic
{
	// Token: 0x0200615D RID: 24925
	public class JumpInputActionLogic : InputActionLogicBase
	{
		// Token: 0x0603BBD6 RID: 244694 RVA: 0x010F49AF File Offset: 0x010F2BAF
		public override bool IsAllowReleaseInput(EInputDataType inputDataType)
		{
			return inputDataType != EInputDataType.NormalWorldMotor;
		}
	}
}
