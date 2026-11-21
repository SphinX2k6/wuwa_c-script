using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004287 RID: 17031
	public class IFinishSurvivorsRougeConditionT
	{
		// Token: 0x17007462 RID: 29794
		// (get) Token: 0x06017CE1 RID: 97505 RVA: 0x003662B9 File Offset: 0x003644B9
		// (set) Token: 0x06017CE2 RID: 97506 RVA: 0x003662C1 File Offset: 0x003644C1
		public EChildQuest Type { get; set; }

		// Token: 0x17007463 RID: 29795
		// (get) Token: 0x06017CE3 RID: 97507 RVA: 0x003662CA File Offset: 0x003644CA
		// (set) Token: 0x06017CE4 RID: 97508 RVA: 0x003662D2 File Offset: 0x003644D2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007464 RID: 29796
		// (get) Token: 0x06017CE5 RID: 97509 RVA: 0x003662DB File Offset: 0x003644DB
		// (set) Token: 0x06017CE6 RID: 97510 RVA: 0x003662E3 File Offset: 0x003644E3
		public TSurvivorsRougeConditionStepUnion Step { get; set; }

		// Token: 0x17007465 RID: 29797
		// (get) Token: 0x06017CE7 RID: 97511 RVA: 0x003662EC File Offset: 0x003644EC
		// (set) Token: 0x06017CE8 RID: 97512 RVA: 0x003662F4 File Offset: 0x003644F4
		public TVarRefUnion Batch { get; set; }

		// Token: 0x06017CE9 RID: 97513 RVA: 0x003662FD File Offset: 0x003644FD
		public IFinishSurvivorsRougeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
		}
	}
}
