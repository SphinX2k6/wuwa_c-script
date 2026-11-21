using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF8 RID: 3320
	public class ICollectAnimalConfig : ISpecialAnimalTypeConfig
	{
		// Token: 0x06004BA8 RID: 19368 RVA: 0x000BD8C0 File Offset: 0x000BBAC0
		public static ICollectAnimalConfig Create(ICollectAnimalConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICollectAnimalConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x000BD8DF File Offset: 0x000BBADF
		public override ESpecialAnimalType Type
		{
			get
			{
				return (ESpecialAnimalType)this.Instance.Type;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x000BD8EC File Offset: 0x000BBAEC
		public virtual List<ICollectAnimalPartsConfig> PartsMap
		{
			get
			{
				if (this._PartsMapInited)
				{
					return this._PartsMapCache;
				}
				this._PartsMapInited = true;
				int partsMapLength = this.Instance.PartsMapLength;
				this._PartsMapCache = new List<ICollectAnimalPartsConfig>(partsMapLength);
				for (int i = 0; i < partsMapLength; i++)
				{
					this._PartsMapCache.Add(ICollectAnimalPartsConfig.Create(this.Instance.PartsMap(i)));
				}
				return this._PartsMapCache;
			}
		}

		// Token: 0x04002AC1 RID: 10945
		private ICollectAnimalConfig Instance;

		// Token: 0x04002AC2 RID: 10946
		private List<ICollectAnimalPartsConfig> _PartsMapCache;

		// Token: 0x04002AC3 RID: 10947
		private bool _PartsMapInited;
	}
}
