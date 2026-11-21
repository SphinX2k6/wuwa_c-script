using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007196 RID: 29078
	public class IMaskTransitionT
	{
		// Token: 0x1700D4DD RID: 54493
		// (get) Token: 0x060328DF RID: 207071 RVA: 0x006D4E2A File Offset: 0x006D302A
		// (set) Token: 0x060328E0 RID: 207072 RVA: 0x006D4E32 File Offset: 0x006D3032
		public ELevelSequenceTransition Type { get; set; }

		// Token: 0x1700D4DE RID: 54494
		// (get) Token: 0x060328E1 RID: 207073 RVA: 0x006D4E3B File Offset: 0x006D303B
		// (set) Token: 0x060328E2 RID: 207074 RVA: 0x006D4E43 File Offset: 0x006D3043
		public float Duration { get; set; }

		// Token: 0x1700D4DF RID: 54495
		// (get) Token: 0x060328E3 RID: 207075 RVA: 0x006D4E4C File Offset: 0x006D304C
		// (set) Token: 0x060328E4 RID: 207076 RVA: 0x006D4E54 File Offset: 0x006D3054
		public ETransitionMask Mask { get; set; }

		// Token: 0x1700D4E0 RID: 54496
		// (get) Token: 0x060328E5 RID: 207077 RVA: 0x006D4E5D File Offset: 0x006D305D
		// (set) Token: 0x060328E6 RID: 207078 RVA: 0x006D4E65 File Offset: 0x006D3065
		public IEaseDataT FadeIn { get; set; }

		// Token: 0x1700D4E1 RID: 54497
		// (get) Token: 0x060328E7 RID: 207079 RVA: 0x006D4E6E File Offset: 0x006D306E
		// (set) Token: 0x060328E8 RID: 207080 RVA: 0x006D4E76 File Offset: 0x006D3076
		public IEaseDataT FadeOut { get; set; }

		// Token: 0x1700D4E2 RID: 54498
		// (get) Token: 0x060328E9 RID: 207081 RVA: 0x006D4E7F File Offset: 0x006D307F
		// (set) Token: 0x060328EA RID: 207082 RVA: 0x006D4E87 File Offset: 0x006D3087
		public byte NullMask { get; set; }

		// Token: 0x060328EB RID: 207083 RVA: 0x006D4E90 File Offset: 0x006D3090
		public IMaskTransitionT()
		{
			this.Type = ELevelSequenceTransition.Camera;
			this.Duration = 0f;
			this.Mask = ETransitionMask.BlackMask;
			this.FadeIn = null;
			this.FadeOut = null;
			this.NullMask = 0;
		}
	}
}
