using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688C RID: 26764
	public class IGetUpT
	{
		// Token: 0x1700C6BC RID: 50876
		// (get) Token: 0x0602EAD4 RID: 191188 RVA: 0x0065D476 File Offset: 0x0065B676
		// (set) Token: 0x0602EAD5 RID: 191189 RVA: 0x0065D47E File Offset: 0x0065B67E
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602EAD6 RID: 191190 RVA: 0x0065D487 File Offset: 0x0065B687
		public IGetUpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
