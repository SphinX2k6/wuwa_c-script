using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D86 RID: 28038
	public class IExecClientBattleActionT
	{
		// Token: 0x1700CDAB RID: 52651
		// (get) Token: 0x0603063D RID: 198205 RVA: 0x006936F5 File Offset: 0x006918F5
		// (set) Token: 0x0603063E RID: 198206 RVA: 0x006936FD File Offset: 0x006918FD
		public TExecClientBattleOptionUnion ClientBattleOption { get; set; }

		// Token: 0x0603063F RID: 198207 RVA: 0x00693706 File Offset: 0x00691906
		public IExecClientBattleActionT()
		{
			this.ClientBattleOption = null;
		}
	}
}
