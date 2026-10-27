using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C9 RID: 26569
	public class IFishingRouletteT
	{
		// Token: 0x1700C537 RID: 50487
		// (get) Token: 0x0602E3FF RID: 189439 RVA: 0x00650E06 File Offset: 0x0064F006
		// (set) Token: 0x0602E400 RID: 189440 RVA: 0x00650E0E File Offset: 0x0064F00E
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x0602E401 RID: 189441 RVA: 0x00650E17 File Offset: 0x0064F017
		public IFishingRouletteT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
