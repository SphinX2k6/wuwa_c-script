using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E84 RID: 3716
	public class ITemplateMatrixRow
	{
		// Token: 0x060053F0 RID: 21488 RVA: 0x000CEE31 File Offset: 0x000CD031
		public static ITemplateMatrixRow Create(ITemplateMatrixRow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITemplateMatrixRow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060053F1 RID: 21489 RVA: 0x000CEE50 File Offset: 0x000CD050
		public virtual List<ISpawnTemplateEntityConfig> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<ISpawnTemplateEntityConfig>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(ISpawnTemplateEntityConfig.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x04003001 RID: 12289
		private ITemplateMatrixRow Instance;

		// Token: 0x04003002 RID: 12290
		private List<ISpawnTemplateEntityConfig> _ItemsCache;

		// Token: 0x04003003 RID: 12291
		private bool _ItemsInited;
	}
}
