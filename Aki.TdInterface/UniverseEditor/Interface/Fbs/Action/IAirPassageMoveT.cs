using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E8 RID: 26600
	public class IAirPassageMoveT
	{
		// Token: 0x1700C394 RID: 50068
		// (get) Token: 0x0602D705 RID: 186117 RVA: 0x00638FC5 File Offset: 0x006371C5
		// (set) Token: 0x0602D706 RID: 186118 RVA: 0x00638FCD File Offset: 0x006371CD
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C395 RID: 50069
		// (get) Token: 0x0602D707 RID: 186119 RVA: 0x00638FD6 File Offset: 0x006371D6
		// (set) Token: 0x0602D708 RID: 186120 RVA: 0x00638FDE File Offset: 0x006371DE
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700C396 RID: 50070
		// (get) Token: 0x0602D709 RID: 186121 RVA: 0x00638FE7 File Offset: 0x006371E7
		// (set) Token: 0x0602D70A RID: 186122 RVA: 0x00638FEF File Offset: 0x006371EF
		public bool IsOneWay { get; set; }

		// Token: 0x1700C397 RID: 50071
		// (get) Token: 0x0602D70B RID: 186123 RVA: 0x00638FF8 File Offset: 0x006371F8
		// (set) Token: 0x0602D70C RID: 186124 RVA: 0x00639000 File Offset: 0x00637200
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700C398 RID: 50072
		// (get) Token: 0x0602D70D RID: 186125 RVA: 0x00639009 File Offset: 0x00637209
		// (set) Token: 0x0602D70E RID: 186126 RVA: 0x00639011 File Offset: 0x00637211
		public bool DynamicGravity { get; set; }

		// Token: 0x1700C399 RID: 50073
		// (get) Token: 0x0602D70F RID: 186127 RVA: 0x0063901A File Offset: 0x0063721A
		// (set) Token: 0x0602D710 RID: 186128 RVA: 0x00639022 File Offset: 0x00637222
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C39A RID: 50074
		// (get) Token: 0x0602D711 RID: 186129 RVA: 0x0063902B File Offset: 0x0063722B
		// (set) Token: 0x0602D712 RID: 186130 RVA: 0x00639033 File Offset: 0x00637233
		public int AutoExitDistance { get; set; }

		// Token: 0x1700C39B RID: 50075
		// (get) Token: 0x0602D713 RID: 186131 RVA: 0x0063903C File Offset: 0x0063723C
		// (set) Token: 0x0602D714 RID: 186132 RVA: 0x00639044 File Offset: 0x00637244
		public IAirPassageMoveLimitT Limit { get; set; }

		// Token: 0x1700C39C RID: 50076
		// (get) Token: 0x0602D715 RID: 186133 RVA: 0x0063904D File Offset: 0x0063724D
		// (set) Token: 0x0602D716 RID: 186134 RVA: 0x00639055 File Offset: 0x00637255
		public byte NullMask { get; set; }

		// Token: 0x0602D717 RID: 186135 RVA: 0x00639060 File Offset: 0x00637260
		public IAirPassageMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.Limit = null;
			this.NullMask = 0;
		}
	}
}
