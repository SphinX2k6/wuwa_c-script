using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B66 RID: 11110
	public class IPreloadSubLevels : SwitchSubLevels
	{
		// Token: 0x0600F42F RID: 62511 RVA: 0x00239D8E File Offset: 0x00237F8E
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

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x0600F430 RID: 62512 RVA: 0x00239DAD File Offset: 0x00237FAD
		public override ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x0600F431 RID: 62513 RVA: 0x00239DBC File Offset: 0x00237FBC
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

		// Token: 0x040085E6 RID: 34278
		private IPreloadSubLevels Instance;

		// Token: 0x040085E7 RID: 34279
		private List<string> _PreloadLevelsCache;

		// Token: 0x040085E8 RID: 34280
		private bool _PreloadLevelsInited;
	}
}
