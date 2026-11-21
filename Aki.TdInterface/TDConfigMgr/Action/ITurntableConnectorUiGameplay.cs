using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002253 RID: 8787
	public class ITurntableConnectorUiGameplay : IUiGame
	{
		// Token: 0x0600BF88 RID: 49032 RVA: 0x001B9F40 File Offset: 0x001B8140
		private ITurntableConnectorUiGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITurntableConnectorUiGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITurntableConnectorUiGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITurntableConnectorUiGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x001B9F78 File Offset: 0x001B8178
		public static ITurntableConnectorUiGameplay Create([Nullable(2)] ITurntableConnectorUiGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableConnectorUiGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x001B9F8B File Offset: 0x001B818B
		public static ITurntableConnectorUiGameplay CreateFromSetValue([Nullable(2)] ITurntableConnectorUiGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITurntableConnectorUiGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF8B RID: 49035 RVA: 0x001B9F9E File Offset: 0x001B819E
		public new ITurntableConnectorUiGameplay_SetValue ToSetValue()
		{
			return new ITurntableConnectorUiGameplay_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x001B9FBD File Offset: 0x001B81BD
		// (set) Token: 0x0600BF8D RID: 49037 RVA: 0x001B9FE8 File Offset: 0x001B81E8
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0600BF8E RID: 49038 RVA: 0x001B9FF6 File Offset: 0x001B81F6
		// (set) Token: 0x0600BF8F RID: 49039 RVA: 0x001BA021 File Offset: 0x001B8221
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

		// Token: 0x040072C2 RID: 29378
		[Nullable(2)]
		protected new ITurntableConnectorUiGameplay FbInstance;

		// Token: 0x040072C3 RID: 29379
		[Nullable(2)]
		protected new ITurntableConnectorUiGameplay_SetValue PocoInterface;
	}
}
