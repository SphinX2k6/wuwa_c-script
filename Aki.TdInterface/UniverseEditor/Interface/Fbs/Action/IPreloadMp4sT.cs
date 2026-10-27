using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D99 RID: 28057
	public class IPreloadMp4sT
	{
		// Token: 0x1700D149 RID: 53577
		// (get) Token: 0x06031907 RID: 203015 RVA: 0x006B7B67 File Offset: 0x006B5D67
		// (set) Token: 0x06031908 RID: 203016 RVA: 0x006B7B6F File Offset: 0x006B5D6F
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700D14A RID: 53578
		// (get) Token: 0x06031909 RID: 203017 RVA: 0x006B7B78 File Offset: 0x006B5D78
		// (set) Token: 0x0603190A RID: 203018 RVA: 0x006B7B80 File Offset: 0x006B5D80
		public List<string> Mp4s { get; set; }

		// Token: 0x0603190B RID: 203019 RVA: 0x006B7B89 File Offset: 0x006B5D89
		public IPreloadMp4sT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.Mp4s = null;
		}
	}
}
