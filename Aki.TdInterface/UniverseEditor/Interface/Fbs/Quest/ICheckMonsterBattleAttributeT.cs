using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D53 RID: 15699
	public class ICheckMonsterBattleAttributeT
	{
		// Token: 0x17006BC1 RID: 27585
		// (get) Token: 0x06015B7B RID: 88955 RVA: 0x0032218A File Offset: 0x0032038A
		// (set) Token: 0x06015B7C RID: 88956 RVA: 0x00322192 File Offset: 0x00320392
		public ETargetBattleAttribute Type { get; set; }

		// Token: 0x17006BC2 RID: 27586
		// (get) Token: 0x06015B7D RID: 88957 RVA: 0x0032219B File Offset: 0x0032039B
		// (set) Token: 0x06015B7E RID: 88958 RVA: 0x003221A3 File Offset: 0x003203A3
		public IHealthAttributeToTargetT Option { get; set; }

		// Token: 0x17006BC3 RID: 27587
		// (get) Token: 0x06015B7F RID: 88959 RVA: 0x003221AC File Offset: 0x003203AC
		// (set) Token: 0x06015B80 RID: 88960 RVA: 0x003221B4 File Offset: 0x003203B4
		public List<int> EntityIds { get; set; }

		// Token: 0x06015B81 RID: 88961 RVA: 0x003221BD File Offset: 0x003203BD
		public ICheckMonsterBattleAttributeT()
		{
			this.Type = ETargetBattleAttribute.Player;
			this.Option = null;
			this.EntityIds = null;
		}
	}
}
