using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F7E RID: 8062
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionQteSucceed : ITalkOptionParamType
	{
		// Token: 0x0600B15A RID: 45402 RVA: 0x0019DEA4 File Offset: 0x0019C0A4
		private ITalkOptionQteSucceed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionQteSucceed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionQteSucceed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionQteSucceed_SetValue());
			}
			return result;
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x0019DEDC File Offset: 0x0019C0DC
		public static ITalkOptionQteSucceed Create([Nullable(2)] ITalkOptionQteSucceed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x0019DEEF File Offset: 0x0019C0EF
		public static ITalkOptionQteSucceed CreateFromSetValue([Nullable(2)] ITalkOptionQteSucceed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x0019DF02 File Offset: 0x0019C102
		public new ITalkOptionQteSucceed_SetValue ToSetValue()
		{
			return new ITalkOptionQteSucceed_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600B15E RID: 45406 RVA: 0x0019DF15 File Offset: 0x0019C115
		// (set) Token: 0x0600B15F RID: 45407 RVA: 0x0019DF40 File Offset: 0x0019C140
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

		// Token: 0x04006B43 RID: 27459
		[Nullable(2)]
		protected new ITalkOptionQteSucceed FbInstance;

		// Token: 0x04006B44 RID: 27460
		[Nullable(2)]
		protected new ITalkOptionQteSucceed_SetValue PocoInterface;
	}
}
