using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057D RID: 1405
	public class IMonsterShowOnDeathConfig
	{
		// Token: 0x06001C5E RID: 7262 RVA: 0x00051C7C File Offset: 0x0004FE7C
		private IMonsterShowOnDeathConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterShowOnDeathConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterShowOnDeathConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterShowOnDeathConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00051CB4 File Offset: 0x0004FEB4
		public static IMonsterShowOnDeathConfig Create([Nullable(2)] IMonsterShowOnDeathConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00051CC7 File Offset: 0x0004FEC7
		public static IMonsterShowOnDeathConfig CreateFromSetValue([Nullable(2)] IMonsterShowOnDeathConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00051CDA File Offset: 0x0004FEDA
		public IMonsterShowOnDeathConfig_SetValue ToSetValue()
		{
			return new IMonsterShowOnDeathConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00051CED File Offset: 0x0004FEED
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x00051D18 File Offset: 0x0004FF18
		public virtual EMonsterShowOnDeathType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterShowOnDeathType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001489 RID: 5257
		[Nullable(2)]
		protected IMonsterShowOnDeathConfig FbInstance;

		// Token: 0x0400148A RID: 5258
		[Nullable(2)]
		protected IMonsterShowOnDeathConfig_SetValue PocoInterface;
	}
}
