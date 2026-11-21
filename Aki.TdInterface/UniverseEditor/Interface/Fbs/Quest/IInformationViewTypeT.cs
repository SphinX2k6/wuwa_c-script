using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042ED RID: 17133
	public class IInformationViewTypeT
	{
		// Token: 0x17007552 RID: 30034
		// (get) Token: 0x060180EE RID: 98542 RVA: 0x0036EC12 File Offset: 0x0036CE12
		// (set) Token: 0x060180EF RID: 98543 RVA: 0x0036EC1A File Offset: 0x0036CE1A
		public EInformationViewType Type { get; set; }

		// Token: 0x060180F0 RID: 98544 RVA: 0x0036EC23 File Offset: 0x0036CE23
		public IInformationViewTypeT()
		{
			this.Type = EInformationViewType.LevelPlay;
		}
	}
}
