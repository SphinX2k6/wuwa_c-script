using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200148D RID: 5261
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffToPlayer : ActionParams
	{
		// Token: 0x060077B0 RID: 30640 RVA: 0x0011F38C File Offset: 0x0011D58C
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

		// Token: 0x060077B1 RID: 30641 RVA: 0x0011F3C4 File Offset: 0x0011D5C4
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

		// Token: 0x060077B2 RID: 30642 RVA: 0x0011F3D7 File Offset: 0x0011D5D7
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

		// Token: 0x060077B3 RID: 30643 RVA: 0x0011F3EA File Offset: 0x0011D5EA
		public AddBuffToPlayer_SetValue ToSetValue()
		{
			return new AddBuffToPlayer_SetValue
			{
				BuffIds = this.BuffIds,
				PersistOnDestroyBuffIds = this.PersistOnDestroyBuffIds
			};
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x0011F409 File Offset: 0x0011D609
		// (set) Token: 0x060077B5 RID: 30645 RVA: 0x0011F430 File Offset: 0x0011D630
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

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x060077B6 RID: 30646 RVA: 0x0011F43E File Offset: 0x0011D63E
		// (set) Token: 0x060077B7 RID: 30647 RVA: 0x0011F465 File Offset: 0x0011D665
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

		// Token: 0x0400459A RID: 17818
		[Nullable(2)]
		protected new AddBuffToPlayer FbInstance;

		// Token: 0x0400459B RID: 17819
		[Nullable(2)]
		protected AddBuffToPlayer_SetValue PocoInterface;
	}
}
