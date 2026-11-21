using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143E RID: 5182
	public class IDarkTideChonglouTrialBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06007540 RID: 30016 RVA: 0x001199D1 File Offset: 0x00117BD1
		public static IDarkTideChonglouTrialBossEvent Create(IDarkTideChonglouTrialBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideChonglouTrialBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x06007541 RID: 30017 RVA: 0x001199F0 File Offset: 0x00117BF0
		public override EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042E4 RID: 17124
		private IDarkTideChonglouTrialBossEvent Instance;
	}
}
