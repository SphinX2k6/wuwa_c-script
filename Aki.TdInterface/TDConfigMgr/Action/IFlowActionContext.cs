using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C10 RID: 7184
	public class IFlowActionContext : IActionContextType
	{
		// Token: 0x06009898 RID: 39064 RVA: 0x00162070 File Offset: 0x00160270
		private IFlowActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x001620A8 File Offset: 0x001602A8
		public static IFlowActionContext Create([Nullable(2)] IFlowActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x001620BB File Offset: 0x001602BB
		public static IFlowActionContext CreateFromSetValue([Nullable(2)] IFlowActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x001620CE File Offset: 0x001602CE
		public new IFlowActionContext_SetValue ToSetValue()
		{
			return new IFlowActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600989C RID: 39068 RVA: 0x001620E1 File Offset: 0x001602E1
		// (set) Token: 0x0600989D RID: 39069 RVA: 0x0016210C File Offset: 0x0016030C
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

		// Token: 0x04005DF6 RID: 24054
		[Nullable(2)]
		protected new IFlowActionContext FbInstance;

		// Token: 0x04005DF7 RID: 24055
		[Nullable(2)]
		protected new IFlowActionContext_SetValue PocoInterface;
	}
}
