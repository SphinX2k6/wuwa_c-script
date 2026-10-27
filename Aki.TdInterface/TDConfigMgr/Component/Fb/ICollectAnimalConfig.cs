using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C25 RID: 3109
	[NullableContext(1)]
	[Nullable(0)]
	public class ICollectAnimalConfig : ISpecialAnimalTypeConfig
	{
		// Token: 0x06004739 RID: 18233 RVA: 0x000B3588 File Offset: 0x000B1788
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

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x000B35A7 File Offset: 0x000B17A7
		public override ESpecialAnimalType Type
		{
			get
			{
				return (ESpecialAnimalType)this.Instance.Type;
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600473B RID: 18235 RVA: 0x000B35B4 File Offset: 0x000B17B4
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

		// Token: 0x0400286E RID: 10350
		private ICollectAnimalConfig Instance;

		// Token: 0x0400286F RID: 10351
		private List<ICollectAnimalPartsConfig> _PartsMapCache;

		// Token: 0x04002870 RID: 10352
		private bool _PartsMapInited;
	}
}
