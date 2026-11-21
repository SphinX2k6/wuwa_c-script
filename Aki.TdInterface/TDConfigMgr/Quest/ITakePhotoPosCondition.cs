using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012C2 RID: 4802
	public class ITakePhotoPosCondition
	{
		// Token: 0x06006C27 RID: 27687 RVA: 0x00102014 File Offset: 0x00100214
		private ITakePhotoPosCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhotoPosCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhotoPosCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhotoPosCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x0010204C File Offset: 0x0010024C
		public static ITakePhotoPosCondition Create([Nullable(2)] ITakePhotoPosCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhotoPosCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x0010205F File Offset: 0x0010025F
		public static ITakePhotoPosCondition CreateFromSetValue([Nullable(2)] ITakePhotoPosCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhotoPosCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00102072 File Offset: 0x00100272
		public ITakePhotoPosCondition_SetValue ToSetValue()
		{
			return new ITakePhotoPosCondition_SetValue
			{
				RangeEntity = this.RangeEntity,
				TidDescription = this.TidDescription,
				EdTidDescription = this.EdTidDescription
			};
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06006C2B RID: 27691 RVA: 0x0010209D File Offset: 0x0010029D
		// (set) Token: 0x06006C2C RID: 27692 RVA: 0x001020C8 File Offset: 0x001002C8
		public virtual int RangeEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RangeEntity;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntity = value;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x001020D6 File Offset: 0x001002D6
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x00102101 File Offset: 0x00100301
		public virtual string TidDescription
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDescription;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDescription;
			}
			set
			{
				this.GetOrCreatePoco().TidDescription = value;
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x0010210F File Offset: 0x0010030F
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x00102126 File Offset: 0x00100326
		[Nullable(2)]
		public virtual string EdTidDescription
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDescription;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDescription = value;
			}
		}

		// Token: 0x0400409A RID: 16538
		[Nullable(2)]
		protected ITakePhotoPosCondition FbInstance;

		// Token: 0x0400409B RID: 16539
		[Nullable(2)]
		protected ITakePhotoPosCondition_SetValue PocoInterface;
	}
}
