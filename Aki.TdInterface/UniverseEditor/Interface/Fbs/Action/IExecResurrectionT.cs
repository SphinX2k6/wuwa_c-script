using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D92 RID: 28050
	public class IExecResurrectionT
	{
		// Token: 0x1700CDB8 RID: 52664
		// (get) Token: 0x06030697 RID: 198295 RVA: 0x0069403E File Offset: 0x0069223E
		// (set) Token: 0x06030698 RID: 198296 RVA: 0x00694046 File Offset: 0x00692246
		public int ReviveId { get; set; }

		// Token: 0x06030699 RID: 198297 RVA: 0x0069404F File Offset: 0x0069224F
		public IExecResurrectionT()
		{
			this.ReviveId = 0;
		}
	}
}
