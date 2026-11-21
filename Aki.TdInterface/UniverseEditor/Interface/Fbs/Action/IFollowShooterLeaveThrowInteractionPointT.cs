using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED9 RID: 28377
	public class IFollowShooterLeaveThrowInteractionPointT
	{
		// Token: 0x1700D020 RID: 53280
		// (get) Token: 0x06031193 RID: 201107 RVA: 0x006A82E6 File Offset: 0x006A64E6
		// (set) Token: 0x06031194 RID: 201108 RVA: 0x006A82EE File Offset: 0x006A64EE
		public EFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x06031195 RID: 201109 RVA: 0x006A82F7 File Offset: 0x006A64F7
		public IFollowShooterLeaveThrowInteractionPointT()
		{
			this.Type = EFollowShooterLeisureInteractType.ResetToPlayer;
		}
	}
}
