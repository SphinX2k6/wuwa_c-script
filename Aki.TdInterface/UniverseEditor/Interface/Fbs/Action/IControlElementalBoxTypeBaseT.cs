using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3D RID: 27453
	public class IControlElementalBoxTypeBaseT
	{
		// Token: 0x1700C9A1 RID: 51617
		// (get) Token: 0x0602F3E8 RID: 193512 RVA: 0x0067358E File Offset: 0x0067178E
		// (set) Token: 0x0602F3E9 RID: 193513 RVA: 0x00673596 File Offset: 0x00671796
		public EControlElementalBoxType Type { get; set; }

		// Token: 0x0602F3EA RID: 193514 RVA: 0x0067359F File Offset: 0x0067179F
		public IControlElementalBoxTypeBaseT()
		{
			this.Type = EControlElementalBoxType.Capture;
		}
	}
}
