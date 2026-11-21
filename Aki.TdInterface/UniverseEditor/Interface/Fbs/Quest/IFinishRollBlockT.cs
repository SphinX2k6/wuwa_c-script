using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004284 RID: 17028
	public class IFinishRollBlockT
	{
		// Token: 0x1700744F RID: 29775
		// (get) Token: 0x06017C9F RID: 97439 RVA: 0x00365738 File Offset: 0x00363938
		// (set) Token: 0x06017CA0 RID: 97440 RVA: 0x00365740 File Offset: 0x00363940
		public EChildQuest Type { get; set; }

		// Token: 0x17007450 RID: 29776
		// (get) Token: 0x06017CA1 RID: 97441 RVA: 0x00365749 File Offset: 0x00363949
		// (set) Token: 0x06017CA2 RID: 97442 RVA: 0x00365751 File Offset: 0x00363951
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007451 RID: 29777
		// (get) Token: 0x06017CA3 RID: 97443 RVA: 0x0036575A File Offset: 0x0036395A
		// (set) Token: 0x06017CA4 RID: 97444 RVA: 0x00365762 File Offset: 0x00363962
		public int CenterEntityId { get; set; }

		// Token: 0x17007452 RID: 29778
		// (get) Token: 0x06017CA5 RID: 97445 RVA: 0x0036576B File Offset: 0x0036396B
		// (set) Token: 0x06017CA6 RID: 97446 RVA: 0x00365773 File Offset: 0x00363973
		public int InteractEntityId { get; set; }

		// Token: 0x17007453 RID: 29779
		// (get) Token: 0x06017CA7 RID: 97447 RVA: 0x0036577C File Offset: 0x0036397C
		// (set) Token: 0x06017CA8 RID: 97448 RVA: 0x00365784 File Offset: 0x00363984
		public List<ERollBlockInteractType> InteractTypes { get; set; }

		// Token: 0x17007454 RID: 29780
		// (get) Token: 0x06017CA9 RID: 97449 RVA: 0x0036578D File Offset: 0x0036398D
		// (set) Token: 0x06017CAA RID: 97450 RVA: 0x00365795 File Offset: 0x00363995
		public List<TRollBlockLaunchMethodUnion> LaunchMethod { get; set; }

		// Token: 0x17007455 RID: 29781
		// (get) Token: 0x06017CAB RID: 97451 RVA: 0x0036579E File Offset: 0x0036399E
		// (set) Token: 0x06017CAC RID: 97452 RVA: 0x003657A6 File Offset: 0x003639A6
		public int RollBlockGroupId { get; set; }

		// Token: 0x17007456 RID: 29782
		// (get) Token: 0x06017CAD RID: 97453 RVA: 0x003657AF File Offset: 0x003639AF
		// (set) Token: 0x06017CAE RID: 97454 RVA: 0x003657B7 File Offset: 0x003639B7
		public int RollBlockTemplateId { get; set; }

		// Token: 0x17007457 RID: 29783
		// (get) Token: 0x06017CAF RID: 97455 RVA: 0x003657C0 File Offset: 0x003639C0
		// (set) Token: 0x06017CB0 RID: 97456 RVA: 0x003657C8 File Offset: 0x003639C8
		public TVarRefUnion CurrentDifficultyVarRef { get; set; }

		// Token: 0x17007458 RID: 29784
		// (get) Token: 0x06017CB1 RID: 97457 RVA: 0x003657D1 File Offset: 0x003639D1
		// (set) Token: 0x06017CB2 RID: 97458 RVA: 0x003657D9 File Offset: 0x003639D9
		public TVarRefUnion AllDifficultyCountVarRef { get; set; }

		// Token: 0x17007459 RID: 29785
		// (get) Token: 0x06017CB3 RID: 97459 RVA: 0x003657E2 File Offset: 0x003639E2
		// (set) Token: 0x06017CB4 RID: 97460 RVA: 0x003657EA File Offset: 0x003639EA
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x1700745A RID: 29786
		// (get) Token: 0x06017CB5 RID: 97461 RVA: 0x003657F3 File Offset: 0x003639F3
		// (set) Token: 0x06017CB6 RID: 97462 RVA: 0x003657FB File Offset: 0x003639FB
		public List<IActionInfoT> ExitActions { get; set; }

		// Token: 0x1700745B RID: 29787
		// (get) Token: 0x06017CB7 RID: 97463 RVA: 0x00365804 File Offset: 0x00363A04
		// (set) Token: 0x06017CB8 RID: 97464 RVA: 0x0036580C File Offset: 0x00363A0C
		public List<IActionInfoT> CompleteActions { get; set; }

		// Token: 0x1700745C RID: 29788
		// (get) Token: 0x06017CB9 RID: 97465 RVA: 0x00365815 File Offset: 0x00363A15
		// (set) Token: 0x06017CBA RID: 97466 RVA: 0x0036581D File Offset: 0x00363A1D
		public byte NullMask { get; set; }

		// Token: 0x06017CBB RID: 97467 RVA: 0x00365828 File Offset: 0x00363A28
		public IFinishRollBlockT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.CenterEntityId = 0;
			this.InteractEntityId = 0;
			this.InteractTypes = null;
			this.LaunchMethod = null;
			this.RollBlockGroupId = 0;
			this.RollBlockTemplateId = 0;
			this.CurrentDifficultyVarRef = null;
			this.AllDifficultyCountVarRef = null;
			this.EnterActions = null;
			this.ExitActions = null;
			this.CompleteActions = null;
			this.NullMask = 0;
		}
	}
}
