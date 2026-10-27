using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002891 RID: 10385
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadSubLevels : SwitchSubLevels
	{
		// Token: 0x0600E600 RID: 58880 RVA: 0x0021CE0E File Offset: 0x0021B00E
		public static IPreloadSubLevels Create(IPreloadSubLevels? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadSubLevels
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x0600E601 RID: 58881 RVA: 0x0021CE2D File Offset: 0x0021B02D
		public override ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x0600E602 RID: 58882 RVA: 0x0021CE3C File Offset: 0x0021B03C
		public virtual List<string> PreloadLevels
		{
			get
			{
				if (this._PreloadLevelsInited)
				{
					return this._PreloadLevelsCache;
				}
				this._PreloadLevelsInited = true;
				int preloadLevelsLength = this.Instance.PreloadLevelsLength;
				this._PreloadLevelsCache = new List<string>(preloadLevelsLength);
				for (int i = 0; i < preloadLevelsLength; i++)
				{
					this._PreloadLevelsCache.Add(this.Instance.PreloadLevels(i));
				}
				return this._PreloadLevelsCache;
			}
		}

		// Token: 0x04007F27 RID: 32551
		private IPreloadSubLevels Instance;

		// Token: 0x04007F28 RID: 32552
		private List<string> _PreloadLevelsCache;

		// Token: 0x04007F29 RID: 32553
		private bool _PreloadLevelsInited;
	}
}
