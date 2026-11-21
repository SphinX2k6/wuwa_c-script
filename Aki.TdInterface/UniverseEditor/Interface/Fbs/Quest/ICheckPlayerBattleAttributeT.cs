using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416D RID: 16749
	public class ICheckPlayerBattleAttributeT
	{
		// Token: 0x17007181 RID: 29057
		// (get) Token: 0x060170CB RID: 94411 RVA: 0x003496B7 File Offset: 0x003478B7
		// (set) Token: 0x060170CC RID: 94412 RVA: 0x003496BF File Offset: 0x003478BF
		public ETargetBattleAttribute Type { get; set; }

		// Token: 0x17007182 RID: 29058
		// (get) Token: 0x060170CD RID: 94413 RVA: 0x003496C8 File Offset: 0x003478C8
		// (set) Token: 0x060170CE RID: 94414 RVA: 0x003496D0 File Offset: 0x003478D0
		public IHealthAttributeToTargetT Option { get; set; }

		// Token: 0x060170CF RID: 94415 RVA: 0x003496D9 File Offset: 0x003478D9
		public ICheckPlayerBattleAttributeT()
		{
			this.Type = ETargetBattleAttribute.Player;
			this.Option = null;
		}
	}
}
