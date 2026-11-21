using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D3 RID: 1235
	public static class IInteractEntityPartBindBaseExtensions
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x0004A2E8 File Offset: 0x000484E8
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
