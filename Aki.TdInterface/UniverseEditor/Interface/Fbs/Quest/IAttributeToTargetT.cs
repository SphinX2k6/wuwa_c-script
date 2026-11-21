using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413A RID: 16698
	public class IAttributeToTargetT
	{
		// Token: 0x17007114 RID: 28948
		// (get) Token: 0x06016ED7 RID: 93911 RVA: 0x003458BA File Offset: 0x00343ABA
		// (set) Token: 0x06016ED8 RID: 93912 RVA: 0x003458C2 File Offset: 0x00343AC2
		public EAttributeToTarget Type { get; set; }

		// Token: 0x06016ED9 RID: 93913 RVA: 0x003458CB File Offset: 0x00343ACB
		public IAttributeToTargetT()
		{
			this.Type = EAttributeToTarget.Health;
		}
	}
}
