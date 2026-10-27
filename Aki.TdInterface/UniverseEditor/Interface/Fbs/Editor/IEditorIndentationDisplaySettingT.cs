using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004860 RID: 18528
	public class IEditorIndentationDisplaySettingT
	{
		// Token: 0x1700856A RID: 34154
		// (get) Token: 0x0601CBE8 RID: 117736 RVA: 0x0041048A File Offset: 0x0040E68A
		// (set) Token: 0x0601CBE9 RID: 117737 RVA: 0x00410492 File Offset: 0x0040E692
		public bool EnabledShowStructureIndentLine { get; set; }

		// Token: 0x1700856B RID: 34155
		// (get) Token: 0x0601CBEA RID: 117738 RVA: 0x0041049B File Offset: 0x0040E69B
		// (set) Token: 0x0601CBEB RID: 117739 RVA: 0x004104A3 File Offset: 0x0040E6A3
		public bool EnabledShowStructureBlock { get; set; }

		// Token: 0x1700856C RID: 34156
		// (get) Token: 0x0601CBEC RID: 117740 RVA: 0x004104AC File Offset: 0x0040E6AC
		// (set) Token: 0x0601CBED RID: 117741 RVA: 0x004104B4 File Offset: 0x0040E6B4
		public bool EnabledShowArrayElementPrefixLine { get; set; }

		// Token: 0x1700856D RID: 34157
		// (get) Token: 0x0601CBEE RID: 117742 RVA: 0x004104BD File Offset: 0x0040E6BD
		// (set) Token: 0x0601CBEF RID: 117743 RVA: 0x004104C5 File Offset: 0x0040E6C5
		public float BaseGray { get; set; }

		// Token: 0x1700856E RID: 34158
		// (get) Token: 0x0601CBF0 RID: 117744 RVA: 0x004104CE File Offset: 0x0040E6CE
		// (set) Token: 0x0601CBF1 RID: 117745 RVA: 0x004104D6 File Offset: 0x0040E6D6
		public float MaxGray { get; set; }

		// Token: 0x1700856F RID: 34159
		// (get) Token: 0x0601CBF2 RID: 117746 RVA: 0x004104DF File Offset: 0x0040E6DF
		// (set) Token: 0x0601CBF3 RID: 117747 RVA: 0x004104E7 File Offset: 0x0040E6E7
		public int MaxDepth { get; set; }

		// Token: 0x17008570 RID: 34160
		// (get) Token: 0x0601CBF4 RID: 117748 RVA: 0x004104F0 File Offset: 0x0040E6F0
		// (set) Token: 0x0601CBF5 RID: 117749 RVA: 0x004104F8 File Offset: 0x0040E6F8
		public float SameLevelChangeStrength { get; set; }

		// Token: 0x0601CBF6 RID: 117750 RVA: 0x00410504 File Offset: 0x0040E704
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
