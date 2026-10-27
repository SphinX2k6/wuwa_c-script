using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004D67 RID: 19815
	public enum EAiWanderType : ushort
	{
		// Token: 0x0400D7C5 RID: 55237
		None,
		// Token: 0x0400D7C6 RID: 55238
		SmallRange = 300,
		// Token: 0x0400D7C7 RID: 55239
		SmallRangeLargeBody,
		// Token: 0x0400D7C8 RID: 55240
		MiddleRange = 600,
		// Token: 0x0400D7C9 RID: 55241
		MiddleRangeLargeBody,
		// Token: 0x0400D7CA RID: 55242
		BigRange = 1000,
		// Token: 0x0400D7CB RID: 55243
		BigRangeLargeBody
	}
}
