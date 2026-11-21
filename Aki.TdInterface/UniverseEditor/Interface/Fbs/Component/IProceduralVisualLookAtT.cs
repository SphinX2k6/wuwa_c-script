using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA1 RID: 23969
	public class IProceduralVisualLookAtT
	{
		// Token: 0x1700B06B RID: 45163
		// (get) Token: 0x06027ED7 RID: 163543 RVA: 0x005760D2 File Offset: 0x005742D2
		// (set) Token: 0x06027ED8 RID: 163544 RVA: 0x005760DA File Offset: 0x005742DA
		public EProceduralVisualType Type { get; set; }

		// Token: 0x1700B06C RID: 45164
		// (get) Token: 0x06027ED9 RID: 163545 RVA: 0x005760E3 File Offset: 0x005742E3
		// (set) Token: 0x06027EDA RID: 163546 RVA: 0x005760EB File Offset: 0x005742EB
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B06D RID: 45165
		// (get) Token: 0x06027EDB RID: 163547 RVA: 0x005760F4 File Offset: 0x005742F4
		// (set) Token: 0x06027EDC RID: 163548 RVA: 0x005760FC File Offset: 0x005742FC
		public TLookAtTargetUnion Target { get; set; }

		// Token: 0x1700B06E RID: 45166
		// (get) Token: 0x06027EDD RID: 163549 RVA: 0x00576105 File Offset: 0x00574305
		// (set) Token: 0x06027EDE RID: 163550 RVA: 0x0057610D File Offset: 0x0057430D
		public string RotateNode { get; set; }

		// Token: 0x1700B06F RID: 45167
		// (get) Token: 0x06027EDF RID: 163551 RVA: 0x00576116 File Offset: 0x00574316
		// (set) Token: 0x06027EE0 RID: 163552 RVA: 0x0057611E File Offset: 0x0057431E
		public float MaxAngleSpeed { get; set; }

		// Token: 0x1700B070 RID: 45168
		// (get) Token: 0x06027EE1 RID: 163553 RVA: 0x00576127 File Offset: 0x00574327
		// (set) Token: 0x06027EE2 RID: 163554 RVA: 0x0057612F File Offset: 0x0057432F
		public ELookAtRotateMode RotateMode { get; set; }

		// Token: 0x1700B071 RID: 45169
		// (get) Token: 0x06027EE3 RID: 163555 RVA: 0x00576138 File Offset: 0x00574338
		// (set) Token: 0x06027EE4 RID: 163556 RVA: 0x00576140 File Offset: 0x00574340
		public EWorldAxisType ForwardDirection { get; set; }

		// Token: 0x1700B072 RID: 45170
		// (get) Token: 0x06027EE5 RID: 163557 RVA: 0x00576149 File Offset: 0x00574349
		// (set) Token: 0x06027EE6 RID: 163558 RVA: 0x00576151 File Offset: 0x00574351
		public ELookAtInvalidProcess InvalidProcess { get; set; }

		// Token: 0x1700B073 RID: 45171
		// (get) Token: 0x06027EE7 RID: 163559 RVA: 0x0057615A File Offset: 0x0057435A
		// (set) Token: 0x06027EE8 RID: 163560 RVA: 0x00576162 File Offset: 0x00574362
		public byte NullMask { get; set; }

		// Token: 0x06027EE9 RID: 163561 RVA: 0x0057616C File Offset: 0x0057436C
		public IProceduralVisualLookAtT()
		{
			this.Type = EProceduralVisualType.LookAt;
			this.Condition = null;
			this.Target = null;
			this.RotateNode = null;
			this.MaxAngleSpeed = 0f;
			this.RotateMode = ELookAtRotateMode.KeepInitialPitchRoll;
			this.ForwardDirection = EWorldAxisType.PositiveX;
			this.InvalidProcess = ELookAtInvalidProcess.Reset;
			this.NullMask = 0;
		}
	}
}
