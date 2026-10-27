using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F4 RID: 8436
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFunction : ActionParams
	{
		// Token: 0x0600B9A0 RID: 47520 RVA: 0x001AD324 File Offset: 0x001AB524
		private OpenSystemFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenSystemFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenSystemFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenSystemFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x001AD35C File Offset: 0x001AB55C
		public static OpenSystemFunction Create([Nullable(2)] OpenSystemFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSystemFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x001AD36F File Offset: 0x001AB56F
		public static OpenSystemFunction CreateFromSetValue([Nullable(2)] OpenSystemFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenSystemFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x001AD382 File Offset: 0x001AB582
		public OpenSystemFunction_SetValue ToSetValue()
		{
			return new OpenSystemFunction_SetValue
			{
				FunctionId = this.FunctionId
			};
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600B9A4 RID: 47524 RVA: 0x001AD395 File Offset: 0x001AB595
		// (set) Token: 0x0600B9A5 RID: 47525 RVA: 0x001AD3C0 File Offset: 0x001AB5C0
		public virtual int FunctionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FunctionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FunctionId;
			}
			set
			{
				this.GetOrCreatePoco().FunctionId = value;
			}
		}

		// Token: 0x04006F2D RID: 28461
		[Nullable(2)]
		protected new OpenSystemFunction FbInstance;

		// Token: 0x04006F2E RID: 28462
		[Nullable(2)]
		protected OpenSystemFunction_SetValue PocoInterface;
	}
}
