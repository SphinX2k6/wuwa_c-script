using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C08 RID: 3080
	public class ITriggerCountConfig
	{
		// Token: 0x060046AA RID: 18090 RVA: 0x000B3D54 File Offset: 0x000B1F54
		public static ITriggerCountConfig Create(ITriggerCountConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerCountConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x000B3D73 File Offset: 0x000B1F73
		public virtual int TriggerCount
		{
			get
			{
				return this.Instance.TriggerCount;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x000B3D80 File Offset: 0x000B1F80
		public virtual float TriggerInterval
		{
			get
			{
				return this.Instance.TriggerInterval;
			}
		}

		// Token: 0x040027AB RID: 10155
		private ITriggerCountConfig Instance;
	}
}
