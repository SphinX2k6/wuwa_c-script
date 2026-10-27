using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D2 RID: 25810
	public class IControlElementalBoxTypeBaseT
	{
		// Token: 0x1700C014 RID: 49172
		// (get) Token: 0x0602CC64 RID: 183396 RVA: 0x00627466 File Offset: 0x00625666
		// (set) Token: 0x0602CC65 RID: 183397 RVA: 0x0062746E File Offset: 0x0062566E
		public EControlElementalBoxType Type { get; set; }

		// Token: 0x0602CC66 RID: 183398 RVA: 0x00627477 File Offset: 0x00625677
		public IControlElementalBoxTypeBaseT()
		{
			this.Type = EControlElementalBoxType.Capture;
		}
	}
}
