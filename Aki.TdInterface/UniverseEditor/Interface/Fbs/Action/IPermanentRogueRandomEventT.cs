using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C97 RID: 27799
	public class IPermanentRogueRandomEventT
	{
		// Token: 0x1700CF04 RID: 52996
		// (get) Token: 0x06030FDD RID: 200669 RVA: 0x006A6AF9 File Offset: 0x006A4CF9
		// (set) Token: 0x06030FDE RID: 200670 RVA: 0x006A6B01 File Offset: 0x006A4D01
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700CF05 RID: 52997
		// (get) Token: 0x06030FDF RID: 200671 RVA: 0x006A6B0A File Offset: 0x006A4D0A
		// (set) Token: 0x06030FE0 RID: 200672 RVA: 0x006A6B12 File Offset: 0x006A4D12
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700CF06 RID: 52998
		// (get) Token: 0x06030FE1 RID: 200673 RVA: 0x006A6B1B File Offset: 0x006A4D1B
		// (set) Token: 0x06030FE2 RID: 200674 RVA: 0x006A6B23 File Offset: 0x006A4D23
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700CF07 RID: 52999
		// (get) Token: 0x06030FE3 RID: 200675 RVA: 0x006A6B2C File Offset: 0x006A4D2C
		// (set) Token: 0x06030FE4 RID: 200676 RVA: 0x006A6B34 File Offset: 0x006A4D34
		public int EventId { get; set; }

		// Token: 0x1700CF08 RID: 53000
		// (get) Token: 0x06030FE5 RID: 200677 RVA: 0x006A6B3D File Offset: 0x006A4D3D
		// (set) Token: 0x06030FE6 RID: 200678 RVA: 0x006A6B45 File Offset: 0x006A4D45
		public byte NullMask { get; set; }

		// Token: 0x06030FE7 RID: 200679 RVA: 0x006A6B4E File Offset: 0x006A4D4E
		public IPermanentRogueRandomEventT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.EventId = 0;
			this.NullMask = 0;
		}
	}
}
