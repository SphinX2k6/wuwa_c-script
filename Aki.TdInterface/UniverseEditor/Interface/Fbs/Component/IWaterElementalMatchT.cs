using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006167 RID: 24935
	public class IWaterElementalMatchT
	{
		// Token: 0x1700B9D6 RID: 47574
		// (get) Token: 0x0602A585 RID: 173445 RVA: 0x005C71F5 File Offset: 0x005C53F5
		// (set) Token: 0x0602A586 RID: 173446 RVA: 0x005C71FD File Offset: 0x005C53FD
		public EElementalType Type { get; set; }

		// Token: 0x1700B9D7 RID: 47575
		// (get) Token: 0x0602A587 RID: 173447 RVA: 0x005C7206 File Offset: 0x005C5406
		// (set) Token: 0x0602A588 RID: 173448 RVA: 0x005C720E File Offset: 0x005C540E
		public bool CanStagnate { get; set; }

		// Token: 0x1700B9D8 RID: 47576
		// (get) Token: 0x0602A589 RID: 173449 RVA: 0x005C7217 File Offset: 0x005C5417
		// (set) Token: 0x0602A58A RID: 173450 RVA: 0x005C721F File Offset: 0x005C541F
		public IWaterStagnationActorConfigT StagnationActorConfig { get; set; }

		// Token: 0x1700B9D9 RID: 47577
		// (get) Token: 0x0602A58B RID: 173451 RVA: 0x005C7228 File Offset: 0x005C5428
		// (set) Token: 0x0602A58C RID: 173452 RVA: 0x005C7230 File Offset: 0x005C5430
		public float StagnationImmuneDurationAfterHit { get; set; }

		// Token: 0x1700B9DA RID: 47578
		// (get) Token: 0x0602A58D RID: 173453 RVA: 0x005C7239 File Offset: 0x005C5439
		// (set) Token: 0x0602A58E RID: 173454 RVA: 0x005C7241 File Offset: 0x005C5441
		public byte NullMask { get; set; }

		// Token: 0x0602A58F RID: 173455 RVA: 0x005C724A File Offset: 0x005C544A
		public IWaterElementalMatchT()
		{
			this.Type = EElementalType.Fire;
			this.CanStagnate = false;
			this.StagnationActorConfig = null;
			this.StagnationImmuneDurationAfterHit = 0f;
			this.NullMask = 0;
		}
	}
}
