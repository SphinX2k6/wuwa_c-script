using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757D RID: 30077
	public class IRacingTrackMoveT
	{
		// Token: 0x1700DD35 RID: 56629
		// (get) Token: 0x06034C0B RID: 216075 RVA: 0x00717E92 File Offset: 0x00716092
		// (set) Token: 0x06034C0C RID: 216076 RVA: 0x00717E9A File Offset: 0x0071609A
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700DD36 RID: 56630
		// (get) Token: 0x06034C0D RID: 216077 RVA: 0x00717EA3 File Offset: 0x007160A3
		// (set) Token: 0x06034C0E RID: 216078 RVA: 0x00717EAB File Offset: 0x007160AB
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700DD37 RID: 56631
		// (get) Token: 0x06034C0F RID: 216079 RVA: 0x00717EB4 File Offset: 0x007160B4
		// (set) Token: 0x06034C10 RID: 216080 RVA: 0x00717EBC File Offset: 0x007160BC
		public bool IsOneWay { get; set; }

		// Token: 0x1700DD38 RID: 56632
		// (get) Token: 0x06034C11 RID: 216081 RVA: 0x00717EC5 File Offset: 0x007160C5
		// (set) Token: 0x06034C12 RID: 216082 RVA: 0x00717ECD File Offset: 0x007160CD
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700DD39 RID: 56633
		// (get) Token: 0x06034C13 RID: 216083 RVA: 0x00717ED6 File Offset: 0x007160D6
		// (set) Token: 0x06034C14 RID: 216084 RVA: 0x00717EDE File Offset: 0x007160DE
		public bool DynamicGravity { get; set; }

		// Token: 0x1700DD3A RID: 56634
		// (get) Token: 0x06034C15 RID: 216085 RVA: 0x00717EE7 File Offset: 0x007160E7
		// (set) Token: 0x06034C16 RID: 216086 RVA: 0x00717EEF File Offset: 0x007160EF
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700DD3B RID: 56635
		// (get) Token: 0x06034C17 RID: 216087 RVA: 0x00717EF8 File Offset: 0x007160F8
		// (set) Token: 0x06034C18 RID: 216088 RVA: 0x00717F00 File Offset: 0x00716100
		public int AutoExitDistance { get; set; }

		// Token: 0x1700DD3C RID: 56636
		// (get) Token: 0x06034C19 RID: 216089 RVA: 0x00717F09 File Offset: 0x00716109
		// (set) Token: 0x06034C1A RID: 216090 RVA: 0x00717F11 File Offset: 0x00716111
		public float DirectionAngleLimit { get; set; }

		// Token: 0x1700DD3D RID: 56637
		// (get) Token: 0x06034C1B RID: 216091 RVA: 0x00717F1A File Offset: 0x0071611A
		// (set) Token: 0x06034C1C RID: 216092 RVA: 0x00717F22 File Offset: 0x00716122
		public byte NullMask { get; set; }

		// Token: 0x06034C1D RID: 216093 RVA: 0x00717F2C File Offset: 0x0071612C
		public IRacingTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.DirectionAngleLimit = 0f;
			this.NullMask = 0;
		}
	}
}
