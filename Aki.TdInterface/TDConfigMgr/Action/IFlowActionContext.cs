using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A7B RID: 6779
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowActionContext : IActionContextType
	{
		// Token: 0x0600912E RID: 37166 RVA: 0x00152144 File Offset: 0x00150344
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

		// Token: 0x0600912F RID: 37167 RVA: 0x0015217C File Offset: 0x0015037C
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

		// Token: 0x06009130 RID: 37168 RVA: 0x0015218F File Offset: 0x0015038F
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

		// Token: 0x06009131 RID: 37169 RVA: 0x001521A2 File Offset: 0x001503A2
		public new IFlowActionContext_SetValue ToSetValue()
		{
			return new IFlowActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x06009132 RID: 37170 RVA: 0x001521B5 File Offset: 0x001503B5
		// (set) Token: 0x06009133 RID: 37171 RVA: 0x001521E0 File Offset: 0x001503E0
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

		// Token: 0x04005991 RID: 22929
		[Nullable(2)]
		protected new IFlowActionContext FbInstance;

		// Token: 0x04005992 RID: 22930
		[Nullable(2)]
		protected new IFlowActionContext_SetValue PocoInterface;
	}
}
