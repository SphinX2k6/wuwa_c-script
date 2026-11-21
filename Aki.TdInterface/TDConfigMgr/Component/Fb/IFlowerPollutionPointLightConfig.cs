using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE9 RID: 3817
	public class IFlowerPollutionPointLightConfig
	{
		// Token: 0x060055E9 RID: 21993 RVA: 0x000D2E00 File Offset: 0x000D1000
		public static IFlowerPollutionPointLightConfig Create(IFlowerPollutionPointLightConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerPollutionPointLightConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x060055EA RID: 21994 RVA: 0x000D2E20 File Offset: 0x000D1020
		public virtual List<int> PointLightEntityIds
		{
			get
			{
				if (this._PointLightEntityIdsInited)
				{
					return this._PointLightEntityIdsCache;
				}
				this._PointLightEntityIdsInited = true;
				int pointLightEntityIdsLength = this.Instance.PointLightEntityIdsLength;
				this._PointLightEntityIdsCache = new List<int>(pointLightEntityIdsLength);
				for (int i = 0; i < pointLightEntityIdsLength; i++)
				{
					this._PointLightEntityIdsCache.Add(this.Instance.PointLightEntityIds(i));
				}
				return this._PointLightEntityIdsCache;
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x060055EB RID: 21995 RVA: 0x000D2E84 File Offset: 0x000D1084
		public virtual List<IPointLightOperations> PointLightConfig
		{
			get
			{
				if (this._PointLightConfigInited)
				{
					return this._PointLightConfigCache;
				}
				this._PointLightConfigInited = true;
				int pointLightConfigLength = this.Instance.PointLightConfigLength;
				this._PointLightConfigCache = new List<IPointLightOperations>(pointLightConfigLength);
				for (int i = 0; i < pointLightConfigLength; i++)
				{
					this._PointLightConfigCache.Add(IPointLightOperations.Create(this.Instance.PointLightConfig(i)));
				}
				return this._PointLightConfigCache;
			}
		}

		// Token: 0x04003128 RID: 12584
		private IFlowerPollutionPointLightConfig Instance;

		// Token: 0x04003129 RID: 12585
		private List<int> _PointLightEntityIdsCache;

		// Token: 0x0400312A RID: 12586
		private bool _PointLightEntityIdsInited;

		// Token: 0x0400312B RID: 12587
		private List<IPointLightOperations> _PointLightConfigCache;

		// Token: 0x0400312C RID: 12588
		private bool _PointLightConfigInited;
	}
}
