using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F66 RID: 28518
	public class IHandBookProgressOptionT
	{
		// Token: 0x1700D0F2 RID: 53490
		// (get) Token: 0x060315CE RID: 202190 RVA: 0x006B1ECE File Offset: 0x006B00CE
		// (set) Token: 0x060315CF RID: 202191 RVA: 0x006B1ED6 File Offset: 0x006B00D6
		public EHandBookProgressType Type { get; set; }

		// Token: 0x060315D0 RID: 202192 RVA: 0x006B1EDF File Offset: 0x006B00DF
		public IHandBookProgressOptionT()
		{
			this.Type = EHandBookProgressType.GrantEmoji;
		}
	}
}
