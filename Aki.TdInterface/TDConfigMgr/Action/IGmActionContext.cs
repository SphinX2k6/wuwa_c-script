using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD7 RID: 6871
	[NullableContext(1)]
	[Nullable(0)]
	public class IGmActionContext : IActionContextType
	{
		// Token: 0x06009344 RID: 37700 RVA: 0x00155DAC File Offset: 0x00153FAC
		private IGmActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGmActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGmActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGmActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x06009345 RID: 37701 RVA: 0x00155DE4 File Offset: 0x00153FE4
		public static IGmActionContext Create([Nullable(2)] IGmActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGmActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x00155DF7 File Offset: 0x00153FF7
		public static IGmActionContext CreateFromSetValue([Nullable(2)] IGmActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGmActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x00155E0A File Offset: 0x0015400A
		public new IGmActionContext_SetValue ToSetValue()
		{
			return new IGmActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x06009348 RID: 37704 RVA: 0x00155E1D File Offset: 0x0015401D
		// (set) Token: 0x06009349 RID: 37705 RVA: 0x00155E48 File Offset: 0x00154048
		public new virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A88 RID: 23176
		[Nullable(2)]
		protected new IGmActionContext FbInstance;

		// Token: 0x04005A89 RID: 23177
		[Nullable(2)]
		protected new IGmActionContext_SetValue PocoInterface;
	}
}
