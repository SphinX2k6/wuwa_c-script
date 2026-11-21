using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AC RID: 6316
	public class FlowDefineNpcGroupPerform : ActionParams
	{
		// Token: 0x06008483 RID: 33923 RVA: 0x0013C5B0 File Offset: 0x0013A7B0
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

		// Token: 0x06008484 RID: 33924 RVA: 0x0013C5E8 File Offset: 0x0013A7E8
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

		// Token: 0x06008485 RID: 33925 RVA: 0x0013C5FB File Offset: 0x0013A7FB
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

		// Token: 0x06008486 RID: 33926 RVA: 0x0013C60E File Offset: 0x0013A80E
		public FlowDefineNpcGroupPerform_SetValue ToSetValue()
		{
			return new FlowDefineNpcGroupPerform_SetValue
			{
				PerformType = this.PerformType
			};
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x06008487 RID: 33927 RVA: 0x0013C621 File Offset: 0x0013A821
		// (set) Token: 0x06008488 RID: 33928 RVA: 0x0013C648 File Offset: 0x0013A848
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

		// Token: 0x04005456 RID: 21590
		[Nullable(2)]
		protected new FlowDefineNpcGroupPerform FbInstance;

		// Token: 0x04005457 RID: 21591
		[Nullable(2)]
		protected FlowDefineNpcGroupPerform_SetValue PocoInterface;
	}
}
