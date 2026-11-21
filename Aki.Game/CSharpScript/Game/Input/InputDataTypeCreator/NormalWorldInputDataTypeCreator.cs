using System;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Input.InputDataTypeCreator
{
	// Token: 0x02006155 RID: 24917
	public class NormalWorldInputDataTypeCreator : InputDataTypeCreator
	{
		// Token: 0x0603BBC4 RID: 244676 RVA: 0x010F48DE File Offset: 0x010F2ADE
		public override EInputDataType GetInputDataType()
		{
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			if (motorcycleData != null && motorcycleData.LastDriving)
			{
				return EInputDataType.NormalWorldMotor;
			}
			return EInputDataType.NormalWorld;
		}
	}
}
