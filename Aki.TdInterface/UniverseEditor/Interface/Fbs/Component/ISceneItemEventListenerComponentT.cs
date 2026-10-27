using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C2 RID: 22722
	public class ISceneItemEventListenerComponentT
	{
		// Token: 0x1700AA23 RID: 43555
		// (get) Token: 0x06026588 RID: 157064 RVA: 0x00548ECD File Offset: 0x005470CD
		// (set) Token: 0x06026589 RID: 157065 RVA: 0x00548ED5 File Offset: 0x005470D5
		public bool Disabled { get; set; }

		// Token: 0x1700AA24 RID: 43556
		// (get) Token: 0x0602658A RID: 157066 RVA: 0x00548EDE File Offset: 0x005470DE
		// (set) Token: 0x0602658B RID: 157067 RVA: 0x00548EE6 File Offset: 0x005470E6
		public List<ISceneItemEventConfigT> Events { get; set; }

		// Token: 0x1700AA25 RID: 43557
		// (get) Token: 0x0602658C RID: 157068 RVA: 0x00548EEF File Offset: 0x005470EF
		// (set) Token: 0x0602658D RID: 157069 RVA: 0x00548EF7 File Offset: 0x005470F7
		public byte NullMask { get; set; }

		// Token: 0x0602658E RID: 157070 RVA: 0x00548F00 File Offset: 0x00547100
		public ISceneItemEventListenerComponentT()
		{
			this.Disabled = false;
			this.Events = null;
			this.NullMask = 0;
		}
	}
}
