using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B3F RID: 19263
	public class ICheckSystemFunctionT
	{
		// Token: 0x17008BC3 RID: 35779
		// (get) Token: 0x0601E51A RID: 124186 RVA: 0x0043F6AE File Offset: 0x0043D8AE
		// (set) Token: 0x0601E51B RID: 124187 RVA: 0x0043F6B6 File Offset: 0x0043D8B6
		public ECondition Type { get; set; }

		// Token: 0x17008BC4 RID: 35780
		// (get) Token: 0x0601E51C RID: 124188 RVA: 0x0043F6BF File Offset: 0x0043D8BF
		// (set) Token: 0x0601E51D RID: 124189 RVA: 0x0043F6C7 File Offset: 0x0043D8C7
		public int SystemId { get; set; }

		// Token: 0x17008BC5 RID: 35781
		// (get) Token: 0x0601E51E RID: 124190 RVA: 0x0043F6D0 File Offset: 0x0043D8D0
		// (set) Token: 0x0601E51F RID: 124191 RVA: 0x0043F6D8 File Offset: 0x0043D8D8
		public ECompare Compare { get; set; }

		// Token: 0x0601E520 RID: 124192 RVA: 0x0043F6E1 File Offset: 0x0043D8E1
		public ICheckSystemFunctionT()
		{
			this.Type = ECondition.CompareVar;
			this.SystemId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
