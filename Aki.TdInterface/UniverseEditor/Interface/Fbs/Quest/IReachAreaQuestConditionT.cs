using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200406B RID: 16491
	public class IReachAreaQuestConditionT
	{
		// Token: 0x17007451 RID: 29777
		// (get) Token: 0x06017F69 RID: 98153 RVA: 0x00375729 File Offset: 0x00373929
		// (set) Token: 0x06017F6A RID: 98154 RVA: 0x00375731 File Offset: 0x00373931
		public EChildQuest Type { get; set; }

		// Token: 0x17007452 RID: 29778
		// (get) Token: 0x06017F6B RID: 98155 RVA: 0x0037573A File Offset: 0x0037393A
		// (set) Token: 0x06017F6C RID: 98156 RVA: 0x00375742 File Offset: 0x00373942
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007453 RID: 29779
		// (get) Token: 0x06017F6D RID: 98157 RVA: 0x0037574B File Offset: 0x0037394B
		// (set) Token: 0x06017F6E RID: 98158 RVA: 0x00375753 File Offset: 0x00373953
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17007454 RID: 29780
		// (get) Token: 0x06017F6F RID: 98159 RVA: 0x0037575C File Offset: 0x0037395C
		// (set) Token: 0x06017F70 RID: 98160 RVA: 0x00375764 File Offset: 0x00373964
		public int Range { get; set; }

		// Token: 0x17007455 RID: 29781
		// (get) Token: 0x06017F71 RID: 98161 RVA: 0x0037576D File Offset: 0x0037396D
		// (set) Token: 0x06017F72 RID: 98162 RVA: 0x00375775 File Offset: 0x00373975
		public int EntityId { get; set; }

		// Token: 0x17007456 RID: 29782
		// (get) Token: 0x06017F73 RID: 98163 RVA: 0x0037577E File Offset: 0x0037397E
		// (set) Token: 0x06017F74 RID: 98164 RVA: 0x00375786 File Offset: 0x00373986
		public int RangeEntityId { get; set; }

		// Token: 0x17007457 RID: 29783
		// (get) Token: 0x06017F75 RID: 98165 RVA: 0x0037578F File Offset: 0x0037398F
		// (set) Token: 0x06017F76 RID: 98166 RVA: 0x00375797 File Offset: 0x00373997
		public List<int> RangeEntities { get; set; }

		// Token: 0x17007458 RID: 29784
		// (get) Token: 0x06017F77 RID: 98167 RVA: 0x003757A0 File Offset: 0x003739A0
		// (set) Token: 0x06017F78 RID: 98168 RVA: 0x003757A8 File Offset: 0x003739A8
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17007459 RID: 29785
		// (get) Token: 0x06017F79 RID: 98169 RVA: 0x003757B1 File Offset: 0x003739B1
		// (set) Token: 0x06017F7A RID: 98170 RVA: 0x003757B9 File Offset: 0x003739B9
		public string EffectPath { get; set; }

		// Token: 0x1700745A RID: 29786
		// (get) Token: 0x06017F7B RID: 98171 RVA: 0x003757C2 File Offset: 0x003739C2
		// (set) Token: 0x06017F7C RID: 98172 RVA: 0x003757CA File Offset: 0x003739CA
		public byte NullMask { get; set; }

		// Token: 0x06017F7D RID: 98173 RVA: 0x003757D4 File Offset: 0x003739D4
		public IReachAreaQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Pos = null;
			this.Range = 0;
			this.EntityId = 0;
			this.RangeEntityId = 0;
			this.RangeEntities = null;
			this.MatchRoleOption = null;
			this.EffectPath = null;
			this.NullMask = 0;
		}
	}
}
