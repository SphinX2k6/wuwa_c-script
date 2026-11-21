using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A16 RID: 10774
	public class ICommonTipPrepareCountdown : ICommonTipType
	{
		// Token: 0x0600EE20 RID: 60960 RVA: 0x0022F6EC File Offset: 0x0022D8EC
		public static ICommonTipPrepareCountdown Create(ICommonTipPrepareCountdown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipPrepareCountdown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x0600EE21 RID: 60961 RVA: 0x0022F70B File Offset: 0x0022D90B
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x040082F6 RID: 33526
		private ICommonTipPrepareCountdown Instance;
	}
}
