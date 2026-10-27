using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D88 RID: 3464
	[NullableContext(1)]
	[Nullable(0)]
	public class ITemplateMatrixRow
	{
		// Token: 0x06004ECB RID: 20171 RVA: 0x000C35E1 File Offset: 0x000C17E1
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

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x000C3600 File Offset: 0x000C1800
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

		// Token: 0x04002D3B RID: 11579
		private ITemplateMatrixRow Instance;

		// Token: 0x04002D3C RID: 11580
		private List<ISpawnTemplateEntityConfig> _ItemsCache;

		// Token: 0x04002D3D RID: 11581
		private bool _ItemsInited;
	}
}
