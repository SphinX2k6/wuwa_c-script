using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005717 RID: 22295
	public readonly struct StarMatch
	{
		// Token: 0x06036DEC RID: 224748 RVA: 0x00F4C692 File Offset: 0x00F4A892
		public StarMatch(int ownerUid, int starIndex, int satisfierUid)
		{
			this.OwnerUid = ownerUid;
			this.StarIndex = starIndex;
			this.SatisfierUid = satisfierUid;
		}

		// Token: 0x0401D105 RID: 119045
		public readonly int OwnerUid;

		// Token: 0x0401D106 RID: 119046
		public readonly int StarIndex;

		// Token: 0x0401D107 RID: 119047
		public readonly int SatisfierUid;
	}
}
