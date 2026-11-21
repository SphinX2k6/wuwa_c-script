using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Input.InputActionLogic
{
	// Token: 0x0200615C RID: 24924
	public class InputActionLogicFactory
	{
		// Token: 0x0603BBD2 RID: 244690 RVA: 0x010F4948 File Offset: 0x010F2B48
		public static void Initialize()
		{
			InputActionLogicFactory.InputActionLogicMap.Clear();
			InputActionLogicFactory.InputActionLogicMap[EInputAction.跳跃] = new JumpInputActionLogic();
			InputActionLogicFactory.InputActionLogicMap[EInputAction.闪避] = new DodgeInputActionLogic();
		}

		// Token: 0x0603BBD3 RID: 244691 RVA: 0x010F497C File Offset: 0x010F2B7C
		[NullableContext(2)]
		public static InputActionLogicBase GetInputActionLogic(EInputAction action)
		{
			InputActionLogicBase result;
			if (InputActionLogicFactory.InputActionLogicMap.TryGetValue(action, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0401F834 RID: 129076
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EInputAction, InputActionLogicBase> InputActionLogicMap = new Dictionary<EInputAction, InputActionLogicBase>();
	}
}
