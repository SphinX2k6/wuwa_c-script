using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011A5 RID: 4517
	public class IQuestFailedConditionEntityDeath
	{
		// Token: 0x060064FB RID: 25851 RVA: 0x000F352C File Offset: 0x000F172C
		private IQuestFailedConditionEntityDeath_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestFailedConditionEntityDeath 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestFailedConditionEntityDeath_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestFailedConditionEntityDeath_SetValue());
			}
			return result;
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x000F3564 File Offset: 0x000F1764
		public static IQuestFailedConditionEntityDeath Create([Nullable(2)] IQuestFailedConditionEntityDeath instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityDeath
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x000F3577 File Offset: 0x000F1777
		public static IQuestFailedConditionEntityDeath CreateFromSetValue([Nullable(2)] IQuestFailedConditionEntityDeath_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityDeath
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x000F358A File Offset: 0x000F178A
		public IQuestFailedConditionEntityDeath_SetValue ToSetValue()
		{
			return new IQuestFailedConditionEntityDeath_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x000F359D File Offset: 0x000F179D
		// (set) Token: 0x06006500 RID: 25856 RVA: 0x000F35C4 File Offset: 0x000F17C4
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IQuestFailedConditionEntityDeath_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04003CA8 RID: 15528
		[Nullable(2)]
		protected IQuestFailedConditionEntityDeath FbInstance;

		// Token: 0x04003CA9 RID: 15529
		[Nullable(2)]
		protected IQuestFailedConditionEntityDeath_SetValue PocoInterface;
	}
}
