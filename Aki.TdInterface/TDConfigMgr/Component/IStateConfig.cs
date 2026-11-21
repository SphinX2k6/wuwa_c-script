using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AE RID: 1966
	public class IStateConfig
	{
		// Token: 0x060029F7 RID: 10743 RVA: 0x0006EB78 File Offset: 0x0006CD78
		private IStateConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		public static IStateConfig Create([Nullable(2)] IStateConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0006EBC3 File Offset: 0x0006CDC3
		public static IStateConfig CreateFromSetValue([Nullable(2)] IStateConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0006EBD6 File Offset: 0x0006CDD6
		public IStateConfig_SetValue ToSetValue()
		{
			return new IStateConfig_SetValue
			{
				State = this.State,
				Duration = this.Duration
			};
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x0006EBF5 File Offset: 0x0006CDF5
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x0006EC20 File Offset: 0x0006CE20
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0006EC2E File Offset: 0x0006CE2E
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x0006EC5D File Offset: 0x0006CE5D
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04001C47 RID: 7239
		[Nullable(2)]
		protected IStateConfig FbInstance;

		// Token: 0x04001C48 RID: 7240
		[Nullable(2)]
		protected IStateConfig_SetValue PocoInterface;
	}
}
