using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001607 RID: 5639
	public class BossPilingRandomBuff : ActionParams
	{
		// Token: 0x06007F59 RID: 32601 RVA: 0x0012FC70 File Offset: 0x0012DE70
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

		// Token: 0x06007F5A RID: 32602 RVA: 0x0012FCA8 File Offset: 0x0012DEA8
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

		// Token: 0x06007F5B RID: 32603 RVA: 0x0012FCBB File Offset: 0x0012DEBB
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

		// Token: 0x06007F5C RID: 32604 RVA: 0x0012FCCE File Offset: 0x0012DECE
		public BossPilingRandomBuff_SetValue ToSetValue()
		{
			return new BossPilingRandomBuff_SetValue
			{
				BuffPoolId = this.BuffPoolId
			};
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x06007F5D RID: 32605 RVA: 0x0012FCE1 File Offset: 0x0012DEE1
		// (set) Token: 0x06007F5E RID: 32606 RVA: 0x0012FD0C File Offset: 0x0012DF0C
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

		// Token: 0x040049A9 RID: 18857
		[Nullable(2)]
		protected new BossPilingRandomBuff FbInstance;

		// Token: 0x040049AA RID: 18858
		[Nullable(2)]
		protected BossPilingRandomBuff_SetValue PocoInterface;
	}
}
