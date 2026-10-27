using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C2 RID: 25026
	public class IAvgMoveRoleT
	{
		// Token: 0x1700BA93 RID: 47763
		// (get) Token: 0x0602B1FA RID: 176634 RVA: 0x005F1FE3 File Offset: 0x005F01E3
		// (set) Token: 0x0602B1FB RID: 176635 RVA: 0x005F1FEB File Offset: 0x005F01EB
		public int RoleId { get; set; }

		// Token: 0x1700BA94 RID: 47764
		// (get) Token: 0x0602B1FC RID: 176636 RVA: 0x005F1FF4 File Offset: 0x005F01F4
		// (set) Token: 0x0602B1FD RID: 176637 RVA: 0x005F1FFC File Offset: 0x005F01FC
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x1700BA95 RID: 47765
		// (get) Token: 0x0602B1FE RID: 176638 RVA: 0x005F2005 File Offset: 0x005F0205
		// (set) Token: 0x0602B1FF RID: 176639 RVA: 0x005F200D File Offset: 0x005F020D
		public bool IsAnimationLoop { get; set; }

		// Token: 0x1700BA96 RID: 47766
		// (get) Token: 0x0602B200 RID: 176640 RVA: 0x005F2016 File Offset: 0x005F0216
		// (set) Token: 0x0602B201 RID: 176641 RVA: 0x005F201E File Offset: 0x005F021E
		public EAvgRolePosition TargetPosition { get; set; }

		// Token: 0x1700BA97 RID: 47767
		// (get) Token: 0x0602B202 RID: 176642 RVA: 0x005F2027 File Offset: 0x005F0227
		// (set) Token: 0x0602B203 RID: 176643 RVA: 0x005F202F File Offset: 0x005F022F
		public IEaseDataT EaseCurve { get; set; }

		// Token: 0x1700BA98 RID: 47768
		// (get) Token: 0x0602B204 RID: 176644 RVA: 0x005F2038 File Offset: 0x005F0238
		// (set) Token: 0x0602B205 RID: 176645 RVA: 0x005F2040 File Offset: 0x005F0240
		public byte NullMask { get; set; }

		// Token: 0x0602B206 RID: 176646 RVA: 0x005F2049 File Offset: 0x005F0249
		public IAvgMoveRoleT()
		{
			this.RoleId = 0;
			this.AnimationType = EAvgRoleAnimationType.Idle;
			this.IsAnimationLoop = false;
			this.TargetPosition = EAvgRolePosition.Center;
			this.EaseCurve = null;
			this.NullMask = 0;
		}
	}
}
