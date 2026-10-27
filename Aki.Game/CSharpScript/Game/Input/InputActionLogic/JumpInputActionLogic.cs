using System;

namespace CSharpScript.Game.Input.InputActionLogic
{
	// Token: 0x02006FDC RID: 28636
	public class JumpInputActionLogic : InputActionLogicBase
	{
		// Token: 0x06045A25 RID: 285221 RVA: 0x0114ABBB File Offset: 0x01148DBB
		public override bool IsAllowReleaseInput(EInputDataType inputDataType)
		{
			return inputDataType != EInputDataType.NormalWorldMotor;
		}
	}
}
