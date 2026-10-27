using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419A RID: 16794
	public class ITakePhoto2TargetPartConditionT
	{
		// Token: 0x17007721 RID: 30497
		// (get) Token: 0x06018B7B RID: 101243 RVA: 0x0038F3F1 File Offset: 0x0038D5F1
		// (set) Token: 0x06018B7C RID: 101244 RVA: 0x0038F3F9 File Offset: 0x0038D5F9
		public List<string> Tags { get; set; }

		// Token: 0x06018B7D RID: 101245 RVA: 0x0038F402 File Offset: 0x0038D602
		public ITakePhoto2TargetPartConditionT()
		{
			this.Tags = null;
		}
	}
}
