using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DF RID: 29919
	public class IUnlockSystemItemT
	{
		// Token: 0x1700E305 RID: 58117
		// (get) Token: 0x0603664C RID: 222796 RVA: 0x00763E51 File Offset: 0x00762051
		// (set) Token: 0x0603664D RID: 222797 RVA: 0x00763E59 File Offset: 0x00762059
		public TUnlockSystemOptionUnion SystemOption { get; set; }

		// Token: 0x0603664E RID: 222798 RVA: 0x00763E62 File Offset: 0x00762062
		public IUnlockSystemItemT()
		{
			this.SystemOption = null;
		}
	}
}
