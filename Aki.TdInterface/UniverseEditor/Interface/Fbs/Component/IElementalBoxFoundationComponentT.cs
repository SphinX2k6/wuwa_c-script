using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005127 RID: 20775
	public class IElementalBoxFoundationComponentT
	{
		// Token: 0x17009764 RID: 38756
		// (get) Token: 0x060217E7 RID: 137191 RVA: 0x004A67A6 File Offset: 0x004A49A6
		// (set) Token: 0x060217E8 RID: 137192 RVA: 0x004A67AE File Offset: 0x004A49AE
		public bool Disabled { get; set; }

		// Token: 0x17009765 RID: 38757
		// (get) Token: 0x060217E9 RID: 137193 RVA: 0x004A67B7 File Offset: 0x004A49B7
		// (set) Token: 0x060217EA RID: 137194 RVA: 0x004A67BF File Offset: 0x004A49BF
		public EElementalType ElementalType { get; set; }

		// Token: 0x17009766 RID: 38758
		// (get) Token: 0x060217EB RID: 137195 RVA: 0x004A67C8 File Offset: 0x004A49C8
		// (set) Token: 0x060217EC RID: 137196 RVA: 0x004A67D0 File Offset: 0x004A49D0
		public int MaxCarryRange { get; set; }

		// Token: 0x17009767 RID: 38759
		// (get) Token: 0x060217ED RID: 137197 RVA: 0x004A67D9 File Offset: 0x004A49D9
		// (set) Token: 0x060217EE RID: 137198 RVA: 0x004A67E1 File Offset: 0x004A49E1
		public int InitialActiveElementalBoxId { get; set; }

		// Token: 0x17009768 RID: 38760
		// (get) Token: 0x060217EF RID: 137199 RVA: 0x004A67EA File Offset: 0x004A49EA
		// (set) Token: 0x060217F0 RID: 137200 RVA: 0x004A67F2 File Offset: 0x004A49F2
		public int LoopTeleportMappingFoundationId { get; set; }

		// Token: 0x17009769 RID: 38761
		// (get) Token: 0x060217F1 RID: 137201 RVA: 0x004A67FB File Offset: 0x004A49FB
		// (set) Token: 0x060217F2 RID: 137202 RVA: 0x004A6803 File Offset: 0x004A4A03
		public List<IActionInfoT> OnObtainNucleusActions { get; set; }

		// Token: 0x1700976A RID: 38762
		// (get) Token: 0x060217F3 RID: 137203 RVA: 0x004A680C File Offset: 0x004A4A0C
		// (set) Token: 0x060217F4 RID: 137204 RVA: 0x004A6814 File Offset: 0x004A4A14
		public List<IActionInfoT> OnReturnNucleusActions { get; set; }

		// Token: 0x1700976B RID: 38763
		// (get) Token: 0x060217F5 RID: 137205 RVA: 0x004A681D File Offset: 0x004A4A1D
		// (set) Token: 0x060217F6 RID: 137206 RVA: 0x004A6825 File Offset: 0x004A4A25
		public byte NullMask { get; set; }

		// Token: 0x060217F7 RID: 137207 RVA: 0x004A682E File Offset: 0x004A4A2E
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
