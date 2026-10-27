using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694F RID: 26959
	public class IInfrActivityInfrastructureStageT
	{
		// Token: 0x1700C7FC RID: 51196
		// (get) Token: 0x0602F128 RID: 192808 RVA: 0x0066A5BC File Offset: 0x006687BC
		// (set) Token: 0x0602F129 RID: 192809 RVA: 0x0066A5C4 File Offset: 0x006687C4
		public EInfrActivityBuildStageType Type { get; set; }

		// Token: 0x1700C7FD RID: 51197
		// (get) Token: 0x0602F12A RID: 192810 RVA: 0x0066A5CD File Offset: 0x006687CD
		// (set) Token: 0x0602F12B RID: 192811 RVA: 0x0066A5D5 File Offset: 0x006687D5
		public int Stage { get; set; }

		// Token: 0x0602F12C RID: 192812 RVA: 0x0066A5DE File Offset: 0x006687DE
		public IInfrActivityInfrastructureStageT()
		{
			this.Type = EInfrActivityBuildStageType.Infrastructure;
			this.Stage = 0;
		}
	}
}
