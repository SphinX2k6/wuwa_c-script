using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000321 RID: 801
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityListBatch : IEntityBatchType
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x000375DC File Offset: 0x000357DC
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

		// Token: 0x06000FBD RID: 4029 RVA: 0x00037614 File Offset: 0x00035814
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

		// Token: 0x06000FBE RID: 4030 RVA: 0x00037627 File Offset: 0x00035827
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x0003763A File Offset: 0x0003583A
		public new IEntityListBatch_SetValue ToSetValue()
		{
			return new IEntityListBatch_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00037659 File Offset: 0x00035859
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00037684 File Offset: 0x00035884
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00037692 File Offset: 0x00035892
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x000376B9 File Offset: 0x000358B9
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

		// Token: 0x04000D68 RID: 3432
		[Nullable(2)]
		protected new IEntityListBatch FbInstance;

		// Token: 0x04000D69 RID: 3433
		[Nullable(2)]
		protected new IEntityListBatch_SetValue PocoInterface;
	}
}
