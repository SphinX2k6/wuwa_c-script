using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A0 RID: 29856
	public class IUiGameT
	{
		// Token: 0x1700E2B0 RID: 58032
		// (get) Token: 0x0603645E RID: 222302 RVA: 0x007609E2 File Offset: 0x0075EBE2
		// (set) Token: 0x0603645F RID: 222303 RVA: 0x007609EA File Offset: 0x0075EBEA
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x06036460 RID: 222304 RVA: 0x007609F3 File Offset: 0x0075EBF3
		public IUiGameT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
