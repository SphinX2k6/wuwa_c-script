using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001075 RID: 4213
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConditionEntityAlert
	{
		// Token: 0x06005EFA RID: 24314 RVA: 0x000E6354 File Offset: 0x000E4554
		private IQuestFailedConditionEntityAlert_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestFailedConditionEntityAlert 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestFailedConditionEntityAlert_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestFailedConditionEntityAlert_SetValue());
			}
			return result;
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x000E638C File Offset: 0x000E458C
		public static IQuestFailedConditionEntityAlert Create([Nullable(2)] IQuestFailedConditionEntityAlert instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityAlert
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x000E639F File Offset: 0x000E459F
		public static IQuestFailedConditionEntityAlert CreateFromSetValue([Nullable(2)] IQuestFailedConditionEntityAlert_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityAlert
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x000E63B2 File Offset: 0x000E45B2
		public IQuestFailedConditionEntityAlert_SetValue ToSetValue()
		{
			return new IQuestFailedConditionEntityAlert_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x000E63C5 File Offset: 0x000E45C5
		// (set) Token: 0x06005EFF RID: 24319 RVA: 0x000E63EC File Offset: 0x000E45EC
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IQuestFailedConditionEntityAlert_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003958 RID: 14680
		[Nullable(2)]
		protected IQuestFailedConditionEntityAlert FbInstance;

		// Token: 0x04003959 RID: 14681
		[Nullable(2)]
		protected IQuestFailedConditionEntityAlert_SetValue PocoInterface;
	}
}
