using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007383 RID: 29571
	public class IOpenQteConfigT
	{
		// Token: 0x1700D8F2 RID: 55538
		// (get) Token: 0x06033A1F RID: 211487 RVA: 0x006F5C7E File Offset: 0x006F3E7E
		// (set) Token: 0x06033A20 RID: 211488 RVA: 0x006F5C86 File Offset: 0x006F3E86
		public EOpenQteType Type { get; set; }

		// Token: 0x06033A21 RID: 211489 RVA: 0x006F5C8F File Offset: 0x006F3E8F
		public IOpenQteConfigT()
		{
			this.Type = EOpenQteType.PanelQte;
		}
	}
}
