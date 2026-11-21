using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F15 RID: 28437
	public class IGamepadShakeInTalkT
	{
		// Token: 0x1700D083 RID: 53379
		// (get) Token: 0x06031363 RID: 201571 RVA: 0x006AB2BB File Offset: 0x006A94BB
		// (set) Token: 0x06031364 RID: 201572 RVA: 0x006AB2C3 File Offset: 0x006A94C3
		public float DelayTime { get; set; }

		// Token: 0x1700D084 RID: 53380
		// (get) Token: 0x06031365 RID: 201573 RVA: 0x006AB2CC File Offset: 0x006A94CC
		// (set) Token: 0x06031366 RID: 201574 RVA: 0x006AB2D4 File Offset: 0x006A94D4
		public IGamepadShakeOptionsT Options { get; set; }

		// Token: 0x06031367 RID: 201575 RVA: 0x006AB2DD File Offset: 0x006A94DD
		public IGamepadShakeInTalkT()
		{
			this.DelayTime = 0f;
			this.Options = null;
		}
	}
}
