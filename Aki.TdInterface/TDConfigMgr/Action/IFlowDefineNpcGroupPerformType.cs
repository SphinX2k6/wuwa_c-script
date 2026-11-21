using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C1C RID: 7196
	public class IFlowDefineNpcGroupPerformType
	{
		// Token: 0x060098DC RID: 39132 RVA: 0x00162808 File Offset: 0x00160A08
		private IFlowDefineNpcGroupPerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowDefineNpcGroupPerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowDefineNpcGroupPerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowDefineNpcGroupPerformType_SetValue());
			}
			return result;
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x00162840 File Offset: 0x00160A40
		public static IFlowDefineNpcGroupPerformType Create([Nullable(2)] IFlowDefineNpcGroupPerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowDefineNpcGroupPerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x00162853 File Offset: 0x00160A53
		public static IFlowDefineNpcGroupPerformType CreateFromSetValue([Nullable(2)] IFlowDefineNpcGroupPerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowDefineNpcGroupPerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x00162866 File Offset: 0x00160A66
		public IFlowDefineNpcGroupPerformType_SetValue ToSetValue()
		{
			return new IFlowDefineNpcGroupPerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x060098E0 RID: 39136 RVA: 0x00162879 File Offset: 0x00160A79
		// (set) Token: 0x060098E1 RID: 39137 RVA: 0x001628A4 File Offset: 0x00160AA4
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E16 RID: 24086
		[Nullable(2)]
		protected IFlowDefineNpcGroupPerformType FbInstance;

		// Token: 0x04005E17 RID: 24087
		[Nullable(2)]
		protected IFlowDefineNpcGroupPerformType_SetValue PocoInterface;
	}
}
