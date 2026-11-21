using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D1 RID: 8657
	public class ITeammateTeleportConfig
	{
		// Token: 0x0600BCB2 RID: 48306 RVA: 0x001B4B68 File Offset: 0x001B2D68
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

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x001B4BA0 File Offset: 0x001B2DA0
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

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x001B4BB3 File Offset: 0x001B2DB3
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

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x001B4BC6 File Offset: 0x001B2DC6
		public ITeammateTeleportConfig_SetValue ToSetValue()
		{
			return new ITeammateTeleportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600BCB6 RID: 48310 RVA: 0x001B4BD9 File Offset: 0x001B2DD9
		// (set) Token: 0x0600BCB7 RID: 48311 RVA: 0x001B4C04 File Offset: 0x001B2E04
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

		// Token: 0x04007162 RID: 29026
		[Nullable(2)]
		protected ITeammateTeleportConfig FbInstance;

		// Token: 0x04007163 RID: 29027
		[Nullable(2)]
		protected ITeammateTeleportConfig_SetValue PocoInterface;
	}
}
