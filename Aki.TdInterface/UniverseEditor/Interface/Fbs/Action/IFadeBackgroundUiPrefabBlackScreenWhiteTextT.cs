using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678A RID: 26506
	public class IFadeBackgroundUiPrefabBlackScreenWhiteTextT
	{
		// Token: 0x1700C4BD RID: 50365
		// (get) Token: 0x0602E1E1 RID: 188897 RVA: 0x0064CB6A File Offset: 0x0064AD6A
		// (set) Token: 0x0602E1E2 RID: 188898 RVA: 0x0064CB72 File Offset: 0x0064AD72
		public EFadeBackgroundUiPrefabType Type { get; set; }

		// Token: 0x1700C4BE RID: 50366
		// (get) Token: 0x0602E1E3 RID: 188899 RVA: 0x0064CB7B File Offset: 0x0064AD7B
		// (set) Token: 0x0602E1E4 RID: 188900 RVA: 0x0064CB83 File Offset: 0x0064AD83
		public EBlackScreenWhiteTextStartAnimName StartAnimName { get; set; }

		// Token: 0x1700C4BF RID: 50367
		// (get) Token: 0x0602E1E5 RID: 188901 RVA: 0x0064CB8C File Offset: 0x0064AD8C
		// (set) Token: 0x0602E1E6 RID: 188902 RVA: 0x0064CB94 File Offset: 0x0064AD94
		public string Text { get; set; }

		// Token: 0x1700C4C0 RID: 50368
		// (get) Token: 0x0602E1E7 RID: 188903 RVA: 0x0064CB9D File Offset: 0x0064AD9D
		// (set) Token: 0x0602E1E8 RID: 188904 RVA: 0x0064CBA5 File Offset: 0x0064ADA5
		public string AudioEvent { get; set; }

		// Token: 0x0602E1E9 RID: 188905 RVA: 0x0064CBAE File Offset: 0x0064ADAE
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT()
		{
			this.Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
			this.StartAnimName = EBlackScreenWhiteTextStartAnimName.Start01;
			this.Text = null;
			this.AudioEvent = null;
		}
	}
}
