using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D7 RID: 8663
	public class ITelePortAfterTimeOut : ITeammateTeleportConfig
	{
		// Token: 0x0600BCCC RID: 48332 RVA: 0x001B4DE0 File Offset: 0x001B2FE0
		private ITelePortAfterTimeOut_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITelePortAfterTimeOut 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITelePortAfterTimeOut_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITelePortAfterTimeOut_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCCD RID: 48333 RVA: 0x001B4E18 File Offset: 0x001B3018
		public static ITelePortAfterTimeOut Create([Nullable(2)] ITelePortAfterTimeOut instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITelePortAfterTimeOut
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x001B4E2B File Offset: 0x001B302B
		public static ITelePortAfterTimeOut CreateFromSetValue([Nullable(2)] ITelePortAfterTimeOut_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITelePortAfterTimeOut
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x001B4E3E File Offset: 0x001B303E
		public new ITelePortAfterTimeOut_SetValue ToSetValue()
		{
			return new ITelePortAfterTimeOut_SetValue
			{
				Type = this.Type,
				TimeOut = this.TimeOut
			};
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x001B4E5D File Offset: 0x001B305D
		// (set) Token: 0x0600BCD1 RID: 48337 RVA: 0x001B4E88 File Offset: 0x001B3088
		public override ETeammateTeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeammateTeleportType.TelePortAfterTimeOut;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600BCD2 RID: 48338 RVA: 0x001B4E96 File Offset: 0x001B3096
		// (set) Token: 0x0600BCD3 RID: 48339 RVA: 0x001B4EC1 File Offset: 0x001B30C1
		public virtual int TimeOut
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeOut;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TimeOut;
			}
			set
			{
				this.GetOrCreatePoco().TimeOut = value;
			}
		}

		// Token: 0x0400716C RID: 29036
		[Nullable(2)]
		protected new ITelePortAfterTimeOut FbInstance;

		// Token: 0x0400716D RID: 29037
		[Nullable(2)]
		protected new ITelePortAfterTimeOut_SetValue PocoInterface;
	}
}
