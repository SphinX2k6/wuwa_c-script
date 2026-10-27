using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006781 RID: 26497
	public class IFadeBackgroundTypeT
	{
		// Token: 0x1700C4B0 RID: 50352
		// (get) Token: 0x0602E19F RID: 188831 RVA: 0x0064C446 File Offset: 0x0064A646
		// (set) Token: 0x0602E1A0 RID: 188832 RVA: 0x0064C44E File Offset: 0x0064A64E
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x0602E1A1 RID: 188833 RVA: 0x0064C457 File Offset: 0x0064A657
		public IFadeBackgroundTypeT()
		{
			this.Type = EFadeBackgroundType.Spine;
		}
	}
}
