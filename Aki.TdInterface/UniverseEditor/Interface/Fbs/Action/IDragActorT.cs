using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006607 RID: 26119
	public class IDragActorT
	{
		// Token: 0x1700C20F RID: 49679
		// (get) Token: 0x0602D59B RID: 185755 RVA: 0x0063717C File Offset: 0x0063537C
		// (set) Token: 0x0602D59C RID: 185756 RVA: 0x00637184 File Offset: 0x00635384
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C210 RID: 49680
		// (get) Token: 0x0602D59D RID: 185757 RVA: 0x0063718D File Offset: 0x0063538D
		// (set) Token: 0x0602D59E RID: 185758 RVA: 0x00637195 File Offset: 0x00635395
		public int TargetEntityId { get; set; }

		// Token: 0x0602D59F RID: 185759 RVA: 0x0063719E File Offset: 0x0063539E
		public IDragActorT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.TargetEntityId = 0;
		}
	}
}
