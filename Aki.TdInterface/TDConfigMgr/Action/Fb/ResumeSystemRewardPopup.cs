using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AD RID: 10669
	[NullableContext(1)]
	[Nullable(0)]
	public class ResumeSystemRewardPopup : ActionParams
	{
		// Token: 0x0600EC0E RID: 60430 RVA: 0x00227DD8 File Offset: 0x00225FD8
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

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x0600EC0F RID: 60431 RVA: 0x00227DF7 File Offset: 0x00225FF7
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

		// Token: 0x040081FD RID: 33277
		private IResumeSystemRewardPopup Instance;

		// Token: 0x040081FE RID: 33278
		[Nullable(2)]
		private IResumeGiantDeliveryRewardPopup _SystemTypeCache;

		// Token: 0x040081FF RID: 33279
		private bool _SystemTypeInited;
	}
}
