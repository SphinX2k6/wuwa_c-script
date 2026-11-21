using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A96 RID: 10902
	public class IChangeTimerUiConfig
	{
		// Token: 0x0600F08A RID: 61578 RVA: 0x00233E79 File Offset: 0x00232079
		public static IChangeTimerUiConfig Create(IChangeTimerUiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTimerUiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x0600F08B RID: 61579 RVA: 0x00233E98 File Offset: 0x00232098
		public virtual EChangeTimerUiType UiType
		{
			get
			{
				return (EChangeTimerUiType)this.Instance.UiType;
			}
		}

		// Token: 0x04008446 RID: 33862
		private IChangeTimerUiConfig Instance;
	}
}
