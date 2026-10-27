using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014AE RID: 5294
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingRandomBuff : ActionParams
	{
		// Token: 0x0600788C RID: 30860 RVA: 0x00121024 File Offset: 0x0011F224
		private BossPilingRandomBuff_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BossPilingRandomBuff 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BossPilingRandomBuff_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BossPilingRandomBuff_SetValue());
			}
			return result;
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x0012105C File Offset: 0x0011F25C
		public static BossPilingRandomBuff Create([Nullable(2)] BossPilingRandomBuff instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BossPilingRandomBuff
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x0012106F File Offset: 0x0011F26F
		public static BossPilingRandomBuff CreateFromSetValue([Nullable(2)] BossPilingRandomBuff_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BossPilingRandomBuff
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00121082 File Offset: 0x0011F282
		public BossPilingRandomBuff_SetValue ToSetValue()
		{
			return new BossPilingRandomBuff_SetValue
			{
				BuffPoolId = this.BuffPoolId
			};
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x00121095 File Offset: 0x0011F295
		// (set) Token: 0x06007891 RID: 30865 RVA: 0x001210C0 File Offset: 0x0011F2C0
		public virtual int BuffPoolId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffPoolId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BuffPoolId;
			}
			set
			{
				this.GetOrCreatePoco().BuffPoolId = value;
			}
		}

		// Token: 0x0400460E RID: 17934
		[Nullable(2)]
		protected new BossPilingRandomBuff FbInstance;

		// Token: 0x0400460F RID: 17935
		[Nullable(2)]
		protected BossPilingRandomBuff_SetValue PocoInterface;
	}
}
