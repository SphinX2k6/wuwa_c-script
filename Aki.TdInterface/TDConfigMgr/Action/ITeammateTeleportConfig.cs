using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F90 RID: 8080
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeammateTeleportConfig
	{
		// Token: 0x0600B1B6 RID: 45494 RVA: 0x0019E874 File Offset: 0x0019CA74
		private ITeammateTeleportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeammateTeleportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeammateTeleportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeammateTeleportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x0019E8AC File Offset: 0x0019CAAC
		public static ITeammateTeleportConfig Create([Nullable(2)] ITeammateTeleportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeammateTeleportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x0019E8BF File Offset: 0x0019CABF
		public static ITeammateTeleportConfig CreateFromSetValue([Nullable(2)] ITeammateTeleportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeammateTeleportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x0019E8D2 File Offset: 0x0019CAD2
		public ITeammateTeleportConfig_SetValue ToSetValue()
		{
			return new ITeammateTeleportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600B1BA RID: 45498 RVA: 0x0019E8E5 File Offset: 0x0019CAE5
		// (set) Token: 0x0600B1BB RID: 45499 RVA: 0x0019E910 File Offset: 0x0019CB10
		public virtual ETeammateTeleportType Type
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

		// Token: 0x04006B6A RID: 27498
		[Nullable(2)]
		protected ITeammateTeleportConfig FbInstance;

		// Token: 0x04006B6B RID: 27499
		[Nullable(2)]
		protected ITeammateTeleportConfig_SetValue PocoInterface;
	}
}
