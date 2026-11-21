using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E49 RID: 28233
	public class IFishingRouletteT
	{
		// Token: 0x1700CEED RID: 52973
		// (get) Token: 0x06030C45 RID: 199749 RVA: 0x0069E54A File Offset: 0x0069C74A
		// (set) Token: 0x06030C46 RID: 199750 RVA: 0x0069E552 File Offset: 0x0069C752
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x06030C47 RID: 199751 RVA: 0x0069E55B File Offset: 0x0069C75B
		public IFishingRouletteT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
