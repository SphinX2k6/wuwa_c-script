using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C92 RID: 19602
	public class IBuffDurationBaseT
	{
		// Token: 0x17008AE7 RID: 35559
		// (get) Token: 0x0601E0EC RID: 123116 RVA: 0x0043683A File Offset: 0x00434A3A
		// (set) Token: 0x0601E0ED RID: 123117 RVA: 0x00436842 File Offset: 0x00434A42
		public EBuffDurationType Type { get; set; }

		// Token: 0x0601E0EE RID: 123118 RVA: 0x0043684B File Offset: 0x00434A4B
		public IBuffDurationBaseT()
		{
			this.Type = EBuffDurationType.Instant;
		}
	}
}
