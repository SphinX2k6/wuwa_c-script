using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C2 RID: 25538
	public class IClientFollowShooterLeisureInteractTypeT
	{
		// Token: 0x1700BE4D RID: 48717
		// (get) Token: 0x0602C2D7 RID: 180951 RVA: 0x00610D72 File Offset: 0x0060EF72
		// (set) Token: 0x0602C2D8 RID: 180952 RVA: 0x00610D7A File Offset: 0x0060EF7A
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x0602C2D9 RID: 180953 RVA: 0x00610D83 File Offset: 0x0060EF83
		public IClientFollowShooterLeisureInteractTypeT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.ResetToPlayer;
		}
	}
}
