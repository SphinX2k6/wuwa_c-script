using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568C RID: 22156
	public class IElementalBoxFoundationComponentT
	{
		// Token: 0x17009F51 RID: 40785
		// (get) Token: 0x0602373B RID: 145211 RVA: 0x004E0732 File Offset: 0x004DE932
		// (set) Token: 0x0602373C RID: 145212 RVA: 0x004E073A File Offset: 0x004DE93A
		public bool Disabled { get; set; }

		// Token: 0x17009F52 RID: 40786
		// (get) Token: 0x0602373D RID: 145213 RVA: 0x004E0743 File Offset: 0x004DE943
		// (set) Token: 0x0602373E RID: 145214 RVA: 0x004E074B File Offset: 0x004DE94B
		public EElementalType ElementalType { get; set; }

		// Token: 0x17009F53 RID: 40787
		// (get) Token: 0x0602373F RID: 145215 RVA: 0x004E0754 File Offset: 0x004DE954
		// (set) Token: 0x06023740 RID: 145216 RVA: 0x004E075C File Offset: 0x004DE95C
		public int MaxCarryRange { get; set; }

		// Token: 0x17009F54 RID: 40788
		// (get) Token: 0x06023741 RID: 145217 RVA: 0x004E0765 File Offset: 0x004DE965
		// (set) Token: 0x06023742 RID: 145218 RVA: 0x004E076D File Offset: 0x004DE96D
		public int InitialActiveElementalBoxId { get; set; }

		// Token: 0x17009F55 RID: 40789
		// (get) Token: 0x06023743 RID: 145219 RVA: 0x004E0776 File Offset: 0x004DE976
		// (set) Token: 0x06023744 RID: 145220 RVA: 0x004E077E File Offset: 0x004DE97E
		public int LoopTeleportMappingFoundationId { get; set; }

		// Token: 0x17009F56 RID: 40790
		// (get) Token: 0x06023745 RID: 145221 RVA: 0x004E0787 File Offset: 0x004DE987
		// (set) Token: 0x06023746 RID: 145222 RVA: 0x004E078F File Offset: 0x004DE98F
		public List<IActionInfoT> OnObtainNucleusActions { get; set; }

		// Token: 0x17009F57 RID: 40791
		// (get) Token: 0x06023747 RID: 145223 RVA: 0x004E0798 File Offset: 0x004DE998
		// (set) Token: 0x06023748 RID: 145224 RVA: 0x004E07A0 File Offset: 0x004DE9A0
		public List<IActionInfoT> OnReturnNucleusActions { get; set; }

		// Token: 0x17009F58 RID: 40792
		// (get) Token: 0x06023749 RID: 145225 RVA: 0x004E07A9 File Offset: 0x004DE9A9
		// (set) Token: 0x0602374A RID: 145226 RVA: 0x004E07B1 File Offset: 0x004DE9B1
		public byte NullMask { get; set; }

		// Token: 0x0602374B RID: 145227 RVA: 0x004E07BA File Offset: 0x004DE9BA
		public IElementalBoxFoundationComponentT()
		{
			this.Disabled = false;
			this.ElementalType = EElementalType.Fire;
			this.MaxCarryRange = 0;
			this.InitialActiveElementalBoxId = 0;
			this.LoopTeleportMappingFoundationId = 0;
			this.OnObtainNucleusActions = null;
			this.OnReturnNucleusActions = null;
			this.NullMask = 0;
		}
	}
}
