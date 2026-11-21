using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002424 RID: 9252
	public class SetForceLock : ActionParams
	{
		// Token: 0x0600C95E RID: 51550 RVA: 0x001CC348 File Offset: 0x001CA548
		private SetForceLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetForceLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetForceLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetForceLock_SetValue());
			}
			return result;
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x001CC380 File Offset: 0x001CA580
		public static SetForceLock Create([Nullable(2)] SetForceLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetForceLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x001CC393 File Offset: 0x001CA593
		public static SetForceLock CreateFromSetValue([Nullable(2)] SetForceLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetForceLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x001CC3A6 File Offset: 0x001CA5A6
		public SetForceLock_SetValue ToSetValue()
		{
			return new SetForceLock_SetValue
			{
				EntityId = this.EntityId,
				IsLocked = this.IsLocked
			};
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600C962 RID: 51554 RVA: 0x001CC3C5 File Offset: 0x001CA5C5
		// (set) Token: 0x0600C963 RID: 51555 RVA: 0x001CC3F0 File Offset: 0x001CA5F0
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600C964 RID: 51556 RVA: 0x001CC3FE File Offset: 0x001CA5FE
		// (set) Token: 0x0600C965 RID: 51557 RVA: 0x001CC429 File Offset: 0x001CA629
		public virtual bool IsLocked
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLocked;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLocked;
			}
			set
			{
				this.GetOrCreatePoco().IsLocked = value;
			}
		}

		// Token: 0x0400777C RID: 30588
		[Nullable(2)]
		protected new SetForceLock FbInstance;

		// Token: 0x0400777D RID: 30589
		[Nullable(2)]
		protected SetForceLock_SetValue PocoInterface;
	}
}
