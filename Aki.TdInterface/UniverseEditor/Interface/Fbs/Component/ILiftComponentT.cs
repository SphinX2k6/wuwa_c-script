using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A84 RID: 23172
	public class ILiftComponentT
	{
		// Token: 0x1700A8D5 RID: 43221
		// (get) Token: 0x06025F8D RID: 155533 RVA: 0x00534B27 File Offset: 0x00532D27
		// (set) Token: 0x06025F8E RID: 155534 RVA: 0x00534B2F File Offset: 0x00532D2F
		public bool Disabled { get; set; }

		// Token: 0x1700A8D6 RID: 43222
		// (get) Token: 0x06025F8F RID: 155535 RVA: 0x00534B38 File Offset: 0x00532D38
		// (set) Token: 0x06025F90 RID: 155536 RVA: 0x00534B40 File Offset: 0x00532D40
		public int InitialFloor { get; set; }

		// Token: 0x1700A8D7 RID: 43223
		// (get) Token: 0x06025F91 RID: 155537 RVA: 0x00534B49 File Offset: 0x00532D49
		// (set) Token: 0x06025F92 RID: 155538 RVA: 0x00534B51 File Offset: 0x00532D51
		public bool UseFloorSeqMarkMapping { get; set; }

		// Token: 0x1700A8D8 RID: 43224
		// (get) Token: 0x06025F93 RID: 155539 RVA: 0x00534B5A File Offset: 0x00532D5A
		// (set) Token: 0x06025F94 RID: 155540 RVA: 0x00534B62 File Offset: 0x00532D62
		public ELiftBuffType CustomLiftBuffType { get; set; }

		// Token: 0x1700A8D9 RID: 43225
		// (get) Token: 0x06025F95 RID: 155541 RVA: 0x00534B6B File Offset: 0x00532D6B
		// (set) Token: 0x06025F96 RID: 155542 RVA: 0x00534B73 File Offset: 0x00532D73
		public List<IVectorInfoT> StayPositions { get; set; }

		// Token: 0x1700A8DA RID: 43226
		// (get) Token: 0x06025F97 RID: 155543 RVA: 0x00534B7C File Offset: 0x00532D7C
		// (set) Token: 0x06025F98 RID: 155544 RVA: 0x00534B84 File Offset: 0x00532D84
		public IAutoConfigT AutoConfig { get; set; }

		// Token: 0x1700A8DB RID: 43227
		// (get) Token: 0x06025F99 RID: 155545 RVA: 0x00534B8D File Offset: 0x00532D8D
		// (set) Token: 0x06025F9A RID: 155546 RVA: 0x00534B95 File Offset: 0x00532D95
		public int MaxSpeed { get; set; }

		// Token: 0x1700A8DC RID: 43228
		// (get) Token: 0x06025F9B RID: 155547 RVA: 0x00534B9E File Offset: 0x00532D9E
		// (set) Token: 0x06025F9C RID: 155548 RVA: 0x00534BA6 File Offset: 0x00532DA6
		public bool UniformMovement { get; set; }

		// Token: 0x1700A8DD RID: 43229
		// (get) Token: 0x06025F9D RID: 155549 RVA: 0x00534BAF File Offset: 0x00532DAF
		// (set) Token: 0x06025F9E RID: 155550 RVA: 0x00534BB7 File Offset: 0x00532DB7
		public float TurnTime { get; set; }

		// Token: 0x1700A8DE RID: 43230
		// (get) Token: 0x06025F9F RID: 155551 RVA: 0x00534BC0 File Offset: 0x00532DC0
		// (set) Token: 0x06025FA0 RID: 155552 RVA: 0x00534BC8 File Offset: 0x00532DC8
		public IVectorInfoT SafePoint { get; set; }

		// Token: 0x1700A8DF RID: 43231
		// (get) Token: 0x06025FA1 RID: 155553 RVA: 0x00534BD1 File Offset: 0x00532DD1
		// (set) Token: 0x06025FA2 RID: 155554 RVA: 0x00534BD9 File Offset: 0x00532DD9
		public bool IsAffectedByTimeDilation { get; set; }

		// Token: 0x1700A8E0 RID: 43232
		// (get) Token: 0x06025FA3 RID: 155555 RVA: 0x00534BE2 File Offset: 0x00532DE2
		// (set) Token: 0x06025FA4 RID: 155556 RVA: 0x00534BEA File Offset: 0x00532DEA
		public bool IsSendEventOnArrive { get; set; }

		// Token: 0x1700A8E1 RID: 43233
		// (get) Token: 0x06025FA5 RID: 155557 RVA: 0x00534BF3 File Offset: 0x00532DF3
		// (set) Token: 0x06025FA6 RID: 155558 RVA: 0x00534BFB File Offset: 0x00532DFB
		public byte NullMask { get; set; }

		// Token: 0x06025FA7 RID: 155559 RVA: 0x00534C04 File Offset: 0x00532E04
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
