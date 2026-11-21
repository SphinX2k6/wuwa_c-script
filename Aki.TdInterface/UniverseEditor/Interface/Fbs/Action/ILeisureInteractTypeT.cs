using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007095 RID: 28821
	public class ILeisureInteractTypeT
	{
		// Token: 0x1700D324 RID: 54052
		// (get) Token: 0x06032037 RID: 204855 RVA: 0x006C546E File Offset: 0x006C366E
		// (set) Token: 0x06032038 RID: 204856 RVA: 0x006C5476 File Offset: 0x006C3676
		public ELeisureInteract Type { get; set; }

		// Token: 0x06032039 RID: 204857 RVA: 0x006C547F File Offset: 0x006C367F
		public ILeisureInteractTypeT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
