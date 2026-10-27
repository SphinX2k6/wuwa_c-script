using System;

namespace CSharpScript.Game.Input.InputActionLogic
{
	// Token: 0x02006FD9 RID: 28633
	public class DodgeInputActionLogic : InputActionLogicBase
	{
		// Token: 0x06045A1D RID: 285213 RVA: 0x0114AB3B File Offset: 0x01148D3B
		public override bool IsAllowReleaseInput(EInputDataType inputDataType)
		{
			return inputDataType != EInputDataType.NormalWorldMotor;
		}
	}
}
