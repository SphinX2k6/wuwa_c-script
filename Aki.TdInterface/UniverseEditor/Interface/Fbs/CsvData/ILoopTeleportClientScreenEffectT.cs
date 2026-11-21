using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DAD RID: 19885
	public class ILoopTeleportClientScreenEffectT
	{
		// Token: 0x17008E41 RID: 36417
		// (get) Token: 0x0601ED87 RID: 126343 RVA: 0x0044F833 File Offset: 0x0044DA33
		// (set) Token: 0x0601ED88 RID: 126344 RVA: 0x0044F83B File Offset: 0x0044DA3B
		public ELoopTeleportClientEffectType Type { get; set; }

		// Token: 0x17008E42 RID: 36418
		// (get) Token: 0x0601ED89 RID: 126345 RVA: 0x0044F844 File Offset: 0x0044DA44
		// (set) Token: 0x0601ED8A RID: 126346 RVA: 0x0044F84C File Offset: 0x0044DA4C
		public string Path { get; set; }

		// Token: 0x0601ED8B RID: 126347 RVA: 0x0044F855 File Offset: 0x0044DA55
		public ILoopTeleportClientScreenEffectT()
		{
			this.Type = ELoopTeleportClientEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
