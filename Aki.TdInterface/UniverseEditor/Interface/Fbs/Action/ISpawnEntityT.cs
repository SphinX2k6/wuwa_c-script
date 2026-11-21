using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200793C RID: 31036
	public class ISpawnEntityT
	{
		// Token: 0x1700E3A9 RID: 58281
		// (get) Token: 0x06036A89 RID: 223881 RVA: 0x00750621 File Offset: 0x0074E821
		// (set) Token: 0x06036A8A RID: 223882 RVA: 0x00750629 File Offset: 0x0074E829
		public int EntityDataId { get; set; }

		// Token: 0x1700E3AA RID: 58282
		// (get) Token: 0x06036A8B RID: 223883 RVA: 0x00750632 File Offset: 0x0074E832
		// (set) Token: 0x06036A8C RID: 223884 RVA: 0x0075063A File Offset: 0x0074E83A
		public ITransformT Transform { get; set; }

		// Token: 0x1700E3AB RID: 58283
		// (get) Token: 0x06036A8D RID: 223885 RVA: 0x00750643 File Offset: 0x0074E843
		// (set) Token: 0x06036A8E RID: 223886 RVA: 0x0075064B File Offset: 0x0074E84B
		public TVarRefUnion Save { get; set; }

		// Token: 0x06036A8F RID: 223887 RVA: 0x00750654 File Offset: 0x0074E854
		public ISpawnEntityT()
		{
			this.EntityDataId = 0;
			this.Transform = null;
			this.Save = null;
		}
	}
}
