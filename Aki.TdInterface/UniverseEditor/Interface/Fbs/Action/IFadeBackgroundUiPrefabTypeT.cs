using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0D RID: 28173
	public class IFadeBackgroundUiPrefabTypeT
	{
		// Token: 0x1700CE79 RID: 52857
		// (get) Token: 0x06030A3F RID: 199231 RVA: 0x0069A49E File Offset: 0x0069869E
		// (set) Token: 0x06030A40 RID: 199232 RVA: 0x0069A4A6 File Offset: 0x006986A6
		public EFadeBackgroundUiPrefabType Type { get; set; }

		// Token: 0x06030A41 RID: 199233 RVA: 0x0069A4AF File Offset: 0x006986AF
		public IFadeBackgroundUiPrefabTypeT()
		{
			this.Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
		}
	}
}
