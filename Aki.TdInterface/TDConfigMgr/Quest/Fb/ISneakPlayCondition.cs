using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200158A RID: 5514
	public class ISneakPlayCondition
	{
		// Token: 0x06007C57 RID: 31831 RVA: 0x00127851 File Offset: 0x00125A51
		public static ISneakPlayCondition Create(ISneakPlayCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISneakPlayCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x06007C58 RID: 31832 RVA: 0x00127870 File Offset: 0x00125A70
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x040047B4 RID: 18356
		private ISneakPlayCondition Instance;
	}
}
