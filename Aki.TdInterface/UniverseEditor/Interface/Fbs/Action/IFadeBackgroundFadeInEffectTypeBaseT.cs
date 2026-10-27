using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006766 RID: 26470
	public class IFadeBackgroundFadeInEffectTypeBaseT
	{
		// Token: 0x1700C481 RID: 50305
		// (get) Token: 0x0602E0D1 RID: 188625 RVA: 0x0064AD5E File Offset: 0x00648F5E
		// (set) Token: 0x0602E0D2 RID: 188626 RVA: 0x0064AD66 File Offset: 0x00648F66
		public EFadeBackgroundFadeInEffectType Type { get; set; }

		// Token: 0x0602E0D3 RID: 188627 RVA: 0x0064AD6F File Offset: 0x00648F6F
		public IFadeBackgroundFadeInEffectTypeBaseT()
		{
			this.Type = EFadeBackgroundFadeInEffectType.Black;
		}
	}
}
