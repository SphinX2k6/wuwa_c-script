using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681B RID: 26651
	public class IAttenuatedGamepadShakeT
	{
		// Token: 0x1700C3F4 RID: 50164
		// (get) Token: 0x0602D8A1 RID: 186529 RVA: 0x0063BA57 File Offset: 0x00639C57
		// (set) Token: 0x0602D8A2 RID: 186530 RVA: 0x0063BA5F File Offset: 0x00639C5F
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700C3F5 RID: 50165
		// (get) Token: 0x0602D8A3 RID: 186531 RVA: 0x0063BA68 File Offset: 0x00639C68
		// (set) Token: 0x0602D8A4 RID: 186532 RVA: 0x0063BA70 File Offset: 0x00639C70
		public int CenterEntity { get; set; }

		// Token: 0x1700C3F6 RID: 50166
		// (get) Token: 0x0602D8A5 RID: 186533 RVA: 0x0063BA79 File Offset: 0x00639C79
		// (set) Token: 0x0602D8A6 RID: 186534 RVA: 0x0063BA81 File Offset: 0x00639C81
		public bool IsFollowEntityMovement { get; set; }

		// Token: 0x1700C3F7 RID: 50167
		// (get) Token: 0x0602D8A7 RID: 186535 RVA: 0x0063BA8A File Offset: 0x00639C8A
		// (set) Token: 0x0602D8A8 RID: 186536 RVA: 0x0063BA92 File Offset: 0x00639C92
		public string ForceFeedbackAttenuation { get; set; }

		// Token: 0x1700C3F8 RID: 50168
		// (get) Token: 0x0602D8A9 RID: 186537 RVA: 0x0063BA9B File Offset: 0x00639C9B
		// (set) Token: 0x0602D8AA RID: 186538 RVA: 0x0063BAA3 File Offset: 0x00639CA3
		public float Duration { get; set; }

		// Token: 0x1700C3F9 RID: 50169
		// (get) Token: 0x0602D8AB RID: 186539 RVA: 0x0063BAAC File Offset: 0x00639CAC
		// (set) Token: 0x0602D8AC RID: 186540 RVA: 0x0063BAB4 File Offset: 0x00639CB4
		public bool IsLoop { get; set; }

		// Token: 0x0602D8AD RID: 186541 RVA: 0x0063BABD File Offset: 0x00639CBD
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
