using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011A3 RID: 4515
	public class IQuestFailedConditionEntityAlert
	{
		// Token: 0x060064F3 RID: 25843 RVA: 0x000F3474 File Offset: 0x000F1674
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

		// Token: 0x060064F4 RID: 25844 RVA: 0x000F34AC File Offset: 0x000F16AC
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

		// Token: 0x060064F5 RID: 25845 RVA: 0x000F34BF File Offset: 0x000F16BF
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

		// Token: 0x060064F6 RID: 25846 RVA: 0x000F34D2 File Offset: 0x000F16D2
		public IQuestFailedConditionEntityAlert_SetValue ToSetValue()
		{
			return new IQuestFailedConditionEntityAlert_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x060064F7 RID: 25847 RVA: 0x000F34E5 File Offset: 0x000F16E5
		// (set) Token: 0x060064F8 RID: 25848 RVA: 0x000F350C File Offset: 0x000F170C
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

		// Token: 0x04003CA5 RID: 15525
		[Nullable(2)]
		protected IQuestFailedConditionEntityAlert FbInstance;

		// Token: 0x04003CA6 RID: 15526
		[Nullable(2)]
		protected IQuestFailedConditionEntityAlert_SetValue PocoInterface;
	}
}
