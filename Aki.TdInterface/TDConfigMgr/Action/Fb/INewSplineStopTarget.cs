using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002731 RID: 10033
	public class INewSplineStopTarget
	{
		// Token: 0x0600DFAE RID: 57262 RVA: 0x0021232F File Offset: 0x0021052F
		[NullableContext(1)]
		public static INewSplineStopTarget Create(INewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x0600DFAF RID: 57263 RVA: 0x0021234E File Offset: 0x0021054E
		public virtual ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007C1D RID: 31773
		private INewSplineStopTarget Instance;
	}
}
