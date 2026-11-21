using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005041 RID: 20545
	public class ICheckTeleControlStateT
	{
		// Token: 0x17009302 RID: 37634
		// (get) Token: 0x060201AB RID: 131499 RVA: 0x0047420A File Offset: 0x0047240A
		// (set) Token: 0x060201AC RID: 131500 RVA: 0x00474212 File Offset: 0x00472412
		public ECondition Type { get; set; }

		// Token: 0x17009303 RID: 37635
		// (get) Token: 0x060201AD RID: 131501 RVA: 0x0047421B File Offset: 0x0047241B
		// (set) Token: 0x060201AE RID: 131502 RVA: 0x00474223 File Offset: 0x00472423
		public int EntityId { get; set; }

		// Token: 0x17009304 RID: 37636
		// (get) Token: 0x060201AF RID: 131503 RVA: 0x0047422C File Offset: 0x0047242C
		// (set) Token: 0x060201B0 RID: 131504 RVA: 0x00474234 File Offset: 0x00472434
		public ECompare CompareType { get; set; }

		// Token: 0x17009305 RID: 37637
		// (get) Token: 0x060201B1 RID: 131505 RVA: 0x0047423D File Offset: 0x0047243D
		// (set) Token: 0x060201B2 RID: 131506 RVA: 0x00474245 File Offset: 0x00472445
		public ETeleControlState State { get; set; }

		// Token: 0x17009306 RID: 37638
		// (get) Token: 0x060201B3 RID: 131507 RVA: 0x0047424E File Offset: 0x0047244E
		// (set) Token: 0x060201B4 RID: 131508 RVA: 0x00474256 File Offset: 0x00472456
		public byte NullMask { get; set; }

		// Token: 0x060201B5 RID: 131509 RVA: 0x0047425F File Offset: 0x0047245F
		public ICheckTeleControlStateT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.CompareType = ECompare.Eq;
			this.State = ETeleControlState.Hold;
			this.NullMask = 0;
		}
	}
}
