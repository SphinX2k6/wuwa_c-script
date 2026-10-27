using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002623 RID: 9763
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayFlow : ActionParams
	{
		// Token: 0x0600DB29 RID: 56105 RVA: 0x0020A355 File Offset: 0x00208555
		public static PlayFlow Create(IPlayFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x0020A374 File Offset: 0x00208574
		public virtual string FlowListName
		{
			get
			{
				return this.Instance.FlowListName;
			}
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x0600DB2B RID: 56107 RVA: 0x0020A381 File Offset: 0x00208581
		public virtual int FlowId
		{
			get
			{
				return this.Instance.FlowId;
			}
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x0600DB2C RID: 56108 RVA: 0x0020A38E File Offset: 0x0020858E
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x0600DB2D RID: 56109 RVA: 0x0020A39B File Offset: 0x0020859B
		[Nullable(2)]
		public virtual string FlowGuid
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FlowGuid;
			}
		}

		// Token: 0x040079C3 RID: 31171
		private IPlayFlow Instance;
	}
}
