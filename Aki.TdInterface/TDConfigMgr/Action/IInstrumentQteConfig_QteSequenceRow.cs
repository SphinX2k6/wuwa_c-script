using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B41 RID: 6977
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentQteConfig_QteSequenceRow
	{
		// Token: 0x06009552 RID: 38226 RVA: 0x0015946E File Offset: 0x0015766E
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

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x06009553 RID: 38227 RVA: 0x00159481 File Offset: 0x00157681
		public virtual List<int> Items
		{
			get
			{
				return this.FbInstance.Items;
			}
		}

		// Token: 0x04005B64 RID: 23396
		private IInstrumentQteConfig_QteSequenceRow FbInstance;
	}
}
