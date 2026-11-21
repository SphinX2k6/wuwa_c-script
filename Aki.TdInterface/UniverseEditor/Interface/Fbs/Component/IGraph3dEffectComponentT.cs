using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589C RID: 22684
	public class IGraph3dEffectComponentT
	{
		// Token: 0x1700A465 RID: 42085
		// (get) Token: 0x06024CAC RID: 150700 RVA: 0x0050D61F File Offset: 0x0050B81F
		// (set) Token: 0x06024CAD RID: 150701 RVA: 0x0050D627 File Offset: 0x0050B827
		public bool Disabled { get; set; }

		// Token: 0x1700A466 RID: 42086
		// (get) Token: 0x06024CAE RID: 150702 RVA: 0x0050D630 File Offset: 0x0050B830
		// (set) Token: 0x06024CAF RID: 150703 RVA: 0x0050D638 File Offset: 0x0050B838
		public int Graph3dEntityId { get; set; }

		// Token: 0x1700A467 RID: 42087
		// (get) Token: 0x06024CB0 RID: 150704 RVA: 0x0050D641 File Offset: 0x0050B841
		// (set) Token: 0x06024CB1 RID: 150705 RVA: 0x0050D649 File Offset: 0x0050B849
		public IFireBoxFishEffectT EffectType { get; set; }

		// Token: 0x1700A468 RID: 42088
		// (get) Token: 0x06024CB2 RID: 150706 RVA: 0x0050D652 File Offset: 0x0050B852
		// (set) Token: 0x06024CB3 RID: 150707 RVA: 0x0050D65A File Offset: 0x0050B85A
		public byte NullMask { get; set; }

		// Token: 0x06024CB4 RID: 150708 RVA: 0x0050D663 File Offset: 0x0050B863
		public IGraph3dEffectComponentT()
		{
			this.Disabled = false;
			this.Graph3dEntityId = 0;
			this.EffectType = null;
			this.NullMask = 0;
		}
	}
}
