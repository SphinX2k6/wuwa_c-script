using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002795 RID: 10133
	public class IFlowSelectedNode
	{
		// Token: 0x0600E078 RID: 57464 RVA: 0x00210882 File Offset: 0x0020EA82
		public static IFlowSelectedNode Create(IFlowSelectedNode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowSelectedNode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600E079 RID: 57465 RVA: 0x002108A1 File Offset: 0x0020EAA1
		public virtual int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600E07A RID: 57466 RVA: 0x002108B0 File Offset: 0x0020EAB0
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

		// Token: 0x04007A13 RID: 31251
		private IFlowSelectedNode Instance;
	}
}
