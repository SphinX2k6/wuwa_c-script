using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F7C RID: 8060
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionQteFailedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600B152 RID: 45394 RVA: 0x0019DDE8 File Offset: 0x0019BFE8
		private ITalkOptionQteFailedDelayExec_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionQteFailedDelayExec 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionQteFailedDelayExec_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionQteFailedDelayExec_SetValue());
			}
			return result;
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x0019DE20 File Offset: 0x0019C020
		public static ITalkOptionQteFailedDelayExec Create([Nullable(2)] ITalkOptionQteFailedDelayExec instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailedDelayExec
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x0019DE33 File Offset: 0x0019C033
		public static ITalkOptionQteFailedDelayExec CreateFromSetValue([Nullable(2)] ITalkOptionQteFailedDelayExec_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionQteFailedDelayExec
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x0019DE46 File Offset: 0x0019C046
		public new ITalkOptionQteFailedDelayExec_SetValue ToSetValue()
		{
			return new ITalkOptionQteFailedDelayExec_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600B156 RID: 45398 RVA: 0x0019DE59 File Offset: 0x0019C059
		// (set) Token: 0x0600B157 RID: 45399 RVA: 0x0019DE84 File Offset: 0x0019C084
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

		// Token: 0x04006B40 RID: 27456
		[Nullable(2)]
		protected new ITalkOptionQteFailedDelayExec FbInstance;

		// Token: 0x04006B41 RID: 27457
		[Nullable(2)]
		protected new ITalkOptionQteFailedDelayExec_SetValue PocoInterface;
	}
}
