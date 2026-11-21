using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EC RID: 21484
	public class IAttachTimingT
	{
		// Token: 0x17009809 RID: 38921
		// (get) Token: 0x0602192F RID: 137519 RVA: 0x004A1216 File Offset: 0x0049F416
		// (set) Token: 0x06021930 RID: 137520 RVA: 0x004A121E File Offset: 0x0049F41E
		public EAttachTimingType Type { get; set; }

		// Token: 0x06021931 RID: 137521 RVA: 0x004A1227 File Offset: 0x0049F427
		public IAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
		}
	}
}
