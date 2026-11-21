using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C1 RID: 4545
	public class IQuestRecallConfig : IRecallConfig
	{
		// Token: 0x060065A7 RID: 26023 RVA: 0x000F4B3C File Offset: 0x000F2D3C
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

		// Token: 0x060065A8 RID: 26024 RVA: 0x000F4B74 File Offset: 0x000F2D74
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

		// Token: 0x060065A9 RID: 26025 RVA: 0x000F4B87 File Offset: 0x000F2D87
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

		// Token: 0x060065AA RID: 26026 RVA: 0x000F4B9A File Offset: 0x000F2D9A
		public new IQuestRecallConfig_SetValue ToSetValue()
		{
			return new IQuestRecallConfig_SetValue
			{
				RecallId = this.RecallId,
				RecallEntityList = this.RecallEntityList
			};
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x000F4BB9 File Offset: 0x000F2DB9
		// (set) Token: 0x060065AC RID: 26028 RVA: 0x000F4BE4 File Offset: 0x000F2DE4
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

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x000F4BF4 File Offset: 0x000F2DF4
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x000F4C87 File Offset: 0x000F2E87
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

		// Token: 0x04003D00 RID: 15616
		[Nullable(2)]
		protected new IQuestRecallConfig FbInstance;

		// Token: 0x04003D01 RID: 15617
		[Nullable(2)]
		protected new IQuestRecallConfig_SetValue PocoInterface;

		// Token: 0x04003D02 RID: 15618
		private List<IRecallEntityList> _RecallEntityListCache;

		// Token: 0x04003D03 RID: 15619
		private bool _RecallEntityListInited;
	}
}
