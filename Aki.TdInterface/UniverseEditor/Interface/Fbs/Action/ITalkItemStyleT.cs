using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FF RID: 29439
	public class ITalkItemStyleT
	{
		// Token: 0x1700DDC0 RID: 56768
		// (get) Token: 0x06034FE8 RID: 217064 RVA: 0x0072E696 File Offset: 0x0072C896
		// (set) Token: 0x06034FE9 RID: 217065 RVA: 0x0072E69E File Offset: 0x0072C89E
		public ETalkItemStyle Type { get; set; }

		// Token: 0x06034FEA RID: 217066 RVA: 0x0072E6A7 File Offset: 0x0072C8A7
		public ITalkItemStyleT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
		}
	}
}
