using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005334 RID: 21300
	public class IGroupAiEcologyGameplayAbpT
	{
		// Token: 0x17009C7C RID: 40060
		// (get) Token: 0x06022D4B RID: 142667 RVA: 0x004D3832 File Offset: 0x004D1A32
		// (set) Token: 0x06022D4C RID: 142668 RVA: 0x004D383A File Offset: 0x004D1A3A
		public EGroupAiEcologyGameplayType GameplayType { get; set; }

		// Token: 0x06022D4D RID: 142669 RVA: 0x004D3843 File Offset: 0x004D1A43
		public IGroupAiEcologyGameplayAbpT()
		{
			this.GameplayType = EGroupAiEcologyGameplayType.FloatParade;
		}
	}
}
