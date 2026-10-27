using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED1 RID: 28369
	public class IRideMotorcycleInteractT
	{
		// Token: 0x1700D31E RID: 54046
		// (get) Token: 0x06032233 RID: 205363 RVA: 0x006C706C File Offset: 0x006C526C
		// (set) Token: 0x06032234 RID: 205364 RVA: 0x006C7074 File Offset: 0x006C5274
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D31F RID: 54047
		// (get) Token: 0x06032235 RID: 205365 RVA: 0x006C707D File Offset: 0x006C527D
		// (set) Token: 0x06032236 RID: 205366 RVA: 0x006C7085 File Offset: 0x006C5285
		public int MotorcycleEntityId { get; set; }

		// Token: 0x06032237 RID: 205367 RVA: 0x006C708E File Offset: 0x006C528E
		public IRideMotorcycleInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.MotorcycleEntityId = 0;
		}
	}
}
