using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A60 RID: 27232
	public class IClientPreEnableSubLevelsT
	{
		// Token: 0x1700C811 RID: 51217
		// (get) Token: 0x0602EB91 RID: 191377 RVA: 0x0065E600 File Offset: 0x0065C800
		// (set) Token: 0x0602EB92 RID: 191378 RVA: 0x0065E608 File Offset: 0x0065C808
		public List<string> EnableLevels { get; set; }

		// Token: 0x1700C812 RID: 51218
		// (get) Token: 0x0602EB93 RID: 191379 RVA: 0x0065E611 File Offset: 0x0065C811
		// (set) Token: 0x0602EB94 RID: 191380 RVA: 0x0065E619 File Offset: 0x0065C819
		public List<string> DisableLevels { get; set; }

		// Token: 0x1700C813 RID: 51219
		// (get) Token: 0x0602EB95 RID: 191381 RVA: 0x0065E622 File Offset: 0x0065C822
		// (set) Token: 0x0602EB96 RID: 191382 RVA: 0x0065E62A File Offset: 0x0065C82A
		public IEnableSubLevelTransitionWithSceneCaptureT TransitionOption { get; set; }

		// Token: 0x1700C814 RID: 51220
		// (get) Token: 0x0602EB97 RID: 191383 RVA: 0x0065E633 File Offset: 0x0065C833
		// (set) Token: 0x0602EB98 RID: 191384 RVA: 0x0065E63B File Offset: 0x0065C83B
		public bool IsWaitForEnableComplete { get; set; }

		// Token: 0x1700C815 RID: 51221
		// (get) Token: 0x0602EB99 RID: 191385 RVA: 0x0065E644 File Offset: 0x0065C844
		// (set) Token: 0x0602EB9A RID: 191386 RVA: 0x0065E64C File Offset: 0x0065C84C
		public byte NullMask { get; set; }

		// Token: 0x0602EB9B RID: 191387 RVA: 0x0065E655 File Offset: 0x0065C855
		public IClientPreEnableSubLevelsT()
		{
			this.EnableLevels = null;
			this.DisableLevels = null;
			this.TransitionOption = null;
			this.IsWaitForEnableComplete = false;
			this.NullMask = 0;
		}
	}
}
