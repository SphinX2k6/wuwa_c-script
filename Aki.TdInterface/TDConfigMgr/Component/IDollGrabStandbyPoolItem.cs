using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000312 RID: 786
	public class IDollGrabStandbyPoolItem
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x00035234 File Offset: 0x00033434
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

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0003526C File Offset: 0x0003346C
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

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0003527F File Offset: 0x0003347F
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

		// Token: 0x06000EAA RID: 3754 RVA: 0x00035292 File Offset: 0x00033492
		public IDollGrabStandbyPoolItem_SetValue ToSetValue()
		{
			return new IDollGrabStandbyPoolItem_SetValue
			{
				UniqueId = this.UniqueId,
				ItemId = this.ItemId
			};
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000352B1 File Offset: 0x000334B1
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x000352DC File Offset: 0x000334DC
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

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000352EA File Offset: 0x000334EA
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00035315 File Offset: 0x00033515
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

		// Token: 0x04000D1D RID: 3357
		[Nullable(2)]
		protected IDollGrabStandbyPoolItem FbInstance;

		// Token: 0x04000D1E RID: 3358
		[Nullable(2)]
		protected IDollGrabStandbyPoolItem_SetValue PocoInterface;
	}
}
