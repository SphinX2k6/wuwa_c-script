using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011BF RID: 4543
	public class IQuestPlayerHitStatisticsType
	{
		// Token: 0x0600659F RID: 26015 RVA: 0x000F4A80 File Offset: 0x000F2C80
		private IQuestPlayerHitStatisticsType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestPlayerHitStatisticsType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestPlayerHitStatisticsType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestPlayerHitStatisticsType_SetValue());
			}
			return result;
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x000F4AB8 File Offset: 0x000F2CB8
		public static IQuestPlayerHitStatisticsType Create([Nullable(2)] IQuestPlayerHitStatisticsType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerHitStatisticsType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x000F4ACB File Offset: 0x000F2CCB
		public static IQuestPlayerHitStatisticsType CreateFromSetValue([Nullable(2)] IQuestPlayerHitStatisticsType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestPlayerHitStatisticsType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x000F4ADE File Offset: 0x000F2CDE
		public IQuestPlayerHitStatisticsType_SetValue ToSetValue()
		{
			return new IQuestPlayerHitStatisticsType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x000F4AF1 File Offset: 0x000F2CF1
		// (set) Token: 0x060065A4 RID: 26020 RVA: 0x000F4B1C File Offset: 0x000F2D1C
		public virtual EPlayerHitStatisticsType Type
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

		// Token: 0x04003CFD RID: 15613
		[Nullable(2)]
		protected IQuestPlayerHitStatisticsType FbInstance;

		// Token: 0x04003CFE RID: 15614
		[Nullable(2)]
		protected IQuestPlayerHitStatisticsType_SetValue PocoInterface;
	}
}
