using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F3F RID: 20287
	public class ICheckInfrastructureStageT
	{
		// Token: 0x170090F3 RID: 37107
		// (get) Token: 0x0601F8C1 RID: 129217 RVA: 0x00463978 File Offset: 0x00461B78
		// (set) Token: 0x0601F8C2 RID: 129218 RVA: 0x00463980 File Offset: 0x00461B80
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170090F4 RID: 37108
		// (get) Token: 0x0601F8C3 RID: 129219 RVA: 0x00463989 File Offset: 0x00461B89
		// (set) Token: 0x0601F8C4 RID: 129220 RVA: 0x00463991 File Offset: 0x00461B91
		public EInfrastructureStage InfrastructureStage { get; set; }

		// Token: 0x0601F8C5 RID: 129221 RVA: 0x0046399A File Offset: 0x00461B9A
		public ICheckInfrastructureStageT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.InfrastructureStage = EInfrastructureStage.None;
		}
	}
}
