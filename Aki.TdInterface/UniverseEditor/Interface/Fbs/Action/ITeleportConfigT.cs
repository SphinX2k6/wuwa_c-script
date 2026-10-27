using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007377 RID: 29559
	public class ITeleportConfigT
	{
		// Token: 0x1700E065 RID: 57445
		// (get) Token: 0x06035A58 RID: 219736 RVA: 0x0074DEB2 File Offset: 0x0074C0B2
		// (set) Token: 0x06035A59 RID: 219737 RVA: 0x0074DEBA File Offset: 0x0074C0BA
		public ETeleportType Type { get; set; }

		// Token: 0x06035A5A RID: 219738 RVA: 0x0074DEC3 File Offset: 0x0074C0C3
		public ITeleportConfigT()
		{
			this.Type = ETeleportType.FixedPos;
		}
	}
}
