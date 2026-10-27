using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047EB RID: 18411
	public class IMonsterTagDeathEffectDataT
	{
		// Token: 0x17008452 RID: 33874
		// (get) Token: 0x0601C78E RID: 116622 RVA: 0x00407257 File Offset: 0x00405457
		// (set) Token: 0x0601C78F RID: 116623 RVA: 0x0040725F File Offset: 0x0040545F
		public string Tag { get; set; }

		// Token: 0x17008453 RID: 33875
		// (get) Token: 0x0601C790 RID: 116624 RVA: 0x00407268 File Offset: 0x00405468
		// (set) Token: 0x0601C791 RID: 116625 RVA: 0x00407270 File Offset: 0x00405470
		public IEffectConfigMonsterDeathT EffectConfig { get; set; }

		// Token: 0x0601C792 RID: 116626 RVA: 0x00407279 File Offset: 0x00405479
		public IMonsterTagDeathEffectDataT()
		{
			this.Tag = null;
			this.EffectConfig = null;
		}
	}
}
