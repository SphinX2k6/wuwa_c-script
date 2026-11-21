using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E31 RID: 11825
	public class IInstrumentQteConfig_QteSequenceRow
	{
		// Token: 0x060100B6 RID: 65718 RVA: 0x0024EB25 File Offset: 0x0024CD25
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

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x060100B7 RID: 65719 RVA: 0x0024EB44 File Offset: 0x0024CD44
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

		// Token: 0x04008C0B RID: 35851
		private IInstrumentQteConfig_QteSequenceRow Instance;

		// Token: 0x04008C0C RID: 35852
		private List<int> _ItemsCache;

		// Token: 0x04008C0D RID: 35853
		private bool _ItemsInited;
	}
}
