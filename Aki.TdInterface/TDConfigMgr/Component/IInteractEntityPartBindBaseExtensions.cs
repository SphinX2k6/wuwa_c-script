using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047A RID: 1146
	public static class IInteractEntityPartBindBaseExtensions
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x000465A0 File Offset: 0x000447A0
		[NullableContext(1)]
		public static IReadOnlyList<object> GetOptionPoints(this IInteractEntityPartBindBase p)
		{
			IInteractEntityPartPrefabBind interactEntityPartPrefabBind = p as IInteractEntityPartPrefabBind;
			IReadOnlyList<object> optionPoints;
			if (interactEntityPartPrefabBind == null)
			{
				IInteractEntityPartModelBind interactEntityPartModelBind = p as IInteractEntityPartModelBind;
				if (interactEntityPartModelBind == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的OptionPoints的字段失败");
				}
				optionPoints = interactEntityPartModelBind.OptionPoints;
			}
			else
			{
				optionPoints = interactEntityPartPrefabBind.OptionPoints;
			}
			return optionPoints;
		}
	}
}
