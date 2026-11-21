using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D4 RID: 22740
	public class IGroupFinishConfigT
	{
		// Token: 0x1700A4EC RID: 42220
		// (get) Token: 0x06024EE8 RID: 151272 RVA: 0x005121D2 File Offset: 0x005103D2
		// (set) Token: 0x06024EE9 RID: 151273 RVA: 0x005121DA File Offset: 0x005103DA
		public EGroupFinishConfig Type { get; set; }

		// Token: 0x06024EEA RID: 151274 RVA: 0x005121E3 File Offset: 0x005103E3
		public IGroupFinishConfigT()
		{
			this.Type = EGroupFinishConfig.Silence;
		}
	}
}
