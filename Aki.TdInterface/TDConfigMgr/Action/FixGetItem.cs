using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A7 RID: 6311
	public class FixGetItem : ActionParams
	{
		// Token: 0x0600846F RID: 33903 RVA: 0x0013C36C File Offset: 0x0013A56C
		private FixGetItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FixGetItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FixGetItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FixGetItem_SetValue());
			}
			return result;
		}

		// Token: 0x06008470 RID: 33904 RVA: 0x0013C3A4 File Offset: 0x0013A5A4
		public static FixGetItem Create([Nullable(2)] FixGetItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixGetItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x0013C3B7 File Offset: 0x0013A5B7
		public static FixGetItem CreateFromSetValue([Nullable(2)] FixGetItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FixGetItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x0013C3CA File Offset: 0x0013A5CA
		public FixGetItem_SetValue ToSetValue()
		{
			return new FixGetItem_SetValue
			{
				Items = this.Items
			};
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x06008473 RID: 33907 RVA: 0x0013C3E0 File Offset: 0x0013A5E0
		// (set) Token: 0x06008474 RID: 33908 RVA: 0x0013C473 File Offset: 0x0013A673
		public virtual List<IItemData> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				if (this.FbInstance != null)
				{
					List<IItemData> items = this.FbInstance.Items;
					if (items != null)
					{
						this._ItemsCache = new List<IItemData>(items.Count);
						for (int i = 0; i < items.Count; i++)
						{
							this._ItemsCache.Add(IItemData.Create(items[i]));
						}
					}
				}
				else
				{
					FixGetItem_SetValue pocoInterface = this.PocoInterface;
					this._ItemsCache = ((pocoInterface != null) ? pocoInterface.Items : null);
				}
				return this._ItemsCache;
			}
			set
			{
				this.GetOrCreatePoco().Items = value;
				this._ItemsInited = false;
			}
		}

		// Token: 0x0400544C RID: 21580
		[Nullable(2)]
		protected new FixGetItem FbInstance;

		// Token: 0x0400544D RID: 21581
		[Nullable(2)]
		protected FixGetItem_SetValue PocoInterface;

		// Token: 0x0400544E RID: 21582
		private List<IItemData> _ItemsCache;

		// Token: 0x0400544F RID: 21583
		private bool _ItemsInited;
	}
}
