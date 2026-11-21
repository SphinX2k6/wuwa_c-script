using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002787 RID: 10119
	public class FixGetItem : ActionParams
	{
		// Token: 0x0600E016 RID: 57366 RVA: 0x0020FAE1 File Offset: 0x0020DCE1
		public static FixGetItem Create(IFixGetItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixGetItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600E017 RID: 57367 RVA: 0x0020FB00 File Offset: 0x0020DD00
		public virtual List<IItemData> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<IItemData>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(IItemData.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x040079E7 RID: 31207
		private IFixGetItem Instance;

		// Token: 0x040079E8 RID: 31208
		private List<IItemData> _ItemsCache;

		// Token: 0x040079E9 RID: 31209
		private bool _ItemsInited;
	}
}
