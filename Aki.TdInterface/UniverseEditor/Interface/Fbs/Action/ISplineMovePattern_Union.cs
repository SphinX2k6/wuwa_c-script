using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718D RID: 29069
	public enum ISplineMovePattern_Union : byte
	{
		// Token: 0x04011C45 RID: 72773
		NONE,
		// Token: 0x04011C46 RID: 72774
		ISplineMovePattern,
		// Token: 0x04011C47 RID: 72775
		IPathLineMove,
		// Token: 0x04011C48 RID: 72776
		IRacingTrackMove,
		// Token: 0x04011C49 RID: 72777
		ISlideTrackMove,
		// Token: 0x04011C4A RID: 72778
		IAirPassageMove,
		// Token: 0x04011C4B RID: 72779
		IMechaAirPassageMove,
		// Token: 0x04011C4C RID: 72780
		IMotorcycleTrack
	}
}
