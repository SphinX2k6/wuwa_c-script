using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000516 RID: 1302
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterShowOnDeathConfig
	{
		// Token: 0x06001A62 RID: 6754 RVA: 0x0004CEC0 File Offset: 0x0004B0C0
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

		// Token: 0x06001A63 RID: 6755 RVA: 0x0004CEF8 File Offset: 0x0004B0F8
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

		// Token: 0x06001A64 RID: 6756 RVA: 0x0004CF0B File Offset: 0x0004B10B
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

		// Token: 0x06001A65 RID: 6757 RVA: 0x0004CF1E File Offset: 0x0004B11E
		public IMonsterShowOnDeathConfig_SetValue ToSetValue()
		{
			return new IMonsterShowOnDeathConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0004CF31 File Offset: 0x0004B131
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0004CF5C File Offset: 0x0004B15C
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

		// Token: 0x0400131F RID: 4895
		[Nullable(2)]
		protected IMonsterShowOnDeathConfig FbInstance;

		// Token: 0x04001320 RID: 4896
		[Nullable(2)]
		protected IMonsterShowOnDeathConfig_SetValue PocoInterface;
	}
}
