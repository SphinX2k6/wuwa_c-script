using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E1 RID: 10465
	public class IFlowIndex
	{
		// Token: 0x0600E8EE RID: 59630 RVA: 0x00226A92 File Offset: 0x00224C92
		public static IFlowIndex Create(IFlowIndex? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowIndex
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x0600E8EF RID: 59631 RVA: 0x00226AB1 File Offset: 0x00224CB1
		public virtual string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x00226ABE File Offset: 0x00224CBE
		public virtual int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x0400805D RID: 32861
		private IFlowIndex Instance;
	}
}
