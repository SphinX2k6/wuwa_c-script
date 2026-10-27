using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E49 RID: 15945
	public class IFinishRollBlockT
	{
		// Token: 0x17006E6B RID: 28267
		// (get) Token: 0x06016678 RID: 91768 RVA: 0x0033CC08 File Offset: 0x0033AE08
		// (set) Token: 0x06016679 RID: 91769 RVA: 0x0033CC10 File Offset: 0x0033AE10
		public EChildQuest Type { get; set; }

		// Token: 0x17006E6C RID: 28268
		// (get) Token: 0x0601667A RID: 91770 RVA: 0x0033CC19 File Offset: 0x0033AE19
		// (set) Token: 0x0601667B RID: 91771 RVA: 0x0033CC21 File Offset: 0x0033AE21
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E6D RID: 28269
		// (get) Token: 0x0601667C RID: 91772 RVA: 0x0033CC2A File Offset: 0x0033AE2A
		// (set) Token: 0x0601667D RID: 91773 RVA: 0x0033CC32 File Offset: 0x0033AE32
		public int CenterEntityId { get; set; }

		// Token: 0x17006E6E RID: 28270
		// (get) Token: 0x0601667E RID: 91774 RVA: 0x0033CC3B File Offset: 0x0033AE3B
		// (set) Token: 0x0601667F RID: 91775 RVA: 0x0033CC43 File Offset: 0x0033AE43
		public int InteractEntityId { get; set; }

		// Token: 0x17006E6F RID: 28271
		// (get) Token: 0x06016680 RID: 91776 RVA: 0x0033CC4C File Offset: 0x0033AE4C
		// (set) Token: 0x06016681 RID: 91777 RVA: 0x0033CC54 File Offset: 0x0033AE54
		public List<ERollBlockInteractType> InteractTypes { get; set; }

		// Token: 0x17006E70 RID: 28272
		// (get) Token: 0x06016682 RID: 91778 RVA: 0x0033CC5D File Offset: 0x0033AE5D
		// (set) Token: 0x06016683 RID: 91779 RVA: 0x0033CC65 File Offset: 0x0033AE65
		public List<TRollBlockLaunchMethodUnion> LaunchMethod { get; set; }

		// Token: 0x17006E71 RID: 28273
		// (get) Token: 0x06016684 RID: 91780 RVA: 0x0033CC6E File Offset: 0x0033AE6E
		// (set) Token: 0x06016685 RID: 91781 RVA: 0x0033CC76 File Offset: 0x0033AE76
		public int RollBlockGroupId { get; set; }

		// Token: 0x17006E72 RID: 28274
		// (get) Token: 0x06016686 RID: 91782 RVA: 0x0033CC7F File Offset: 0x0033AE7F
		// (set) Token: 0x06016687 RID: 91783 RVA: 0x0033CC87 File Offset: 0x0033AE87
		public int RollBlockTemplateId { get; set; }

		// Token: 0x17006E73 RID: 28275
		// (get) Token: 0x06016688 RID: 91784 RVA: 0x0033CC90 File Offset: 0x0033AE90
		// (set) Token: 0x06016689 RID: 91785 RVA: 0x0033CC98 File Offset: 0x0033AE98
		public TVarRefUnion CurrentDifficultyVarRef { get; set; }

		// Token: 0x17006E74 RID: 28276
		// (get) Token: 0x0601668A RID: 91786 RVA: 0x0033CCA1 File Offset: 0x0033AEA1
		// (set) Token: 0x0601668B RID: 91787 RVA: 0x0033CCA9 File Offset: 0x0033AEA9
		public TVarRefUnion AllDifficultyCountVarRef { get; set; }

		// Token: 0x17006E75 RID: 28277
		// (get) Token: 0x0601668C RID: 91788 RVA: 0x0033CCB2 File Offset: 0x0033AEB2
		// (set) Token: 0x0601668D RID: 91789 RVA: 0x0033CCBA File Offset: 0x0033AEBA
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x17006E76 RID: 28278
		// (get) Token: 0x0601668E RID: 91790 RVA: 0x0033CCC3 File Offset: 0x0033AEC3
		// (set) Token: 0x0601668F RID: 91791 RVA: 0x0033CCCB File Offset: 0x0033AECB
		public List<IActionInfoT> ExitActions { get; set; }

		// Token: 0x17006E77 RID: 28279
		// (get) Token: 0x06016690 RID: 91792 RVA: 0x0033CCD4 File Offset: 0x0033AED4
		// (set) Token: 0x06016691 RID: 91793 RVA: 0x0033CCDC File Offset: 0x0033AEDC
		public List<IActionInfoT> CompleteActions { get; set; }

		// Token: 0x17006E78 RID: 28280
		// (get) Token: 0x06016692 RID: 91794 RVA: 0x0033CCE5 File Offset: 0x0033AEE5
		// (set) Token: 0x06016693 RID: 91795 RVA: 0x0033CCED File Offset: 0x0033AEED
		public byte NullMask { get; set; }

		// Token: 0x06016694 RID: 91796 RVA: 0x0033CCF8 File Offset: 0x0033AEF8
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
