using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A9 RID: 9129
	public class RemoveBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x0600C71C RID: 50972 RVA: 0x001C8144 File Offset: 0x001C6344
		private RemoveBuffToTriggeredEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveBuffToTriggeredEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveBuffToTriggeredEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveBuffToTriggeredEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C71D RID: 50973 RVA: 0x001C817C File Offset: 0x001C637C
		public static RemoveBuffToTriggeredEntity Create([Nullable(2)] RemoveBuffToTriggeredEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffToTriggeredEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C71E RID: 50974 RVA: 0x001C818F File Offset: 0x001C638F
		public static RemoveBuffToTriggeredEntity CreateFromSetValue([Nullable(2)] RemoveBuffToTriggeredEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveBuffToTriggeredEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x001C81A2 File Offset: 0x001C63A2
		public RemoveBuffToTriggeredEntity_SetValue ToSetValue()
		{
			return new RemoveBuffToTriggeredEntity_SetValue
			{
				BuffIds = this.BuffIds
			};
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600C720 RID: 50976 RVA: 0x001C81B5 File Offset: 0x001C63B5
		// (set) Token: 0x0600C721 RID: 50977 RVA: 0x001C81DC File Offset: 0x001C63DC
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				RemoveBuffToTriggeredEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007657 RID: 30295
		[Nullable(2)]
		protected new RemoveBuffToTriggeredEntity FbInstance;

		// Token: 0x04007658 RID: 30296
		[Nullable(2)]
		protected RemoveBuffToTriggeredEntity_SetValue PocoInterface;
	}
}
