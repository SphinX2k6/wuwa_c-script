using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D0A RID: 19722
	public class IScanDirectoryT
	{
		// Token: 0x17008D23 RID: 36131
		// (get) Token: 0x0601E85F RID: 125023 RVA: 0x0044606F File Offset: 0x0044426F
		// (set) Token: 0x0601E860 RID: 125024 RVA: 0x00446077 File Offset: 0x00444277
		public bool IsEnable { get; set; }

		// Token: 0x17008D24 RID: 36132
		// (get) Token: 0x0601E861 RID: 125025 RVA: 0x00446080 File Offset: 0x00444280
		// (set) Token: 0x0601E862 RID: 125026 RVA: 0x00446088 File Offset: 0x00444288
		public string Path { get; set; }

		// Token: 0x0601E863 RID: 125027 RVA: 0x00446091 File Offset: 0x00444291
		public IScanDirectoryT()
		{
			this.IsEnable = false;
			this.Path = null;
		}
	}
}
