using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F94 RID: 8084
	[NullableContext(1)]
	[Nullable(0)]
	public class ITelePortAfterTimeOut : ITeammateTeleportConfig
	{
		// Token: 0x0600B1C8 RID: 45512 RVA: 0x0019EA30 File Offset: 0x0019CC30
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

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x0019EA68 File Offset: 0x0019CC68
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

		// Token: 0x0600B1CA RID: 45514 RVA: 0x0019EA7B File Offset: 0x0019CC7B
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

		// Token: 0x0600B1CB RID: 45515 RVA: 0x0019EA8E File Offset: 0x0019CC8E
		public new ITelePortAfterTimeOut_SetValue ToSetValue()
		{
			return new ITelePortAfterTimeOut_SetValue
			{
				Type = this.Type,
				TimeOut = this.TimeOut
			};
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600B1CC RID: 45516 RVA: 0x0019EAAD File Offset: 0x0019CCAD
		// (set) Token: 0x0600B1CD RID: 45517 RVA: 0x0019EAD8 File Offset: 0x0019CCD8
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

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600B1CE RID: 45518 RVA: 0x0019EAE6 File Offset: 0x0019CCE6
		// (set) Token: 0x0600B1CF RID: 45519 RVA: 0x0019EB11 File Offset: 0x0019CD11
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

		// Token: 0x04006B71 RID: 27505
		[Nullable(2)]
		protected new ITelePortAfterTimeOut FbInstance;

		// Token: 0x04006B72 RID: 27506
		[Nullable(2)]
		protected new ITelePortAfterTimeOut_SetValue PocoInterface;
	}
}
