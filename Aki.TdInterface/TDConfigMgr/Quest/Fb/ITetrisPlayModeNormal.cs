using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C1 RID: 5569
	public class ITetrisPlayModeNormal : ITetrisPlayModeBase
	{
		// Token: 0x06007DB0 RID: 32176 RVA: 0x0012AF7C File Offset: 0x0012917C
		public static ITetrisPlayModeNormal Create(ITetrisPlayModeNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x0012AF9B File Offset: 0x0012919B
		public override ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x0012AFA8 File Offset: 0x001291A8
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x040048B9 RID: 18617
		private ITetrisPlayModeNormal Instance;
	}
}
