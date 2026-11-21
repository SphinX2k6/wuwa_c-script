using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E07 RID: 28167
	public class IFadeBackgroundUiPrefabT
	{
		// Token: 0x1700CE6C RID: 52844
		// (get) Token: 0x06030A09 RID: 199177 RVA: 0x00699F5B File Offset: 0x0069815B
		// (set) Token: 0x06030A0A RID: 199178 RVA: 0x00699F63 File Offset: 0x00698163
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x1700CE6D RID: 52845
		// (get) Token: 0x06030A0B RID: 199179 RVA: 0x00699F6C File Offset: 0x0069816C
		// (set) Token: 0x06030A0C RID: 199180 RVA: 0x00699F74 File Offset: 0x00698174
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT PrefabType { get; set; }

		// Token: 0x06030A0D RID: 199181 RVA: 0x00699F7D File Offset: 0x0069817D
		public IFadeBackgroundUiPrefabT()
		{
			this.Type = EFadeBackgroundType.Spine;
			this.PrefabType = null;
		}
	}
}
