using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A45 RID: 27205
	public class ILongPressInteractStyleConfigDefaultT
	{
		// Token: 0x1700C9DA RID: 51674
		// (get) Token: 0x0602FA28 RID: 195112 RVA: 0x0067BEE2 File Offset: 0x0067A0E2
		// (set) Token: 0x0602FA29 RID: 195113 RVA: 0x0067BEEA File Offset: 0x0067A0EA
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x0602FA2A RID: 195114 RVA: 0x0067BEF3 File Offset: 0x0067A0F3
		public ILongPressInteractStyleConfigDefaultT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}
