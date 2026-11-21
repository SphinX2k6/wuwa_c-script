using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200030C RID: 780
	public class IDollGrabItem
	{
		// Token: 0x06000E89 RID: 3721 RVA: 0x00034EB4 File Offset: 0x000330B4
		private IDollGrabItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabItem_SetValue());
			}
			return result;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00034EEC File Offset: 0x000330EC
		public static IDollGrabItem Create([Nullable(2)] IDollGrabItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00034EFF File Offset: 0x000330FF
		public static IDollGrabItem CreateFromSetValue([Nullable(2)] IDollGrabItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00034F12 File Offset: 0x00033112
		public IDollGrabItem_SetValue ToSetValue()
		{
			return new IDollGrabItem_SetValue
			{
				Id = this.Id,
				ItemId = this.ItemId
			};
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00034F31 File Offset: 0x00033131
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00034F5C File Offset: 0x0003315C
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00034F6A File Offset: 0x0003316A
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x00034F95 File Offset: 0x00033195
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

		// Token: 0x04000D0D RID: 3341
		[Nullable(2)]
		protected IDollGrabItem FbInstance;

		// Token: 0x04000D0E RID: 3342
		[Nullable(2)]
		protected IDollGrabItem_SetValue PocoInterface;
	}
}
