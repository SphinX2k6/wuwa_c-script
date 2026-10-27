using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C53 RID: 3155
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimePathConfig
	{
		// Token: 0x0600484A RID: 18506 RVA: 0x000B5BBE File Offset: 0x000B3DBE
		public static ITimePathConfig Create(ITimePathConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimePathConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x000B5BDD File Offset: 0x000B3DDD
		public virtual float TotalTime
		{
			get
			{
				return this.Instance.TotalTime;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x000B5BEA File Offset: 0x000B3DEA
		public virtual string TimePathCurve
		{
			get
			{
				return this.Instance.TimePathCurve;
			}
		}

		// Token: 0x0400292E RID: 10542
		private ITimePathConfig Instance;
	}
}
