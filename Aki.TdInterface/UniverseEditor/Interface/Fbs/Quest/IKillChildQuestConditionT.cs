using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC7 RID: 16071
	public class IKillChildQuestConditionT
	{
		// Token: 0x17006F91 RID: 28561
		// (get) Token: 0x06016B97 RID: 93079 RVA: 0x003480C9 File Offset: 0x003462C9
		// (set) Token: 0x06016B98 RID: 93080 RVA: 0x003480D1 File Offset: 0x003462D1
		public EChildQuest Type { get; set; }

		// Token: 0x17006F92 RID: 28562
		// (get) Token: 0x06016B99 RID: 93081 RVA: 0x003480DA File Offset: 0x003462DA
		// (set) Token: 0x06016B9A RID: 93082 RVA: 0x003480E2 File Offset: 0x003462E2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006F93 RID: 28563
		// (get) Token: 0x06016B9B RID: 93083 RVA: 0x003480EB File Offset: 0x003462EB
		// (set) Token: 0x06016B9C RID: 93084 RVA: 0x003480F3 File Offset: 0x003462F3
		public List<int> ExistTargets { get; set; }

		// Token: 0x17006F94 RID: 28564
		// (get) Token: 0x06016B9D RID: 93085 RVA: 0x003480FC File Offset: 0x003462FC
		// (set) Token: 0x06016B9E RID: 93086 RVA: 0x00348104 File Offset: 0x00346304
		public List<int> TargetsToAwake { get; set; }

		// Token: 0x17006F95 RID: 28565
		// (get) Token: 0x06016B9F RID: 93087 RVA: 0x0034810D File Offset: 0x0034630D
		// (set) Token: 0x06016BA0 RID: 93088 RVA: 0x00348115 File Offset: 0x00346315
		public TVarRefUnion PrefabVar { get; set; }

		// Token: 0x17006F96 RID: 28566
		// (get) Token: 0x06016BA1 RID: 93089 RVA: 0x0034811E File Offset: 0x0034631E
		// (set) Token: 0x06016BA2 RID: 93090 RVA: 0x00348126 File Offset: 0x00346326
		public List<IEntityDeadPositionT> EntityDeadPositions { get; set; }

		// Token: 0x17006F97 RID: 28567
		// (get) Token: 0x06016BA3 RID: 93091 RVA: 0x0034812F File Offset: 0x0034632F
		// (set) Token: 0x06016BA4 RID: 93092 RVA: 0x00348137 File Offset: 0x00346337
		public byte NullMask { get; set; }

		// Token: 0x06016BA5 RID: 93093 RVA: 0x00348140 File Offset: 0x00346340
		public IKillChildQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ExistTargets = null;
			this.TargetsToAwake = null;
			this.PrefabVar = null;
			this.EntityDeadPositions = null;
			this.NullMask = 0;
		}
	}
}
