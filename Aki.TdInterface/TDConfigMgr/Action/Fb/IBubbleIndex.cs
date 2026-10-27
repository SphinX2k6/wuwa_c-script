using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002624 RID: 9764
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleIndex : IFlowIndex
	{
		// Token: 0x0600DB2F RID: 56111 RVA: 0x0020A3B0 File Offset: 0x002085B0
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

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x0600DB30 RID: 56112 RVA: 0x0020A3CF File Offset: 0x002085CF
		public override string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0600DB31 RID: 56113 RVA: 0x0020A3DC File Offset: 0x002085DC
		public override int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x0600DB32 RID: 56114 RVA: 0x0020A3EC File Offset: 0x002085EC
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

		// Token: 0x040079C4 RID: 31172
		private IBubbleIndex Instance;
	}
}
