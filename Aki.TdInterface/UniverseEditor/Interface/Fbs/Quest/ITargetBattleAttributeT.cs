using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200460B RID: 17931
	public class ITargetBattleAttributeT
	{
		// Token: 0x17007D74 RID: 32116
		// (get) Token: 0x0601A392 RID: 107410 RVA: 0x003BBF76 File Offset: 0x003BA176
		// (set) Token: 0x0601A393 RID: 107411 RVA: 0x003BBF7E File Offset: 0x003BA17E
		public ETargetBattleAttribute Type { get; set; }

		// Token: 0x0601A394 RID: 107412 RVA: 0x003BBF87 File Offset: 0x003BA187
		public ITargetBattleAttributeT()
		{
			this.Type = ETargetBattleAttribute.Player;
		}
	}
}
