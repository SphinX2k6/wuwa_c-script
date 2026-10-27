using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002010 RID: 8208
	[NullableContext(1)]
	[Nullable(0)]
	public static class IUiGameExtensions
	{
		// Token: 0x0600B482 RID: 46210 RVA: 0x001A3B30 File Offset: 0x001A1D30
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

		// Token: 0x0600B483 RID: 46211 RVA: 0x001A3B88 File Offset: 0x001A1D88
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
