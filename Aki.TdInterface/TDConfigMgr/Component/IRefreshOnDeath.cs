using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070B RID: 1803
	public class IRefreshOnDeath : IRefreshConditionBase
	{
		// Token: 0x0600263C RID: 9788 RVA: 0x000672C0 File Offset: 0x000654C0
		private IRefreshOnDeath_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshOnDeath 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshOnDeath_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshOnDeath_SetValue());
			}
			return result;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000672F8 File Offset: 0x000654F8
		public static IRefreshOnDeath Create([Nullable(2)] IRefreshOnDeath instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnDeath
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0006730B File Offset: 0x0006550B
		public static IRefreshOnDeath CreateFromSetValue([Nullable(2)] IRefreshOnDeath_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshOnDeath
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0006731E File Offset: 0x0006551E
		public new IRefreshOnDeath_SetValue ToSetValue()
		{
			return new IRefreshOnDeath_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x00067331 File Offset: 0x00065531
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0006735C File Offset: 0x0006555C
		public override ERewardDropType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERewardDropType.Death;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A51 RID: 6737
		[Nullable(2)]
		protected new IRefreshOnDeath FbInstance;

		// Token: 0x04001A52 RID: 6738
		[Nullable(2)]
		protected new IRefreshOnDeath_SetValue PocoInterface;
	}
}
