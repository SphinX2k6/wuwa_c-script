using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553A RID: 21818
	public class IMechascoutJavelinTriggerConfigT
	{
		// Token: 0x1700A113 RID: 41235
		// (get) Token: 0x060240C9 RID: 147657 RVA: 0x004FAE2A File Offset: 0x004F902A
		// (set) Token: 0x060240CA RID: 147658 RVA: 0x004FAE32 File Offset: 0x004F9032
		public ETeleCtrlTriggerType Type { get; set; }

		// Token: 0x060240CB RID: 147659 RVA: 0x004FAE3B File Offset: 0x004F903B
		public IMechascoutJavelinTriggerConfigT()
		{
			this.Type = ETeleCtrlTriggerType.MechascoutJavelin;
		}
	}
}
