using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200523E RID: 21054
	public class IFanStateEffectT
	{
		// Token: 0x17009A3E RID: 39486
		// (get) Token: 0x060223E9 RID: 140265 RVA: 0x004BFF23 File Offset: 0x004BE123
		// (set) Token: 0x060223EA RID: 140266 RVA: 0x004BFF2B File Offset: 0x004BE12B
		public string EntityState { get; set; }

		// Token: 0x17009A3F RID: 39487
		// (get) Token: 0x060223EB RID: 140267 RVA: 0x004BFF34 File Offset: 0x004BE134
		// (set) Token: 0x060223EC RID: 140268 RVA: 0x004BFF3C File Offset: 0x004BE13C
		public IFanEffectConfigT EffectConfig { get; set; }

		// Token: 0x060223ED RID: 140269 RVA: 0x004BFF45 File Offset: 0x004BE145
		public IFanStateEffectT()
		{
			this.EntityState = null;
			this.EffectConfig = null;
		}
	}
}
