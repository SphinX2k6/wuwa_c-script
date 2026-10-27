using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D1 RID: 4817
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationViewConfig
	{
		// Token: 0x06006E2B RID: 28203 RVA: 0x0010A7BD File Offset: 0x001089BD
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

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06006E2C RID: 28204 RVA: 0x0010A7DC File Offset: 0x001089DC
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

		// Token: 0x04003F23 RID: 16163
		private IInformationViewConfig Instance;

		// Token: 0x04003F24 RID: 16164
		private IInformationViewType _InformationViewCache;

		// Token: 0x04003F25 RID: 16165
		private bool _InformationViewInited;
	}
}
