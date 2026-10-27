using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005124 RID: 20772
	public class IElementalAbilityConfigT
	{
		// Token: 0x17009755 RID: 38741
		// (get) Token: 0x060217B1 RID: 137137 RVA: 0x004A5F30 File Offset: 0x004A4130
		// (set) Token: 0x060217B2 RID: 137138 RVA: 0x004A5F38 File Offset: 0x004A4138
		public EElementalType ElementalType { get; set; }

		// Token: 0x17009756 RID: 38742
		// (get) Token: 0x060217B3 RID: 137139 RVA: 0x004A5F41 File Offset: 0x004A4141
		// (set) Token: 0x060217B4 RID: 137140 RVA: 0x004A5F49 File Offset: 0x004A4149
		public bool IsInitialActive { get; set; }

		// Token: 0x17009757 RID: 38743
		// (get) Token: 0x060217B5 RID: 137141 RVA: 0x004A5F52 File Offset: 0x004A4152
		// (set) Token: 0x060217B6 RID: 137142 RVA: 0x004A5F5A File Offset: 0x004A415A
		public TTriggerShapeUnion Range { get; set; }

		// Token: 0x17009758 RID: 38744
		// (get) Token: 0x060217B7 RID: 137143 RVA: 0x004A5F63 File Offset: 0x004A4163
		// (set) Token: 0x060217B8 RID: 137144 RVA: 0x004A5F6B File Offset: 0x004A416B
		public bool IsEnableEnvEffect { get; set; }

		// Token: 0x17009759 RID: 38745
		// (get) Token: 0x060217B9 RID: 137145 RVA: 0x004A5F74 File Offset: 0x004A4174
		// (set) Token: 0x060217BA RID: 137146 RVA: 0x004A5F7C File Offset: 0x004A417C
		public List<IStateElementalEnableConfigT> StateEnableConfigs { get; set; }

		// Token: 0x1700975A RID: 38746
		// (get) Token: 0x060217BB RID: 137147 RVA: 0x004A5F85 File Offset: 0x004A4185
		// (set) Token: 0x060217BC RID: 137148 RVA: 0x004A5F8D File Offset: 0x004A418D
		public byte NullMask { get; set; }

		// Token: 0x060217BD RID: 137149 RVA: 0x004A5F96 File Offset: 0x004A4196
		public IElementalAbilityConfigT()
		{
			this.ElementalType = EElementalType.Fire;
			this.IsInitialActive = false;
			this.Range = null;
			this.IsEnableEnvEffect = false;
			this.StateEnableConfigs = null;
			this.NullMask = 0;
		}
	}
}
