using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062F RID: 1583
	public class IPasserbyNpcExitIntervalBase
	{
		// Token: 0x0600214C RID: 8524 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		private IPasserbyNpcExitIntervalBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcExitIntervalBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcExitIntervalBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcExitIntervalBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0005CE2C File Offset: 0x0005B02C
		public static IPasserbyNpcExitIntervalBase Create([Nullable(2)] IPasserbyNpcExitIntervalBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcExitIntervalBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0005CE3F File Offset: 0x0005B03F
		public static IPasserbyNpcExitIntervalBase CreateFromSetValue([Nullable(2)] IPasserbyNpcExitIntervalBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcExitIntervalBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0005CE52 File Offset: 0x0005B052
		public IPasserbyNpcExitIntervalBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcExitIntervalBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x0005CE65 File Offset: 0x0005B065
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x0005CE90 File Offset: 0x0005B090
		public virtual EPasserbyNpcExitIntervalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcExitIntervalType.PerNpcRandom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001797 RID: 6039
		[Nullable(2)]
		protected IPasserbyNpcExitIntervalBase FbInstance;

		// Token: 0x04001798 RID: 6040
		[Nullable(2)]
		protected IPasserbyNpcExitIntervalBase_SetValue PocoInterface;
	}
}
