using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C5 RID: 709
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabItem
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x00031F80 File Offset: 0x00030180
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

		// Token: 0x06000D5A RID: 3418 RVA: 0x00031FB8 File Offset: 0x000301B8
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

		// Token: 0x06000D5B RID: 3419 RVA: 0x00031FCB File Offset: 0x000301CB
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

		// Token: 0x06000D5C RID: 3420 RVA: 0x00031FDE File Offset: 0x000301DE
		public IDollGrabItem_SetValue ToSetValue()
		{
			return new IDollGrabItem_SetValue
			{
				Id = this.Id,
				ItemId = this.ItemId
			};
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00031FFD File Offset: 0x000301FD
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00032028 File Offset: 0x00030228
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

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00032036 File Offset: 0x00030236
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00032061 File Offset: 0x00030261
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

		// Token: 0x04000C23 RID: 3107
		[Nullable(2)]
		protected IDollGrabItem FbInstance;

		// Token: 0x04000C24 RID: 3108
		[Nullable(2)]
		protected IDollGrabItem_SetValue PocoInterface;
	}
}
