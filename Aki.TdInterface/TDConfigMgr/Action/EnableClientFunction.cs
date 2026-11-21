using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A3 RID: 6051
	public class EnableClientFunction : ActionParams
	{
		// Token: 0x06008309 RID: 33545 RVA: 0x00139C64 File Offset: 0x00137E64
		private EnableClientFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableClientFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableClientFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableClientFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x00139C9C File Offset: 0x00137E9C
		public static EnableClientFunction Create([Nullable(2)] EnableClientFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableClientFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x00139CAF File Offset: 0x00137EAF
		public static EnableClientFunction CreateFromSetValue([Nullable(2)] EnableClientFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableClientFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x00139CC2 File Offset: 0x00137EC2
		public EnableClientFunction_SetValue ToSetValue()
		{
			return new EnableClientFunction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0600830D RID: 33549 RVA: 0x00139CD5 File Offset: 0x00137ED5
		// (set) Token: 0x0600830E RID: 33550 RVA: 0x00139D00 File Offset: 0x00137F00
		public virtual EEnableClientFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableClientFunctionType.HealthBarDisplay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005041 RID: 20545
		[Nullable(2)]
		protected new EnableClientFunction FbInstance;

		// Token: 0x04005042 RID: 20546
		[Nullable(2)]
		protected EnableClientFunction_SetValue PocoInterface;
	}
}
