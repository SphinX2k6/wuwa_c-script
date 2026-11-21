using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A5B RID: 6747
	public class IClientTeleportConfig
	{
		// Token: 0x06008F63 RID: 36707 RVA: 0x00151DE4 File Offset: 0x0014FFE4
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

		// Token: 0x06008F64 RID: 36708 RVA: 0x00151E1C File Offset: 0x0015001C
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

		// Token: 0x06008F65 RID: 36709 RVA: 0x00151E2F File Offset: 0x0015002F
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

		// Token: 0x06008F66 RID: 36710 RVA: 0x00151E42 File Offset: 0x00150042
		public IClientTeleportConfig_SetValue ToSetValue()
		{
			return new IClientTeleportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x06008F67 RID: 36711 RVA: 0x00151E55 File Offset: 0x00150055
		// (set) Token: 0x06008F68 RID: 36712 RVA: 0x00151E80 File Offset: 0x00150080
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

		// Token: 0x040059E0 RID: 23008
		[Nullable(2)]
		protected IClientTeleportConfig FbInstance;

		// Token: 0x040059E1 RID: 23009
		[Nullable(2)]
		protected IClientTeleportConfig_SetValue PocoInterface;
	}
}
