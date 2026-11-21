using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD4 RID: 31444
	public class ITalkItemStyleT
	{
		// Token: 0x1700E9B9 RID: 59833
		// (get) Token: 0x060382EE RID: 230126 RVA: 0x0078FAFA File Offset: 0x0078DCFA
		// (set) Token: 0x060382EF RID: 230127 RVA: 0x0078FB02 File Offset: 0x0078DD02
		public ETalkItemStyle Type { get; set; }

		// Token: 0x060382F0 RID: 230128 RVA: 0x0078FB0B File Offset: 0x0078DD0B
		public ITalkItemStyleT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
		}
	}
}
