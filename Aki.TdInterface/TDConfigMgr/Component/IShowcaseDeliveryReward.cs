using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200076B RID: 1899
	public class IShowcaseDeliveryReward
	{
		// Token: 0x06002878 RID: 10360 RVA: 0x0006BA64 File Offset: 0x00069C64
		private IShowcaseDeliveryReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowcaseDeliveryReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowcaseDeliveryReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowcaseDeliveryReward_SetValue());
			}
			return result;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0006BA9C File Offset: 0x00069C9C
		public static IShowcaseDeliveryReward Create([Nullable(2)] IShowcaseDeliveryReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowcaseDeliveryReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0006BAAF File Offset: 0x00069CAF
		public static IShowcaseDeliveryReward CreateFromSetValue([Nullable(2)] IShowcaseDeliveryReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowcaseDeliveryReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0006BAC2 File Offset: 0x00069CC2
		public IShowcaseDeliveryReward_SetValue ToSetValue()
		{
			return new IShowcaseDeliveryReward_SetValue
			{
				AchievedDollCount = this.AchievedDollCount,
				DropId = this.DropId
			};
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x0006BAE1 File Offset: 0x00069CE1
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0006BB0C File Offset: 0x00069D0C
		public virtual int AchievedDollCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AchievedDollCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AchievedDollCount;
			}
			set
			{
				this.GetOrCreatePoco().AchievedDollCount = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x0006BB1A File Offset: 0x00069D1A
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x0006BB45 File Offset: 0x00069D45
		public virtual int DropId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DropId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DropId;
			}
			set
			{
				this.GetOrCreatePoco().DropId = value;
			}
		}

		// Token: 0x04001B81 RID: 7041
		[Nullable(2)]
		protected IShowcaseDeliveryReward FbInstance;

		// Token: 0x04001B82 RID: 7042
		[Nullable(2)]
		protected IShowcaseDeliveryReward_SetValue PocoInterface;
	}
}
