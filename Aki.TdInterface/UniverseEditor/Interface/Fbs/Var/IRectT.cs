using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ABB RID: 15035
	public class IRectT
	{
		// Token: 0x17006726 RID: 26406
		// (get) Token: 0x0601471E RID: 83742 RVA: 0x002FACB2 File Offset: 0x002F8EB2
		// (set) Token: 0x0601471F RID: 83743 RVA: 0x002FACBA File Offset: 0x002F8EBA
		public IVector2T Min { get; set; }

		// Token: 0x17006727 RID: 26407
		// (get) Token: 0x06014720 RID: 83744 RVA: 0x002FACC3 File Offset: 0x002F8EC3
		// (set) Token: 0x06014721 RID: 83745 RVA: 0x002FACCB File Offset: 0x002F8ECB
		public IVector2T Max { get; set; }

		// Token: 0x06014722 RID: 83746 RVA: 0x002FACD4 File Offset: 0x002F8ED4
		public IRectT()
		{
			this.Min = null;
			this.Max = null;
		}
	}
}
