using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062CA RID: 25290
	public class IChangeActorTalkerT
	{
		// Token: 0x1700BCC8 RID: 48328
		// (get) Token: 0x0602BB5D RID: 179037 RVA: 0x00603E74 File Offset: 0x00602074
		// (set) Token: 0x0602BB5E RID: 179038 RVA: 0x00603E7C File Offset: 0x0060207C
		public int ActorIndex { get; set; }

		// Token: 0x1700BCC9 RID: 48329
		// (get) Token: 0x0602BB5F RID: 179039 RVA: 0x00603E85 File Offset: 0x00602085
		// (set) Token: 0x0602BB60 RID: 179040 RVA: 0x00603E8D File Offset: 0x0060208D
		public int Talker { get; set; }

		// Token: 0x0602BB61 RID: 179041 RVA: 0x00603E96 File Offset: 0x00602096
		public IChangeActorTalkerT()
		{
			this.ActorIndex = 0;
			this.Talker = 0;
		}
	}
}
