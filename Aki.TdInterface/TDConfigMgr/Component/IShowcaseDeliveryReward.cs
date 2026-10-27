using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CA RID: 1738
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowcaseDeliveryReward
	{
		// Token: 0x06002558 RID: 9560 RVA: 0x000649F4 File Offset: 0x00062BF4
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

		// Token: 0x06002559 RID: 9561 RVA: 0x00064A2C File Offset: 0x00062C2C
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

		// Token: 0x0600255A RID: 9562 RVA: 0x00064A3F File Offset: 0x00062C3F
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

		// Token: 0x0600255B RID: 9563 RVA: 0x00064A52 File Offset: 0x00062C52
		public IShowcaseDeliveryReward_SetValue ToSetValue()
		{
			return new IShowcaseDeliveryReward_SetValue
			{
				AchievedDollCount = this.AchievedDollCount,
				DropId = this.DropId
			};
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x00064A71 File Offset: 0x00062C71
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x00064A9C File Offset: 0x00062C9C
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00064AAA File Offset: 0x00062CAA
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00064AD5 File Offset: 0x00062CD5
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

		// Token: 0x04001982 RID: 6530
		[Nullable(2)]
		protected IShowcaseDeliveryReward FbInstance;

		// Token: 0x04001983 RID: 6531
		[Nullable(2)]
		protected IShowcaseDeliveryReward_SetValue PocoInterface;
	}
}
