using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200611F RID: 24863
	public class IVehicleAudioConfigT
	{
		// Token: 0x1700B91D RID: 47389
		// (get) Token: 0x0602A284 RID: 172676 RVA: 0x005C0D65 File Offset: 0x005BEF65
		// (set) Token: 0x0602A285 RID: 172677 RVA: 0x005C0D6D File Offset: 0x005BEF6D
		public float MinVehicleSpeed { get; set; }

		// Token: 0x1700B91E RID: 47390
		// (get) Token: 0x0602A286 RID: 172678 RVA: 0x005C0D76 File Offset: 0x005BEF76
		// (set) Token: 0x0602A287 RID: 172679 RVA: 0x005C0D7E File Offset: 0x005BEF7E
		public float MaxVehicleSpeed { get; set; }

		// Token: 0x1700B91F RID: 47391
		// (get) Token: 0x0602A288 RID: 172680 RVA: 0x005C0D87 File Offset: 0x005BEF87
		// (set) Token: 0x0602A289 RID: 172681 RVA: 0x005C0D8F File Offset: 0x005BEF8F
		public string AudioEvent { get; set; }

		// Token: 0x0602A28A RID: 172682 RVA: 0x005C0D98 File Offset: 0x005BEF98
		public IVehicleAudioConfigT()
		{
			this.MinVehicleSpeed = 0f;
			this.MaxVehicleSpeed = 0f;
			this.AudioEvent = null;
		}
	}
}
