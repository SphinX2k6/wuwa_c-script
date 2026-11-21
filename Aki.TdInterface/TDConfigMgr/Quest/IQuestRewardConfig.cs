using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C5 RID: 4549
	public class IQuestRewardConfig
	{
		// Token: 0x060065BD RID: 26045 RVA: 0x000F4E30 File Offset: 0x000F3030
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

		// Token: 0x060065BE RID: 26046 RVA: 0x000F4E68 File Offset: 0x000F3068
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

		// Token: 0x060065BF RID: 26047 RVA: 0x000F4E7B File Offset: 0x000F307B
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

		// Token: 0x060065C0 RID: 26048 RVA: 0x000F4E8E File Offset: 0x000F308E
		public IQuestRewardConfig_SetValue ToSetValue()
		{
			return new IQuestRewardConfig_SetValue
			{
				RewardId = this.RewardId,
				RewardGetUiType = this.RewardGetUiType,
				UiConfig = this.UiConfig
			};
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x060065C1 RID: 26049 RVA: 0x000F4EB9 File Offset: 0x000F30B9
		// (set) Token: 0x060065C2 RID: 26050 RVA: 0x000F4EE4 File Offset: 0x000F30E4
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

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x000F4EF4 File Offset: 0x000F30F4
		// (set) Token: 0x060065C4 RID: 26052 RVA: 0x000F4F2E File Offset: 0x000F312E
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

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x000F4F3C File Offset: 0x000F313C
		// (set) Token: 0x060065C6 RID: 26054 RVA: 0x000F4F9D File Offset: 0x000F319D
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

		// Token: 0x04003D0D RID: 15629
		[Nullable(2)]
		protected IQuestRewardConfig FbInstance;

		// Token: 0x04003D0E RID: 15630
		[Nullable(2)]
		protected IQuestRewardConfig_SetValue PocoInterface;

		// Token: 0x04003D0F RID: 15631
		private IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x04003D10 RID: 15632
		private bool _UiConfigInited;
	}
}
