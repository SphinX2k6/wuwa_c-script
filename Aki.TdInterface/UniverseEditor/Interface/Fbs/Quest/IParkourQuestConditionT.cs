using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F75 RID: 16245
	public class IParkourQuestConditionT
	{
		// Token: 0x17007162 RID: 29026
		// (get) Token: 0x060172F6 RID: 94966 RVA: 0x00358980 File Offset: 0x00356B80
		// (set) Token: 0x060172F7 RID: 94967 RVA: 0x00358988 File Offset: 0x00356B88
		public EChildQuest Type { get; set; }

		// Token: 0x17007163 RID: 29027
		// (get) Token: 0x060172F8 RID: 94968 RVA: 0x00358991 File Offset: 0x00356B91
		// (set) Token: 0x060172F9 RID: 94969 RVA: 0x00358999 File Offset: 0x00356B99
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007164 RID: 29028
		// (get) Token: 0x060172FA RID: 94970 RVA: 0x003589A2 File Offset: 0x00356BA2
		// (set) Token: 0x060172FB RID: 94971 RVA: 0x003589AA File Offset: 0x00356BAA
		public string Config { get; set; }

		// Token: 0x17007165 RID: 29029
		// (get) Token: 0x060172FC RID: 94972 RVA: 0x003589B3 File Offset: 0x00356BB3
		// (set) Token: 0x060172FD RID: 94973 RVA: 0x003589BB File Offset: 0x00356BBB
		public int SplineEntityId { get; set; }

		// Token: 0x17007166 RID: 29030
		// (get) Token: 0x060172FE RID: 94974 RVA: 0x003589C4 File Offset: 0x00356BC4
		// (set) Token: 0x060172FF RID: 94975 RVA: 0x003589CC File Offset: 0x00356BCC
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17007167 RID: 29031
		// (get) Token: 0x06017300 RID: 94976 RVA: 0x003589D5 File Offset: 0x00356BD5
		// (set) Token: 0x06017301 RID: 94977 RVA: 0x003589DD File Offset: 0x00356BDD
		public byte NullMask { get; set; }

		// Token: 0x06017302 RID: 94978 RVA: 0x003589E6 File Offset: 0x00356BE6
		public IParkourQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Config = null;
			this.SplineEntityId = 0;
			this.MatchRoleOption = null;
			this.NullMask = 0;
		}
	}
}
