using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E2B RID: 32299
	public class IWuWaGoGameT
	{
		// Token: 0x1700F1DC RID: 61916
		// (get) Token: 0x0603A5D9 RID: 239065 RVA: 0x007DC5B4 File Offset: 0x007DA7B4
		// (set) Token: 0x0603A5DA RID: 239066 RVA: 0x007DC5BC File Offset: 0x007DA7BC
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700F1DD RID: 61917
		// (get) Token: 0x0603A5DB RID: 239067 RVA: 0x007DC5C5 File Offset: 0x007DA7C5
		// (set) Token: 0x0603A5DC RID: 239068 RVA: 0x007DC5CD File Offset: 0x007DA7CD
		public int LevelCenterId { get; set; }

		// Token: 0x0603A5DD RID: 239069 RVA: 0x007DC5D6 File Offset: 0x007DA7D6
		public IWuWaGoGameT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.LevelCenterId = 0;
		}
	}
}
