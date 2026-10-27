using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004688 RID: 18056
	public class ISavePlayerDataT
	{
		// Token: 0x17008032 RID: 32818
		// (get) Token: 0x0601B69F RID: 112287 RVA: 0x003E524A File Offset: 0x003E344A
		// (set) Token: 0x0601B6A0 RID: 112288 RVA: 0x003E5252 File Offset: 0x003E3452
		public EGmCommand Type { get; set; }

		// Token: 0x0601B6A1 RID: 112289 RVA: 0x003E525B File Offset: 0x003E345B
		public ISavePlayerDataT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
