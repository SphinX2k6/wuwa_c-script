using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673D RID: 26429
	public class IActorLookAtEmptyDataT
	{
		// Token: 0x1700C021 RID: 49185
		// (get) Token: 0x0602CC7B RID: 183419 RVA: 0x00620352 File Offset: 0x0061E552
		// (set) Token: 0x0602CC7C RID: 183420 RVA: 0x0062035A File Offset: 0x0061E55A
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C022 RID: 49186
		// (get) Token: 0x0602CC7D RID: 183421 RVA: 0x00620363 File Offset: 0x0061E563
		// (set) Token: 0x0602CC7E RID: 183422 RVA: 0x0062036B File Offset: 0x0061E56B
		public bool Lock { get; set; }

		// Token: 0x1700C023 RID: 49187
		// (get) Token: 0x0602CC7F RID: 183423 RVA: 0x00620374 File Offset: 0x0061E574
		// (set) Token: 0x0602CC80 RID: 183424 RVA: 0x0062037C File Offset: 0x0061E57C
		public byte NullMask { get; set; }

		// Token: 0x0602CC81 RID: 183425 RVA: 0x00620385 File Offset: 0x0061E585
		public IActorLookAtEmptyDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}
