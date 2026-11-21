using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577C RID: 22396
	public class IExtraRangeComponentT
	{
		// Token: 0x1700A1E6 RID: 41446
		// (get) Token: 0x060241F8 RID: 147960 RVA: 0x004F7AB1 File Offset: 0x004F5CB1
		// (set) Token: 0x060241F9 RID: 147961 RVA: 0x004F7AB9 File Offset: 0x004F5CB9
		public bool Disabled { get; set; }

		// Token: 0x1700A1E7 RID: 41447
		// (get) Token: 0x060241FA RID: 147962 RVA: 0x004F7AC2 File Offset: 0x004F5CC2
		// (set) Token: 0x060241FB RID: 147963 RVA: 0x004F7ACA File Offset: 0x004F5CCA
		public List<ISunSpiritBlockExtraRangeT> ExtraRangeConfigs { get; set; }

		// Token: 0x1700A1E8 RID: 41448
		// (get) Token: 0x060241FC RID: 147964 RVA: 0x004F7AD3 File Offset: 0x004F5CD3
		// (set) Token: 0x060241FD RID: 147965 RVA: 0x004F7ADB File Offset: 0x004F5CDB
		public byte NullMask { get; set; }

		// Token: 0x060241FE RID: 147966 RVA: 0x004F7AE4 File Offset: 0x004F5CE4
		public IExtraRangeComponentT()
		{
			this.Disabled = false;
			this.ExtraRangeConfigs = null;
			this.NullMask = 0;
		}
	}
}
