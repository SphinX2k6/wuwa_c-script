using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E6 RID: 5606
	public class AddBuffToPlayer : ActionParams
	{
		// Token: 0x06007E7D RID: 32381 RVA: 0x0012DFD8 File Offset: 0x0012C1D8
		private AddBuffToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddBuffToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddBuffToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddBuffToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0012E010 File Offset: 0x0012C210
		public static AddBuffToPlayer Create([Nullable(2)] AddBuffToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0012E023 File Offset: 0x0012C223
		public static AddBuffToPlayer CreateFromSetValue([Nullable(2)] AddBuffToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddBuffToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x0012E036 File Offset: 0x0012C236
		public AddBuffToPlayer_SetValue ToSetValue()
		{
			return new AddBuffToPlayer_SetValue
			{
				BuffIds = this.BuffIds,
				PersistOnDestroyBuffIds = this.PersistOnDestroyBuffIds
			};
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06007E81 RID: 32385 RVA: 0x0012E055 File Offset: 0x0012C255
		// (set) Token: 0x06007E82 RID: 32386 RVA: 0x0012E07C File Offset: 0x0012C27C
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				AddBuffToPlayer_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06007E83 RID: 32387 RVA: 0x0012E08A File Offset: 0x0012C28A
		// (set) Token: 0x06007E84 RID: 32388 RVA: 0x0012E0B1 File Offset: 0x0012C2B1
		[Nullable(2)]
		public virtual List<long> PersistOnDestroyBuffIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PersistOnDestroyBuffIds;
				}
				AddBuffToPlayer_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PersistOnDestroyBuffIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PersistOnDestroyBuffIds = value;
			}
		}

		// Token: 0x04004935 RID: 18741
		[Nullable(2)]
		protected new AddBuffToPlayer FbInstance;

		// Token: 0x04004936 RID: 18742
		[Nullable(2)]
		protected AddBuffToPlayer_SetValue PocoInterface;
	}
}
