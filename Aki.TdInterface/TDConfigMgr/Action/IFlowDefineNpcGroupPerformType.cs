using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A87 RID: 6791
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowDefineNpcGroupPerformType
	{
		// Token: 0x06009172 RID: 37234 RVA: 0x001528DC File Offset: 0x00150ADC
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

		// Token: 0x06009173 RID: 37235 RVA: 0x00152914 File Offset: 0x00150B14
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

		// Token: 0x06009174 RID: 37236 RVA: 0x00152927 File Offset: 0x00150B27
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

		// Token: 0x06009175 RID: 37237 RVA: 0x0015293A File Offset: 0x00150B3A
		public IFlowDefineNpcGroupPerformType_SetValue ToSetValue()
		{
			return new IFlowDefineNpcGroupPerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x0015294D File Offset: 0x00150B4D
		// (set) Token: 0x06009177 RID: 37239 RVA: 0x00152978 File Offset: 0x00150B78
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

		// Token: 0x040059B1 RID: 22961
		[Nullable(2)]
		protected IFlowDefineNpcGroupPerformType FbInstance;

		// Token: 0x040059B2 RID: 22962
		[Nullable(2)]
		protected IFlowDefineNpcGroupPerformType_SetValue PocoInterface;
	}
}
