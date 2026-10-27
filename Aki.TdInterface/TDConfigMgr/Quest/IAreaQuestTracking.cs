using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000ECA RID: 3786
	[NullableContext(1)]
	[Nullable(0)]
	public class IAreaQuestTracking
	{
		// Token: 0x06005396 RID: 21398 RVA: 0x000CD97C File Offset: 0x000CBB7C
		private IAreaQuestTracking_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAreaQuestTracking 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAreaQuestTracking_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAreaQuestTracking_SetValue());
			}
			return result;
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x000CD9B4 File Offset: 0x000CBBB4
		public static IAreaQuestTracking Create([Nullable(2)] IAreaQuestTracking instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaQuestTracking
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x000CD9C7 File Offset: 0x000CBBC7
		public static IAreaQuestTracking CreateFromSetValue([Nullable(2)] IAreaQuestTracking_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAreaQuestTracking
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x000CD9DA File Offset: 0x000CBBDA
		public IAreaQuestTracking_SetValue ToSetValue()
		{
			return new IAreaQuestTracking_SetValue
			{
				QuestId = this.QuestId,
				NodeId = this.NodeId,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x000CDA05 File Offset: 0x000CBC05
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x000CDA30 File Offset: 0x000CBC30
		public virtual int QuestId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QuestId;
			}
			set
			{
				this.GetOrCreatePoco().QuestId = value;
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x000CDA3E File Offset: 0x000CBC3E
		// (set) Token: 0x0600539D RID: 21405 RVA: 0x000CDA69 File Offset: 0x000CBC69
		public virtual int NodeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NodeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NodeId;
			}
			set
			{
				this.GetOrCreatePoco().NodeId = value;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x000CDA77 File Offset: 0x000CBC77
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x000CDA9E File Offset: 0x000CBC9E
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				IAreaQuestTracking_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x040032A1 RID: 12961
		[Nullable(2)]
		protected IAreaQuestTracking FbInstance;

		// Token: 0x040032A2 RID: 12962
		[Nullable(2)]
		protected IAreaQuestTracking_SetValue PocoInterface;
	}
}
