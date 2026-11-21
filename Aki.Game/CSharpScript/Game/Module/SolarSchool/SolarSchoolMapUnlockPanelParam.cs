using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A4B RID: 23115
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolMapUnlockPanelParam : SolarSchoolMapPanelParam
	{
		// Token: 0x17006C88 RID: 27784
		// (get) Token: 0x06038F7C RID: 233340 RVA: 0x00FF603F File Offset: 0x00FF423F
		[Nullable(1)]
		public IReadOnlyList<int> UnlockLocationIds { [NullableContext(1)] get; }

		// Token: 0x17006C89 RID: 27785
		// (get) Token: 0x06038F7D RID: 233341 RVA: 0x00FF6047 File Offset: 0x00FF4247
		public Action OnUnlockStarted { get; }

		// Token: 0x17006C8A RID: 27786
		// (get) Token: 0x06038F7E RID: 233342 RVA: 0x00FF604F File Offset: 0x00FF424F
		public Action<bool> OnUnlockFinished { get; }

		// Token: 0x06038F7F RID: 233343 RVA: 0x00FF6057 File Offset: 0x00FF4257
		public SolarSchoolMapUnlockPanelParam([Nullable(1)] IReadOnlyList<int> unlockLocationIds, Action onUnlockStarted, Action<bool> onUnlockFinished)
		{
			this.UnlockLocationIds = new List<int>(unlockLocationIds);
			this.OnUnlockStarted = onUnlockStarted;
			this.OnUnlockFinished = onUnlockFinished;
		}
	}
}
