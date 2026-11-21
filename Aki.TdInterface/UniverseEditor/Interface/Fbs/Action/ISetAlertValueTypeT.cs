using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775D RID: 30557
	public class ISetAlertValueTypeT
	{
		// Token: 0x1700DFFC RID: 57340
		// (get) Token: 0x06035A1D RID: 219677 RVA: 0x00730362 File Offset: 0x0072E562
		// (set) Token: 0x06035A1E RID: 219678 RVA: 0x0073036A File Offset: 0x0072E56A
		public EValueChangeType Type { get; set; }

		// Token: 0x06035A1F RID: 219679 RVA: 0x00730373 File Offset: 0x0072E573
		public ISetAlertValueTypeT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
