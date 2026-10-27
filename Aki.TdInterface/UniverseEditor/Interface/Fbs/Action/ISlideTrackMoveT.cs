using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007158 RID: 29016
	public class ISlideTrackMoveT
	{
		// Token: 0x1700D799 RID: 55193
		// (get) Token: 0x0603371E RID: 210718 RVA: 0x006EE8F8 File Offset: 0x006ECAF8
		// (set) Token: 0x0603371F RID: 210719 RVA: 0x006EE900 File Offset: 0x006ECB00
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700D79A RID: 55194
		// (get) Token: 0x06033720 RID: 210720 RVA: 0x006EE909 File Offset: 0x006ECB09
		// (set) Token: 0x06033721 RID: 210721 RVA: 0x006EE911 File Offset: 0x006ECB11
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D79B RID: 55195
		// (get) Token: 0x06033722 RID: 210722 RVA: 0x006EE91A File Offset: 0x006ECB1A
		// (set) Token: 0x06033723 RID: 210723 RVA: 0x006EE922 File Offset: 0x006ECB22
		public bool IsOneWay { get; set; }

		// Token: 0x1700D79C RID: 55196
		// (get) Token: 0x06033724 RID: 210724 RVA: 0x006EE92B File Offset: 0x006ECB2B
		// (set) Token: 0x06033725 RID: 210725 RVA: 0x006EE933 File Offset: 0x006ECB33
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700D79D RID: 55197
		// (get) Token: 0x06033726 RID: 210726 RVA: 0x006EE93C File Offset: 0x006ECB3C
		// (set) Token: 0x06033727 RID: 210727 RVA: 0x006EE944 File Offset: 0x006ECB44
		public bool DynamicGravity { get; set; }

		// Token: 0x1700D79E RID: 55198
		// (get) Token: 0x06033728 RID: 210728 RVA: 0x006EE94D File Offset: 0x006ECB4D
		// (set) Token: 0x06033729 RID: 210729 RVA: 0x006EE955 File Offset: 0x006ECB55
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700D79F RID: 55199
		// (get) Token: 0x0603372A RID: 210730 RVA: 0x006EE95E File Offset: 0x006ECB5E
		// (set) Token: 0x0603372B RID: 210731 RVA: 0x006EE966 File Offset: 0x006ECB66
		public int AutoExitDistance { get; set; }

		// Token: 0x1700D7A0 RID: 55200
		// (get) Token: 0x0603372C RID: 210732 RVA: 0x006EE96F File Offset: 0x006ECB6F
		// (set) Token: 0x0603372D RID: 210733 RVA: 0x006EE977 File Offset: 0x006ECB77
		public float DirectionAngleLimit { get; set; }

		// Token: 0x1700D7A1 RID: 55201
		// (get) Token: 0x0603372E RID: 210734 RVA: 0x006EE980 File Offset: 0x006ECB80
		// (set) Token: 0x0603372F RID: 210735 RVA: 0x006EE988 File Offset: 0x006ECB88
		public float EdgeLimitCurveFactor { get; set; }

		// Token: 0x1700D7A2 RID: 55202
		// (get) Token: 0x06033730 RID: 210736 RVA: 0x006EE991 File Offset: 0x006ECB91
		// (set) Token: 0x06033731 RID: 210737 RVA: 0x006EE999 File Offset: 0x006ECB99
		public byte NullMask { get; set; }

		// Token: 0x06033732 RID: 210738 RVA: 0x006EE9A4 File Offset: 0x006ECBA4
		public ISlideTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.DirectionAngleLimit = 0f;
			this.EdgeLimitCurveFactor = 0f;
			this.NullMask = 0;
		}
	}
}
