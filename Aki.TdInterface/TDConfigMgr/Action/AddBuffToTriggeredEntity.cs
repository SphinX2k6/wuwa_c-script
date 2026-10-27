using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200148F RID: 5263
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x060077BA RID: 30650 RVA: 0x0011F484 File Offset: 0x0011D684
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

		// Token: 0x060077BB RID: 30651 RVA: 0x0011F4BC File Offset: 0x0011D6BC
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

		// Token: 0x060077BC RID: 30652 RVA: 0x0011F4CF File Offset: 0x0011D6CF
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

		// Token: 0x060077BD RID: 30653 RVA: 0x0011F4E2 File Offset: 0x0011D6E2
		public AddBuffToTriggeredEntity_SetValue ToSetValue()
		{
			return new AddBuffToTriggeredEntity_SetValue
			{
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x0011F4F5 File Offset: 0x0011D6F5
		// (set) Token: 0x060077BF RID: 30655 RVA: 0x0011F51C File Offset: 0x0011D71C
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

		// Token: 0x0400459E RID: 17822
		[Nullable(2)]
		protected new AddBuffToTriggeredEntity FbInstance;

		// Token: 0x0400459F RID: 17823
		[Nullable(2)]
		protected AddBuffToTriggeredEntity_SetValue PocoInterface;
	}
}
