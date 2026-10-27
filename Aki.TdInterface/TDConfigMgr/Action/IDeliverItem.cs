using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001982 RID: 6530
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeliverItem
	{
		// Token: 0x06008BD3 RID: 35795 RVA: 0x00148768 File Offset: 0x00146968
		private IDeliverItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeliverItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeliverItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeliverItem_SetValue());
			}
			return result;
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x001487A0 File Offset: 0x001469A0
		public static IDeliverItem Create([Nullable(2)] IDeliverItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x001487B3 File Offset: 0x001469B3
		public static IDeliverItem CreateFromSetValue([Nullable(2)] IDeliverItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeliverItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x001487C6 File Offset: 0x001469C6
		public IDeliverItem_SetValue ToSetValue()
		{
			return new IDeliverItem_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count
			};
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x06008BD7 RID: 35799 RVA: 0x001487E5 File Offset: 0x001469E5
		// (set) Token: 0x06008BD8 RID: 35800 RVA: 0x00148810 File Offset: 0x00146A10
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x06008BD9 RID: 35801 RVA: 0x0014881E File Offset: 0x00146A1E
		// (set) Token: 0x06008BDA RID: 35802 RVA: 0x00148849 File Offset: 0x00146A49
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x04005724 RID: 22308
		[Nullable(2)]
		protected IDeliverItem FbInstance;

		// Token: 0x04005725 RID: 22309
		[Nullable(2)]
		protected IDeliverItem_SetValue PocoInterface;
	}
}
