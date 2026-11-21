using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A6 RID: 22438
	public class IFanStateEffectT
	{
		// Token: 0x1700A23A RID: 41530
		// (get) Token: 0x0602437F RID: 148351 RVA: 0x004FA9E7 File Offset: 0x004F8BE7
		// (set) Token: 0x06024380 RID: 148352 RVA: 0x004FA9EF File Offset: 0x004F8BEF
		public string EntityState { get; set; }

		// Token: 0x1700A23B RID: 41531
		// (get) Token: 0x06024381 RID: 148353 RVA: 0x004FA9F8 File Offset: 0x004F8BF8
		// (set) Token: 0x06024382 RID: 148354 RVA: 0x004FAA00 File Offset: 0x004F8C00
		public IFanEffectConfigT EffectConfig { get; set; }

		// Token: 0x06024383 RID: 148355 RVA: 0x004FAA09 File Offset: 0x004F8C09
		public IFanStateEffectT()
		{
			this.EntityState = null;
			this.EffectConfig = null;
		}
	}
}
