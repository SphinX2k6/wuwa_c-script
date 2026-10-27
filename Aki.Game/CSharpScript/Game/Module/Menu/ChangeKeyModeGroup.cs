using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053FD RID: 21501
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeGroup : IChangeKeyModeGroup
	{
		// Token: 0x1700841B RID: 33819
		// (get) Token: 0x06036F36 RID: 225078 RVA: 0x00D04ECF File Offset: 0x00D030CF
		// (set) Token: 0x06036F37 RID: 225079 RVA: 0x00D04ED7 File Offset: 0x00D030D7
		public string GroupName { get; set; } = "";

		// Token: 0x1700841C RID: 33820
		// (get) Token: 0x06036F38 RID: 225080 RVA: 0x00D04EE0 File Offset: 0x00D030E0
		// (set) Token: 0x06036F39 RID: 225081 RVA: 0x00D04EE8 File Offset: 0x00D030E8
		public int DefaultKeyModeRowIndex { get; set; }

		// Token: 0x1700841D RID: 33821
		// (get) Token: 0x06036F3A RID: 225082 RVA: 0x00D04EF1 File Offset: 0x00D030F1
		// (set) Token: 0x06036F3B RID: 225083 RVA: 0x00D04EF9 File Offset: 0x00D030F9
		public IChangeKeyModeRow[] ChangeKeyModeRowList { get; set; } = new IChangeKeyModeRow[0];
	}
}
