using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001735 RID: 5941
	[NullableContext(1)]
	[Nullable(0)]
	public class GetItem : ActionParams
	{
		// Token: 0x06007DBF RID: 32191 RVA: 0x0012D770 File Offset: 0x0012B970
		private GetItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GetItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GetItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GetItem_SetValue());
			}
			return result;
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x0012D7A8 File Offset: 0x0012B9A8
		public static GetItem Create([Nullable(2)] GetItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GetItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x0012D7BB File Offset: 0x0012B9BB
		public static GetItem CreateFromSetValue([Nullable(2)] GetItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GetItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x0012D7CE File Offset: 0x0012B9CE
		public GetItem_SetValue ToSetValue()
		{
			return new GetItem_SetValue
			{
				Items = this.Items,
				UiType = this.UiType,
				UiConfig = this.UiConfig
			};
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x06007DC3 RID: 32195 RVA: 0x0012D7FC File Offset: 0x0012B9FC
		// (set) Token: 0x06007DC4 RID: 32196 RVA: 0x0012D88F File Offset: 0x0012BA8F
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
					GetItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x0012D8A4 File Offset: 0x0012BAA4
		// (set) Token: 0x06007DC6 RID: 32198 RVA: 0x0012D8DE File Offset: 0x0012BADE
		public virtual EItemGetUiType? UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				GetItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x06007DC7 RID: 32199 RVA: 0x0012D8EC File Offset: 0x0012BAEC
		// (set) Token: 0x06007DC8 RID: 32200 RVA: 0x0012D94D File Offset: 0x0012BB4D
		[Nullable(2)]
		public virtual IItemGetUiConfigSpecialQuest UiConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._UiConfigInited)
				{
					return this._UiConfigCache;
				}
				this._UiConfigInited = true;
				if (this.FbInstance != null)
				{
					this._UiConfigCache = IItemGetUiConfigSpecialQuest.Create(this.FbInstance.UiConfig);
				}
				else
				{
					GetItem_SetValue pocoInterface = this.PocoInterface;
					this._UiConfigCache = ((pocoInterface != null) ? pocoInterface.UiConfig : null);
				}
				return this._UiConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UiConfig = value;
				this._UiConfigInited = false;
			}
		}

		// Token: 0x04005031 RID: 20529
		[Nullable(2)]
		protected new GetItem FbInstance;

		// Token: 0x04005032 RID: 20530
		[Nullable(2)]
		protected GetItem_SetValue PocoInterface;

		// Token: 0x04005033 RID: 20531
		private List<IItemData> _ItemsCache;

		// Token: 0x04005034 RID: 20532
		private bool _ItemsInited;

		// Token: 0x04005035 RID: 20533
		private IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x04005036 RID: 20534
		private bool _UiConfigInited;
	}
}
