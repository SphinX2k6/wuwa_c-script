using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004531 RID: 17713
	public class INoneRefreshT
	{
		// Token: 0x17007DA5 RID: 32165
		// (get) Token: 0x0601AA39 RID: 109113 RVA: 0x003CD3E2 File Offset: 0x003CB5E2
		// (set) Token: 0x0601AA3A RID: 109114 RVA: 0x003CD3EA File Offset: 0x003CB5EA
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x0601AA3B RID: 109115 RVA: 0x003CD3F3 File Offset: 0x003CB5F3
		public INoneRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
		}
	}
}
