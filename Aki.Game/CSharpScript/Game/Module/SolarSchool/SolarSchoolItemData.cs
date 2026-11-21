using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D0 RID: 22736
	public sealed class SolarSchoolItemData
	{
		// Token: 0x17006B65 RID: 27493
		// (get) Token: 0x06037FD5 RID: 229333 RVA: 0x00FA6813 File Offset: 0x00FA4A13
		public int ItemId { get; }

		// Token: 0x17006B66 RID: 27494
		// (get) Token: 0x06037FD6 RID: 229334 RVA: 0x00FA681B File Offset: 0x00FA4A1B
		// (set) Token: 0x06037FD7 RID: 229335 RVA: 0x00FA6823 File Offset: 0x00FA4A23
		public int Count { get; private set; }

		// Token: 0x06037FD8 RID: 229336 RVA: 0x00FA682C File Offset: 0x00FA4A2C
		public SolarSchoolItemData(int itemId, int count)
		{
			this.ItemId = itemId;
			this.Count = count;
		}

		// Token: 0x06037FD9 RID: 229337 RVA: 0x00FA6842 File Offset: 0x00FA4A42
		internal void SetCount(int count)
		{
			this.Count = count;
		}
	}
}
