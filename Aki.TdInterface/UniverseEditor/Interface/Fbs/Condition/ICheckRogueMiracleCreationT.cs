using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B12 RID: 19218
	public class ICheckRogueMiracleCreationT
	{
		// Token: 0x17008B6C RID: 35692
		// (get) Token: 0x0601E3A6 RID: 123814 RVA: 0x0043CEBC File Offset: 0x0043B0BC
		// (set) Token: 0x0601E3A7 RID: 123815 RVA: 0x0043CEC4 File Offset: 0x0043B0C4
		public ERogueStateType Type { get; set; }

		// Token: 0x17008B6D RID: 35693
		// (get) Token: 0x0601E3A8 RID: 123816 RVA: 0x0043CECD File Offset: 0x0043B0CD
		// (set) Token: 0x0601E3A9 RID: 123817 RVA: 0x0043CED5 File Offset: 0x0043B0D5
		public int Id { get; set; }

		// Token: 0x0601E3AA RID: 123818 RVA: 0x0043CEDE File Offset: 0x0043B0DE
		public ICheckRogueMiracleCreationT()
		{
			this.Type = ERogueStateType.Talent;
			this.Id = 0;
		}
	}
}
