using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200617D RID: 24957
	public class IAirPassageMoveT
	{
		// Token: 0x1700BA16 RID: 47638
		// (get) Token: 0x0602AFD4 RID: 176084 RVA: 0x005EE751 File Offset: 0x005EC951
		// (set) Token: 0x0602AFD5 RID: 176085 RVA: 0x005EE759 File Offset: 0x005EC959
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BA17 RID: 47639
		// (get) Token: 0x0602AFD6 RID: 176086 RVA: 0x005EE762 File Offset: 0x005EC962
		// (set) Token: 0x0602AFD7 RID: 176087 RVA: 0x005EE76A File Offset: 0x005EC96A
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700BA18 RID: 47640
		// (get) Token: 0x0602AFD8 RID: 176088 RVA: 0x005EE773 File Offset: 0x005EC973
		// (set) Token: 0x0602AFD9 RID: 176089 RVA: 0x005EE77B File Offset: 0x005EC97B
		public bool IsOneWay { get; set; }

		// Token: 0x1700BA19 RID: 47641
		// (get) Token: 0x0602AFDA RID: 176090 RVA: 0x005EE784 File Offset: 0x005EC984
		// (set) Token: 0x0602AFDB RID: 176091 RVA: 0x005EE78C File Offset: 0x005EC98C
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700BA1A RID: 47642
		// (get) Token: 0x0602AFDC RID: 176092 RVA: 0x005EE795 File Offset: 0x005EC995
		// (set) Token: 0x0602AFDD RID: 176093 RVA: 0x005EE79D File Offset: 0x005EC99D
		public bool DynamicGravity { get; set; }

		// Token: 0x1700BA1B RID: 47643
		// (get) Token: 0x0602AFDE RID: 176094 RVA: 0x005EE7A6 File Offset: 0x005EC9A6
		// (set) Token: 0x0602AFDF RID: 176095 RVA: 0x005EE7AE File Offset: 0x005EC9AE
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BA1C RID: 47644
		// (get) Token: 0x0602AFE0 RID: 176096 RVA: 0x005EE7B7 File Offset: 0x005EC9B7
		// (set) Token: 0x0602AFE1 RID: 176097 RVA: 0x005EE7BF File Offset: 0x005EC9BF
		public int AutoExitDistance { get; set; }

		// Token: 0x1700BA1D RID: 47645
		// (get) Token: 0x0602AFE2 RID: 176098 RVA: 0x005EE7C8 File Offset: 0x005EC9C8
		// (set) Token: 0x0602AFE3 RID: 176099 RVA: 0x005EE7D0 File Offset: 0x005EC9D0
		public IAirPassageMoveLimitT Limit { get; set; }

		// Token: 0x1700BA1E RID: 47646
		// (get) Token: 0x0602AFE4 RID: 176100 RVA: 0x005EE7D9 File Offset: 0x005EC9D9
		// (set) Token: 0x0602AFE5 RID: 176101 RVA: 0x005EE7E1 File Offset: 0x005EC9E1
		public byte NullMask { get; set; }

		// Token: 0x0602AFE6 RID: 176102 RVA: 0x005EE7EC File Offset: 0x005EC9EC
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
