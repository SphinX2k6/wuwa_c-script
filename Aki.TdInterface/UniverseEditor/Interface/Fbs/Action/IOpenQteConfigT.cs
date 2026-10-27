using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1C RID: 27676
	public class IOpenQteConfigT
	{
		// Token: 0x1700CDD7 RID: 52695
		// (get) Token: 0x06030ACB RID: 199371 RVA: 0x0069B982 File Offset: 0x00699B82
		// (set) Token: 0x06030ACC RID: 199372 RVA: 0x0069B98A File Offset: 0x00699B8A
		public EOpenQteType Type { get; set; }

		// Token: 0x06030ACD RID: 199373 RVA: 0x0069B993 File Offset: 0x00699B93
		public IOpenQteConfigT()
		{
			this.Type = EOpenQteType.PanelQte;
		}
	}
}
