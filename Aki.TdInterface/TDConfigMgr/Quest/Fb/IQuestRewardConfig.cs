using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001410 RID: 5136
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestRewardConfig
	{
		// Token: 0x0600748C RID: 29836 RVA: 0x0011878A File Offset: 0x0011698A
		[NullableContext(0)]
		public static IQuestRewardConfig Create(IQuestRewardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestRewardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x0600748D RID: 29837 RVA: 0x001187A9 File Offset: 0x001169A9
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x001187B8 File Offset: 0x001169B8
		public virtual EItemGetUiType? RewardGetUiType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EItemGetUiType?((EItemGetUiType)this.Instance.RewardGetUiType);
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600748F RID: 29839 RVA: 0x001187EE File Offset: 0x001169EE
		public virtual Aki.TDConfigMgr.Action.Fb.IItemGetUiConfigSpecialQuest UiConfig
		{
			get
			{
				if (this._UiConfigInited)
				{
					return this._UiConfigCache;
				}
				this._UiConfigInited = true;
				this._UiConfigCache = Aki.TDConfigMgr.Action.Fb.IItemGetUiConfigSpecialQuest.Create(this.Instance.UiConfig);
				return this._UiConfigCache;
			}
		}

		// Token: 0x04004284 RID: 17028
		private IQuestRewardConfig Instance;

		// Token: 0x04004285 RID: 17029
		private Aki.TDConfigMgr.Action.Fb.IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x04004286 RID: 17030
		private bool _UiConfigInited;
	}
}
