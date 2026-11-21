using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B4 RID: 6324
	public class GetItem : ActionParams
	{
		// Token: 0x060084A7 RID: 33959 RVA: 0x0013C918 File Offset: 0x0013AB18
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

		// Token: 0x060084A8 RID: 33960 RVA: 0x0013C950 File Offset: 0x0013AB50
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

		// Token: 0x060084A9 RID: 33961 RVA: 0x0013C963 File Offset: 0x0013AB63
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

		// Token: 0x060084AA RID: 33962 RVA: 0x0013C976 File Offset: 0x0013AB76
		public GetItem_SetValue ToSetValue()
		{
			return new GetItem_SetValue
			{
				Items = this.Items,
				UiType = this.UiType,
				UiConfig = this.UiConfig
			};
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x0013C9A4 File Offset: 0x0013ABA4
		// (set) Token: 0x060084AC RID: 33964 RVA: 0x0013CA37 File Offset: 0x0013AC37
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

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x060084AD RID: 33965 RVA: 0x0013CA4C File Offset: 0x0013AC4C
		// (set) Token: 0x060084AE RID: 33966 RVA: 0x0013CA86 File Offset: 0x0013AC86
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

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x0013CA94 File Offset: 0x0013AC94
		// (set) Token: 0x060084B0 RID: 33968 RVA: 0x0013CAF5 File Offset: 0x0013ACF5
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

		// Token: 0x04005464 RID: 21604
		[Nullable(2)]
		protected new GetItem FbInstance;

		// Token: 0x04005465 RID: 21605
		[Nullable(2)]
		protected GetItem_SetValue PocoInterface;

		// Token: 0x04005466 RID: 21606
		private List<IItemData> _ItemsCache;

		// Token: 0x04005467 RID: 21607
		private bool _ItemsInited;

		// Token: 0x04005468 RID: 21608
		private IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x04005469 RID: 21609
		private bool _UiConfigInited;
	}
}
