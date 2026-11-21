using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B28 RID: 27432
	public class IConditionT
	{
		// Token: 0x1700C974 RID: 51572
		// (get) Token: 0x0602F32C RID: 193324 RVA: 0x0067215B File Offset: 0x0067035B
		// (set) Token: 0x0602F32D RID: 193325 RVA: 0x00672163 File Offset: 0x00670363
		public TVarValueUnion Var1 { get; set; }

		// Token: 0x1700C975 RID: 51573
		// (get) Token: 0x0602F32E RID: 193326 RVA: 0x0067216C File Offset: 0x0067036C
		// (set) Token: 0x0602F32F RID: 193327 RVA: 0x00672174 File Offset: 0x00670374
		public TVarValueUnion Var2 { get; set; }

		// Token: 0x1700C976 RID: 51574
		// (get) Token: 0x0602F330 RID: 193328 RVA: 0x0067217D File Offset: 0x0067037D
		// (set) Token: 0x0602F331 RID: 193329 RVA: 0x00672185 File Offset: 0x00670385
		public string Compare { get; set; }

		// Token: 0x0602F332 RID: 193330 RVA: 0x0067218E File Offset: 0x0067038E
		public IConditionT()
		{
			this.Var1 = null;
			this.Var2 = null;
			this.Compare = null;
		}
	}
}
