using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DC RID: 16860
	public class IDangoAbyssInformationBoardT
	{
		// Token: 0x170072E4 RID: 29412
		// (get) Token: 0x06017650 RID: 95824 RVA: 0x003581C2 File Offset: 0x003563C2
		// (set) Token: 0x06017651 RID: 95825 RVA: 0x003581CA File Offset: 0x003563CA
		public EInformationBoardType Type { get; set; }

		// Token: 0x06017652 RID: 95826 RVA: 0x003581D3 File Offset: 0x003563D3
		public IDangoAbyssInformationBoardT()
		{
			this.Type = EInformationBoardType.DangoAbyss;
		}
	}
}
