using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005737 RID: 22327
	public class IExhibitEffectT
	{
		// Token: 0x1700A13E RID: 41278
		// (get) Token: 0x06023ED4 RID: 147156 RVA: 0x004F062D File Offset: 0x004EE82D
		// (set) Token: 0x06023ED5 RID: 147157 RVA: 0x004F0635 File Offset: 0x004EE835
		public string Path { get; set; }

		// Token: 0x1700A13F RID: 41279
		// (get) Token: 0x06023ED6 RID: 147158 RVA: 0x004F063E File Offset: 0x004EE83E
		// (set) Token: 0x06023ED7 RID: 147159 RVA: 0x004F0646 File Offset: 0x004EE846
		public float Scale { get; set; }

		// Token: 0x1700A140 RID: 41280
		// (get) Token: 0x06023ED8 RID: 147160 RVA: 0x004F064F File Offset: 0x004EE84F
		// (set) Token: 0x06023ED9 RID: 147161 RVA: 0x004F0657 File Offset: 0x004EE857
		public IVectorInfoT Offset { get; set; }

		// Token: 0x06023EDA RID: 147162 RVA: 0x004F0660 File Offset: 0x004EE860
		public IExhibitEffectT()
		{
			this.Path = null;
			this.Scale = 0f;
			this.Offset = null;
		}
	}
}
