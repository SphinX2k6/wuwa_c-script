using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579A RID: 22426
	public class IProceduralVisualLookAtT
	{
		// Token: 0x1700A747 RID: 42823
		// (get) Token: 0x060259B7 RID: 154039 RVA: 0x0052FF46 File Offset: 0x0052E146
		// (set) Token: 0x060259B8 RID: 154040 RVA: 0x0052FF4E File Offset: 0x0052E14E
		public EProceduralVisualType Type { get; set; }

		// Token: 0x1700A748 RID: 42824
		// (get) Token: 0x060259B9 RID: 154041 RVA: 0x0052FF57 File Offset: 0x0052E157
		// (set) Token: 0x060259BA RID: 154042 RVA: 0x0052FF5F File Offset: 0x0052E15F
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A749 RID: 42825
		// (get) Token: 0x060259BB RID: 154043 RVA: 0x0052FF68 File Offset: 0x0052E168
		// (set) Token: 0x060259BC RID: 154044 RVA: 0x0052FF70 File Offset: 0x0052E170
		public TLookAtTargetUnion Target { get; set; }

		// Token: 0x1700A74A RID: 42826
		// (get) Token: 0x060259BD RID: 154045 RVA: 0x0052FF79 File Offset: 0x0052E179
		// (set) Token: 0x060259BE RID: 154046 RVA: 0x0052FF81 File Offset: 0x0052E181
		public string RotateNode { get; set; }

		// Token: 0x1700A74B RID: 42827
		// (get) Token: 0x060259BF RID: 154047 RVA: 0x0052FF8A File Offset: 0x0052E18A
		// (set) Token: 0x060259C0 RID: 154048 RVA: 0x0052FF92 File Offset: 0x0052E192
		public float MaxAngleSpeed { get; set; }

		// Token: 0x1700A74C RID: 42828
		// (get) Token: 0x060259C1 RID: 154049 RVA: 0x0052FF9B File Offset: 0x0052E19B
		// (set) Token: 0x060259C2 RID: 154050 RVA: 0x0052FFA3 File Offset: 0x0052E1A3
		public ELookAtRotateMode RotateMode { get; set; }

		// Token: 0x1700A74D RID: 42829
		// (get) Token: 0x060259C3 RID: 154051 RVA: 0x0052FFAC File Offset: 0x0052E1AC
		// (set) Token: 0x060259C4 RID: 154052 RVA: 0x0052FFB4 File Offset: 0x0052E1B4
		public EWorldAxisType ForwardDirection { get; set; }

		// Token: 0x1700A74E RID: 42830
		// (get) Token: 0x060259C5 RID: 154053 RVA: 0x0052FFBD File Offset: 0x0052E1BD
		// (set) Token: 0x060259C6 RID: 154054 RVA: 0x0052FFC5 File Offset: 0x0052E1C5
		public ELookAtInvalidProcess InvalidProcess { get; set; }

		// Token: 0x1700A74F RID: 42831
		// (get) Token: 0x060259C7 RID: 154055 RVA: 0x0052FFCE File Offset: 0x0052E1CE
		// (set) Token: 0x060259C8 RID: 154056 RVA: 0x0052FFD6 File Offset: 0x0052E1D6
		public byte NullMask { get; set; }

		// Token: 0x060259C9 RID: 154057 RVA: 0x0052FFE0 File Offset: 0x0052E1E0
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
