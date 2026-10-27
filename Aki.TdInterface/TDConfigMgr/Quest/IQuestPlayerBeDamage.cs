using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200108B RID: 4235
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestPlayerBeDamage : IQuestPlayerHitStatisticsType
	{
		// Token: 0x06005F82 RID: 24450 RVA: 0x000E7590 File Offset: 0x000E5790
		private IQuestPlayerBeDamage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestPlayerBeDamage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestPlayerBeDamage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestPlayerBeDamage_SetValue());
			}
			return result;
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x000E75C8 File Offset: 0x000E57C8
		public static IQuestPlayerBeDamage Create([Nullable(2)] IQuestPlayerBeDamage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerBeDamage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x000E75DB File Offset: 0x000E57DB
		public static IQuestPlayerBeDamage CreateFromSetValue([Nullable(2)] IQuestPlayerBeDamage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestPlayerBeDamage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x000E75EE File Offset: 0x000E57EE
		public new IQuestPlayerBeDamage_SetValue ToSetValue()
		{
			return new IQuestPlayerBeDamage_SetValue
			{
				Type = this.Type,
				StatisticsType = this.StatisticsType
			};
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x000E760D File Offset: 0x000E580D
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x000E7638 File Offset: 0x000E5838
		public override EPlayerHitStatisticsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerHitStatisticsType.HitCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x000E7646 File Offset: 0x000E5846
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x000E7671 File Offset: 0x000E5871
		public virtual EPlayerDamageInfoType StatisticsType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StatisticsType;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerDamageInfoType.DamagePoint;
				}
				return this.PocoInterface.StatisticsType;
			}
			set
			{
				this.GetOrCreatePoco().StatisticsType = value;
			}
		}

		// Token: 0x040039A1 RID: 14753
		[Nullable(2)]
		protected new IQuestPlayerBeDamage FbInstance;

		// Token: 0x040039A2 RID: 14754
		[Nullable(2)]
		protected new IQuestPlayerBeDamage_SetValue PocoInterface;
	}
}
