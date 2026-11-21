using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C2 RID: 30658
	public class ISetGlobalTimeScaleTypeT
	{
		// Token: 0x1700E0C5 RID: 57541
		// (get) Token: 0x06035DB2 RID: 220594 RVA: 0x0073745E File Offset: 0x0073565E
		// (set) Token: 0x06035DB3 RID: 220595 RVA: 0x00737466 File Offset: 0x00735666
		public ESetTimeScaleType Type { get; set; }

		// Token: 0x06035DB4 RID: 220596 RVA: 0x0073746F File Offset: 0x0073566F
		public ISetGlobalTimeScaleTypeT()
		{
			this.Type = ESetTimeScaleType.Open;
		}
	}
}
