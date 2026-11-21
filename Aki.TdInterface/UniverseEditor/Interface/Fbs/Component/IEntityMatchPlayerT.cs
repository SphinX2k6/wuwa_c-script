using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005704 RID: 22276
	public class IEntityMatchPlayerT
	{
		// Token: 0x1700A098 RID: 41112
		// (get) Token: 0x06023C4B RID: 146507 RVA: 0x004EAC63 File Offset: 0x004E8E63
		// (set) Token: 0x06023C4C RID: 146508 RVA: 0x004EAC6B File Offset: 0x004E8E6B
		public EEntityMatchType Type { get; set; }

		// Token: 0x1700A099 RID: 41113
		// (get) Token: 0x06023C4D RID: 146509 RVA: 0x004EAC74 File Offset: 0x004E8E74
		// (set) Token: 0x06023C4E RID: 146510 RVA: 0x004EAC7C File Offset: 0x004E8E7C
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700A09A RID: 41114
		// (get) Token: 0x06023C4F RID: 146511 RVA: 0x004EAC85 File Offset: 0x004E8E85
		// (set) Token: 0x06023C50 RID: 146512 RVA: 0x004EAC8D File Offset: 0x004E8E8D
		public bool ChangeRoleTrigger { get; set; }

		// Token: 0x1700A09B RID: 41115
		// (get) Token: 0x06023C51 RID: 146513 RVA: 0x004EAC96 File Offset: 0x004E8E96
		// (set) Token: 0x06023C52 RID: 146514 RVA: 0x004EAC9E File Offset: 0x004E8E9E
		public byte NullMask { get; set; }

		// Token: 0x06023C53 RID: 146515 RVA: 0x004EACA7 File Offset: 0x004E8EA7
		public IEntityMatchPlayerT()
		{
			this.Type = EEntityMatchType.Player;
			this.MatchRoleOption = null;
			this.ChangeRoleTrigger = false;
			this.NullMask = 0;
		}
	}
}
