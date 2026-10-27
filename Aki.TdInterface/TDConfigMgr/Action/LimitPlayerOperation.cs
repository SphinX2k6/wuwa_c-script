using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020CB RID: 8395
	[NullableContext(1)]
	[Nullable(0)]
	public class LimitPlayerOperation : ActionParams
	{
		// Token: 0x0600B882 RID: 47234 RVA: 0x001AAE44 File Offset: 0x001A9044
		private LimitPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LimitPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LimitPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LimitPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x001AAE7C File Offset: 0x001A907C
		public static LimitPlayerOperation Create([Nullable(2)] LimitPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LimitPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x001AAE8F File Offset: 0x001A908F
		public static LimitPlayerOperation CreateFromSetValue([Nullable(2)] LimitPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LimitPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x001AAEA2 File Offset: 0x001A90A2
		public LimitPlayerOperation_SetValue ToSetValue()
		{
			return new LimitPlayerOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600B886 RID: 47238 RVA: 0x001AAEB5 File Offset: 0x001A90B5
		// (set) Token: 0x0600B887 RID: 47239 RVA: 0x001AAEDC File Offset: 0x001A90DC
		public virtual ILimitPlayerOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				LimitPlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006E92 RID: 28306
		[Nullable(2)]
		protected new LimitPlayerOperation FbInstance;

		// Token: 0x04006E93 RID: 28307
		[Nullable(2)]
		protected LimitPlayerOperation_SetValue PocoInterface;
	}
}
