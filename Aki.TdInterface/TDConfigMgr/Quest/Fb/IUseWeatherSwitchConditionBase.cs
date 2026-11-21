using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001565 RID: 5477
	public class IUseWeatherSwitchConditionBase
	{
		// Token: 0x06007B7F RID: 31615 RVA: 0x00125BE0 File Offset: 0x00123DE0
		public static IUseWeatherSwitchConditionBase Create(IUseWeatherSwitchConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x06007B80 RID: 31616 RVA: 0x00125BFF File Offset: 0x00123DFF
		public virtual EUseWeatherSwitchCheckType Type
		{
			get
			{
				return (EUseWeatherSwitchCheckType)this.Instance.Type;
			}
		}

		// Token: 0x04004729 RID: 18217
		private IUseWeatherSwitchConditionBase Instance;
	}
}
