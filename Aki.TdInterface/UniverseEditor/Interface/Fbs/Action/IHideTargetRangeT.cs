using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690A RID: 26890
	public class IHideTargetRangeT
	{
		// Token: 0x1700C77F RID: 51071
		// (get) Token: 0x0602EECA RID: 192202 RVA: 0x00666635 File Offset: 0x00664835
		// (set) Token: 0x0602EECB RID: 192203 RVA: 0x0066663D File Offset: 0x0066483D
		public int RangeEntity { get; set; }

		// Token: 0x1700C780 RID: 51072
		// (get) Token: 0x0602EECC RID: 192204 RVA: 0x00666646 File Offset: 0x00664846
		// (set) Token: 0x0602EECD RID: 192205 RVA: 0x0066664E File Offset: 0x0066484E
		public THideRangeConfigUnion HideConfig { get; set; }

		// Token: 0x1700C781 RID: 51073
		// (get) Token: 0x0602EECE RID: 192206 RVA: 0x00666657 File Offset: 0x00664857
		// (set) Token: 0x0602EECF RID: 192207 RVA: 0x0066665F File Offset: 0x0066485F
		public bool IsHideSimpleNpc { get; set; }

		// Token: 0x1700C782 RID: 51074
		// (get) Token: 0x0602EED0 RID: 192208 RVA: 0x00666668 File Offset: 0x00664868
		// (set) Token: 0x0602EED1 RID: 192209 RVA: 0x00666670 File Offset: 0x00664870
		public bool IsHidePasserByNpc { get; set; }

		// Token: 0x1700C783 RID: 51075
		// (get) Token: 0x0602EED2 RID: 192210 RVA: 0x00666679 File Offset: 0x00664879
		// (set) Token: 0x0602EED3 RID: 192211 RVA: 0x00666681 File Offset: 0x00664881
		public byte NullMask { get; set; }

		// Token: 0x0602EED4 RID: 192212 RVA: 0x0066668A File Offset: 0x0066488A
		public IHideTargetRangeT()
		{
			this.RangeEntity = 0;
			this.HideConfig = null;
			this.IsHideSimpleNpc = false;
			this.IsHidePasserByNpc = false;
			this.NullMask = 0;
		}
	}
}
