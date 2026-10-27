using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EF RID: 21743
	public class ILevelSequenceFrameEventComponentT
	{
		// Token: 0x1700A067 RID: 41063
		// (get) Token: 0x06023E19 RID: 146969 RVA: 0x004F6146 File Offset: 0x004F4346
		// (set) Token: 0x06023E1A RID: 146970 RVA: 0x004F614E File Offset: 0x004F434E
		public bool Disabled { get; set; }

		// Token: 0x1700A068 RID: 41064
		// (get) Token: 0x06023E1B RID: 146971 RVA: 0x004F6157 File Offset: 0x004F4357
		// (set) Token: 0x06023E1C RID: 146972 RVA: 0x004F615F File Offset: 0x004F435F
		public List<ILevelSequenceSectionInfoT> ForwardSections { get; set; }

		// Token: 0x1700A069 RID: 41065
		// (get) Token: 0x06023E1D RID: 146973 RVA: 0x004F6168 File Offset: 0x004F4368
		// (set) Token: 0x06023E1E RID: 146974 RVA: 0x004F6170 File Offset: 0x004F4370
		public List<ILevelSequenceSectionInfoT> BackWardSections { get; set; }

		// Token: 0x1700A06A RID: 41066
		// (get) Token: 0x06023E1F RID: 146975 RVA: 0x004F6179 File Offset: 0x004F4379
		// (set) Token: 0x06023E20 RID: 146976 RVA: 0x004F6181 File Offset: 0x004F4381
		public byte NullMask { get; set; }

		// Token: 0x06023E21 RID: 146977 RVA: 0x004F618A File Offset: 0x004F438A
		public ILevelSequenceFrameEventComponentT()
		{
			this.Disabled = false;
			this.ForwardSections = null;
			this.BackWardSections = null;
			this.NullMask = 0;
		}
	}
}
