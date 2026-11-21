using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C98 RID: 19608
	public class IBuffDurationInstantT
	{
		// Token: 0x17008AEC RID: 35564
		// (get) Token: 0x0601E10E RID: 123150 RVA: 0x00436B3E File Offset: 0x00434D3E
		// (set) Token: 0x0601E10F RID: 123151 RVA: 0x00436B46 File Offset: 0x00434D46
		public EBuffDurationType Type { get; set; }

		// Token: 0x0601E110 RID: 123152 RVA: 0x00436B4F File Offset: 0x00434D4F
		public IBuffDurationInstantT()
		{
			this.Type = EBuffDurationType.Instant;
		}
	}
}
