using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589F RID: 22687
	public class IGraph3dNodeBaseT
	{
		// Token: 0x1700A46C RID: 42092
		// (get) Token: 0x06024CC6 RID: 150726 RVA: 0x0050D8FB File Offset: 0x0050BAFB
		// (set) Token: 0x06024CC7 RID: 150727 RVA: 0x0050D903 File Offset: 0x0050BB03
		public int Id { get; set; }

		// Token: 0x1700A46D RID: 42093
		// (get) Token: 0x06024CC8 RID: 150728 RVA: 0x0050D90C File Offset: 0x0050BB0C
		// (set) Token: 0x06024CC9 RID: 150729 RVA: 0x0050D914 File Offset: 0x0050BB14
		public IVectorInfoT Position { get; set; }

		// Token: 0x06024CCA RID: 150730 RVA: 0x0050D91D File Offset: 0x0050BB1D
		public IGraph3dNodeBaseT()
		{
			this.Id = 0;
			this.Position = null;
		}
	}
}
