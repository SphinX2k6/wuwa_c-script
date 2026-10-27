using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6C RID: 27244
	public class IManipulateT
	{
		// Token: 0x1700CA21 RID: 51745
		// (get) Token: 0x0602FB74 RID: 195444 RVA: 0x0067E4E8 File Offset: 0x0067C6E8
		// (set) Token: 0x0602FB75 RID: 195445 RVA: 0x0067E4F0 File Offset: 0x0067C6F0
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CA22 RID: 51746
		// (get) Token: 0x0602FB76 RID: 195446 RVA: 0x0067E4F9 File Offset: 0x0067C6F9
		// (set) Token: 0x0602FB77 RID: 195447 RVA: 0x0067E501 File Offset: 0x0067C701
		public int TargetEntityId { get; set; }

		// Token: 0x0602FB78 RID: 195448 RVA: 0x0067E50A File Offset: 0x0067C70A
		public IManipulateT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.TargetEntityId = 0;
		}
	}
}
