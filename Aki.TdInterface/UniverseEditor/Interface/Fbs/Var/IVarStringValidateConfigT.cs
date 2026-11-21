using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F1D RID: 16157
	public class IVarStringValidateConfigT
	{
		// Token: 0x17006D6A RID: 28010
		// (get) Token: 0x06015F35 RID: 89909 RVA: 0x00327D19 File Offset: 0x00325F19
		// (set) Token: 0x06015F36 RID: 89910 RVA: 0x00327D21 File Offset: 0x00325F21
		public EVar Type { get; set; }

		// Token: 0x17006D6B RID: 28011
		// (get) Token: 0x06015F37 RID: 89911 RVA: 0x00327D2A File Offset: 0x00325F2A
		// (set) Token: 0x06015F38 RID: 89912 RVA: 0x00327D32 File Offset: 0x00325F32
		public List<string> ValidList { get; set; }

		// Token: 0x17006D6C RID: 28012
		// (get) Token: 0x06015F39 RID: 89913 RVA: 0x00327D3B File Offset: 0x00325F3B
		// (set) Token: 0x06015F3A RID: 89914 RVA: 0x00327D43 File Offset: 0x00325F43
		public byte NullMask { get; set; }

		// Token: 0x06015F3B RID: 89915 RVA: 0x00327D4C File Offset: 0x00325F4C
		public IVarStringValidateConfigT()
		{
			this.Type = EVar.Boolean;
			this.ValidList = null;
			this.NullMask = 0;
		}
	}
}
