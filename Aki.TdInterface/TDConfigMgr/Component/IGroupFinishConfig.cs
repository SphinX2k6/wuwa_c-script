using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FE RID: 1022
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupFinishConfig
	{
		// Token: 0x0600149F RID: 5279 RVA: 0x00041B2C File Offset: 0x0003FD2C
		private IGroupFinishConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupFinishConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupFinishConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupFinishConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00041B64 File Offset: 0x0003FD64
		public static IGroupFinishConfig Create([Nullable(2)] IGroupFinishConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00041B77 File Offset: 0x0003FD77
		public static IGroupFinishConfig CreateFromSetValue([Nullable(2)] IGroupFinishConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupFinishConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00041B8A File Offset: 0x0003FD8A
		public IGroupFinishConfig_SetValue ToSetValue()
		{
			return new IGroupFinishConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00041B9D File Offset: 0x0003FD9D
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		public virtual EGroupFinishConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupFinishConfig.Silence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400102D RID: 4141
		[Nullable(2)]
		protected IGroupFinishConfig FbInstance;

		// Token: 0x0400102E RID: 4142
		[Nullable(2)]
		protected IGroupFinishConfig_SetValue PocoInterface;
	}
}
