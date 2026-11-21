using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005896 RID: 22678
	public class IGraph3dEffectBaseT
	{
		// Token: 0x1700A45D RID: 42077
		// (get) Token: 0x06024C88 RID: 150664 RVA: 0x0050D216 File Offset: 0x0050B416
		// (set) Token: 0x06024C89 RID: 150665 RVA: 0x0050D21E File Offset: 0x0050B41E
		public EGraph3dEffectType Type { get; set; }

		// Token: 0x06024C8A RID: 150666 RVA: 0x0050D227 File Offset: 0x0050B427
		public IGraph3dEffectBaseT()
		{
			this.Type = EGraph3dEffectType.FireBoxFish;
		}
	}
}
