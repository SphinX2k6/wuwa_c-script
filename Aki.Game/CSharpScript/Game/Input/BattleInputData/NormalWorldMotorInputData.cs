using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006FDF RID: 28639
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalWorldMotorInputData : BattleInputData
	{
		// Token: 0x06045A38 RID: 285240 RVA: 0x0114B088 File Offset: 0x01149288
		public NormalWorldMotorInputData()
		{
			Dictionary<string, EInputAction> dictionary = new Dictionary<string, EInputAction>();
			dictionary["载具漂移"] = EInputAction.跳跃;
			dictionary["载具氮气"] = EInputAction.闪避;
			dictionary["载具子弹跳"] = EInputAction.技能1;
			dictionary["载具子弹跳1"] = EInputAction.攻击;
			dictionary["载具退场技和下车"] = EInputAction.大招;
			dictionary["通用交互"] = EInputAction.通用交互;
			dictionary["载具探索工具"] = EInputAction.幻象1;
			dictionary["载具锁定目标"] = EInputAction.锁定目标;
			dictionary["载具视角切换"] = EInputAction.瞄准;
			dictionary["载具空中抬升"] = EInputAction.走跑切换;
			dictionary["载具辅助机攻击"] = EInputAction.攻击;
			this.ActionMap = dictionary;
			Dictionary<string, EInputAxis> dictionary2 = new Dictionary<string, EInputAxis>();
			dictionary2["LookUp"] = EInputAxis.LookUp;
			dictionary2["Turn"] = EInputAxis.Turn;
			dictionary2["MotorMoveForward"] = EInputAxis.MoveForward;
			dictionary2["MotorMoveRight"] = EInputAxis.MoveRight;
			dictionary2["MotorSoarMoveForward"] = EInputAxis.MoveForward;
			dictionary2["Zoom"] = EInputAxis.Zoom;
			dictionary2["WheelAxis"] = EInputAxis.WheelAxis;
			this.AxisMap = dictionary2;
			base..ctor(EInputDataType.NormalWorldMotor, EInputBindingType.Motor);
		}

		// Token: 0x06045A39 RID: 285241 RVA: 0x0114B1D3 File Offset: 0x011493D3
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x06045A3A RID: 285242 RVA: 0x0114B1DB File Offset: 0x011493DB
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x06045A3B RID: 285243 RVA: 0x0114B1E3 File Offset: 0x011493E3
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (actionName == "载具辅助机攻击")
			{
				SkillButtonUiMotorcycleGamepadData skillButtonUiMotorcycleGamepadData = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Motorcycle) as SkillButtonUiMotorcycleGamepadData;
				return skillButtonUiMotorcycleGamepadData != null && skillButtonUiMotorcycleGamepadData.ShootEnable;
			}
			return base.OnCheckActionInAllowFightActionNameList(actionName, inputActionHandle);
		}

		// Token: 0x06045A3C RID: 285244 RVA: 0x0114B218 File Offset: 0x01149418
		protected override bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			if (Info.Instance.IsInGamepad())
			{
				if (axisName == "MotorMoveForward")
				{
					return !BattleUiModel.Instance.MotorcycleData.IsMotorSoaring;
				}
				if (axisName == "MotorSoarMoveForward")
				{
					return BattleUiModel.Instance.MotorcycleData.IsMotorSoaring;
				}
			}
			else if (axisName == "MotorSoarMoveForward")
			{
				return false;
			}
			return base.OnCheckAxisInAllowFightAxisNameList(axisName, inputAxisHandle);
		}

		// Token: 0x04024584 RID: 148868
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x04024585 RID: 148869
		private readonly Dictionary<string, EInputAxis> AxisMap;
	}
}
