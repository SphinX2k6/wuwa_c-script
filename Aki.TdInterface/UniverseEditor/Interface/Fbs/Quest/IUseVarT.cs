using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425D RID: 16989
	public class IUseVarT
	{
		// Token: 0x170078A3 RID: 30883
		// (get) Token: 0x06019247 RID: 102983 RVA: 0x0039D3F7 File Offset: 0x0039B5F7
		// (set) Token: 0x06019248 RID: 102984 RVA: 0x0039D3FF File Offset: 0x0039B5FF
		public EProgressBarLeftType Type { get; set; }

		// Token: 0x170078A4 RID: 30884
		// (get) Token: 0x06019249 RID: 102985 RVA: 0x0039D408 File Offset: 0x0039B608
		// (set) Token: 0x0601924A RID: 102986 RVA: 0x0039D410 File Offset: 0x0039B610
		public TVarRefUnion Var { get; set; }

		// Token: 0x0601924B RID: 102987 RVA: 0x0039D419 File Offset: 0x0039B619
		public IUseVarT()
		{
			this.Type = EProgressBarLeftType.UseCount;
			this.Var = null;
		}
	}
}
