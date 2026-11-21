using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C53 RID: 19539
	public class IMonsterTagDeathEffectDataT
	{
		// Token: 0x17008A9D RID: 35485
		// (get) Token: 0x0601DF8B RID: 122763 RVA: 0x00433BA7 File Offset: 0x00431DA7
		// (set) Token: 0x0601DF8C RID: 122764 RVA: 0x00433BAF File Offset: 0x00431DAF
		public string Tag { get; set; }

		// Token: 0x17008A9E RID: 35486
		// (get) Token: 0x0601DF8D RID: 122765 RVA: 0x00433BB8 File Offset: 0x00431DB8
		// (set) Token: 0x0601DF8E RID: 122766 RVA: 0x00433BC0 File Offset: 0x00431DC0
		public IEffectConfigMonsterDeathT EffectConfig { get; set; }

		// Token: 0x0601DF8F RID: 122767 RVA: 0x00433BC9 File Offset: 0x00431DC9
		public IMonsterTagDeathEffectDataT()
		{
			this.Tag = null;
			this.EffectConfig = null;
		}
	}
}
