using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F07 RID: 3847
	public class IWuWaGoGear : IWuWaGoEntityBase
	{
		// Token: 0x06005687 RID: 22151 RVA: 0x000D4559 File Offset: 0x000D2759
		public static IWuWaGoGear Create(IWuWaGoGear? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGear
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x000D4578 File Offset: 0x000D2778
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06005689 RID: 22153 RVA: 0x000D4588 File Offset: 0x000D2788
		public virtual List<int> GridEntityIds
		{
			get
			{
				if (this._GridEntityIdsInited)
				{
					return this._GridEntityIdsCache;
				}
				this._GridEntityIdsInited = true;
				int gridEntityIdsLength = this.Instance.GridEntityIdsLength;
				this._GridEntityIdsCache = new List<int>(gridEntityIdsLength);
				for (int i = 0; i < gridEntityIdsLength; i++)
				{
					this._GridEntityIdsCache.Add(this.Instance.GridEntityIds(i));
				}
				return this._GridEntityIdsCache;
			}
		}

		// Token: 0x040031A4 RID: 12708
		private IWuWaGoGear Instance;

		// Token: 0x040031A5 RID: 12709
		private List<int> _GridEntityIdsCache;

		// Token: 0x040031A6 RID: 12710
		private bool _GridEntityIdsInited;
	}
}
