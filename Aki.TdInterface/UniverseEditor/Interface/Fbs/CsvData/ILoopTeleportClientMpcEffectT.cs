using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004906 RID: 18694
	public class ILoopTeleportClientMpcEffectT
	{
		// Token: 0x1700878D RID: 34701
		// (get) Token: 0x0601D396 RID: 119702 RVA: 0x0041F7A7 File Offset: 0x0041D9A7
		// (set) Token: 0x0601D397 RID: 119703 RVA: 0x0041F7AF File Offset: 0x0041D9AF
		public ELoopTeleportClientEffectType Type { get; set; }

		// Token: 0x1700878E RID: 34702
		// (get) Token: 0x0601D398 RID: 119704 RVA: 0x0041F7B8 File Offset: 0x0041D9B8
		// (set) Token: 0x0601D399 RID: 119705 RVA: 0x0041F7C0 File Offset: 0x0041D9C0
		public string Path { get; set; }

		// Token: 0x0601D39A RID: 119706 RVA: 0x0041F7C9 File Offset: 0x0041D9C9
		public ILoopTeleportClientMpcEffectT()
		{
			this.Type = ELoopTeleportClientEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
