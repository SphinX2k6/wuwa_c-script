using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF9 RID: 20473
	public class ICheckRogueMiracleCreationT
	{
		// Token: 0x1700927C RID: 37500
		// (get) Token: 0x0601FF31 RID: 130865 RVA: 0x0046F668 File Offset: 0x0046D868
		// (set) Token: 0x0601FF32 RID: 130866 RVA: 0x0046F670 File Offset: 0x0046D870
		public ERogueStateType Type { get; set; }

		// Token: 0x1700927D RID: 37501
		// (get) Token: 0x0601FF33 RID: 130867 RVA: 0x0046F679 File Offset: 0x0046D879
		// (set) Token: 0x0601FF34 RID: 130868 RVA: 0x0046F681 File Offset: 0x0046D881
		public int Id { get; set; }

		// Token: 0x0601FF35 RID: 130869 RVA: 0x0046F68A File Offset: 0x0046D88A
		public ICheckRogueMiracleCreationT()
		{
			this.Type = ERogueStateType.Talent;
			this.Id = 0;
		}
	}
}
