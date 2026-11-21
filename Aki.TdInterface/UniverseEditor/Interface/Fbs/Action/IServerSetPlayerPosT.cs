using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007754 RID: 30548
	public class IServerSetPlayerPosT
	{
		// Token: 0x1700DFEB RID: 57323
		// (get) Token: 0x060359CE RID: 219598 RVA: 0x0072F96D File Offset: 0x0072DB6D
		// (set) Token: 0x060359CF RID: 219599 RVA: 0x0072F975 File Offset: 0x0072DB75
		public IPosAT Pos { get; set; }

		// Token: 0x060359D0 RID: 219600 RVA: 0x0072F97E File Offset: 0x0072DB7E
		public IServerSetPlayerPosT()
		{
			this.Pos = null;
		}
	}
}
