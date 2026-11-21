using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143B RID: 5179
	public class IDarkTideHecatePollutionBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06007537 RID: 30007 RVA: 0x00119935 File Offset: 0x00117B35
		public static IDarkTideHecatePollutionBossEvent Create(IDarkTideHecatePollutionBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideHecatePollutionBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x06007538 RID: 30008 RVA: 0x00119954 File Offset: 0x00117B54
		public override EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042E1 RID: 17121
		private IDarkTideHecatePollutionBossEvent Instance;
	}
}
