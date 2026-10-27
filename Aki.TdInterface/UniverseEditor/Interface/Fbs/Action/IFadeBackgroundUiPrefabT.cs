using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006787 RID: 26503
	public class IFadeBackgroundUiPrefabT
	{
		// Token: 0x1700C4B6 RID: 50358
		// (get) Token: 0x0602E1C3 RID: 188867 RVA: 0x0064C817 File Offset: 0x0064AA17
		// (set) Token: 0x0602E1C4 RID: 188868 RVA: 0x0064C81F File Offset: 0x0064AA1F
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x1700C4B7 RID: 50359
		// (get) Token: 0x0602E1C5 RID: 188869 RVA: 0x0064C828 File Offset: 0x0064AA28
		// (set) Token: 0x0602E1C6 RID: 188870 RVA: 0x0064C830 File Offset: 0x0064AA30
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT PrefabType { get; set; }

		// Token: 0x0602E1C7 RID: 188871 RVA: 0x0064C839 File Offset: 0x0064AA39
		public IFadeBackgroundUiPrefabT()
		{
			this.Type = EFadeBackgroundType.Spine;
			this.PrefabType = null;
		}
	}
}
