using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005969 RID: 22889
	public class ISpawnTemplateEntityConfigT
	{
		// Token: 0x1700ABCA RID: 43978
		// (get) Token: 0x06026BF7 RID: 158711 RVA: 0x00555C3C File Offset: 0x00553E3C
		// (set) Token: 0x06026BF8 RID: 158712 RVA: 0x00555C44 File Offset: 0x00553E44
		public string TemplateBpType { get; set; }

		// Token: 0x1700ABCB RID: 43979
		// (get) Token: 0x06026BF9 RID: 158713 RVA: 0x00555C4D File Offset: 0x00553E4D
		// (set) Token: 0x06026BFA RID: 158714 RVA: 0x00555C55 File Offset: 0x00553E55
		public IVectorInfoT PosOffset { get; set; }

		// Token: 0x1700ABCC RID: 43980
		// (get) Token: 0x06026BFB RID: 158715 RVA: 0x00555C5E File Offset: 0x00553E5E
		// (set) Token: 0x06026BFC RID: 158716 RVA: 0x00555C66 File Offset: 0x00553E66
		public IVectorInfoT RotOffset { get; set; }

		// Token: 0x1700ABCD RID: 43981
		// (get) Token: 0x06026BFD RID: 158717 RVA: 0x00555C6F File Offset: 0x00553E6F
		// (set) Token: 0x06026BFE RID: 158718 RVA: 0x00555C77 File Offset: 0x00553E77
		public List<ETemplateEntityGroupType> GroupTypes { get; set; }

		// Token: 0x1700ABCE RID: 43982
		// (get) Token: 0x06026BFF RID: 158719 RVA: 0x00555C80 File Offset: 0x00553E80
		// (set) Token: 0x06026C00 RID: 158720 RVA: 0x00555C88 File Offset: 0x00553E88
		public byte NullMask { get; set; }

		// Token: 0x06026C01 RID: 158721 RVA: 0x00555C91 File Offset: 0x00553E91
		public ISpawnTemplateEntityConfigT()
		{
			this.TemplateBpType = null;
			this.PosOffset = null;
			this.RotOffset = null;
			this.GroupTypes = null;
			this.NullMask = 0;
		}
	}
}
