using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B13 RID: 11027
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentQteConfig_QteSequenceRow
	{
		// Token: 0x0600F162 RID: 61794 RVA: 0x0023008D File Offset: 0x0022E28D
		public static IInstrumentQteConfig_QteSequenceRow Create(IInstrumentQteConfig_QteSequenceRow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteConfig_QteSequenceRow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x0600F163 RID: 61795 RVA: 0x002300AC File Offset: 0x0022E2AC
		public virtual List<int> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<int>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(this.Instance.Items(i));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x040084C3 RID: 33987
		private IInstrumentQteConfig_QteSequenceRow Instance;

		// Token: 0x040084C4 RID: 33988
		private List<int> _ItemsCache;

		// Token: 0x040084C5 RID: 33989
		private bool _ItemsInited;
	}
}
