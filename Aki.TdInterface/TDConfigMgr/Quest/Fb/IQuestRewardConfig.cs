using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012CA RID: 4810
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestRewardConfig
	{
		// Token: 0x06006E0E RID: 28174 RVA: 0x0010A4FA File Offset: 0x001086FA
		[NullableContext(1)]
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

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x06006E0F RID: 28175 RVA: 0x0010A519 File Offset: 0x00108719
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06006E10 RID: 28176 RVA: 0x0010A528 File Offset: 0x00108728
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

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06006E11 RID: 28177 RVA: 0x0010A55E File Offset: 0x0010875E
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

		// Token: 0x04003F16 RID: 16150
		private IQuestRewardConfig Instance;

		// Token: 0x04003F17 RID: 16151
		private Aki.TDConfigMgr.Action.Fb.IItemGetUiConfigSpecialQuest _UiConfigCache;

		// Token: 0x04003F18 RID: 16152
		private bool _UiConfigInited;
	}
}
