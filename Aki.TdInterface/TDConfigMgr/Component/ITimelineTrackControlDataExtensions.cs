using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000819 RID: 2073
	public static class ITimelineTrackControlDataExtensions
	{
		// Token: 0x06002C9B RID: 11419 RVA: 0x000747F0 File Offset: 0x000729F0
		public static IReadOnlyList<object> GetControlPoints(this ITimelineTrackControlData p)
		{
			ISequenceTrackControl sequenceTrackControl = p as ISequenceTrackControl;
			IReadOnlyList<object> controlPoints;
			if (sequenceTrackControl == null)
			{
				IEntityTrackControl entityTrackControl = p as IEntityTrackControl;
				if (entityTrackControl == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的ControlPoints的字段失败");
				}
				controlPoints = entityTrackControl.ControlPoints;
			}
			else
			{
				controlPoints = sequenceTrackControl.ControlPoints;
			}
			return controlPoints;
		}
	}
}
