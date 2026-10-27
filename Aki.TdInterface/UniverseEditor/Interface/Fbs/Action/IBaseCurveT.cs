using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E0 RID: 25056
	public class IBaseCurveT
	{
		// Token: 0x1700BAD3 RID: 47827
		// (get) Token: 0x0602B307 RID: 176903 RVA: 0x005F3E01 File Offset: 0x005F2001
		// (set) Token: 0x0602B308 RID: 176904 RVA: 0x005F3E09 File Offset: 0x005F2009
		public EBaseCurveType Type { get; set; }

		// Token: 0x1700BAD4 RID: 47828
		// (get) Token: 0x0602B309 RID: 176905 RVA: 0x005F3E12 File Offset: 0x005F2012
		// (set) Token: 0x0602B30A RID: 176906 RVA: 0x005F3E1A File Offset: 0x005F201A
		public float N { get; set; }

		// Token: 0x1700BAD5 RID: 47829
		// (get) Token: 0x0602B30B RID: 176907 RVA: 0x005F3E23 File Offset: 0x005F2023
		// (set) Token: 0x0602B30C RID: 176908 RVA: 0x005F3E2B File Offset: 0x005F202B
		public string CurveAsset { get; set; }

		// Token: 0x0602B30D RID: 176909 RVA: 0x005F3E34 File Offset: 0x005F2034
		public IBaseCurveT()
		{
			this.Type = EBaseCurveType.None;
			this.N = 0f;
			this.CurveAsset = null;
		}
	}
}
