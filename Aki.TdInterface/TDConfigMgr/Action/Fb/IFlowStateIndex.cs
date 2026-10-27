using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002622 RID: 9762
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowStateIndex : IFlowIndex
	{
		// Token: 0x0600DB24 RID: 56100 RVA: 0x0020A307 File Offset: 0x00208507
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

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x0600DB25 RID: 56101 RVA: 0x0020A326 File Offset: 0x00208526
		public override string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x0600DB26 RID: 56102 RVA: 0x0020A333 File Offset: 0x00208533
		public override int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x0600DB27 RID: 56103 RVA: 0x0020A340 File Offset: 0x00208540
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x040079C2 RID: 31170
		private IFlowStateIndex Instance;
	}
}
