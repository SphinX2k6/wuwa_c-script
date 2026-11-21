using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005346 RID: 21318
	public enum EVehicleFeatureFlag : byte
	{
		// Token: 0x0400E71A RID: 59162
		None,
		// Token: 0x0400E71B RID: 59163
		Movement,
		// Token: 0x0400E71C RID: 59164
		Battle,
		// Token: 0x0400E71D RID: 59165
		Audio = 4,
		// Token: 0x0400E71E RID: 59166
		MovablePlatform = 8,
		// Token: 0x0400E71F RID: 59167
		Sharing = 16,
		// Token: 0x0400E720 RID: 59168
		Performance = 32
	}
}
