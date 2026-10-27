using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001077 RID: 4215
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConditionEntityDeath
	{
		// Token: 0x06005F02 RID: 24322 RVA: 0x000E640C File Offset: 0x000E460C
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

		// Token: 0x06005F03 RID: 24323 RVA: 0x000E6444 File Offset: 0x000E4644
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

		// Token: 0x06005F04 RID: 24324 RVA: 0x000E6457 File Offset: 0x000E4657
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

		// Token: 0x06005F05 RID: 24325 RVA: 0x000E646A File Offset: 0x000E466A
		public IQuestFailedConditionEntityDeath_SetValue ToSetValue()
		{
			return new IQuestFailedConditionEntityDeath_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06005F06 RID: 24326 RVA: 0x000E647D File Offset: 0x000E467D
		// (set) Token: 0x06005F07 RID: 24327 RVA: 0x000E64A4 File Offset: 0x000E46A4
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

		// Token: 0x0400395B RID: 14683
		[Nullable(2)]
		protected IQuestFailedConditionEntityDeath FbInstance;

		// Token: 0x0400395C RID: 14684
		[Nullable(2)]
		protected IQuestFailedConditionEntityDeath_SetValue PocoInterface;
	}
}
