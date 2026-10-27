using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E2 RID: 9442
	[NullableContext(1)]
	[Nullable(0)]
	public class FixGetItem : ActionParams
	{
		// Token: 0x0600D2C1 RID: 53953 RVA: 0x001F4285 File Offset: 0x001F2485
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

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600D2C2 RID: 53954 RVA: 0x001F42A4 File Offset: 0x001F24A4
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

		// Token: 0x0400739A RID: 29594
		private IFixGetItem Instance;

		// Token: 0x0400739B RID: 29595
		private List<IItemData> _ItemsCache;

		// Token: 0x0400739C RID: 29596
		private bool _ItemsInited;
	}
}
