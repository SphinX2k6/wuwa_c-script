using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B45 RID: 19269
	public class ICheckSystemStateTypeT
	{
		// Token: 0x17008BCD RID: 35789
		// (get) Token: 0x0601E559 RID: 124249 RVA: 0x0044012A File Offset: 0x0043E32A
		// (set) Token: 0x0601E55A RID: 124250 RVA: 0x00440132 File Offset: 0x0043E332
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x0601E55B RID: 124251 RVA: 0x0044013B File Offset: 0x0043E33B
		public ICheckSystemStateTypeT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
		}
	}
}
