using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006943 RID: 26947
	public class IICenterTextTypeWriterT
	{
		// Token: 0x1700C7ED RID: 51181
		// (get) Token: 0x0602F0DC RID: 192732 RVA: 0x00669EFC File Offset: 0x006680FC
		// (set) Token: 0x0602F0DD RID: 192733 RVA: 0x00669F04 File Offset: 0x00668104
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x1700C7EE RID: 51182
		// (get) Token: 0x0602F0DE RID: 192734 RVA: 0x00669F0D File Offset: 0x0066810D
		// (set) Token: 0x0602F0DF RID: 192735 RVA: 0x00669F15 File Offset: 0x00668115
		public int TextCountPerSecond { get; set; }

		// Token: 0x0602F0E0 RID: 192736 RVA: 0x00669F1E File Offset: 0x0066811E
		public IICenterTextTypeWriterT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
			this.TextCountPerSecond = 0;
		}
	}
}
