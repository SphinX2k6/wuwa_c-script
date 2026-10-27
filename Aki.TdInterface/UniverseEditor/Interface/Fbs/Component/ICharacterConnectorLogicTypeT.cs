using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F80 RID: 20352
	public class ICharacterConnectorLogicTypeT
	{
		// Token: 0x17009318 RID: 37656
		// (get) Token: 0x060204F9 RID: 132345 RVA: 0x0047EC63 File Offset: 0x0047CE63
		// (set) Token: 0x060204FA RID: 132346 RVA: 0x0047EC6B File Offset: 0x0047CE6B
		public ECharacterConnectorLogicType Type { get; set; }

		// Token: 0x17009319 RID: 37657
		// (get) Token: 0x060204FB RID: 132347 RVA: 0x0047EC74 File Offset: 0x0047CE74
		// (set) Token: 0x060204FC RID: 132348 RVA: 0x0047EC7C File Offset: 0x0047CE7C
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x060204FD RID: 132349 RVA: 0x0047EC85 File Offset: 0x0047CE85
		public ICharacterConnectorLogicTypeT()
		{
			this.Type = ECharacterConnectorLogicType.Range;
			this.EffectConfig = null;
		}
	}
}
