using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CDD RID: 19677
	public class ISystemStateConditonT
	{
		// Token: 0x17008ED8 RID: 36568
		// (get) Token: 0x0601F3BE RID: 127934 RVA: 0x0045C18F File Offset: 0x0045A38F
		// (set) Token: 0x0601F3BF RID: 127935 RVA: 0x0045C197 File Offset: 0x0045A397
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008ED9 RID: 36569
		// (get) Token: 0x0601F3C0 RID: 127936 RVA: 0x0045C1A0 File Offset: 0x0045A3A0
		// (set) Token: 0x0601F3C1 RID: 127937 RVA: 0x0045C1A8 File Offset: 0x0045A3A8
		public TCheckSystemStateUnion Config { get; set; }

		// Token: 0x0601F3C2 RID: 127938 RVA: 0x0045C1B1 File Offset: 0x0045A3B1
		public ISystemStateConditonT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Config = null;
		}
	}
}
