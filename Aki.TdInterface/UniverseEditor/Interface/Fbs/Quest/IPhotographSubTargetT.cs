using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C5 RID: 17349
	public class IPhotographSubTargetT
	{
		// Token: 0x1700777E RID: 30590
		// (get) Token: 0x06018A0D RID: 100877 RVA: 0x0038358E File Offset: 0x0038178E
		// (set) Token: 0x06018A0E RID: 100878 RVA: 0x00383596 File Offset: 0x00381796
		public EPhotographSubTargetType Type { get; set; }

		// Token: 0x06018A0F RID: 100879 RVA: 0x0038359F File Offset: 0x0038179F
		public IPhotographSubTargetT()
		{
			this.Type = EPhotographSubTargetType.SpecificRole;
		}
	}
}
