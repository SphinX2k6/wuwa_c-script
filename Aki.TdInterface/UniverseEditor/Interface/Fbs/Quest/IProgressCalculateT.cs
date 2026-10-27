using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC3 RID: 16323
	public class IProgressCalculateT
	{
		// Token: 0x170071FB RID: 29179
		// (get) Token: 0x06017583 RID: 95619 RVA: 0x0035D693 File Offset: 0x0035B893
		// (set) Token: 0x06017584 RID: 95620 RVA: 0x0035D69B File Offset: 0x0035B89B
		public TProgressBarLeftTypeUnion VarLeft { get; set; }

		// Token: 0x170071FC RID: 29180
		// (get) Token: 0x06017585 RID: 95621 RVA: 0x0035D6A4 File Offset: 0x0035B8A4
		// (set) Token: 0x06017586 RID: 95622 RVA: 0x0035D6AC File Offset: 0x0035B8AC
		public TVarRefUnion VarRight { get; set; }

		// Token: 0x06017587 RID: 95623 RVA: 0x0035D6B5 File Offset: 0x0035B8B5
		public IProgressCalculateT()
		{
			this.VarLeft = null;
			this.VarRight = null;
		}
	}
}
