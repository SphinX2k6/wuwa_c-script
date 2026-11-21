using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004608 RID: 17928
	public class ITakePhotoTimeConditionT
	{
		// Token: 0x17007D6F RID: 32111
		// (get) Token: 0x0601A37C RID: 107388 RVA: 0x003BBD91 File Offset: 0x003B9F91
		// (set) Token: 0x0601A37D RID: 107389 RVA: 0x003BBD99 File Offset: 0x003B9F99
		public IHourToHourT TimeRange { get; set; }

		// Token: 0x17007D70 RID: 32112
		// (get) Token: 0x0601A37E RID: 107390 RVA: 0x003BBDA2 File Offset: 0x003B9FA2
		// (set) Token: 0x0601A37F RID: 107391 RVA: 0x003BBDAA File Offset: 0x003B9FAA
		public ECompare Compare { get; set; }

		// Token: 0x17007D71 RID: 32113
		// (get) Token: 0x0601A380 RID: 107392 RVA: 0x003BBDB3 File Offset: 0x003B9FB3
		// (set) Token: 0x0601A381 RID: 107393 RVA: 0x003BBDBB File Offset: 0x003B9FBB
		public string TidDescription { get; set; }

		// Token: 0x0601A382 RID: 107394 RVA: 0x003BBDC4 File Offset: 0x003B9FC4
		public ITakePhotoTimeConditionT()
		{
			this.TimeRange = null;
			this.Compare = ECompare.Eq;
			this.TidDescription = null;
		}
	}
}
