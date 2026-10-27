using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C19 RID: 27673
	public class IOpenQteActionT
	{
		// Token: 0x1700CDD4 RID: 52692
		// (get) Token: 0x06030AB9 RID: 199353 RVA: 0x0069B7D5 File Offset: 0x006999D5
		// (set) Token: 0x06030ABA RID: 199354 RVA: 0x0069B7DD File Offset: 0x006999DD
		public TOpenQteConfigUnion Config { get; set; }

		// Token: 0x06030ABB RID: 199355 RVA: 0x0069B7E6 File Offset: 0x006999E6
		public IOpenQteActionT()
		{
			this.Config = null;
		}
	}
}
