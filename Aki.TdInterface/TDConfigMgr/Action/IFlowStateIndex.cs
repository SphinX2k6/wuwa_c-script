using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C30 RID: 7216
	public class IFlowStateIndex : IFlowIndex
	{
		// Token: 0x06009980 RID: 39296 RVA: 0x00163CA4 File Offset: 0x00161EA4
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

		// Token: 0x06009981 RID: 39297 RVA: 0x00163CDC File Offset: 0x00161EDC
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

		// Token: 0x06009982 RID: 39298 RVA: 0x00163CEF File Offset: 0x00161EEF
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

		// Token: 0x06009983 RID: 39299 RVA: 0x00163D02 File Offset: 0x00161F02
		public new IFlowStateIndex_SetValue ToSetValue()
		{
			return new IFlowStateIndex_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId,
				StateId = this.StateId
			};
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x06009984 RID: 39300 RVA: 0x00163D2D File Offset: 0x00161F2D
		// (set) Token: 0x06009985 RID: 39301 RVA: 0x00163D58 File Offset: 0x00161F58
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

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x06009986 RID: 39302 RVA: 0x00163D66 File Offset: 0x00161F66
		// (set) Token: 0x06009987 RID: 39303 RVA: 0x00163D91 File Offset: 0x00161F91
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

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x06009988 RID: 39304 RVA: 0x00163D9F File Offset: 0x00161F9F
		// (set) Token: 0x06009989 RID: 39305 RVA: 0x00163DCA File Offset: 0x00161FCA
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

		// Token: 0x04005E68 RID: 24168
		[Nullable(2)]
		protected new IFlowStateIndex FbInstance;

		// Token: 0x04005E69 RID: 24169
		[Nullable(2)]
		protected new IFlowStateIndex_SetValue PocoInterface;
	}
}
