using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C7 RID: 26567
	public readonly struct StarMatch
	{
		// Token: 0x06042296 RID: 270998 RVA: 0x0100B2AE File Offset: 0x010094AE
		public StarMatch(int ownerUid, int starIndex, int satisfierUid)
		{
			this.OwnerUid = ownerUid;
			this.StarIndex = starIndex;
			this.SatisfierUid = satisfierUid;
		}

		// Token: 0x040228A8 RID: 141480
		public readonly int OwnerUid;

		// Token: 0x040228A9 RID: 141481
		public readonly int StarIndex;

		// Token: 0x040228AA RID: 141482
		public readonly int SatisfierUid;
	}
}
