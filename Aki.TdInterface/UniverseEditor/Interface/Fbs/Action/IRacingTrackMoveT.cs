using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E02 RID: 28162
	public class IRacingTrackMoveT
	{
		// Token: 0x1700D1ED RID: 53741
		// (get) Token: 0x06031C0F RID: 203791 RVA: 0x006BC7AA File Offset: 0x006BA9AA
		// (set) Token: 0x06031C10 RID: 203792 RVA: 0x006BC7B2 File Offset: 0x006BA9B2
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700D1EE RID: 53742
		// (get) Token: 0x06031C11 RID: 203793 RVA: 0x006BC7BB File Offset: 0x006BA9BB
		// (set) Token: 0x06031C12 RID: 203794 RVA: 0x006BC7C3 File Offset: 0x006BA9C3
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D1EF RID: 53743
		// (get) Token: 0x06031C13 RID: 203795 RVA: 0x006BC7CC File Offset: 0x006BA9CC
		// (set) Token: 0x06031C14 RID: 203796 RVA: 0x006BC7D4 File Offset: 0x006BA9D4
		public bool IsOneWay { get; set; }

		// Token: 0x1700D1F0 RID: 53744
		// (get) Token: 0x06031C15 RID: 203797 RVA: 0x006BC7DD File Offset: 0x006BA9DD
		// (set) Token: 0x06031C16 RID: 203798 RVA: 0x006BC7E5 File Offset: 0x006BA9E5
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700D1F1 RID: 53745
		// (get) Token: 0x06031C17 RID: 203799 RVA: 0x006BC7EE File Offset: 0x006BA9EE
		// (set) Token: 0x06031C18 RID: 203800 RVA: 0x006BC7F6 File Offset: 0x006BA9F6
		public bool DynamicGravity { get; set; }

		// Token: 0x1700D1F2 RID: 53746
		// (get) Token: 0x06031C19 RID: 203801 RVA: 0x006BC7FF File Offset: 0x006BA9FF
		// (set) Token: 0x06031C1A RID: 203802 RVA: 0x006BC807 File Offset: 0x006BAA07
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700D1F3 RID: 53747
		// (get) Token: 0x06031C1B RID: 203803 RVA: 0x006BC810 File Offset: 0x006BAA10
		// (set) Token: 0x06031C1C RID: 203804 RVA: 0x006BC818 File Offset: 0x006BAA18
		public int AutoExitDistance { get; set; }

		// Token: 0x1700D1F4 RID: 53748
		// (get) Token: 0x06031C1D RID: 203805 RVA: 0x006BC821 File Offset: 0x006BAA21
		// (set) Token: 0x06031C1E RID: 203806 RVA: 0x006BC829 File Offset: 0x006BAA29
		public float DirectionAngleLimit { get; set; }

		// Token: 0x1700D1F5 RID: 53749
		// (get) Token: 0x06031C1F RID: 203807 RVA: 0x006BC832 File Offset: 0x006BAA32
		// (set) Token: 0x06031C20 RID: 203808 RVA: 0x006BC83A File Offset: 0x006BAA3A
		public byte NullMask { get; set; }

		// Token: 0x06031C21 RID: 203809 RVA: 0x006BC844 File Offset: 0x006BAA44
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
