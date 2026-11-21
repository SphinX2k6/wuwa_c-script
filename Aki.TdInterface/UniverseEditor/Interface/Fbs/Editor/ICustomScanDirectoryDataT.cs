using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CAD RID: 19629
	public class ICustomScanDirectoryDataT
	{
		// Token: 0x17008B17 RID: 35607
		// (get) Token: 0x0601E1CE RID: 123342 RVA: 0x004380D8 File Offset: 0x004362D8
		// (set) Token: 0x0601E1CF RID: 123343 RVA: 0x004380E0 File Offset: 0x004362E0
		public bool IsEnable { get; set; }

		// Token: 0x17008B18 RID: 35608
		// (get) Token: 0x0601E1D0 RID: 123344 RVA: 0x004380E9 File Offset: 0x004362E9
		// (set) Token: 0x0601E1D1 RID: 123345 RVA: 0x004380F1 File Offset: 0x004362F1
		public bool IsEnableBaseDirs { get; set; }

		// Token: 0x17008B19 RID: 35609
		// (get) Token: 0x0601E1D2 RID: 123346 RVA: 0x004380FA File Offset: 0x004362FA
		// (set) Token: 0x0601E1D3 RID: 123347 RVA: 0x00438102 File Offset: 0x00436302
		public List<string> DisabledBaseDirs { get; set; }

		// Token: 0x17008B1A RID: 35610
		// (get) Token: 0x0601E1D4 RID: 123348 RVA: 0x0043810B File Offset: 0x0043630B
		// (set) Token: 0x0601E1D5 RID: 123349 RVA: 0x00438113 File Offset: 0x00436313
		public List<IScanDirectoryT> AppendDirs { get; set; }

		// Token: 0x17008B1B RID: 35611
		// (get) Token: 0x0601E1D6 RID: 123350 RVA: 0x0043811C File Offset: 0x0043631C
		// (set) Token: 0x0601E1D7 RID: 123351 RVA: 0x00438124 File Offset: 0x00436324
		public bool IsSwarmDirs { get; set; }

		// Token: 0x0601E1D8 RID: 123352 RVA: 0x0043812D File Offset: 0x0043632D
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
