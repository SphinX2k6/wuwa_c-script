using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761D RID: 30237
	public class IWuWaGoGameT
	{
		// Token: 0x1700E59E RID: 58782
		// (get) Token: 0x06037134 RID: 225588 RVA: 0x007784B8 File Offset: 0x007766B8
		// (set) Token: 0x06037135 RID: 225589 RVA: 0x007784C0 File Offset: 0x007766C0
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E59F RID: 58783
		// (get) Token: 0x06037136 RID: 225590 RVA: 0x007784C9 File Offset: 0x007766C9
		// (set) Token: 0x06037137 RID: 225591 RVA: 0x007784D1 File Offset: 0x007766D1
		public int LevelCenterId { get; set; }

		// Token: 0x06037138 RID: 225592 RVA: 0x007784DA File Offset: 0x007766DA
		public IWuWaGoGameT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.LevelCenterId = 0;
		}
	}
}
