using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001199 RID: 4505
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestBuffActiveRange
	{
		// Token: 0x0600647C RID: 25724 RVA: 0x000F1C6C File Offset: 0x000EFE6C
		[NullableContext(0)]
		private IQuestBuffActiveRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestBuffActiveRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestBuffActiveRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestBuffActiveRange_SetValue());
			}
			return result;
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x000F1CA4 File Offset: 0x000EFEA4
		[NullableContext(0)]
		public static IQuestBuffActiveRange Create([Nullable(2)] IQuestBuffActiveRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestBuffActiveRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x000F1CB7 File Offset: 0x000EFEB7
		[NullableContext(0)]
		public static IQuestBuffActiveRange CreateFromSetValue([Nullable(2)] IQuestBuffActiveRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestBuffActiveRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x000F1CCA File Offset: 0x000EFECA
		[NullableContext(0)]
		public IQuestBuffActiveRange_SetValue ToSetValue()
		{
			return new IQuestBuffActiveRange_SetValue
			{
				QuestBuffActiveCenterRange = this.QuestBuffActiveCenterRange,
				QuestBuffActiveRangeEntities = this.QuestBuffActiveRangeEntities,
				QuestBuffActiveRangeAreaIds = this.QuestBuffActiveRangeAreaIds
			};
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06006480 RID: 25728 RVA: 0x000F1CF8 File Offset: 0x000EFEF8
		// (set) Token: 0x06006481 RID: 25729 RVA: 0x000F1D59 File Offset: 0x000EFF59
		public virtual IQuestBuffActiveCenterRange QuestBuffActiveCenterRange
		{
			get
			{
				if (this._QuestBuffActiveCenterRangeInited)
				{
					return this._QuestBuffActiveCenterRangeCache;
				}
				this._QuestBuffActiveCenterRangeInited = true;
				if (this.FbInstance != null)
				{
					this._QuestBuffActiveCenterRangeCache = IQuestBuffActiveCenterRange.Create(this.FbInstance.QuestBuffActiveCenterRange);
				}
				else
				{
					IQuestBuffActiveRange_SetValue pocoInterface = this.PocoInterface;
					this._QuestBuffActiveCenterRangeCache = ((pocoInterface != null) ? pocoInterface.QuestBuffActiveCenterRange : null);
				}
				return this._QuestBuffActiveCenterRangeCache;
			}
			set
			{
				this.GetOrCreatePoco().QuestBuffActiveCenterRange = value;
				this._QuestBuffActiveCenterRangeInited = false;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06006482 RID: 25730 RVA: 0x000F1D6E File Offset: 0x000EFF6E
		// (set) Token: 0x06006483 RID: 25731 RVA: 0x000F1D95 File Offset: 0x000EFF95
		public virtual List<int> QuestBuffActiveRangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestBuffActiveRangeEntities;
				}
				IQuestBuffActiveRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.QuestBuffActiveRangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().QuestBuffActiveRangeEntities = value;
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06006484 RID: 25732 RVA: 0x000F1DA3 File Offset: 0x000EFFA3
		// (set) Token: 0x06006485 RID: 25733 RVA: 0x000F1DCA File Offset: 0x000EFFCA
		public virtual List<int> QuestBuffActiveRangeAreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestBuffActiveRangeAreaIds;
				}
				IQuestBuffActiveRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.QuestBuffActiveRangeAreaIds;
			}
			set
			{
				this.GetOrCreatePoco().QuestBuffActiveRangeAreaIds = value;
			}
		}

		// Token: 0x04003C43 RID: 15427
		protected IQuestBuffActiveRange FbInstance;

		// Token: 0x04003C44 RID: 15428
		protected IQuestBuffActiveRange_SetValue PocoInterface;

		// Token: 0x04003C45 RID: 15429
		[Nullable(0)]
		private IQuestBuffActiveCenterRange _QuestBuffActiveCenterRangeCache;

		// Token: 0x04003C46 RID: 15430
		private bool _QuestBuffActiveCenterRangeInited;
	}
}
