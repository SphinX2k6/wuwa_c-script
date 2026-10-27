using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702F RID: 28719
	public class ISetNpcGroupPerformT
	{
		// Token: 0x1700D544 RID: 54596
		// (get) Token: 0x06032CE6 RID: 208102 RVA: 0x006DA933 File Offset: 0x006D8B33
		// (set) Token: 0x06032CE7 RID: 208103 RVA: 0x006DA93B File Offset: 0x006D8B3B
		public string Key { get; set; }

		// Token: 0x1700D545 RID: 54597
		// (get) Token: 0x06032CE8 RID: 208104 RVA: 0x006DA944 File Offset: 0x006D8B44
		// (set) Token: 0x06032CE9 RID: 208105 RVA: 0x006DA94C File Offset: 0x006D8B4C
		public TSetNpcGroupPerformTypeUnion PerformType { get; set; }

		// Token: 0x1700D546 RID: 54598
		// (get) Token: 0x06032CEA RID: 208106 RVA: 0x006DA955 File Offset: 0x006D8B55
		// (set) Token: 0x06032CEB RID: 208107 RVA: 0x006DA95D File Offset: 0x006D8B5D
		public bool IsWaitActionFinish { get; set; }

		// Token: 0x1700D547 RID: 54599
		// (get) Token: 0x06032CEC RID: 208108 RVA: 0x006DA966 File Offset: 0x006D8B66
		// (set) Token: 0x06032CED RID: 208109 RVA: 0x006DA96E File Offset: 0x006D8B6E
		public byte NullMask { get; set; }

		// Token: 0x06032CEE RID: 208110 RVA: 0x006DA977 File Offset: 0x006D8B77
		public ISetNpcGroupPerformT()
		{
			this.Key = null;
			this.PerformType = null;
			this.IsWaitActionFinish = false;
			this.NullMask = 0;
		}
	}
}
