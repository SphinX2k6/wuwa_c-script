using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004530 RID: 17712
	public class IRollBlockLaunchMethodRangeT
	{
		// Token: 0x17007B31 RID: 31537
		// (get) Token: 0x06019A46 RID: 105030 RVA: 0x003A6F08 File Offset: 0x003A5108
		// (set) Token: 0x06019A47 RID: 105031 RVA: 0x003A6F10 File Offset: 0x003A5110
		public ERollBlockLaunchMethod Type { get; set; }

		// Token: 0x17007B32 RID: 31538
		// (get) Token: 0x06019A48 RID: 105032 RVA: 0x003A6F19 File Offset: 0x003A5119
		// (set) Token: 0x06019A49 RID: 105033 RVA: 0x003A6F21 File Offset: 0x003A5121
		public int TargetId { get; set; }

		// Token: 0x06019A4A RID: 105034 RVA: 0x003A6F2A File Offset: 0x003A512A
		public IRollBlockLaunchMethodRangeT()
		{
			this.Type = ERollBlockLaunchMethod.Interact;
			this.TargetId = 0;
		}
	}
}
