using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A77 RID: 27255
	public class IMaxAlertValueT
	{
		// Token: 0x1700CA3A RID: 51770
		// (get) Token: 0x0602FBD5 RID: 195541 RVA: 0x0067EFEA File Offset: 0x0067D1EA
		// (set) Token: 0x0602FBD6 RID: 195542 RVA: 0x0067EFF2 File Offset: 0x0067D1F2
		public EValueChangeType Type { get; set; }

		// Token: 0x0602FBD7 RID: 195543 RVA: 0x0067EFFB File Offset: 0x0067D1FB
		public IMaxAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
