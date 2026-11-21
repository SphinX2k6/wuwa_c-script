using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143D RID: 5181
	public class IDarkTideWyvernPositionBossEvent : IDarkTideBossEvent
	{
		// Token: 0x0600753D RID: 30013 RVA: 0x0011999D File Offset: 0x00117B9D
		public static IDarkTideWyvernPositionBossEvent Create(IDarkTideWyvernPositionBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideWyvernPositionBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x0600753E RID: 30014 RVA: 0x001199BC File Offset: 0x00117BBC
		public override EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042E3 RID: 17123
		private IDarkTideWyvernPositionBossEvent Instance;
	}
}
