using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9F RID: 28063
	public class IPreloadSubLevelsT
	{
		// Token: 0x1700D153 RID: 53587
		// (get) Token: 0x06031939 RID: 203065 RVA: 0x006B80A7 File Offset: 0x006B62A7
		// (set) Token: 0x0603193A RID: 203066 RVA: 0x006B80AF File Offset: 0x006B62AF
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x1700D154 RID: 53588
		// (get) Token: 0x0603193B RID: 203067 RVA: 0x006B80B8 File Offset: 0x006B62B8
		// (set) Token: 0x0603193C RID: 203068 RVA: 0x006B80C0 File Offset: 0x006B62C0
		public List<string> PreloadLevels { get; set; }

		// Token: 0x0603193D RID: 203069 RVA: 0x006B80C9 File Offset: 0x006B62C9
		public IPreloadSubLevelsT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
			this.PreloadLevels = null;
		}
	}
}
