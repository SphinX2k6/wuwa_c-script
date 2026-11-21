using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006773 RID: 26483
	public class IActorVisibilityT
	{
		// Token: 0x1700C08D RID: 49293
		// (get) Token: 0x0602CE38 RID: 183864 RVA: 0x006233E3 File Offset: 0x006215E3
		// (set) Token: 0x0602CE39 RID: 183865 RVA: 0x006233EB File Offset: 0x006215EB
		public int ActorIndex { get; set; }

		// Token: 0x1700C08E RID: 49294
		// (get) Token: 0x0602CE3A RID: 183866 RVA: 0x006233F4 File Offset: 0x006215F4
		// (set) Token: 0x0602CE3B RID: 183867 RVA: 0x006233FC File Offset: 0x006215FC
		public EActorVisibilityPlayMode PlayMode { get; set; }

		// Token: 0x1700C08F RID: 49295
		// (get) Token: 0x0602CE3C RID: 183868 RVA: 0x00623405 File Offset: 0x00621605
		// (set) Token: 0x0602CE3D RID: 183869 RVA: 0x0062340D File Offset: 0x0062160D
		public IActorVisibilityEffectDefaultT Effect { get; set; }

		// Token: 0x1700C090 RID: 49296
		// (get) Token: 0x0602CE3E RID: 183870 RVA: 0x00623416 File Offset: 0x00621616
		// (set) Token: 0x0602CE3F RID: 183871 RVA: 0x0062341E File Offset: 0x0062161E
		public float FadeDuration { get; set; }

		// Token: 0x1700C091 RID: 49297
		// (get) Token: 0x0602CE40 RID: 183872 RVA: 0x00623427 File Offset: 0x00621627
		// (set) Token: 0x0602CE41 RID: 183873 RVA: 0x0062342F File Offset: 0x0062162F
		public float DelayTime { get; set; }

		// Token: 0x1700C092 RID: 49298
		// (get) Token: 0x0602CE42 RID: 183874 RVA: 0x00623438 File Offset: 0x00621638
		// (set) Token: 0x0602CE43 RID: 183875 RVA: 0x00623440 File Offset: 0x00621640
		public byte NullMask { get; set; }

		// Token: 0x0602CE44 RID: 183876 RVA: 0x00623449 File Offset: 0x00621649
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
