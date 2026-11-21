using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E4 RID: 10468
	public class IBubbleIndex : IFlowIndex
	{
		// Token: 0x0600E8FD RID: 59645 RVA: 0x00226B7C File Offset: 0x00224D7C
		public static IBubbleIndex Create(IBubbleIndex? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleIndex
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x0600E8FE RID: 59646 RVA: 0x00226B9B File Offset: 0x00224D9B
		public override string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x0600E8FF RID: 59647 RVA: 0x00226BA8 File Offset: 0x00224DA8
		public override int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x0600E900 RID: 59648 RVA: 0x00226BB8 File Offset: 0x00224DB8
		public virtual int? StateId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.StateId);
			}
		}

		// Token: 0x04008060 RID: 32864
		private IBubbleIndex Instance;
	}
}
