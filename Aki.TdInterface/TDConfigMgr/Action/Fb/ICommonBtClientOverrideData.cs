using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D70 RID: 11632
	public class ICommonBtClientOverrideData
	{
		// Token: 0x0600FDCB RID: 64971 RVA: 0x0024A348 File Offset: 0x00248548
		public static ICommonBtClientOverrideData Create(ICommonBtClientOverrideData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtClientOverrideData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x0600FDCC RID: 64972 RVA: 0x0024A367 File Offset: 0x00248567
		public virtual int TaskId
		{
			get
			{
				return this.Instance.TaskId;
			}
		}

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x0600FDCD RID: 64973 RVA: 0x0024A374 File Offset: 0x00248574
		public virtual string Data
		{
			get
			{
				return this.Instance.Data;
			}
		}

		// Token: 0x04008A92 RID: 35474
		private ICommonBtClientOverrideData Instance;
	}
}
