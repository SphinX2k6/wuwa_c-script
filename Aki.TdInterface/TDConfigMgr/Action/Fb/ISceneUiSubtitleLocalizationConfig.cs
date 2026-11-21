using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002882 RID: 10370
	public class ISceneUiSubtitleLocalizationConfig
	{
		// Token: 0x0600E71D RID: 59165 RVA: 0x002230D6 File Offset: 0x002212D6
		public static ISceneUiSubtitleLocalizationConfig Create(ISceneUiSubtitleLocalizationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleLocalizationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x0600E71E RID: 59166 RVA: 0x002230F8 File Offset: 0x002212F8
		public virtual List<ISceneUiSubtitleLanguageOverride> OverrideList
		{
			get
			{
				if (this._OverrideListInited)
				{
					return this._OverrideListCache;
				}
				this._OverrideListInited = true;
				int overrideListLength = this.Instance.OverrideListLength;
				this._OverrideListCache = new List<ISceneUiSubtitleLanguageOverride>(overrideListLength);
				for (int i = 0; i < overrideListLength; i++)
				{
					this._OverrideListCache.Add(ISceneUiSubtitleLanguageOverride.Create(this.Instance.OverrideList(i)));
				}
				return this._OverrideListCache;
			}
		}

		// Token: 0x04007F3E RID: 32574
		private ISceneUiSubtitleLocalizationConfig Instance;

		// Token: 0x04007F3F RID: 32575
		private List<ISceneUiSubtitleLanguageOverride> _OverrideListCache;

		// Token: 0x04007F40 RID: 32576
		private bool _OverrideListInited;
	}
}
