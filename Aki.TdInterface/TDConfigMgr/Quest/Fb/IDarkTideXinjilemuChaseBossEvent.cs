using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143A RID: 5178
	public class IDarkTideXinjilemuChaseBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06007534 RID: 30004 RVA: 0x00119901 File Offset: 0x00117B01
		public static IDarkTideXinjilemuChaseBossEvent Create(IDarkTideXinjilemuChaseBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideXinjilemuChaseBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x00119920 File Offset: 0x00117B20
		public override EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042E0 RID: 17120
		private IDarkTideXinjilemuChaseBossEvent Instance;
	}
}
