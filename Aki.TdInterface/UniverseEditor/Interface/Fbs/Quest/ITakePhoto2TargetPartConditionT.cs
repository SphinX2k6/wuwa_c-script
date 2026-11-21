using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F3 RID: 17907
	public class ITakePhoto2TargetPartConditionT
	{
		// Token: 0x17007D4D RID: 32077
		// (get) Token: 0x0601A2D1 RID: 107217 RVA: 0x003BA845 File Offset: 0x003B8A45
		// (set) Token: 0x0601A2D2 RID: 107218 RVA: 0x003BA84D File Offset: 0x003B8A4D
		public List<string> Tags { get; set; }

		// Token: 0x0601A2D3 RID: 107219 RVA: 0x003BA856 File Offset: 0x003B8A56
		public ITakePhoto2TargetPartConditionT()
		{
			this.Tags = null;
		}
	}
}
