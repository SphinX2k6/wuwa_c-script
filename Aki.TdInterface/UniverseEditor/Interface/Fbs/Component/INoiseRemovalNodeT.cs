using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005609 RID: 22025
	public class INoiseRemovalNodeT
	{
		// Token: 0x1700A2FE RID: 41726
		// (get) Token: 0x060248DB RID: 149723 RVA: 0x0050B627 File Offset: 0x00509827
		// (set) Token: 0x060248DC RID: 149724 RVA: 0x0050B62F File Offset: 0x0050982F
		public ENoiseRemovalColor Color { get; set; }

		// Token: 0x1700A2FF RID: 41727
		// (get) Token: 0x060248DD RID: 149725 RVA: 0x0050B638 File Offset: 0x00509838
		// (set) Token: 0x060248DE RID: 149726 RVA: 0x0050B640 File Offset: 0x00509840
		public IVectorInfoT Position { get; set; }

		// Token: 0x060248DF RID: 149727 RVA: 0x0050B649 File Offset: 0x00509849
		public INoiseRemovalNodeT()
		{
			this.Color = ENoiseRemovalColor.Red;
			this.Position = null;
		}
	}
}
