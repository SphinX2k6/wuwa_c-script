using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678D RID: 26509
	public class IFadeBackgroundUiPrefabTypeT
	{
		// Token: 0x1700C4C3 RID: 50371
		// (get) Token: 0x0602E1F9 RID: 188921 RVA: 0x0064CD5A File Offset: 0x0064AF5A
		// (set) Token: 0x0602E1FA RID: 188922 RVA: 0x0064CD62 File Offset: 0x0064AF62
		public EFadeBackgroundUiPrefabType Type { get; set; }

		// Token: 0x0602E1FB RID: 188923 RVA: 0x0064CD6B File Offset: 0x0064AF6B
		public IFadeBackgroundUiPrefabTypeT()
		{
			this.Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
		}
	}
}
