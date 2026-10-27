using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006111 RID: 24849
	public class IActorVisibilityT
	{
		// Token: 0x1700B722 RID: 46882
		// (get) Token: 0x0602A757 RID: 173911 RVA: 0x005D943B File Offset: 0x005D763B
		// (set) Token: 0x0602A758 RID: 173912 RVA: 0x005D9443 File Offset: 0x005D7643
		public int ActorIndex { get; set; }

		// Token: 0x1700B723 RID: 46883
		// (get) Token: 0x0602A759 RID: 173913 RVA: 0x005D944C File Offset: 0x005D764C
		// (set) Token: 0x0602A75A RID: 173914 RVA: 0x005D9454 File Offset: 0x005D7654
		public EActorVisibilityPlayMode PlayMode { get; set; }

		// Token: 0x1700B724 RID: 46884
		// (get) Token: 0x0602A75B RID: 173915 RVA: 0x005D945D File Offset: 0x005D765D
		// (set) Token: 0x0602A75C RID: 173916 RVA: 0x005D9465 File Offset: 0x005D7665
		public IActorVisibilityEffectDefaultT Effect { get; set; }

		// Token: 0x1700B725 RID: 46885
		// (get) Token: 0x0602A75D RID: 173917 RVA: 0x005D946E File Offset: 0x005D766E
		// (set) Token: 0x0602A75E RID: 173918 RVA: 0x005D9476 File Offset: 0x005D7676
		public float FadeDuration { get; set; }

		// Token: 0x1700B726 RID: 46886
		// (get) Token: 0x0602A75F RID: 173919 RVA: 0x005D947F File Offset: 0x005D767F
		// (set) Token: 0x0602A760 RID: 173920 RVA: 0x005D9487 File Offset: 0x005D7687
		public float DelayTime { get; set; }

		// Token: 0x1700B727 RID: 46887
		// (get) Token: 0x0602A761 RID: 173921 RVA: 0x005D9490 File Offset: 0x005D7690
		// (set) Token: 0x0602A762 RID: 173922 RVA: 0x005D9498 File Offset: 0x005D7698
		public byte NullMask { get; set; }

		// Token: 0x0602A763 RID: 173923 RVA: 0x005D94A1 File Offset: 0x005D76A1
		public IActorVisibilityT()
		{
			this.ActorIndex = 0;
			this.PlayMode = EActorVisibilityPlayMode.FadeIn;
			this.Effect = null;
			this.FadeDuration = 0f;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
