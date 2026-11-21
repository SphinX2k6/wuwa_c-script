using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005074 RID: 20596
	public class IComparedAlertValueTypeT
	{
		// Token: 0x1700936E RID: 37742
		// (get) Token: 0x0602035C RID: 131932 RVA: 0x004770EA File Offset: 0x004752EA
		// (set) Token: 0x0602035D RID: 131933 RVA: 0x004770F2 File Offset: 0x004752F2
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x0602035E RID: 131934 RVA: 0x004770FB File Offset: 0x004752FB
		public IComparedAlertValueTypeT()
		{
			this.Type = EComparedAlertValueType.Min;
		}
	}
}
