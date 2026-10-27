using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200622B RID: 25131
	public class IBubbleCylinderConfigT
	{
		// Token: 0x1700BB42 RID: 47938
		// (get) Token: 0x0602B51E RID: 177438 RVA: 0x005F7174 File Offset: 0x005F5374
		// (set) Token: 0x0602B51F RID: 177439 RVA: 0x005F717C File Offset: 0x005F537C
		public float Radius { get; set; }

		// Token: 0x1700BB43 RID: 47939
		// (get) Token: 0x0602B520 RID: 177440 RVA: 0x005F7185 File Offset: 0x005F5385
		// (set) Token: 0x0602B521 RID: 177441 RVA: 0x005F718D File Offset: 0x005F538D
		public float Height { get; set; }

		// Token: 0x0602B522 RID: 177442 RVA: 0x005F7196 File Offset: 0x005F5396
		public IBubbleCylinderConfigT()
		{
			this.Radius = 0f;
			this.Height = 0f;
		}
	}
}
