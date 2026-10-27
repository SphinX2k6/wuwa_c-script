using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200172F RID: 5935
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowDefineNpcGroupPerform : ActionParams
	{
		// Token: 0x06007DA5 RID: 32165 RVA: 0x0012D504 File Offset: 0x0012B704
		private FlowDefineNpcGroupPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FlowDefineNpcGroupPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FlowDefineNpcGroupPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FlowDefineNpcGroupPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x0012D53C File Offset: 0x0012B73C
		public static FlowDefineNpcGroupPerform Create([Nullable(2)] FlowDefineNpcGroupPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FlowDefineNpcGroupPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x0012D54F File Offset: 0x0012B74F
		public static FlowDefineNpcGroupPerform CreateFromSetValue([Nullable(2)] FlowDefineNpcGroupPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FlowDefineNpcGroupPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x0012D562 File Offset: 0x0012B762
		public FlowDefineNpcGroupPerform_SetValue ToSetValue()
		{
			return new FlowDefineNpcGroupPerform_SetValue
			{
				PerformType = this.PerformType
			};
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x0012D575 File Offset: 0x0012B775
		// (set) Token: 0x06007DAA RID: 32170 RVA: 0x0012D59C File Offset: 0x0012B79C
		public virtual IFlowDefineNpcGroupPerformType PerformType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformType;
				}
				FlowDefineNpcGroupPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformType;
			}
			set
			{
				this.GetOrCreatePoco().PerformType = value;
			}
		}

		// Token: 0x04005027 RID: 20519
		[Nullable(2)]
		protected new FlowDefineNpcGroupPerform FbInstance;

		// Token: 0x04005028 RID: 20520
		[Nullable(2)]
		protected FlowDefineNpcGroupPerform_SetValue PocoInterface;
	}
}
