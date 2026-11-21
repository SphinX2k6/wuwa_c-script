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
	// Token: 0x02006160 RID: 24928
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalWorldMotorInputData : BattleInputData
	{
		// Token: 0x0603BBE9 RID: 244713 RVA: 0x010F4E7C File Offset: 0x010F307C
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

		// Token: 0x0603BBEA RID: 244714 RVA: 0x010F4FC7 File Offset: 0x010F31C7
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x0603BBEB RID: 244715 RVA: 0x010F4FCF File Offset: 0x010F31CF
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x0603BBEC RID: 244716 RVA: 0x010F4FD7 File Offset: 0x010F31D7
		protected override bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			if (actionName == "载具辅助机攻击")
			{
				SkillButtonUiMotorcycleGamepadData skillButtonUiMotorcycleGamepadData = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Motorcycle) as SkillButtonUiMotorcycleGamepadData;
				return skillButtonUiMotorcycleGamepadData != null && skillButtonUiMotorcycleGamepadData.ShootEnable;
			}
			return base.OnCheckActionInAllowFightActionNameList(actionName, inputActionHandle);
		}

		// Token: 0x0603BBED RID: 244717 RVA: 0x010F500C File Offset: 0x010F320C
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

		// Token: 0x0401F839 RID: 129081
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x0401F83A RID: 129082
		private readonly Dictionary<string, EInputAxis> AxisMap;
	}
}
