using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004410 RID: 17424
	public class ILevelsConfigT
	{
		// Token: 0x17007AF0 RID: 31472
		// (get) Token: 0x06019F2E RID: 106286 RVA: 0x003B6121 File Offset: 0x003B4321
		// (set) Token: 0x06019F2F RID: 106287 RVA: 0x003B6129 File Offset: 0x003B4329
		public List<ILevelConfigT> Levels { get; set; }

		// Token: 0x06019F30 RID: 106288 RVA: 0x003B6132 File Offset: 0x003B4332
		public ILevelsConfigT()
		{
			this.Levels = null;
		}
	}
}
