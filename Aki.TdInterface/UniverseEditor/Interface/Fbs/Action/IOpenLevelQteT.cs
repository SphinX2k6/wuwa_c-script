using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0D RID: 27661
	public class IOpenLevelQteT
	{
		// Token: 0x1700CDB9 RID: 52665
		// (get) Token: 0x06030A41 RID: 199233 RVA: 0x0069A6C7 File Offset: 0x006988C7
		// (set) Token: 0x06030A42 RID: 199234 RVA: 0x0069A6CF File Offset: 0x006988CF
		public EOpenQteType Type { get; set; }

		// Token: 0x1700CDBA RID: 52666
		// (get) Token: 0x06030A43 RID: 199235 RVA: 0x0069A6D8 File Offset: 0x006988D8
		// (set) Token: 0x06030A44 RID: 199236 RVA: 0x0069A6E0 File Offset: 0x006988E0
		public TTargetEntityUnion LevelQteEntity { get; set; }

		// Token: 0x06030A45 RID: 199237 RVA: 0x0069A6E9 File Offset: 0x006988E9
		public IOpenLevelQteT()
		{
			this.Type = EOpenQteType.PanelQte;
			this.LevelQteEntity = null;
		}
	}
}
