using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011B9 RID: 4537
	public class IQuestPlayerBeDamage : IQuestPlayerHitStatisticsType
	{
		// Token: 0x0600657B RID: 25979 RVA: 0x000F46B0 File Offset: 0x000F28B0
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

		// Token: 0x0600657C RID: 25980 RVA: 0x000F46E8 File Offset: 0x000F28E8
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

		// Token: 0x0600657D RID: 25981 RVA: 0x000F46FB File Offset: 0x000F28FB
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

		// Token: 0x0600657E RID: 25982 RVA: 0x000F470E File Offset: 0x000F290E
		public new IQuestPlayerBeDamage_SetValue ToSetValue()
		{
			return new IQuestPlayerBeDamage_SetValue
			{
				Type = this.Type,
				StatisticsType = this.StatisticsType
			};
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x000F472D File Offset: 0x000F292D
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x000F4758 File Offset: 0x000F2958
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

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x000F4766 File Offset: 0x000F2966
		// (set) Token: 0x06006582 RID: 25986 RVA: 0x000F4791 File Offset: 0x000F2991
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

		// Token: 0x04003CEE RID: 15598
		[Nullable(2)]
		protected new IQuestPlayerBeDamage FbInstance;

		// Token: 0x04003CEF RID: 15599
		[Nullable(2)]
		protected new IQuestPlayerBeDamage_SetValue PocoInterface;
	}
}
