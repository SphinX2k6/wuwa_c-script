using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005875 RID: 22645
	public class IGazeNextPointAfterInteractT
	{
		// Token: 0x1700A40A RID: 41994
		// (get) Token: 0x06024B4C RID: 150348 RVA: 0x0050AD0B File Offset: 0x00508F0B
		// (set) Token: 0x06024B4D RID: 150349 RVA: 0x0050AD13 File Offset: 0x00508F13
		public IGazeConditionT GazeCondition { get; set; }

		// Token: 0x1700A40B RID: 41995
		// (get) Token: 0x06024B4E RID: 150350 RVA: 0x0050AD1C File Offset: 0x00508F1C
		// (set) Token: 0x06024B4F RID: 150351 RVA: 0x0050AD24 File Offset: 0x00508F24
		public IGazePerformanceT GazePerformance { get; set; }

		// Token: 0x06024B50 RID: 150352 RVA: 0x0050AD2D File Offset: 0x00508F2D
		public IGazeNextPointAfterInteractT()
		{
			this.GazeCondition = null;
			this.GazePerformance = null;
		}
	}
}
