using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF0 RID: 7408
	public class IInstrumentQteConfig_QteSequenceRow
	{
		// Token: 0x06009D3C RID: 40252 RVA: 0x0016A14A File Offset: 0x0016834A
		public static IInstrumentQteConfig_QteSequenceRow Create([Nullable(2)] IInstrumentQteConfig_QteSequenceRow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteConfig_QteSequenceRow
			{
				FbInstance = instance
			};
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x0016A15D File Offset: 0x0016835D
		public virtual List<int> Items
		{
			get
			{
				return this.FbInstance.Items;
			}
		}

		// Token: 0x04006002 RID: 24578
		private IInstrumentQteConfig_QteSequenceRow FbInstance;
	}
}
