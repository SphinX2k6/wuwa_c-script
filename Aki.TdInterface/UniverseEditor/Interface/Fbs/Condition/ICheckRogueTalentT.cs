using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B1E RID: 19230
	public class ICheckRogueTalentT
	{
		// Token: 0x17008B7B RID: 35707
		// (get) Token: 0x0601E3F6 RID: 123894 RVA: 0x0043D6F8 File Offset: 0x0043B8F8
		// (set) Token: 0x0601E3F7 RID: 123895 RVA: 0x0043D700 File Offset: 0x0043B900
		public ERogueStateType Type { get; set; }

		// Token: 0x17008B7C RID: 35708
		// (get) Token: 0x0601E3F8 RID: 123896 RVA: 0x0043D709 File Offset: 0x0043B909
		// (set) Token: 0x0601E3F9 RID: 123897 RVA: 0x0043D711 File Offset: 0x0043B911
		public int Id { get; set; }

		// Token: 0x0601E3FA RID: 123898 RVA: 0x0043D71A File Offset: 0x0043B91A
		public ICheckRogueTalentT()
		{
			this.Type = ERogueStateType.Talent;
			this.Id = 0;
		}
	}
}
