using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C07 RID: 27655
	public class IOpenGreatSwordChallengeResultT
	{
		// Token: 0x1700CDAC RID: 52652
		// (get) Token: 0x060309FD RID: 199165 RVA: 0x00699B79 File Offset: 0x00697D79
		// (set) Token: 0x060309FE RID: 199166 RVA: 0x00699B81 File Offset: 0x00697D81
		public ESystemType Type { get; set; }

		// Token: 0x1700CDAD RID: 52653
		// (get) Token: 0x060309FF RID: 199167 RVA: 0x00699B8A File Offset: 0x00697D8A
		// (set) Token: 0x06030A00 RID: 199168 RVA: 0x00699B92 File Offset: 0x00697D92
		public int Id { get; set; }

		// Token: 0x1700CDAE RID: 52654
		// (get) Token: 0x06030A01 RID: 199169 RVA: 0x00699B9B File Offset: 0x00697D9B
		// (set) Token: 0x06030A02 RID: 199170 RVA: 0x00699BA3 File Offset: 0x00697DA3
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030A03 RID: 199171 RVA: 0x00699BAC File Offset: 0x00697DAC
		public IOpenGreatSwordChallengeResultT()
		{
			this.Type = ESystemType.Shop;
			this.Id = 0;
			this.ReturnVar = null;
		}
	}
}
