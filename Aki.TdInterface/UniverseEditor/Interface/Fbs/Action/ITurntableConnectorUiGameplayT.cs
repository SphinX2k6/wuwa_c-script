using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C90 RID: 31888
	public class ITurntableConnectorUiGameplayT
	{
		// Token: 0x1700EECB RID: 61131
		// (get) Token: 0x06039833 RID: 235571 RVA: 0x007C359C File Offset: 0x007C179C
		// (set) Token: 0x06039834 RID: 235572 RVA: 0x007C35A4 File Offset: 0x007C17A4
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700EECC RID: 61132
		// (get) Token: 0x06039835 RID: 235573 RVA: 0x007C35AD File Offset: 0x007C17AD
		// (set) Token: 0x06039836 RID: 235574 RVA: 0x007C35B5 File Offset: 0x007C17B5
		public int EntityId { get; set; }

		// Token: 0x06039837 RID: 235575 RVA: 0x007C35BE File Offset: 0x007C17BE
		public ITurntableConnectorUiGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.EntityId = 0;
		}
	}
}
