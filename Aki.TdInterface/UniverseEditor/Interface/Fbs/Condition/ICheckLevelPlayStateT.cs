using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC4 RID: 19140
	public class ICheckLevelPlayStateT
	{
		// Token: 0x17008AC3 RID: 35523
		// (get) Token: 0x0601E0D6 RID: 123094 RVA: 0x00437878 File Offset: 0x00435A78
		// (set) Token: 0x0601E0D7 RID: 123095 RVA: 0x00437880 File Offset: 0x00435A80
		public ECondition Type { get; set; }

		// Token: 0x17008AC4 RID: 35524
		// (get) Token: 0x0601E0D8 RID: 123096 RVA: 0x00437889 File Offset: 0x00435A89
		// (set) Token: 0x0601E0D9 RID: 123097 RVA: 0x00437891 File Offset: 0x00435A91
		public int LevelId { get; set; }

		// Token: 0x17008AC5 RID: 35525
		// (get) Token: 0x0601E0DA RID: 123098 RVA: 0x0043789A File Offset: 0x00435A9A
		// (set) Token: 0x0601E0DB RID: 123099 RVA: 0x004378A2 File Offset: 0x00435AA2
		public ECompare Compare { get; set; }

		// Token: 0x17008AC6 RID: 35526
		// (get) Token: 0x0601E0DC RID: 123100 RVA: 0x004378AB File Offset: 0x00435AAB
		// (set) Token: 0x0601E0DD RID: 123101 RVA: 0x004378B3 File Offset: 0x00435AB3
		public ELevelPlayState State { get; set; }

		// Token: 0x0601E0DE RID: 123102 RVA: 0x004378BC File Offset: 0x00435ABC
		public ICheckLevelPlayStateT()
		{
			this.Type = ECondition.CompareVar;
			this.LevelId = 0;
			this.Compare = ECompare.Eq;
			this.State = ELevelPlayState.Close;
		}
	}
}
