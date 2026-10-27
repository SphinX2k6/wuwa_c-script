using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200490F RID: 18703
	public class ILoopTeleportClientPlayEffectLogicT
	{
		// Token: 0x17008799 RID: 34713
		// (get) Token: 0x0601D3D6 RID: 119766 RVA: 0x0041FE6B File Offset: 0x0041E06B
		// (set) Token: 0x0601D3D7 RID: 119767 RVA: 0x0041FE73 File Offset: 0x0041E073
		public ELoopTeleportClientLogicType Type { get; set; }

		// Token: 0x1700879A RID: 34714
		// (get) Token: 0x0601D3D8 RID: 119768 RVA: 0x0041FE7C File Offset: 0x0041E07C
		// (set) Token: 0x0601D3D9 RID: 119769 RVA: 0x0041FE84 File Offset: 0x0041E084
		public TLoopTeleportClientPlayEffectUnion EffectConfig { get; set; }

		// Token: 0x0601D3DA RID: 119770 RVA: 0x0041FE8D File Offset: 0x0041E08D
		public ILoopTeleportClientPlayEffectLogicT()
		{
			this.Type = ELoopTeleportClientLogicType.PlayEffect;
			this.EffectConfig = null;
		}
	}
}
