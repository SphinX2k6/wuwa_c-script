using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A76 RID: 10870
	public class ISubScreenModeAdjust : ISubScreenModeConfig
	{
		// Token: 0x0600EFEA RID: 61418 RVA: 0x00232928 File Offset: 0x00230B28
		public static ISubScreenModeAdjust Create(ISubScreenModeAdjust? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeAdjust
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x0600EFEB RID: 61419 RVA: 0x00232947 File Offset: 0x00230B47
		public override ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x00232954 File Offset: 0x00230B54
		public virtual List<ISetSubScreenData> AdjustConfigs
		{
			get
			{
				if (this._AdjustConfigsInited)
				{
					return this._AdjustConfigsCache;
				}
				this._AdjustConfigsInited = true;
				int adjustConfigsLength = this.Instance.AdjustConfigsLength;
				this._AdjustConfigsCache = new List<ISetSubScreenData>(adjustConfigsLength);
				for (int i = 0; i < adjustConfigsLength; i++)
				{
					this._AdjustConfigsCache.Add(ISetSubScreenData.Create(this.Instance.AdjustConfigs(i)));
				}
				return this._AdjustConfigsCache;
			}
		}

		// Token: 0x040083EC RID: 33772
		private ISubScreenModeAdjust Instance;

		// Token: 0x040083ED RID: 33773
		private List<ISetSubScreenData> _AdjustConfigsCache;

		// Token: 0x040083EE RID: 33774
		private bool _AdjustConfigsInited;
	}
}
