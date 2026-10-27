using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E2 RID: 29922
	public class IUnlockSystemItemTypeT
	{
		// Token: 0x1700E308 RID: 58120
		// (get) Token: 0x0603665E RID: 222814 RVA: 0x00763FFE File Offset: 0x007621FE
		// (set) Token: 0x0603665F RID: 222815 RVA: 0x00764006 File Offset: 0x00762206
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x06036660 RID: 222816 RVA: 0x0076400F File Offset: 0x0076220F
		public IUnlockSystemItemTypeT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
		}
	}
}
