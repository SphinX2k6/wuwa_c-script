using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E73 RID: 28275
	public class IFlowActorUnitT
	{
		// Token: 0x1700CF3E RID: 53054
		// (get) Token: 0x06030DA7 RID: 200103 RVA: 0x006A0C8B File Offset: 0x0069EE8B
		// (set) Token: 0x06030DA8 RID: 200104 RVA: 0x006A0C93 File Offset: 0x0069EE93
		public int EntityId { get; set; }

		// Token: 0x1700CF3F RID: 53055
		// (get) Token: 0x06030DA9 RID: 200105 RVA: 0x006A0C9C File Offset: 0x0069EE9C
		// (set) Token: 0x06030DAA RID: 200106 RVA: 0x006A0CA4 File Offset: 0x0069EEA4
		public int TalkerId { get; set; }

		// Token: 0x1700CF40 RID: 53056
		// (get) Token: 0x06030DAB RID: 200107 RVA: 0x006A0CAD File Offset: 0x0069EEAD
		// (set) Token: 0x06030DAC RID: 200108 RVA: 0x006A0CB5 File Offset: 0x0069EEB5
		public bool IsPlayer { get; set; }

		// Token: 0x1700CF41 RID: 53057
		// (get) Token: 0x06030DAD RID: 200109 RVA: 0x006A0CBE File Offset: 0x0069EEBE
		// (set) Token: 0x06030DAE RID: 200110 RVA: 0x006A0CC6 File Offset: 0x0069EEC6
		public bool IsResetPosition { get; set; }

		// Token: 0x1700CF42 RID: 53058
		// (get) Token: 0x06030DAF RID: 200111 RVA: 0x006A0CCF File Offset: 0x0069EECF
		// (set) Token: 0x06030DB0 RID: 200112 RVA: 0x006A0CD7 File Offset: 0x0069EED7
		public string SeqFacePath { get; set; }

		// Token: 0x1700CF43 RID: 53059
		// (get) Token: 0x06030DB1 RID: 200113 RVA: 0x006A0CE0 File Offset: 0x0069EEE0
		// (set) Token: 0x06030DB2 RID: 200114 RVA: 0x006A0CE8 File Offset: 0x0069EEE8
		public IActorInitialStateT InitialState { get; set; }

		// Token: 0x06030DB3 RID: 200115 RVA: 0x006A0CF1 File Offset: 0x0069EEF1
		public IFlowActorUnitT()
		{
			this.EntityId = 0;
			this.TalkerId = 0;
			this.IsPlayer = false;
			this.IsResetPosition = false;
			this.SeqFacePath = null;
			this.InitialState = null;
		}
	}
}
