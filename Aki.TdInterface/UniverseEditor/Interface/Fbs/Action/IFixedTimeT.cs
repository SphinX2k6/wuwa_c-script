using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E52 RID: 28242
	public class IFixedTimeT
	{
		// Token: 0x1700CF07 RID: 52999
		// (get) Token: 0x06030C9D RID: 199837 RVA: 0x0069F054 File Offset: 0x0069D254
		// (set) Token: 0x06030C9E RID: 199838 RVA: 0x0069F05C File Offset: 0x0069D25C
		public int Hour { get; set; }

		// Token: 0x1700CF08 RID: 53000
		// (get) Token: 0x06030C9F RID: 199839 RVA: 0x0069F065 File Offset: 0x0069D265
		// (set) Token: 0x06030CA0 RID: 199840 RVA: 0x0069F06D File Offset: 0x0069D26D
		public int Minutes { get; set; }

		// Token: 0x06030CA1 RID: 199841 RVA: 0x0069F076 File Offset: 0x0069D276
		public IFixedTimeT()
		{
			this.Hour = 0;
			this.Minutes = 0;
		}
	}
}
