using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058CD RID: 22733
	public sealed class SolarSchoolEndingSnapshotRoleEntry
	{
		// Token: 0x17006B60 RID: 27488
		// (get) Token: 0x06037FB1 RID: 229297 RVA: 0x00FA5E6D File Offset: 0x00FA406D
		public bool IsUnlocked { get; }

		// Token: 0x17006B61 RID: 27489
		// (get) Token: 0x06037FB2 RID: 229298 RVA: 0x00FA5E75 File Offset: 0x00FA4075
		public int FavorLevel { get; }

		// Token: 0x17006B62 RID: 27490
		// (get) Token: 0x06037FB3 RID: 229299 RVA: 0x00FA5E7D File Offset: 0x00FA407D
		public bool IsFavorValueFull { get; }

		// Token: 0x17006B63 RID: 27491
		// (get) Token: 0x06037FB4 RID: 229300 RVA: 0x00FA5E85 File Offset: 0x00FA4085
		public int GiftReceivedCount { get; }

		// Token: 0x06037FB5 RID: 229301 RVA: 0x00FA5E8D File Offset: 0x00FA408D
		[NullableContext(1)]
		public SolarSchoolEndingSnapshotRoleEntry(SolarSchoolRoleData role)
		{
			this.IsUnlocked = role.IsUnlocked;
			this.FavorLevel = role.FavorLevel;
			this.IsFavorValueFull = role.IsFavorValueFull();
			this.GiftReceivedCount = role.GiftReceivedCount;
		}
	}
}
