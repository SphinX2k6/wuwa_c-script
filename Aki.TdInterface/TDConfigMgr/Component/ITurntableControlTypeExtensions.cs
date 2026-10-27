using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AE RID: 1966
	public static class ITurntableControlTypeExtensions
	{
		// Token: 0x06002AA2 RID: 10914 RVA: 0x0006FB54 File Offset: 0x0006DD54
		[NullableContext(1)]
		public static IReadOnlyList<object> GetItemConfig(this ITurntableControlType p)
		{
			IFreeAngleTurntable freeAngleTurntable = p as IFreeAngleTurntable;
			IReadOnlyList<object> itemConfig;
			if (freeAngleTurntable == null)
			{
				IFixedAngleTurntable fixedAngleTurntable = p as IFixedAngleTurntable;
				if (fixedAngleTurntable == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的ItemConfig的字段失败");
				}
				itemConfig = fixedAngleTurntable.ItemConfig;
			}
			else
			{
				itemConfig = freeAngleTurntable.ItemConfig;
			}
			return itemConfig;
		}
	}
}
