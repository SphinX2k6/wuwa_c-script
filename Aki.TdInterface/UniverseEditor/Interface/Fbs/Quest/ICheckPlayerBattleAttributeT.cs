using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D56 RID: 15702
	public class ICheckPlayerBattleAttributeT
	{
		// Token: 0x17006BC7 RID: 27591
		// (get) Token: 0x06015B93 RID: 88979 RVA: 0x0032243F File Offset: 0x0032063F
		// (set) Token: 0x06015B94 RID: 88980 RVA: 0x00322447 File Offset: 0x00320647
		public ETargetBattleAttribute Type { get; set; }

		// Token: 0x17006BC8 RID: 27592
		// (get) Token: 0x06015B95 RID: 88981 RVA: 0x00322450 File Offset: 0x00320650
		// (set) Token: 0x06015B96 RID: 88982 RVA: 0x00322458 File Offset: 0x00320658
		public IHealthAttributeToTargetT Option { get; set; }

		// Token: 0x06015B97 RID: 88983 RVA: 0x00322461 File Offset: 0x00320661
		public ICheckPlayerBattleAttributeT()
		{
			this.Type = ETargetBattleAttribute.Player;
			this.Option = null;
		}
	}
}
