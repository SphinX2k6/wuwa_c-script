using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A99 RID: 6809
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowStateIndex : IFlowIndex
	{
		// Token: 0x06009208 RID: 37384 RVA: 0x00153B74 File Offset: 0x00151D74
		private IFlowStateIndex_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowStateIndex 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowStateIndex_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowStateIndex_SetValue());
			}
			return result;
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00153BAC File Offset: 0x00151DAC
		public static IFlowStateIndex Create([Nullable(2)] IFlowStateIndex instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowStateIndex
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00153BBF File Offset: 0x00151DBF
		public static IFlowStateIndex CreateFromSetValue([Nullable(2)] IFlowStateIndex_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowStateIndex
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00153BD2 File Offset: 0x00151DD2
		public new IFlowStateIndex_SetValue ToSetValue()
		{
			return new IFlowStateIndex_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId,
				StateId = this.StateId
			};
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600920C RID: 37388 RVA: 0x00153BFD File Offset: 0x00151DFD
		// (set) Token: 0x0600920D RID: 37389 RVA: 0x00153C28 File Offset: 0x00151E28
		public override string FlowListName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowListName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FlowListName;
			}
			set
			{
				this.GetOrCreatePoco().FlowListName = value;
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600920E RID: 37390 RVA: 0x00153C36 File Offset: 0x00151E36
		// (set) Token: 0x0600920F RID: 37391 RVA: 0x00153C61 File Offset: 0x00151E61
		public override int FlowId
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

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x06009210 RID: 37392 RVA: 0x00153C6F File Offset: 0x00151E6F
		// (set) Token: 0x06009211 RID: 37393 RVA: 0x00153C9A File Offset: 0x00151E9A
		public virtual int StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x040059FB RID: 23035
		[Nullable(2)]
		protected new IFlowStateIndex FbInstance;

		// Token: 0x040059FC RID: 23036
		[Nullable(2)]
		protected new IFlowStateIndex_SetValue PocoInterface;
	}
}
