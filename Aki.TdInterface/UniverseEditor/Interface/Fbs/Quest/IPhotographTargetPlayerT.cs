using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D4 RID: 17364
	public class IPhotographTargetPlayerT
	{
		// Token: 0x1700779C RID: 30620
		// (get) Token: 0x06018A83 RID: 100995 RVA: 0x003842FD File Offset: 0x003824FD
		// (set) Token: 0x06018A84 RID: 100996 RVA: 0x00384305 File Offset: 0x00382505
		public EPhotographTargetType Type { get; set; }

		// Token: 0x1700779D RID: 30621
		// (get) Token: 0x06018A85 RID: 100997 RVA: 0x0038430E File Offset: 0x0038250E
		// (set) Token: 0x06018A86 RID: 100998 RVA: 0x00384316 File Offset: 0x00382516
		public int RoleId { get; set; }

		// Token: 0x1700779E RID: 30622
		// (get) Token: 0x06018A87 RID: 100999 RVA: 0x0038431F File Offset: 0x0038251F
		// (set) Token: 0x06018A88 RID: 101000 RVA: 0x00384327 File Offset: 0x00382527
		public EOnCameraCheckType OnCameraCheckType { get; set; }

		// Token: 0x1700779F RID: 30623
		// (get) Token: 0x06018A89 RID: 101001 RVA: 0x00384330 File Offset: 0x00382530
		// (set) Token: 0x06018A8A RID: 101002 RVA: 0x00384338 File Offset: 0x00382538
		public IConditionGroupT CommonCondition { get; set; }

		// Token: 0x170077A0 RID: 30624
		// (get) Token: 0x06018A8B RID: 101003 RVA: 0x00384341 File Offset: 0x00382541
		// (set) Token: 0x06018A8C RID: 101004 RVA: 0x00384349 File Offset: 0x00382549
		public byte NullMask { get; set; }

		// Token: 0x06018A8D RID: 101005 RVA: 0x00384352 File Offset: 0x00382552
		public IPhotographTargetPlayerT()
		{
			this.Type = EPhotographTargetType.Player;
			this.RoleId = 0;
			this.OnCameraCheckType = EOnCameraCheckType.All;
			this.CommonCondition = null;
			this.NullMask = 0;
		}
	}
}
