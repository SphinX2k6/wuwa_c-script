using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000368 RID: 872
	public class IEntityListBatch : IEntityBatchType
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x0003A5A8 File Offset: 0x000387A8
		private IEntityListBatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityListBatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityListBatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityListBatch_SetValue());
			}
			return result;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0003A5E0 File Offset: 0x000387E0
		public static IEntityListBatch Create([Nullable(2)] IEntityListBatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityListBatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0003A5F3 File Offset: 0x000387F3
		public static IEntityListBatch CreateFromSetValue([Nullable(2)] IEntityListBatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityListBatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0003A606 File Offset: 0x00038806
		public new IEntityListBatch_SetValue ToSetValue()
		{
			return new IEntityListBatch_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x0003A625 File Offset: 0x00038825
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x0003A650 File Offset: 0x00038850
		public override EEntityBatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityBatchType.EntityList;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0003A65E File Offset: 0x0003885E
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x0003A685 File Offset: 0x00038885
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IEntityListBatch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04000E53 RID: 3667
		[Nullable(2)]
		protected new IEntityListBatch FbInstance;

		// Token: 0x04000E54 RID: 3668
		[Nullable(2)]
		protected new IEntityListBatch_SetValue PocoInterface;
	}
}
