using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED3 RID: 28371
	public class IFocusOnQuestMapMarkT
	{
		// Token: 0x1700D017 RID: 53271
		// (get) Token: 0x06031169 RID: 201065 RVA: 0x006A7F44 File Offset: 0x006A6144
		// (set) Token: 0x0603116A RID: 201066 RVA: 0x006A7F4C File Offset: 0x006A614C
		public EMapMarkType Type { get; set; }

		// Token: 0x1700D018 RID: 53272
		// (get) Token: 0x0603116B RID: 201067 RVA: 0x006A7F55 File Offset: 0x006A6155
		// (set) Token: 0x0603116C RID: 201068 RVA: 0x006A7F5D File Offset: 0x006A615D
		public int QuestId { get; set; }

		// Token: 0x0603116D RID: 201069 RVA: 0x006A7F66 File Offset: 0x006A6166
		public IFocusOnQuestMapMarkT()
		{
			this.Type = EMapMarkType.Custom;
			this.QuestId = 0;
		}
	}
}
