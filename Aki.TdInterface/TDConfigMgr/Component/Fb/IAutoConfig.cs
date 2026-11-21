using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA5 RID: 3237
	public class IAutoConfig
	{
		// Token: 0x06004A06 RID: 18950 RVA: 0x000BA700 File Offset: 0x000B8900
		public static IAutoConfig Create(IAutoConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutoConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x000BA71F File Offset: 0x000B891F
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06004A08 RID: 18952 RVA: 0x000BA72C File Offset: 0x000B892C
		public virtual int Interval
		{
			get
			{
				return this.Instance.Interval;
			}
		}

		// Token: 0x040029FA RID: 10746
		private IAutoConfig Instance;
	}
}
