using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D1 RID: 17361
	public class IPhotographTargetT
	{
		// Token: 0x17007795 RID: 30613
		// (get) Token: 0x06018A69 RID: 100969 RVA: 0x00383F92 File Offset: 0x00382192
		// (set) Token: 0x06018A6A RID: 100970 RVA: 0x00383F9A File Offset: 0x0038219A
		public EPhotographTargetType Type { get; set; }

		// Token: 0x06018A6B RID: 100971 RVA: 0x00383FA3 File Offset: 0x003821A3
		public IPhotographTargetT()
		{
			this.Type = EPhotographTargetType.Player;
		}
	}
}
