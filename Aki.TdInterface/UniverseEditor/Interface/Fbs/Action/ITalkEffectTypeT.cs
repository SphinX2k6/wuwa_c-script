using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A8C RID: 31372
	public class ITalkEffectTypeT
	{
		// Token: 0x1700E5D2 RID: 58834
		// (get) Token: 0x060374DD RID: 226525 RVA: 0x00762612 File Offset: 0x00760812
		// (set) Token: 0x060374DE RID: 226526 RVA: 0x0076261A File Offset: 0x0076081A
		public ETalkEffectType Type { get; set; }

		// Token: 0x060374DF RID: 226527 RVA: 0x00762623 File Offset: 0x00760823
		public ITalkEffectTypeT()
		{
			this.Type = ETalkEffectType.Effect;
		}
	}
}
