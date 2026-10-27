using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061AD RID: 25005
	public class IAttenuatedGamepadShakeT
	{
		// Token: 0x1700BA71 RID: 47729
		// (get) Token: 0x0602B15A RID: 176474 RVA: 0x005F0FE3 File Offset: 0x005EF1E3
		// (set) Token: 0x0602B15B RID: 176475 RVA: 0x005F0FEB File Offset: 0x005EF1EB
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700BA72 RID: 47730
		// (get) Token: 0x0602B15C RID: 176476 RVA: 0x005F0FF4 File Offset: 0x005EF1F4
		// (set) Token: 0x0602B15D RID: 176477 RVA: 0x005F0FFC File Offset: 0x005EF1FC
		public int CenterEntity { get; set; }

		// Token: 0x1700BA73 RID: 47731
		// (get) Token: 0x0602B15E RID: 176478 RVA: 0x005F1005 File Offset: 0x005EF205
		// (set) Token: 0x0602B15F RID: 176479 RVA: 0x005F100D File Offset: 0x005EF20D
		public bool IsFollowEntityMovement { get; set; }

		// Token: 0x1700BA74 RID: 47732
		// (get) Token: 0x0602B160 RID: 176480 RVA: 0x005F1016 File Offset: 0x005EF216
		// (set) Token: 0x0602B161 RID: 176481 RVA: 0x005F101E File Offset: 0x005EF21E
		public string ForceFeedbackAttenuation { get; set; }

		// Token: 0x1700BA75 RID: 47733
		// (get) Token: 0x0602B162 RID: 176482 RVA: 0x005F1027 File Offset: 0x005EF227
		// (set) Token: 0x0602B163 RID: 176483 RVA: 0x005F102F File Offset: 0x005EF22F
		public float Duration { get; set; }

		// Token: 0x1700BA76 RID: 47734
		// (get) Token: 0x0602B164 RID: 176484 RVA: 0x005F1038 File Offset: 0x005EF238
		// (set) Token: 0x0602B165 RID: 176485 RVA: 0x005F1040 File Offset: 0x005EF240
		public bool IsLoop { get; set; }

		// Token: 0x0602B166 RID: 176486 RVA: 0x005F1049 File Offset: 0x005EF249
		public IAttenuatedGamepadShakeT()
		{
			this.Type = EGamepadShakeType.Onetime;
			this.CenterEntity = 0;
			this.IsFollowEntityMovement = false;
			this.ForceFeedbackAttenuation = null;
			this.Duration = 0f;
			this.IsLoop = false;
		}
	}
}
