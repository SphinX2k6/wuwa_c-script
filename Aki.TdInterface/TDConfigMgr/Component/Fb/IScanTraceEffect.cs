using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B69 RID: 2921
	public class IScanTraceEffect
	{
		// Token: 0x060042CB RID: 17099 RVA: 0x000A9ADA File Offset: 0x000A7CDA
		public static IScanTraceEffect Create(IScanTraceEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScanTraceEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x000A9AF9 File Offset: 0x000A7CF9
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x000A9B06 File Offset: 0x000A7D06
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x040024EA RID: 9450
		private IScanTraceEffect Instance;
	}
}
