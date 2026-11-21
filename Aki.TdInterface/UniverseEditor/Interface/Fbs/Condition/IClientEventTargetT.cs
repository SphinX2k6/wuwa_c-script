using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005062 RID: 20578
	public class IClientEventTargetT
	{
		// Token: 0x1700934B RID: 37707
		// (get) Token: 0x060202CD RID: 131789 RVA: 0x004761C6 File Offset: 0x004743C6
		// (set) Token: 0x060202CE RID: 131790 RVA: 0x004761CE File Offset: 0x004743CE
		public EClientEventTarget Type { get; set; }

		// Token: 0x060202CF RID: 131791 RVA: 0x004761D7 File Offset: 0x004743D7
		public IClientEventTargetT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
