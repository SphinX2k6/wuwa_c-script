using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD7 RID: 27351
	public class ICommonBtOverrideTaskInfoBaseT
	{
		// Token: 0x1700C8D7 RID: 51415
		// (get) Token: 0x0602EFDE RID: 192478 RVA: 0x00668B82 File Offset: 0x00666D82
		// (set) Token: 0x0602EFDF RID: 192479 RVA: 0x00668B8A File Offset: 0x00666D8A
		public ECommonBtPlaceholderTargetType Type { get; set; }

		// Token: 0x0602EFE0 RID: 192480 RVA: 0x00668B93 File Offset: 0x00666D93
		public ICommonBtOverrideTaskInfoBaseT()
		{
			this.Type = ECommonBtPlaceholderTargetType.Action;
		}
	}
}
