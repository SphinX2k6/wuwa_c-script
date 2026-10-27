using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FE RID: 21758
	public class ILiftComponentT
	{
		// Token: 0x1700A09B RID: 41115
		// (get) Token: 0x06023ED3 RID: 147155 RVA: 0x004F7A03 File Offset: 0x004F5C03
		// (set) Token: 0x06023ED4 RID: 147156 RVA: 0x004F7A0B File Offset: 0x004F5C0B
		public bool Disabled { get; set; }

		// Token: 0x1700A09C RID: 41116
		// (get) Token: 0x06023ED5 RID: 147157 RVA: 0x004F7A14 File Offset: 0x004F5C14
		// (set) Token: 0x06023ED6 RID: 147158 RVA: 0x004F7A1C File Offset: 0x004F5C1C
		public int InitialFloor { get; set; }

		// Token: 0x1700A09D RID: 41117
		// (get) Token: 0x06023ED7 RID: 147159 RVA: 0x004F7A25 File Offset: 0x004F5C25
		// (set) Token: 0x06023ED8 RID: 147160 RVA: 0x004F7A2D File Offset: 0x004F5C2D
		public bool UseFloorSeqMarkMapping { get; set; }

		// Token: 0x1700A09E RID: 41118
		// (get) Token: 0x06023ED9 RID: 147161 RVA: 0x004F7A36 File Offset: 0x004F5C36
		// (set) Token: 0x06023EDA RID: 147162 RVA: 0x004F7A3E File Offset: 0x004F5C3E
		public ELiftBuffType CustomLiftBuffType { get; set; }

		// Token: 0x1700A09F RID: 41119
		// (get) Token: 0x06023EDB RID: 147163 RVA: 0x004F7A47 File Offset: 0x004F5C47
		// (set) Token: 0x06023EDC RID: 147164 RVA: 0x004F7A4F File Offset: 0x004F5C4F
		public List<IVectorInfoT> StayPositions { get; set; }

		// Token: 0x1700A0A0 RID: 41120
		// (get) Token: 0x06023EDD RID: 147165 RVA: 0x004F7A58 File Offset: 0x004F5C58
		// (set) Token: 0x06023EDE RID: 147166 RVA: 0x004F7A60 File Offset: 0x004F5C60
		public IAutoConfigT AutoConfig { get; set; }

		// Token: 0x1700A0A1 RID: 41121
		// (get) Token: 0x06023EDF RID: 147167 RVA: 0x004F7A69 File Offset: 0x004F5C69
		// (set) Token: 0x06023EE0 RID: 147168 RVA: 0x004F7A71 File Offset: 0x004F5C71
		public int MaxSpeed { get; set; }

		// Token: 0x1700A0A2 RID: 41122
		// (get) Token: 0x06023EE1 RID: 147169 RVA: 0x004F7A7A File Offset: 0x004F5C7A
		// (set) Token: 0x06023EE2 RID: 147170 RVA: 0x004F7A82 File Offset: 0x004F5C82
		public bool UniformMovement { get; set; }

		// Token: 0x1700A0A3 RID: 41123
		// (get) Token: 0x06023EE3 RID: 147171 RVA: 0x004F7A8B File Offset: 0x004F5C8B
		// (set) Token: 0x06023EE4 RID: 147172 RVA: 0x004F7A93 File Offset: 0x004F5C93
		public float TurnTime { get; set; }

		// Token: 0x1700A0A4 RID: 41124
		// (get) Token: 0x06023EE5 RID: 147173 RVA: 0x004F7A9C File Offset: 0x004F5C9C
		// (set) Token: 0x06023EE6 RID: 147174 RVA: 0x004F7AA4 File Offset: 0x004F5CA4
		public IVectorInfoT SafePoint { get; set; }

		// Token: 0x1700A0A5 RID: 41125
		// (get) Token: 0x06023EE7 RID: 147175 RVA: 0x004F7AAD File Offset: 0x004F5CAD
		// (set) Token: 0x06023EE8 RID: 147176 RVA: 0x004F7AB5 File Offset: 0x004F5CB5
		public bool IsAffectedByTimeDilation { get; set; }

		// Token: 0x1700A0A6 RID: 41126
		// (get) Token: 0x06023EE9 RID: 147177 RVA: 0x004F7ABE File Offset: 0x004F5CBE
		// (set) Token: 0x06023EEA RID: 147178 RVA: 0x004F7AC6 File Offset: 0x004F5CC6
		public bool IsSendEventOnArrive { get; set; }

		// Token: 0x1700A0A7 RID: 41127
		// (get) Token: 0x06023EEB RID: 147179 RVA: 0x004F7ACF File Offset: 0x004F5CCF
		// (set) Token: 0x06023EEC RID: 147180 RVA: 0x004F7AD7 File Offset: 0x004F5CD7
		public byte NullMask { get; set; }

		// Token: 0x06023EED RID: 147181 RVA: 0x004F7AE0 File Offset: 0x004F5CE0
		public ILiftComponentT()
		{
			this.Disabled = false;
			this.InitialFloor = 0;
			this.UseFloorSeqMarkMapping = false;
			this.CustomLiftBuffType = ELiftBuffType.DefaultLiftBuff;
			this.StayPositions = null;
			this.AutoConfig = null;
			this.MaxSpeed = 0;
			this.UniformMovement = false;
			this.TurnTime = 0f;
			this.SafePoint = null;
			this.IsAffectedByTimeDilation = false;
			this.IsSendEventOnArrive = false;
			this.NullMask = 0;
		}
	}
}
