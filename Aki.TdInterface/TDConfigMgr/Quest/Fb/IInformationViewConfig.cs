using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001417 RID: 5143
	public class IInformationViewConfig
	{
		// Token: 0x060074A9 RID: 29865 RVA: 0x00118A4D File Offset: 0x00116C4D
		public static IInformationViewConfig Create(IInformationViewConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationViewConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x00118A6C File Offset: 0x00116C6C
		public virtual IInformationViewType InformationView
		{
			get
			{
				if (this._InformationViewInited)
				{
					return this._InformationViewCache;
				}
				this._InformationViewInited = true;
				this._InformationViewCache = QuestReadHelper.ReadIInformationViewConfig_InformationView(this.Instance);
				return this._InformationViewCache;
			}
		}

		// Token: 0x04004291 RID: 17041
		private IInformationViewConfig Instance;

		// Token: 0x04004292 RID: 17042
		private IInformationViewType _InformationViewCache;

		// Token: 0x04004293 RID: 17043
		private bool _InformationViewInited;
	}
}
