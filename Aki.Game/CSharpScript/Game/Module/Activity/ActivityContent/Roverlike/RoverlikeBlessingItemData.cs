using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005103 RID: 20739
	public class RoverlikeBlessingItemData : IRoverlikeBlessingItemData
	{
		// Token: 0x1700652A RID: 25898
		// (get) Token: 0x06033E34 RID: 212532 RVA: 0x00E85F71 File Offset: 0x00E84171
		// (set) Token: 0x06033E35 RID: 212533 RVA: 0x00E85F79 File Offset: 0x00E84179
		public int BlessId { get; set; }

		// Token: 0x1700652B RID: 25899
		// (get) Token: 0x06033E36 RID: 212534 RVA: 0x00E85F82 File Offset: 0x00E84182
		// (set) Token: 0x06033E37 RID: 212535 RVA: 0x00E85F8A File Offset: 0x00E8418A
		public int? IncId { get; set; }

		// Token: 0x1700652C RID: 25900
		// (get) Token: 0x06033E38 RID: 212536 RVA: 0x00E85F93 File Offset: 0x00E84193
		// (set) Token: 0x06033E39 RID: 212537 RVA: 0x00E85F9B File Offset: 0x00E8419B
		public bool? AllowToggleInteract { get; set; }

		// Token: 0x1700652D RID: 25901
		// (get) Token: 0x06033E3A RID: 212538 RVA: 0x00E85FA4 File Offset: 0x00E841A4
		// (set) Token: 0x06033E3B RID: 212539 RVA: 0x00E85FAC File Offset: 0x00E841AC
		public bool? IsUp { get; set; }

		// Token: 0x1700652E RID: 25902
		// (get) Token: 0x06033E3C RID: 212540 RVA: 0x00E85FB5 File Offset: 0x00E841B5
		// (set) Token: 0x06033E3D RID: 212541 RVA: 0x00E85FBD File Offset: 0x00E841BD
		public bool? CheckSameSlot { get; set; }

		// Token: 0x1700652F RID: 25903
		// (get) Token: 0x06033E3E RID: 212542 RVA: 0x00E85FC6 File Offset: 0x00E841C6
		// (set) Token: 0x06033E3F RID: 212543 RVA: 0x00E85FCE File Offset: 0x00E841CE
		public bool? ShowRecommend { get; set; }
	}
}
