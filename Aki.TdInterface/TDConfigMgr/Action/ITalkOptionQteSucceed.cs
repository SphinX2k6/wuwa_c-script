using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B9 RID: 8633
	public class ITalkOptionQteSucceed : ITalkOptionParamType
	{
		// Token: 0x0600BC34 RID: 48180 RVA: 0x001B3DF8 File Offset: 0x001B1FF8
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

		// Token: 0x0600BC35 RID: 48181 RVA: 0x001B3E30 File Offset: 0x001B2030
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

		// Token: 0x0600BC36 RID: 48182 RVA: 0x001B3E43 File Offset: 0x001B2043
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

		// Token: 0x0600BC37 RID: 48183 RVA: 0x001B3E56 File Offset: 0x001B2056
		public new ITalkOptionQteSucceed_SetValue ToSetValue()
		{
			return new ITalkOptionQteSucceed_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600BC38 RID: 48184 RVA: 0x001B3E69 File Offset: 0x001B2069
		// (set) Token: 0x0600BC39 RID: 48185 RVA: 0x001B3E94 File Offset: 0x001B2094
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

		// Token: 0x0400712B RID: 28971
		[Nullable(2)]
		protected new ITalkOptionQteSucceed FbInstance;

		// Token: 0x0400712C RID: 28972
		[Nullable(2)]
		protected new ITalkOptionQteSucceed_SetValue PocoInterface;
	}
}
