using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000633 RID: 1587
	public class IPasserbyNpcExitTimingBase
	{
		// Token: 0x0600215C RID: 8540 RVA: 0x0005CF6C File Offset: 0x0005B16C
		private IPasserbyNpcExitTimingBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcExitTimingBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcExitTimingBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcExitTimingBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
		public static IPasserbyNpcExitTimingBase Create([Nullable(2)] IPasserbyNpcExitTimingBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcExitTimingBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0005CFB7 File Offset: 0x0005B1B7
		public static IPasserbyNpcExitTimingBase CreateFromSetValue([Nullable(2)] IPasserbyNpcExitTimingBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcExitTimingBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0005CFCA File Offset: 0x0005B1CA
		public IPasserbyNpcExitTimingBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcExitTimingBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0005CFDD File Offset: 0x0005B1DD
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x0005D008 File Offset: 0x0005B208
		public virtual EPasserbyNpcExitTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcExitTimingType.LiftStop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400179D RID: 6045
		[Nullable(2)]
		protected IPasserbyNpcExitTimingBase FbInstance;

		// Token: 0x0400179E RID: 6046
		[Nullable(2)]
		protected IPasserbyNpcExitTimingBase_SetValue PocoInterface;
	}
}
