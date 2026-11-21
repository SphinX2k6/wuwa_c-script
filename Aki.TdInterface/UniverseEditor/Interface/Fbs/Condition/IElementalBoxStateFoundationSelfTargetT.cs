using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050EC RID: 20716
	public class IElementalBoxStateFoundationSelfTargetT
	{
		// Token: 0x17009477 RID: 38007
		// (get) Token: 0x060208D3 RID: 133331 RVA: 0x0048407B File Offset: 0x0048227B
		// (set) Token: 0x060208D4 RID: 133332 RVA: 0x00484083 File Offset: 0x00482283
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x17009478 RID: 38008
		// (get) Token: 0x060208D5 RID: 133333 RVA: 0x0048408C File Offset: 0x0048228C
		// (set) Token: 0x060208D6 RID: 133334 RVA: 0x00484094 File Offset: 0x00482294
		public string State { get; set; }

		// Token: 0x060208D7 RID: 133335 RVA: 0x0048409D File Offset: 0x0048229D
		public IElementalBoxStateFoundationSelfTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.State = null;
		}
	}
}
