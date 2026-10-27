using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006886 RID: 26758
	public class IGetOffMotorcycleInteractT
	{
		// Token: 0x1700C6B8 RID: 50872
		// (get) Token: 0x0602EAB5 RID: 191157 RVA: 0x0065D216 File Offset: 0x0065B416
		// (set) Token: 0x0602EAB6 RID: 191158 RVA: 0x0065D21E File Offset: 0x0065B41E
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602EAB7 RID: 191159 RVA: 0x0065D227 File Offset: 0x0065B427
		public IGetOffMotorcycleInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
