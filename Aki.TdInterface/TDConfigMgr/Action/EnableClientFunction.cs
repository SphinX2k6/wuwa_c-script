using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001636 RID: 5686
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableClientFunction : ActionParams
	{
		// Token: 0x06007C2B RID: 31787 RVA: 0x0012ABB8 File Offset: 0x00128DB8
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

		// Token: 0x06007C2C RID: 31788 RVA: 0x0012ABF0 File Offset: 0x00128DF0
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

		// Token: 0x06007C2D RID: 31789 RVA: 0x0012AC03 File Offset: 0x00128E03
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

		// Token: 0x06007C2E RID: 31790 RVA: 0x0012AC16 File Offset: 0x00128E16
		public EnableClientFunction_SetValue ToSetValue()
		{
			return new EnableClientFunction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x06007C2F RID: 31791 RVA: 0x0012AC29 File Offset: 0x00128E29
		// (set) Token: 0x06007C30 RID: 31792 RVA: 0x0012AC54 File Offset: 0x00128E54
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

		// Token: 0x04004C4D RID: 19533
		[Nullable(2)]
		protected new EnableClientFunction FbInstance;

		// Token: 0x04004C4E RID: 19534
		[Nullable(2)]
		protected EnableClientFunction_SetValue PocoInterface;
	}
}
