using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001093 RID: 4243
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestRecallConfig : IRecallConfig
	{
		// Token: 0x06005FAE RID: 24494 RVA: 0x000E7A1C File Offset: 0x000E5C1C
		private IQuestRecallConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestRecallConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestRecallConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestRecallConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x000E7A54 File Offset: 0x000E5C54
		public static IQuestRecallConfig Create([Nullable(2)] IQuestRecallConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestRecallConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x000E7A67 File Offset: 0x000E5C67
		public static IQuestRecallConfig CreateFromSetValue([Nullable(2)] IQuestRecallConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestRecallConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x000E7A7A File Offset: 0x000E5C7A
		public new IQuestRecallConfig_SetValue ToSetValue()
		{
			return new IQuestRecallConfig_SetValue
			{
				RecallId = this.RecallId,
				RecallEntityList = this.RecallEntityList
			};
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x000E7A99 File Offset: 0x000E5C99
		// (set) Token: 0x06005FB3 RID: 24499 RVA: 0x000E7AC4 File Offset: 0x000E5CC4
		public override int RecallId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RecallId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RecallId;
			}
			set
			{
				this.GetOrCreatePoco().RecallId = value;
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x000E7AD4 File Offset: 0x000E5CD4
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x000E7B67 File Offset: 0x000E5D67
		public virtual List<IRecallEntityList> RecallEntityList
		{
			get
			{
				if (this._RecallEntityListInited)
				{
					return this._RecallEntityListCache;
				}
				this._RecallEntityListInited = true;
				if (this.FbInstance != null)
				{
					List<IRecallEntityList> recallEntityList = this.FbInstance.RecallEntityList;
					if (recallEntityList != null)
					{
						this._RecallEntityListCache = new List<IRecallEntityList>(recallEntityList.Count);
						for (int i = 0; i < recallEntityList.Count; i++)
						{
							this._RecallEntityListCache.Add(IRecallEntityList.Create(recallEntityList[i]));
						}
					}
				}
				else
				{
					IQuestRecallConfig_SetValue pocoInterface = this.PocoInterface;
					this._RecallEntityListCache = ((pocoInterface != null) ? pocoInterface.RecallEntityList : null);
				}
				return this._RecallEntityListCache;
			}
			set
			{
				this.GetOrCreatePoco().RecallEntityList = value;
				this._RecallEntityListInited = false;
			}
		}

		// Token: 0x040039B3 RID: 14771
		[Nullable(2)]
		protected new IQuestRecallConfig FbInstance;

		// Token: 0x040039B4 RID: 14772
		[Nullable(2)]
		protected new IQuestRecallConfig_SetValue PocoInterface;

		// Token: 0x040039B5 RID: 14773
		private List<IRecallEntityList> _RecallEntityListCache;

		// Token: 0x040039B6 RID: 14774
		private bool _RecallEntityListInited;
	}
}
