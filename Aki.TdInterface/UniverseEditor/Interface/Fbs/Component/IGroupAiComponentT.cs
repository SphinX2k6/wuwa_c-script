using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005331 RID: 21297
	public class IGroupAiComponentT
	{
		// Token: 0x17009C75 RID: 40053
		// (get) Token: 0x06022D37 RID: 142647 RVA: 0x004D366C File Offset: 0x004D186C
		// (set) Token: 0x06022D38 RID: 142648 RVA: 0x004D3674 File Offset: 0x004D1874
		public bool Disabled { get; set; }

		// Token: 0x17009C76 RID: 40054
		// (get) Token: 0x06022D39 RID: 142649 RVA: 0x004D367D File Offset: 0x004D187D
		// (set) Token: 0x06022D3A RID: 142650 RVA: 0x004D3685 File Offset: 0x004D1885
		public List<int> Entities { get; set; }

		// Token: 0x17009C77 RID: 40055
		// (get) Token: 0x06022D3B RID: 142651 RVA: 0x004D368E File Offset: 0x004D188E
		// (set) Token: 0x06022D3C RID: 142652 RVA: 0x004D3696 File Offset: 0x004D1896
		public TGroupAiOptionUnion Option { get; set; }

		// Token: 0x17009C78 RID: 40056
		// (get) Token: 0x06022D3D RID: 142653 RVA: 0x004D369F File Offset: 0x004D189F
		// (set) Token: 0x06022D3E RID: 142654 RVA: 0x004D36A7 File Offset: 0x004D18A7
		public List<string> SyncTags { get; set; }

		// Token: 0x17009C79 RID: 40057
		// (get) Token: 0x06022D3F RID: 142655 RVA: 0x004D36B0 File Offset: 0x004D18B0
		// (set) Token: 0x06022D40 RID: 142656 RVA: 0x004D36B8 File Offset: 0x004D18B8
		public byte NullMask { get; set; }

		// Token: 0x06022D41 RID: 142657 RVA: 0x004D36C1 File Offset: 0x004D18C1
		public IGroupAiComponentT()
		{
			this.Disabled = false;
			this.Entities = null;
			this.Option = null;
			this.SyncTags = null;
			this.NullMask = 0;
		}
	}
}
