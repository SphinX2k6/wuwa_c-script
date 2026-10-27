using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004640 RID: 17984
	public class ICustomTextGmT
	{
		// Token: 0x17007F9C RID: 32668
		// (get) Token: 0x0601B3DB RID: 111579 RVA: 0x003E0843 File Offset: 0x003DEA43
		// (set) Token: 0x0601B3DC RID: 111580 RVA: 0x003E084B File Offset: 0x003DEA4B
		public EGmCommand Type { get; set; }

		// Token: 0x17007F9D RID: 32669
		// (get) Token: 0x0601B3DD RID: 111581 RVA: 0x003E0854 File Offset: 0x003DEA54
		// (set) Token: 0x0601B3DE RID: 111582 RVA: 0x003E085C File Offset: 0x003DEA5C
		public string Text { get; set; }

		// Token: 0x0601B3DF RID: 111583 RVA: 0x003E0865 File Offset: 0x003DEA65
		public ICustomTextGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Text = null;
		}
	}
}
