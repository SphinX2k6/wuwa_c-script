using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B5A RID: 7002
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemCellIndependentDeliverType : IDeliverType
	{
		// Token: 0x060095E9 RID: 38377 RVA: 0x0015A738 File Offset: 0x00158938
		private IItemCellIndependentDeliverType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemCellIndependentDeliverType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemCellIndependentDeliverType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemCellIndependentDeliverType_SetValue());
			}
			return result;
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x0015A770 File Offset: 0x00158970
		public static IItemCellIndependentDeliverType Create([Nullable(2)] IItemCellIndependentDeliverType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemCellIndependentDeliverType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x0015A783 File Offset: 0x00158983
		public static IItemCellIndependentDeliverType CreateFromSetValue([Nullable(2)] IItemCellIndependentDeliverType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemCellIndependentDeliverType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x0015A796 File Offset: 0x00158996
		public new IItemCellIndependentDeliverType_SetValue ToSetValue()
		{
			return new IItemCellIndependentDeliverType_SetValue
			{
				Type = this.Type,
				DeliverItem = this.DeliverItem
			};
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x060095ED RID: 38381 RVA: 0x0015A7B5 File Offset: 0x001589B5
		// (set) Token: 0x060095EE RID: 38382 RVA: 0x0015A7E0 File Offset: 0x001589E0
		public override EDeliverType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDeliverType.ItemIdCellIndependent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x060095EF RID: 38383 RVA: 0x0015A7F0 File Offset: 0x001589F0
		// (set) Token: 0x060095F0 RID: 38384 RVA: 0x0015A883 File Offset: 0x00158A83
		public virtual List<IDeliverItem> DeliverItem
		{
			get
			{
				if (this._DeliverItemInited)
				{
					return this._DeliverItemCache;
				}
				this._DeliverItemInited = true;
				if (this.FbInstance != null)
				{
					List<IDeliverItem> deliverItem = this.FbInstance.DeliverItem;
					if (deliverItem != null)
					{
						this._DeliverItemCache = new List<IDeliverItem>(deliverItem.Count);
						for (int i = 0; i < deliverItem.Count; i++)
						{
							this._DeliverItemCache.Add(IDeliverItem.Create(deliverItem[i]));
						}
					}
				}
				else
				{
					IItemCellIndependentDeliverType_SetValue pocoInterface = this.PocoInterface;
					this._DeliverItemCache = ((pocoInterface != null) ? pocoInterface.DeliverItem : null);
				}
				return this._DeliverItemCache;
			}
			set
			{
				this.GetOrCreatePoco().DeliverItem = value;
				this._DeliverItemInited = false;
			}
		}

		// Token: 0x04005BB5 RID: 23477
		[Nullable(2)]
		protected new IItemCellIndependentDeliverType FbInstance;

		// Token: 0x04005BB6 RID: 23478
		[Nullable(2)]
		protected new IItemCellIndependentDeliverType_SetValue PocoInterface;

		// Token: 0x04005BB7 RID: 23479
		private List<IDeliverItem> _DeliverItemCache;

		// Token: 0x04005BB8 RID: 23480
		private bool _DeliverItemInited;
	}
}
