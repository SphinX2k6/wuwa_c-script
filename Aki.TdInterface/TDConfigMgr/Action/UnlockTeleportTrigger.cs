using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002267 RID: 8807
	[NullableContext(1)]
	[Nullable(0)]
	public class UnlockTeleportTrigger : ActionParams
	{
		// Token: 0x0600C12C RID: 49452 RVA: 0x001BB5B8 File Offset: 0x001B97B8
		private UnlockTeleportTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UnlockTeleportTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UnlockTeleportTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UnlockTeleportTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x0600C12D RID: 49453 RVA: 0x001BB5F0 File Offset: 0x001B97F0
		public static UnlockTeleportTrigger Create([Nullable(2)] UnlockTeleportTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockTeleportTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C12E RID: 49454 RVA: 0x001BB603 File Offset: 0x001B9803
		public static UnlockTeleportTrigger CreateFromSetValue([Nullable(2)] UnlockTeleportTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UnlockTeleportTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C12F RID: 49455 RVA: 0x001BB616 File Offset: 0x001B9816
		public UnlockTeleportTrigger_SetValue ToSetValue()
		{
			return new UnlockTeleportTrigger_SetValue
			{
				TeleportId = this.TeleportId
			};
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600C130 RID: 49456 RVA: 0x001BB629 File Offset: 0x001B9829
		// (set) Token: 0x0600C131 RID: 49457 RVA: 0x001BB654 File Offset: 0x001B9854
		public virtual int TeleportId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleportId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TeleportId;
			}
			set
			{
				this.GetOrCreatePoco().TeleportId = value;
			}
		}

		// Token: 0x0400731A RID: 29466
		[Nullable(2)]
		protected new UnlockTeleportTrigger FbInstance;

		// Token: 0x0400731B RID: 29467
		[Nullable(2)]
		protected UnlockTeleportTrigger_SetValue PocoInterface;
	}
}
