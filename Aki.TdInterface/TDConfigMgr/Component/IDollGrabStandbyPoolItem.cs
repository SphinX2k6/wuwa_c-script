using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002CB RID: 715
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabStandbyPoolItem
	{
		// Token: 0x06000D77 RID: 3447 RVA: 0x00032300 File Offset: 0x00030500
		private IDollGrabStandbyPoolItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabStandbyPoolItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabStandbyPoolItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabStandbyPoolItem_SetValue());
			}
			return result;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00032338 File Offset: 0x00030538
		public static IDollGrabStandbyPoolItem Create([Nullable(2)] IDollGrabStandbyPoolItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabStandbyPoolItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0003234B File Offset: 0x0003054B
		public static IDollGrabStandbyPoolItem CreateFromSetValue([Nullable(2)] IDollGrabStandbyPoolItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabStandbyPoolItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0003235E File Offset: 0x0003055E
		public IDollGrabStandbyPoolItem_SetValue ToSetValue()
		{
			return new IDollGrabStandbyPoolItem_SetValue
			{
				UniqueId = this.UniqueId,
				ItemId = this.ItemId
			};
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x0003237D File Offset: 0x0003057D
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x000323A8 File Offset: 0x000305A8
		public virtual int UniqueId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UniqueId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.UniqueId;
			}
			set
			{
				this.GetOrCreatePoco().UniqueId = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000323B6 File Offset: 0x000305B6
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x000323E1 File Offset: 0x000305E1
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

		// Token: 0x04000C33 RID: 3123
		[Nullable(2)]
		protected IDollGrabStandbyPoolItem FbInstance;

		// Token: 0x04000C34 RID: 3124
		[Nullable(2)]
		protected IDollGrabStandbyPoolItem_SetValue PocoInterface;
	}
}
