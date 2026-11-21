using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771B RID: 30491
	public class ISelfEntityT
	{
		// Token: 0x1700DF96 RID: 57238
		// (get) Token: 0x060357F7 RID: 219127 RVA: 0x0072C162 File Offset: 0x0072A362
		// (set) Token: 0x060357F8 RID: 219128 RVA: 0x0072C16A File Offset: 0x0072A36A
		public ETargetEntityType Type { get; set; }

		// Token: 0x060357F9 RID: 219129 RVA: 0x0072C173 File Offset: 0x0072A373
		public ISelfEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
