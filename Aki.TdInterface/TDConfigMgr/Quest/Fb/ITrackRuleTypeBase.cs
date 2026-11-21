using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145F RID: 5215
	public class ITrackRuleTypeBase
	{
		// Token: 0x060076B0 RID: 30384 RVA: 0x0011D2F8 File Offset: 0x0011B4F8
		public static ITrackRuleTypeBase Create(ITrackRuleTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x060076B1 RID: 30385 RVA: 0x0011D317 File Offset: 0x0011B517
		public virtual ETrackRuleType Type
		{
			get
			{
				return (ETrackRuleType)this.Instance.Type;
			}
		}

		// Token: 0x04004421 RID: 17441
		private ITrackRuleTypeBase Instance;
	}
}
