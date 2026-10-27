using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A79 RID: 19065
	public class ICheckInfrastructureStageT
	{
		// Token: 0x17008A17 RID: 35351
		// (get) Token: 0x0601DE1E RID: 122398 RVA: 0x004327EC File Offset: 0x004309EC
		// (set) Token: 0x0601DE1F RID: 122399 RVA: 0x004327F4 File Offset: 0x004309F4
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008A18 RID: 35352
		// (get) Token: 0x0601DE20 RID: 122400 RVA: 0x004327FD File Offset: 0x004309FD
		// (set) Token: 0x0601DE21 RID: 122401 RVA: 0x00432805 File Offset: 0x00430A05
		public EInfrastructureStage InfrastructureStage { get; set; }

		// Token: 0x0601DE22 RID: 122402 RVA: 0x0043280E File Offset: 0x00430A0E
		public ICheckInfrastructureStageT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.InfrastructureStage = EInfrastructureStage.None;
		}
	}
}
