using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018CA RID: 6346
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientTeleportConfig
	{
		// Token: 0x0600881B RID: 34843 RVA: 0x0014226C File Offset: 0x0014046C
		private IClientTeleportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientTeleportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientTeleportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientTeleportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x001422A4 File Offset: 0x001404A4
		public static IClientTeleportConfig Create([Nullable(2)] IClientTeleportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientTeleportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x001422B7 File Offset: 0x001404B7
		public static IClientTeleportConfig CreateFromSetValue([Nullable(2)] IClientTeleportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientTeleportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x001422CA File Offset: 0x001404CA
		public IClientTeleportConfig_SetValue ToSetValue()
		{
			return new IClientTeleportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600881F RID: 34847 RVA: 0x001422DD File Offset: 0x001404DD
		// (set) Token: 0x06008820 RID: 34848 RVA: 0x00142308 File Offset: 0x00140508
		public virtual EClientTeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientTeleportType.RelativeEntityPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005586 RID: 21894
		[Nullable(2)]
		protected IClientTeleportConfig FbInstance;

		// Token: 0x04005587 RID: 21895
		[Nullable(2)]
		protected IClientTeleportConfig_SetValue PocoInterface;
	}
}
