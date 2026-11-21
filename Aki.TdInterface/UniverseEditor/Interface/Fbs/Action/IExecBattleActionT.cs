using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7A RID: 28026
	public class IExecBattleActionT
	{
		// Token: 0x1700CDA0 RID: 52640
		// (get) Token: 0x060305DA RID: 198106 RVA: 0x00692959 File Offset: 0x00690B59
		// (set) Token: 0x060305DB RID: 198107 RVA: 0x00692961 File Offset: 0x00690B61
		public TExecBattleOptionUnion BattleOption { get; set; }

		// Token: 0x060305DC RID: 198108 RVA: 0x0069296A File Offset: 0x00690B6A
		public IExecBattleActionT()
		{
			this.BattleOption = null;
		}
	}
}
