using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002259 RID: 8793
	public static class IUiGameExtensions
	{
		// Token: 0x0600BFA4 RID: 49060 RVA: 0x001BA1F4 File Offset: 0x001B83F4
		public static IReadOnlyList<IColorPiece> GetConfig(this IUiGame p)
		{
			ISignalDevice signalDevice = p as ISignalDevice;
			List<IColorPiece> config;
			if (signalDevice == null)
			{
				ISignalDevice2 signalDevice2 = p as ISignalDevice2;
				if (signalDevice2 == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Config的字段失败");
				}
				config = signalDevice2.Config;
			}
			else
			{
				config = signalDevice.Config;
			}
			return config;
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x001BA24C File Offset: 0x001B844C
		public static IReadOnlyList<object> GetMaxStepRewardRule(this IUiGame p)
		{
			ILifePoint lifePoint = p as ILifePoint;
			IReadOnlyList<object> maxStepRewardRule;
			if (lifePoint == null)
			{
				ITraceTracing traceTracing = p as ITraceTracing;
				if (traceTracing == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的MaxStepRewardRule的字段失败");
				}
				maxStepRewardRule = traceTracing.MaxStepRewardRule;
			}
			else
			{
				maxStepRewardRule = lifePoint.MaxStepRewardRule;
			}
			return maxStepRewardRule;
		}
	}
}
