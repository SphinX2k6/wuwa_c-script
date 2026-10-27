using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005969 RID: 22889
	public class GiantSystemQuestOpenParam : IGiantSystemQuestOpenParam
	{
		// Token: 0x17008B30 RID: 35632
		// (get) Token: 0x0603A128 RID: 237864 RVA: 0x00DCD862 File Offset: 0x00DCBA62
		// (set) Token: 0x0603A129 RID: 237865 RVA: 0x00DCD86A File Offset: 0x00DCBA6A
		public GiantEcoNetType EcoType { get; set; }

		// Token: 0x17008B31 RID: 35633
		// (get) Token: 0x0603A12A RID: 237866 RVA: 0x00DCD873 File Offset: 0x00DCBA73
		// (set) Token: 0x0603A12B RID: 237867 RVA: 0x00DCD87B File Offset: 0x00DCBA7B
		public bool? GuideOnly { get; set; }
	}
}
