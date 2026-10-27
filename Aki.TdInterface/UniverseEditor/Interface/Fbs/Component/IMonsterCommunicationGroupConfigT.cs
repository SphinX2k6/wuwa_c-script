using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005570 RID: 21872
	public class IMonsterCommunicationGroupConfigT
	{
		// Token: 0x1700A192 RID: 41362
		// (get) Token: 0x060242EB RID: 148203 RVA: 0x004FF36E File Offset: 0x004FD56E
		// (set) Token: 0x060242EC RID: 148204 RVA: 0x004FF376 File Offset: 0x004FD576
		public int GroupId { get; set; }

		// Token: 0x060242ED RID: 148205 RVA: 0x004FF37F File Offset: 0x004FD57F
		public IMonsterCommunicationGroupConfigT()
		{
			this.GroupId = 0;
		}
	}
}
