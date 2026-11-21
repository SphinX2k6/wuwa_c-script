using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A20 RID: 31264
	public class ISwingGetUpT
	{
		// Token: 0x1700E513 RID: 58643
		// (get) Token: 0x0603715C RID: 225628 RVA: 0x0075C5C2 File Offset: 0x0075A7C2
		// (set) Token: 0x0603715D RID: 225629 RVA: 0x0075C5CA File Offset: 0x0075A7CA
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603715E RID: 225630 RVA: 0x0075C5D3 File Offset: 0x0075A7D3
		public ISwingGetUpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
