using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004909 RID: 18697
	public class ILoopTeleportClientPlayEffectBaseT
	{
		// Token: 0x17008792 RID: 34706
		// (get) Token: 0x0601D3AE RID: 119726 RVA: 0x0041F9DB File Offset: 0x0041DBDB
		// (set) Token: 0x0601D3AF RID: 119727 RVA: 0x0041F9E3 File Offset: 0x0041DBE3
		public ELoopTeleportClientEffectType Type { get; set; }

		// Token: 0x17008793 RID: 34707
		// (get) Token: 0x0601D3B0 RID: 119728 RVA: 0x0041F9EC File Offset: 0x0041DBEC
		// (set) Token: 0x0601D3B1 RID: 119729 RVA: 0x0041F9F4 File Offset: 0x0041DBF4
		public string Path { get; set; }

		// Token: 0x0601D3B2 RID: 119730 RVA: 0x0041F9FD File Offset: 0x0041DBFD
		public ILoopTeleportClientPlayEffectBaseT()
		{
			this.Type = ELoopTeleportClientEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
