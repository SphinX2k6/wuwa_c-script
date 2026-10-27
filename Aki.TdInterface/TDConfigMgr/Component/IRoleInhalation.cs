using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200068C RID: 1676
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleInhalation : IInhalationPerformanceType
	{
		// Token: 0x060023E6 RID: 9190 RVA: 0x00061ACC File Offset: 0x0005FCCC
		private IRoleInhalation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleInhalation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleInhalation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleInhalation_SetValue());
			}
			return result;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00061B04 File Offset: 0x0005FD04
		public static IRoleInhalation Create([Nullable(2)] IRoleInhalation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleInhalation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00061B17 File Offset: 0x0005FD17
		public static IRoleInhalation CreateFromSetValue([Nullable(2)] IRoleInhalation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleInhalation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00061B2A File Offset: 0x0005FD2A
		public new IRoleInhalation_SetValue ToSetValue()
		{
			return new IRoleInhalation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x00061B3D File Offset: 0x0005FD3D
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x00061B68 File Offset: 0x0005FD68
		public override EInhalationPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhalationPerformanceType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040018BA RID: 6330
		[Nullable(2)]
		protected new IRoleInhalation FbInstance;

		// Token: 0x040018BB RID: 6331
		[Nullable(2)]
		protected new IRoleInhalation_SetValue PocoInterface;
	}
}
