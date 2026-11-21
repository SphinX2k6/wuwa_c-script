using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C9A RID: 11418
	public class ResumeSystemRewardPopup : ActionParams
	{
		// Token: 0x0600FAA5 RID: 64165 RVA: 0x0024575D File Offset: 0x0024395D
		public static ResumeSystemRewardPopup Create(IResumeSystemRewardPopup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResumeSystemRewardPopup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x0600FAA6 RID: 64166 RVA: 0x0024577C File Offset: 0x0024397C
		public virtual IResumeGiantDeliveryRewardPopup SystemType
		{
			get
			{
				if (this._SystemTypeInited)
				{
					return this._SystemTypeCache;
				}
				this._SystemTypeInited = true;
				this._SystemTypeCache = IResumeGiantDeliveryRewardPopup.Create(this.Instance.SystemType);
				return this._SystemTypeCache;
			}
		}

		// Token: 0x040088EE RID: 35054
		private IResumeSystemRewardPopup Instance;

		// Token: 0x040088EF RID: 35055
		[Nullable(2)]
		private IResumeGiantDeliveryRewardPopup _SystemTypeCache;

		// Token: 0x040088F0 RID: 35056
		private bool _SystemTypeInited;
	}
}
