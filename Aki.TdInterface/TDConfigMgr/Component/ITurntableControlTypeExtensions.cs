using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000851 RID: 2129
	public static class ITurntableControlTypeExtensions
	{
		// Token: 0x06002DD2 RID: 11730 RVA: 0x00076EB8 File Offset: 0x000750B8
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
