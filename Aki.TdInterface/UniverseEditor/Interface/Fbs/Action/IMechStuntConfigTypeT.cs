using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8F RID: 27279
	public class IMechStuntConfigTypeT
	{
		// Token: 0x1700CA86 RID: 51846
		// (get) Token: 0x0602FCEC RID: 195820 RVA: 0x006815A2 File Offset: 0x0067F7A2
		// (set) Token: 0x0602FCED RID: 195821 RVA: 0x006815AA File Offset: 0x0067F7AA
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FCEE RID: 195822 RVA: 0x006815B3 File Offset: 0x0067F7B3
		public IMechStuntConfigTypeT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
