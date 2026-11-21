using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2E RID: 7214
	public class IFlowSelectedNode
	{
		// Token: 0x06009976 RID: 39286 RVA: 0x00163B94 File Offset: 0x00161D94
		private IFlowSelectedNode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowSelectedNode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowSelectedNode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowSelectedNode_SetValue());
			}
			return result;
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00163BCC File Offset: 0x00161DCC
		public static IFlowSelectedNode Create([Nullable(2)] IFlowSelectedNode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowSelectedNode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00163BDF File Offset: 0x00161DDF
		public static IFlowSelectedNode CreateFromSetValue([Nullable(2)] IFlowSelectedNode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowSelectedNode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00163BF2 File Offset: 0x00161DF2
		public IFlowSelectedNode_SetValue ToSetValue()
		{
			return new IFlowSelectedNode_SetValue
			{
				FlowId = this.FlowId,
				StateId = this.StateId
			};
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600997A RID: 39290 RVA: 0x00163C11 File Offset: 0x00161E11
		// (set) Token: 0x0600997B RID: 39291 RVA: 0x00163C3C File Offset: 0x00161E3C
		public virtual int FlowId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlowId;
			}
			set
			{
				this.GetOrCreatePoco().FlowId = value;
			}
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600997C RID: 39292 RVA: 0x00163C4C File Offset: 0x00161E4C
		// (set) Token: 0x0600997D RID: 39293 RVA: 0x00163C86 File Offset: 0x00161E86
		public virtual int? StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				IFlowSelectedNode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x04005E64 RID: 24164
		[Nullable(2)]
		protected IFlowSelectedNode FbInstance;

		// Token: 0x04005E65 RID: 24165
		[Nullable(2)]
		protected IFlowSelectedNode_SetValue PocoInterface;
	}
}
