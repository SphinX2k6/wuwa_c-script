using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CFA RID: 11514
	public class IPlayGuestUiAnimationType
	{
		// Token: 0x0600FC05 RID: 64517 RVA: 0x002476FE File Offset: 0x002458FE
		public static IPlayGuestUiAnimationType Create(IPlayGuestUiAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x0600FC06 RID: 64518 RVA: 0x0024771D File Offset: 0x0024591D
		public virtual EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040089A2 RID: 35234
		private IPlayGuestUiAnimationType Instance;
	}
}
