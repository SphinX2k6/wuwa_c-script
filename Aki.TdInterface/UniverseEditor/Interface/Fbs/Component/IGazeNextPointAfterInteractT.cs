using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F2 RID: 21234
	public class IGazeNextPointAfterInteractT
	{
		// Token: 0x17009BD9 RID: 39897
		// (get) Token: 0x06022AB2 RID: 142002 RVA: 0x004CE1DF File Offset: 0x004CC3DF
		// (set) Token: 0x06022AB3 RID: 142003 RVA: 0x004CE1E7 File Offset: 0x004CC3E7
		public IGazeConditionT GazeCondition { get; set; }

		// Token: 0x17009BDA RID: 39898
		// (get) Token: 0x06022AB4 RID: 142004 RVA: 0x004CE1F0 File Offset: 0x004CC3F0
		// (set) Token: 0x06022AB5 RID: 142005 RVA: 0x004CE1F8 File Offset: 0x004CC3F8
		public IGazePerformanceT GazePerformance { get; set; }

		// Token: 0x06022AB6 RID: 142006 RVA: 0x004CE201 File Offset: 0x004CC401
		public IGazeNextPointAfterInteractT()
		{
			this.GazeCondition = null;
			this.GazePerformance = null;
		}
	}
}
