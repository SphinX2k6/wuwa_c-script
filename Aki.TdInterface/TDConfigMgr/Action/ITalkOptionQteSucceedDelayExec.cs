using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021BB RID: 8635
	public class ITalkOptionQteSucceedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600BC3C RID: 48188 RVA: 0x001B3EB4 File Offset: 0x001B20B4
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

		// Token: 0x0600BC3D RID: 48189 RVA: 0x001B3EEC File Offset: 0x001B20EC
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

		// Token: 0x0600BC3E RID: 48190 RVA: 0x001B3EFF File Offset: 0x001B20FF
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

		// Token: 0x0600BC3F RID: 48191 RVA: 0x001B3F12 File Offset: 0x001B2112
		public new ITalkOptionQteSucceedDelayExec_SetValue ToSetValue()
		{
			return new ITalkOptionQteSucceedDelayExec_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600BC40 RID: 48192 RVA: 0x001B3F25 File Offset: 0x001B2125
		// (set) Token: 0x0600BC41 RID: 48193 RVA: 0x001B3F50 File Offset: 0x001B2150
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

		// Token: 0x0400712E RID: 28974
		[Nullable(2)]
		protected new ITalkOptionQteSucceedDelayExec FbInstance;

		// Token: 0x0400712F RID: 28975
		[Nullable(2)]
		protected new ITalkOptionQteSucceedDelayExec_SetValue PocoInterface;
	}
}
