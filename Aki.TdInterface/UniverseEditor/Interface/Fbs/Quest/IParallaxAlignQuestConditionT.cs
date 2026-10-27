using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F6F RID: 16239
	public class IParallaxAlignQuestConditionT
	{
		// Token: 0x170070FD RID: 28925
		// (get) Token: 0x060171CE RID: 94670 RVA: 0x00354CEB File Offset: 0x00352EEB
		// (set) Token: 0x060171CF RID: 94671 RVA: 0x00354CF3 File Offset: 0x00352EF3
		public EChildQuest Type { get; set; }

		// Token: 0x170070FE RID: 28926
		// (get) Token: 0x060171D0 RID: 94672 RVA: 0x00354CFC File Offset: 0x00352EFC
		// (set) Token: 0x060171D1 RID: 94673 RVA: 0x00354D04 File Offset: 0x00352F04
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170070FF RID: 28927
		// (get) Token: 0x060171D2 RID: 94674 RVA: 0x00354D0D File Offset: 0x00352F0D
		// (set) Token: 0x060171D3 RID: 94675 RVA: 0x00354D15 File Offset: 0x00352F15
		public IVectorInfoT SourcePos { get; set; }

		// Token: 0x17007100 RID: 28928
		// (get) Token: 0x060171D4 RID: 94676 RVA: 0x00354D1E File Offset: 0x00352F1E
		// (set) Token: 0x060171D5 RID: 94677 RVA: 0x00354D26 File Offset: 0x00352F26
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x17007101 RID: 28929
		// (get) Token: 0x060171D6 RID: 94678 RVA: 0x00354D2F File Offset: 0x00352F2F
		// (set) Token: 0x060171D7 RID: 94679 RVA: 0x00354D37 File Offset: 0x00352F37
		public float ErrorRange { get; set; }

		// Token: 0x17007102 RID: 28930
		// (get) Token: 0x060171D8 RID: 94680 RVA: 0x00354D40 File Offset: 0x00352F40
		// (set) Token: 0x060171D9 RID: 94681 RVA: 0x00354D48 File Offset: 0x00352F48
		public int BallEntity { get; set; }

		// Token: 0x17007103 RID: 28931
		// (get) Token: 0x060171DA RID: 94682 RVA: 0x00354D51 File Offset: 0x00352F51
		// (set) Token: 0x060171DB RID: 94683 RVA: 0x00354D59 File Offset: 0x00352F59
		public float BrightnessAdjustRange { get; set; }

		// Token: 0x17007104 RID: 28932
		// (get) Token: 0x060171DC RID: 94684 RVA: 0x00354D62 File Offset: 0x00352F62
		// (set) Token: 0x060171DD RID: 94685 RVA: 0x00354D6A File Offset: 0x00352F6A
		public float DefaultBrightness { get; set; }

		// Token: 0x17007105 RID: 28933
		// (get) Token: 0x060171DE RID: 94686 RVA: 0x00354D73 File Offset: 0x00352F73
		// (set) Token: 0x060171DF RID: 94687 RVA: 0x00354D7B File Offset: 0x00352F7B
		public IColorT FinalColor { get; set; }

		// Token: 0x17007106 RID: 28934
		// (get) Token: 0x060171E0 RID: 94688 RVA: 0x00354D84 File Offset: 0x00352F84
		// (set) Token: 0x060171E1 RID: 94689 RVA: 0x00354D8C File Offset: 0x00352F8C
		public float FixationTime { get; set; }

		// Token: 0x17007107 RID: 28935
		// (get) Token: 0x060171E2 RID: 94690 RVA: 0x00354D95 File Offset: 0x00352F95
		// (set) Token: 0x060171E3 RID: 94691 RVA: 0x00354D9D File Offset: 0x00352F9D
		public byte NullMask { get; set; }

		// Token: 0x060171E4 RID: 94692 RVA: 0x00354DA8 File Offset: 0x00352FA8
		public IParallaxAlignQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SourcePos = null;
			this.TargetPos = null;
			this.ErrorRange = 0f;
			this.BallEntity = 0;
			this.BrightnessAdjustRange = 0f;
			this.DefaultBrightness = 0f;
			this.FinalColor = null;
			this.FixationTime = 0f;
			this.NullMask = 0;
		}
	}
}
