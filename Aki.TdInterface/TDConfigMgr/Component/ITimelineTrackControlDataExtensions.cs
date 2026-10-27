using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000778 RID: 1912
	public static class ITimelineTrackControlDataExtensions
	{
		// Token: 0x06002977 RID: 10615 RVA: 0x0006D648 File Offset: 0x0006B848
		[NullableContext(1)]
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
