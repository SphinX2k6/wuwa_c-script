using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F8 RID: 20728
	public class IElementalBoxStateTargetT
	{
		// Token: 0x1700948E RID: 38030
		// (get) Token: 0x06020937 RID: 133431 RVA: 0x004849BA File Offset: 0x00482BBA
		// (set) Token: 0x06020938 RID: 133432 RVA: 0x004849C2 File Offset: 0x00482BC2
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x06020939 RID: 133433 RVA: 0x004849CB File Offset: 0x00482BCB
		public IElementalBoxStateTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
		}
	}
}
