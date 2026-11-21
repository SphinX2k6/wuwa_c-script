using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAF RID: 27567
	public class IDartInteractTypeBaseT
	{
		// Token: 0x1700CA40 RID: 51776
		// (get) Token: 0x0602F724 RID: 194340 RVA: 0x00678D2E File Offset: 0x00676F2E
		// (set) Token: 0x0602F725 RID: 194341 RVA: 0x00678D36 File Offset: 0x00676F36
		public EDartInteractType Type { get; set; }

		// Token: 0x0602F726 RID: 194342 RVA: 0x00678D3F File Offset: 0x00676F3F
		public IDartInteractTypeBaseT()
		{
			this.Type = EDartInteractType.Machine;
		}
	}
}
