using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002667 RID: 9831
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemCellIndependentDeliverType : IDeliverType
	{
		// Token: 0x0600DC4B RID: 56395 RVA: 0x0020C4A6 File Offset: 0x0020A6A6
		public static IItemCellIndependentDeliverType Create(IItemCellIndependentDeliverType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemCellIndependentDeliverType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x0600DC4C RID: 56396 RVA: 0x0020C4C5 File Offset: 0x0020A6C5
		public override EDeliverType Type
		{
			get
			{
				return (EDeliverType)this.Instance.Type;
			}
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x0600DC4D RID: 56397 RVA: 0x0020C4D4 File Offset: 0x0020A6D4
		public virtual List<IDeliverItem> DeliverItem
		{
			get
			{
				if (this._DeliverItemInited)
				{
					return this._DeliverItemCache;
				}
				this._DeliverItemInited = true;
				int deliverItemLength = this.Instance.DeliverItemLength;
				this._DeliverItemCache = new List<IDeliverItem>(deliverItemLength);
				for (int i = 0; i < deliverItemLength; i++)
				{
					this._DeliverItemCache.Add(IDeliverItem.Create(this.Instance.DeliverItem(i)));
				}
				return this._DeliverItemCache;
			}
		}

		// Token: 0x04007A6B RID: 31339
		private IItemCellIndependentDeliverType Instance;

		// Token: 0x04007A6C RID: 31340
		private List<IDeliverItem> _DeliverItemCache;

		// Token: 0x04007A6D RID: 31341
		private bool _DeliverItemInited;
	}
}
