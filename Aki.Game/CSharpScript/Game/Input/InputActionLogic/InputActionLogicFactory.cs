using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Input.InputActionLogic
{
	// Token: 0x02006FDB RID: 28635
	public class InputActionLogicFactory
	{
		// Token: 0x06045A21 RID: 285217 RVA: 0x0114AB54 File Offset: 0x01148D54
		public static void Initialize()
		{
			InputActionLogicFactory.InputActionLogicMap.Clear();
			InputActionLogicFactory.InputActionLogicMap[EInputAction.跳跃] = new JumpInputActionLogic();
			InputActionLogicFactory.InputActionLogicMap[EInputAction.闪避] = new DodgeInputActionLogic();
		}

		// Token: 0x06045A22 RID: 285218 RVA: 0x0114AB88 File Offset: 0x01148D88
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

		// Token: 0x0402457F RID: 148863
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EInputAction, InputActionLogicBase> InputActionLogicMap = new Dictionary<EInputAction, InputActionLogicBase>();
	}
}
