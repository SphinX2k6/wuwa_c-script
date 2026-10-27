using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A7 RID: 26791
	public class IGroupAiCommunicateModeT
	{
		// Token: 0x1700C6E6 RID: 50918
		// (get) Token: 0x0602EBB4 RID: 191412 RVA: 0x0065ECB2 File Offset: 0x0065CEB2
		// (set) Token: 0x0602EBB5 RID: 191413 RVA: 0x0065ECBA File Offset: 0x0065CEBA
		public EGroupAiCommunicateType Type { get; set; }

		// Token: 0x0602EBB6 RID: 191414 RVA: 0x0065ECC3 File Offset: 0x0065CEC3
		public IGroupAiCommunicateModeT()
		{
			this.Type = EGroupAiCommunicateType.AddTag;
		}
	}
}
