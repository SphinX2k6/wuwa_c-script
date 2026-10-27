using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E7 RID: 24807
	public class IActorLookAtPlayerDataT
	{
		// Token: 0x1700B6D6 RID: 46806
		// (get) Token: 0x0602A60A RID: 173578 RVA: 0x005D6F0A File Offset: 0x005D510A
		// (set) Token: 0x0602A60B RID: 173579 RVA: 0x005D6F12 File Offset: 0x005D5112
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700B6D7 RID: 46807
		// (get) Token: 0x0602A60C RID: 173580 RVA: 0x005D6F1B File Offset: 0x005D511B
		// (set) Token: 0x0602A60D RID: 173581 RVA: 0x005D6F23 File Offset: 0x005D5123
		public bool Lock { get; set; }

		// Token: 0x1700B6D8 RID: 46808
		// (get) Token: 0x0602A60E RID: 173582 RVA: 0x005D6F2C File Offset: 0x005D512C
		// (set) Token: 0x0602A60F RID: 173583 RVA: 0x005D6F34 File Offset: 0x005D5134
		public byte NullMask { get; set; }

		// Token: 0x0602A610 RID: 173584 RVA: 0x005D6F3D File Offset: 0x005D513D
		public IActorLookAtPlayerDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}
