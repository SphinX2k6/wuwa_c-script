using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004845 RID: 18501
	public class ICustomScanDirectoryDataT
	{
		// Token: 0x170084CC RID: 33996
		// (get) Token: 0x0601C9D1 RID: 117201 RVA: 0x0040B788 File Offset: 0x00409988
		// (set) Token: 0x0601C9D2 RID: 117202 RVA: 0x0040B790 File Offset: 0x00409990
		public bool IsEnable { get; set; }

		// Token: 0x170084CD RID: 33997
		// (get) Token: 0x0601C9D3 RID: 117203 RVA: 0x0040B799 File Offset: 0x00409999
		// (set) Token: 0x0601C9D4 RID: 117204 RVA: 0x0040B7A1 File Offset: 0x004099A1
		public bool IsEnableBaseDirs { get; set; }

		// Token: 0x170084CE RID: 33998
		// (get) Token: 0x0601C9D5 RID: 117205 RVA: 0x0040B7AA File Offset: 0x004099AA
		// (set) Token: 0x0601C9D6 RID: 117206 RVA: 0x0040B7B2 File Offset: 0x004099B2
		public List<string> DisabledBaseDirs { get; set; }

		// Token: 0x170084CF RID: 33999
		// (get) Token: 0x0601C9D7 RID: 117207 RVA: 0x0040B7BB File Offset: 0x004099BB
		// (set) Token: 0x0601C9D8 RID: 117208 RVA: 0x0040B7C3 File Offset: 0x004099C3
		public List<IScanDirectoryT> AppendDirs { get; set; }

		// Token: 0x170084D0 RID: 34000
		// (get) Token: 0x0601C9D9 RID: 117209 RVA: 0x0040B7CC File Offset: 0x004099CC
		// (set) Token: 0x0601C9DA RID: 117210 RVA: 0x0040B7D4 File Offset: 0x004099D4
		public bool IsSwarmDirs { get; set; }

		// Token: 0x0601C9DB RID: 117211 RVA: 0x0040B7DD File Offset: 0x004099DD
		public ICustomScanDirectoryDataT()
		{
			this.IsEnable = false;
			this.IsEnableBaseDirs = false;
			this.DisabledBaseDirs = null;
			this.AppendDirs = null;
			this.IsSwarmDirs = false;
		}
	}
}
