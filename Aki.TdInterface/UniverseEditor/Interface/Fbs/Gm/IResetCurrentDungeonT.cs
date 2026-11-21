using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AED RID: 19181
	public class IResetCurrentDungeonT
	{
		// Token: 0x17008670 RID: 34416
		// (get) Token: 0x0601CE62 RID: 118370 RVA: 0x0041136E File Offset: 0x0040F56E
		// (set) Token: 0x0601CE63 RID: 118371 RVA: 0x00411376 File Offset: 0x0040F576
		public EGmCommand Type { get; set; }

		// Token: 0x0601CE64 RID: 118372 RVA: 0x0041137F File Offset: 0x0040F57F
		public IResetCurrentDungeonT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
