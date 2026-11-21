using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024D4 RID: 9428
	public class UnlockTeleportTrigger : ActionParams
	{
		// Token: 0x0600CCF2 RID: 52466 RVA: 0x001D2D3C File Offset: 0x001D0F3C
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

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x001D2D74 File Offset: 0x001D0F74
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

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x001D2D87 File Offset: 0x001D0F87
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

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x001D2D9A File Offset: 0x001D0F9A
		public UnlockTeleportTrigger_SetValue ToSetValue()
		{
			return new UnlockTeleportTrigger_SetValue
			{
				TeleportId = this.TeleportId
			};
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600CCF6 RID: 52470 RVA: 0x001D2DAD File Offset: 0x001D0FAD
		// (set) Token: 0x0600CCF7 RID: 52471 RVA: 0x001D2DD8 File Offset: 0x001D0FD8
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

		// Token: 0x04007967 RID: 31079
		[Nullable(2)]
		protected new UnlockTeleportTrigger FbInstance;

		// Token: 0x04007968 RID: 31080
		[Nullable(2)]
		protected UnlockTeleportTrigger_SetValue PocoInterface;
	}
}
