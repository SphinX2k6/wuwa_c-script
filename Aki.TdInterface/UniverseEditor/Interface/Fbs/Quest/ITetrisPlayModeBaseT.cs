using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004617 RID: 17943
	public class ITetrisPlayModeBaseT
	{
		// Token: 0x17007D83 RID: 32131
		// (get) Token: 0x0601A3EA RID: 107498 RVA: 0x003BCA9E File Offset: 0x003BAC9E
		// (set) Token: 0x0601A3EB RID: 107499 RVA: 0x003BCAA6 File Offset: 0x003BACA6
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x0601A3EC RID: 107500 RVA: 0x003BCAAF File Offset: 0x003BACAF
		public ITetrisPlayModeBaseT()
		{
			this.Type = ETetrisPlayMode.Normal;
		}
	}
}
