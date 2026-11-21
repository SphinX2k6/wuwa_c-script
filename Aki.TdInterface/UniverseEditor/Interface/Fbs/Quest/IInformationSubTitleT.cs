using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E1 RID: 17121
	public class IInformationSubTitleT
	{
		// Token: 0x1700753F RID: 30015
		// (get) Token: 0x06018093 RID: 98451 RVA: 0x0036E20E File Offset: 0x0036C40E
		// (set) Token: 0x06018094 RID: 98452 RVA: 0x0036E216 File Offset: 0x0036C416
		public string TidTitle { get; set; }

		// Token: 0x17007540 RID: 30016
		// (get) Token: 0x06018095 RID: 98453 RVA: 0x0036E21F File Offset: 0x0036C41F
		// (set) Token: 0x06018096 RID: 98454 RVA: 0x0036E227 File Offset: 0x0036C427
		public string TidContent { get; set; }

		// Token: 0x06018097 RID: 98455 RVA: 0x0036E230 File Offset: 0x0036C430
		public IInformationSubTitleT()
		{
			this.TidTitle = null;
			this.TidContent = null;
		}
	}
}
