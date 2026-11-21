using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004203 RID: 16899
	public class IDarkTideXinjilemuChaseBossEventT
	{
		// Token: 0x1700730D RID: 29453
		// (get) Token: 0x06017748 RID: 96072 RVA: 0x003599B6 File Offset: 0x00357BB6
		// (set) Token: 0x06017749 RID: 96073 RVA: 0x003599BE File Offset: 0x00357BBE
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x0601774A RID: 96074 RVA: 0x003599C7 File Offset: 0x00357BC7
		public IDarkTideXinjilemuChaseBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
