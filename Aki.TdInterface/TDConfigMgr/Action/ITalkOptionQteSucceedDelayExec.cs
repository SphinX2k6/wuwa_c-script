using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F80 RID: 8064
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionQteSucceedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600B162 RID: 45410 RVA: 0x0019DF60 File Offset: 0x0019C160
		private ITalkOptionQteSucceedDelayExec_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionQteSucceedDelayExec 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionQteSucceedDelayExec_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionQteSucceedDelayExec_SetValue());
			}
			return result;
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x0019DF98 File Offset: 0x0019C198
		public static ITalkOptionQteSucceedDelayExec Create([Nullable(2)] ITalkOptionQteSucceedDelayExec instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceedDelayExec
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x0019DFAB File Offset: 0x0019C1AB
		public static ITalkOptionQteSucceedDelayExec CreateFromSetValue([Nullable(2)] ITalkOptionQteSucceedDelayExec_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceedDelayExec
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x0019DFBE File Offset: 0x0019C1BE
		public new ITalkOptionQteSucceedDelayExec_SetValue ToSetValue()
		{
			return new ITalkOptionQteSucceedDelayExec_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600B166 RID: 45414 RVA: 0x0019DFD1 File Offset: 0x0019C1D1
		// (set) Token: 0x0600B167 RID: 45415 RVA: 0x0019DFFC File Offset: 0x0019C1FC
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B46 RID: 27462
		[Nullable(2)]
		protected new ITalkOptionQteSucceedDelayExec FbInstance;

		// Token: 0x04006B47 RID: 27463
		[Nullable(2)]
		protected new ITalkOptionQteSucceedDelayExec_SetValue PocoInterface;
	}
}
