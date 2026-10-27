using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164E RID: 5710
	[NullableContext(1)]
	[Nullable(0)]
	public class EndCommonTip : ActionParams
	{
		// Token: 0x06007CA1 RID: 31905 RVA: 0x0012B860 File Offset: 0x00129A60
		private EndCommonTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EndCommonTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EndCommonTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EndCommonTip_SetValue());
			}
			return result;
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x0012B898 File Offset: 0x00129A98
		public static EndCommonTip Create([Nullable(2)] EndCommonTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EndCommonTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x0012B8AB File Offset: 0x00129AAB
		public static EndCommonTip CreateFromSetValue([Nullable(2)] EndCommonTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EndCommonTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x0012B8BE File Offset: 0x00129ABE
		public EndCommonTip_SetValue ToSetValue()
		{
			return new EndCommonTip_SetValue
			{
				Token = this.Token
			};
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x06007CA5 RID: 31909 RVA: 0x0012B8D1 File Offset: 0x00129AD1
		// (set) Token: 0x06007CA6 RID: 31910 RVA: 0x0012B8FC File Offset: 0x00129AFC
		public virtual string Token
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Token;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Token;
			}
			set
			{
				this.GetOrCreatePoco().Token = value;
			}
		}

		// Token: 0x04004C82 RID: 19586
		[Nullable(2)]
		protected new EndCommonTip FbInstance;

		// Token: 0x04004C83 RID: 19587
		[Nullable(2)]
		protected EndCommonTip_SetValue PocoInterface;
	}
}
