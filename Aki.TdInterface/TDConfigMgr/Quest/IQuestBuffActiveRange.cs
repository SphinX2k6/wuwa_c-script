using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200106B RID: 4203
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestBuffActiveRange
	{
		// Token: 0x06005E88 RID: 24200 RVA: 0x000E4C14 File Offset: 0x000E2E14
		[NullableContext(1)]
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

		// Token: 0x06005E89 RID: 24201 RVA: 0x000E4C4C File Offset: 0x000E2E4C
		[NullableContext(1)]
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

		// Token: 0x06005E8A RID: 24202 RVA: 0x000E4C5F File Offset: 0x000E2E5F
		[NullableContext(1)]
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

		// Token: 0x06005E8B RID: 24203 RVA: 0x000E4C72 File Offset: 0x000E2E72
		[NullableContext(1)]
		public IQuestBuffActiveRange_SetValue ToSetValue()
		{
			return new IQuestBuffActiveRange_SetValue
			{
				QuestBuffActiveCenterRange = this.QuestBuffActiveCenterRange,
				QuestBuffActiveRangeEntities = this.QuestBuffActiveRangeEntities,
				QuestBuffActiveRangeAreaIds = this.QuestBuffActiveRangeAreaIds
			};
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06005E8C RID: 24204 RVA: 0x000E4CA0 File Offset: 0x000E2EA0
		// (set) Token: 0x06005E8D RID: 24205 RVA: 0x000E4D01 File Offset: 0x000E2F01
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

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06005E8E RID: 24206 RVA: 0x000E4D16 File Offset: 0x000E2F16
		// (set) Token: 0x06005E8F RID: 24207 RVA: 0x000E4D3D File Offset: 0x000E2F3D
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

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x000E4D4B File Offset: 0x000E2F4B
		// (set) Token: 0x06005E91 RID: 24209 RVA: 0x000E4D72 File Offset: 0x000E2F72
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

		// Token: 0x040038F8 RID: 14584
		protected IQuestBuffActiveRange FbInstance;

		// Token: 0x040038F9 RID: 14585
		protected IQuestBuffActiveRange_SetValue PocoInterface;

		// Token: 0x040038FA RID: 14586
		[Nullable(1)]
		private IQuestBuffActiveCenterRange _QuestBuffActiveCenterRangeCache;

		// Token: 0x040038FB RID: 14587
		private bool _QuestBuffActiveCenterRangeInited;
	}
}
