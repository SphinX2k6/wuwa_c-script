using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF6 RID: 19446
	public class ICustomJsonConditionT
	{
		// Token: 0x17008D41 RID: 36161
		// (get) Token: 0x0601ECA3 RID: 126115 RVA: 0x00450280 File Offset: 0x0044E480
		// (set) Token: 0x0601ECA4 RID: 126116 RVA: 0x00450288 File Offset: 0x0044E488
		public ECondition Type { get; set; }

		// Token: 0x17008D42 RID: 36162
		// (get) Token: 0x0601ECA5 RID: 126117 RVA: 0x00450291 File Offset: 0x0044E491
		// (set) Token: 0x0601ECA6 RID: 126118 RVA: 0x00450299 File Offset: 0x0044E499
		public string Name { get; set; }

		// Token: 0x17008D43 RID: 36163
		// (get) Token: 0x0601ECA7 RID: 126119 RVA: 0x004502A2 File Offset: 0x0044E4A2
		// (set) Token: 0x0601ECA8 RID: 126120 RVA: 0x004502AA File Offset: 0x0044E4AA
		public string JsonString { get; set; }

		// Token: 0x0601ECA9 RID: 126121 RVA: 0x004502B3 File Offset: 0x0044E4B3
		public ICustomJsonConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Name = null;
			this.JsonString = null;
		}
	}
}
