using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2C RID: 3372
	public class ITimePathConfig
	{
		// Token: 0x06004CCF RID: 19663 RVA: 0x000C01B2 File Offset: 0x000BE3B2
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

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x000C01D1 File Offset: 0x000BE3D1
		public virtual float TotalTime
		{
			get
			{
				return this.Instance.TotalTime;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x000C01DE File Offset: 0x000BE3DE
		public virtual string TimePathCurve
		{
			get
			{
				return this.Instance.TimePathCurve;
			}
		}

		// Token: 0x04002B8F RID: 11151
		private ITimePathConfig Instance;
	}
}
