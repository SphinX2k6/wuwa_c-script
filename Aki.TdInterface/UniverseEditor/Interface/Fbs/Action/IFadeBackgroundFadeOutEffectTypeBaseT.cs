using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006775 RID: 26485
	public class IFadeBackgroundFadeOutEffectTypeBaseT
	{
		// Token: 0x1700C499 RID: 50329
		// (get) Token: 0x0602E141 RID: 188737 RVA: 0x0064B912 File Offset: 0x00649B12
		// (set) Token: 0x0602E142 RID: 188738 RVA: 0x0064B91A File Offset: 0x00649B1A
		public EFadeBackgroundFadeOutEffectType Type { get; set; }

		// Token: 0x0602E143 RID: 188739 RVA: 0x0064B923 File Offset: 0x00649B23
		public IFadeBackgroundFadeOutEffectTypeBaseT()
		{
			this.Type = EFadeBackgroundFadeOutEffectType.Black;
		}
	}
}
