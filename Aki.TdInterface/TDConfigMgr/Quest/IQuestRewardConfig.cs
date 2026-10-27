using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001097 RID: 4247
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestRewardConfig
	{
		// Token: 0x06005FC4 RID: 24516 RVA: 0x000E7D10 File Offset: 0x000E5F10
		private IQuestRewardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestRewardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestRewardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestRewardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x000E7D48 File Offset: 0x000E5F48
		public static IQuestRewardConfig Create([Nullable(2)] IQuestRewardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestRewardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x000E7D5B File Offset: 0x000E5F5B
		public static IQuestRewardConfig CreateFromSetValue([Nullable(2)] IQuestRewardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestRewardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x000E7D6E File Offset: 0x000E5F6E
		public IQuestRewardConfig_SetValue ToSetValue()
		{
			return new IQuestRewardConfig_SetValue
			{
				RewardId = this.RewardId,
				RewardGetUiType = this.RewardGetUiType,
				UiConfig = this.UiConfig
			};
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x000E7D99 File Offset: 0x000E5F99
		// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x000E7DC4 File Offset: 0x000E5FC4
		public virtual int RewardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RewardId;
			}
			set
			{
				this.GetOrCreatePoco().RewardId = value;
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x000E7DD4 File Offset: 0x000E5FD4
		// (set) Token: 0x06005FCB RID: 24523 RVA: 0x000E7E0E File Offset: 0x000E600E
		public virtual EItemGetUiType? RewardGetUiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardGetUiType;
				}
				IQuestRewardConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RewardGetUiType;
			}
			set
			{
				this.GetOrCreatePoco().RewardGetUiType = value;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06005FCC RID: 24524 RVA: 0x000E7E1C File Offset: 0x000E601C
		// (set) Token: 0x06005FCD RID: 24525 RVA: 0x000E7E7D File Offset: 0x000E607D
		[Nullable(2)]
		public virtual IItemGetUiConfigSpecialQuest UiConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._UiConfigInited)
				{
					return this._UiConfigCache;
				}
				this._UiConfigInited = true;
				if (this.FbInstance != null)
				{
					this._UiConfigCache = IItemGetUiConfigSpecialQuest.Create(this.FbInstance.UiConfig);
				}
				else
				{
					IQuestRewardConfig_SetValue pocoInterface = this.PocoInterface;
					this._UiConfigCache = ((pocoInterface != null) ? pocoInterface.UiConfig : null);
				}
				return this._UiConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UiConfig = value;
				this._UiConfigInited = false;
			}
		}

		// Token: 0x040039C0 RID: 14784
		[Nullable(2)]
		protected IQuestRewardConfig FbInstance;

		// Token: 0x040039C1 RID: 14785
		[Nullable(2)]
		protected IQuestRewardConfig_SetValue PocoInterface;

		// Token: 0x040039C2 RID: 14786
		private IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x040039C3 RID: 14787
		private bool _UiConfigInited;
	}
}
