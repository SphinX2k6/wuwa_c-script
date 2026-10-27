using System;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Input.InputDataTypeCreator
{
	// Token: 0x02006FD4 RID: 28628
	public class NormalWorldInputDataTypeCreator : InputDataTypeCreator
	{
		// Token: 0x06045A13 RID: 285203 RVA: 0x0114AAEA File Offset: 0x01148CEA
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
