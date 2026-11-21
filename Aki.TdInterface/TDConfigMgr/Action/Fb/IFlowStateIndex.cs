using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E2 RID: 10466
	public class IFlowStateIndex : IFlowIndex
	{
		// Token: 0x0600E8F2 RID: 59634 RVA: 0x00226AD3 File Offset: 0x00224CD3
		public static IFlowStateIndex Create(IFlowStateIndex? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowStateIndex
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x0600E8F3 RID: 59635 RVA: 0x00226AF2 File Offset: 0x00224CF2
		public override string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x00226AFF File Offset: 0x00224CFF
		public override int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x0600E8F5 RID: 59637 RVA: 0x00226B0C File Offset: 0x00224D0C
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x0400805E RID: 32862
		private IFlowStateIndex Instance;
	}
}
