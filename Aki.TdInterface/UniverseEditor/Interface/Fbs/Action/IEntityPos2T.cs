using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D68 RID: 28008
	public class IEntityPos2T
	{
		// Token: 0x1700CD7A RID: 52602
		// (get) Token: 0x06030528 RID: 197928 RVA: 0x006910F9 File Offset: 0x0068F2F9
		// (set) Token: 0x06030529 RID: 197929 RVA: 0x00691101 File Offset: 0x0068F301
		public EPos2 Type { get; set; }

		// Token: 0x1700CD7B RID: 52603
		// (get) Token: 0x0603052A RID: 197930 RVA: 0x0069110A File Offset: 0x0068F30A
		// (set) Token: 0x0603052B RID: 197931 RVA: 0x00691112 File Offset: 0x0068F312
		public int EntityId { get; set; }

		// Token: 0x1700CD7C RID: 52604
		// (get) Token: 0x0603052C RID: 197932 RVA: 0x0069111B File Offset: 0x0068F31B
		// (set) Token: 0x0603052D RID: 197933 RVA: 0x00691123 File Offset: 0x0068F323
		public IVectorInfoT Offset { get; set; }

		// Token: 0x0603052E RID: 197934 RVA: 0x0069112C File Offset: 0x0068F32C
		public IEntityPos2T()
		{
			this.Type = EPos2.Player;
			this.EntityId = 0;
			this.Offset = null;
		}
	}
}
