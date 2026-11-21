using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C26 RID: 7206
	public class IFlowIndex
	{
		// Token: 0x06009914 RID: 39188 RVA: 0x00162DE4 File Offset: 0x00160FE4
		private IFlowIndex_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowIndex 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowIndex_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowIndex_SetValue());
			}
			return result;
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x00162E1C File Offset: 0x0016101C
		public static IFlowIndex Create([Nullable(2)] IFlowIndex instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowIndex
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00162E2F File Offset: 0x0016102F
		public static IFlowIndex CreateFromSetValue([Nullable(2)] IFlowIndex_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowIndex
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x00162E42 File Offset: 0x00161042
		public IFlowIndex_SetValue ToSetValue()
		{
			return new IFlowIndex_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId
			};
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x06009918 RID: 39192 RVA: 0x00162E61 File Offset: 0x00161061
		// (set) Token: 0x06009919 RID: 39193 RVA: 0x00162E8C File Offset: 0x0016108C
		public virtual string FlowListName
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

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600991A RID: 39194 RVA: 0x00162E9A File Offset: 0x0016109A
		// (set) Token: 0x0600991B RID: 39195 RVA: 0x00162EC5 File Offset: 0x001610C5
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

		// Token: 0x04005E2D RID: 24109
		[Nullable(2)]
		protected IFlowIndex FbInstance;

		// Token: 0x04005E2E RID: 24110
		[Nullable(2)]
		protected IFlowIndex_SetValue PocoInterface;
	}
}
