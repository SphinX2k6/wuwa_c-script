using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E5 RID: 27109
	public class ILeisureInteractTypeT
	{
		// Token: 0x1700C924 RID: 51492
		// (get) Token: 0x0602F677 RID: 194167 RVA: 0x00675116 File Offset: 0x00673316
		// (set) Token: 0x0602F678 RID: 194168 RVA: 0x0067511E File Offset: 0x0067331E
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602F679 RID: 194169 RVA: 0x00675127 File Offset: 0x00673327
		public ILeisureInteractTypeT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
