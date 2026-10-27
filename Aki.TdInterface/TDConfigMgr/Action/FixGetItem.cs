using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200172A RID: 5930
	[NullableContext(1)]
	[Nullable(0)]
	public class FixGetItem : ActionParams
	{
		// Token: 0x06007D91 RID: 32145 RVA: 0x0012D2C0 File Offset: 0x0012B4C0
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

		// Token: 0x06007D92 RID: 32146 RVA: 0x0012D2F8 File Offset: 0x0012B4F8
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

		// Token: 0x06007D93 RID: 32147 RVA: 0x0012D30B File Offset: 0x0012B50B
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

		// Token: 0x06007D94 RID: 32148 RVA: 0x0012D31E File Offset: 0x0012B51E
		public FixGetItem_SetValue ToSetValue()
		{
			return new FixGetItem_SetValue
			{
				Items = this.Items
			};
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0012D334 File Offset: 0x0012B534
		// (set) Token: 0x06007D96 RID: 32150 RVA: 0x0012D3C7 File Offset: 0x0012B5C7
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

		// Token: 0x0400501D RID: 20509
		[Nullable(2)]
		protected new FixGetItem FbInstance;

		// Token: 0x0400501E RID: 20510
		[Nullable(2)]
		protected FixGetItem_SetValue PocoInterface;

		// Token: 0x0400501F RID: 20511
		private List<IItemData> _ItemsCache;

		// Token: 0x04005020 RID: 20512
		private bool _ItemsInited;
	}
}
