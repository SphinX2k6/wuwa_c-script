using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E8 RID: 5608
	public class AddBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x06007E87 RID: 32391 RVA: 0x0012E0D0 File Offset: 0x0012C2D0
		private AddBuffToTriggeredEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddBuffToTriggeredEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddBuffToTriggeredEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddBuffToTriggeredEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x0012E108 File Offset: 0x0012C308
		public static AddBuffToTriggeredEntity Create([Nullable(2)] AddBuffToTriggeredEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToTriggeredEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0012E11B File Offset: 0x0012C31B
		public static AddBuffToTriggeredEntity CreateFromSetValue([Nullable(2)] AddBuffToTriggeredEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddBuffToTriggeredEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0012E12E File Offset: 0x0012C32E
		public AddBuffToTriggeredEntity_SetValue ToSetValue()
		{
			return new AddBuffToTriggeredEntity_SetValue
			{
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06007E8B RID: 32395 RVA: 0x0012E141 File Offset: 0x0012C341
		// (set) Token: 0x06007E8C RID: 32396 RVA: 0x0012E168 File Offset: 0x0012C368
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				AddBuffToTriggeredEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BuffIds;
			}
			set
			{
				this.GetOrCreatePoco().BuffIds = value;
			}
		}

		// Token: 0x04004939 RID: 18745
		[Nullable(2)]
		protected new AddBuffToTriggeredEntity FbInstance;

		// Token: 0x0400493A RID: 18746
		[Nullable(2)]
		protected AddBuffToTriggeredEntity_SetValue PocoInterface;
	}
}
