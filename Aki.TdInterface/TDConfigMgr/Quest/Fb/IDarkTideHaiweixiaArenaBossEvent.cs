using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143C RID: 5180
	public class IDarkTideHaiweixiaArenaBossEvent : IDarkTideBossEvent
	{
		// Token: 0x0600753A RID: 30010 RVA: 0x00119969 File Offset: 0x00117B69
		public static IDarkTideHaiweixiaArenaBossEvent Create(IDarkTideHaiweixiaArenaBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideHaiweixiaArenaBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x0600753B RID: 30011 RVA: 0x00119988 File Offset: 0x00117B88
		public override EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042E2 RID: 17122
		private IDarkTideHaiweixiaArenaBossEvent Instance;
	}
}
