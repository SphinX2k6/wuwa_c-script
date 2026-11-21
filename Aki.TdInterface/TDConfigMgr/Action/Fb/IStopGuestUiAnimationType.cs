using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CFD RID: 11517
	public class IStopGuestUiAnimationType
	{
		// Token: 0x0600FC0F RID: 64527 RVA: 0x002477CE File Offset: 0x002459CE
		public static IStopGuestUiAnimationType Create(IStopGuestUiAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestUiAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x0600FC10 RID: 64528 RVA: 0x002477ED File Offset: 0x002459ED
		public virtual EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040089A7 RID: 35239
		private IStopGuestUiAnimationType Instance;
	}
}
