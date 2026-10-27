using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E0 RID: 21728
	public class ILevelPlayComponentT
	{
		// Token: 0x1700A039 RID: 41017
		// (get) Token: 0x06023D50 RID: 146768 RVA: 0x004F42B6 File Offset: 0x004F24B6
		// (set) Token: 0x06023D51 RID: 146769 RVA: 0x004F42BE File Offset: 0x004F24BE
		public bool Disabled { get; set; }

		// Token: 0x1700A03A RID: 41018
		// (get) Token: 0x06023D52 RID: 146770 RVA: 0x004F42C7 File Offset: 0x004F24C7
		// (set) Token: 0x06023D53 RID: 146771 RVA: 0x004F42CF File Offset: 0x004F24CF
		public int LevelPlayId { get; set; }

		// Token: 0x1700A03B RID: 41019
		// (get) Token: 0x06023D54 RID: 146772 RVA: 0x004F42D8 File Offset: 0x004F24D8
		// (set) Token: 0x06023D55 RID: 146773 RVA: 0x004F42E0 File Offset: 0x004F24E0
		public byte NullMask { get; set; }

		// Token: 0x06023D56 RID: 146774 RVA: 0x004F42E9 File Offset: 0x004F24E9
		public ILevelPlayComponentT()
		{
			this.Disabled = false;
			this.LevelPlayId = 0;
			this.NullMask = 0;
		}
	}
}
