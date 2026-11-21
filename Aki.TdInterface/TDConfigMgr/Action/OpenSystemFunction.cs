using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002355 RID: 9045
	public class OpenSystemFunction : ActionParams
	{
		// Token: 0x0600C52C RID: 50476 RVA: 0x001C4484 File Offset: 0x001C2684
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

		// Token: 0x0600C52D RID: 50477 RVA: 0x001C44BC File Offset: 0x001C26BC
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

		// Token: 0x0600C52E RID: 50478 RVA: 0x001C44CF File Offset: 0x001C26CF
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

		// Token: 0x0600C52F RID: 50479 RVA: 0x001C44E2 File Offset: 0x001C26E2
		public OpenSystemFunction_SetValue ToSetValue()
		{
			return new OpenSystemFunction_SetValue
			{
				FunctionId = this.FunctionId
			};
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600C530 RID: 50480 RVA: 0x001C44F5 File Offset: 0x001C26F5
		// (set) Token: 0x0600C531 RID: 50481 RVA: 0x001C4520 File Offset: 0x001C2720
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

		// Token: 0x04007561 RID: 30049
		[Nullable(2)]
		protected new OpenSystemFunction FbInstance;

		// Token: 0x04007562 RID: 30050
		[Nullable(2)]
		protected OpenSystemFunction_SetValue PocoInterface;
	}
}
