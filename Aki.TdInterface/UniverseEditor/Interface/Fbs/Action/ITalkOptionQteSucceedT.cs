using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B22 RID: 31522
	public class ITalkOptionQteSucceedT
	{
		// Token: 0x1700EC18 RID: 60440
		// (get) Token: 0x06038C29 RID: 232489 RVA: 0x007AD25E File Offset: 0x007AB45E
		// (set) Token: 0x06038C2A RID: 232490 RVA: 0x007AD266 File Offset: 0x007AB466
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x06038C2B RID: 232491 RVA: 0x007AD26F File Offset: 0x007AB46F
		public ITalkOptionQteSucceedT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
