using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DAA RID: 19882
	public class ILoopTeleportClientPlayEffectLogicT
	{
		// Token: 0x17008E3C RID: 36412
		// (get) Token: 0x0601ED6F RID: 126319 RVA: 0x0044F5CB File Offset: 0x0044D7CB
		// (set) Token: 0x0601ED70 RID: 126320 RVA: 0x0044F5D3 File Offset: 0x0044D7D3
		public ELoopTeleportClientLogicType Type { get; set; }

		// Token: 0x17008E3D RID: 36413
		// (get) Token: 0x0601ED71 RID: 126321 RVA: 0x0044F5DC File Offset: 0x0044D7DC
		// (set) Token: 0x0601ED72 RID: 126322 RVA: 0x0044F5E4 File Offset: 0x0044D7E4
		public TLoopTeleportClientPlayEffectUnion EffectConfig { get; set; }

		// Token: 0x0601ED73 RID: 126323 RVA: 0x0044F5ED File Offset: 0x0044D7ED
		public ILoopTeleportClientPlayEffectLogicT()
		{
			this.Type = ELoopTeleportClientLogicType.PlayEffect;
			this.EffectConfig = null;
		}
	}
}
