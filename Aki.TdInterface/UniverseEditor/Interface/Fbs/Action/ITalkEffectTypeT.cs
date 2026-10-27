using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B7 RID: 29367
	public class ITalkEffectTypeT
	{
		// Token: 0x1700D9D9 RID: 55769
		// (get) Token: 0x060341D9 RID: 213465 RVA: 0x00701276 File Offset: 0x006FF476
		// (set) Token: 0x060341DA RID: 213466 RVA: 0x0070127E File Offset: 0x006FF47E
		public ETalkEffectType Type { get; set; }

		// Token: 0x060341DB RID: 213467 RVA: 0x00701287 File Offset: 0x006FF487
		public ITalkEffectTypeT()
		{
			this.Type = ETalkEffectType.Effect;
		}
	}
}
