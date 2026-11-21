using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002089 RID: 8329
	public class ISheriffReasoning : IUiGame
	{
		// Token: 0x0600B0D9 RID: 45273 RVA: 0x0018DD78 File Offset: 0x0018BF78
		private ISheriffReasoning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffReasoning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffReasoning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffReasoning_SetValue());
			}
			return result;
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x0018DDB0 File Offset: 0x0018BFB0
		public static ISheriffReasoning Create([Nullable(2)] ISheriffReasoning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffReasoning
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x0018DDC3 File Offset: 0x0018BFC3
		public static ISheriffReasoning CreateFromSetValue([Nullable(2)] ISheriffReasoning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffReasoning
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x0018DDD6 File Offset: 0x0018BFD6
		public new ISheriffReasoning_SetValue ToSetValue()
		{
			return new ISheriffReasoning_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600B0DD RID: 45277 RVA: 0x0018DDF5 File Offset: 0x0018BFF5
		// (set) Token: 0x0600B0DE RID: 45278 RVA: 0x0018DE20 File Offset: 0x0018C020
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600B0DF RID: 45279 RVA: 0x0018DE2E File Offset: 0x0018C02E
		// (set) Token: 0x0600B0E0 RID: 45280 RVA: 0x0018DE59 File Offset: 0x0018C059
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006926 RID: 26918
		[Nullable(2)]
		protected new ISheriffReasoning FbInstance;

		// Token: 0x04006927 RID: 26919
		[Nullable(2)]
		protected new ISheriffReasoning_SetValue PocoInterface;
	}
}
