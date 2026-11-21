using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA7 RID: 23463
	public class INoiseRemovalNodeT
	{
		// Token: 0x1700AB86 RID: 43910
		// (get) Token: 0x06026AEB RID: 158443 RVA: 0x0054BC3F File Offset: 0x00549E3F
		// (set) Token: 0x06026AEC RID: 158444 RVA: 0x0054BC47 File Offset: 0x00549E47
		public ENoiseRemovalColor Color { get; set; }

		// Token: 0x1700AB87 RID: 43911
		// (get) Token: 0x06026AED RID: 158445 RVA: 0x0054BC50 File Offset: 0x00549E50
		// (set) Token: 0x06026AEE RID: 158446 RVA: 0x0054BC58 File Offset: 0x00549E58
		public IVectorInfoT Position { get; set; }

		// Token: 0x06026AEF RID: 158447 RVA: 0x0054BC61 File Offset: 0x00549E61
		public INoiseRemovalNodeT()
		{
			this.Color = ENoiseRemovalColor.Red;
			this.Position = null;
		}
	}
}
