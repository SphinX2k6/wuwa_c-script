using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004338 RID: 17208
	public class ILevelPlayInformationT
	{
		// Token: 0x170075C5 RID: 30149
		// (get) Token: 0x06018369 RID: 99177 RVA: 0x00373A10 File Offset: 0x00371C10
		// (set) Token: 0x0601836A RID: 99178 RVA: 0x00373A18 File Offset: 0x00371C18
		public string TidMainTitle { get; set; }

		// Token: 0x170075C6 RID: 30150
		// (get) Token: 0x0601836B RID: 99179 RVA: 0x00373A21 File Offset: 0x00371C21
		// (set) Token: 0x0601836C RID: 99180 RVA: 0x00373A29 File Offset: 0x00371C29
		public List<IInformationSubTitleT> SubTitles { get; set; }

		// Token: 0x0601836D RID: 99181 RVA: 0x00373A32 File Offset: 0x00371C32
		public ILevelPlayInformationT()
		{
			this.TidMainTitle = null;
			this.SubTitles = null;
		}
	}
}
