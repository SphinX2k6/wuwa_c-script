using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BE RID: 22462
	public class IFinishStateTriggerT
	{
		// Token: 0x1700A260 RID: 41568
		// (get) Token: 0x0602442F RID: 148527 RVA: 0x004FBCF7 File Offset: 0x004F9EF7
		// (set) Token: 0x06024430 RID: 148528 RVA: 0x004FBCFF File Offset: 0x004F9EFF
		public bool IsSilenceEntities { get; set; }

		// Token: 0x1700A261 RID: 41569
		// (get) Token: 0x06024431 RID: 148529 RVA: 0x004FBD08 File Offset: 0x004F9F08
		// (set) Token: 0x06024432 RID: 148530 RVA: 0x004FBD10 File Offset: 0x004F9F10
		public IEntityGroupConditionT GroupCondition { get; set; }

		// Token: 0x06024433 RID: 148531 RVA: 0x004FBD19 File Offset: 0x004F9F19
		public IFinishStateTriggerT()
		{
			this.IsSilenceEntities = false;
			this.GroupCondition = null;
		}
	}
}
