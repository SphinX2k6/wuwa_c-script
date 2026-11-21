using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0A RID: 28170
	public class IFadeBackgroundUiPrefabBlackScreenWhiteTextT
	{
		// Token: 0x1700CE73 RID: 52851
		// (get) Token: 0x06030A27 RID: 199207 RVA: 0x0069A2AE File Offset: 0x006984AE
		// (set) Token: 0x06030A28 RID: 199208 RVA: 0x0069A2B6 File Offset: 0x006984B6
		public EFadeBackgroundUiPrefabType Type { get; set; }

		// Token: 0x1700CE74 RID: 52852
		// (get) Token: 0x06030A29 RID: 199209 RVA: 0x0069A2BF File Offset: 0x006984BF
		// (set) Token: 0x06030A2A RID: 199210 RVA: 0x0069A2C7 File Offset: 0x006984C7
		public EBlackScreenWhiteTextStartAnimName StartAnimName { get; set; }

		// Token: 0x1700CE75 RID: 52853
		// (get) Token: 0x06030A2B RID: 199211 RVA: 0x0069A2D0 File Offset: 0x006984D0
		// (set) Token: 0x06030A2C RID: 199212 RVA: 0x0069A2D8 File Offset: 0x006984D8
		public string Text { get; set; }

		// Token: 0x1700CE76 RID: 52854
		// (get) Token: 0x06030A2D RID: 199213 RVA: 0x0069A2E1 File Offset: 0x006984E1
		// (set) Token: 0x06030A2E RID: 199214 RVA: 0x0069A2E9 File Offset: 0x006984E9
		public string AudioEvent { get; set; }

		// Token: 0x06030A2F RID: 199215 RVA: 0x0069A2F2 File Offset: 0x006984F2
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT()
		{
			this.Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
			this.StartAnimName = EBlackScreenWhiteTextStartAnimName.Start01;
			this.Text = null;
			this.AudioEvent = null;
		}
	}
}
