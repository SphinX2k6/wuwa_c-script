using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D9B RID: 19867
	public class ILoopTeleportClientLogicItemBaseT
	{
		// Token: 0x17008E2A RID: 36394
		// (get) Token: 0x0601ED0D RID: 126221 RVA: 0x0044EBFA File Offset: 0x0044CDFA
		// (set) Token: 0x0601ED0E RID: 126222 RVA: 0x0044EC02 File Offset: 0x0044CE02
		public ELoopTeleportClientLogicType Type { get; set; }

		// Token: 0x0601ED0F RID: 126223 RVA: 0x0044EC0B File Offset: 0x0044CE0B
		public ILoopTeleportClientLogicItemBaseT()
		{
			this.Type = ELoopTeleportClientLogicType.PlayEffect;
		}
	}
}
