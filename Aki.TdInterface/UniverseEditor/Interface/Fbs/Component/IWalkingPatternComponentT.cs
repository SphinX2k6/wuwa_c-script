using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200615E RID: 24926
	public class IWalkingPatternComponentT
	{
		// Token: 0x1700B9B4 RID: 47540
		// (get) Token: 0x0602A50B RID: 173323 RVA: 0x005C60B4 File Offset: 0x005C42B4
		// (set) Token: 0x0602A50C RID: 173324 RVA: 0x005C60BC File Offset: 0x005C42BC
		public bool Disabled { get; set; }

		// Token: 0x1700B9B5 RID: 47541
		// (get) Token: 0x0602A50D RID: 173325 RVA: 0x005C60C5 File Offset: 0x005C42C5
		// (set) Token: 0x0602A50E RID: 173326 RVA: 0x005C60CD File Offset: 0x005C42CD
		public int SplineEntityId { get; set; }

		// Token: 0x1700B9B6 RID: 47542
		// (get) Token: 0x0602A50F RID: 173327 RVA: 0x005C60D6 File Offset: 0x005C42D6
		// (set) Token: 0x0602A510 RID: 173328 RVA: 0x005C60DE File Offset: 0x005C42DE
		public int EndEntityId { get; set; }

		// Token: 0x1700B9B7 RID: 47543
		// (get) Token: 0x0602A511 RID: 173329 RVA: 0x005C60E7 File Offset: 0x005C42E7
		// (set) Token: 0x0602A512 RID: 173330 RVA: 0x005C60EF File Offset: 0x005C42EF
		public TVarRefUnion ScoreVar { get; set; }

		// Token: 0x1700B9B8 RID: 47544
		// (get) Token: 0x0602A513 RID: 173331 RVA: 0x005C60F8 File Offset: 0x005C42F8
		// (set) Token: 0x0602A514 RID: 173332 RVA: 0x005C6100 File Offset: 0x005C4300
		public float SpineEffectExistDuration { get; set; }

		// Token: 0x1700B9B9 RID: 47545
		// (get) Token: 0x0602A515 RID: 173333 RVA: 0x005C6109 File Offset: 0x005C4309
		// (set) Token: 0x0602A516 RID: 173334 RVA: 0x005C6111 File Offset: 0x005C4311
		public string ReplaySpineEffect { get; set; }

		// Token: 0x1700B9BA RID: 47546
		// (get) Token: 0x0602A517 RID: 173335 RVA: 0x005C611A File Offset: 0x005C431A
		// (set) Token: 0x0602A518 RID: 173336 RVA: 0x005C6122 File Offset: 0x005C4322
		public IWalkingPatternStayAwayConfigT StayAwayFailConfig { get; set; }

		// Token: 0x1700B9BB RID: 47547
		// (get) Token: 0x0602A519 RID: 173337 RVA: 0x005C612B File Offset: 0x005C432B
		// (set) Token: 0x0602A51A RID: 173338 RVA: 0x005C6133 File Offset: 0x005C4333
		public byte NullMask { get; set; }

		// Token: 0x0602A51B RID: 173339 RVA: 0x005C613C File Offset: 0x005C433C
		public IWalkingPatternComponentT()
		{
			this.Disabled = false;
			this.SplineEntityId = 0;
			this.EndEntityId = 0;
			this.ScoreVar = null;
			this.SpineEffectExistDuration = 0f;
			this.ReplaySpineEffect = null;
			this.StayAwayFailConfig = null;
			this.NullMask = 0;
		}
	}
}
