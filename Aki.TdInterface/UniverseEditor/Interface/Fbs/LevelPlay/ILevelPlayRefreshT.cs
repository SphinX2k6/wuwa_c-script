using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200450D RID: 17677
	public class ILevelPlayRefreshT
	{
		// Token: 0x17007D57 RID: 32087
		// (get) Token: 0x0601A903 RID: 108803 RVA: 0x003CB33E File Offset: 0x003C953E
		// (set) Token: 0x0601A904 RID: 108804 RVA: 0x003CB346 File Offset: 0x003C9546
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x0601A905 RID: 108805 RVA: 0x003CB34F File Offset: 0x003C954F
		public ILevelPlayRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
		}
	}
}
