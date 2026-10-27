using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F09 RID: 16137
	public class ILinkSystemConfigT
	{
		// Token: 0x17006FEF RID: 28655
		// (get) Token: 0x06016D8E RID: 93582 RVA: 0x0034B5C8 File Offset: 0x003497C8
		// (set) Token: 0x06016D8F RID: 93583 RVA: 0x0034B5D0 File Offset: 0x003497D0
		public EEnableSystemType Type { get; set; }

		// Token: 0x17006FF0 RID: 28656
		// (get) Token: 0x06016D90 RID: 93584 RVA: 0x0034B5D9 File Offset: 0x003497D9
		// (set) Token: 0x06016D91 RID: 93585 RVA: 0x0034B5E1 File Offset: 0x003497E1
		public int LinkDataId { get; set; }

		// Token: 0x06016D92 RID: 93586 RVA: 0x0034B5EA File Offset: 0x003497EA
		public ILinkSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.LinkDataId = 0;
		}
	}
}
