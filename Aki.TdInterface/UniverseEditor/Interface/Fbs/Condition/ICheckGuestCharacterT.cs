using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F06 RID: 20230
	public class ICheckGuestCharacterT
	{
		// Token: 0x17009077 RID: 36983
		// (get) Token: 0x0601F6D9 RID: 128729 RVA: 0x00460858 File Offset: 0x0045EA58
		// (set) Token: 0x0601F6DA RID: 128730 RVA: 0x00460860 File Offset: 0x0045EA60
		public ECondition Type { get; set; }

		// Token: 0x17009078 RID: 36984
		// (get) Token: 0x0601F6DB RID: 128731 RVA: 0x00460869 File Offset: 0x0045EA69
		// (set) Token: 0x0601F6DC RID: 128732 RVA: 0x00460871 File Offset: 0x0045EA71
		public int GuestCharacterId { get; set; }

		// Token: 0x0601F6DD RID: 128733 RVA: 0x0046087A File Offset: 0x0045EA7A
		public ICheckGuestCharacterT()
		{
			this.Type = ECondition.CompareVar;
			this.GuestCharacterId = 0;
		}
	}
}
