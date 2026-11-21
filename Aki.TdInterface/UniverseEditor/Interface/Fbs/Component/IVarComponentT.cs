using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200611C RID: 24860
	public class IVarComponentT
	{
		// Token: 0x1700B916 RID: 47382
		// (get) Token: 0x0602A268 RID: 172648 RVA: 0x005C0A6D File Offset: 0x005BEC6D
		// (set) Token: 0x0602A269 RID: 172649 RVA: 0x005C0A75 File Offset: 0x005BEC75
		public bool Disabled { get; set; }

		// Token: 0x1700B917 RID: 47383
		// (get) Token: 0x0602A26A RID: 172650 RVA: 0x005C0A7E File Offset: 0x005BEC7E
		// (set) Token: 0x0602A26B RID: 172651 RVA: 0x005C0A86 File Offset: 0x005BEC86
		public List<IVarDefineT> Vars { get; set; }

		// Token: 0x1700B918 RID: 47384
		// (get) Token: 0x0602A26C RID: 172652 RVA: 0x005C0A8F File Offset: 0x005BEC8F
		// (set) Token: 0x0602A26D RID: 172653 RVA: 0x005C0A97 File Offset: 0x005BEC97
		public byte NullMask { get; set; }

		// Token: 0x0602A26E RID: 172654 RVA: 0x005C0AA0 File Offset: 0x005BECA0
		public IVarComponentT()
		{
			this.Disabled = false;
			this.Vars = null;
			this.NullMask = 0;
		}
	}
}
