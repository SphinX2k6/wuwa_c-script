using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694A RID: 26954
	public class IChangeElementalBoxStateTargetT
	{
		// Token: 0x1700C66C RID: 50796
		// (get) Token: 0x0602E348 RID: 189256 RVA: 0x0064FC02 File Offset: 0x0064DE02
		// (set) Token: 0x0602E349 RID: 189257 RVA: 0x0064FC0A File Offset: 0x0064DE0A
		public EChangeElementalBoxStateTargetType Type { get; set; }

		// Token: 0x0602E34A RID: 189258 RVA: 0x0064FC13 File Offset: 0x0064DE13
		public IChangeElementalBoxStateTargetT()
		{
			this.Type = EChangeElementalBoxStateTargetType.Player;
		}
	}
}
