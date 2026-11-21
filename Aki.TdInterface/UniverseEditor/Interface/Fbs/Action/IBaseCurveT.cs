using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684E RID: 26702
	public class IBaseCurveT
	{
		// Token: 0x1700C456 RID: 50262
		// (get) Token: 0x0602DA4E RID: 186958 RVA: 0x0063E875 File Offset: 0x0063CA75
		// (set) Token: 0x0602DA4F RID: 186959 RVA: 0x0063E87D File Offset: 0x0063CA7D
		public EBaseCurveType Type { get; set; }

		// Token: 0x1700C457 RID: 50263
		// (get) Token: 0x0602DA50 RID: 186960 RVA: 0x0063E886 File Offset: 0x0063CA86
		// (set) Token: 0x0602DA51 RID: 186961 RVA: 0x0063E88E File Offset: 0x0063CA8E
		public float N { get; set; }

		// Token: 0x1700C458 RID: 50264
		// (get) Token: 0x0602DA52 RID: 186962 RVA: 0x0063E897 File Offset: 0x0063CA97
		// (set) Token: 0x0602DA53 RID: 186963 RVA: 0x0063E89F File Offset: 0x0063CA9F
		public string CurveAsset { get; set; }

		// Token: 0x0602DA54 RID: 186964 RVA: 0x0063E8A8 File Offset: 0x0063CAA8
		public IBaseCurveT()
		{
			this.Type = EBaseCurveType.None;
			this.N = 0f;
			this.CurveAsset = null;
		}
	}
}
