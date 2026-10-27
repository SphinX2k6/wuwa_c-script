using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004912 RID: 18706
	public class ILoopTeleportClientScreenEffectT
	{
		// Token: 0x1700879E RID: 34718
		// (get) Token: 0x0601D3EE RID: 119790 RVA: 0x004200D3 File Offset: 0x0041E2D3
		// (set) Token: 0x0601D3EF RID: 119791 RVA: 0x004200DB File Offset: 0x0041E2DB
		public ELoopTeleportClientEffectType Type { get; set; }

		// Token: 0x1700879F RID: 34719
		// (get) Token: 0x0601D3F0 RID: 119792 RVA: 0x004200E4 File Offset: 0x0041E2E4
		// (set) Token: 0x0601D3F1 RID: 119793 RVA: 0x004200EC File Offset: 0x0041E2EC
		public string Path { get; set; }

		// Token: 0x0601D3F2 RID: 119794 RVA: 0x004200F5 File Offset: 0x0041E2F5
		public ILoopTeleportClientScreenEffectT()
		{
			this.Type = ELoopTeleportClientEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
