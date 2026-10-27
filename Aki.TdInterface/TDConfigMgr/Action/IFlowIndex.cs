using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A91 RID: 6801
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowIndex
	{
		// Token: 0x060091AA RID: 37290 RVA: 0x00152EB8 File Offset: 0x001510B8
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

		// Token: 0x060091AB RID: 37291 RVA: 0x00152EF0 File Offset: 0x001510F0
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

		// Token: 0x060091AC RID: 37292 RVA: 0x00152F03 File Offset: 0x00151103
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

		// Token: 0x060091AD RID: 37293 RVA: 0x00152F16 File Offset: 0x00151116
		public IFlowIndex_SetValue ToSetValue()
		{
			return new IFlowIndex_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId
			};
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x060091AE RID: 37294 RVA: 0x00152F35 File Offset: 0x00151135
		// (set) Token: 0x060091AF RID: 37295 RVA: 0x00152F60 File Offset: 0x00151160
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

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x060091B0 RID: 37296 RVA: 0x00152F6E File Offset: 0x0015116E
		// (set) Token: 0x060091B1 RID: 37297 RVA: 0x00152F99 File Offset: 0x00151199
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

		// Token: 0x040059C8 RID: 22984
		[Nullable(2)]
		protected IFlowIndex FbInstance;

		// Token: 0x040059C9 RID: 22985
		[Nullable(2)]
		protected IFlowIndex_SetValue PocoInterface;
	}
}
