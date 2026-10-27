using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DED RID: 3565
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerPollutionPointLightConfig
	{
		// Token: 0x060050C2 RID: 20674 RVA: 0x000C7538 File Offset: 0x000C5738
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

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x060050C3 RID: 20675 RVA: 0x000C7558 File Offset: 0x000C5758
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

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x000C75BC File Offset: 0x000C57BC
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

		// Token: 0x04002E60 RID: 11872
		private IFlowerPollutionPointLightConfig Instance;

		// Token: 0x04002E61 RID: 11873
		private List<int> _PointLightEntityIdsCache;

		// Token: 0x04002E62 RID: 11874
		private bool _PointLightEntityIdsInited;

		// Token: 0x04002E63 RID: 11875
		private List<IPointLightOperations> _PointLightConfigCache;

		// Token: 0x04002E64 RID: 11876
		private bool _PointLightConfigInited;
	}
}
