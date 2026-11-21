using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC8 RID: 19656
	public class IEditorIndentationDisplaySettingT
	{
		// Token: 0x17008BB9 RID: 35769
		// (get) Token: 0x0601E3EF RID: 123887 RVA: 0x0043CF36 File Offset: 0x0043B136
		// (set) Token: 0x0601E3F0 RID: 123888 RVA: 0x0043CF3E File Offset: 0x0043B13E
		public bool EnabledShowStructureIndentLine { get; set; }

		// Token: 0x17008BBA RID: 35770
		// (get) Token: 0x0601E3F1 RID: 123889 RVA: 0x0043CF47 File Offset: 0x0043B147
		// (set) Token: 0x0601E3F2 RID: 123890 RVA: 0x0043CF4F File Offset: 0x0043B14F
		public bool EnabledShowStructureBlock { get; set; }

		// Token: 0x17008BBB RID: 35771
		// (get) Token: 0x0601E3F3 RID: 123891 RVA: 0x0043CF58 File Offset: 0x0043B158
		// (set) Token: 0x0601E3F4 RID: 123892 RVA: 0x0043CF60 File Offset: 0x0043B160
		public bool EnabledShowArrayElementPrefixLine { get; set; }

		// Token: 0x17008BBC RID: 35772
		// (get) Token: 0x0601E3F5 RID: 123893 RVA: 0x0043CF69 File Offset: 0x0043B169
		// (set) Token: 0x0601E3F6 RID: 123894 RVA: 0x0043CF71 File Offset: 0x0043B171
		public float BaseGray { get; set; }

		// Token: 0x17008BBD RID: 35773
		// (get) Token: 0x0601E3F7 RID: 123895 RVA: 0x0043CF7A File Offset: 0x0043B17A
		// (set) Token: 0x0601E3F8 RID: 123896 RVA: 0x0043CF82 File Offset: 0x0043B182
		public float MaxGray { get; set; }

		// Token: 0x17008BBE RID: 35774
		// (get) Token: 0x0601E3F9 RID: 123897 RVA: 0x0043CF8B File Offset: 0x0043B18B
		// (set) Token: 0x0601E3FA RID: 123898 RVA: 0x0043CF93 File Offset: 0x0043B193
		public int MaxDepth { get; set; }

		// Token: 0x17008BBF RID: 35775
		// (get) Token: 0x0601E3FB RID: 123899 RVA: 0x0043CF9C File Offset: 0x0043B19C
		// (set) Token: 0x0601E3FC RID: 123900 RVA: 0x0043CFA4 File Offset: 0x0043B1A4
		public float SameLevelChangeStrength { get; set; }

		// Token: 0x0601E3FD RID: 123901 RVA: 0x0043CFB0 File Offset: 0x0043B1B0
		public IEditorIndentationDisplaySettingT()
		{
			this.EnabledShowStructureIndentLine = false;
			this.EnabledShowStructureBlock = false;
			this.EnabledShowArrayElementPrefixLine = false;
			this.BaseGray = 0f;
			this.MaxGray = 0f;
			this.MaxDepth = 0;
			this.SameLevelChangeStrength = 0f;
		}
	}
}
