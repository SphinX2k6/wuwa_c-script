using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002621 RID: 9761
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowIndex
	{
		// Token: 0x0600DB20 RID: 56096 RVA: 0x0020A2C6 File Offset: 0x002084C6
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

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x0600DB21 RID: 56097 RVA: 0x0020A2E5 File Offset: 0x002084E5
		public virtual string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x0600DB22 RID: 56098 RVA: 0x0020A2F2 File Offset: 0x002084F2
		public virtual int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x040079C1 RID: 31169
		private IFlowIndex Instance;
	}
}
